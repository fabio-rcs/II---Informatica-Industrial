Public Class Form1
    ' When the user selects a new date in DateTimePicker, this sub is called
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txt_year.Text = DateTimePicker1.Value.Year
        txt_month.Text = DateTimePicker1.Value.Month
        txt_day.Text = DateTimePicker1.Value.Day
        txt_date.Text = DateTimePicker1.Value.Date

    End Sub
End Class