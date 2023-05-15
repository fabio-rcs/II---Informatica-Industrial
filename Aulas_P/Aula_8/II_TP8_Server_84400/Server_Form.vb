Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices

Public Class Server_Form
    ' The IP address of the server
    ReadOnly ip As String = GetIp()
    ReadOnly local_adress As IPAddress = IPAddress.Parse(ip)

    ' A server object will accept connection requests
    ReadOnly server As New TcpListener(local_adress, 80)

    ' A connection object will receive data
    Dim connection As New TcpClient

    ' Helper variable
    Dim stoped As Boolean

    ' Facon Server variables
    Dim fs_is_connected As Boolean
    ReadOnly fs As New FaconSvr.FaconServer
    ReadOnly CSG As String = "Channel0.Station0.Group0"

    Private Sub Server_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Reservoir Control - Server"
        Me.Icon = New Icon("ua-favicon.ico")
        ' Start the TCP server.
        ' Will wait for clients to connect
        server.Start()

        ' Initial defaults
        ToolStripStatusLabel1.Text = ""
        TimerConnection.Interval = 1000
        TimerReceive.Interval = 1000
        TimerSend.Interval = 1000
        TimerConnection.Enabled = True
        TimerReceive.Enabled = True
        TimerSend.Enabled = True
        txtbxWaterLvl.Text = ""
        txtbxMessageReceived.ScrollBars = RichTextBoxScrollBars.ForcedVertical
        txtbxMessageReceived.HideSelection = False
        txtbxMessageSent.ScrollBars = RichTextBoxScrollBars.ForcedVertical
        txtbxMessageSent.HideSelection = False
        ToolStripStatusLabel3.Text = ""

        ' Call the routine to disconnect (initial status should be disconnected) and update GUI
        Disconnect()
    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        ' Accept client if there's one waiting
        If Not stoped AndAlso server.Pending() Then
            connection = server.AcceptTcpClient()
        End If

        ' If connected, get message
        If connection.Connected Then
            Dim message_size As Integer = connection.Available()

            ' Message must have buffer size bigger than 0
            If message_size > 0 Then

                Dim message_in_stream As NetworkStream = connection.GetStream()
                Dim buffer(message_size) As Byte

                message_in_stream.Read(buffer, 0, message_size)

                Dim message_in As String = ""
                Dim i As Integer

                Dim data As String

                ' Append each buffer to message_in
                For i = 0 To message_size - 1
#Disable Warning S1643 ' Strings should not be concatenated using "+" or "&" in a loop
                    message_in += Chr(buffer(i))
