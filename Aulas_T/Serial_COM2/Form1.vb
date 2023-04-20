Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Dim tx, rx As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Start()
        SerialPort1.PortName = "com6"
        SerialPort1.BaudRate = 9600
        SerialPort1.Parity = IO.Ports.Parity.Even
        SerialPort1.DataBits = 8
        SerialPort1.StopBits = 2
        SerialPort1.Handshake = IO.Ports.Handshake.None
        SerialPort1.Encoding = System.Text.UTF8Encoding.UTF8
        SerialPort1.Open()
    End Sub
    Private Sub BtnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        tx = txtSend.Text
        SerialPort1.Write(tx)
        'Dim barray() As Byte = {48, 127, 230, 51, 52, 0} 
        'SerialPort1.Write(barray, 0, 6) 
    End Sub
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As EventArgs)
        rx &= SerialPort1.ReadExisting()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        RadioButton1.Checked = Not (RadioButton1.Checked)
        txtReceive.Text = rx
    End Sub
    Private Sub AjudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmAjuda1 As New frmAjuda
        frmAjuda1.ShowDialog()
    End Sub


    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As … 
 If SerialPort1.IsOpen() Then
            SerialPort1.Close()
        End If
    End Sub
End Class