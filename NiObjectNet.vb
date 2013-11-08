<Serializable()> Public Class NiObjectNet
    Inherits NiObject
    Public indexstring() As indexstring
    Public hasoldextradata As UInteger
    Public oldextrapropname As indexstring
    Public oldExtraInternalId As UInteger
    Public oldextrastring As indexstring
    Public unknowm As Byte
    Public extradata() As NiExtraData
    Public numextradatalist As UInteger
    Public extraDataList() As NiExtraData
    Public controller() As NiTimeController

    Public Overloads Function asstring(verboose As Boolean) As String
        Return Me.ToString()
    End Function
    Public Overloads Function returntype() As Type
        Return Me.GetType()
    End Function
    Public Function GetName() As String

    End Function
    Public Sub SetName(new_name As String)

    End Sub
    Public Function GetIDString() As String

    End Function
    Public Sub AddExtraData(obj As NiExtraData, version As UInt32)

    End Sub
    Public Sub RemoveExtraData(obj As NiExtraData)

    End Sub
    Public Sub ShiftExtraData(version As UInt32)

    End Sub
    Public Sub ClearExtraData()

    End Sub
    Public Function GetExtraData() As NiExtraData()

    End Function
    Public Function IsAnimated() As Boolean

    End Function
    Public Sub AddController(obj As NiTimeController)

    End Sub
    Public Sub RemoveController(obj As NiTimeController)

    End Sub
    Public Sub ClearControllers()

    End Sub
    Public Function GetControllers() As NiTimeController()

    End Function
End Class
