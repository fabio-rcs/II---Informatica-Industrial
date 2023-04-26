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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chckbxX3 = New System.Windows.Forms.CheckBox()
        Me.txtbxWaterLvl = New System.Windows.Forms.TextBox()
        Me.chckbxX2 = New System.Windows.Forms.CheckBox()
        Me.chckbxY2 = New System.Windows.Forms.CheckBox()
        Me.chckbxX1 = New System.Windows.Forms.CheckBox()
        Me.chckbxY1 = New System.Windows.Forms.CheckBox()
        Me.chckbxX0 = New System.Windows.Forms.CheckBox()
        Me.chckbxY0 = New System.Windows.Forms.CheckBox()
        Me.txtbxMessageReceived = New System.Windows.Forms.RichTextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.gbxTransmission = New System.Windows.Forms.GroupBox()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimerReceive = New System.Windows.Forms.Timer(Me.components)
        Me.TimerConnection = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSend = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommunicationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaconServerConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToFaconServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutFastConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ConnectionStatusStripLabelPort = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbxMessageSent = New System.Windows.Forms.RichTextBox()
        Me.gboxReception.SuspendLayout()
        Me.gbxTransmission.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ConnectionStatusStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboxReception
        '
        Me.gboxReception.Controls.Add(Me.Label1)
        Me.gboxReception.Controls.Add(Me.chckbxX3)
        Me.gboxReception.Controls.Add(Me.txtbxWaterLvl)
        Me.gboxReception.Controls.Add(Me.chckbxX2)
        Me.gboxReception.Controls.Add(Me.chckbxY2)
        Me.gboxReception.Controls.Add(Me.chckbxX1)
        Me.gboxReception.Controls.Add(Me.chckbxY1)
        Me.gboxReception.Controls.Add(Me.chckbxX0)
        Me.gboxReception.Controls.Add(Me.chckbxY0)
        Me.gboxReception.Location = New System.Drawing.Point(26, 12)
        Me.gboxReception.Name = "gboxReception"
        Me.gboxReception.Size = New System.Drawing.Size(404, 215)
        Me.gboxReception.TabIndex = 0
        Me.gboxReception.TabStop = False
        Me.gboxReception.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Water Level"
        '
        'chckbxX3
        '
        Me.chckbxX3.AutoCheck = False
        Me.chckbxX3.AutoSize = True
        Me.chckbxX3.Location = New System.Drawing.Point(112, 133)
        Me.chckbxX3.Name = "chckbxX3"
        Me.chckbxX3.Size = New System.Drawing.Size(44, 20)
        Me.chckbxX3.TabIndex = 9
        Me.chckbxX3.Text = "X3"
        Me.chckbxX3.UseVisualStyleBackColor = True
        '
        'txtbxWaterLvl
        '
        Me.txtbxWaterLvl.Location = New System.Drawing.Point(215, 46)
        Me.txtbxWaterLvl.Name = "txtbxWaterLvl"
        Me.txtbxWaterLvl.ReadOnly = True
        Me.txtbxWaterLvl.Size = New System.Drawing.Size(102, 22)
        Me.txtbxWaterLvl.TabIndex = 6
        '
        'chckbxX2
        '
        Me.chckbxX2.AutoCheck = False
        Me.chckbxX2.AutoSize = True
        Me.chckbxX2.Location = New System.Drawing.Point(112, 96)
        Me.chckbxX2.Name = "chckbxX2"
        Me.chckbxX2.Size = New System.Drawing.Size(44, 20)
        Me.chckbxX2.TabIndex = 8
        Me.chckbxX2.Text = "X2"
        Me.chckbxX2.UseVisualStyleBackColor = True
        '
        'chckbxY2
        '
        Me.chckbxY2.AutoCheck = False
        Me.chckbxY2.AutoSize = True
        Me.chckbxY2.Location = New System.Drawing.Point(20, 97)
        Me.chckbxY2.Name = "chckbxY2"
        Me.chckbxY2.Size = New System.Drawing.Size(45, 20)
        Me.chckbxY2.TabIndex = 5
        Me.chckbxY2.Text = "Y2"
        Me.chckbxY2.UseVisualStyleBackColor = True
        '
        'chckbxX1
        '
        Me.chckbxX1.AutoCheck = False
        Me.chckbxX1.AutoSize = True
        Me.chckbxX1.Location = New System.Drawing.Point(112, 58)
        Me.chckbxX1.Name = "chckbxX1"
        Me.chckbxX1.Size = New System.Drawing.Size(44, 20)
        Me.chckbxX1.TabIndex = 7
        Me.chckbxX1.Text = "X1"
        Me.chckbxX1.UseVisualStyleBackColor = True
        '
        'chckbxY1
        '
        Me.chckbxY1.AutoCheck = False
        Me.chckbxY1.AutoSize = True
        Me.chckbxY1.Location = New System.Drawing.Point(20, 58)
        Me.chckbxY1.Name = "chckbxY1"
        Me.chckbxY1.Size = New System.Drawing.Size(45, 20)
        Me.chckbxY1.TabIndex = 4
        Me.chckbxY1.Text = "Y1"
        Me.chckbxY1.UseVisualStyleBackColor = True
        '
        'chckbxX0
        '
        Me.chckbxX0.AutoCheck = False
        Me.chckbxX0.AutoSize = True
        Me.chckbxX0.Location = New System.Drawing.Point(112, 23)
        Me.chckbxX0.Name = "chckbxX0"
        Me.chckbxX0.Size = New System.Drawing.Size(44, 20)
        Me.chckbxX0.TabIndex = 6
        Me.chckbxX0.Text = "X0"
        Me.chckbxX0.UseVisualStyleBackColor = True
        '
        'chckbxY0
        '
        Me.chckbxY0.AutoCheck = False
        Me.chckbxY0.AutoSize = True
        Me.chckbxY0.Location = New System.Drawing.Point(20, 23)
        Me.chckbxY0.Name = "chckbxY0"
        Me.chckbxY0.Size = New System.Drawing.Size(45, 20)
        Me.chckbxY0.TabIndex = 3
        Me.chckbxY0.Text = "Y0"
        Me.chckbxY0.UseVisualStyleBackColor = True
        '
        'txtbxMessageReceived
        '
        Me.txtbxMessageReceived.Location = New System.Drawing.Point(6, 21)
        Me.txtbxMessageReceived.Name = "txtbxMessageReceived"
        Me.txtbxMessageReceived.ReadOnly = True
        Me.txtbxMessageReceived.Size = New System.Drawing.Size(392, 55)
        Me.txtbxMessageReceived.TabIndex = 8
        Me.txtbxMessageReceived.Text = ""
        '
        'gbxTransmission
        '
        Me.gbxTransmission.Controls.Add(Me.txtbxMessageReceived)
        Me.gbxTransmission.Location = New System.Drawing.Point(26, 248)
        Me.gbxTransmission.Name = "gbxTransmission"
        Me.gbxTransmission.Size = New System.Drawing.Size(404, 86)
        Me.gbxTransmission.TabIndex = 1
        Me.gbxTransmission.TabStop = False
        Me.gbxTransmission.Text = "Received Messages"
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 542)
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
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
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
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CommunicationsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(446, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'CommunicationsToolStripMenuItem
        '
        Me.CommunicationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FaconServerConfigurationToolStripMenuItem, Me.ConnectToFaconServerToolStripMenuItem, Me.FastConnectToolStripMenuItem})
        Me.CommunicationsToolStripMenuItem.Name = "CommunicationsToolStripMenuItem"
        Me.CommunicationsToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.CommunicationsToolStripMenuItem.Text = "Communications"
        '
        'FaconServerConfigurationToolStripMenuItem
        '
        Me.FaconServerConfigurationToolStripMenuItem.Name = "FaconServerConfigurationToolStripMenuItem"
        Me.FaconServerConfigurationToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.FaconServerConfigurationToolStripMenuItem.Text = "Facon Server Configuration"
        '
        'ConnectToFaconServerToolStripMenuItem
        '
        Me.ConnectToFaconServerToolStripMenuItem.Name = "ConnectToFaconServerToolStripMenuItem"
        Me.ConnectToFaconServerToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.ConnectToFaconServerToolStripMenuItem.Text = "Connect to Facon Server"
        '
        'FastConnectToolStripMenuItem
        '
        Me.FastConnectToolStripMenuItem.Name = "FastConnectToolStripMenuItem"
        Me.FastConnectToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.FastConnectToolStripMenuItem.Text = "Fast Connect to Facon Server"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.AboutFastConnectToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.HelpToolStripMenuItem.Text = "Help "
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AboutToolStripMenuItem.Text = "About This Program"
        '
        'AboutFastConnectToolStripMenuItem
        '
        Me.AboutFastConnectToolStripMenuItem.Name = "AboutFastConnectToolStripMenuItem"
        Me.AboutFastConnectToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AboutFastConnectToolStripMenuItem.Text = "About Fast Connect"
        '
        'ConnectionStatusStrip
        '
        Me.ConnectionStatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ConnectionStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectionStatusStripLabelPort})
        Me.ConnectionStatusStrip.Location = New System.Drawing.Point(0, 516)
        Me.ConnectionStatusStrip.Name = "ConnectionStatusStrip"
        Me.ConnectionStatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.ConnectionStatusStrip.Size = New System.Drawing.Size(446, 26)
        Me.ConnectionStatusStrip.TabIndex = 13
        Me.ConnectionStatusStrip.Text = "StatusStrip1"
        '
        'ConnectionStatusStripLabelPort
        '
        Me.ConnectionStatusStripLabelPort.Name = "ConnectionStatusStripLabelPort"
        Me.ConnectionStatusStripLabelPort.Size = New System.Drawing.Size(217, 20)
        Me.ConnectionStatusStripLabelPort.Text = "ConnectionStatusStripLabelPort"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbxMessageSent)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 361)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 86)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sent Messages"
        '
        'txtbxMessageSent
        '
        Me.txtbxMessageSent.Location = New System.Drawing.Point(6, 21)
        Me.txtbxMessageSent.Name = "txtbxMessageSent"
        Me.txtbxMessageSent.ReadOnly = True
        Me.txtbxMessageSent.Size = New System.Drawing.Size(392, 55)
        Me.txtbxMessageSent.TabIndex = 8
        Me.txtbxMessageSent.Text = ""
        '
        'Server_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 568)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ConnectionStatusStrip)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.gbxTransmission)
        Me.Controls.Add(Me.gboxReception)
        Me.Location = New System.Drawing.Point(540, 200)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Server_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Server"
        Me.gboxReception.ResumeLayout(False)
        Me.gboxReception.PerformLayout()
        Me.gbxTransmission.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ConnectionStatusStrip.ResumeLayout(False)
        Me.ConnectionStatusStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gboxReception As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxWaterLvl As TextBox
    Friend WithEvents chckbxY2 As CheckBox
    Friend WithEvents chckbxY1 As CheckBox
    Friend WithEvents chckbxY0 As CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents gbxTransmission As GroupBox
    Friend WithEvents btnOff As Button
    Friend WithEvents chckbxX3 As CheckBox
    Friend WithEvents chckbxX2 As CheckBox
    Friend WithEvents chckbxX1 As CheckBox
    Friend WithEvents chckbxX0 As CheckBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TimerReceive As Timer
    Friend WithEvents TimerConnection As Timer
    Friend WithEvents TimerSend As Timer
    Friend WithEvents txtbxMessageReceived As RichTextBox
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommunicationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FaconServerConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectToFaconServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FastConnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectionStatusStrip As StatusStrip
    Friend WithEvents ConnectionStatusStripLabelPort As ToolStripStatusLabel
    Friend WithEvents AboutFastConnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbxMessageSent As RichTextBox
End Class
