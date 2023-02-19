Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Text = "Image Selector"
        BackgroundImage = Image.FromFile("..\..\..\..\..\..\docs\ua-top-1.jpg")
        Height = 500
        Width = 800
        Icon = New Icon("..\..\..\..\..\..\docs\ua-favicon.ico")
        With rtbn_bubbles
            .Text = "Bolhas"
            .Location = New Point(50, 50)
            .Width = 50
            .Height = 25
        End With

        With rbtn_stones
            .Text = "Pedras"
            .Location = New Point(50, 70)
            .Width = 50
            .Height = 25
            .Select()
            .BackColor = Color.Aquamarine
        End With

        With rbtn_salmon
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
                                            e As EventArgs) Handles rtbn_bubbles.CheckedChanged
        rtbn_bubbles.BackColor = Color.Aquamarine
        rbtn_stones.BackColor = Color.Empty
        rbtn_salmon.BackColor = Color.Empty
        PictureBox1.BackgroundImage = Image.FromFile("..\..\..\..\..\..\docs\bolhas.jpg")
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object,
                                            e As EventArgs) Handles rbtn_stones.CheckedChanged
        rbtn_stones.BackColor = Color.Aquamarine
        rtbn_bubbles.BackColor = Color.Empty
        rbtn_salmon.BackColor = Color.Empty
        PictureBox1.BackgroundImage = Image.FromFile("..\..\..\..\..\..\docs\pedra.jpg")
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object,
                                            e As EventArgs) Handles rbtn_salmon.CheckedChanged
        rbtn_salmon.BackColor = Color.Aquamarine
        rtbn_bubbles.BackColor = Color.Empty
        rbtn_stones.BackColor = Color.Empty
        PictureBox1.BackgroundImage = Image.FromFile("..\..\..\..\..\..\docs\salmao.jpg")
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
End Class
