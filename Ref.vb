Imports System.Runtime.InteropServices
Public Class Ref
    Inherits MarshalByRefObject
    Private NiObjectReference As NiObject
    Private NiAVObjectReference As NiAVObject

    Public Property ObReference As NiObject
        Get
            Return NiObjectReference
        End Get
        Set(value As NiObject)
            NiObjectReference = value
        End Set
    End Property

    Public Sub New(ByVal ObReference As NiObject)
        NiObjectReference = ObReference
    End Sub
    ''''
    Public Property ObavReference As NiAVObject
        Get
            Return NiAVObjectReference
        End Get
        Set(value As NiAVObject)
            NiAVObjectReference = value
        End Set
    End Property

    Public Sub New(ByVal ObavReference As NiAVObject)
        NiAVObjectReference = ObavReference
    End Sub
End Class
