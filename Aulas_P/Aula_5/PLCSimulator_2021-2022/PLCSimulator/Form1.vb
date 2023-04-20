'Imports System.Configuration
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxFIFOLIFO.Items.Add("FIFO")
        ComboBoxFIFOLIFO.Items.Add("LIFO")
        ComboBoxFIFOLIFO.SelectedIndex = 0
        SaveFileDialogReceive.Filter = "Rich Text Files | *.rtf"
        SaveFileDialogReceive.FileName = "received.rtf"
        SaveFileDialogReceive.DefaultExt = "rtf"
        SaveFileDialogSend.Filter = "Rich Text Files | *.rtf"
        SaveFileDialogSend.FileName = "sent.rtf"
        SaveFileDialogSend.DefaultExt = "rtf"
    End Sub

    Private Sub ConfigureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigureParametersToolStripMenuItem.Click
        FormComPortConfiguration.StartPosition = FormStartPosition.CenterParent
        FormComPortConfiguration.ShowDialog()
    End Sub

    Private Sub OpenPortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPortToolStripMenuItem.Click
        If ModuleComPortParameters.configuration_is_valid = True Then
            If SerialPort1.IsOpen Then 'If opened, close. 
                Disconnect()
            Else 'If closed, open. 
                Connect()
            End If
        Else
            MsgBox("Cannot open port with an invalid configuration!")
        End If
    End Sub

    'All necessary actions (funcional and GUI) for making a RS232 connect
    Private Sub Connect()
        'Functional actions
        SerialPort1.Open()
        TimerReceive.Enabled = True
        TimerSend.Enabled = True
        TimerSend.Interval = NumericUpDownSend.Value

        'GUI actions
        OpenPortToolStripMenuItem.Text = "Close Port"
        ConfigureParametersToolStripMenuItem.Enabled = False

        ToolStripStatusLabelConnection.Text = "Connected to " + CStr(ModuleComPortParameters.port) + " " + CStr(ModuleComPortParameters.baud_rate) + " bps, " + CStr(ModuleComPortParameters.data_bits) + CStr(FormComPortConfiguration.ComboBoxParity.SelectedItem) + CStr(ModuleComPortParameters.stop_bits)

    End Sub

    'All necessary actions (funcional and GUI) for making a RS232 disconnect
    Private Sub Disconnect()
        'Functional actions
        TimerReceive.Enabled = False
        TimerSend.Enabled = False
        SerialPort1.Close()

        'GUI actions
        OpenPortToolStripMenuItem.Text = "Open Port"
        ConfigureParametersToolStripMenuItem.Enabled = True

        ToolStripStatusLabelConnection.Text = "Not connected"

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("PLC Emulator. Written by Miguel Riem Oliveira. 15/10/2018. Modified by Jorge Almeida 29/03/2022")
    End Sub

    Private Sub NumericUpDownSend_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownSend.ValueChanged
        TimerSend.Interval = NumericUpDownSend.Value
    End Sub

    Private Sub NumericUpDownReceive_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownReceive.ValueChanged
        TimerReceive.Interval = NumericUpDownReceive.Value
    End Sub

    'Converts boolean values to strings in the 0 or 1 format
    Function BTo01(boolean_value As Boolean) As String
        Return CStr(Convert.ToInt32(boolean_value))
    End Function

    Private Sub TimerSend_Tick(sender As Object, e As EventArgs) Handles TimerSend.Tick
        If CheckBoxDisablePoolingSend.Checked = True Then
            Return
        End If

        'Create message to send
        Dim msg As String = "s_ToPC" _
            + BTo01(CheckBoxY0.Checked) + BTo01(CheckBoxY1.Checked) + BTo01(CheckBoxY2.Checked) _
            + BTo01(CheckBoxX0.Checked) + BTo01(CheckBoxX1.Checked) + BTo01(CheckBoxX2.Checked) + BTo01(CheckBoxX3.Checked) _
            + Chr(NumericUpDownLevel.Value) + "_e"

        'Send the message
        SerialPort1.Write(msg)

        'Show the sent message in the debug form
        RichTextBoxSend.AppendText(Format(Now, "HH:mm:ss ") + msg + vbNewLine)
        'RichTextBoxSend.
        'RichTextBoxSend.ScrollToCaret()

    End Sub

    Private Sub FastConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastConnectToolStripMenuItem.Click

        FormComPortConfiguration.FormComPortConfiguration_Load(Nothing, Nothing)
        FormComPortConfiguration.ButtonOK_Click(Nothing, Nothing)
        Connect()
    End Sub

    Private Sub CheckBoxForceY_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxForceY.CheckedChanged
        If CheckBoxForceY.Checked = False Then
            CheckBoxY0.Enabled = False
            CheckBoxY1.Enabled = False
            CheckBoxY2.Enabled = False
        Else
            CheckBoxY0.Enabled = True
            CheckBoxY1.Enabled = True
            CheckBoxY2.Enabled = True
        End If
    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        Static Dim data_received As String
        Static Dim msg_size As Integer = Len("s_ToPLC000_e")

        'Receive the data
        data_received += SerialPort1.ReadExisting()

        ToolStripStatusLabelReceptionBuffer.Text = "Reception buffer: " + data_received

        If CheckBoxDisablePoolingReceive.Checked = True Then
            Return
        End If

        'Process the data and extract message
        If Len(data_received) >= msg_size Then
            Dim idx As Integer
            If ComboBoxFIFOLIFO.SelectedItem = "FIFO" Then
                idx = FIFOProcessing(data_received, Len("s_ToPLC000_e"))
            ElseIf ComboBoxFIFOLIFO.SelectedItem = "LIFO" Then
                idx = LIFOProcessing(data_received, Len("s_ToPLC000_e"))
            End If

            If idx <> 0 Then
                RichTextBoxReceive.SelectionColor = Color.Black
                RichTextBoxReceive.AppendText(Format(Now, "HH:mm:ss: "))

                RichTextBoxReceive.SelectionColor = Color.DarkGray
                RichTextBoxReceive.AppendText(Mid(data_received, 1, idx - 1))

                RichTextBoxReceive.SelectionColor = Color.Red
                RichTextBoxReceive.AppendText(Mid(data_received, idx, Len("s_")))

                RichTextBoxReceive.SelectionColor = Color.Blue
                RichTextBoxReceive.AppendText(Mid(data_received, idx + Len("s_"), Len("ToPLC")))

                RichTextBoxReceive.SelectionColor = Color.Green
                RichTextBoxReceive.AppendText(Mid(data_received, idx + Len("s_ToPLC"), Len("000")))

                RichTextBoxReceive.SelectionColor = Color.Red
                RichTextBoxReceive.AppendText(Mid(data_received, idx + Len("s_ToPLC000"), Len("_e")))

                RichTextBoxReceive.SelectionColor = Color.DarkGray
                RichTextBoxReceive.AppendText(Mid(data_received, idx + Len("s_ToPLC000_e")))

                RichTextBoxReceive.AppendText(vbNewLine)

                CheckBoxY0.Checked = CBool(Mid(data_received, idx + Len("s_ToPLC"), 1))
                CheckBoxY1.Checked = CBool(Mid(data_received, idx + Len("s_ToPLC0"), 1))
                CheckBoxY2.Checked = CBool(Mid(data_received, idx + Len("s_ToPLC00"), 1))

                data_received = "" 'Clear the incoming buffer

            End If
        End If
    End Sub

    Function FIFOProcessing(data_received As String, msg_size As Integer) As Integer

        Dim idx As Integer = InStr(data_received, "s")
        If idx = 0 Then 'Could not find "s_"
            ToolStripStatusLabelDataReceived.Text = "Msg extraction: Could not find pattern"
        ElseIf (idx + msg_size) > Len(data_received) Then
            ToolStripStatusLabelDataReceived.Text = "Msg extraction: not enough characters"
        Else
            ToolStripStatusLabelDataReceived.Text = "Msg extraction: successful"
            Return idx
        End If
        Return 0
    End Function

    Function LIFOProcessing(data_received As String, msg_size As Integer) As Integer

        Dim idx As Integer = InStrRev(data_received, "e")
        If idx = 0 Then 'Could not find "_e"
            ToolStripStatusLabelDataReceived.Text = "Msg extraction: Could not find pattern"
        ElseIf (idx - msg_size) <= 0 Then
            ToolStripStatusLabelDataReceived.Text = "Msg extraction: not enough characters"
        Else
            ToolStripStatusLabelDataReceived.Text = "Msg extraction: successful"
            Return (idx - msg_size + 1)
        End If
        Return 0
    End Function

    Private Sub ButtonClearReceive_Click(sender As Object, e As EventArgs) Handles ButtonClearReceive.Click
        RichTextBoxReceive.Text = ""
    End Sub

    Private Sub ButtonClearSend_Click(sender As Object, e As EventArgs) Handles ButtonClearSend.Click
        RichTextBoxSend.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub SaveToLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToLogToolStripMenuItem.Click
        'Shows the open file dialog If file is selected returns 1 otherwise returns 2
        If SaveFileDialogReceive.ShowDialog() = 1 Then
            RichTextBoxReceive.SaveFile(SaveFileDialogReceive.FileName)
        End If
    End Sub

    Private Sub SaveSentMsgsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveSentMsgsToolStripMenuItem.Click
        'Shows the open file dialog If file is selected returns 1 otherwise returns 2
        If SaveFileDialogSend.ShowDialog() = 1 Then
            RichTextBoxSend.SaveFile(SaveFileDialogSend.FileName)
        End If
    End Sub
End Class
