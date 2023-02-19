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
        Me.rtbn_bubbles = New System.Windows.Forms.RadioButton()
        Me.rbtn_stones = New System.Windows.Forms.RadioButton()
        Me.rbtn_salmon = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtbn_bubbles
        '
        Me.rtbn_bubbles.AutoSize = True
        Me.rtbn_bubbles.Location = New System.Drawing.Point(12, 69)
        Me.rtbn_bubbles.Name = "rtbn_bubbles"
        Me.rtbn_bubbles.Size = New System.Drawing.Size(121, 24)
        Me.rtbn_bubbles.TabIndex = 0
        Me.rtbn_bubbles.TabStop = True
        Me.rtbn_bubbles.Text = "RadioButton1"
        Me.rtbn_bubbles.UseVisualStyleBackColor = True
        '
        'rbtn_stones
        '
        Me.rbtn_stones.AutoSize = True
        Me.rbtn_stones.Location = New System.Drawing.Point(12, 111)
        Me.rbtn_stones.Name = "rbtn_stones"
        Me.rbtn_stones.Size = New System.Drawing.Size(121, 24)
        Me.rbtn_stones.TabIndex = 1
        Me.rbtn_stones.TabStop = True
        Me.rbtn_stones.Text = "RadioButton2"
        Me.rbtn_stones.UseVisualStyleBackColor = True
        '
        'rbtn_salmon
        '
        Me.rbtn_salmon.AutoSize = True
        Me.rbtn_salmon.Location = New System.Drawing.Point(12, 152)
        Me.rbtn_salmon.Name = "rbtn_salmon"
        Me.rbtn_salmon.Size = New System.Drawing.Size(121, 24)
        Me.rbtn_salmon.TabIndex = 2
        Me.rbtn_salmon.TabStop = True
        Me.rbtn_salmon.Text = "RadioButton3"
        Me.rbtn_salmon.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(191, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(575, 379)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rbtn_salmon)
        Me.Controls.Add(Me.rbtn_stones)
        Me.Controls.Add(Me.rtbn_bubbles)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbn_bubbles As RadioButton
    Friend WithEvents rbtn_stones As RadioButton
    Friend WithEvents rbtn_salmon As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
