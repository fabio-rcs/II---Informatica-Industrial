'In this class is defined all the necessary code for the interface (window) execution
Public Class Form1
    'The sub is automatically executed once when the window pops up 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This function is executed at the start of the app

        'Calculator properties
        Text = "Calculadora" 'The word 'Calculadora' appears in the top of the window
        BackgroundImage = Image.FromFile("B:\source\repos\Inf_Indust\docs\ua-top-1.jpg") 'Background image of the window
        Height = 200 'Window size in screen
        Width = 500
        Icon = New Icon("B:\source\repos\Inf_Indust\docs\ua-favicon.ico") 'Icon of the window in the top left

        'TextBox properties
        'the box top left corner has coordinates X=50,Y=40
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
        btnSum.BackColor = Color.Red 'Define button background as red
        btnSum.ForeColor = Color.Yellow 'and the text in yellow
        btnSum.Location = New Point(175, 75)
        btnSum.Visible = True
        btnSum.Height = 40
        btnSum.Width = 100

        label_x.Text = "X"
        label_x.BackColor = Color.Yellow 'Background of label_x is becomes yellow
        label_x.ForeColor = Color.Black 'and text becomes black
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

    'When the user clicks on the button (+) if the interface, this sub will be executed:
    'TODO The functions associated with design elements can be automatically generated with a double click 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSum.Click

        'The contents of the text boxes are converted to integers and the result is visualized in the text box at the right
        If IsNumeric(txtbx_y.Text) And IsNumeric(txtbx_x.Text) Then
            txtbx_z.Text = CInt(txtbx_y.Text) + CInt(txtbx_x.Text)
        End If

        'If the text is not numeric, raise an error
        If Not IsNumeric(txtbx_y.Text) Or Not IsNumeric(txtbx_x.Text) Then
            txtbx_z.Text = CStr(<Text>Invalid input</Text>)
        End If

    End Sub

End Class