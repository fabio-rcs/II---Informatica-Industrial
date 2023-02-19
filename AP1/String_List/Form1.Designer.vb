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
        Me.label_item = New System.Windows.Forms.Label()
        Me.label_cbx = New System.Windows.Forms.Label()
        Me.label_nitems = New System.Windows.Forms.Label()
        Me.label_selected = New System.Windows.Forms.Label()
        Me.txtbx_item = New System.Windows.Forms.TextBox()
        Me.txtbx_nitems = New System.Windows.Forms.TextBox()
        Me.txtbx_selected = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.cbx_list = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'label_item
        '
        Me.label_item.AutoSize = True
        Me.label_item.Location = New System.Drawing.Point(23, 29)
        Me.label_item.Name = "label_item"
        Me.label_item.Size = New System.Drawing.Size(53, 20)
        Me.label_item.TabIndex = 0
        Me.label_item.Text = "Label1"
        '
        'label_cbx
        '
        Me.label_cbx.AutoSize = True
        Me.label_cbx.Location = New System.Drawing.Point(466, 29)
        Me.label_cbx.Name = "label_cbx"
        Me.label_cbx.Size = New System.Drawing.Size(53, 20)
        Me.label_cbx.TabIndex = 1
        Me.label_cbx.Text = "Label2"
        '
        'label_nitems
        '
        Me.label_nitems.AutoSize = True
        Me.label_nitems.Location = New System.Drawing.Point(279, 226)
        Me.label_nitems.Name = "label_nitems"
        Me.label_nitems.Size = New System.Drawing.Size(53, 20)
        Me.label_nitems.TabIndex = 2
        Me.label_nitems.Text = "Label3"
        '
        'label_selected
        '
        Me.label_selected.AutoSize = True
        Me.label_selected.Location = New System.Drawing.Point(279, 290)
        Me.label_selected.Name = "label_selected"
        Me.label_selected.Size = New System.Drawing.Size(53, 20)
        Me.label_selected.TabIndex = 3
        Me.label_selected.Text = "Label4"
        '
        'txtbx_item
        '
        Me.txtbx_item.Location = New System.Drawing.Point(23, 71)
        Me.txtbx_item.Name = "txtbx_item"
        Me.txtbx_item.Size = New System.Drawing.Size(125, 27)
        Me.txtbx_item.TabIndex = 4
        '
        'txtbx_nitems
        '
        Me.txtbx_nitems.Location = New System.Drawing.Point(466, 226)
        Me.txtbx_nitems.Name = "txtbx_nitems"
        Me.txtbx_nitems.Size = New System.Drawing.Size(125, 27)
        Me.txtbx_nitems.TabIndex = 5
        '
        'txtbx_selected
        '
        Me.txtbx_selected.Location = New System.Drawing.Point(466, 290)
        Me.txtbx_selected.Name = "txtbx_selected"
        Me.txtbx_selected.Size = New System.Drawing.Size(125, 27)
        Me.txtbx_selected.TabIndex = 6
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(238, 25)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(94, 29)
        Me.btn_add.TabIndex = 7
        Me.btn_add.Text = "Button1"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(238, 131)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(94, 29)
        Me.btn_remove.TabIndex = 8
        Me.btn_remove.Text = "Button2"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(523, 409)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(94, 29)
        Me.btn_close.TabIndex = 9
        Me.btn_close.Text = "Button3"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'cbx_list
        '
        Me.cbx_list.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbx_list.FormattingEnabled = True
        Me.cbx_list.Location = New System.Drawing.Point(440, 70)
        Me.cbx_list.MaxLength = 100
        Me.cbx_list.Name = "cbx_list"
        Me.cbx_list.Size = New System.Drawing.Size(151, 28)
        Me.cbx_list.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 449)
        Me.Controls.Add(Me.cbx_list)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txtbx_selected)
        Me.Controls.Add(Me.txtbx_nitems)
        Me.Controls.Add(Me.txtbx_item)
        Me.Controls.Add(Me.label_selected)
        Me.Controls.Add(Me.label_nitems)
        Me.Controls.Add(Me.label_cbx)
        Me.Controls.Add(Me.label_item)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_item As Label
    Friend WithEvents label_cbx As Label
    Friend WithEvents label_nitems As Label
    Friend WithEvents label_selected As Label
    Friend WithEvents txtbx_item As TextBox
    Friend WithEvents txtbx_nitems As TextBox
    Friend WithEvents txtbx_selected As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_remove As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents cbx_list As ComboBox
End Class
