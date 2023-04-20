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
        Me.components = New System.ComponentModel.Container()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtOp1 = New System.Windows.Forms.TextBox()
        Me.txtOp2 = New System.Windows.Forms.TextBox()
        Me.txtOp = New System.Windows.Forms.TextBox()
        Me.labelOp1 = New System.Windows.Forms.Label()
        Me.labelOp2 = New System.Windows.Forms.Label()
        Me.labelOp = New System.Windows.Forms.Label()
        Me.labelResult = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.DateStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimeStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CreatorStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimerDate = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnPoint = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ComoUtilizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.WorksLikeANormalCalculatorYouCanUseTheButtonsOrTheKeyboardForInputsToolStripMenuItem = New System.Windows.Forms.ToolStripTextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtResult.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtResult.Location = New System.Drawing.Point(12, 114)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(330, 31)
        Me.txtResult.TabIndex = 1
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn1.Location = New System.Drawing.Point(12, 161)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(50, 50)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn2.Location = New System.Drawing.Point(62, 161)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(50, 50)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn3.Location = New System.Drawing.Point(112, 161)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(50, 50)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btnDivide
        '
        Me.btnDivide.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDivide.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDivide.Location = New System.Drawing.Point(162, 311)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(80, 50)
        Me.btnDivide.TabIndex = 5
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = False
        '
        'btnMultiply
        '
        Me.btnMultiply.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMultiply.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMultiply.Location = New System.Drawing.Point(162, 261)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(80, 50)
        Me.btnMultiply.TabIndex = 6
        Me.btnMultiply.Text = "x"
        Me.btnMultiply.UseVisualStyleBackColor = False
        '
        'btnSubtract
        '
        Me.btnSubtract.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSubtract.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSubtract.Location = New System.Drawing.Point(162, 211)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(80, 50)
        Me.btnSubtract.TabIndex = 7
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = False
        '
        'btnSum
        '
        Me.btnSum.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSum.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSum.Location = New System.Drawing.Point(162, 161)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(80, 50)
        Me.btnSum.TabIndex = 8
        Me.btnSum.Text = "+"
        Me.btnSum.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn0.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn0.Location = New System.Drawing.Point(12, 311)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(100, 50)
        Me.btn0.TabIndex = 9
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn9.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn9.Location = New System.Drawing.Point(112, 261)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(50, 50)
        Me.btn9.TabIndex = 10
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn8.Location = New System.Drawing.Point(62, 261)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(50, 50)
        Me.btn8.TabIndex = 11
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn7.Location = New System.Drawing.Point(12, 261)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(50, 50)
        Me.btn7.TabIndex = 12
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn6.Location = New System.Drawing.Point(112, 211)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(50, 50)
        Me.btn6.TabIndex = 13
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn5.Location = New System.Drawing.Point(62, 211)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(50, 50)
        Me.btn5.TabIndex = 14
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn4.Location = New System.Drawing.Point(12, 211)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(50, 50)
        Me.btn4.TabIndex = 15
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(242, 161)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 100)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnEqual
        '
        Me.btnEqual.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEqual.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEqual.Location = New System.Drawing.Point(242, 261)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(100, 100)
        Me.btnEqual.TabIndex = 17
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(248, 390)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 29)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtOp1
        '
        Me.txtOp1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtOp1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtOp1.Location = New System.Drawing.Point(12, 61)
        Me.txtOp1.Name = "txtOp1"
        Me.txtOp1.ReadOnly = True
        Me.txtOp1.Size = New System.Drawing.Size(125, 27)
        Me.txtOp1.TabIndex = 19
        '
        'txtOp2
        '
        Me.txtOp2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtOp2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtOp2.Location = New System.Drawing.Point(217, 61)
        Me.txtOp2.Name = "txtOp2"
        Me.txtOp2.ReadOnly = True
        Me.txtOp2.Size = New System.Drawing.Size(125, 27)
        Me.txtOp2.TabIndex = 20
        '
        'txtOp
        '
        Me.txtOp.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtOp.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtOp.Location = New System.Drawing.Point(162, 61)
        Me.txtOp.Name = "txtOp"
        Me.txtOp.ReadOnly = True
        Me.txtOp.Size = New System.Drawing.Size(28, 27)
        Me.txtOp.TabIndex = 21
        Me.txtOp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelOp1
        '
        Me.labelOp1.AutoSize = True
        Me.labelOp1.Location = New System.Drawing.Point(12, 38)
        Me.labelOp1.Name = "labelOp1"
        Me.labelOp1.Size = New System.Drawing.Size(88, 20)
        Me.labelOp1.TabIndex = 22
        Me.labelOp1.Text = "1st operand"
        '
        'labelOp2
        '
        Me.labelOp2.AutoSize = True
        Me.labelOp2.Location = New System.Drawing.Point(229, 38)
        Me.labelOp2.Name = "labelOp2"
        Me.labelOp2.Size = New System.Drawing.Size(94, 20)
        Me.labelOp2.TabIndex = 23
        Me.labelOp2.Text = "2nd operand"
        '
        'labelOp
        '
        Me.labelOp.AutoSize = True
        Me.labelOp.Location = New System.Drawing.Point(138, 38)
        Me.labelOp.Name = "labelOp"
        Me.labelOp.Size = New System.Drawing.Size(76, 20)
        Me.labelOp.TabIndex = 24
        Me.labelOp.Text = "Operation"
        '
        'labelResult
        '
        Me.labelResult.AutoSize = True
        Me.labelResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelResult.Location = New System.Drawing.Point(12, 91)
        Me.labelResult.Name = "labelResult"
        Me.labelResult.Size = New System.Drawing.Size(53, 20)
        Me.labelResult.TabIndex = 25
        Me.labelResult.Text = "Result"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateStatusLabel, Me.TimeStatusLabel, Me.CreatorStripStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(362, 22)
        Me.StatusStrip1.TabIndex = 26
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'DateStatusLabel
        '
        Me.DateStatusLabel.Name = "DateStatusLabel"
        Me.DateStatusLabel.Size = New System.Drawing.Size(119, 16)
        Me.DateStatusLabel.Text = "ToolStripStatusLabel1"
        '
        'TimeStatusLabel
        '
        Me.TimeStatusLabel.Name = "TimeStatusLabel"
        Me.TimeStatusLabel.Size = New System.Drawing.Size(93, 16)
        Me.TimeStatusLabel.Text = "TimeStatusLabel"
        '
        'CreatorStripStatus
        '
        Me.CreatorStripStatus.Name = "CreatorStripStatus"
        Me.CreatorStripStatus.Size = New System.Drawing.Size(119, 16)
        Me.CreatorStripStatus.Text = "ToolStripStatusLabel1"
        Me.CreatorStripStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TimerDate
        '
        '
        'Timer1
        '
        '
        'btnPoint
        '
        Me.btnPoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPoint.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPoint.Location = New System.Drawing.Point(112, 311)
        Me.btnPoint.Name = "btnPoint"
        Me.btnPoint.Size = New System.Drawing.Size(50, 50)
        Me.btnPoint.TabIndex = 27
        Me.btnPoint.Text = "."
        Me.btnPoint.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(362, 28)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem, Me.ComoUtilizarToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.AjudaToolStripMenuItem.Text = "Help"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox2, Me.ToolStripTextBox3, Me.ToolStripTextBox1})
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.SobreToolStripMenuItem.Text = "About"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.ReadOnly = True
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 27)
        Me.ToolStripTextBox2.Text = "Version 1.0"
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.ReadOnly = True
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(100, 27)
        Me.ToolStripTextBox3.Text = "Class II"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.ReadOnly = True
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.ToolStripTextBox1.Text = "Made By Fábio Sousa"
        '
        'ComoUtilizarToolStripMenuItem
        '
        Me.ComoUtilizarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox4, Me.WorksLikeANormalCalculatorYouCanUseTheButtonsOrTheKeyboardForInputsToolStripMenuItem})
        Me.ComoUtilizarToolStripMenuItem.Name = "ComoUtilizarToolStripMenuItem"
        Me.ComoUtilizarToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.ComoUtilizarToolStripMenuItem.Text = "How to use"
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.ReadOnly = True
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(300, 27)
        Me.ToolStripTextBox4.Text = "App that performs the required calculations."
        '
        'WorksLikeANormalCalculatorYouCanUseTheButtonsOrTheKeyboardForInputsToolStripMenuItem
        '
        Me.WorksLikeANormalCalculatorYouCanUseTheButtonsOrTheKeyboardForInputsToolStripMenuItem.AutoSize = False
        Me.WorksLikeANormalCalculatorYouCanUseTheButtonsOrTheKeyboardForInputsToolStripMenuItem.Name = "WorksLikeANormalCalculatorYouCanUseTheButtonsOrTheKeyboardForInputsToolStripMenuI" &
    "tem"
        Me.WorksLikeANormalCalculatorYouCanUseTheButtonsOrTheKeyboardForInputsToolStripMenuItem.ReadOnly = True
        Me.WorksLikeANormalCalculatorYouCanUseTheButtonsOrTheKeyboardForInputsToolStripMenuItem.Size = New System.Drawing.Size(634, 27)
        Me.WorksLikeANormalCalculatorYouCanUseTheButtonsOrTheKeyboardForInputsToolStripMenuItem.Text = " Works like a normal calculator. You can use the buttons or the keyboard for inpu" &
    "ts"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(362, 453)
        Me.Controls.Add(Me.btnPoint)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.labelResult)
        Me.Controls.Add(Me.labelOp)
        Me.Controls.Add(Me.labelOp2)
        Me.Controls.Add(Me.labelOp1)
        Me.Controls.Add(Me.txtOp)
        Me.Controls.Add(Me.txtOp2)
        Me.Controls.Add(Me.txtOp1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtResult)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "9"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnSum As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtOp1 As TextBox
    Friend WithEvents txtOp2 As TextBox
    Friend WithEvents txtOp As TextBox
    Friend WithEvents labelOp1 As Label
    Friend WithEvents labelOp2 As Label
    Friend WithEvents labelOp As Label
    Friend WithEvents labelResult As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TimeStatusLabel As ToolStripStatusLabel
    Friend WithEvents TimerDate As Timer
    Friend WithEvents DateStatusLabel As ToolStripStatusLabel
    Friend WithEvents CreatorStripStatus As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnPoint As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ComoUtilizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents ToolStripTextBox3 As ToolStripTextBox
    Friend WithEvents ToolStripTextBox4 As ToolStripTextBox
    Friend WithEvents WorksLikeANormalCalculatorYouCanUseTheButtonsOrTheKeyboardForInputsToolStripMenuItem As ToolStripTextBox
End Class
