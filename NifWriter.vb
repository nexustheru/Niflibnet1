Imports System
Imports System.Runtime.InteropServices
Imports System.IO

Public Class NifWriter
    Inherits IO.BinaryWriter
    Public Sub New(stream As NifStream)
        MyBase.New(stream)

    End Sub
    Public Function Niobject_to_bytes(ob As NiObject) As Byte()
        Dim _MemoryStream As New System.IO.MemoryStream()
        Dim _BinaryFormatter As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        _BinaryFormatter.Serialize(_MemoryStream, ob)
        Return _MemoryStream.ToArray()
    End Function
    Public Function NiAVobject_to_bytes(ob As NiAVObject) As Byte()
        Dim _MemoryStream As New System.IO.MemoryStream()
        Dim _BinaryFormatter As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        _BinaryFormatter.Serialize(_MemoryStream, ob)
        Return _MemoryStream.ToArray()
    End Function
    Public Function NiNode_to_bytes(ob As NiNode) As Byte()
        Dim _MemoryStream As New System.IO.MemoryStream()
        Dim _BinaryFormatter As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        _BinaryFormatter.Serialize(_MemoryStream, ob)
        Return _MemoryStream.ToArray()
    End Function
End Class
