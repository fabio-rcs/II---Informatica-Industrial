Imports System.IO.Ports
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Web

Public Class Main
    ' The IP address of the server
    ReadOnly ip_address As IPAddress = IPAddress.Parse("192.168.1.69")

    ' A client object will request connection requirement
    Dim client As New Sockets.TcpClient

    ' Connection helper variable
    Dim first_time As Boolean

    ' Working variables
    Dim level_start_y As Integer
    Dim level_y As Integer
    Dim level_bottom_y As Integer

    Dim X0 As Integer
    Dim X1 As Integer
    Dim X2 As Integer
    Dim X3 As Integer

    Dim Y0 As Integer
    Dim Y1 As Integer
    Dim Y2 As Integer

    Dim Y0_in As Integer
    Dim Y1_in As Integer
    Dim Y2_in As Integer

    Dim level As Integer


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Reservoir Control - Client"
        Me.Icon = New Icon("ua-favicon.ico") 'Icon of the window in the top left

        ' Configure the send and receive Timers
        TimerReceive.Interval = 100
        TimerAutoMode.Interval = 500
        TimerSend.Interval = 100

        level_start_y = picbxWaterLevel.Location.Y
        level_y = picbxWaterLevel.Location.Y
        level_bottom_y = picbxWaterLevel.Location.Y + picbxWaterLevel.Height

        ' Default text in StatusStrips
        StatusStripLabelAutoMode.Text = "Automatic Mode is Disabled"
        StatusStripLabelWarnings.Text = " "
        SentStripStatusLabel.Text = " "
        ToolStripStatusCompare.Text = ""
        txtbxLevel.ReadOnly = True
        ' Call the routine to disconnect (initial status should be disconnected) and update GUI
        Disconnect()
        UpdateButtonImages()
    End Sub


    Private Sub OpenPortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPortToolStripMenuItem.Click
        ' If it's the first click (not connected yet)
        If first_time Then
            ' Try connecting
            Try
                client.Connect(ip_address, 80)
                first_time = False
                OpenPortToolStripMenuItem.Text = "Disconnect"
                OpenPortToolStripMenuItem.BackColor = Color.Lime
                ConnectionStatusStripLabelPort.Text = "Connected to IP " & ip_address.ToString
                TimerReceive.Enabled = True ' Start receiving
                TimerSend.Enabled = True
                TimerCompare.Enabled = True
                rbtnY0On.Enabled = True
                rbtnY1On.Enabled = True
                rbtnY2On.Enabled = True
                chckbxAutoMode.AutoCheck = True
                StatusStripLabelAutoMode.Text = "Automatic mode is off"
                ' Get and display any errors that occur
            Catch ex As Exception
                MsgBox(ex.ToString()) ' Error display
            End Try

            ' Else is already connected and with the click we want to disconnect
        Else
            Disconnect()
        End If
    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        ' If there is a connection, get the message
        If client.Connected Then
            Dim message_size As Integer = client.Available

            ' Read message if size is not zero
            If message_size > 0 Then

                ' Copy stream to byte array buffer
                Dim message_in_stream As NetworkStream = client.GetStream()

                ' A buffer to copy the received data
                Dim buffer(message_size) As Byte
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


                DisplayMesssages.txtReceived.AppendText($"{Now}{" "}{message_in}")
                DisplayMesssages.txtReceived.Text += vbCrLf
                StatusStripLabelWarnings.Text = "Message received: " & message_in

                ' Show always last message
                Dim last As Long
                last = Len(DisplayMesssages.txtReceived.Text)
                DisplayMesssages.txtReceived.SelectionStart = last
                ' Define the variables as per values received
                X0 = Mid(message_in, 1, 1)
                X1 = Mid(message_in, 2, 1)
                X2 = Mid(message_in, 3, 1)
                X3 = Mid(message_in, 4, 1)
                Y0_in = Mid(message_in, 5, 1)
                Y1_in = Mid(message_in, 6, 1)
                Y2_in = Mid(message_in, 7, 1)
                level = Asc(Mid(message_in, 8, 1))

            End If
        End If

        ' Set the GUI to show vars values
        rbtnStatusY0.Checked = Y0
        rbtnStatusY1.Checked = Y1
        rbtnStatusY2.Checked = Y2

        rbtnX0.Checked = X0
        rbtnX1.Checked = X1
        rbtnX2.Checked = X2
        rbtnX3.Checked = X3

        txtbxLevel.Text = level

        ' Change picture box size according to the level received
        Dim height_difference = CDbl(level_bottom_y - level_start_y) * (1 - (level / 100))

        picbxWaterLevel.Location = New Point(picbxWaterLevel.Location.X, level_start_y + CInt(height_difference))
        picbxWaterLevel.Height = level_bottom_y - picbxWaterLevel.Location.Y
    End Sub

    ' Exit sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    '------------------------------------------------------
    ' Button Click Subs -----------------------------------
    '------------------------------------------------------
    Private Sub RbtnY0On_Click(sender As Object, e As EventArgs) Handles rbtnY0On.Click
        Y0 = If(Y0 = 1, 0, 1)
    End Sub


    Private Sub RbtnY1On_Click(sender As Object, e As EventArgs) Handles rbtnY1On.Click
        Y1 = If(Y1 = 1, 0, 1)
    End Sub

    Private Sub RbtnY2On_Click(sender As Object, e As EventArgs) Handles rbtnY2On.Click
        Y2 = If(Y2 = 1, 0, 1)
    End Sub

    ' Open debug form
    Private Sub DebugFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugFormToolStripMenuItem.Click
        DisplayMesssages.Show()
    End Sub

    'Check if automatic mode is enabled
    Private Sub ChckbxAutoMode_CheckStateChanged(sender As Object, e As EventArgs) Handles chckbxAutoMode.CheckStateChanged
        ' If not automatic mode, go back to normal
        If chckbxAutoMode.CheckState = CheckState.Unchecked Then
            TimerAutoMode.Enabled = False
            StatusStripLabelAutoMode.Text = "Automatic mode is off"

            ' Enable control buttons
            If client.Connected Then
                rbtnY0On.Enabled = True
                rbtnY1On.Enabled = True
                rbtnY2On.Enabled = True
            End If

            ' If automatic mode, disable buttons
        ElseIf chckbxAutoMode.CheckState = CheckState.Checked Then
            StatusStripLabelAutoMode.Text = "Automatic mode is on"
            TimerAutoMode.Enabled = True
            rbtnY0On.Enabled = False
            rbtnY1On.Enabled = False
            rbtnY2On.Enabled = False
        End If

    End Sub

    ' Subroutine to disconnect
    Private Sub Disconnect()
        ' Functional actions
        client.Close()
        client = New Sockets.TcpClient
        first_time = True
        TimerSend.Enabled = False
        TimerReceive.Enabled = False
        TimerCompare.Enabled = False

        ' GUI Actions
        OpenPortToolStripMenuItem.Text = "Connect"
        OpenPortToolStripMenuItem.BackColor = Color.Red
        rbtnY0On.Enabled = False
        rbtnY1On.Enabled = False
        rbtnY2On.Enabled = False
        chckbxAutoMode.AutoCheck = False
        ConnectionStatusStripLabelPort.Text = "Not connected"
        StatusStripLabelAutoMode.Text = "Automatic mode is disabled"
    End Sub

    ' Subroutine to update the GUI
    Private Sub UpdateButtonImages()
        If Y0 = 1 Then
            picbxY0.BackColor = Color.Lime
            rbtnY0On.Text = "Turn Y0 Off"
        ElseIf Y0 = 0 Then
            picbxY0.BackColor = Color.Red
            rbtnY0On.Text = "Turn Y0 On"
        End If

        If Y1 = 1 Then
            picbxY1.BackColor = Color.Lime
            rbtnY1On.Text = "Turn Y1 Off"
        ElseIf Y1 = 0 Then
            picbxY1.BackColor = Color.Red
            rbtnY1On.Text = "Turn Y1 On"
        End If

        If Y2 = 1 Then
            picbxY2.BackColor = Color.Lime
            rbtnY2On.Text = "Turn Y2 Off"
        ElseIf Y2 = 0 Then
            picbxY2.BackColor = Color.Red
            rbtnY2On.Text = "Turn Y2 On"
        End If
    End Sub

    '------------------------------------
    ' Automatic mode
    '------------------------------------
    Private Sub TimerAutoMode_Tick(sender As Object, e As EventArgs) Handles TimerAutoMode.Tick
        If (X0 = 1 AndAlso level < 30) Then
            StatusStripLabelAutoMode.Text = "Warning! Water level is dangerously low!"
            Y0 = 1
            Y1 = 1
            Y2 = 0

        ElseIf (X1 = 1 AndAlso (level >= 30 AndAlso level <= 75)) Then
            StatusStripLabelAutoMode.Text = "X1 on, filling the reservoir"
            Y0 = 1
            Y1 = 1
            Y2 = 1

        ElseIf (X2 = 1 AndAlso (level > 75 AndAlso level <= 90)) Then
            StatusStripLabelAutoMode.Text = "X2 on, reservoir full"
            Y0 = 0
            Y1 = 0
            Y2 = 1

        ElseIf (X3 = 1 AndAlso level > 90) Then
            StatusStripLabelAutoMode.Text = "Warning! Water level too high!"
            Y0 = 0
            Y1 = 0
            Y2 = 1
        ElseIf (X0 = 0 AndAlso level < 30) Then
            StatusStripLabelAutoMode.Text = "Error in  sensor X0 or water level sensor"
        ElseIf (X1 = 0 AndAlso (level >= 30 AndAlso level <= 75)) Then
            StatusStripLabelAutoMode.Text = "Error in  sensor X1 or water level sensor"
        ElseIf (X2 = 0 AndAlso (level > 75 AndAlso level <= 90)) Then
            StatusStripLabelAutoMode.Text = "Error in  sensor X2 or water level sensor"
        ElseIf (X3 = 0 AndAlso level > 90) Then
            StatusStripLabelAutoMode.Text = "Error in  sensor X3 or water level sensor"
        End If

    End Sub

    '------------------------------------
    ' Send message every tick
    '------------------------------------
    Private Sub TimerSend_Tick(sender As Object, e As EventArgs) Handles TimerSend.Tick
        Dim output As String = ""

        ' If connected, message can be sent
        If client.Connected Then
            Try
                ' Declare a byte array and set it according to the state of the check-boxes
                Dim buffer(3) As Byte
                buffer(0) = rbtnStatusY0.CheckState + 48
                buffer(1) = rbtnStatusY1.CheckState + 48
                buffer(2) = rbtnStatusY2.CheckState + 48

                ' Now send the array
                Dim message_out_stream As NetworkStream
                message_out_stream = client.GetStream()
                message_out_stream.Write(buffer, 0, buffer.Length)

                Dim i As Integer

                ' Copy from buffer to message in
                For i = 0 To buffer.Length - 1
