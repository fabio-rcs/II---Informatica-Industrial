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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbxRegistReading = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxTelefone = New System.Windows.Forms.RichTextBox()
        Me.txtbxName = New System.Windows.Forms.RichTextBox()
        Me.txtbxNMec = New System.Windows.Forms.RichTextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnReadDB = New System.Windows.Forms.Button()
        Me.btnInsertRegist = New System.Windows.Forms.Button()
        Me.btnReadRegist = New System.Windows.Forms.Button()
        Me.btnUpdateRegist = New System.Windows.Forms.Button()
        Me.btnDeleteRegist = New System.Windows.Forms.Button()
        Me.btnMaxID = New System.Windows.Forms.Button()
        Me.btnTerminate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbxMaxID = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbxID = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbxRegistReading)
        Me.GroupBox1.Location = New System.Drawing.Point(193, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(418, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registry Reading"
        '
        'txtbxRegistReading
        '
        Me.txtbxRegistReading.Location = New System.Drawing.Point(6, 24)
        Me.txtbxRegistReading.Name = "txtbxRegistReading"
        Me.txtbxRegistReading.Size = New System.Drawing.Size(406, 159)
        Me.txtbxRegistReading.TabIndex = 0
        Me.txtbxRegistReading.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtbxID)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtbxTelefone)
        Me.GroupBox2.Controls.Add(Me.txtbxName)
        Me.GroupBox2.Controls.Add(Me.txtbxNMec)
        Me.GroupBox2.Location = New System.Drawing.Point(193, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(418, 199)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registry"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Telefone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NMec"
        '
        'txtbxTelefone
        '
        Me.txtbxTelefone.Location = New System.Drawing.Point(171, 166)
        Me.txtbxTelefone.Name = "txtbxTelefone"
        Me.txtbxTelefone.Size = New System.Drawing.Size(241, 27)
        Me.txtbxTelefone.TabIndex = 2
        Me.txtbxTelefone.Text = ""
        '
        'txtbxName
        '
        Me.txtbxName.Location = New System.Drawing.Point(171, 116)
        Me.txtbxName.Name = "txtbxName"
        Me.txtbxName.Size = New System.Drawing.Size(241, 27)
        Me.txtbxName.TabIndex = 1
        Me.txtbxName.Text = ""
        '
        'txtbxNMec
        '
        Me.txtbxNMec.Location = New System.Drawing.Point(171, 66)
        Me.txtbxNMec.Name = "txtbxNMec"
        Me.txtbxNMec.Size = New System.Drawing.Size(241, 27)
        Me.txtbxNMec.TabIndex = 0
        Me.txtbxNMec.Text = ""
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(25, 28)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(122, 57)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnReadDB
        '
        Me.btnReadDB.Location = New System.Drawing.Point(25, 91)
        Me.btnReadDB.Name = "btnReadDB"
        Me.btnReadDB.Size = New System.Drawing.Size(122, 57)
        Me.btnReadDB.TabIndex = 10
        Me.btnReadDB.Text = "Read Data Base"
        Me.btnReadDB.UseVisualStyleBackColor = True
        '
        'btnInsertRegist
        '
        Me.btnInsertRegist.Location = New System.Drawing.Point(25, 154)
        Me.btnInsertRegist.Name = "btnInsertRegist"
        Me.btnInsertRegist.Size = New System.Drawing.Size(122, 57)
        Me.btnInsertRegist.TabIndex = 11
        Me.btnInsertRegist.Text = "Insert Registry"
        Me.btnInsertRegist.UseVisualStyleBackColor = True
        '
        'btnReadRegist
        '
        Me.btnReadRegist.Location = New System.Drawing.Point(25, 217)
        Me.btnReadRegist.Name = "btnReadRegist"
        Me.btnReadRegist.Size = New System.Drawing.Size(122, 57)
        Me.btnReadRegist.TabIndex = 12
        Me.btnReadRegist.Text = "Read Registry"
        Me.btnReadRegist.UseVisualStyleBackColor = True
        '
        'btnUpdateRegist
        '
        Me.btnUpdateRegist.Location = New System.Drawing.Point(25, 280)
        Me.btnUpdateRegist.Name = "btnUpdateRegist"
        Me.btnUpdateRegist.Size = New System.Drawing.Size(122, 57)
        Me.btnUpdateRegist.TabIndex = 13
        Me.btnUpdateRegist.Text = "Update Registry"
        Me.btnUpdateRegist.UseVisualStyleBackColor = True
        '
        'btnDeleteRegist
        '
        Me.btnDeleteRegist.Location = New System.Drawing.Point(25, 343)
        Me.btnDeleteRegist.Name = "btnDeleteRegist"
        Me.btnDeleteRegist.Size = New System.Drawing.Size(122, 57)
        Me.btnDeleteRegist.TabIndex = 14
        Me.btnDeleteRegist.Text = "Delete Registry"
        Me.btnDeleteRegist.UseVisualStyleBackColor = True
        '
        'btnMaxID
        '
        Me.btnMaxID.Location = New System.Drawing.Point(642, 70)
        Me.btnMaxID.Name = "btnMaxID"
        Me.btnMaxID.Size = New System.Drawing.Size(122, 57)
        Me.btnMaxID.TabIndex = 15
        Me.btnMaxID.Text = "Max. (id_alunos)"
        Me.btnMaxID.UseVisualStyleBackColor = True
        '
        'btnTerminate
        '
        Me.btnTerminate.Location = New System.Drawing.Point(642, 356)
        Me.btnTerminate.Name = "btnTerminate"
        Me.btnTerminate.Size = New System.Drawing.Size(122, 57)
        Me.btnTerminate.TabIndex = 16
        Me.btnTerminate.Text = "Terminate"
        Me.btnTerminate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(617, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Max ID"
        '
        'txtbxMaxID
        '
        Me.txtbxMaxID.Location = New System.Drawing.Point(688, 28)
        Me.txtbxMaxID.Name = "txtbxMaxID"
        Me.txtbxMaxID.Size = New System.Drawing.Size(100, 27)
        Me.txtbxMaxID.TabIndex = 6
        Me.txtbxMaxID.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ID"
        '
        'txtbxID
        '
        Me.txtbxID.Location = New System.Drawing.Point(171, 21)
        Me.txtbxID.Name = "txtbxID"
        Me.txtbxID.Size = New System.Drawing.Size(241, 27)
        Me.txtbxID.TabIndex = 6
        Me.txtbxID.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtbxMaxID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnTerminate)
        Me.Controls.Add(Me.btnMaxID)
        Me.Controls.Add(Me.btnDeleteRegist)
        Me.Controls.Add(Me.btnUpdateRegist)
        Me.Controls.Add(Me.btnReadRegist)
        Me.Controls.Add(Me.btnInsertRegist)
        Me.Controls.Add(Me.btnReadDB)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnReadDB As Button
    Friend WithEvents btnInsertRegist As Button
    Friend WithEvents btnReadRegist As Button
    Friend WithEvents btnUpdateRegist As Button
    Friend WithEvents btnDeleteRegist As Button
    Friend WithEvents btnMaxID As Button
    Friend WithEvents txtbxRegistReading As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxTelefone As RichTextBox
    Friend WithEvents txtbxName As RichTextBox
    Friend WithEvents txtbxNMec As RichTextBox
    Friend WithEvents btnTerminate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbxMaxID As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbxID As RichTextBox
End Class
