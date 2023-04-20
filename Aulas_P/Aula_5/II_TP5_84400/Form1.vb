Imports System.IO.Ports
Imports System.Text

Public Class Form1
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

    Dim level As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Reservoir Control"

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

        ' Call the routine to disconnect (initial status should be disconnected) and update GUI
        Disconnect()
        UpdateButtonImages()
    End Sub

    Private Sub PortConfigurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PortConfigurationToolStripMenuItem.Click
        ' Dim form1 to highlight formPortConfig
        Me.Opacity = 0.5
        ' Show in center of parent form
        PortConfiguration.StartPosition = FormStartPosition.CenterParent
        ' Show dialog blocks from doing anything in parent form until is closed
        PortConfiguration.ShowDialog()
        ' Return opacity to normal after closing
        Me.Opacity = 1

        ' Only use values from Module to SerialPort is configuration is valid
        If ModulePortParameters.cfg_is_valid Then
            If SerialPort.IsOpen Then
                Return
            End If

            With SerialPort
                .PortName = ModulePortParameters.port
                .BaudRate = ModulePortParameters.baud_rate
                .Parity = ModulePortParameters.parity
                .DataBits = ModulePortParameters.data_bits
                .StopBits = ModulePortParameters.stop_bits
                .Encoding = ModulePortParameters.encoding
                .Handshake = ModulePortParameters.handshake
            End With
        End If
    End Sub

    Private Sub OpenPortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPortToolStripMenuItem.Click
        ' Allow to open port only if config is valid
        If ModulePortParameters.cfg_is_valid Then

            ' If opened, close
            If SerialPort.IsOpen Then
                Disconnect()

            Else ' If closed, open
                ' Try to open the port. If fails, display error
                Try
                    SerialPort.Open()
                    OpenPortToolStripMenuItem.Text = "Close Port"
                    OpenPortToolStripMenuItem.BackColor = Color.Lime
                    ConnectionStatusStripLabelPort.Text = "Connected To " & SerialPort.PortName & ", " _
                                                          & SerialPort.BaudRate & " bps, " & SerialPort.DataBits _
                                                          & SerialPort.Parity.ToString & SerialPort.StopBits
                    TimerReceive.Enabled = True ' Start receiving
                    TimerSend.Enabled = True
                    PortConfigurationToolStripMenuItem.Enabled = False
                    rbtnY0On.Enabled = True
                    rbtnY1On.Enabled = True
                    rbtnY2On.Enabled = True

                Catch ex As Exception
                    MsgBox(ex.ToString()) ' Error display
                End Try
            End If

        Else
            MsgBox("Cannot open port with invalid configuration")
        End If
    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        ' If message is empty, do nothing
        If SerialPort.BytesToRead = 0 Then
            Return
        End If

        ' Read Serial Port reception buffer and append to data_received
        Dim data = SerialPort.ReadExisting()

        ' Search for the start of the message
        Dim start_position = InStr(data, "s")

        ' Start of the message wasn't extracted, cannot extract message
        If start_position = 0 Then
            StatusStripLabelWarnings.Text = "Message Extraction Failed"
            Return
        End If

        ' Search for the end of the message
        Dim end_position = InStr(data, "e")

        ' Get values of the variables in the received message
        Dim data_cropped As String = Mid(data, start_position, end_position - start_position + 1)

        ' Check if the cropped data is complete, if the start_position - end_possition = 16
        ' This only works if the message has a fixed length, else doesn't work
        If Len(data_cropped) = Len("s_ToPC0000000A_e") Then
            ' Display message to user
            StatusStripLabelWarnings.Text = "Message Extraction Successful: " & data_cropped

            ' Save message in debug
            DisplayMesssages.txtReceived.AppendText(Now.ToString & " " & data_cropped & vbCrLf)

            ' Define variable values an per the received message
            Y0 = Mid(data_cropped, 7, 1)
            Y1 = Mid(data_cropped, 8, 1)
            Y2 = Mid(data_cropped, 9, 1)

            X0 = Mid(data_cropped, 10, 1)
            X1 = Mid(data_cropped, 11, 1)
            X2 = Mid(data_cropped, 12, 1)
            X3 = Mid(data_cropped, 13, 1)

            ' Set the GUI to show vars values
            rbtnStatusY0.Checked = Y0
            rbtnStatusY1.Checked = Y1
            rbtnStatusY2.Checked = Y2

            rbtnX0.Checked = X0
            rbtnX1.Checked = X1
            rbtnX2.Checked = X2
            rbtnX3.Checked = X3

            level = Asc(Mid(data_cropped, 14, 1))
            txtbxLevel.Text = level

            ' Change picture box size according to the level received
            Dim height_difference = CDbl(level_bottom_y - level_start_y) * (1 - (level / 100))

            picbxWaterLevel.Location = New Point(picbxWaterLevel.Location.X, level_start_y + CInt(height_difference))
            picbxWaterLevel.Height = level_bottom_y - picbxWaterLevel.Location.Y
        End If
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
            StatusStripLabelAutoMode.Text = "Automatic Mode is Disabled"

            ' Enable control buttons
            If cfg_is_valid AndAlso SerialPort.IsOpen Then
                rbtnY0On.Enabled = True
                rbtnY1On.Enabled = True
                rbtnY2On.Enabled = True
            End If

            ' If automatic mode, disable buttons
        ElseIf chckbxAutoMode.CheckState = CheckState.Checked Then
            StatusStripLabelAutoMode.Text = "Automatic Mode is Enabled"
            TimerAutoMode.Enabled = True
            rbtnY0On.Enabled = False
            rbtnY1On.Enabled = False
            rbtnY2On.Enabled = False
        End If

    End Sub

    ' Subroutine to disconnect
    Private Sub Disconnect()
        ' Functional actions
        TimerReceive.Enabled = False
        TimerSend.Enabled = False
        SerialPort.Close()

        ' GUI Actions
        OpenPortToolStripMenuItem.Text = "Open Port"
        OpenPortToolStripMenuItem.BackColor = Color.Red
        PortConfigurationToolStripMenuItem.Enabled = True
        FastConnectToolStripMenuItem.Enabled = True
        rbtnY0On.Enabled = False
        rbtnY1On.Enabled = False
        rbtnY2On.Enabled = False
        ConnectionStatusStripLabelPort.Text = "Not connected"
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

    ' Enable fast connect for easier as faster connection
    Private Sub FastConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastConnectToolStripMenuItem.Click
        ModulePortParameters.port = "COM2"
        ModulePortParameters.data_bits = 8
        ModulePortParameters.stop_bits = 1
        ModulePortParameters.baud_rate = 9600
        ModulePortParameters.parity = Parity.Even
        ModulePortParameters.handshake = Handshake.None
        ModulePortParameters.encoding = Encoding.UTF8
        ModulePortParameters.cfg_is_valid = True

        With SerialPort
            .PortName = ModulePortParameters.port
            .BaudRate = ModulePortParameters.baud_rate
            .Parity = ModulePortParameters.parity
            .DataBits = ModulePortParameters.data_bits
            .StopBits = ModulePortParameters.stop_bits
            .Encoding = ModulePortParameters.encoding
            .Handshake = ModulePortParameters.handshake
        End With

        FastConnectToolStripMenuItem.Enabled = False

        OpenPortToolStripMenuItem.PerformClick()
    End Sub

    '------------------------------------
    ' Automatic mode
    '------------------------------------
    Private Sub TimerAutoMode_Tick(sender As Object, e As EventArgs) Handles TimerAutoMode.Tick
        If (X0 = 1 AndAlso X1 = 0) OrElse level < 5 Then
            StatusStripLabelAutoMode.Text = "Warning! Water level is dangerously low!"
            Y0 = 1
            Y1 = 1
            Y2 = 0

        ElseIf (X1 = 1 AndAlso X2 = 0) OrElse level < 75 Then
            StatusStripLabelAutoMode.Text = "X1 on, filling the reservoir"
            Y0 = 1
            Y1 = 1
            Y2 = 1

        ElseIf (X2 = 1 AndAlso X3 = 0) Then
            StatusStripLabelAutoMode.Text = "X2 on, reservoir full"
            Y0 = 0
            Y1 = 0
            Y2 = 1

        ElseIf (X3 = 1) Then
            StatusStripLabelAutoMode.Text = "Warning! Water level too high!"
            Y0 = 0
            Y1 = 0
            Y2 = 1
        End If

    End Sub

    '------------------------------------
    ' Send message every tick
    '------------------------------------
    Private Sub TimerSend_Tick(sender As Object, e As EventArgs) Handles TimerSend.Tick
        Dim output As String = "s_ToPLC" & CStr(Y0) & CStr(Y1) & CStr(Y2) & "_e"

        SerialPort.Write(output)

        DisplayMesssages.txtSent.AppendText($"{Now}{output}{vbCrLf}")
        SentStripStatusLabel.Text = "Message Sent: " & output

        UpdateButtonImages()
    End Sub

    ' About box
    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MsgBox("Reservoir control made by Fábio Sousa, with the mec. 84400 in 20/03/2023 for the class 'Industrial Informatics'")

    End Sub

    Private Sub AutomaticModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutomaticModeToolStripMenuItem.Click
        MsgBox("Automatic mode detects the state of the reservoir, fills when needed and emits alarms when empty or full. After X1, it allows the water to be consumed.")
    End Sub

    Private Sub FastConnectToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FastConnectToolStripMenuItem1.Click
        MsgBox(" Fast connect is defaulted to COM2, 9600bps, 8Even1.")
    End Sub
End Class
