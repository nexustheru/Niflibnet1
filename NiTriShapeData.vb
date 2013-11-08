<Serializable()> Public Class NiTriShapeData
    Inherits NiGeomtryData
    Public numtrianglepoints As UInteger
    Public hastriangles As Boolean
    Public nummatchgroup As UShort
    Public matchgroup() As MatchGroup
End Class
