<Serializable()> Public Class AdditionalDataBlock
    Public hasdata As Boolean
    Public blocksize As Integer
    Public numblocks As Integer
    Public blockoffsets() As Integer
    Public numdata As Integer
    Public datasizes() As Integer
    Public data() As Byte
End Class
