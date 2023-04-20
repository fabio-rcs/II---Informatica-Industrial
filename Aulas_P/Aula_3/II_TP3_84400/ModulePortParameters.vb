Module ModulePortParameters

    'Global variables for the communication parameters 
    Public port As String
    Public baud_rate As Integer
    Public parity As System.IO.Ports.Parity
    Public cfg_is_valid As Boolean
    Public data_bits As Integer
    Public stop_bits As System.IO.Ports.StopBits
    Public encoding As System.Text.Encoding
    Public handshake As System.IO.Ports.Handshake
End Module
