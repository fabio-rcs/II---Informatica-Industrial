<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.labelOp1 = New System.Windows.Forms.Label()
        Me.labelOp2 = New System.Windows.Forms.Label()
        Me.labelEqual = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.labelResult = New System.Windows.Forms.Label()
        Me.txtOp1 = New System.Windows.Forms.TextBox()
        Me.txtOp2 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtRead = New System.Windows.Forms.TextBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelOp1
        '
        Me.labelOp1.AutoSize = True
        Me.labelOp1.BackColor = System.Drawing.SystemColors.Window
        Me.labelOp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelOp1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelOp1.Location = New System.Drawing.Point(12, 7)
        Me.labelOp1.Name = "labelOp1"
        Me.labelOp1.Size = New System.Drawing.Size(65, 25)
        Me.labelOp1.TabIndex = 0
        Me.labelOp1.Text = "Label1"
        '
        'labelOp2
        '
        Me.labelOp2.AutoSize = True
        Me.labelOp2.BackColor = System.Drawing.SystemColors.Window
        Me.labelOp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelOp2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelOp2.Location = New System.Drawing.Point(222, 7)
        Me.labelOp2.Name = "labelOp2"
        Me.labelOp2.Size = New System.Drawing.Size(65, 25)
        Me.labelOp2.TabIndex = 1
        Me.labelOp2.Text = "Label2"
        '
        'labelEqual
        '
        Me.labelEqual.AutoSize = True
        Me.labelEqual.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelEqual.Location = New System.Drawing.Point(374, 35)
        Me.labelEqual.Name = "labelEqual"
        Me.labelEqual.Size = New System.Drawing.Size(55, 20)
        Me.labelEqual.TabIndex = 2
        Me.labelEqual.Text = "Label3"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(12, 117)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 100)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Button1"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMultiply.Location = New System.Drawing.Point(12, 223)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(100, 100)
        Me.btnMultiply.TabIndex = 4
        Me.btnMultiply.Text = "Button2"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSubtract.Location = New System.Drawing.Point(118, 117)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(100, 100)
        Me.btnSubtract.TabIndex = 5
        Me.btnSubtract.Text = "Button3"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDivide.Location = New System.Drawing.Point(118, 223)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(100, 100)
        Me.btnDivide.TabIndex = 6
        Me.btnDivide.Text = "Button4"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(458, 294)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 29)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Button5"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'labelResult
        '
        Me.labelResult.AutoSize = True
        Me.labelResult.BackColor = System.Drawing.SystemColors.Window
        Me.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelResult.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelResult.Location = New System.Drawing.Point(425, 4)
        Me.labelResult.Name = "labelResult"
        Me.labelResult.Size = New System.Drawing.Size(65, 25)
        Me.labelResult.TabIndex = 8
        Me.labelResult.Text = "Label4"
        '
        'txtOp1
        '
        Me.txtOp1.Location = New System.Drawing.Point(12, 35)
        Me.txtOp1.Name = "txtOp1"
        Me.txtOp1.Size = New System.Drawing.Size(125, 27)
        Me.txtOp1.TabIndex = 9
        '
        'txtOp2
        '
        Me.txtOp2.Location = New System.Drawing.Point(222, 35)
        Me.txtOp2.Name = "txtOp2"
        Me.txtOp2.Size = New System.Drawing.Size(125, 27)
        Me.txtOp2.TabIndex = 10
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(425, 32)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(125, 27)
        Me.txtResult.TabIndex = 11
        '
        'txtRead
        '
        Me.txtRead.Location = New System.Drawing.Point(224, 117)
        Me.txtRead.Multiline = True
        Me.txtRead.Name = "txtRead"
        Me.txtRead.Size = New System.Drawing.Size(328, 171)
        Me.txtRead.TabIndex = 12
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(349, 82)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(94, 29)
        Me.btnRead.TabIndex = 13
        Me.btnRead.Text = "Button1"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(456, 82)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 29)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Button2"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 335)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.txtRead)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtOp2)
        Me.Controls.Add(Me.txtOp1)
        Me.Controls.Add(Me.labelResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.labelEqual)
        Me.Controls.Add(Me.labelOp2)
        Me.Controls.Add(Me.labelOp1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelOp1 As Label
    Friend WithEvents labelOp2 As Label
    Friend WithEvents labelEqual As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents labelResult As Label
    Friend WithEvents txtOp1 As TextBox
    Friend WithEvents txtOp2 As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents txtRead As TextBox
    Friend WithEvents btnRead As Button
    Friend WithEvents btnSave As Button
End Class
