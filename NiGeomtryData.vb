Public Class NiGeomtryData
    Inherits NiObject
    Public vertexindices As Generic.List(Of Integer)
    Public uvsetmap As Generic.List(Of Integer)
    Public uknownint As Integer
    Public numvertices As UShort
    Public keepflags As Byte
    Public compressedflags As Byte
    Public hasvertices As Boolean
    Public vertices As Generic.List(Of Vector3)
    Public numuvset As Byte
    Public tspaceflag As Byte
    Public hasnormals As Boolean
    Public normals As Generic.List(Of Vector3)
    Public binormals As Generic.List(Of Vector3)
    Public tangents As Generic.List(Of Vector3)
    Public center As Vector3
    Public radious As Single
    Public hasvertexcolor As Boolean
    Public vertexcolor As Generic.List(Of Color4)
    Public hasuv As Boolean
    Public uvsets As Generic.List(Of TexCoord)
    Public consistencyflags As Enums.ConsistencyType
    Public additionaldata As Generic.List(Of NiAdditionalData)
End Class
