Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Image Selector"
        BackgroundImage = Image.FromFile("..\..\..\..\..\..\docs\ua-top-1.jpg")
        Height = 170
        Width = 820
        Icon = New Icon("..\..\..\..\..\..\docs\ua-favicon.ico")
        btnOpen.Text = "Open"
        btnSave.Text = "Save"
        ' Filter: Quando a Janela de diálogo aparecer ao utilizador
        ' serao mostrados todos os ficheiros
        OpenFileDialog1.Filter = "All Files|*|Imagem|*.jpg, *.png, .*bmp"
    End Sub
    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim result As Integer
        ' Mostra ao utilizador a janela de diálogo
        ' Na janela de diálogo o utilizador pode retornar "Cancel"
        ' sem selecionar nenhum ficheiro.
        '! Se o ficheiro foi seleccionado a funçao retorna 1 caso contrário retorna 2
        result = OpenFileDialog1.ShowDialog()
        ' Se um ficheiro imagem foi seleccionado
        If result = 1 Then
            ' Quando o utilizador sai da janela de diálogo,
            ' o nome e a localização do ficheiro seleccionado
            ' está memorizado na propriedade "FileName"
            txtOpen.Text = OpenFileDialog1.FileName
        Else
            txtOpen.Text = "Nenhum ficheiro selecionado"
        End If
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveFileDialog1.ShowDialog()
        txtSave.Text = SaveFileDialog1.FileName
    End Sub
End Class