#Disable Warning S1643 ' Strings should not be concatenated using "+" or "&" in a loop
                    output += Chr(buffer(i))
#Enable Warning S1643 ' Strings should not be concatenated using "+" or "&" in a loop
                Next i

                ' Catch and display any errors that occur
            Catch ex As Exception
                MsgBox(ex.ToString()) ' Error display
            End Try
        End If

        DisplayMesssages.txtSent.AppendText($"{Now}{" "}{output}")
        SentStripStatusLabel.Text = "Message Sent: " & output
        DisplayMesssages.txtSent.Text += vbCrLf

        ' Show always last message
        Dim last As Long
        last = Len(DisplayMesssages.txtSent.Text)
        DisplayMesssages.txtSent.SelectionStart = last

        UpdateButtonImages()
    End Sub

    ' About box
    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MsgBox("Reservoir control client made by Fábio Sousa, with the mec. 84400 in 20/03/2023 for the class 'Industrial Informatics'")

    End Sub

    Private Sub AutomaticModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutomaticModeToolStripMenuItem.Click
        MsgBox("Automatic mode detects the state of the reservoir, fills when needed and emits alarms when empty or full. After X1, it allows the water to be consumed.
                Thresholds: To be empty, water level < 30 and X0 on
                            To start filling, 30 <= water level <= 75 and X1 on
                            To stop filling, 75 < water level <= 90 and X2 on
                            To be full, water level > 90 and X3 on")
    End Sub

    Private Sub TimerCompare_Tick(sender As Object, e As EventArgs) Handles TimerCompare.Tick
        ' Check if valve status in client differs from server
        If Y0 <> Y0_in OrElse Y1 <> Y1_in OrElse Y2 <> Y2_in Then
            ToolStripStatusCompare.Text = "Changing valves status"

        Else
            ToolStripStatusCompare.Text = "Valves status synchronized"
        End If
    End Sub
End Class
