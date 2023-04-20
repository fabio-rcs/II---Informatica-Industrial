Imports System.IO.Ports
Imports System.Text

Public Class PortConfiguration
    '-----------------------------------------------------
    ' Initialization -------------------------------------
    '-----------------------------------------------------
    Private Sub PortConfiguratio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Port Configuration"
        ' Configure the comboboxes with the appropriate options

        ' CboxPort cfg
        Dim available_ports As Array = IO.Ports.SerialPort.GetPortNames
        Dim i As Integer
        For i = 0 To UBound(available_ports)
            cboxPort.Items.Add(available_ports(i))
        Next
        cboxPort.SelectedIndex = 0

        ' cboxBaudRate config
        cboxBaudRate.Items.Clear()
        cboxBaudRate.Items.Add("4800")
        cboxBaudRate.Items.Add("9600")
        cboxBaudRate.Items.Add("19200")
        cboxBaudRate.SelectedIndex = 1 'Define 9600 as default

        ' cboxParity config
        cboxParity.Items.Clear()
        cboxParity.Items.Add(IO.Ports.Parity.None)
        cboxParity.Items.Add(IO.Ports.Parity.Odd)
        cboxParity.Items.Add(IO.Ports.Parity.Even)
        cboxParity.SelectedIndex = 2 ' Define Odd as default

        ' cboxStopBits config
        cboxDataBits.Items.Clear()
        cboxDataBits.Items.Add("5")
        cboxDataBits.Items.Add("6")
        cboxDataBits.Items.Add("7")
        cboxDataBits.Items.Add("8")
        cboxDataBits.SelectedIndex = 3 ' Define 8 as default

        ' cboxStopBits config
        cboxStopBits.Items.Clear()
        cboxStopBits.Items.Add(IO.Ports.StopBits.One)
        cboxStopBits.Items.Add(IO.Ports.StopBits.OnePointFive)
        cboxStopBits.Items.Add(IO.Ports.StopBits.Two)
        cboxStopBits.Items.Add(IO.Ports.StopBits.None)
        cboxStopBits.SelectedIndex = 0 ' Define One as default

        ' cboxEncoding config
        cboxEncoding.Items.Clear()
        cboxEncoding.Items.Add("ASCII")
        cboxEncoding.Items.Add("BigEndianUnicode")
        cboxEncoding.Items.Add("Default")
        cboxEncoding.Items.Add("Unicode")
        cboxEncoding.Items.Add("UTF32")
        cboxEncoding.Items.Add("UTF7")
        cboxEncoding.Items.Add("UTF8")
        cboxEncoding.SelectedIndex = 6 ' Define UTF8 as default

        ' cboxHandshakeconfig
        cboxHandshake.Items.Clear()
        cboxHandshake.Items.Add(System.IO.Ports.Handshake.None)
        cboxHandshake.Items.Add(System.IO.Ports.Handshake.RequestToSend)
        cboxHandshake.Items.Add(System.IO.Ports.Handshake.RequestToSendXOnXOff)
        cboxHandshake.Items.Add(System.IO.Ports.Handshake.XOnXOff)
        cboxHandshake.SelectedIndex = 0 ' Define None as default

    End Sub

    '-----------------------------------------------------
    ' Button clicks routine ------------------------------
    '-----------------------------------------------------
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ModulePortParameters.cfg_is_valid = False
        Me.Close()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ' Copy the values of the comboboxes to the vars in Module

        ' Str to str is easy, no sweat bro
        ModulePortParameters.port = cboxPort.Text

        ' Str to int is automatic, also no sweat
        ModulePortParameters.baud_rate = cboxBaudRate.Text

        ' String to IO.Ports.Parity *Sweating beggins*
        Select Case cboxParity.Text
            Case "None"
                ModulePortParameters.parity = IO.Ports.Parity.None
            Case "Even"
                ModulePortParameters.parity = IO.Ports.Parity.Even
            Case "Odd"
                ModulePortParameters.parity = IO.Ports.Parity.Odd
        End Select

        ModulePortParameters.data_bits = cboxDataBits.Text

        Select Case cboxStopBits.Text
            Case "One"
                ModulePortParameters.stop_bits = IO.Ports.StopBits.One
            Case "OnePointFive"
                ModulePortParameters.stop_bits = IO.Ports.StopBits.OnePointFive
            Case "Two"
                ModulePortParameters.stop_bits = IO.Ports.StopBits.Two
            Case "None"
                ModulePortParameters.stop_bits = IO.Ports.StopBits.None
        End Select

        Select Case cboxEncoding.Text
            Case "ASCII"
                ModulePortParameters.encoding = System.Text.Encoding.ASCII
            Case "BigEndianUnicode"
                ModulePortParameters.encoding = System.Text.Encoding.BigEndianUnicode
            Case "Default"
                ModulePortParameters.encoding = System.Text.Encoding.Default
            Case "Unicode"
                ModulePortParameters.encoding = System.Text.Encoding.Unicode
            Case "UTF32"
                ModulePortParameters.encoding = System.Text.Encoding.UTF32
            Case "UTF7"
                ModulePortParameters.encoding = System.Text.Encoding.UTF7
            Case "UTF8"
                ModulePortParameters.encoding = System.Text.Encoding.UTF8
        End Select

        Select Case cboxHandshake.Text
            Case "None"
                ModulePortParameters.handshake = System.IO.Ports.Handshake.None
            Case "RequestToSend"
                ModulePortParameters.handshake = System.IO.Ports.Handshake.RequestToSend
            Case "RequestToSendXOnXOff"
                ModulePortParameters.handshake = System.IO.Ports.Handshake.RequestToSendXOnXOff
            Case "XOnXOff"
                ModulePortParameters.handshake = System.IO.Ports.Handshake.XOnXOff
        End Select

        ' Set flag for valid config
        ModulePortParameters.cfg_is_valid = True

        Me.Close()
    End Sub
End Class