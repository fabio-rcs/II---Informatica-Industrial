Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices

Public Class Server_Form
    ' The IP address of the server
    Dim local_adress As IPAddress = IPAddress.Parse("127.0.0.1")

    ' A server object will accept connection requests
    Dim server As New TcpListener(local_adress, 81)

    ' A connection object will receive data
    Dim connection As New TcpClient

    ' Helper variable
    Dim stoped As Boolean

    Private Sub Server_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Start the TCP server.
        ' Will wait for clients to connect
        server.Start()

        ' Initial defaults
        stoped = False
        ToolStripStatusLabel1.Text = ""
        TimerConnection.Interval = 1000
        TimerReceive.Interval = 1000
        TimerSend.Interval = 1000
        TimerConnection.Enabled = True
        TimerReceive.Enabled = True
        TimerSend.Enabled = True
        txtbxVelocitySend.Text = 0
        txtbxVelocityReceive.Text = 0
        txtbxReception.ScrollBars = RichTextBoxScrollBars.ForcedVertical
        txtbxReception.HideSelection = False
    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        ' Accept client if there's one waiting
        If Not stoped AndAlso server.Pending() Then
            connection = server.AcceptTcpClient()
        End If

        ' If connected, get message
        If connection.Connected Then
            Dim message_size As Integer = connection.Available()

            ' Message must have buffer size of 4
            If message_size = 4 Then

                Dim message_in_stream As NetworkStream = connection.GetStream()
                Dim buffer(message_size) As Byte

                message_in_stream.Read(buffer, 0, message_size)

                Dim message_in As String = ""
                Dim i As Integer

                ' Append each buffer to message_in
                For i = 0 To message_size - 1
#Disable Warning S1643 ' Strings should not be concatenated using "+" or "&" in a loop
                    message_in += Chr(buffer(i))
#Enable Warning S1643 ' Strings should not be concatenated using "+" or "&" in a loop
                Next

                ' Display message received
                txtbxReception.Text &= message_in & vbTab & Now.ToString & vbCrLf

                ' Show always last message
                Dim last As Long
                last = Len(txtbxReception.Text)
                txtbxReception.SelectionStart = last

                ' Update variables status
                chckbxY0.Checked = If(Mid(message_in, 1, 1) = "1", "True", "False")
                chckbxY1.Checked = If(Mid(message_in, 2, 1) = "1", "True", "False")
                chckbxY2.Checked = If(Mid(message_in, 3, 1) = "1", "True", "False")
                txtbxVelocityReceive.Text = If(Asc(Mid(message_in, 4, 1)) = 0, "0", AscW(Mid(message_in, 4, 1)))
            End If
        End If
    End Sub

    Private Sub TimerConnection_Tick(sender As Object, e As EventArgs) Handles TimerConnection.Tick
        Try
            ' Display connection status
            ToolStripStatusLabel1.Text = If(connection.Connected, "Connection Established", "Not Connected")
            ToolStripStatusLabel2.Text = If(connection.Connected, local_adress.ToString, "")
        Catch ex As Exception
            MsgBox(ex.ToString()) ' Error display
        End Try


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

    Private Sub TimerSend_Tick(sender As Object, e As EventArgs) Handles TimerSend.Tick
        ' If connected, message can be sent
        If connection.Connected Then
            Dim buffer(4) As Byte

            Try
                ' Declare a byte array and set it according to the state of X0 to X3
                buffer(0) = chckbxX0.CheckState + 48
                buffer(1) = chckbxX1.CheckState + 48
                buffer(2) = chckbxX2.CheckState + 48
                buffer(3) = chckbxX3.CheckState + 48

                ' Velocity must be a value up to 100
                If IsNumeric(txtbxVelocitySend.Text) Then
                    If txtbxVelocitySend.Text > 100 Then
                        TimerSend.Enabled = False
                        MsgBox("You can only use values up to 100", vbOKOnly + vbInformation, "Streams")
                        txtbxVelocitySend.Text = 100
                        buffer(4) = 100
                        TimerSend.Enabled = True
                    Else
                        buffer(4) = CInt(txtbxVelocitySend.Text)
                    End If

                    ' Velocity must be a number as well
                Else
                    TimerSend.Enabled = False
                    MsgBox("You can only use numerical integer values to fill in this text box", vbOKOnly + vbInformation, "Streams")
                    txtbxVelocitySend.Text = 0
                    buffer(4) = 0
                    TimerSend.Enabled = True
                End If

                ' Display any other error that happens
            Catch ex As Exception
                TimerSend.Enabled = False
                MsgBox(ex.ToString()) ' Error display
                TimerSend.Enabled = True
            End Try

            Try
                ' Now send the array
                Dim message_out_stream As NetworkStream
                message_out_stream = connection.GetStream()
                message_out_stream.Write(buffer, 0, 5)

                ' Display any error that happens
            Catch ex As Exception
                TimerSend.Enabled = False
                MsgBox(ex.ToString(), vbOKOnly + vbInformation) ' Error display
                TimerSend.Enabled = True
            End Try
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
End Class