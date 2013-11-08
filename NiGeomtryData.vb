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

    Public Overloads Function asstring(verboose As Boolean) As String
        Return Me.ToString()
    End Function
    Public Overloads Function returntype() As Type
        Return Me.GetType()
    End Function
    Public Function GetVertexCount() As Integer

    End Function
    Public Function GetUVSetCount() As Short

    End Function
    Public Sub SetUVSetCount(n As Integer)

    End Sub
    Public Function GetVertexIndexCount() As Integer

    End Function
    Public Function GetCenter() As Vector3

    End Function
    Public Function GetRadius() As Single

    End Function
    Public Sub SetBound(center As Vector3, radius As Single)

    End Sub
    Public Function GetVertices() As Vector3()

    End Function
    Public Function GetNormals() As Vector3()

    End Function
    Public Function GetColors() As Color4

    End Function
    Public Function GetUVSet(index As Integer) As TexCoord

    End Function
    Public Function GetVertexIndices() As Integer

    End Function
    Public Function GetUVSetIndex(maxMapChannel As Integer) As Integer

    End Function
    Public Sub SetVertices(inv As Vector3())

    End Sub

    Public Sub SetNormals(inn As Vector3())

    End Sub
    Public Sub SetVertexColors(inc As Color4())

    End Sub
    Public Sub SetUVSet(index As Integer, int As TexCoord())

    End Sub
    Public Sub SetVertexIndices(inv As Integer)

    End Sub

    Public Sub SetUVSetMap(iv As Integer, ivs As Integer)

    End Sub
    Public Sub Transform(transform As matrix44)

    End Sub
    Public Function GetConsistencyFlags() As Enums.ConsistencyType

    End Function
    Public Sub SetConsistencyFlags(value As Enums.ConsistencyType)

    End Sub
    Public Function GetTspaceFlag() As Byte

    End Function
    Public Sub SetTspaceFlag(value As Byte)

    End Sub
    Public Function GetHasNormals() As Boolean

    End Function
    Public Sub SetHasNormals(value As Boolean)

    End Sub
    Public Function GetBinormals() As Vector3()

    End Function
    Public Sub SetBinormals(value As Vector3)

    End Sub
    Public Function GetTangents() As Vector3()

    End Function
    Public Sub SetTangents(value As Vector3)

    End Sub
End Class
