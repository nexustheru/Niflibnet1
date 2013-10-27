Imports System
Public Class NifReader
    Inherits IO.BinaryReader
    Public Sub New(stream As NifStream)
        MyBase.New(stream)
    End Sub
    Public Function NifreaderSeek(offset As Long, beginfrom As IO.SeekOrigin) As Long
        MyBase.BaseStream.Seek(offset, beginfrom)
        Return 1

    End Function
End Class
