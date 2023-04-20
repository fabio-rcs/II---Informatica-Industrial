Imports System.IO.Ports
Imports System.Runtime.InteropServices
Imports System.Text


Public Class Form1
    ReadOnly fs As New FaconSvr.FaconServer
    ReadOnly CSG As String = "Channel0.Station0.Group0"
    Dim fs_is_connected As Boolean

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

        If ModulePortParameters.cfg_is_valid Then
            ' FaconSrv connection
            fs.OpenProject(ModulePortParameters.faconsrv_path)
        End If
    End Sub

    Private Sub OpenPortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPortToolStripMenuItem.Click
        ' Allow to open port only if config is valid
        If ModulePortParameters.cfg_is_valid Then

            ' If opened, close
            If fs_is_connected Then
                Disconnect()

            Else ' If closed, open
                ' Try to open the port. If fails, display error
                Try
                    fs.Connect()
                    fs_is_connected = True
                    OpenPortToolStripMenuItem.Text = "Disconnect"
                    OpenPortToolStripMenuItem.BackColor = Color.Lime
                    ConnectionStatusStripLabelPort.Text = "Connected To FaconSrv"
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
        Dim data As String

        ' Define variable values an per the received message
        Y0 = fs.GetItem(CSG, "Y0")
        Y1 = fs.GetItem(CSG, "Y1")
        Y2 = fs.GetItem(CSG, "Y2")

        X0 = fs.GetItem(CSG, "X0")
        X1 = fs.GetItem(CSG, "X1")
        X2 = fs.GetItem(CSG, "X2")
        X3 = fs.GetItem(CSG, "X3")

        ' Set the GUI to show vars values
        rbtnStatusY0.Checked = Y0
        rbtnStatusY1.Checked = Y1
        rbtnStatusY2.Checked = Y2

        rbtnX0.Checked = X0
        rbtnX1.Checked = X1
        rbtnX2.Checked = X2
        rbtnX3.Checked = X3

        level = fs.GetItem(CSG, "D300")
        txtbxLevel.Text = level

        data = ($"{Now}{" "}{"s_ToPC"}{Y0}{Y1}{Y2}{X0}{X1}{X2}{X3}{level}{"_e"}{vbCrLf}")

        DisplayMesssages.txtReceived.AppendText(data)

        StatusStripLabelWarnings.Text = "Message received: " & data

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
        fs_is_connected = False
        TimerReceive.Enabled = False
        TimerSend.Enabled = False
        fs.Disconnect()

        ' GUI Actions
        OpenPortToolStripMenuItem.Text = "Connect"
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
        ModulePortParameters.cfg_is_valid = True

        faconsrv_path = "B:\Universidade de Aveiro\Informática Industrial\Aulas_P\Aula_8\II_TP6_84400.fcs"

        FastConnectToolStripMenuItem.Enabled = False

        OpenPortToolStripMenuItem.PerformClick()
    End Sub

    '------------------------------------
    ' Automatic mode
    '------------------------------------
    Private Sub TimerAutoMode_Tick(sender As Object, e As EventArgs) Handles TimerAutoMode.Tick
        If (X0 = 1 AndAlso level < 10) Then
            StatusStripLabelAutoMode.Text = "Warning! Water level is dangerously low!"
            Y0 = 1
            Y1 = 1
            Y2 = 0

        ElseIf (X1 = 1 AndAlso (level >= 10 AndAlso level <= 75)) Then
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
        ElseIf (X0 = 0 AndAlso level < 10) Then
            StatusStripLabelAutoMode.Text = "Error in  sensor X0 or water level sensor"
        ElseIf (X1 = 0 AndAlso (level >= 10 AndAlso level <= 75)) Then
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
        Dim output As String = "s_ToPLC" & CStr(Y0) & CStr(Y1) & CStr(Y2) & "_e"

        'SerialPort.Write(output)
        fs.SetItem(CSG, "Y0", Y0)
        fs.SetItem(CSG, "Y1", Y1)
        fs.SetItem(CSG, "Y2", Y2)

        DisplayMesssages.txtSent.AppendText($"{Now}{" "}{output}{vbCrLf}")
        SentStripStatusLabel.Text = "Message Sent: " & output

        UpdateButtonImages()
    End Sub

    ' About box
    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MsgBox("Reservoir control made by Fábio Sousa, with the mec. 84400 in 20/03/2023 for the class 'Industrial Informatics'")

    End Sub

    Private Sub AutomaticModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutomaticModeToolStripMenuItem.Click
        MsgBox("Automatic mode detects the state of the reservoir, fills when needed and emits alarms when empty or full. After X1, it allows the water to be consumed.
                Thresholds: To be empty, water level < 10 and X0 on
                            To start filling, 10 <= water level <= 75 and X1 on
                            To stop filling, 75 < water level <= 90 and X2 on
                            To be full, water level > 90 and X3 on")
    End Sub

    Private Sub FastConnectToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FastConnectToolStripMenuItem1.Click
        MsgBox("Fast connect is defaulted to the file B:\Universidade de Aveiro\Informática Industrial\Aulas_P\Aula_6\II_TP6_84400.fcs")
    End Sub
End Class
