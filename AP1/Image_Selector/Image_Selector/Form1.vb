Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Text = "Image Selector"
        BackgroundImage = Image.FromFile("..\..\..\..\..\..\docs\ua-top-1.jpg")
        Height = 500
        Width = 800
        Icon = New Icon("..\..\..\..\..\..\docs\ua-favicon.ico")
        With RadioButton1
            .Text = "Bolhas"
            .Location = New Point(50, 50)
            .Width = 50
            .Height = 25
        End With

        With RadioButton2
            .Text = "Pedras"
            .Location = New Point(50, 70)
            .Width = 50
            .Height = 25
            .Select()
            .BackColor = Color.Aquamarine
        End With

        With RadioButton3
            .Text = "Salmão"
            .Location = New Point(50, 90)
            .Width = 50
            .Height = 25
        End With

        With PictureBox1
            .Location = New Point(200, 20)
            .BackColor = Color.AliceBlue
            .BorderStyle = BorderStyle.Fixed3D
        End With
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object,
                                            e As EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton1.BackColor = Color.Aquamarine
        RadioButton2.BackColor = Color.Empty
        RadioButton3.BackColor = Color.Empty
        PictureBox1.BackgroundImage = Image.FromFile("..\..\..\..\..\..\docs\bolhas.jpg")
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object,
                                            e As EventArgs) Handles RadioButton2.CheckedChanged
        RadioButton2.BackColor = Color.Aquamarine
        RadioButton1.BackColor = Color.Empty
        RadioButton3.BackColor = Color.Empty
        PictureBox1.BackgroundImage = Image.FromFile("..\..\..\..\..\..\docs\pedra.jpg")
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object,
                                            e As EventArgs) Handles RadioButton3.CheckedChanged
        RadioButton3.BackColor = Color.Aquamarine
        RadioButton1.BackColor = Color.Empty
        RadioButton2.BackColor = Color.Empty
        PictureBox1.BackgroundImage = Image.FromFile("..\..\..\..\..\..\docs\salmao.jpg")
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
End Class