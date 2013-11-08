<Serializable()> Public Class NiGeomtry
    Inherits NiAVObject
    Public data() As NiObject
    Public skininstance() As NiSkinInstance
    Public nummaterials As UInteger
    Public materialname() As indexstring
    Public activematerial As Integer
    Public shadername As indexstring
    Public uknowninteger As Integer
    Public uknownbyte As Byte
    Public uknowninteger2 As Integer
    Public dirtyflag As Boolean

    Public Overloads Function asstring(verboose As Boolean) As String
        Return Me.ToString()
    End Function
    Public Overloads Function returntype() As Type
        Return Me.GetType()
    End Function
    Public Sub BindSkin(bone_nodes As NiNode)

    End Sub

    Public Sub BindSkinWith(bone_nodes As NiNode, SkinInstConstructor As NiObject)

    End Sub
    Public Sub UnbindSkin()

    End Sub
    Public Sub SetBoneWeights(bone_index As UInt32, n As SkinWeight)

    End Sub
    Public Function GetSkinInstance() As NiSkinInstance

    End Function
    Public Function GetData() As NiGeomtryData

    End Function
    Public Sub SetData(n As NiGeomtryData)

    End Sub
    Public Function GetShader() As String

    End Function
    Public Sub SetShader(n As String)

    End Sub
    Public Sub GetSkinDeformation(vertices As Vector3, normals As Vector3)

    End Sub
    Public Sub ApplyTransforms()

    End Sub
    Public Sub ApplySkinOffset()

    End Sub
    Public Sub NormalizeSkinWeights()

    End Sub
    Public Function IsSkin() As Boolean

    End Function
    Public Function GetActiveMaterial() As Integer

    End Function
    Public Sub SetActiveMaterial(value As Integer)

    End Sub
    Public Function HasShader() As Boolean

    End Function
End Class
