<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
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
        txtReceived = New TextBox()
        txtHistory = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnSend = New Button()
        btnCfgPort = New Button()
        btnOpenPort = New Button()
        btnExit = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' txtSend
        ' 
        txtSend.Location = New Point(12, 55)
        txtSend.Multiline = True
        txtSend.Name = "txtSend"
        txtSend.Size = New Size(220, 300)
        txtSend.TabIndex = 0
        ' 
        ' txtReceived
        ' 
        txtReceived.Location = New Point(251, 55)
        txtReceived.Multiline = True
        txtReceived.Name = "txtReceived"
        txtReceived.Size = New Size(220, 300)
        txtReceived.TabIndex = 1
        ' 
        ' txtHistory
        ' 
        txtHistory.Location = New Point(613, 55)
        txtHistory.Multiline = True
        txtHistory.Name = "txtHistory"
        txtHistory.Size = New Size(220, 300)
        txtHistory.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 20)
        Label1.TabIndex = 3
        Label1.Text = "Data to send"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(251, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 20)
        Label2.TabIndex = 4
        Label2.Text = "Data received"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(613, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 20)
        Label3.TabIndex = 5
        Label3.Text = "Communication history"' 
        ' btnSend
        ' 
        btnSend.Location = New Point(12, 361)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(94, 29)
        btnSend.TabIndex = 6
        btnSend.Text = "Send"
        btnSend.UseVisualStyleBackColor = True
        ' 
        ' btnCfgPort
        ' 
        btnCfgPort.Location = New Point(477, 54)
        btnCfgPort.Name = "btnCfgPort"
        btnCfgPort.Size = New Size(130, 29)
        btnCfgPort.TabIndex = 7
        btnCfgPort.Text = "Configure port"
        btnCfgPort.UseVisualStyleBackColor = True
        ' 
        ' btnOpenPort
        ' 
        btnOpenPort.Location = New Point(477, 89)
        btnOpenPort.Name = "btnOpenPort"
        btnOpenPort.Size = New Size(130, 29)
        btnOpenPort.TabIndex = 8
        btnOpenPort.Text = "Open Port"
        btnOpenPort.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(489, 361)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 9
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(849, 423)
        Controls.Add(btnExit)
        Controls.Add(btnOpenPort)
        Controls.Add(btnCfgPort)
        Controls.Add(btnSend)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtHistory)
        Controls.Add(txtReceived)
        Controls.Add(txtSend)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSend As TextBox
    Friend WithEvents txtReceived As TextBox
    Friend WithEvents txtHistory As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents btnCfgPort As Button
    Friend WithEvents btnOpenPort As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Timer1 As Timer
End Class
