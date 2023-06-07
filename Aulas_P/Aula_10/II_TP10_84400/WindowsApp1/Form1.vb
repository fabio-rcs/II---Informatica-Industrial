Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Text
Imports FaconSvr
Imports Microsoft.VisualBasic.Devices

Public Class Form1
    ' The IP address of the server
    ReadOnly ip As String = GetIp()
    ReadOnly local_address As IPAddress = IPAddress.Parse(ip)

    ' A connection object will receive data
    Dim connection As New TcpClient

    ' A server object will accept connection requests
    ReadOnly server As New TcpListener(local_address, 80)

    ' Facon Server variables
    Dim fs_is_connected As Boolean
    ReadOnly fs As New FaconSvr.FaconServer
    ReadOnly CSG As String = "Channel0.Station0.Group0"

    ' HTML files' folder path
    ReadOnly html_folder_path As String = "C:\Users\fabio\OneDrive\Documentos\GitHub\II---Informatica-Industrial\Aulas_P\Aula_10\II_TP10_84400\WindowsApp1\HTML\"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Reservoir Control - Server"

        txtbxMessageReceived.ScrollBars = RichTextBoxScrollBars.ForcedVertical
        txtbxMessageReceived.HideSelection = False

        ToolStripStatusLabel1.Text = "Server Offline"
        ToolStripStatusLabel2.Text = ""

        ' Start the TCP server.
        ' Will wait for clients to connect
        server.Start()

        ' Call the routine to disconnect (initial status should be disconnected) and update GUI
        Disconnect()
    End Sub

    Private Sub TimerConnection_Tick(sender As Object, e As EventArgs) Handles TimerConnection.Tick

        ' Display connection status
        ToolStripStatusLabel1.Text = "Accepting Clients"
        ToolStripStatusLabel2.Text = "IP " & local_address.ToString & " | Port 80"

        'See if there's any connection request and accept if exists
        If server.Pending Then
            connection = server.AcceptTcpClient()
        End If

        ' If connected, get message
        If connection.Connected Then


            ' Get number of available bytes
            Dim message_size As Integer = connection.Available()

            ' Message must have buffer size bigger than 0
            If message_size > 0 Then

                Dim message_in_stream As NetworkStream = connection.GetStream()
                Dim buffer(message_size) As Byte

                'Read the bytes
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
                '------------------------------------------------------
                ' --------- Message Received Processing ---------------
                '------------------------------------------------------
                Dim first_line = message_in.Substring(0, message_in.IndexOf(vbCrLf))
                Dim first_line_items = first_line.Split(" ")
                'Dim method = first_line_items(0)
                Dim path = first_line_items(1)

                If InStr(path, "Y0=1") Then
                    fs.SetItem(CSG, "Y0", 1)

                ElseIf InStr(path, "Y0=0") Then
                    fs.SetItem(CSG, "Y0", 0)

                ElseIf InStr(path, "Y1=1") Then
                    fs.SetItem(CSG, "Y1", 1)

                ElseIf InStr(path, "Y1=0") Then
                    fs.SetItem(CSG, "Y1", 0)

                ElseIf InStr(path, "Y2=1") Then
                    fs.SetItem(CSG, "Y2", 1)

                ElseIf InStr(path, "Y2=0") Then
                    fs.SetItem(CSG, "Y2", 0)
                End If

                If InStr(path, "Supervision.html") Then
                    SendFile(html_folder_path & "Supervision.html")

                ElseIf InStr(path, "Supervisao.html") Then
                    SendFile(html_folder_path & "Supervision.html")

                ElseIf InStr(path, "Control.html") Then
                    SendFile(html_folder_path & "Control.html")

                ElseIf InStr(path, "Controlo.html") Then
                    SendFile(html_folder_path & "Control.html")

                ElseIf InStr(path, "Reservoir.html") Then
                    SendFile(html_folder_path & "Reservoir.html")

                ElseIf InStr(path, "Reservatorio.html") Then
                    SendFile(html_folder_path & "Reservoir.html")

                ElseIf InStr(path, "Rodape.html") Then
                    SendFile(html_folder_path & "Rodape.html")

                ElseIf InStr(path, "Reservoir2.html") Then
                    SendFile(html_folder_path & "Reservoir2.html")

                ElseIf InStr(path, "Reservatorio2.html") Then
                    SendFile(html_folder_path & "Reservoir2.html")

                ElseIf InStr(path, "Logo.html") Then
                    SendFile(html_folder_path & "Logo.html")

                Else
                    SendFile(html_folder_path & "error_2.html")
                End If
            End If

            'HTTP protocol foresees the end of the connection   
            connection.Close()
            connection = New TcpClient
        End If

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

    Private Sub SendFile(ByVal file_path As String)
        If connection.Connected Then
            Dim file_stream As New StreamReader(file_path)
            Dim file_string As String = file_stream.ReadToEnd()

            file_stream.Close()

            'Change the string of the html to send

            Dim X0 = Mid(fs.GetItem(CSG, "X0"), 1, 1)
            Dim X1 = Mid(fs.GetItem(CSG, "X1"), 1, 1)
            Dim X2 = Mid(fs.GetItem(CSG, "X2"), 1, 1)
            Dim X3 = Mid(fs.GetItem(CSG, "X3"), 1, 1)
            Dim Y0 = Mid(fs.GetItem(CSG, "Y0"), 1, 1)
            Dim Y1 = Mid(fs.GetItem(CSG, "Y1"), 1, 1)
            Dim Y2 = Mid(fs.GetItem(CSG, "Y2"), 1, 1)
            Dim Water_Level = Mid(fs.GetItem(CSG, "D300"), 1, 3)

            file_string = Replace(file_string, "X0_Value", X0)
            file_string = Replace(file_string, "X1_Value", X1)
            file_string = Replace(file_string, "X2_Value", X2)
            file_string = Replace(file_string, "X3_Value", X3)
            file_string = Replace(file_string, "Y0_Value", Y0)
            file_string = Replace(file_string, "Y1_Value", Y1)
            file_string = Replace(file_string, "Y2_Value", Y2)
            file_string = Replace(file_string, "Water_Level", Water_Level)

            Dim header = "HTTP/1.1 200 OK" & vbNewLine & "Content-Type: text/html; charset=wtf-8" & vbNewLine & vbNewLine
            Dim reply = header & file_string

            Dim send_bytes As Byte() = Encoding.UTF8.GetBytes(reply)

            Try
                Dim stream As NetworkStream = connection.GetStream()
                stream.Write(send_bytes, 0, send_bytes.Length)

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
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
                    ToolStripStatusLabel3.Text = "Connected To FaconSrv"
                    TimerConnection.Enabled = True 'Strat working
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
    Private Sub Disconnect()
        ' Functional actions
        fs_is_connected = False
        fs.Disconnect()
        TimerConnection.Enabled = False

        ' GUI Actions
        ConnectToFaconServerToolStripMenuItem.Text = "Connect to FaconSrv"
        ConnectToFaconServerToolStripMenuItem.BackColor = Color.Red
        FaconServerConfigurationToolStripMenuItem.Enabled = True
        FastConnectToolStripMenuItem.Enabled = True
        ToolStripStatusLabel3.Text = "Not connected to FaconSrv"
    End Sub

    Private Sub FastConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastConnectToolStripMenuItem.Click
        ModulePathParameters.cfg_is_valid = True

        faconsrv_path = "C:\Users\fabio\OneDrive\Documentos\GitHub\II---Informatica-Industrial\Aulas_P\Aula_10\II_TP10_84400.fcs"

        fs.OpenProject(faconsrv_path)
        ConnectToFaconServerToolStripMenuItem.PerformClick()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Reservoir server made by Fábio Sousa, with the mec. 84400 for the class 'Industrial Informatics'")
    End Sub

    Private Sub AboutFastConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutFastConnectToolStripMenuItem.Click
        MsgBox("Fast connect Facon Server file path is defaulted to C:\Users\fabio\OneDrive\Documentos\GitHub\II---Informatica-Industrial\Aulas_P\Aula_10\II_TP10_84400.fcs")
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class