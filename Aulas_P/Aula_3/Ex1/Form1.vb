Imports System.IO.Ports
Public Class Form1
    Dim SerialPort1 As New SerialPort()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Simple communication"
        Icon = New Icon("..\..\..\..\..\..\docs\ua-favicon.ico")
        BackgroundImage = Image.FromFile("..\..\..\..\..\..\docs\ua-top-1.jpg")

        With SerialPort1
            .PortName = "COM2"
            .BaudRate = 19200
            .Parity = Parity.Even
            .DataBits = 8
            .StopBits = 1
            .Handshake = Handshake.None
            .Encoding = System.Text.Encoding.UTF8
        End With

        SerialPort1.Open()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click, btnExit.Click
        End
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim tx = txtSend.Text
        SerialPort1.Write(tx + vbCrLf)
        txtSend.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SerialPort1.BytesToRead > 8 Then
            txtReceive.Text = SerialPort1.ReadExisting
        End If
    End Sub

End Class
