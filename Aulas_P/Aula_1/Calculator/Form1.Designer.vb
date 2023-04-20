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
        Me.label_x = New System.Windows.Forms.Label()
        Me.label_y = New System.Windows.Forms.Label()
        Me.label_z = New System.Windows.Forms.Label()
        Me.txtbx_x = New System.Windows.Forms.TextBox()
        Me.txtbx_y = New System.Windows.Forms.TextBox()
        Me.txtbx_z = New System.Windows.Forms.TextBox()
        Me.btn_sum = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label_x
        '
        Me.label_x.AutoSize = True
        Me.label_x.Location = New System.Drawing.Point(116, 98)
        Me.label_x.Name = "label_x"
        Me.label_x.Size = New System.Drawing.Size(53, 20)
        Me.label_x.TabIndex = 0
        Me.label_x.Text = "Label1"
        '
        'label_y
        '
        Me.label_y.AutoSize = True
        Me.label_y.Location = New System.Drawing.Point(116, 233)
        Me.label_y.Name = "label_y"
        Me.label_y.Size = New System.Drawing.Size(53, 20)
        Me.label_y.TabIndex = 1
        Me.label_y.Text = "Label2"
        '
        'label_z
        '
        Me.label_z.AutoSize = True
        Me.label_z.Location = New System.Drawing.Point(574, 82)
        Me.label_z.Name = "label_z"
        Me.label_z.Size = New System.Drawing.Size(53, 20)
        Me.label_z.TabIndex = 2
        Me.label_z.Text = "Label3"
        '
        'txtbx_x
        '
        Me.txtbx_x.Location = New System.Drawing.Point(122, 129)
        Me.txtbx_x.Name = "txtbx_x"
        Me.txtbx_x.Size = New System.Drawing.Size(125, 27)
        Me.txtbx_x.TabIndex = 3
        '
        'txtbx_y
        '
        Me.txtbx_y.Location = New System.Drawing.Point(133, 256)
        Me.txtbx_y.Name = "txtbx_y"
        Me.txtbx_y.Size = New System.Drawing.Size(125, 27)
        Me.txtbx_y.TabIndex = 4
        '
        'txtbx_z
        '
        Me.txtbx_z.Location = New System.Drawing.Point(562, 148)
        Me.txtbx_z.Name = "txtbx_z"
        Me.txtbx_z.Size = New System.Drawing.Size(125, 27)
        Me.txtbx_z.TabIndex = 5
        '
        'btn_sum
        '
        Me.btn_sum.Location = New System.Drawing.Point(374, 178)
        Me.btn_sum.Name = "btn_sum"
        Me.btn_sum.Size = New System.Drawing.Size(94, 29)
        Me.btn_sum.TabIndex = 6
        Me.btn_sum.Text = "Button1"
        Me.btn_sum.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_sum)
        Me.Controls.Add(Me.txtbx_z)
        Me.Controls.Add(Me.txtbx_y)
        Me.Controls.Add(Me.txtbx_x)
        Me.Controls.Add(Me.label_z)
        Me.Controls.Add(Me.label_y)
        Me.Controls.Add(Me.label_x)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_x As Label
    Friend WithEvents label_y As Label
    Friend WithEvents label_z As Label
    Friend WithEvents txtbx_x As TextBox
    Friend WithEvents txtbx_y As TextBox
    Friend WithEvents txtbx_z As TextBox
    Friend WithEvents btn_sum As Button
End Class
