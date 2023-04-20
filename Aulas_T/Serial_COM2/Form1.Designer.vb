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
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.txtReceive = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.labelSend = New System.Windows.Forms.Label()
        Me.labelReceive = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(29, 74)
        Me.txtSend.Multiline = True
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(347, 265)
        Me.txtSend.TabIndex = 0
        '
        'txtReceive
        '
        Me.txtReceive.Location = New System.Drawing.Point(414, 74)
        Me.txtReceive.Multiline = True
        Me.txtReceive.Name = "txtReceive"
        Me.txtReceive.Size = New System.Drawing.Size(331, 265)
        Me.txtReceive.TabIndex = 1
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(63, 373)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(508, 384)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(109, 20)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'labelSend
        '
        Me.labelSend.AutoSize = True
        Me.labelSend.Location = New System.Drawing.Point(137, 38)
        Me.labelSend.Name = "labelSend"
        Me.labelSend.Size = New System.Drawing.Size(80, 16)
        Me.labelSend.TabIndex = 4
        Me.labelSend.Text = "Text to send"
        '
        'labelReceive
        '
        Me.labelReceive.AutoSize = True
        Me.labelReceive.Location = New System.Drawing.Point(569, 38)
        Me.labelReceive.Name = "labelReceive"
        Me.labelReceive.Size = New System.Drawing.Size(89, 16)
        Me.labelReceive.TabIndex = 5
        Me.labelReceive.Text = "Received text"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.labelReceive)
        Me.Controls.Add(Me.labelSend)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtReceive)
        Me.Controls.Add(Me.txtSend)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtSend As TextBox
    Friend WithEvents txtReceive As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents labelSend As Label
    Friend WithEvents labelReceive As Label
End Class
