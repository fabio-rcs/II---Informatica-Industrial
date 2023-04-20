Public Class Form1
    ' When the user selects a new date in DateTimePicker, this sub is called
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txtbx_year.Text = DateTimePicker1.Value.Year
        txtbx_month.Text = DateTimePicker1.Value.Month
        txtbx_day.Text = DateTimePicker1.Value.Day
        txtbx_date.Text = DateTimePicker1.Value.Date

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Window formatting
        Text = "Image Selector"
        BackgroundImage = Image.FromFile("..\..\..\..\..\..\docs\ua-top-1.jpg")
        Height = 500
        Width = 400
        Icon = New Icon("..\..\..\..\..\..\docs\ua-favicon.ico")

        'Define labels text
        label_year.Text = "Year"
        label_month.Text = "Month"
        label_day.Text = "Day"
        label_date.Text = "Date"

        'Define textboxes initial content
        txtbx_year.Text = DateTimePicker1.Value.Year
        txtbx_month.Text = DateTimePicker1.Value.Month
        txtbx_day.Text = DateTimePicker1.Value.Day
        txtbx_date.Text = DateTimePicker1.Value.Date
    End Sub
End Class
