<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayMesssages
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReceived = New System.Windows.Forms.RichTextBox()
        Me.txtSent = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sent messages"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(444, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Received messages"
        '
        'txtReceived
        '
        Me.txtReceived.Location = New System.Drawing.Point(447, 105)
        Me.txtReceived.Name = "txtReceived"
        Me.txtReceived.Size = New System.Drawing.Size(326, 333)
        Me.txtReceived.TabIndex = 5
        Me.txtReceived.Text = ""
        '
        'txtSent
        '
        Me.txtSent.Location = New System.Drawing.Point(50, 105)
        Me.txtSent.Name = "txtSent"
        Me.txtSent.Size = New System.Drawing.Size(326, 333)
        Me.txtSent.TabIndex = 6
        Me.txtSent.Text = ""
        '
        'DisplayMesssages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtSent)
        Me.Controls.Add(Me.txtReceived)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DisplayMesssages"
        Me.Text = "DisplayMesssages"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtReceived As RichTextBox
    Friend WithEvents txtSent As RichTextBox
End Class
