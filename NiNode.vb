
<Serializable()> Public Class NiNode
    Inherits NiAVObject
    Public numchildren As UInteger
    Public children() As NiAVObject
    Public numEffects As UInteger
    Public Effects() As NiDynamicEffect
    Public Overloads Function asstring(verboose As Boolean) As String
        Return Me.ToString()
    End Function
    Public Overloads Function returntype() As Type
        Return Me.GetType()
    End Function
    Public Overloads Sub AddChild(niav As NiAVObject)

    End Sub
    Public Sub RemoveChild(niav As NiAVObject)

    End Sub
    Public Sub clearChildren()

    End Sub
    Public Function getChildren() As NiAVObject()

        Return children
      
    End Function
    Public Sub addEffect(effect As NiDynamicEffect)

    End Sub
    Public Sub clearEffects()
        Dim eff() As NiDynamicEffect = Nothing
        Effects = eff
    End Sub
    Public Function geteffects() As NiDynamicEffect()

        Return Effects
      
    End Function
    Public Function IsSkeletonRoot() As Boolean
        Return False
    End Function
    Public Function IsSkinInfluence() As Boolean
        Return False
    End Function
    Public Function IsSplitMeshProxy() As Boolean
        Return False
    End Function
    Public Sub GoToSkeletonBindPosition()

    End Sub
    Public Sub PropagateTransform()

    End Sub
    Public Sub AddSkin(skin_inst As NiSkinInstance)

    End Sub
    Public Sub RemoveSkin(skin_inst As NiSkinInstance)

    End Sub
    Public Sub SetSkinFlag(n As Boolean)

    End Sub
End Class
