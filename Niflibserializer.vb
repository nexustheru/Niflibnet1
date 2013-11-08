Imports System
Imports System.Runtime.Serialization
Public Class Niflibserializer
    Implements ISerializable
    Private h As Header
    Public ReadOnly Property blocksize As Generic.List(Of UInteger)
        Get
            Return h.blocksize
        End Get
    End Property
    Public ReadOnly Property blocktypeindex As Generic.List(Of UShort)
        Get
            Return h.blocktypeindex
        End Get
    End Property
    Public ReadOnly Property blocktypes As Generic.List(Of String)
        Get
            Return h.blocktypes
        End Get
    End Property
    Public ReadOnly Property copyright As Generic.List(Of String)
        Get
            Return h.copyright
        End Get
    End Property
    Public Sub GetObjectData(info As System.Runtime.Serialization.SerializationInfo, context As System.Runtime.Serialization.StreamingContext) Implements System.Runtime.Serialization.ISerializable.GetObjectData

    End Sub
    Private Sub New(ByVal Info As SerializationInfo, ByVal Context As StreamingContext)
        With Info
            mstrFullName = .GetString("FullName")
            mintAge = .GetInt32("Age")
        End With
    End Sub
End Class
