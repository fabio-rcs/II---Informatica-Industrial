Module ModuleComPortParameters

    'Global variables for the communication parameters
    Public port As String
    Public baud_rate As Integer
    Public data_bits As Integer
    Public parity As IO.Ports.Parity
    Public stop_bits As Integer
    Public configuration_is_valid As Boolean
End Module
