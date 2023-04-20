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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommunicationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenPortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ConnectionStatusStripLabelPort = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusStripLabelAutoMode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStripLabelWarnings = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SentStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimerAutoMode = New System.Windows.Forms.Timer(Me.components)
        Me.TimerReceive = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.txtbxLevel = New System.Windows.Forms.TextBox()
        Me.picbxY2 = New System.Windows.Forms.PictureBox()
        Me.picbxY1 = New System.Windows.Forms.PictureBox()
        Me.picbxWaterLevel = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picbxY0 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chckbxAutoMode = New System.Windows.Forms.CheckBox()
        Me.rbtnY0On = New System.Windows.Forms.Button()
        Me.rbtnY1On = New System.Windows.Forms.Button()
        Me.rbtnY2On = New System.Windows.Forms.Button()
        Me.TimerSend = New System.Windows.Forms.Timer(Me.components)
        Me.rbtnStatusY0 = New System.Windows.Forms.CheckBox()
        Me.rbtnStatusY1 = New System.Windows.Forms.CheckBox()
        Me.rbtnStatusY2 = New System.Windows.Forms.CheckBox()
        Me.rbtnX0 = New System.Windows.Forms.CheckBox()
        Me.rbtnX1 = New System.Windows.Forms.CheckBox()
        Me.rbtnX2 = New System.Windows.Forms.CheckBox()
        Me.rbtnX3 = New System.Windows.Forms.CheckBox()
        Me.AutomaticModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastConnectToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.ConnectionStatusStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.picbxY2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbxY1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbxWaterLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbxY0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(965, 417)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CommunicationsToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(992, 28)
        Me.MenuStrip.TabIndex = 11
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.ExitToolStripMenuItem.Text = "Close"
        '
        'CommunicationsToolStripMenuItem
        '
        Me.CommunicationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PortConfigurationToolStripMenuItem, Me.OpenPortToolStripMenuItem, Me.FastConnectToolStripMenuItem})
        Me.CommunicationsToolStripMenuItem.Name = "CommunicationsToolStripMenuItem"
        Me.CommunicationsToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.CommunicationsToolStripMenuItem.Text = "Communications"
        '
        'PortConfigurationToolStripMenuItem
        '
        Me.PortConfigurationToolStripMenuItem.Name = "PortConfigurationToolStripMenuItem"
        Me.PortConfigurationToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PortConfigurationToolStripMenuItem.Text = "Port configuration"
        '
        'OpenPortToolStripMenuItem
        '
        Me.OpenPortToolStripMenuItem.Name = "OpenPortToolStripMenuItem"
        Me.OpenPortToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OpenPortToolStripMenuItem.Text = "Open Port"
        '
        'FastConnectToolStripMenuItem
        '
        Me.FastConnectToolStripMenuItem.Name = "FastConnectToolStripMenuItem"
        Me.FastConnectToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.FastConnectToolStripMenuItem.Text = "Fast Connect"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DebugFormToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'DebugFormToolStripMenuItem
        '
        Me.DebugFormToolStripMenuItem.Name = "DebugFormToolStripMenuItem"
        Me.DebugFormToolStripMenuItem.Size = New System.Drawing.Size(137, 26)
        Me.DebugFormToolStripMenuItem.Text = "Debug"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.AutomaticModeToolStripMenuItem, Me.FastConnectToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'ConnectionStatusStrip
        '
        Me.ConnectionStatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ConnectionStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectionStatusStripLabelPort})
        Me.ConnectionStatusStrip.Location = New System.Drawing.Point(0, 472)
        Me.ConnectionStatusStrip.Name = "ConnectionStatusStrip"
        Me.ConnectionStatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.ConnectionStatusStrip.Size = New System.Drawing.Size(992, 26)
        Me.ConnectionStatusStrip.TabIndex = 12
        Me.ConnectionStatusStrip.Text = "StatusStrip1"
        '
        'ConnectionStatusStripLabelPort
        '
        Me.ConnectionStatusStripLabelPort.Name = "ConnectionStatusStripLabelPort"
        Me.ConnectionStatusStripLabelPort.Size = New System.Drawing.Size(217, 20)
        Me.ConnectionStatusStripLabelPort.Text = "ConnectionStatusStripLabelPort"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusStripLabelAutoMode, Me.StatusStripLabelWarnings, Me.SentStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 446)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(992, 26)
        Me.StatusStrip.TabIndex = 13
        Me.StatusStrip.Text = "StatusStrip2"
        '
        'StatusStripLabelAutoMode
        '
        Me.StatusStripLabelAutoMode.Name = "StatusStripLabelAutoMode"
        Me.StatusStripLabelAutoMode.Size = New System.Drawing.Size(187, 20)
        Me.StatusStripLabelAutoMode.Text = "StatusStripLabelAutoMode"
        '
        'StatusStripLabelWarnings
        '
        Me.StatusStripLabelWarnings.Name = "StatusStripLabelWarnings"
        Me.StatusStripLabelWarnings.Size = New System.Drawing.Size(177, 20)
        Me.StatusStripLabelWarnings.Text = "StatusStripLabelWarnings"
        '
        'SentStripStatusLabel
        '
        Me.SentStripStatusLabel.Name = "SentStripStatusLabel"
        Me.SentStripStatusLabel.Size = New System.Drawing.Size(145, 20)
        Me.SentStripStatusLabel.Text = "SentStripStatusLabel"
        '
        'TimerAutoMode
        '
        '
        'TimerReceive
        '
        '
        'txtbxLevel
        '
        Me.txtbxLevel.Location = New System.Drawing.Point(508, 54)
        Me.txtbxLevel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbxLevel.Name = "txtbxLevel"
        Me.txtbxLevel.Size = New System.Drawing.Size(39, 22)
        Me.txtbxLevel.TabIndex = 14
        '
        'picbxY2
        '
        Me.picbxY2.BackColor = System.Drawing.Color.Silver
        Me.picbxY2.Location = New System.Drawing.Point(791, 240)
        Me.picbxY2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picbxY2.Name = "picbxY2"
        Me.picbxY2.Size = New System.Drawing.Size(123, 26)
        Me.picbxY2.TabIndex = 15
        Me.picbxY2.TabStop = False
        '
        'picbxY1
        '
        Me.picbxY1.BackColor = System.Drawing.Color.Silver
        Me.picbxY1.Location = New System.Drawing.Point(251, 142)
        Me.picbxY1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picbxY1.Name = "picbxY1"
        Me.picbxY1.Size = New System.Drawing.Size(123, 26)
        Me.picbxY1.TabIndex = 16
        Me.picbxY1.TabStop = False
        '
        'picbxWaterLevel
        '
        Me.picbxWaterLevel.BackColor = System.Drawing.Color.DodgerBlue
        Me.picbxWaterLevel.Location = New System.Drawing.Point(440, 107)
        Me.picbxWaterLevel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picbxWaterLevel.Name = "picbxWaterLevel"
        Me.picbxWaterLevel.Size = New System.Drawing.Size(167, 231)
        Me.picbxWaterLevel.TabIndex = 17
        Me.picbxWaterLevel.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picbxY0
        '
        Me.picbxY0.Location = New System.Drawing.Point(55, 198)
        Me.picbxY0.Margin = New System.Windows.Forms.Padding(4)
        Me.picbxY0.Name = "picbxY0"
        Me.picbxY0.Size = New System.Drawing.Size(80, 74)
        Me.picbxY0.TabIndex = 21
        Me.picbxY0.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(481, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Water Level"
        '
        'chckbxAutoMode
        '
        Me.chckbxAutoMode.AutoSize = True
        Me.chckbxAutoMode.Location = New System.Drawing.Point(55, 58)
        Me.chckbxAutoMode.Margin = New System.Windows.Forms.Padding(4)
        Me.chckbxAutoMode.Name = "chckbxAutoMode"
        Me.chckbxAutoMode.Size = New System.Drawing.Size(94, 20)
        Me.chckbxAutoMode.TabIndex = 24
        Me.chckbxAutoMode.Text = "Auto Mode"
        Me.chckbxAutoMode.UseVisualStyleBackColor = True
        '
        'rbtnY0On
        '
        Me.rbtnY0On.Location = New System.Drawing.Point(51, 318)
        Me.rbtnY0On.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnY0On.Name = "rbtnY0On"
        Me.rbtnY0On.Size = New System.Drawing.Size(100, 80)
        Me.rbtnY0On.TabIndex = 28
        Me.rbtnY0On.Text = "Turn Y0 On"
        Me.rbtnY0On.UseVisualStyleBackColor = True
        '
        'rbtnY1On
        '
        Me.rbtnY1On.Location = New System.Drawing.Point(259, 218)
        Me.rbtnY1On.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnY1On.Name = "rbtnY1On"
        Me.rbtnY1On.Size = New System.Drawing.Size(100, 80)
        Me.rbtnY1On.TabIndex = 29
        Me.rbtnY1On.Text = "Turn Y1 On"
        Me.rbtnY1On.UseVisualStyleBackColor = True
        '
        'rbtnY2On
        '
        Me.rbtnY2On.Location = New System.Drawing.Point(801, 318)
        Me.rbtnY2On.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnY2On.Name = "rbtnY2On"
        Me.rbtnY2On.Size = New System.Drawing.Size(100, 80)
        Me.rbtnY2On.TabIndex = 30
        Me.rbtnY2On.Text = "Turn Y2 On"
        Me.rbtnY2On.UseVisualStyleBackColor = True
        '
        'TimerSend
        '
        '
        'rbtnStatusY0
        '
        Me.rbtnStatusY0.AutoCheck = False
        Me.rbtnStatusY0.AutoSize = True
        Me.rbtnStatusY0.Location = New System.Drawing.Point(55, 107)
        Me.rbtnStatusY0.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnStatusY0.Name = "rbtnStatusY0"
        Me.rbtnStatusY0.Size = New System.Drawing.Size(67, 52)
        Me.rbtnStatusY0.TabIndex = 36
        Me.rbtnStatusY0.Text = "Y0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pump " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rbtnStatusY0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtnStatusY0.UseVisualStyleBackColor = True
        '
        'rbtnStatusY1
        '
        Me.rbtnStatusY1.AutoCheck = False
        Me.rbtnStatusY1.AutoSize = True
        Me.rbtnStatusY1.Location = New System.Drawing.Point(259, 75)
        Me.rbtnStatusY1.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnStatusY1.Name = "rbtnStatusY1"
        Me.rbtnStatusY1.Size = New System.Drawing.Size(89, 52)
        Me.rbtnStatusY1.TabIndex = 37
        Me.rbtnStatusY1.Text = "Y1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EValve In " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rbtnStatusY1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtnStatusY1.UseVisualStyleBackColor = True
        '
        'rbtnStatusY2
        '
        Me.rbtnStatusY2.AutoCheck = False
        Me.rbtnStatusY2.AutoSize = True
        Me.rbtnStatusY2.Location = New System.Drawing.Point(791, 181)
        Me.rbtnStatusY2.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnStatusY2.Name = "rbtnStatusY2"
        Me.rbtnStatusY2.Size = New System.Drawing.Size(99, 52)
        Me.rbtnStatusY2.TabIndex = 38
        Me.rbtnStatusY2.Text = "Y2 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EValve Out " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rbtnStatusY2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtnStatusY2.UseVisualStyleBackColor = True
        '
        'rbtnX0
        '
        Me.rbtnX0.AutoCheck = False
        Me.rbtnX0.AutoSize = True
        Me.rbtnX0.Location = New System.Drawing.Point(613, 318)
        Me.rbtnX0.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnX0.Name = "rbtnX0"
        Me.rbtnX0.Size = New System.Drawing.Size(44, 20)
        Me.rbtnX0.TabIndex = 39
        Me.rbtnX0.Text = "X0"
        Me.rbtnX0.UseVisualStyleBackColor = True
        '
        'rbtnX1
        '
        Me.rbtnX1.AutoCheck = False
        Me.rbtnX1.AutoSize = True
        Me.rbtnX1.Location = New System.Drawing.Point(613, 262)
        Me.rbtnX1.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnX1.Name = "rbtnX1"
        Me.rbtnX1.Size = New System.Drawing.Size(44, 20)
        Me.rbtnX1.TabIndex = 40
        Me.rbtnX1.Text = "X1"
        Me.rbtnX1.UseVisualStyleBackColor = True
        '
        'rbtnX2
        '
        Me.rbtnX2.AutoCheck = False
        Me.rbtnX2.AutoSize = True
        Me.rbtnX2.Location = New System.Drawing.Point(615, 146)
        Me.rbtnX2.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnX2.Name = "rbtnX2"
        Me.rbtnX2.Size = New System.Drawing.Size(44, 20)
        Me.rbtnX2.TabIndex = 41
        Me.rbtnX2.Text = "X2"
        Me.rbtnX2.UseVisualStyleBackColor = True
        '
        'rbtnX3
        '
        Me.rbtnX3.AutoCheck = False
        Me.rbtnX3.AutoSize = True
        Me.rbtnX3.Location = New System.Drawing.Point(613, 107)
        Me.rbtnX3.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnX3.Name = "rbtnX3"
        Me.rbtnX3.Size = New System.Drawing.Size(44, 20)
        Me.rbtnX3.TabIndex = 42
        Me.rbtnX3.Text = "X3"
        Me.rbtnX3.UseVisualStyleBackColor = True
        '
        'AutomaticModeToolStripMenuItem
        '
        Me.AutomaticModeToolStripMenuItem.Name = "AutomaticModeToolStripMenuItem"
        Me.AutomaticModeToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AutomaticModeToolStripMenuItem.Text = "Automatic Mode"
        '
        'FastConnectToolStripMenuItem1
        '
        Me.FastConnectToolStripMenuItem1.Name = "FastConnectToolStripMenuItem1"
        Me.FastConnectToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.FastConnectToolStripMenuItem1.Text = "Fast Connect"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 498)
        Me.Controls.Add(Me.rbtnX3)
        Me.Controls.Add(Me.rbtnX2)
        Me.Controls.Add(Me.rbtnX1)
        Me.Controls.Add(Me.rbtnX0)
        Me.Controls.Add(Me.rbtnStatusY2)
        Me.Controls.Add(Me.rbtnStatusY1)
        Me.Controls.Add(Me.rbtnStatusY0)
        Me.Controls.Add(Me.rbtnY2On)
        Me.Controls.Add(Me.rbtnY1On)
        Me.Controls.Add(Me.rbtnY0On)
        Me.Controls.Add(Me.chckbxAutoMode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.picbxY0)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picbxWaterLevel)
        Me.Controls.Add(Me.picbxY1)
        Me.Controls.Add(Me.picbxY2)
        Me.Controls.Add(Me.txtbxLevel)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.ConnectionStatusStrip)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ConnectionStatusStrip.ResumeLayout(False)
        Me.ConnectionStatusStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.picbxY2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbxY1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbxWaterLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbxY0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbtnY0 As RadioButton
    Friend WithEvents rbtnY1 As RadioButton
    Friend WithEvents rbtnY2 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ConnectionStatusStrip As StatusStrip
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents TimerAutoMode As Timer
    Friend WithEvents TimerReceive As Timer
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents txtbxLevel As TextBox
    Friend WithEvents picbxY2 As PictureBox
    Friend WithEvents picbxY1 As PictureBox
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommunicationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PortConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DebugFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenPortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStripLabelAutoMode As ToolStripStatusLabel
    Friend WithEvents StatusStripLabelWarnings As ToolStripStatusLabel
    Friend WithEvents picbxWaterLevel As PictureBox
    Friend WithEvents ConnectionStatusStripLabelPort As ToolStripStatusLabel
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents picbxY0 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chckbxAutoMode As CheckBox
    Friend WithEvents rbtnY0On As Button
    Friend WithEvents rbtnY1On As Button
    Friend WithEvents rbtnY2On As Button
    Friend WithEvents SentStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FastConnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerSend As Timer
    Friend WithEvents rbtnStatusY0 As CheckBox
    Friend WithEvents rbtnStatusY1 As CheckBox
    Friend WithEvents rbtnStatusY2 As CheckBox
    Friend WithEvents rbtnX0 As CheckBox
    Friend WithEvents rbtnX1 As CheckBox
    Friend WithEvents rbtnX2 As CheckBox
    Friend WithEvents rbtnX3 As CheckBox
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AutomaticModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FastConnectToolStripMenuItem1 As ToolStripMenuItem
End Class
