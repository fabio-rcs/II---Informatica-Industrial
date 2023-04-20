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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtbx_year = New System.Windows.Forms.TextBox()
        Me.txtbx_day = New System.Windows.Forms.TextBox()
        Me.txtbx_month = New System.Windows.Forms.TextBox()
        Me.txtbx_date = New System.Windows.Forms.TextBox()
        Me.label_year = New System.Windows.Forms.Label()
        Me.label_month = New System.Windows.Forms.Label()
        Me.label_day = New System.Windows.Forms.Label()
        Me.label_date = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 56)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(250, 27)
        Me.DateTimePicker1.TabIndex = 0
        '
        'txtbx_year
        '
        Me.txtbx_year.Location = New System.Drawing.Point(137, 142)
        Me.txtbx_year.Name = "txtbx_year"
        Me.txtbx_year.Size = New System.Drawing.Size(125, 27)
        Me.txtbx_year.TabIndex = 1
        '
        'txtbx_day
        '
        Me.txtbx_day.Location = New System.Drawing.Point(137, 254)
        Me.txtbx_day.Name = "txtbx_day"
        Me.txtbx_day.Size = New System.Drawing.Size(125, 27)
        Me.txtbx_day.TabIndex = 2
        '
        'txtbx_month
        '
        Me.txtbx_month.Location = New System.Drawing.Point(137, 190)
        Me.txtbx_month.Name = "txtbx_month"
        Me.txtbx_month.Size = New System.Drawing.Size(125, 27)
        Me.txtbx_month.TabIndex = 2
        '
        'txtbx_date
        '
        Me.txtbx_date.Location = New System.Drawing.Point(137, 318)
        Me.txtbx_date.Name = "txtbx_date"
        Me.txtbx_date.Size = New System.Drawing.Size(125, 27)
        Me.txtbx_date.TabIndex = 3
        '
        'label_year
        '
        Me.label_year.AutoSize = True
        Me.label_year.Location = New System.Drawing.Point(12, 144)
        Me.label_year.Name = "label_year"
        Me.label_year.Size = New System.Drawing.Size(37, 20)
        Me.label_year.TabIndex = 4
        Me.label_year.Text = "yyyy"
        '
        'label_month
        '
        Me.label_month.AutoSize = True
        Me.label_month.Location = New System.Drawing.Point(12, 197)
        Me.label_month.Name = "label_month"
        Me.label_month.Size = New System.Drawing.Size(35, 20)
        Me.label_month.TabIndex = 5
        Me.label_month.Text = "mm"
        '
        'label_day
        '
        Me.label_day.AutoSize = True
        Me.label_day.Location = New System.Drawing.Point(12, 261)
        Me.label_day.Name = "label_day"
        Me.label_day.Size = New System.Drawing.Size(27, 20)
        Me.label_day.TabIndex = 6
        Me.label_day.Text = "dd"
        '
        'label_date
        '
        Me.label_date.AutoSize = True
        Me.label_date.Location = New System.Drawing.Point(12, 325)
        Me.label_date.Name = "label_date"
        Me.label_date.Size = New System.Drawing.Size(93, 20)
        Me.label_date.TabIndex = 7
        Me.label_date.Text = "yyyy/mm/dd"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 450)
        Me.Controls.Add(Me.label_date)
        Me.Controls.Add(Me.label_day)
        Me.Controls.Add(Me.label_month)
        Me.Controls.Add(Me.label_year)
        Me.Controls.Add(Me.txtbx_date)
        Me.Controls.Add(Me.txtbx_month)
        Me.Controls.Add(Me.txtbx_day)
        Me.Controls.Add(Me.txtbx_year)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtbx_year As TextBox
    Friend WithEvents txtbx_day As TextBox
    Friend WithEvents txtbx_month As TextBox
    Friend WithEvents txtbx_date As TextBox
    Friend WithEvents label_year As Label
    Friend WithEvents label_month As Label
    Friend WithEvents label_day As Label
    Friend WithEvents label_date As Label
End Class
