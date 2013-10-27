Public Class NifWriter
    Inherits IO.BinaryWriter
    Public Sub New(stream As NifStream)
        MyBase.New(stream)
       
    End Sub
End Class
