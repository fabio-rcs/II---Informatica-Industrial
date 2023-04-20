<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.txtbxIP = New System.Windows.Forms.TextBox()
        Me.txtbxNs = New System.Windows.Forms.TextBox()
        Me.txtbxS = New System.Windows.Forms.TextBox()
        Me.txtbxRead = New System.Windows.Forms.TextBox()
        Me.txtbxWrite = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfig
        '
        Me.btnConfig.AutoSize = True
        Me.btnConfig.Location = New System.Drawing.Point(161, 59)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(164, 26)
        Me.btnConfig.TabIndex = 0
        Me.btnConfig.Text = "Update Configuration"
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.AutoSize = True
        Me.btnStart.Location = New System.Drawing.Point(161, 88)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(164, 26)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start Connection"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.AutoSize = True
        Me.btnStop.Location = New System.Drawing.Point(161, 117)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(164, 26)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Stop Connection"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.AutoSize = True
        Me.btnRead.Location = New System.Drawing.Point(161, 205)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(164, 26)
        Me.btnRead.TabIndex = 3
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnWrite
        '
        Me.btnWrite.AutoSize = True
        Me.btnWrite.Location = New System.Drawing.Point(161, 382)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(164, 26)
        Me.btnWrite.TabIndex = 4
        Me.btnWrite.Text = "Write"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'txtbxIP
        '
        Me.txtbxIP.Location = New System.Drawing.Point(102, 31)
        Me.txtbxIP.Name = "txtbxIP"
        Me.txtbxIP.Size = New System.Drawing.Size(279, 22)
        Me.txtbxIP.TabIndex = 5
        '
        'txtbxNs
        '
        Me.txtbxNs.Location = New System.Drawing.Point(102, 149)
        Me.txtbxNs.Name = "txtbxNs"
        Me.txtbxNs.Size = New System.Drawing.Size(279, 22)
        Me.txtbxNs.TabIndex = 6
        '
        'txtbxS
        '
        Me.txtbxS.Location = New System.Drawing.Point(102, 177)
        Me.txtbxS.Name = "txtbxS"
        Me.txtbxS.Size = New System.Drawing.Size(279, 22)
        Me.txtbxS.TabIndex = 7
        '
        'txtbxRead
        '
        Me.txtbxRead.Location = New System.Drawing.Point(102, 237)
        Me.txtbxRead.Multiline = True
        Me.txtbxRead.Name = "txtbxRead"
        Me.txtbxRead.Size = New System.Drawing.Size(279, 139)
        Me.txtbxRead.TabIndex = 8
        '
        'txtbxWrite
        '
        Me.txtbxWrite.Location = New System.Drawing.Point(102, 414)
        Me.txtbxWrite.Name = "txtbxWrite"
        Me.txtbxWrite.Size = New System.Drawing.Size(279, 22)
        Me.txtbxWrite.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ns"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "s"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Read info"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 414)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Write info"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(415, 28)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 447)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(415, 26)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 473)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbxWrite)
        Me.Controls.Add(Me.txtbxRead)
        Me.Controls.Add(Me.txtbxS)
        Me.Controls.Add(Me.txtbxNs)
        Me.Controls.Add(Me.txtbxIP)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnConfig)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConfig As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnWrite As Button
    Friend WithEvents txtbxIP As TextBox
    Friend WithEvents txtbxNs As TextBox
    Friend WithEvents txtbxS As TextBox
    Friend WithEvents txtbxRead As TextBox
    Friend WithEvents txtbxWrite As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
End Class
