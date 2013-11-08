<Serializable()> Public Class NiAVObject
    Inherits NiObjectNet
    Public parent As NiNode
    Public flag As Flags
    Public uknownshort1 As UShort
    Public translation As Vector3
    Public rotation As Matrix33
    Public scale As Single
    Public velocity As Vector3
    Public numprops As UInteger
    Public Properties() As NiProperty
    Public unknow1 As UInteger
    Public unknown2 As Byte
    Public hasboundingbox As Boolean
    Public BoundingBox As BoundingBox
    Public collisionobject() As NiCollisionObject
    Public Function asstring(verboose As Boolean) As String
        Return Me.ToString()
    End Function
    Public Function returntype() As Type
        Return Me.GetType()
    End Function
    Public Sub ClearBoundingBox()

    End Sub
    Public Function GetBoundingBox()
        Return Me.BoundingBox

    End Function
    Public Sub SetBoundingBox(n As BoundingBox)

    End Sub

    Public Function GetLocalTransform() As matrix44
        Return Me.GetLocalTransform
    End Function
    Public Sub SetLocalTransform(n As matrix44)

    End Sub
    Public Function GetWorldTransform() As matrix44
        Return Me.GetWorldTransform
    End Function
    Public Function GetParent() As NiNode
        Return Me.parent
    End Function
    Public Sub AddProperty(prop As NiProperty)

    End Sub
    Public Sub RemoveProperty(prop As NiProperty)

    End Sub
    Public Sub ClearProperties()

    End Sub
    Public Function GetProperties() As NiProperty()
        Return Me.Properties
    End Function
    Public Function GetPropertyByType(typ As Type, compare_to As Type) As NiProperty

    End Function

    Public Function GetFlags() As Flags
        Return Me.flag
    End Function
    Public Sub SetFlags(n As UShort)

    End Sub
    Public Function GetLocalRotation() As Matrix33
        Return Me.rotation
    End Function
    Public Sub SetLocalRotation(n As Matrix33)

    End Sub
    Public Function GetLocalTranslation() As Vector3
        Return Me.translation
    End Function
    Public Sub SetLocalTranslation(n As Vector3)

    End Sub
    Public Function GetLocalScale() As Single
        Return Me.scale
    End Function
    Public Sub SetLocalScale(n As Single)

    End Sub
    Public Function GetVelocity() As Vector3
        Return Me.velocity
    End Function
    Public Sub SetVelocity(n As Vector3)

    End Sub
    Public Function GetVisibility() As Boolean
        Return True
    End Function
    Public Sub SetVisibility(n As Boolean)

    End Sub
    Public Function GetCollisionObject() As NiCollisionObject()
        Return Me.collisionobject
    End Function
    Public Sub SetCollisionObject(value As NiCollisionObject)

    End Sub
    Public Function GetCollisionMode() As Enums.collisiontypes
        Return Enums.collisiontypes.CT_NONE
    End Function
    Public Sub SetCollisionMode(value As Enums.collisiontypes)

    End Sub
    Public Sub SetParent(new_parent As NiNode)

    End Sub
End Class