#Enable Warning S1643 ' Strings should not be concatenated using "+" or "&" in a loop
                Next

                ' Display message received
                data = $"{Now}{" "}{message_in}"
                txtbxMessageReceived.AppendText(data)
                txtbxMessageReceived.Text += vbCrLf

                ' Show always last message
                Dim last As Long
                last = Len(txtbxMessageReceived.Text)
                txtbxMessageReceived.SelectionStart = last

                ' Auxiliary variables
                Dim Y0, Y1, Y2 As String

                Y0 = Mid(message_in, 1, 1)
                Y1 = Mid(message_in, 2, 1)
                Y2 = Mid(message_in, 3, 1)

                ' Send receives message to PLC
                fs.SetItem(CSG, "Y0", Y0)
                fs.SetItem(CSG, "Y1", Y1)
                fs.SetItem(CSG, "Y2", Y2)
            End If
        End If

        ' Read status from PLC and send to client
        chckbxX0.CheckState = fs.GetItem(CSG, "X0")
        chckbxX1.CheckState = fs.GetItem(CSG, "X1")
        chckbxX2.CheckState = fs.GetItem(CSG, "X2")
        chckbxX3.CheckState = fs.GetItem(CSG, "X3")
        chckbxY0.CheckState = fs.GetItem(CSG, "Y0")
        chckbxY1.CheckState = fs.GetItem(CSG, "Y1")
        chckbxY2.CheckState = fs.GetItem(CSG, "Y2")
        txtbxWaterLvl.Text = fs.GetItem(CSG, "D300")
    End Sub

    Private Sub TimerConnection_Tick(sender As Object, e As EventArgs) Handles TimerConnection.Tick
        ' Display connection status
        ToolStripStatusLabel1.Text = If(connection.Connected, "Connection Established", "Not Connected")
        ToolStripStatusLabel2.Text = "IP " & local_adress.ToString & " | Port 80"

        ' Update button according to connection status
        If stoped Then
            If Not connection.Connected Then
                btnOff.Text = "Turn On"
                btnOff.BackColor = Color.Red
            End If

        Else
            btnOff.Text = "Turn Off"
            btnOff.BackColor = Color.Green
        End If
    End Sub

    Private Sub Server_Form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ' If window is closed, stop the server
        server.Stop()
    End Sub

    Private Sub BtnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        ' Start or stop the server and necessary variables with the button click 
        If stoped Then
            server.Start()
            TimerSend.Enabled = True
            TimerReceive.Enabled = True
            stoped = False
        Else
            server.Stop()
            TimerSend.Enabled = False
            TimerReceive.Enabled = False
            connection.Close()
            stoped = True
        End If
    End Sub

    Private Sub Disconnect()
        ' Functional actions
        fs_is_connected = False
        TimerReceive.Enabled = False
        TimerSend.Enabled = False
        fs.Disconnect()

        ' GUI Actions
        ConnectToFaconServerToolStripMenuItem.Text = "Connect to FaconSrv"
        ConnectToFaconServerToolStripMenuItem.BackColor = Color.Red
        FaconServerConfigurationToolStripMenuItem.Enabled = True
        FastConnectToolStripMenuItem.Enabled = True
        ConnectionStatusStripLabelPort.Text = "Not connected to FaconSrv"
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub

    Private Sub ConnectToFaconServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToFaconServerToolStripMenuItem.Click
        ' Allow to open port only if config is valid
        If ModulePathParameters.cfg_is_valid Then

            ' If opened, close
            If fs_is_connected Then
                Disconnect()

            Else ' If closed, open
                ' Try to open the port. If fails, display error
                Try
                    fs.Connect()
                    fs_is_connected = True
                    ConnectToFaconServerToolStripMenuItem.Text = "Disconnect from FaconSrv"
                    ConnectToFaconServerToolStripMenuItem.BackColor = Color.Lime
                    ConnectionStatusStripLabelPort.Text = "Connected To FaconSrv"
                    TimerReceive.Enabled = True ' Start receiving
                    TimerSend.Enabled = True
                    FaconServerConfigurationToolStripMenuItem.Enabled = False
                    FastConnectToolStripMenuItem.Enabled = False

                Catch ex As Exception
                    MsgBox(ex.ToString()) ' Error display
                End Try
            End If

        Else
            MsgBox("Cannot open port with invalid configuration")
        End If
    End Sub

    Private Sub FaconServerConfigurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FaconServerConfigurationToolStripMenuItem.Click
        ' Dim form1 to highlight formPortConfig
        Me.Opacity = 0.5
        ' Show in center of parent form
        Form_FaconSrvPath.StartPosition = FormStartPosition.CenterParent
        ' Show dialog blocks from doing anything in parent form until is closed
        Form_FaconSrvPath.ShowDialog()
        ' Return opacity to normal after closing
        Me.Opacity = 1

        If ModulePathParameters.cfg_is_valid Then
            ' FaconSrv connection
            fs.OpenProject(ModulePathParameters.faconsrv_path)
        End If
    End Sub

    Private Sub TimerSend_Tick(sender As Object, e As EventArgs) Handles TimerSend.Tick
        Dim output As String = ""

        If connection.Connected Then

            Dim status(8) As Byte

            status(0) = chckbxX0.CheckState + 48
            status(1) = chckbxX1.CheckState + 48
            status(2) = chckbxX2.CheckState + 48
            status(3) = chckbxX3.CheckState + 48
            status(4) = chckbxY0.CheckState + 48
            status(5) = chckbxY1.CheckState + 48
            status(6) = chckbxY2.CheckState + 48
            status(7) = txtbxWaterLvl.Text

            Try
                Dim stream As NetworkStream = connection.GetStream()
                stream.Write(status, 0, status.Length)

                Dim i As Integer

                ' Copy from buffer to message in
                For i = 0 To status.Length - 1
#Disable Warning S1643 ' Strings should not be concatenated using "+" or "&" in a loop
                    output += Chr(status(i))
#Enable Warning S1643 ' Strings should not be concatenated using "+" or "&" in a loop
                Next i

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try

            Dim data As String
            data = $"{Now}{" "}{output}"
            txtbxMessageSent.AppendText(data)
            txtbxMessageSent.Text += vbCrLf

            ' Show always last message
            Dim last As Long
            last = Len(txtbxMessageSent.Text)
            txtbxMessageSent.SelectionStart = last
        End If
    End Sub

    ' Enable fast connect for easier as faster connection
    Private Sub FastConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastConnectToolStripMenuItem.Click
        ModulePathParameters.cfg_is_valid = True

        faconsrv_path = "C:\Users\fabio\OneDrive\Documentos\GitHub\II---Informatica-Industrial\Aulas_P\Aula_8\II_TP8_84400.fcs"

        fs.OpenProject(faconsrv_path)
        ConnectToFaconServerToolStripMenuItem.PerformClick()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Reservoir server made by Fábio Sousa, with the mec. 84400 for the class 'Industrial Informatics'")
    End Sub

    Private Sub AboutFastConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutFastConnectToolStripMenuItem.Click
        MsgBox("Fast connect Facon Server file path is defaulted to C:\Users\fabio\OneDrive\Documentos\GitHub\II---Informatica-Industrial\Aulas_P\Aula_8\II_TP8_84400.fcs")
    End Sub

    Public Function GetIp() As String
        Try
            Dim IPList As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName)
            Dim IP As IPAddress

            For Each IP In IPList.AddressList
                'Only return IPv4 routable IPs 
                If (IP.AddressFamily = Sockets.AddressFamily.InterNetwork) Then
                    Return IP.ToString
                End If
            Next
            Return ""

        Catch ex As Exception
            Return ""
        End Try
    End Function
End Class