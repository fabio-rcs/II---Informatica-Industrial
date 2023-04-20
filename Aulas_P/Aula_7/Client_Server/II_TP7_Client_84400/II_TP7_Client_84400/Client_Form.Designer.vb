<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Client_Form
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtbxVelocityReceive = New System.Windows.Forms.TextBox()
        Me.chckbxX0 = New System.Windows.Forms.CheckBox()
        Me.chckbxX1 = New System.Windows.Forms.CheckBox()
        Me.labelMotorVelocityReceive = New System.Windows.Forms.Label()
        Me.chckbxX2 = New System.Windows.Forms.CheckBox()
        Me.chckbxX3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chckbxY2 = New System.Windows.Forms.CheckBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.chckbxY0 = New System.Windows.Forms.CheckBox()
        Me.chckbxY1 = New System.Windows.Forms.CheckBox()
        Me.labelMotorSend = New System.Windows.Forms.Label()
        Me.txtbxVelocitySend = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.TimerReceive = New System.Windows.Forms.Timer(Me.components)
        Me.TimerConnection = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtbxVelocityReceive)
        Me.GroupBox2.Controls.Add(Me.chckbxX0)
        Me.GroupBox2.Controls.Add(Me.chckbxX1)
        Me.GroupBox2.Controls.Add(Me.labelMotorVelocityReceive)
        Me.GroupBox2.Controls.Add(Me.chckbxX2)
        Me.GroupBox2.Controls.Add(Me.chckbxX3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 303)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(329, 195)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reception"
        '
        'txtbxVelocityReceive
        '
        Me.txtbxVelocityReceive.Location = New System.Drawing.Point(7, 156)
        Me.txtbxVelocityReceive.Name = "txtbxVelocityReceive"
        Me.txtbxVelocityReceive.ReadOnly = True
        Me.txtbxVelocityReceive.Size = New System.Drawing.Size(45, 22)
        Me.txtbxVelocityReceive.TabIndex = 11
        '
        'chckbxX0
        '
        Me.chckbxX0.AutoCheck = False
        Me.chckbxX0.AutoSize = True
        Me.chckbxX0.Location = New System.Drawing.Point(7, 31)
        Me.chckbxX0.Name = "chckbxX0"
        Me.chckbxX0.Size = New System.Drawing.Size(44, 20)
        Me.chckbxX0.TabIndex = 6
        Me.chckbxX0.Text = "X0"
        Me.chckbxX0.UseVisualStyleBackColor = True
        '
        'chckbxX1
        '
        Me.chckbxX1.AutoCheck = False
        Me.chckbxX1.AutoSize = True
        Me.chckbxX1.Location = New System.Drawing.Point(7, 62)
        Me.chckbxX1.Name = "chckbxX1"
        Me.chckbxX1.Size = New System.Drawing.Size(44, 20)
        Me.chckbxX1.TabIndex = 7
        Me.chckbxX1.Text = "X1"
        Me.chckbxX1.UseVisualStyleBackColor = True
        '
        'labelMotorVelocityReceive
        '
        Me.labelMotorVelocityReceive.AutoSize = True
        Me.labelMotorVelocityReceive.Location = New System.Drawing.Point(58, 162)
        Me.labelMotorVelocityReceive.Name = "labelMotorVelocityReceive"
        Me.labelMotorVelocityReceive.Size = New System.Drawing.Size(92, 16)
        Me.labelMotorVelocityReceive.TabIndex = 13
        Me.labelMotorVelocityReceive.Text = "Motor Velocity"
        '
        'chckbxX2
        '
        Me.chckbxX2.AutoCheck = False
        Me.chckbxX2.AutoSize = True
        Me.chckbxX2.Location = New System.Drawing.Point(7, 98)
        Me.chckbxX2.Name = "chckbxX2"
        Me.chckbxX2.Size = New System.Drawing.Size(44, 20)
        Me.chckbxX2.TabIndex = 8
        Me.chckbxX2.Text = "X2"
        Me.chckbxX2.UseVisualStyleBackColor = True
        '
        'chckbxX3
        '
        Me.chckbxX3.AutoCheck = False
        Me.chckbxX3.AutoSize = True
        Me.chckbxX3.Location = New System.Drawing.Point(8, 130)
        Me.chckbxX3.Name = "chckbxX3"
        Me.chckbxX3.Size = New System.Drawing.Size(44, 20)
        Me.chckbxX3.TabIndex = 9
        Me.chckbxX3.Text = "X3"
        Me.chckbxX3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chckbxY2)
        Me.GroupBox1.Controls.Add(Me.btnSend)
        Me.GroupBox1.Controls.Add(Me.chckbxY0)
        Me.GroupBox1.Controls.Add(Me.chckbxY1)
        Me.GroupBox1.Controls.Add(Me.labelMotorSend)
        Me.GroupBox1.Controls.Add(Me.txtbxVelocitySend)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 196)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transmission"
        '
        'chckbxY2
        '
        Me.chckbxY2.AutoSize = True
        Me.chckbxY2.Location = New System.Drawing.Point(6, 96)
        Me.chckbxY2.Name = "chckbxY2"
        Me.chckbxY2.Size = New System.Drawing.Size(45, 20)
        Me.chckbxY2.TabIndex = 5
        Me.chckbxY2.Text = "Y2"
        Me.chckbxY2.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.AutoSize = True
        Me.btnSend.Location = New System.Drawing.Point(248, 167)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 26)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'chckbxY0
        '
        Me.chckbxY0.AutoSize = True
        Me.chckbxY0.Location = New System.Drawing.Point(6, 32)
        Me.chckbxY0.Name = "chckbxY0"
        Me.chckbxY0.Size = New System.Drawing.Size(45, 20)
        Me.chckbxY0.TabIndex = 3
        Me.chckbxY0.Text = "Y0"
        Me.chckbxY0.UseVisualStyleBackColor = True
        '
        'chckbxY1
        '
        Me.chckbxY1.AutoSize = True
        Me.chckbxY1.Location = New System.Drawing.Point(6, 64)
        Me.chckbxY1.Name = "chckbxY1"
        Me.chckbxY1.Size = New System.Drawing.Size(45, 20)
        Me.chckbxY1.TabIndex = 4
        Me.chckbxY1.Text = "Y1"
        Me.chckbxY1.UseVisualStyleBackColor = True
        '
        'labelMotorSend
        '
        Me.labelMotorSend.AutoSize = True
        Me.labelMotorSend.Location = New System.Drawing.Point(57, 137)
        Me.labelMotorSend.Name = "labelMotorSend"
        Me.labelMotorSend.Size = New System.Drawing.Size(92, 16)
        Me.labelMotorSend.TabIndex = 12
        Me.labelMotorSend.Text = "Motor Velocity"
        '
        'txtbxVelocitySend
        '
        Me.txtbxVelocitySend.Location = New System.Drawing.Point(6, 131)
        Me.txtbxVelocitySend.Name = "txtbxVelocitySend"
        Me.txtbxVelocitySend.Size = New System.Drawing.Size(45, 22)
        Me.txtbxVelocitySend.TabIndex = 10
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 517)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(382, 26)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'btnConnect
        '
        Me.btnConnect.AutoSize = True
        Me.btnConnect.Font = New System.Drawing.Font("Ink Free", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(12, 17)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(329, 53)
        Me.btnConnect.TabIndex = 17
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'TimerReceive
        '
        '
        'TimerConnection
        '
        '
        'Client_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 543)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnConnect)
        Me.Location = New System.Drawing.Point(250, 200)
        Me.Name = "Client_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtbxVelocityReceive As TextBox
    Friend WithEvents chckbxX0 As CheckBox
    Friend WithEvents chckbxX1 As CheckBox
    Friend WithEvents labelMotorVelocityReceive As Label
    Friend WithEvents chckbxX2 As CheckBox
    Friend WithEvents chckbxX3 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chckbxY2 As CheckBox
    Friend WithEvents btnSend As Button
    Friend WithEvents chckbxY0 As CheckBox
    Friend WithEvents chckbxY1 As CheckBox
    Friend WithEvents labelMotorSend As Label
    Friend WithEvents txtbxVelocitySend As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents btnConnect As Button
    Friend WithEvents TimerReceive As Timer
    Friend WithEvents TimerConnection As Timer
End Class