<Serializable()> Public Class NiGeomtryData
    Inherits NiObject
    Public vertexindices() As Integer
    Public uvsetmap() As Integer
    Public uknownint As Integer
    Public numvertices As UShort
    Public keepflags As Byte
    Public compressedflags As Byte
    Public hasvertices As Boolean
    Public vertices() As Vector3
    Public numuvset As Byte
    Public tspaceflag As Byte
    Public hasnormals As Boolean
    Public normals() As Vector3
    Public binormals() As Vector3
    Public tangents() As Vector3
    Public center As Vector3
    Public radious As Single
    Public hasvertexcolor As Boolean
    Public vertexcolor() As Color4
    Public hasuv As Boolean
    Public uvsets() As TexCoord
    Public consistencyflags As Enums.ConsistencyType
    Public additionaldata() As NiAdditionalData
End Class
