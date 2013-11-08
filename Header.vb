<Serializable()> Public Class Header
    Public headerstring As String
    Public copyright() As String
    Public version As UInteger
    Public endiantype As Enums
    Public userversion As UInteger
    Public numblocks As UInteger
    Public userversion2 As UInteger
    Public exportInfo As exportinfo
    Public numblocktypes As UInteger
    Public blocktypes() As String
    Public blocktypeindex() As UShort
    Public blocksize() As UInteger
    Public numstrings As UInteger
    Public maxstringlenght As UInteger
    Public strings() As String
    Public unknownint2 As UInteger
End Class
