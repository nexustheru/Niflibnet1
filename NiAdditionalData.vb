Public Class NiAdditionalData
    Inherits NiObject
    Public numvertices As UShort
    Public numblockinfos As UInteger
    Public numblocks As Integer
    Public blocks As Generic.List(Of AdditionalDataBlock)
End Class
