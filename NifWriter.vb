Imports System
Imports System.Runtime.InteropServices
Imports System.IO

<Serializable()> Public Class NifWriter
    Inherits IO.BinaryWriter
    Public Sub New(stream As NifStream)
        MyBase.New(stream)

    End Sub
    Public Sub save_Niobject(node As NiNode)
        MyClass.Write(node.name)
        MyClass.Write(node.numchildren)
        For i As Integer = 0 To node.children.Count - 1
            MyClass.Write(node.children(i).name)
        Next
        MyClass.Write(node.numEffects)
        For ip As Integer = 0 To node.Effects.Count - 1
            MyClass.Write(node.Effects(ip).ToString)
        Next
        
    End Sub
End Class
