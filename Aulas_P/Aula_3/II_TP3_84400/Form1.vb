Public Class Form1

    Dim data_received As String
    Private ReadOnly receivedMessages As New List(Of String)
    Private first_click As Boolean
    '-----------------------------------------------------
    ' Initialization -------------------------------------
    '-----------------------------------------------------

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Serial Communication"

        txtSend.Text = "By Fábio Sousa, 84400"

        ' Enable scrollbars in textboxes
        txtHistory.ScrollBars = ScrollBars.Vertical
        txtSend.ScrollBars = ScrollBars.Vertical
        txtReceived.ScrollBars = ScrollBars.Vertical

        TimerReceive.Interval = 300 'Timer tics every 300ms
        TimerReceive.Enabled = False 'Only start after port is open

        'To make sure we don't open the port without a valid config
        ModulePortParameters.cfg_is_valid = False

        first_click = False
    End Sub


    '-----------------------------------------------------
    ' Serial Port Configuration --------------------------
    '-----------------------------------------------------

    Private Sub BtnCfgPort_Click(sender As Object, e As EventArgs) Handles btnCfgPort.Click
        ' Dim form1 to highlight formPortConfig
        Me.Opacity = 0.5
        ' Show in certer of parent form
        FormPortCfg.StartPosition = FormStartPosition.CenterParent
        ' Show dialog blocks from doing anything in parent form until is closed
        FormPortCfg.ShowDialog()
        ' Return opacity to normal after closing
        Me.Opacity = 1

        ' Only use values from Module to SerialPort is cfg is valid
        If ModulePortParameters.cfg_is_valid = True Then
            If Not SerialPort1.IsOpen Then
                btnOpenPort.BackColor = Color.Red
            End If

            With SerialPort1
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

    'Open and close Serial Port
    Private Sub BtnOpenPort_Click(sender As Object, e As EventArgs) Handles btnOpenPort.Click
        If ModulePortParameters.cfg_is_valid = True Then
            ' If opened, close
            If SerialPort1.IsOpen Then
                SerialPort1.Close()
                btnOpenPort.Text = "Open Port"
                btnOpenPort.BackColor = Color.Red
                TimerReceive.Enabled = False ' Stop receiving

                ' If closed, open
            Else
                ' Try to open the port, if fails, display error
                Try
                    SerialPort1.Open()
                    btnOpenPort.Text = "Close Port"
                    btnOpenPort.BackColor = Color.Green
                    TimerReceive.Enabled = True ' Start receiving at 3.33Hz
                Catch ex As Exception
                    MsgBox(ex.ToString()) ' Error display
                End Try
            End If
        Else
            MsgBox("Cannot open port with invalid configuration")
        End If
    End Sub

    '-----------------------------------------------------
    ' Communication routines -----------------------------
    '-----------------------------------------------------

    ' Send data in txtSend
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim text_sent As String

        If ModulePortParameters.cfg_is_valid = False Then
            MsgBox("You need to configure the port before trying to send messages")
        Else
            ' Try to send text, else display error
            Try
                SerialPort1.Write(txtSend.Text)
                text_sent = TimeOfDay.ToLongTimeString + vbNewLine + " Sent: " + txtSend.Text + vbNewLine
                receivedMessages.Insert(0, text_sent)

                ' Clear the Hostory textbox to display new message on top
                txtHistory.Text = ""

                ' Append to history the list of strings with the most recent on top
                For i As Integer = 0 To receivedMessages.Count - 1
                    txtHistory.Text &= receivedMessages(i) + vbNewLine
                Next

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    ' Receive data
    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        Dim text_rec As String

        data_received &= SerialPort1.ReadExisting

        ' Copy from reception buffet to txtbx if theres something

        ' First we append in the string list
        If Len(data_received) > 0 Then
            text_rec = TimeOfDay.ToLongTimeString + vbNewLine + " Received: " + data_received
            receivedMessages.Insert(0, text_rec)

            ' Copy from data_received
            txtReceived.Text = data_received

            ' Clear the Hostory textbox to display new message on top
            txtHistory.Text = ""

            ' Append to history the list of strings with the most recent on top
            For i As Integer = 0 To receivedMessages.Count - 1
                txtHistory.Text &= receivedMessages(i) + vbNewLine
            Next

            data_received = ""
        End If
    End Sub

    '-----------------------------------------------------
    ' Other routines -------------------------------------
    '-----------------------------------------------------
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    ' Clear the initial text on the send textbox with a click
    Private Sub TxtSend_Click(sender As Object, e As EventArgs) Handles txtSend.Click
        If first_click = False Then
            txtSend.Text = ""
            first_click = True
        End If
    End Sub
End Class