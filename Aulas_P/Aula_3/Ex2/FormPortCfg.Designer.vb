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
        cbxPort = New ComboBox()
        cboxBaudRate = New ComboBox()
        cboxParity = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnCancel = New Button()
        btnOk = New Button()
        SuspendLayout()
        ' 
        ' cbxPort
        ' 
        cbxPort.FormattingEnabled = True
        cbxPort.Location = New Point(116, 18)
        cbxPort.Name = "cbxPort"
        cbxPort.Size = New Size(151, 28)
        cbxPort.TabIndex = 0
        ' 
        ' cboxBaudRate
        ' 
        cboxBaudRate.FormattingEnabled = True
        cboxBaudRate.Location = New Point(116, 52)
        cboxBaudRate.Name = "cboxBaudRate"
        cboxBaudRate.Size = New Size(151, 28)
        cboxBaudRate.TabIndex = 1
        ' 
        ' cboxParity
        ' 
        cboxParity.FormattingEnabled = True
        cboxParity.Location = New Point(116, 86)
        cboxParity.Name = "cboxParity"
        cboxParity.Size = New Size(151, 28)
        cboxParity.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 20)
        Label1.TabIndex = 3
        Label1.Text = "Port"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 20)
        Label2.TabIndex = 4
        Label2.Text = "Baud Rate"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 20)
        Label3.TabIndex = 5
        Label3.Text = "Parity"' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(30, 154)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 6
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnOk
        ' 
        btnOk.Location = New Point(196, 154)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(94, 29)
        btnOk.TabIndex = 7
        btnOk.Text = "Ok"
        btnOk.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(313, 213)
        Controls.Add(btnOk)
        Controls.Add(btnCancel)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cboxParity)
        Controls.Add(cboxBaudRate)
        Controls.Add(cbxPort)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbxPort As ComboBox
    Friend WithEvents cboxBaudRate As ComboBox
    Friend WithEvents cboxParity As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button


End Class
