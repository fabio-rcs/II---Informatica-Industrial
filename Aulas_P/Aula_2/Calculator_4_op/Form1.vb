Imports System.IO
Imports System.Threading

Public Class Form1
    Public Shared FilePath As String = "B:\Universidade de Aveiro\Informática Industrial\Aulas_P\Aula_2\calculus.txt"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Window properties
        Me.Text = "Simple Calculator" 'The word 'Calculadora' appears in the top of the window
        BackgroundImage = Image.FromFile("..\..\..\..\..\..\docs\ua-top-1.jpg") 'Background image of the window
        Icon = New Icon("..\..\..\..\..\..\docs\ua-favicon.ico") 'Icon of the window in the top left
        'labels
        labelOp1.Text = "Operand 1"
        labelOp2.Text = "Operand 2"
        labelEqual.Text = "="
        labelResult.Text = "Result"
        'buttons
        btnAdd.Text = "+"
        btnSubtract.Text = "-"
        btnMultiply.Text = "x"
        btnDivide.Text = "/"
        btnExit.Text = "Exit"
        btnRead.Text = "Read"
        btnSave.Text = "Save"
    End Sub

    'Sum sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Check if text is numeric
        If IsNumeric(txtOp1.Text) And IsNumeric(txtOp2.Text) Then
            txtResult.Text = CDbl(txtOp1.Text) + CDbl(txtOp2.Text)

            'If not numeric, raise error
        Else
            txtResult.Text = "Invalid Input"
        End If
    End Sub

    'Multiply sub
    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click

        If IsNumeric(txtOp1.Text) And IsNumeric(txtOp2.Text) Then
            txtResult.Text = CDbl(txtOp1.Text) * CDbl(txtOp2.Text)

        Else
            txtResult.Text = "Invalid Input"
        End If
    End Sub

    'Subtract sub
    Private Sub BtnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        If IsNumeric(txtOp1.Text) And IsNumeric(txtOp2.Text) Then
            txtResult.Text = CDbl(txtOp1.Text) - CDbl(txtOp2.Text)

        Else
            txtResult.Text = "Invalid Input"
        End If
    End Sub

    'Divide sub
    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If IsNumeric(txtOp1.Text) And IsNumeric(txtOp2.Text) Then
            txtResult.Text = CDbl(txtOp1.Text) / CDbl(txtOp2.Text)

        Else
            txtResult.Text = "Invalid Input"
        End If

    End Sub

    'Exit application sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim textToSave As String
        textToSave = "Log Saved:" + vbCrLf + Now.ToString + ";  Resultado = " + txtResult.Text
        txtRead.Text = textToSave
        FileOpen(1, FilePath, OpenMode.Append)
        PrintLine(1, textToSave + vbCrLf)
        FileClose()
    End Sub

    Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        FileOpen(1, FilePath, OpenMode.Input)
        txtRead.Text = ""
        While (EOF(1) = False)
            txtRead.Text = txtRead.Text + LineInput(1) + vbCrLf
        End While

        FileClose()
    End Sub
End Class