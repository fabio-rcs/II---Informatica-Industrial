Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Styling 
        BackgroundImage = Image.FromFile("..\..\..\..\..\..\docs\ua-top-1.jpg")
        Height = 900
        Width = 800
        Icon = New Icon("..\..\..\..\..\..\docs\ua-favicon.ico")
        TextBox1.Height = 850
        Me.Text = "Bloco de notas"
        LastOperationStatusLabel.Text = ""
        OpenFileDialog1.Filter = "Ficheiros de texto|*.txt" 'Define the file format
        OpenFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "Ficheiros de texto|*.txt"
        UpdateLastChange("")
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim result = OpenFileDialog1.ShowDialog()

        If result = 1 Then
            Dim fileToOpen = New StreamReader(OpenFileDialog1.FileName)
            TextBox1.Text = fileToOpen.ReadToEnd()
            Me.Text = OpenFileDialog1.FileName
            UpdateLastChange("Ficheiro aberto com sucesso.")
        End If
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If TextBox1.Text.Length = 0 Then
            UpdateLastChange("Não existem dados a guardar no ficheiro.")
            Return
        End If

        SaveFileDialog1.FileName = OpenFileDialog1.FileName
        Dim result = SaveFileDialog1.ShowDialog()
        If result = 1 Then
            Dim fileToSave As StreamWriter
            fileToSave = New StreamWriter(SaveFileDialog1.FileName, False)
            fileToSave.Write(TextBox1.Text)
            fileToSave.Close()
            Me.Text = SaveFileDialog1.FileName
            UpdateLastChange("Ficheiro guardado com sucesso")
        End If
    End Sub
    Private Sub UpdateLastChange(status)
        LastChangeStatusLabel.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        LastOperationStatusLabel.Text = status
    End Sub
End Class