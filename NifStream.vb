Public Class NifStream
    Inherits IO.FileStream
    Public Sub New(filename As String)
        MyBase.New(filename, IO.FileMode.Open)
    End Sub

End Class
