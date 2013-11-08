<Serializable()> Public Class NiSkinInstance
    Inherits NiObject
    Public data() As NiSkinData
    Public skinpartion() As NiSkinPartion
    Public skeletonroot As NiNode
    Public numbones As UInteger
    Public bones() As NiNode
End Class
