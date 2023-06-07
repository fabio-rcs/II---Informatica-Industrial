Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Text
Imports FaconSvr
Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient

Public Class Form1
    'SQL server variables
    ReadOnly cn As New MySqlConnection
    ReadOnly cmd As New MySqlCommand
    ReadOnly data_reader As MySqlDataReader
    Dim sql_connected As Boolean

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
    Dim X0 As String
    Dim X1 As String
    Dim X2 As String
    Dim X3 As String
    Dim Y0 As String
    Dim Y1 As String
    Dim Y2 As String

    ' First time reading values from FaconSrv variable
    Dim first_time As Boolean

    ' HTML files' folder path
    ReadOnly html_folder_path As String = "C:\Users\fabio\OneDrive\Documentos\GitHub\II---Informatica-Industrial\Aulas_P\Aula_10\II_TP10_84400\WindowsApp1\HTML\"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Change window name
        Me.Text = "Reservoir Control - Server"

        ' Connection, initialization of the data base and scheme selection
        cn.ConnectionString = "Server=localhost; User Id=root; Password=84400; Database=reservatorio"

        ' Show always last message
        txtbxMessageReceived.ScrollBars = RichTextBoxScrollBars.ForcedVertical
        txtbxMessageReceived.HideSelection = False

        'Initial text os status labels
        ToolStripStatusLabel1.Text = "Server Offline"
        ToolStripStatusLabel2.Text = ""
        ToolStripStatusLabel4.Text = "Not connected to DataBase"

        ConnectToSQLServerToolStripMenuItem.Text = "Connect to SQL Server"
        ConnectToSQLServerToolStripMenuItem.BackColor = Color.Red

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
        If connection.Connected AndAlso sql_connected Then

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
                    Try
                        'Inserts the registry in the data base
                        cmd.CommandText = "insert into reservatorio.controlo(DataHora, Y0) values('" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "', '1')"
                        cmd.ExecuteNonQuery()

                    Catch ex As Exception
                        MsgBox(ex.ToString())
                    End Try

                ElseIf InStr(path, "Y0=0") Then
                    fs.SetItem(CSG, "Y0", 0)
                    Try
                        'Inserts the registry in the data base
                        cmd.CommandText = "insert into reservatorio.controlo(DataHora, Y0) values('" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "', '0')"
                        cmd.ExecuteNonQuery()

                    Catch ex As Exception
                        MsgBox(ex.ToString())
                    End Try

                ElseIf InStr(path, "Y1=1") Then
                    fs.SetItem(CSG, "Y1", 1)
                    Try
                        'Inserts the registry in the data base
                        cmd.CommandText = "insert into reservatorio.controlo(DataHora, Y1) values('" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "', '1')"
                        cmd.ExecuteNonQuery()

                    Catch ex As Exception
                        MsgBox(ex.ToString())
                    End Try

                ElseIf InStr(path, "Y1=0") Then
                    fs.SetItem(CSG, "Y1", 0)
                    Try
                        'Inserts the registry in the data base
                        cmd.CommandText = "insert into reservatorio.controlo(DataHora, Y1) values('" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "', '0')"
                        cmd.ExecuteNonQuery()

                    Catch ex As Exception
                        MsgBox(ex.ToString())
                    End Try

                ElseIf InStr(path, "Y2=1") Then
                    fs.SetItem(CSG, "Y2", 1)
                    Try
                        'Inserts the registry in the data base
                        cmd.CommandText = "insert into reservatorio.controlo(DataHora, Y2) values('" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "', '1')"
                        cmd.ExecuteNonQuery()

                    Catch ex As Exception
                        MsgBox(ex.ToString())
                    End Try

                ElseIf InStr(path, "Y2=0") Then
                    fs.SetItem(CSG, "Y2", 0)
                    Try
                        'Inserts the registry in the data base
                        cmd.CommandText = "insert into reservatorio.controlo(DataHora, Y2) values('" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "', '0')"
                        cmd.ExecuteNonQuery()

                    Catch ex As Exception
                        MsgBox(ex.ToString())
                    End Try
                End If

                ' Send corresponding HTML file
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
        ' Get connection IP
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
        ' Only sends HTML file if there's a connection and the data base is connected
        If connection.Connected AndAlso sql_connected Then
            'Reads file path
            Dim file_stream As New StreamReader(file_path)
            Dim file_string As String = file_stream.ReadToEnd()

            'Close the stream
            file_stream.Close()

            'Change the string of the html to send
            X0 = Mid(fs.GetItem(CSG, "X0"), 1, 1)
            X1 = Mid(fs.GetItem(CSG, "X1"), 1, 1)
            X2 = Mid(fs.GetItem(CSG, "X2"), 1, 1)
            X3 = Mid(fs.GetItem(CSG, "X3"), 1, 1)
            Y0 = Mid(fs.GetItem(CSG, "Y0"), 1, 1)
            Y1 = Mid(fs.GetItem(CSG, "Y1"), 1, 1)
            Y2 = Mid(fs.GetItem(CSG, "Y2"), 1, 1)
            Dim Water_Level = Mid(fs.GetItem(CSG, "D300"), 1, 3)

            ' Variable that becomes true when the upper variables receive values, to avoid errors in SQL server
            first_time = True

            'Update the values in HTML file
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
        ' Allow to open port only if configuration is valid
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
                    TimerConnection.Enabled = True 'Start working
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
        ' Functional actions to disconnect
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
        'Automatically configures FaconSrv path and performs click to connect
        ModulePathParameters.cfg_is_valid = True

        faconsrv_path = "C:\Users\fabio\OneDrive\Documentos\GitHub\II---Informatica-Industrial\Aulas_P\Aula_11\II_TP11_84400.fcs"

        fs.OpenProject(faconsrv_path)
        ConnectToFaconServerToolStripMenuItem.PerformClick()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Show msgbox with information
        MsgBox("Reservoir server made by Fábio Sousa, with the mec. 84400 for the class 'Industrial Informatics'")
    End Sub

    Private Sub AboutFastConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutFastConnectToolStripMenuItem.Click
        'Show msgbox with information
        MsgBox("Fast connect Facon Server file path is defaulted to C:\Users\fabio\OneDrive\Documentos\GitHub\II---Informatica-Industrial\Aulas_P\Aula_11\II_TP11_84400.fcs")
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Terminate program
        End
    End Sub

    Private Sub ConnectToSQLServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToSQLServerToolStripMenuItem.Click
        'Tries to connect to the SQL server upon menu item click. 
        Try
            'If closed, open
            If cn.State = ConnectionState.Closed Then
                cn.Open()
                ToolStripStatusLabel4.Text = "Correct connection to the data base 'reservatorio'"
                sql_connected = True
                TimerSQL.Enabled = True
                TimerSQL.Interval = (5000)
                ConnectToSQLServerToolStripMenuItem.Text = "Disconnect from SQL Server"
                ConnectToSQLServerToolStripMenuItem.BackColor = Color.Green

                'If open, closes
            ElseIf cn.State = ConnectionState.Open Then
                cn.Close()
                ToolStripStatusLabel4.Text = "Not connected to the data base"
                sql_connected = False
                TimerSQL.Enabled = False
                ConnectToSQLServerToolStripMenuItem.Text = "Connect to SQL Server"
                ConnectToSQLServerToolStripMenuItem.BackColor = Color.Red
            End If

            'If there's an error, close connection and display error
        Catch ex As Exception
            cn.Close()
            ToolStripStatusLabel4.Text = "Incorrect connection to the data base 'reservatorio'"
            sql_connected = False
            TimerSQL.Enabled = False
            ConnectToSQLServerToolStripMenuItem.Text = "Connect to SQL Server"
            ConnectToSQLServerToolStripMenuItem.BackColor = Color.Red
            MsgBox(ex.ToString())
        End Try

        cmd.Connection = cn
    End Sub

    Private Sub TimerSQL_Tick(sender As Object, e As EventArgs) Handles TimerSQL.Tick
        ' Only starts sending stuff after all conditions are met
        If sql_connected AndAlso fs_is_connected AndAlso first_time Then
            Try
                'Inserts the registry in the data base
                cmd.CommandText = "insert into reservatorio.supervisao(DataHora, Y0, Y1, Y2, X0, X1, X2, X3) values('" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "','" & Y0 & "','" & Y1 & "','" & Y2 & "','" & X0 & "','" & X1 & "','" & X2 & "','" & X3 & "')"
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                'Error display
                MsgBox(ex.ToString())
            End Try
        End If

    End Sub
End Class