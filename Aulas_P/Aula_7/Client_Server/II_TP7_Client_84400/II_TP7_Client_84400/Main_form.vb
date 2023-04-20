Public Class Main_form
    '! Main form objective is to open the server and client windows and have relevant informations
    Private Sub Main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Defaults
        ToolStripStatusLabel1.Text = ""
        Me.Text = "Client-Server Connection"
        Timer1.Interval = 1000
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Get current time and date and display it
        ToolStripStatusLabel1.Text = Now.ToString
    End Sub

    Private Sub BtnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        ' Button click opens corresponding window
        Client_Form.Show()
    End Sub

    Private Sub BtnServer_Click(sender As Object, e As EventArgs) Handles btnServer.Click
        ' Button click opens corresponding window
        Server_Form.Show()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Button Exit, ends the program
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Show about informations with only the OK button and the information symbol
        MsgBox("Program made by Fábio Sousa, 84400, for the Practical Assignment #7 of Industrial Informatics class.", vbOKOnly & vbInformation)
    End Sub

    Private Sub HowItWorksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowItWorksToolStripMenuItem.Click
        ' Show how it works informations with only the OK button and the information symbol
        MsgBox("After opening both the client and the server windows, they will communicate with each other trough a TCPIP connection, sending the status of the variables visible in each window", vbOKOnly & vbInformation)
    End Sub
End Class