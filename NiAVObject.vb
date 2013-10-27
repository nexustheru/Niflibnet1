Public Class NiAVObject
    Inherits NiObjectNet
    Public parent As NiNode
    Public flag As Flags
    Public uknownshort1 As UShort
    Public translation As Vector3
    Public rotation As Matrix33
    Public scale As Single
    Public velocity As Vector3
    Public numprops As UInteger
    Public Properties As Generic.List(Of NiProperty)
    Public unknow1 As UInteger
    Public unknown2 As Byte
    Public hasboundingbox As Boolean
    Public BoundingBox As BoundingBox
    Public collisionobject As Generic.List(Of NiCollisionObject)
End Class
