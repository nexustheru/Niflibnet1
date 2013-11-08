Imports System
<Serializable()> Public Class NiObject
    Private children() As Type
    Private count As Integer
    Public Property name As String
    Public Sub New()
        MyBase.New()
    End Sub
    Public Function getchildren_size() As Integer
        Return children.Length
    End Function
    Public Function getchildren_at(pos As Integer) As Type
        Return children(pos)

    End Function
    Public Sub addchild(ob As Type)
        For i As Integer = 0 To children.Length - 1
            Dim lastpos = children.Length
            children(lastpos + 1) = ob
        Next
    End Sub
End Class
