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
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimeDateStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.TimeDateStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtbxD4076Velocity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxY0 = New System.Windows.Forms.CheckBox()
        Me.gbxSupervision = New System.Windows.Forms.GroupBox()
        Me.gbxControl = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxD4076VelocityControl = New System.Windows.Forms.TextBox()
        Me.btnY0Off = New System.Windows.Forms.Button()
        Me.btnY0On = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TimeDateStatusStrip.SuspendLayout()
        Me.gbxSupervision.SuspendLayout()
        Me.gbxControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(26, 329)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(110, 60)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FaconSrv to PLC"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(26, 406)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(110, 60)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Read Item"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(150, 406)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(110, 60)
        Me.btnWrite.TabIndex = 2
        Me.btnWrite.Text = "Write Item"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(150, 329)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(110, 60)
        Me.btnDisconnect.TabIndex = 3
        Me.btnDisconnect.Text = "Disconnect" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FaconSrv of PLC"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(329, 348)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(119, 22)
        Me.txtItem.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 325)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Item"
        '
        'TimeDateStatusStrip
        '
        Me.TimeDateStatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TimeDateStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimeDateStatusLabel})
        Me.TimeDateStatusStrip.Location = New System.Drawing.Point(0, 564)
        Me.TimeDateStatusStrip.Name = "TimeDateStatusStrip"
        Me.TimeDateStatusStrip.Size = New System.Drawing.Size(478, 26)
        Me.TimeDateStatusStrip.TabIndex = 6
        Me.TimeDateStatusStrip.Text = "StatusStrip1"
        '
        'TimeDateStatusLabel
        '
        Me.TimeDateStatusLabel.Name = "TimeDateStatusLabel"
        Me.TimeDateStatusLabel.Size = New System.Drawing.Size(150, 20)
        Me.TimeDateStatusLabel.Text = "TimeDateStatusLabel"
        '
        'Timer1
        '
        '
        'txtbxD4076Velocity
        '
        Me.txtbxD4076Velocity.Location = New System.Drawing.Point(166, 34)
        Me.txtbxD4076Velocity.Name = "txtbxD4076Velocity"
        Me.txtbxD4076Velocity.Size = New System.Drawing.Size(100, 22)
        Me.txtbxD4076Velocity.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "D4076 Velocity"
        '
        'cbxY0
        '
        Me.cbxY0.AutoSize = True
        Me.cbxY0.Location = New System.Drawing.Point(14, 36)
        Me.cbxY0.Name = "cbxY0"
        Me.cbxY0.Size = New System.Drawing.Size(82, 20)
        Me.cbxY0.TabIndex = 9
        Me.cbxY0.Text = "Y0 Motor"
        Me.cbxY0.UseVisualStyleBackColor = True
        '
        'gbxSupervision
        '
        Me.gbxSupervision.Controls.Add(Me.cbxY0)
        Me.gbxSupervision.Controls.Add(Me.Label2)
        Me.gbxSupervision.Controls.Add(Me.txtbxD4076Velocity)
        Me.gbxSupervision.Location = New System.Drawing.Point(26, 12)
        Me.gbxSupervision.Name = "gbxSupervision"
        Me.gbxSupervision.Size = New System.Drawing.Size(413, 78)
        Me.gbxSupervision.TabIndex = 11
        Me.gbxSupervision.TabStop = False
        Me.gbxSupervision.Text = "Supervision"
        '
        'gbxControl
        '
        Me.gbxControl.Controls.Add(Me.Label3)
        Me.gbxControl.Controls.Add(Me.txtbxD4076VelocityControl)
        Me.gbxControl.Controls.Add(Me.btnY0Off)
        Me.gbxControl.Controls.Add(Me.btnY0On)
        Me.gbxControl.Location = New System.Drawing.Point(26, 150)
        Me.gbxControl.Name = "gbxControl"
        Me.gbxControl.Size = New System.Drawing.Size(413, 123)
        Me.gbxControl.TabIndex = 12
        Me.gbxControl.TabStop = False
        Me.gbxControl.Text = "Control"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(163, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "D4076 Velocity Control"
        '
        'txtbxD4076VelocityControl
        '
        Me.txtbxD4076VelocityControl.Location = New System.Drawing.Point(166, 61)
        Me.txtbxD4076VelocityControl.Name = "txtbxD4076VelocityControl"
        Me.txtbxD4076VelocityControl.Size = New System.Drawing.Size(138, 22)
        Me.txtbxD4076VelocityControl.TabIndex = 15
        '
        'btnY0Off
        '
        Me.btnY0Off.Location = New System.Drawing.Point(6, 76)
        Me.btnY0Off.Name = "btnY0Off"
        Me.btnY0Off.Size = New System.Drawing.Size(110, 26)
        Me.btnY0Off.TabIndex = 14
        Me.btnY0Off.Text = "Y0 Turn Off"
        Me.btnY0Off.UseVisualStyleBackColor = True
        '
        'btnY0On
        '
        Me.btnY0On.Location = New System.Drawing.Point(6, 34)
        Me.btnY0On.Name = "btnY0On"
        Me.btnY0On.Size = New System.Drawing.Size(110, 26)
        Me.btnY0On.TabIndex = 13
        Me.btnY0On.Text = "Y0 Turn On"
        Me.btnY0On.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(338, 440)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 26)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 590)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbxControl)
        Me.Controls.Add(Me.gbxSupervision)
        Me.Controls.Add(Me.TimeDateStatusStrip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TimeDateStatusStrip.ResumeLayout(False)
        Me.TimeDateStatusStrip.PerformLayout()
        Me.gbxSupervision.ResumeLayout(False)
        Me.gbxSupervision.PerformLayout()
        Me.gbxControl.ResumeLayout(False)
        Me.gbxControl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConnect As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnWrite As Button
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents txtItem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TimeDateStatusStrip As StatusStrip
    Friend WithEvents TimeDateStatusLabel As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtbxD4076Velocity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxY0 As CheckBox
    Friend WithEvents gbxSupervision As GroupBox
    Friend WithEvents gbxControl As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxD4076VelocityControl As TextBox
    Friend WithEvents btnY0Off As Button
    Friend WithEvents btnY0On As Button
    Friend WithEvents btnExit As Button
End Class
