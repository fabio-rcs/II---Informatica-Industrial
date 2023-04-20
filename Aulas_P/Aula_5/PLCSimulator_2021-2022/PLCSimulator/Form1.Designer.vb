<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveSentMsgsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommunicationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigureParametersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenPortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FastConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelConnection = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelDataReceived = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimerSend = New System.Windows.Forms.Timer(Me.components)
        Me.TimerReceive = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxOutputs = New System.Windows.Forms.GroupBox()
        Me.CheckBoxForceY = New System.Windows.Forms.CheckBox()
        Me.CheckBoxY2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxY1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxY0 = New System.Windows.Forms.CheckBox()
        Me.GroupBoxInputs = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDownLevel = New System.Windows.Forms.NumericUpDown()
        Me.CheckBoxX3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX0 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxFIFOLIFO = New System.Windows.Forms.ComboBox()
        Me.ButtonClearReceive = New System.Windows.Forms.Button()
        Me.CheckBoxDisablePoolingReceive = New System.Windows.Forms.CheckBox()
        Me.RichTextBoxReceive = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownReceive = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownSend = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonClearSend = New System.Windows.Forms.Button()
        Me.CheckBoxDisablePoolingSend = New System.Windows.Forms.CheckBox()
        Me.RichTextBoxSend = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelReceptionBuffer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SaveFileDialogReceive = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialogSend = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBoxOutputs.SuspendLayout()
        Me.GroupBoxInputs.SuspendLayout()
        CType(Me.NumericUpDownLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDownReceive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownSend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CommunicationsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(593, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToLogToolStripMenuItem, Me.SaveSentMsgsToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToLogToolStripMenuItem
        '
        Me.SaveToLogToolStripMenuItem.Name = "SaveToLogToolStripMenuItem"
        Me.SaveToLogToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SaveToLogToolStripMenuItem.Text = "Save Received Msgs"
        '
        'SaveSentMsgsToolStripMenuItem
        '
        Me.SaveSentMsgsToolStripMenuItem.Name = "SaveSentMsgsToolStripMenuItem"
        Me.SaveSentMsgsToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SaveSentMsgsToolStripMenuItem.Text = "Save Sent Msgs"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(176, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CommunicationsToolStripMenuItem
        '
        Me.CommunicationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigureParametersToolStripMenuItem, Me.OpenPortToolStripMenuItem, Me.ToolStripSeparator1, Me.FastConnectToolStripMenuItem})
        Me.CommunicationsToolStripMenuItem.Name = "CommunicationsToolStripMenuItem"
        Me.CommunicationsToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.CommunicationsToolStripMenuItem.Text = "Communications"
        '
        'ConfigureParametersToolStripMenuItem
        '
        Me.ConfigureParametersToolStripMenuItem.Name = "ConfigureParametersToolStripMenuItem"
        Me.ConfigureParametersToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ConfigureParametersToolStripMenuItem.Text = "Configure"
        '
        'OpenPortToolStripMenuItem
        '
        Me.OpenPortToolStripMenuItem.Name = "OpenPortToolStripMenuItem"
        Me.OpenPortToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.OpenPortToolStripMenuItem.Text = "Open Port"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(140, 6)
        '
        'FastConnectToolStripMenuItem
        '
        Me.FastConnectToolStripMenuItem.Name = "FastConnectToolStripMenuItem"
        Me.FastConnectToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.FastConnectToolStripMenuItem.Text = "Fast Connect"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelConnection, Me.ToolStripStatusLabelDataReceived})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 300)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(593, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelConnection
        '
        Me.ToolStripStatusLabelConnection.Name = "ToolStripStatusLabelConnection"
        Me.ToolStripStatusLabelConnection.Size = New System.Drawing.Size(86, 17)
        Me.ToolStripStatusLabelConnection.Text = "Not connected"
        '
        'ToolStripStatusLabelDataReceived
        '
        Me.ToolStripStatusLabelDataReceived.Name = "ToolStripStatusLabelDataReceived"
        Me.ToolStripStatusLabelDataReceived.Size = New System.Drawing.Size(96, 17)
        Me.ToolStripStatusLabelDataReceived.Text = "No data received"
        '
        'TimerSend
        '
        '
        'TimerReceive
        '
        Me.TimerReceive.Interval = 500
        '
        'GroupBoxOutputs
        '
        Me.GroupBoxOutputs.Controls.Add(Me.CheckBoxForceY)
        Me.GroupBoxOutputs.Controls.Add(Me.CheckBoxY2)
        Me.GroupBoxOutputs.Controls.Add(Me.CheckBoxY1)
        Me.GroupBoxOutputs.Controls.Add(Me.CheckBoxY0)
        Me.GroupBoxOutputs.Location = New System.Drawing.Point(12, 37)
        Me.GroupBoxOutputs.Name = "GroupBoxOutputs"
        Me.GroupBoxOutputs.Size = New System.Drawing.Size(281, 50)
        Me.GroupBoxOutputs.TabIndex = 3
        Me.GroupBoxOutputs.TabStop = False
        Me.GroupBoxOutputs.Text = "Outputs"
        '
        'CheckBoxForceY
        '
        Me.CheckBoxForceY.AutoSize = True
        Me.CheckBoxForceY.Location = New System.Drawing.Point(183, 26)
        Me.CheckBoxForceY.Name = "CheckBoxForceY"
        Me.CheckBoxForceY.Size = New System.Drawing.Size(91, 17)
        Me.CheckBoxForceY.TabIndex = 6
        Me.CheckBoxForceY.Text = "Force Y State"
        Me.CheckBoxForceY.UseVisualStyleBackColor = True
        '
        'CheckBoxY2
        '
        Me.CheckBoxY2.AutoSize = True
        Me.CheckBoxY2.Enabled = False
        Me.CheckBoxY2.Location = New System.Drawing.Point(96, 26)
        Me.CheckBoxY2.Name = "CheckBoxY2"
        Me.CheckBoxY2.Size = New System.Drawing.Size(39, 17)
        Me.CheckBoxY2.TabIndex = 8
        Me.CheckBoxY2.Text = "Y2"
        Me.CheckBoxY2.UseVisualStyleBackColor = True
        '
        'CheckBoxY1
        '
        Me.CheckBoxY1.AutoSize = True
        Me.CheckBoxY1.Enabled = False
        Me.CheckBoxY1.Location = New System.Drawing.Point(51, 26)
        Me.CheckBoxY1.Name = "CheckBoxY1"
        Me.CheckBoxY1.Size = New System.Drawing.Size(39, 17)
        Me.CheckBoxY1.TabIndex = 7
        Me.CheckBoxY1.Text = "Y1"
        Me.CheckBoxY1.UseVisualStyleBackColor = True
        '
        'CheckBoxY0
        '
        Me.CheckBoxY0.AutoSize = True
        Me.CheckBoxY0.Enabled = False
        Me.CheckBoxY0.Location = New System.Drawing.Point(6, 26)
        Me.CheckBoxY0.Name = "CheckBoxY0"
        Me.CheckBoxY0.Size = New System.Drawing.Size(39, 17)
        Me.CheckBoxY0.TabIndex = 6
        Me.CheckBoxY0.Text = "Y0"
        Me.CheckBoxY0.UseVisualStyleBackColor = True
        '
        'GroupBoxInputs
        '
        Me.GroupBoxInputs.Controls.Add(Me.Label1)
        Me.GroupBoxInputs.Controls.Add(Me.NumericUpDownLevel)
        Me.GroupBoxInputs.Controls.Add(Me.CheckBoxX3)
        Me.GroupBoxInputs.Controls.Add(Me.CheckBoxX2)
        Me.GroupBoxInputs.Controls.Add(Me.CheckBoxX1)
        Me.GroupBoxInputs.Controls.Add(Me.CheckBoxX0)
        Me.GroupBoxInputs.Location = New System.Drawing.Point(299, 37)
        Me.GroupBoxInputs.Name = "GroupBoxInputs"
        Me.GroupBoxInputs.Size = New System.Drawing.Size(281, 50)
        Me.GroupBoxInputs.TabIndex = 4
        Me.GroupBoxInputs.TabStop = False
        Me.GroupBoxInputs.Text = "Inputs"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Level"
        '
        'NumericUpDownLevel
        '
        Me.NumericUpDownLevel.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDownLevel.Location = New System.Drawing.Point(187, 22)
        Me.NumericUpDownLevel.Name = "NumericUpDownLevel"
        Me.NumericUpDownLevel.Size = New System.Drawing.Size(46, 20)
        Me.NumericUpDownLevel.TabIndex = 4
        Me.NumericUpDownLevel.Value = New Decimal(New Integer() {65, 0, 0, 0})
        '
        'CheckBoxX3
        '
        Me.CheckBoxX3.AutoSize = True
        Me.CheckBoxX3.Location = New System.Drawing.Point(141, 23)
        Me.CheckBoxX3.Name = "CheckBoxX3"
        Me.CheckBoxX3.Size = New System.Drawing.Size(39, 17)
        Me.CheckBoxX3.TabIndex = 3
        Me.CheckBoxX3.Text = "X3"
        Me.CheckBoxX3.UseVisualStyleBackColor = True
        '
        'CheckBoxX2
        '
        Me.CheckBoxX2.AutoSize = True
        Me.CheckBoxX2.Location = New System.Drawing.Point(96, 23)
        Me.CheckBoxX2.Name = "CheckBoxX2"
        Me.CheckBoxX2.Size = New System.Drawing.Size(39, 17)
        Me.CheckBoxX2.TabIndex = 2
        Me.CheckBoxX2.Text = "X2"
        Me.CheckBoxX2.UseVisualStyleBackColor = True
        '
        'CheckBoxX1
        '
        Me.CheckBoxX1.AutoSize = True
        Me.CheckBoxX1.Location = New System.Drawing.Point(51, 23)
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Size = New System.Drawing.Size(39, 17)
        Me.CheckBoxX1.TabIndex = 1
        Me.CheckBoxX1.Text = "X1"
        Me.CheckBoxX1.UseVisualStyleBackColor = True
        '
        'CheckBoxX0
        '
        Me.CheckBoxX0.AutoSize = True
        Me.CheckBoxX0.Location = New System.Drawing.Point(6, 23)
        Me.CheckBoxX0.Name = "CheckBoxX0"
        Me.CheckBoxX0.Size = New System.Drawing.Size(39, 17)
        Me.CheckBoxX0.TabIndex = 0
        Me.CheckBoxX0.Text = "X0"
        Me.CheckBoxX0.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBoxFIFOLIFO)
        Me.GroupBox1.Controls.Add(Me.ButtonClearReceive)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDisablePoolingReceive)
        Me.GroupBox1.Controls.Add(Me.RichTextBoxReceive)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownReceive)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 174)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Messages Received (Command)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(180, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Extraction method"
        '
        'ComboBoxFIFOLIFO
        '
        Me.ComboBoxFIFOLIFO.FormattingEnabled = True
        Me.ComboBoxFIFOLIFO.Location = New System.Drawing.Point(124, 147)
        Me.ComboBoxFIFOLIFO.Name = "ComboBoxFIFOLIFO"
        Me.ComboBoxFIFOLIFO.Size = New System.Drawing.Size(50, 21)
        Me.ComboBoxFIFOLIFO.TabIndex = 11
        '
        'ButtonClearReceive
        '
        Me.ButtonClearReceive.Location = New System.Drawing.Point(9, 117)
        Me.ButtonClearReceive.Name = "ButtonClearReceive"
        Me.ButtonClearReceive.Size = New System.Drawing.Size(77, 21)
        Me.ButtonClearReceive.TabIndex = 10
        Me.ButtonClearReceive.Text = "Clear"
        Me.ButtonClearReceive.UseVisualStyleBackColor = True
        '
        'CheckBoxDisablePoolingReceive
        '
        Me.CheckBoxDisablePoolingReceive.AutoSize = True
        Me.CheckBoxDisablePoolingReceive.Location = New System.Drawing.Point(92, 120)
        Me.CheckBoxDisablePoolingReceive.Name = "CheckBoxDisablePoolingReceive"
        Me.CheckBoxDisablePoolingReceive.Size = New System.Drawing.Size(61, 17)
        Me.CheckBoxDisablePoolingReceive.TabIndex = 9
        Me.CheckBoxDisablePoolingReceive.Text = "Disable"
        Me.CheckBoxDisablePoolingReceive.UseVisualStyleBackColor = True
        '
        'RichTextBoxReceive
        '
        Me.RichTextBoxReceive.EnableAutoDragDrop = True
        Me.RichTextBoxReceive.HideSelection = False
        Me.RichTextBoxReceive.Location = New System.Drawing.Point(9, 19)
        Me.RichTextBoxReceive.Name = "RichTextBoxReceive"
        Me.RichTextBoxReceive.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBoxReceive.Size = New System.Drawing.Size(263, 94)
        Me.RichTextBoxReceive.TabIndex = 9
        Me.RichTextBoxReceive.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pooling (ms)"
        '
        'NumericUpDownReceive
        '
        Me.NumericUpDownReceive.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDownReceive.Location = New System.Drawing.Point(159, 118)
        Me.NumericUpDownReceive.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NumericUpDownReceive.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownReceive.Name = "NumericUpDownReceive"
        Me.NumericUpDownReceive.Size = New System.Drawing.Size(46, 20)
        Me.NumericUpDownReceive.TabIndex = 7
        Me.NumericUpDownReceive.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'NumericUpDownSend
        '
        Me.NumericUpDownSend.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDownSend.Location = New System.Drawing.Point(160, 117)
        Me.NumericUpDownSend.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NumericUpDownSend.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownSend.Name = "NumericUpDownSend"
        Me.NumericUpDownSend.Size = New System.Drawing.Size(46, 20)
        Me.NumericUpDownSend.TabIndex = 6
        Me.NumericUpDownSend.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Pooling (ms)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonClearSend)
        Me.GroupBox2.Controls.Add(Me.CheckBoxDisablePoolingSend)
        Me.GroupBox2.Controls.Add(Me.RichTextBoxSend)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.NumericUpDownSend)
        Me.GroupBox2.Location = New System.Drawing.Point(299, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(281, 146)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Messages Sent (Status)"
        '
        'ButtonClearSend
        '
        Me.ButtonClearSend.Location = New System.Drawing.Point(10, 117)
        Me.ButtonClearSend.Name = "ButtonClearSend"
        Me.ButtonClearSend.Size = New System.Drawing.Size(77, 21)
        Me.ButtonClearSend.TabIndex = 11
        Me.ButtonClearSend.Text = "Clear"
        Me.ButtonClearSend.UseVisualStyleBackColor = True
        '
        'CheckBoxDisablePoolingSend
        '
        Me.CheckBoxDisablePoolingSend.AutoSize = True
        Me.CheckBoxDisablePoolingSend.Location = New System.Drawing.Point(95, 119)
        Me.CheckBoxDisablePoolingSend.Name = "CheckBoxDisablePoolingSend"
        Me.CheckBoxDisablePoolingSend.Size = New System.Drawing.Size(61, 17)
        Me.CheckBoxDisablePoolingSend.TabIndex = 10
        Me.CheckBoxDisablePoolingSend.Text = "Disable"
        Me.CheckBoxDisablePoolingSend.UseVisualStyleBackColor = True
        '
        'RichTextBoxSend
        '
        Me.RichTextBoxSend.HideSelection = False
        Me.RichTextBoxSend.Location = New System.Drawing.Point(9, 19)
        Me.RichTextBoxSend.Name = "RichTextBoxSend"
        Me.RichTextBoxSend.Size = New System.Drawing.Size(263, 94)
        Me.RichTextBoxSend.TabIndex = 10
        Me.RichTextBoxSend.Text = ""
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelReceptionBuffer})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 278)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(593, 22)
        Me.StatusStrip2.TabIndex = 11
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabelReceptionBuffer
        '
        Me.ToolStripStatusLabelReceptionBuffer.Name = "ToolStripStatusLabelReceptionBuffer"
        Me.ToolStripStatusLabelReceptionBuffer.Size = New System.Drawing.Size(101, 17)
        Me.ToolStripStatusLabelReceptionBuffer.Text = "Reception Buffer: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 322)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxInputs)
        Me.Controls.Add(Me.GroupBoxOutputs)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "PLC Simulator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBoxOutputs.ResumeLayout(False)
        Me.GroupBoxOutputs.PerformLayout()
        Me.GroupBoxInputs.ResumeLayout(False)
        Me.GroupBoxInputs.PerformLayout()
        CType(Me.NumericUpDownLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDownReceive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownSend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommunicationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigureParametersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenPortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabelConnection As ToolStripStatusLabel
    Friend WithEvents TimerSend As Timer
    Friend WithEvents TimerReceive As Timer
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBoxOutputs As GroupBox
    Friend WithEvents GroupBoxInputs As GroupBox
    Friend WithEvents NumericUpDownLevel As NumericUpDown
    Friend WithEvents CheckBoxX3 As CheckBox
    Friend WithEvents CheckBoxX2 As CheckBox
    Friend WithEvents CheckBoxX1 As CheckBox
    Friend WithEvents CheckBoxX0 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBoxY2 As CheckBox
    Friend WithEvents CheckBoxY1 As CheckBox
    Friend WithEvents CheckBoxY0 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDownReceive As NumericUpDown
    Friend WithEvents CheckBoxForceY As CheckBox
    Friend WithEvents CheckBoxDisablePoolingReceive As CheckBox
    Friend WithEvents RichTextBoxReceive As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDownSend As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBoxDisablePoolingSend As CheckBox
    Friend WithEvents RichTextBoxSend As RichTextBox
    Friend WithEvents ButtonClearReceive As Button
    Friend WithEvents ButtonClearSend As Button
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents FastConnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabelDataReceived As ToolStripStatusLabel
    Friend WithEvents ComboBoxFIFOLIFO As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents ToolStripStatusLabelReceptionBuffer As ToolStripStatusLabel
    Friend WithEvents SaveToLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialogReceive As SaveFileDialog
    Friend WithEvents SaveSentMsgsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialogSend As SaveFileDialog
End Class
