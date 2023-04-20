<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPortCfg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPortCfg))
        Me.cboxPort = New System.Windows.Forms.ComboBox()
        Me.cboxBaudRate = New System.Windows.Forms.ComboBox()
        Me.cboxParity = New System.Windows.Forms.ComboBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblBaudRate = New System.Windows.Forms.Label()
        Me.lblParity = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxStopBits = New System.Windows.Forms.ComboBox()
        Me.cboxEncoding = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboxHandshake = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboxDataBits = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboxPort
        '
        Me.cboxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxPort.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cboxPort.Location = New System.Drawing.Point(149, 18)
        Me.cboxPort.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboxPort.Name = "cboxPort"
        Me.cboxPort.Size = New System.Drawing.Size(98, 21)
        Me.cboxPort.TabIndex = 0
        '
        'cboxBaudRate
        '
        Me.cboxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxBaudRate.FormattingEnabled = True
        Me.cboxBaudRate.Location = New System.Drawing.Point(149, 49)
        Me.cboxBaudRate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboxBaudRate.Name = "cboxBaudRate"
        Me.cboxBaudRate.Size = New System.Drawing.Size(98, 21)
        Me.cboxBaudRate.TabIndex = 1
        '
        'cboxParity
        '
        Me.cboxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxParity.FormattingEnabled = True
        Me.cboxParity.Location = New System.Drawing.Point(149, 79)
        Me.cboxParity.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboxParity.Name = "cboxParity"
        Me.cboxParity.Size = New System.Drawing.Size(98, 21)
        Me.cboxParity.TabIndex = 2
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.BackColor = System.Drawing.Color.Transparent
        Me.lblPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort.Location = New System.Drawing.Point(46, 19)
        Me.lblPort.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(42, 20)
        Me.lblPort.TabIndex = 3
        Me.lblPort.Text = "Port"
        '
        'lblBaudRate
        '
        Me.lblBaudRate.AutoSize = True
        Me.lblBaudRate.BackColor = System.Drawing.Color.Transparent
        Me.lblBaudRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaudRate.Location = New System.Drawing.Point(46, 49)
        Me.lblBaudRate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBaudRate.Name = "lblBaudRate"
        Me.lblBaudRate.Size = New System.Drawing.Size(95, 20)
        Me.lblBaudRate.TabIndex = 4
        Me.lblBaudRate.Text = "Baud Rate"
        '
        'lblParity
        '
        Me.lblParity.AutoSize = True
        Me.lblParity.BackColor = System.Drawing.Color.Transparent
        Me.lblParity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParity.Location = New System.Drawing.Point(46, 79)
        Me.lblParity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblParity.Name = "lblParity"
        Me.lblParity.Size = New System.Drawing.Size(54, 20)
        Me.lblParity.TabIndex = 5
        Me.lblParity.Text = "Parity"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(49, 250)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(56, 19)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(185, 250)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(56, 19)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 109)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Data Bits"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 139)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Stop Bits"
        '
        'cboxStopBits
        '
        Me.cboxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxStopBits.FormattingEnabled = True
        Me.cboxStopBits.Location = New System.Drawing.Point(149, 139)
        Me.cboxStopBits.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxStopBits.Name = "cboxStopBits"
        Me.cboxStopBits.Size = New System.Drawing.Size(98, 21)
        Me.cboxStopBits.TabIndex = 12
        '
        'cboxEncoding
        '
        Me.cboxEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEncoding.FormattingEnabled = True
        Me.cboxEncoding.Location = New System.Drawing.Point(149, 169)
        Me.cboxEncoding.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxEncoding.Name = "cboxEncoding"
        Me.cboxEncoding.Size = New System.Drawing.Size(98, 21)
        Me.cboxEncoding.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 169)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Encoding"
        '
        'cboxHandshake
        '
        Me.cboxHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxHandshake.FormattingEnabled = True
        Me.cboxHandshake.Location = New System.Drawing.Point(149, 199)
        Me.cboxHandshake.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxHandshake.Name = "cboxHandshake"
        Me.cboxHandshake.Size = New System.Drawing.Size(98, 21)
        Me.cboxHandshake.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 199)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Handshake"
        '
        'cboxDataBits
        '
        Me.cboxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxDataBits.FormattingEnabled = True
        Me.cboxDataBits.Location = New System.Drawing.Point(149, 109)
        Me.cboxDataBits.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxDataBits.Name = "cboxDataBits"
        Me.cboxDataBits.Size = New System.Drawing.Size(98, 21)
        Me.cboxDataBits.TabIndex = 17
        '
        'FormPortCfg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.II_TP3_84400.My.Resources.Resources.ua_top_1
        Me.ClientSize = New System.Drawing.Size(295, 276)
        Me.Controls.Add(Me.cboxDataBits)
        Me.Controls.Add(Me.cboxHandshake)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboxEncoding)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboxStopBits)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblParity)
        Me.Controls.Add(Me.lblBaudRate)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.cboxParity)
        Me.Controls.Add(Me.cboxBaudRate)
        Me.Controls.Add(Me.cboxPort)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormPortCfg"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboxPort As ComboBox
    Friend WithEvents cboxBaudRate As ComboBox
    Friend WithEvents cboxParity As ComboBox
    Friend WithEvents lblPort As Label
    Friend WithEvents lblBaudRate As Label
    Friend WithEvents lblParity As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboxStopBits As ComboBox
    Friend WithEvents cboxEncoding As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboxHandshake As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboxDataBits As ComboBox
End Class
