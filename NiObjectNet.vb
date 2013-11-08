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
End Class
