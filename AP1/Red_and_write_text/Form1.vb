Imports System.IO
Imports System.Xml

Public Class Form1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim fileToSave As StreamWriter
        fileToSave = New StreamWriter(txtPath.Text, True)
        fileToSave.Write("Parse")
        fileToSave.Close()
    End Sub
    Private Sub button_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim result As Integer
        result = OpenFileDialog1.ShowDialog()
        If result = 1 Then
            Dim file As StreamReader
            file = New StreamReader(OpenFileDialog1.FileName)
            txtRead.Text = file.ReadToEnd()
            file.Close()
        End If
    End Sub
End Class