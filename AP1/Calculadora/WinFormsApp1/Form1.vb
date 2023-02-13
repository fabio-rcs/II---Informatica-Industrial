'Nesta classe é definido todo o código necessário para a execução da interface (Janela) Calculadora
Public Class Form1
    'A subrotina Form1_Load é executada automaticamente, uma vez, quando a janela Calculadora aparece no ecrã
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Esta função executada no arranque da aplicação

        'Proprieades da Calculadora
        Text = "Calculadora" 'A palavra Calculadora aparece na parte de cima da janela Calculadora
        BackgroundImage = Image.FromFile("B:\source\repos\Inf_Indust\AP1\docs\ua-top-1.jpg") 'Esta passa a ser a imagem de fundo da janela Form1
        'BackgroundImageLayout = ImageLayout.Stretch
        Height = 200 'A janela ocupa 200 por 500 pixeis no ecrã
        Width = 500
        Icon = New Icon("B:\source\repos\Inf_Indust\AP1\docs\ua-favicon.ico") ' Esta imagem "icon" aparece no canto superior da janela Form1

        'Propriedade da TextBox1
        'A caixa de texto TextBox1, o seu canto superior esquerdo, tem as coordenadas X=50,Y=40
        txtbx_y.Location = New Point(50, 40)
        txtbx_y.Width = 100
        txtbx_y.Height = 30

        txtbx_x.Location = New Point(50, 120)
        txtbx_x.Width = 100
        txtbx_x.Height = 30

        txtbx_z.Location = New Point(300, 75)
        txtbx_z.Height = 100
        txtbx_z.Width = 150

        btnSum.Text = "+"
        btnSum.BackColor = Color.Red 'O botao passa a ter a cor de fundo vermelha
        btnSum.ForeColor = Color.Yellow 'e o texto a amarelo
        btnSum.Location = New Point(175, 75)
        btnSum.Visible = True
        btnSum.Height = 40
        btnSum.Width = 100

        label_x.Text = "X"
        label_x.BackColor = Color.Yellow 'A cor de fundo do Label1 passa a amarelo
        label_x.ForeColor = Color.Black 'e o texto que aparece no Label1, neste caso a letra X, passa preto
        label_x.Width = 100
        label_x.Location = New Point(50, 20)

        label_y.Text = "Y"
        label_y.BackColor = Color.Yellow
        label_y.ForeColor = Color.Black
        label_y.Width = 100
        label_y.Location = New Point(50, 100)

        label_z.Text = "Z"
        label_z.BackColor = Color.Yellow
        label_z.ForeColor = Color.Black
        label_z.Width = 100
        label_z.Location = New Point(300, 55)
    End Sub

    ' Quando o utilizador do programa permir o botão (+) da interface Form1 esta subrotina será executada
    '! É possível criar a base desta função automaticamente by double click no botão no designer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        ' Os conteúdos das caixas de texto da esquerda são convertidos em números inteiros
        ' e o resutado da sua soma é visulizado na caixa de texto da direita (textbox3)
        If IsNumeric(txtbx_y.Text) And IsNumeric(txtbx_x.Text) Then
            txtbx_z.Text = CInt(txtbx_y.Text) + CInt(txtbx_x.Text)
        End If

        If Not IsNumeric(txtbx_y.Text) Or Not IsNumeric(txtbx_x.Text) Then
            txtbx_z.Text = CStr(<Text>Invalid input</Text>)
        End If

    End Sub

End Class