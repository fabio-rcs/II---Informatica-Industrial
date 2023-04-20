<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Server_Form
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gboxReception = New System.Windows.Forms.GroupBox()
        Me.txtbxReception = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxVelocityReceive = New System.Windows.Forms.TextBox()
        Me.chckbxY2 = New System.Windows.Forms.CheckBox()
        Me.chckbxY1 = New System.Windows.Forms.CheckBox()
        Me.chckbxY0 = New System.Windows.Forms.CheckBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.gbxTransmission = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxVelocitySend = New System.Windows.Forms.TextBox()
        Me.chckbxX3 = New System.Windows.Forms.CheckBox()
        Me.chckbxX2 = New System.Windows.Forms.CheckBox()
        Me.chckbxX1 = New System.Windows.Forms.CheckBox()
        Me.chckbxX0 = New System.Windows.Forms.CheckBox()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimerReceive = New System.Windows.Forms.Timer(Me.components)
        Me.TimerConnection = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSend = New System.Windows.Forms.Timer(Me.components)
        Me.gboxReception.SuspendLayout()
        Me.gbxTransmission.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboxReception
        '
        Me.gboxReception.Controls.Add(Me.txtbxReception)
        Me.gboxReception.Controls.Add(Me.Label1)
        Me.gboxReception.Controls.Add(Me.txtbxVelocityReceive)
        Me.gboxReception.Controls.Add(Me.chckbxY2)
        Me.gboxReception.Controls.Add(Me.chckbxY1)
        Me.gboxReception.Controls.Add(Me.chckbxY0)
        Me.gboxReception.Location = New System.Drawing.Point(26, 12)
        Me.gboxReception.Name = "gboxReception"
        Me.gboxReception.Size = New System.Drawing.Size(404, 215)
        Me.gboxReception.TabIndex = 0
        Me.gboxReception.TabStop = False
        Me.gboxReception.Text = "Reception"
        '
        'txtbxReception
        '
        Me.txtbxReception.Location = New System.Drawing.Point(6, 32)
        Me.txtbxReception.Name = "txtbxReception"
        Me.txtbxReception.ReadOnly = True
        Me.txtbxReception.Size = New System.Drawing.Size(240, 177)
        Me.txtbxReception.TabIndex = 8
        Me.txtbxReception.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Motor Velocity"
        '
        'txtbxVelocityReceive
        '
        Me.txtbxVelocityReceive.Location = New System.Drawing.Point(353, 91)
        Me.txtbxVelocityReceive.Name = "txtbxVelocityReceive"
        Me.txtbxVelocityReceive.ReadOnly = True
        Me.txtbxVelocityReceive.Size = New System.Drawing.Size(45, 22)
        Me.txtbxVelocityReceive.TabIndex = 6
        '
        'chckbxY2
        '
        Me.chckbxY2.AutoCheck = False
        Me.chckbxY2.AutoSize = True
        Me.chckbxY2.Location = New System.Drawing.Point(353, 65)
        Me.chckbxY2.Name = "chckbxY2"
        Me.chckbxY2.Size = New System.Drawing.Size(45, 20)
        Me.chckbxY2.TabIndex = 5
        Me.chckbxY2.Text = "Y2"
        Me.chckbxY2.UseVisualStyleBackColor = True
        '
        'chckbxY1
        '
        Me.chckbxY1.AutoCheck = False
        Me.chckbxY1.AutoSize = True
        Me.chckbxY1.Location = New System.Drawing.Point(353, 39)
        Me.chckbxY1.Name = "chckbxY1"
        Me.chckbxY1.Size = New System.Drawing.Size(45, 20)
        Me.chckbxY1.TabIndex = 4
        Me.chckbxY1.Text = "Y1"
        Me.chckbxY1.UseVisualStyleBackColor = True
        '
        'chckbxY0
        '
        Me.chckbxY0.AutoCheck = False
        Me.chckbxY0.AutoSize = True
        Me.chckbxY0.Location = New System.Drawing.Point(353, 13)
        Me.chckbxY0.Name = "chckbxY0"
        Me.chckbxY0.Size = New System.Drawing.Size(45, 20)
        Me.chckbxY0.TabIndex = 3
        Me.chckbxY0.Text = "Y0"
        Me.chckbxY0.UseVisualStyleBackColor = True
        '
        'gbxTransmission
        '
        Me.gbxTransmission.Controls.Add(Me.Label2)
        Me.gbxTransmission.Controls.Add(Me.txtbxVelocitySend)
        Me.gbxTransmission.Controls.Add(Me.chckbxX3)
        Me.gbxTransmission.Controls.Add(Me.chckbxX2)
        Me.gbxTransmission.Controls.Add(Me.chckbxX1)
        Me.gbxTransmission.Controls.Add(Me.chckbxX0)
        Me.gbxTransmission.Location = New System.Drawing.Point(26, 248)
        Me.gbxTransmission.Name = "gbxTransmission"
        Me.gbxTransmission.Size = New System.Drawing.Size(404, 199)
        Me.gbxTransmission.TabIndex = 1
        Me.gbxTransmission.TabStop = False
        Me.gbxTransmission.Text = "Transmission"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Motor Velocity "
        '
        'txtbxVelocitySend
        '
        Me.txtbxVelocitySend.Location = New System.Drawing.Point(0, 171)
        Me.txtbxVelocitySend.Name = "txtbxVelocitySend"
        Me.txtbxVelocitySend.Size = New System.Drawing.Size(45, 22)
        Me.txtbxVelocitySend.TabIndex = 10
        '
        'chckbxX3
        '
        Me.chckbxX3.AutoSize = True
        Me.chckbxX3.Location = New System.Drawing.Point(6, 141)
        Me.chckbxX3.Name = "chckbxX3"
        Me.chckbxX3.Size = New System.Drawing.Size(44, 20)
        Me.chckbxX3.TabIndex = 9
        Me.chckbxX3.Text = "X3"
        Me.chckbxX3.UseVisualStyleBackColor = True
        '
        'chckbxX2
        '
        Me.chckbxX2.AutoSize = True
        Me.chckbxX2.Location = New System.Drawing.Point(6, 104)
        Me.chckbxX2.Name = "chckbxX2"
        Me.chckbxX2.Size = New System.Drawing.Size(44, 20)
        Me.chckbxX2.TabIndex = 8
        Me.chckbxX2.Text = "X2"
        Me.chckbxX2.UseVisualStyleBackColor = True
        '
        'chckbxX1
        '
        Me.chckbxX1.AutoSize = True
        Me.chckbxX1.Location = New System.Drawing.Point(6, 66)
        Me.chckbxX1.Name = "chckbxX1"
        Me.chckbxX1.Size = New System.Drawing.Size(44, 20)
        Me.chckbxX1.TabIndex = 7
        Me.chckbxX1.Text = "X1"
        Me.chckbxX1.UseVisualStyleBackColor = True
        '
        'chckbxX0
        '
        Me.chckbxX0.AutoSize = True
        Me.chckbxX0.Location = New System.Drawing.Point(6, 31)
        Me.chckbxX0.Name = "chckbxX0"
        Me.chckbxX0.Size = New System.Drawing.Size(44, 20)
        Me.chckbxX0.TabIndex = 6
        Me.chckbxX0.Text = "X0"
        Me.chckbxX0.UseVisualStyleBackColor = True
        '
        'btnOff
        '
        Me.btnOff.AutoSize = True
        Me.btnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOff.Location = New System.Drawing.Point(347, 453)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(83, 44)
        Me.btnOff.TabIndex = 2
        Me.btnOff.Text = "Turn Off"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 508)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(446, 26)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'TimerReceive
        '
        '
        'TimerConnection
        '
        '
        'TimerSend
        '
        '
        'Server_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 534)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.gbxTransmission)
        Me.Controls.Add(Me.gboxReception)
        Me.Location = New System.Drawing.Point(960, 200)
        Me.Name = "Server_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Server"
        Me.gboxReception.ResumeLayout(False)
        Me.gboxReception.PerformLayout()
        Me.gbxTransmission.ResumeLayout(False)
        Me.gbxTransmission.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gboxReception As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxVelocityReceive As TextBox
    Friend WithEvents chckbxY2 As CheckBox
    Friend WithEvents chckbxY1 As CheckBox
    Friend WithEvents chckbxY0 As CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents gbxTransmission As GroupBox
    Friend WithEvents btnOff As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxVelocitySend As TextBox
    Friend WithEvents chckbxX3 As CheckBox
    Friend WithEvents chckbxX2 As CheckBox
    Friend WithEvents chckbxX1 As CheckBox
    Friend WithEvents chckbxX0 As CheckBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TimerReceive As Timer
    Friend WithEvents TimerConnection As Timer
    Friend WithEvents TimerSend As Timer
    Friend WithEvents txtbxReception As RichTextBox
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
End Class
