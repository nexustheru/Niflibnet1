Public Class Header
    Public headerstring As String
    Public copyright As Generic.List(Of String)
    Public version As UInteger
    Public endiantype As Enums
    Public userversion As UInteger
    Public numblocks As UInteger
    Public userversion2 As UInteger
    Public exportInfo As exportinfo
    Public numblocktypes As UInteger
    Public blocktypes As Generic.List(Of String)
    Public blocktypeindex As Generic.List(Of UShort)
    Public blocksize As Generic.List(Of UInteger)
    Public numstrings As UInteger
    Public maxstringlenght As UInteger
    Public strings As Generic.List(Of String)
    Public unknownint2 As UInteger
End Class
