Public Class NiSkinData
    Inherits NiObject
    Public rotation As Matrix33
    Public translation As Vector3
    Public numbones As UInteger
    Public skinpartion As Generic.List(Of NiSkinPartion)
    Public hasvertexwight As Byte
    Public bonelist As Generic.List(Of NiSkinData)
End Class
