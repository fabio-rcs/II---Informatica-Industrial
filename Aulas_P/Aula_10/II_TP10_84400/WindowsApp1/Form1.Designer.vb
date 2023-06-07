<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TimerConnection = New System.Windows.Forms.Timer(Me.components)
        Me.txtbxMessageReceived = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommunicationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaconServerConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToFaconServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutFastConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerConnection
        '
        '
        'txtbxMessageReceived
        '
        Me.txtbxMessageReceived.Location = New System.Drawing.Point(12, 31)
        Me.txtbxMessageReceived.Name = "txtbxMessageReceived"
        Me.txtbxMessageReceived.Size = New System.Drawing.Size(392, 397)
        Me.txtbxMessageReceived.TabIndex = 0
        Me.txtbxMessageReceived.Text = ""
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 474)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(420, 26)
        Me.StatusStrip1.TabIndex = 2
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
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CommunicationsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(420, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
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
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
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
        'StatusStrip2
        '
        Me.StatusStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 448)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(420, 26)
        Me.StatusStrip2.TabIndex = 4
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 500)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtbxMessageReceived)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimerConnection As Timer
    Friend WithEvents txtbxMessageReceived As RichTextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommunicationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FaconServerConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectToFaconServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FastConnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutFastConnectToolStripMenuItem As ToolStripMenuItem
End Class
