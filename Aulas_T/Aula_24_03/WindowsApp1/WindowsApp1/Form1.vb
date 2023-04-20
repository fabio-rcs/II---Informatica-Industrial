Imports System.Net.Sockets
Imports System.Text

Public Class Form1
    ReadOnly WaitTCPConnection As New TcpListener(85)
    Dim TCPConnection As New TcpClient
    Dim MsgTxRx As NetworkStream
    ReadOnly ss(1000) As Byte
    Private nBytes As UInteger
    Private ReadOnly i As UInteger

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WaitTCPConnection.Start()
        Timer1.Interval = 500
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If WaitTCPConnection.Pending Then
            TCPConnection = WaitTCPConnection.AcceptTcpClient
        End If

        nBytes = TCPConnection.Available
        If nBytes > 0 Then
            MsgTxRx = TCPConnection.GetStream
            MsgTxRx.Read(ss, 0, nBytes)

            RichTextBox1.Text = Encoding.Default.GetChars(ss)

            MsgTxRx.Write(ss, 0, nBytes)
        End If
    End Sub
End Class
