<Serializable()> Public Class NiGeomtry
    Inherits NiAVObject
    Public data As Generic.List(Of NiObject)
    Public skininstance() As NiSkinInstance
    Public nummaterials As UInteger
    Public materialname() As indexstring
    Public activematerial As Integer
    Public hasshader As Boolean
    Public shadername As indexstring
    Public uknowninteger As Integer
    Public uknownbyte As Byte
    Public uknowninteger2 As Integer
    Public dirtyflag As Boolean
End Class
