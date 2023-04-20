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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerReceive = New System.Windows.Forms.Timer(Me.components)
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.txtReceived = New System.Windows.Forms.TextBox()
        Me.txtHistory = New System.Windows.Forms.TextBox()
        Me.lblSend = New System.Windows.Forms.Label()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.lblReceived = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnCfgPort = New System.Windows.Forms.Button()
        Me.btnOpenPort = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TimerReceive
        '
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(20, 55)
        Me.txtSend.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSend.Multiline = True
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(151, 244)
        Me.txtSend.TabIndex = 0
        '
        'txtReceived
        '
        Me.txtReceived.Location = New System.Drawing.Point(174, 55)
        Me.txtReceived.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReceived.Multiline = True
        Me.txtReceived.Name = "txtReceived"
        Me.txtReceived.ReadOnly = True
        Me.txtReceived.Size = New System.Drawing.Size(151, 244)
        Me.txtReceived.TabIndex = 1
        '
        'txtHistory
        '
        Me.txtHistory.Location = New System.Drawing.Point(441, 55)
        Me.txtHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHistory.Multiline = True
        Me.txtHistory.Name = "txtHistory"
        Me.txtHistory.ReadOnly = True
        Me.txtHistory.Size = New System.Drawing.Size(151, 244)
        Me.txtHistory.TabIndex = 2
        '
        'lblSend
        '
        Me.lblSend.BackColor = System.Drawing.Color.Transparent
        Me.lblSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSend.Location = New System.Drawing.Point(16, 21)
        Me.lblSend.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSend.Name = "lblSend"
        Me.lblSend.Size = New System.Drawing.Size(155, 16)
        Me.lblSend.TabIndex = 3
        Me.lblSend.Text = "Data to send:"
        Me.lblSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHistory
        '
        Me.lblHistory.BackColor = System.Drawing.Color.Transparent
        Me.lblHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistory.ForeColor = System.Drawing.Color.Black
        Me.lblHistory.Location = New System.Drawing.Point(438, 6)
        Me.lblHistory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(151, 47)
        Me.lblHistory.TabIndex = 4
        Me.lblHistory.Text = "Communication History"
        Me.lblHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReceived
        '
        Me.lblReceived.BackColor = System.Drawing.Color.Transparent
        Me.lblReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceived.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblReceived.Location = New System.Drawing.Point(175, 21)
        Me.lblReceived.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReceived.Name = "lblReceived"
        Me.lblReceived.Size = New System.Drawing.Size(155, 16)
        Me.lblReceived.TabIndex = 5
        Me.lblReceived.Text = "Received data:"
        Me.lblReceived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(20, 303)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(56, 25)
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnCfgPort
        '
        Me.btnCfgPort.Location = New System.Drawing.Point(328, 55)
        Me.btnCfgPort.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCfgPort.Name = "btnCfgPort"
        Me.btnCfgPort.Size = New System.Drawing.Size(108, 24)
        Me.btnCfgPort.TabIndex = 7
        Me.btnCfgPort.Text = "Configure Port"
        Me.btnCfgPort.UseVisualStyleBackColor = True
        '
        'btnOpenPort
        '
        Me.btnOpenPort.Location = New System.Drawing.Point(328, 84)
        Me.btnOpenPort.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOpenPort.Name = "btnOpenPort"
        Me.btnOpenPort.Size = New System.Drawing.Size(108, 24)
        Me.btnOpenPort.TabIndex = 8
        Me.btnOpenPort.Text = "Open Port"
        Me.btnOpenPort.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(533, 303)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 25)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.II_TP3_84400.My.Resources.Resources.ua_top_1
        Me.ClientSize = New System.Drawing.Size(600, 341)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOpenPort)
        Me.Controls.Add(Me.btnCfgPort)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lblReceived)
        Me.Controls.Add(Me.lblHistory)
        Me.Controls.Add(Me.lblSend)
        Me.Controls.Add(Me.txtHistory)
        Me.Controls.Add(Me.txtReceived)
        Me.Controls.Add(Me.txtSend)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerReceive As Timer
    Friend WithEvents txtSend As TextBox
    Friend WithEvents txtReceived As TextBox
    Friend WithEvents txtHistory As TextBox
    Friend WithEvents lblSend As Label
    Friend WithEvents lblHistory As Label
    Friend WithEvents lblReceived As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents btnCfgPort As Button
    Friend WithEvents btnOpenPort As Button
    Friend WithEvents btnExit As Button
End Class
