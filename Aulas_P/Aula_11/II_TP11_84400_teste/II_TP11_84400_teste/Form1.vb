Imports System.ComponentModel.Design
Imports MySql.Data.MySqlClient

Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim data_reader As MySqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        ' Connection, initialization of the data base and scheme selection
        cn.ConnectionString = "Server=localhost; User Id=root; Password=84400; Database=dados_alunos"

        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
                MsgBox("Correct connection to the data base 'dados_alunos'")
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox("Incorrect connection to the data base 'dados_alunos'")
        End Try

        cmd.Connection = cn
    End Sub

    Private Sub BtnReadDB_Click(sender As Object, e As EventArgs) Handles btnReadDB.Click
        ' Sequential reading of the existent data in the data base
        Dim str As String = ""

        'Data base table selection for data reading
        cmd.CommandText = "SELECT * FROM dados_alunos.dados_alunos"
        data_reader = cmd.ExecuteReader

        'Sequential reading of the table
        'Saves all content in the str variable
        While data_reader.Read
            str = str & data_reader("id") & vbTab & data_reader("nome") & vbTab & data_reader("numero_mecanografico") & vbTab & data_reader("telefone") & vbCrLf
        End While

        'Visualization of all data
        txtbxRegistReading.Text = str
        data_reader.Close()
    End Sub

    Private Sub BtnInsertRegistry_Click(sender As Object, e As EventArgs) Handles btnInsertRegist.Click
        Try
            'Inserts the registry in the data base
            cmd.CommandText = "insert into dados_alunos.dados_alunos(nome, numero_mecanografico, telefone) values('" & txtbxName.Text & "','" & txtbxNMec.Text & "','" & txtbxTelefone.Text & "')"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnUpdateRegistry_Click(sender As Object, e As EventArgs) Handles btnUpdateRegist.Click
        Try
            'Updates and existing registry
            cmd.CommandText = "update dados_alunos.dados_alunos set nome='" & txtbxName.Text & "', telefone='" & txtbxTelefone.Text & "' where numero_mecanografico='" & CInt(txtbxNMec.Text) & "'"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnReadRegistry_Click(sender As Object, e As EventArgs) Handles btnReadRegist.Click
        'Reading of a specific registry
        Dim str As String


        Try
            'Search the requires registry
            cmd.CommandText = "Select * from dados_alunos.dados_alunos where numero_mecanografico='" & txtbxNMec.Text & "'"

            data_reader = cmd.ExecuteReader

            'Registry reading
            data_reader.Read()
            txtbxName.Text = data_reader("nome")
            txtbxTelefone.Text = data_reader("telefone")
            txtbxID.Text = data_reader("id")
            data_reader.Close()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub BtnDeleteRegistry_Click(sender As Object, e As EventArgs) Handles btnDeleteRegist.Click
        Try
            'Delete registry through index key
            cmd.CommandText = "Delete from dados_alunos.dados_alunos where numero_mecanografico='" & txtbxNMec.Text & "'"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub BtnMaxID_Click(sender As Object, e As EventArgs) Handles btnMaxID.Click
        Try
            'Looks for registry with max id
            cmd.CommandText = "select max(id) from dados_alunos.dados_alunos"

            'Executes the command for reading the max id of data base
            Dim total As Integer = cmd.ExecuteScalar
            txtbxMaxID.Text = total.ToString

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub BtnTerminate_Click(sender As Object, e As EventArgs) Handles btnTerminate.Click
        'Terminate app
        End
    End Sub
End Class
