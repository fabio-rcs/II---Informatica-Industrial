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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.txtRead = New System.Windows.Forms.TextBox()
        Me.txtSave = New System.Windows.Forms.TextBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.labelPath = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(599, 165)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 29)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(599, 346)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(94, 29)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Open"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'txtRead
        '
        Me.txtRead.Location = New System.Drawing.Point(34, 291)
        Me.txtRead.Multiline = True
        Me.txtRead.Name = "txtRead"
        Me.txtRead.Size = New System.Drawing.Size(537, 133)
        Me.txtRead.TabIndex = 2
        '
        'txtSave
        '
        Me.txtSave.Location = New System.Drawing.Point(34, 112)
        Me.txtSave.Multiline = True
        Me.txtSave.Name = "txtSave"
        Me.txtSave.Size = New System.Drawing.Size(537, 133)
        Me.txtSave.TabIndex = 3
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(34, 31)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(537, 27)
        Me.txtPath.TabIndex = 4
        '
        'labelPath
        '
        Me.labelPath.AutoSize = True
        Me.labelPath.Location = New System.Drawing.Point(34, 8)
        Me.labelPath.Name = "labelPath"
        Me.labelPath.Size = New System.Drawing.Size(280, 20)
        Me.labelPath.TabIndex = 5
        Me.labelPath.Text = "Path of file (full path including file name)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Text to save in file"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Text read from file"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labelPath)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.txtSave)
        Me.Controls.Add(Me.txtRead)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents txtRead As TextBox
    Friend WithEvents txtSave As TextBox
    Friend WithEvents txtPath As TextBox
    Friend WithEvents labelPath As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
