Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Form1
    ' The IP address of the server
    ReadOnly ip As String = GetIp()
    ReadOnly local_address As IPAddress = IPAddress.Parse(ip)

    ' A connection object will receive data
    Dim connection As New TcpClient

    ' A server object will accept connection requests
    ReadOnly server As New TcpListener(local_address, 80)

    ReadOnly html_folder_path As String = "C:\Users\fabio\OneDrive\Documentos\GitHub\II---Informatica-Industrial\Aulas_P\Aula_9\II_TP9_84400\WindowsApp1\HTML\"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Reservoir Control - Server"

        txtbxMessageReceived.ScrollBars = RichTextBoxScrollBars.ForcedVertical
        txtbxMessageReceived.HideSelection = False

        TimerConnection.Enabled = True

        ' Start the TCP server.
        ' Will wait for clients to connect
        server.Start()
    End Sub

    Private Sub TimerConnection_Tick(sender As Object, e As EventArgs) Handles TimerConnection.Tick

        ' Display connection status
        ToolStripStatusLabel1.Text = If(connection.Connected, "Connection Established", "Not Connected")
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

            Dim status = "HTTP/1.1 200 OK"
            Dim header = "Content-Type: text/html; charset=wtf-8"

            Dim answer = status & vbNewLine & header & vbNewLine & vbNewLine & file_string

            Dim send_bytes As Byte() = Encoding.UTF8.GetBytes(answer)

            Try
                Dim stream As NetworkStream = connection.GetStream()
                stream.Write(send_bytes, 0, send_bytes.Length)

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub
End Class
