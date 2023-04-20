<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtSend = New TextBox()
        txtReceive = New TextBox()
        btnSend = New Button()
        btnExit = New Button()
        Timer1 = New Timer(components)
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txtSend
        ' 
        txtSend.Location = New Point(12, 49)
        txtSend.Multiline = True
        txtSend.Name = "txtSend"
        txtSend.Size = New Size(234, 288)
        txtSend.TabIndex = 0
        ' 
        ' txtReceive
        ' 
        txtReceive.Location = New Point(275, 49)
        txtReceive.Multiline = True
        txtReceive.Name = "txtReceive"
        txtReceive.Size = New Size(234, 288)
        txtReceive.TabIndex = 1
        ' 
        ' btnSend
        ' 
        btnSend.Location = New Point(12, 343)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(94, 29)
        btnSend.TabIndex = 2
        btnSend.Text = "Send"
        btnSend.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(415, 409)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 4
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 20)
        Label1.TabIndex = 5
        Label1.Text = "Text to send"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(275, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 6
        Label2.Text = "Received Text"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(522, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnExit)
        Controls.Add(btnSend)
        Controls.Add(txtReceive)
        Controls.Add(txtSend)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSend As TextBox
    Friend WithEvents txtReceive As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
