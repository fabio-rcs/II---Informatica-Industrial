Public Class Form1
    Dim fs As New FaconSvr.FaconServer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fs.OpenProject("B:\Universidade de Aveiro\Informática Industrial\Aulas_T\reservoir.fcs")
        Timer1.Interval = 1000
        Timer1.Enabled = True
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        fs.Connect()
    End Sub

    Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        txtItem.Text = fs.GetItem("Channel0.Station0.Group0", "M100")
    End Sub

    Private Sub BtnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Dim ss As String
        ss = txtItem.Text
        fs.SetItem("Channel0.Station0.Group0", "M100", ss)
    End Sub

    Private Sub BtnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        fs.Disconnect()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        fs.Disconnect()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeDateStatusLabel.Text = "Aveiro, " + Now.ToString
        txtbxD4076Velocity.Text = fs.GetItem("Channel0.Station0.Group0", "D4076")
        cbxY0.Checked = fs.GetItem("Channel0.Station0.Group0", "Y0")
    End Sub

    Private Sub TxtbxD4076VelocityControl_TextChanged(sender As Object, e As EventArgs) Handles txtbxD4076VelocityControl.TextChanged
        fs.SetItem("Channel0.Station0.Group0", "D4076", txtbxD4076VelocityControl.Text)
    End Sub

    Private Sub BtnY0On_Click(sender As Object, e As EventArgs) Handles btnY0On.Click
        fs.SetItem("Channel0.Station0.Group0", "Y0", "1")
    End Sub

    Private Sub BtnY0Off_Click(sender As Object, e As EventArgs) Handles btnY0Off.Click
        fs.SetItem("Channel0.Station0.Group0", "Y0", "0")
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

End Class
