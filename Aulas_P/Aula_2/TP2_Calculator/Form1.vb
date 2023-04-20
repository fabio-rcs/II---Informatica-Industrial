Imports System.Windows.Forms.PropertyGridInternal

Public Class Form1

    'Global program variables
    Dim operator1 As String
    Dim operator2 As String
    Dim operation As String

    '------------------------------------------------
    ' Initialization routine
    '------------------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Define refresh rate
        TimerDate.Interval = 500
        Timer1.Interval = 500
        Timer1.Enabled = True
        ' Start timer
        TimerDate.Enabled = True

        'Define window text, notes and icon
        Me.Text = "Calculator"
        CreatorStripStatus.Text = "Creator: Fábio Sousa, 84400"
        Me.Icon = New Icon("ua_favicon.ico")
    End Sub

    '------------------------------------------------
    ' Math operation buttons callback
    '------------------------------------------------
    Private Sub SetOperationAndOperator1(operation_arg As String, operator1_arg As String)
        ' Set operation
        operation = operation_arg

        'Set operator 1
        operator1 = operator1_arg

        'Delete from the result textbox
        txtResult.Text = ""

        'For debug, show operator1 and operation
        txtOp1.Text = operator1
        txtOp.Text = operation
    End Sub

    Private Sub BtnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        SetOperationAndOperator1("+", txtResult.Text)
    End Sub

    Private Sub BtnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        SetOperationAndOperator1("-", txtResult.Text)
    End Sub

    Private Sub BtMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        SetOperationAndOperator1("x", txtResult.Text)
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        SetOperationAndOperator1("/", txtResult.Text)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtResult.Text = ""
        txtOp1.Text = ""
        txtOp2.Text = ""
        txtOp.Text = ""
    End Sub

    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        operator2 = txtResult.Text

        'Show Operator 2 for debug
        txtOp2.Text = operator2

        'Actual math 
        If IsNumeric(operator1) And IsNumeric(operator2) Then
            If operation = "+" Then
                txtResult.Text = CDbl(operator1) + CDbl(operator2)
            ElseIf operation = "-" Then
                txtResult.Text = CDbl(operator1) - CDbl(operator2)
            ElseIf operation = "x" Then
                txtResult.Text = CDbl(operator1) * CDbl(operator2)
            ElseIf operation = "/" Then
                txtResult.Text = CDbl(operator1) / CDbl(operator2)
            End If
        Else
            txtResult.Text = "Invalid Input"
        End If
    End Sub

    '------------------------------------------------
    ' Keyboard to buttons callback
    '------------------------------------------------
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If GetAsyncKeyState(Keys.NumPad0) Or GetAsyncKeyState(Keys.D0) Then
            btn0.PerformClick()

        ElseIf GetAsyncKeyState(Keys.NumPad1) Or GetAsyncKeyState(Keys.D1) Then
            btn1.PerformClick()

        ElseIf GetAsyncKeyState(Keys.NumPad2) Or GetAsyncKeyState(Keys.D2) Then
            btn2.PerformClick()

        ElseIf GetAsyncKeyState(Keys.NumPad3) Or GetAsyncKeyState(Keys.D3) Then
            btn3.PerformClick()

        ElseIf GetAsyncKeyState(Keys.NumPad4) Or GetAsyncKeyState(Keys.D4) Then
            btn4.PerformClick()

        ElseIf GetAsyncKeyState(Keys.NumPad5) Or GetAsyncKeyState(Keys.D5) Then
            btn5.PerformClick()

        ElseIf GetAsyncKeyState(Keys.NumPad6) Or GetAsyncKeyState(Keys.D6) Then
            btn6.PerformClick()

        ElseIf GetAsyncKeyState(Keys.NumPad7) Or GetAsyncKeyState(Keys.D7) Then
            btn7.PerformClick()

        ElseIf GetAsyncKeyState(Keys.NumPad8) Or GetAsyncKeyState(Keys.D8) Then
            btn8.PerformClick()

        ElseIf GetAsyncKeyState(Keys.NumPad9) Or GetAsyncKeyState(Keys.D9) Then
            btn9.PerformClick()

        ElseIf GetAsyncKeyState(Keys.Oemcomma) Or GetAsyncKeyState(Keys.Decimal) Then
            btnPoint.PerformClick()

        ElseIf GetAsyncKeyState(Keys.Add) Then
            btnSum.PerformClick()

        ElseIf GetAsyncKeyState(Keys.Subtract) Then
            btnSubtract.PerformClick()

        ElseIf GetAsyncKeyState(Keys.Multiply) Then
            btnMultiply.PerformClick()

        ElseIf GetAsyncKeyState(Keys.Divide) Then
            btnDivide.PerformClick()

        ElseIf GetAsyncKeyState(Keys.Enter) Then
            btnEqual.PerformClick()

        ElseIf GetAsyncKeyState(Keys.Delete) Or GetAsyncKeyState(Keys.Back) Then
            btnClear.PerformClick()

        End If
    End Sub

    '------------------------------------------------
    ' Numeric buttons callback
    '------------------------------------------------
    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtResult.Text = txtResult.Text + "0"
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtResult.Text = txtResult.Text + "1"
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtResult.Text = txtResult.Text + "2"
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtResult.Text = txtResult.Text + "3"
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtResult.Text = txtResult.Text + "4"
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtResult.Text = txtResult.Text + "5"
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtResult.Text = txtResult.Text + "6"
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtResult.Text = txtResult.Text + "7"
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtResult.Text = txtResult.Text + "8"
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtResult.Text = txtResult.Text + "9"
    End Sub
    Private Sub BtnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        txtResult.Text = txtResult.Text + ","
    End Sub

    '------------------------------------------------
    ' Other methods
    '------------------------------------------------
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    'Actual time and date show and update with timer
    Private Sub TimerDate_Tick(sender As Object, e As EventArgs) Handles TimerDate.Tick
        TimeStatusLabel.Text = "Time: " + Format(Now, "HH:mm:ss")
        DateStatusLabel.Text = "Date: " + Format(Now, "dd/MM/yyyy")

    End Sub
End Class