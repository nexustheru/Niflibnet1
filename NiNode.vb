Public Class NiNode
    Inherits NiAVObject
    Public Property name As String
    Public numchildren As UInteger
    Public children As Generic.List(Of NiAVObject)
    Public numEffects As UInteger
    Public Effects As Generic.List(Of NiDynamicEffect)
End Class
