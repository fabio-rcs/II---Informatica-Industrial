<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PortConfiguration
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
        Me.cboxDataBits = New System.Windows.Forms.ComboBox()
        Me.cboxHandshake = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboxEncoding = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboxStopBits = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblParity = New System.Windows.Forms.Label()
        Me.lblBaudRate = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.cboxParity = New System.Windows.Forms.ComboBox()
        Me.cboxBaudRate = New System.Windows.Forms.ComboBox()
        Me.cboxPort = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboxDataBits
        '
        Me.cboxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxDataBits.FormattingEnabled = True
        Me.cboxDataBits.Location = New System.Drawing.Point(150, 120)
        Me.cboxDataBits.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxDataBits.Name = "cboxDataBits"
        Me.cboxDataBits.Size = New System.Drawing.Size(129, 24)
        Me.cboxDataBits.TabIndex = 33
        '
        'cboxHandshake
        '
        Me.cboxHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxHandshake.FormattingEnabled = True
        Me.cboxHandshake.Location = New System.Drawing.Point(150, 231)
        Me.cboxHandshake.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxHandshake.Name = "cboxHandshake"
        Me.cboxHandshake.Size = New System.Drawing.Size(129, 24)
        Me.cboxHandshake.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Handshake"
        '
        'cboxEncoding
        '
        Me.cboxEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEncoding.FormattingEnabled = True
        Me.cboxEncoding.Location = New System.Drawing.Point(150, 194)
        Me.cboxEncoding.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxEncoding.Name = "cboxEncoding"
        Me.cboxEncoding.Size = New System.Drawing.Size(129, 24)
        Me.cboxEncoding.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 25)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Encoding"
        '
        'cboxStopBits
        '
        Me.cboxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxStopBits.FormattingEnabled = True
        Me.cboxStopBits.Location = New System.Drawing.Point(150, 157)
        Me.cboxStopBits.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxStopBits.Name = "cboxStopBits"
        Me.cboxStopBits.Size = New System.Drawing.Size(129, 24)
        Me.cboxStopBits.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Stop Bits"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Data Bits"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(198, 294)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 25
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(16, 294)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblParity
        '
        Me.lblParity.AutoSize = True
        Me.lblParity.BackColor = System.Drawing.Color.Transparent
        Me.lblParity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParity.Location = New System.Drawing.Point(12, 83)
        Me.lblParity.Name = "lblParity"
        Me.lblParity.Size = New System.Drawing.Size(67, 25)
        Me.lblParity.TabIndex = 23
        Me.lblParity.Text = "Parity"
        '
        'lblBaudRate
        '
        Me.lblBaudRate.AutoSize = True
        Me.lblBaudRate.BackColor = System.Drawing.Color.Transparent
        Me.lblBaudRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaudRate.Location = New System.Drawing.Point(12, 46)
        Me.lblBaudRate.Name = "lblBaudRate"
        Me.lblBaudRate.Size = New System.Drawing.Size(112, 25)
        Me.lblBaudRate.TabIndex = 22
        Me.lblBaudRate.Text = "Baud Rate"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.BackColor = System.Drawing.Color.Transparent
        Me.lblPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort.Location = New System.Drawing.Point(12, 9)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(51, 25)
        Me.lblPort.TabIndex = 21
        Me.lblPort.Text = "Port"
        '
        'cboxParity
        '
        Me.cboxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxParity.FormattingEnabled = True
        Me.cboxParity.Location = New System.Drawing.Point(150, 83)
        Me.cboxParity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxParity.Name = "cboxParity"
        Me.cboxParity.Size = New System.Drawing.Size(129, 24)
        Me.cboxParity.TabIndex = 20
        '
        'cboxBaudRate
        '
        Me.cboxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxBaudRate.FormattingEnabled = True
        Me.cboxBaudRate.Location = New System.Drawing.Point(150, 46)
        Me.cboxBaudRate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxBaudRate.Name = "cboxBaudRate"
        Me.cboxBaudRate.Size = New System.Drawing.Size(129, 24)
        Me.cboxBaudRate.TabIndex = 19
        '
        'cboxPort
        '
        Me.cboxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxPort.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cboxPort.Location = New System.Drawing.Point(150, 8)
        Me.cboxPort.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxPort.Name = "cboxPort"
        Me.cboxPort.Size = New System.Drawing.Size(129, 24)
        Me.cboxPort.TabIndex = 18
        '
        'PortConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(303, 325)
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
        Me.Name = "PortConfiguration"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboxDataBits As ComboBox
    Friend WithEvents cboxHandshake As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboxEncoding As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboxStopBits As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblParity As Label
    Friend WithEvents lblBaudRate As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents cboxParity As ComboBox
    Friend WithEvents cboxBaudRate As ComboBox
    Friend WithEvents cboxPort As ComboBox
End Class
