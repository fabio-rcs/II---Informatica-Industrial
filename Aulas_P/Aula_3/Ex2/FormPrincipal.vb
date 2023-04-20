Imports System.IO.Ports

Public Class FormPrincipal
    Dim data_received As String
    '-----------------------------------------
    'Initialization --------------------------
    '-----------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtSend.Text = "Write here your first message! :)"

        Timer1.Interval = 300 'Timer tics every 300ms
        Timer1.Enabled = False 'Timer only starts after port is configured

        ModulePortParameters.configuration_is_valid = False
    End Sub

    '-----------------------------------------
    'Serial Port Configuration ---------------
    '-----------------------------------------

    'Configure Serial Port Communication Parameters
    Private Sub BtnCfgPort_Click(sender As Object, e As EventArgs) Handles btnCfgPort.Click
        FormPortCfg.StartPosition = FormStartPosition.CenterParent
        FormPortCfg.ShowDialog()

        'Now setup the SerialPort1 using the variables from the module
        'We'll only use the variables if configuration is valid
        If ModulePortParameters.configuration_is_valid = True Then
            With SerialPort1 :
            End If
    End Sub
End Class
