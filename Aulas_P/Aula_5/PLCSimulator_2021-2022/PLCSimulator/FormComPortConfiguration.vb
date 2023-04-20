Public Class FormComPortConfiguration
    '------------------------------------
    'Initialization routines
    '------------------------------------

    Public Sub FormComPortConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configure the combo boxes with the appropriate options

        'ComboBox Port Configuration
        Dim available_ports As Array = IO.Ports.SerialPort.GetPortNames
        ComboBoxPort.Items.Clear()
        ComboBoxPort.Items.Add(My.Settings.Item("ComPortName"))

        Dim i As Integer 'cycle all available ports
        For i = 0 To UBound(available_ports)
            ComboBoxPort.Items.Add(available_ports(i))
        Next
        'ComboBoxPort.Items.Add("No com port") 'To make it work when not having any com port created
        ComboBoxPort.SelectedIndex = 0 'Default value

        'ComboBox Baud rate configuration
        ComboBoxBaudRate.Items.Clear()
        ComboBoxBaudRate.Items.Add("4800")
        ComboBoxBaudRate.Items.Add("9600")
        ComboBoxBaudRate.Items.Add("19200")
        'ComboBoxBaudRate.SelectedIndex = 1 'Default
        ComboBoxBaudRate.SelectedIndex = My.Settings.ComboBoxBaudRateIndex

        'ComboBox DataBits configuration
        ComboBoxDataBits.Items.Clear()
        ComboBoxDataBits.Items.Add("7")
        ComboBoxDataBits.Items.Add("8")
        'ComboBoxDataBits.SelectedIndex = 0 'Default
        ComboBoxDataBits.SelectedIndex = My.Settings.ComboBoxDataBitsIndex

        'ComboBox parity configuration
        ComboBoxParity.Items.Clear()
        ComboBoxParity.Items.Add("Even")
        ComboBoxParity.Items.Add("Odd")
        ComboBoxParity.Items.Add("None")
        'ComboBoxParity.SelectedIndex = 0
        ComboBoxParity.SelectedIndex = My.Settings.ComboBoxParityIndex

        'ComboBox StopBits configuration
        ComboBoxStopBits.Items.Clear()
        ComboBoxStopBits.Items.Add("1")
        ComboBoxStopBits.Items.Add("2")
        'ComboBoxStopBits.SelectedIndex = 0 'Default
        ComboBoxStopBits.SelectedIndex = My.Settings.ComboBoxStopBitsIndex


    End Sub

    '------------------------------------
    'Button press routines
    '------------------------------------

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        ModuleComPortParameters.configuration_is_valid = False
        Me.Close()
    End Sub

    Public Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        'Copy the values in the combo boxes to the variables in the ModuleComPortParameters
        'In some cases, must use a switch case to map from string to IO.Ports type values

        ModuleComPortParameters.port = ComboBoxPort.Text 'String to String mapping, no sweat
        My.Settings.ComPortName = ComboBoxPort.Text

        ModuleComPortParameters.baud_rate = ComboBoxBaudRate.Text 'String to Integer, automatic conversion
        My.Settings.ComboBoxBaudRateIndex = ComboBoxBaudRate.SelectedIndex

        ModuleComPortParameters.data_bits = ComboBoxDataBits.Text 'String to Integer, automatic conversion
        My.Settings.ComboBoxDataBitsIndex = ComboBoxDataBits.SelectedIndex

        Select Case ComboBoxParity.Text 'String to IO.Ports.Parity, trickier
            Case "None"
                ModuleComPortParameters.parity = IO.Ports.Parity.None
            Case "Even"
                ModuleComPortParameters.parity = IO.Ports.Parity.Even
            Case "Odd"
                ModuleComPortParameters.parity = IO.Ports.Parity.Odd
        End Select
        My.Settings.ComboBoxParityIndex = ComboBoxParity.SelectedIndex

        ModuleComPortParameters.stop_bits = ComboBoxStopBits.Text 'String to Integer, automatic conversion
        My.Settings.ComboBoxStopBitsIndex = ComboBoxStopBits.SelectedIndex

        'Set configuration is valid flag
        ModuleComPortParameters.configuration_is_valid = True

        'Now setup the object SerialPort1 using the variables from the ModuleComPortParameters
        'Only use the vales if configuration was declared valid
        If ModuleComPortParameters.configuration_is_valid = True Then
            With Form1.SerialPort1
                .PortName = ModuleComPortParameters.port
                .BaudRate = ModuleComPortParameters.baud_rate
                .Parity = ModuleComPortParameters.parity
            End With
        End If

        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub ButtonDefault_Click(sender As Object, e As EventArgs) Handles ButtonDefault.Click
        My.Settings.Reset()
        My.Settings.Save()
        Me.Close()
    End Sub
End Class