<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComPortConfiguration
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
        Me.ComboBoxStopBits = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxDataBits = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxParity = New System.Windows.Forms.ComboBox()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonDefault = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxStopBits
        '
        Me.ComboBoxStopBits.FormattingEnabled = True
        Me.ComboBoxStopBits.Location = New System.Drawing.Point(77, 120)
        Me.ComboBoxStopBits.Name = "ComboBoxStopBits"
        Me.ComboBoxStopBits.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxStopBits.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "StopBits"
        '
        'ComboBoxDataBits
        '
        Me.ComboBoxDataBits.FormattingEnabled = True
        Me.ComboBoxDataBits.Location = New System.Drawing.Point(77, 65)
        Me.ComboBoxDataBits.Name = "ComboBoxDataBits"
        Me.ComboBoxDataBits.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxDataBits.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "DataBits"
        '
        'ComboBoxParity
        '
        Me.ComboBoxParity.FormattingEnabled = True
        Me.ComboBoxParity.Location = New System.Drawing.Point(77, 93)
        Me.ComboBoxParity.Name = "ComboBoxParity"
        Me.ComboBoxParity.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxParity.TabIndex = 54
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(77, 37)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxBaudRate.TabIndex = 53
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(77, 11)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPort.TabIndex = 52
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(146, 155)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(51, 23)
        Me.ButtonOK.TabIndex = 47
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(81, 155)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(51, 23)
        Me.ButtonCancel.TabIndex = 51
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Parity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "BaudRate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Port"
        '
        'ButtonDefault
        '
        Me.ButtonDefault.Location = New System.Drawing.Point(12, 155)
        Me.ButtonDefault.Name = "ButtonDefault"
        Me.ButtonDefault.Size = New System.Drawing.Size(51, 23)
        Me.ButtonDefault.TabIndex = 59
        Me.ButtonDefault.Text = "Default"
        Me.ButtonDefault.UseVisualStyleBackColor = True
        '
        'FormComPortConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 199)
        Me.Controls.Add(Me.ButtonDefault)
        Me.Controls.Add(Me.ComboBoxStopBits)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoxDataBits)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxParity)
        Me.Controls.Add(Me.ComboBoxBaudRate)
        Me.Controls.Add(Me.ComboBoxPort)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormComPortConfiguration"
        Me.Text = "FormComPortConfiguration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxStopBits As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxDataBits As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxParity As ComboBox
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonDefault As Button
End Class
