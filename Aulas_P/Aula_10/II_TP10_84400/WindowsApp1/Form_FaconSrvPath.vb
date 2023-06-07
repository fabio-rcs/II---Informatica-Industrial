Imports System.IO.Ports
Imports System.Text

Public Class Form_FaconSrvPath
    Dim path As String
    Dim file_success As Integer

    '-----------------------------------------------------
    ' Initialization -------------------------------------
    '-----------------------------------------------------
    Private Sub PortConfiguratio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "FaconSrv Configuration"
        btnOpen.Text = "Open File"
    End Sub

    '-----------------------------------------------------
    ' Button clicks routine ------------------------------
    '-----------------------------------------------------
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ModulePathParameters.cfg_is_valid = False
        Me.Close()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ModulePathParameters.faconsrv_path = path

        ' Set flag for valid config
        ModulePathParameters.cfg_is_valid = True

        Me.Close()
    End Sub

    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        file_success = OpenFileDialog1.ShowDialog()

        If file_success <> 2 Then
            path = OpenFileDialog1.FileName
            txtFilePath.Text = path
        Else
            MsgBox("User exited or failed to open file")
        End If


    End Sub
End Class