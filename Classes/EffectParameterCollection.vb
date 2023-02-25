Public Class EffectParameterCollection
    Inherits List(Of EffectParameter)

    Private Sub New()

    End Sub

    Shared Function GetInstance(deviceType As Enums.DeviceEnum) As EffectParameterCollection
        Dim ret As New EffectParameterCollection
        Dim item As EffectParameter
        Dim paramElements() As String

        For Each param As String In EffectResources.GetResource(deviceType).GetString("EffectParameters").Split(vbCrLf)
            paramElements = param.Split(","c)

            item = New EffectParameter With {.MinValue = CInt(paramElements(0)), .MaxValue = CInt(paramElements(1)), .Name = paramElements(2), .LabelName = paramElements(3), .DisplayValueKey = paramElements(4)}
            ret.Add(item)
        Next

        Return ret

    End Function

End Class
