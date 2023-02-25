Public Class ReverbEffectCollection
    Inherits List(Of ReverbEffect)

    Private Sub New()

    End Sub

    Shared Function GetInstance(params As EffectParameterCollection, deviceType As Enums.DeviceEnum) As ReverbEffectCollection
        Dim ret As New ReverbEffectCollection
        Dim item As ReverbEffect
        Dim paramElements() As String

        For Each param As String In EffectResources.GetResource(deviceType).GetString("ReverbEffects").Split(vbCrLf)
            paramElements = param.Split(","c)
            item = New ReverbEffect With {.MSB = CByte(paramElements(0)), .LSB = CByte(paramElements(1)), .Name = paramElements(3)}
            For Each parmIndex As String In paramElements(2).Split("|"c)
                item.Params.Add(params(CInt(parmIndex)))
            Next

            ret.Add(item)
        Next

        Return ret
    End Function
End Class
