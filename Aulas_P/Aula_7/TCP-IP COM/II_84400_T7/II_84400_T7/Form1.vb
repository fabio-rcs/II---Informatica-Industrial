'Imports the OPC-UA library
Imports Opc.UaFx.Client
Public Class Form1
    'Global variables creation
    Dim IP 'OPC-UA's server endpoint
    Dim client 'Client instance
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "OCP-UA Communication"
        'Start up configurations (not needed)
        txtbxIP.Text = "ibhlinkua_011088:48010" 'We can use this address or the IP as commented bellow
        'TODO txtbxIP.Text = "192.168.10.9:48010" 'IP of the PLC
        txtbxNs.Text = "7"
        txtbxS.Text = ".Publish.struct1.u2" 'We have from u1 to u30 memories to write to
        txtbxWrite.Text = "True"
        'Button Configuration
        btnConfig.Enabled = True
        btnStart.Enabled = False
        btnStop.Enabled = False
        btnRead.Enabled = False
        btnWrite.Enabled = False

        Timer1.Interval = 1000
        Timer1.Start()
    End Sub
    Private Sub BtnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        'Updates OPC-UA's server endpoint
        IP = "opc.tcp://" & txtbxIP.Text 'OPC-UA's server endpoint
        'Button Configuration
        btnConfig.Enabled = True
        btnStart.Enabled = True
        btnStop.Enabled = False
        btnRead.Enabled = False
        btnWrite.Enabled = False
    End Sub
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Starts the connection with the OPC-UA Server
        client = New OpcClient(Convert.ToString(IP)) 'Converts the Object from a text box to a String and creates a new OPC-UA client
        client.Connect() 'Tries to establish a connection with the OPC-UA Server
        'Button Configuration
        btnConfig.Enabled = False
        btnStart.Enabled = False
        btnStop.Enabled = True
        btnRead.Enabled = True
        btnWrite.Enabled = True
    End Sub
    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        'Ends the connection with the OPC-AU Server
        client.Disconnect() 'Finishes to establish a connection with the OPC-UA Server
        'Button Configuration
        btnConfig.Enabled = True
        btnStart.Enabled = True
        btnStop.Enabled = False
        btnRead.Enabled = False
        btnWrite.Enabled = False
    End Sub
    Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        'Request to read a variable from the OPC-UA Server
        Dim id = "ns=" & txtbxNs.Text & ";s=" & txtbxS.Text 'Variable endpoint identification
        Dim OPCValue = client.ReadNode(Convert.ToString(id)) 'Converts the object from a text box to a string and requests the variables info
        txtbxRead.Text = Convert.ToString(OPCValue) 'Converts the Object from the request to a string and updates the read text box
    End Sub
    Private Sub BtnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        'Submits to write a variable from the OPC-UA Server
        Dim id = "ns=" & txtbxNs.Text & ";s=" & txtbxS.Text 'Variable endpoint identification
        client.WriteNode(Convert.ToString(id), Convert.ToString(txtbxWrite.Text))
        'Converts the Object from a text box to a String and requests to write a variable from the OPC -UA Server
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Made by Fábio Sousa, 84400, for class #7 in 27/03/2023.")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = Now.ToString
    End Sub
End Class