Imports System.Net
Imports System.Net.Sockets

Public Class Client_Form
    ' The IP address of the server
    ReadOnly ip_address As IPAddress = IPAddress.Parse("127.0.0.1")

    ' A client object will request connection requirement
    Dim client As New Sockets.TcpClient

    ' Connection helper variable
    Dim first_time As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Client"

        ' Initialization reset
        ToolStripStatusLabel1.Text = ""
        chckbxX0.CheckState = CheckState.Unchecked
        chckbxX1.CheckState = CheckState.Unchecked
        chckbxX2.CheckState = CheckState.Unchecked
        chckbxX3.CheckState = CheckState.Unchecked
        chckbxY0.CheckState = CheckState.Unchecked
        chckbxY1.CheckState = CheckState.Unchecked
        chckbxY2.CheckState = CheckState.Unchecked
        TimerReceive.Interval = 1000
        TimerReceive.Enabled = True
        TimerConnection.Interval = 500
        TimerConnection.Enabled = True
        btnSend.Enabled = False
        btnConnect.BackColor = Color.Red
        btnConnect.Text = "Disconnected"
        first_time = True
        txtbxVelocitySend.Text = 0
    End Sub
    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        ' If it's the first click (not connected yet)
        If first_time Then
            ' Try connecting
            Try
                client.Connect(ip_address, 81)
                btnSend.Enabled = True
                first_time = False
                btnConnect.BackColor = Color.Green
                btnConnect.Text = "Connected"

                ' Get and display any errors that occur
            Catch ex As Exception
                MsgBox(ex.ToString()) ' Error display
            End Try

            ' Else is already connected and with the click we want to disconnect
        Else
            client.Close()
            client = New Sockets.TcpClient
            btnConnect.BackColor = Color.Red
            btnConnect.Text = "Disconnected"
            btnSend.Enabled = False
            first_time = True
        End If
    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        ' If there is a connection, get the message
        If client.Connected Then
            Dim message_size As Integer = client.Available

            ' Read message if size is 5
            If message_size = 5 Then

                ' Copy stream to byte array buffer
                Dim message_in_stream As NetworkStream = client.GetStream()

                ' A buffer to copy the received data
                Dim buffer(4) As Byte
                message_in_stream.Read(buffer, 0, message_size)

                '! Convert byte array buffer to a string
                Dim message_in As String = ""
                Dim i As Integer

                ' Copy from buffer to message in
                For i = 0 To message_size - 1
#Disable Warning S1643 ' Strings should not be concatenated using "+" or "&" in a loop
                    message_in += Chr(buffer(i))
#Enable Warning S1643 ' Strings should not be concatenated using "+" or "&" in a loop
                Next i

                ' Process message to get values for X0 to X3
                chckbxX0.Checked = If(Mid(message_in, 1, 1) = "1", "True", "False")
                chckbxX1.Checked = If(Mid(message_in, 2, 1) = "1", "True", "False")
                chckbxX2.Checked = If(Mid(message_in, 3, 1) = "1", "True", "False")
                chckbxX3.Checked = If(Mid(message_in, 4, 1) = "1", "True", "False")
                txtbxVelocityReceive.Text = If(Asc(Mid(message_in, 5, 1)) = 0, "0", Asc(Mid(message_in, 5, 1)))
            End If
        End If
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        ' If connected, message can be sent
        If client.Connected Then
            Try
                ' Declare a byte array and set it according to the state of the check-boxes
                Dim buffer(5) As Byte
                buffer(0) = chckbxY0.CheckState + 48
                buffer(1) = chckbxY1.CheckState + 48
                buffer(2) = chckbxY2.CheckState + 48

                ' Velocity must be numeric and a value up to 100
                If IsNumeric(txtbxVelocitySend.Text) Then
                    If txtbxVelocitySend.Text > 100 Then
                        MsgBox("You can only use values up to 100", vbOKOnly + vbInformation, "Streams")
                        txtbxVelocitySend.Text = 100
                        buffer(3) = 100
                    Else
                        buffer(3) = CInt(txtbxVelocitySend.Text)
                    End If

                    ' Show message explaining to the user that Velocity must be numeric 
                Else
                    MsgBox("You can only use numerical integer values to fill in this text box", vbOKOnly + vbInformation, "Streams")
                    txtbxVelocitySend.Clear()
                    buffer(3) = 0
                End If

                ' Now send the array
                Dim message_out_stream As NetworkStream
                message_out_stream = client.GetStream()
                message_out_stream.Write(buffer, 0, 4)

                ' Catch and display any errors that occur
            Catch ex As Exception
                MsgBox(ex.ToString()) ' Error display
            End Try
        End If
    End Sub

    Private Sub TimerConnection_Tick(sender As Object, e As EventArgs) Handles TimerConnection.Tick
        ' Update connection state
        ToolStripStatusLabel1.Text = If(client.Connected, "Connection established", "Not connected")
        ToolStripStatusLabel2.Text = Now.ToString

        'Dim res As Boolean
        'res = CheckPortOpen("127.0.0.1", 81)
        'If Not res Then
        'btnConnect.PerformClick()

        '? Doesn't work because the client only tests connection when trying to send a message
        If Not client.Connected AndAlso btnConnect.Text = "Connected" Then
            btnConnect.PerformClick()
        End If
    End Sub

    'TODO Ping Test is not enough because there's no way to ping a port, but we can try to connect to see if it's available or not and use the result
    'TODO This enters in conflict, too many errors to solve
    'Function CheckPortOpen(ByVal hostname As String, ByVal portnum As Integer) As Boolean

    '    Dim ipa As IPAddress = CType(Dns.GetHostAddresses(hostname)(0), IPAddress)

    '    Try
    '        Dim sock As Socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
    '        Console.WriteLine("Testing " & hostname & ":" & portnum)
    '        sock.Connect(ipa, portnum)
    '        If sock.Connected Then
    '            sock.Close()
    '            sock = Nothing
    '            Return True
    '        End If

    '    Catch sx As SocketException
    '        If sx.ErrorCode = 10061 Then
    '            Return False
    '        Else
    '            Return Nothing
    '        End If

    '    End Try

    'End Function

End Class