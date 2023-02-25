Public Class VariationEffectCollection
    Inherits List(Of VariationEffect)

    Private Sub New()

    End Sub

    Shared Function GetInstance(params As EffectParameterCollection, deviceType As Enums.DeviceEnum) As VariationEffectCollection
        Dim ret As New VariationEffectCollection
        Dim item As VariationEffect
        Dim paramElements() As String

        For Each param As String In EffectResources.GetResource(deviceType).GetString("VariationEffects").Split(vbCrLf)
            paramElements = param.Split(","c)
            item = New VariationEffect With {.MSB = CByte(paramElements(0)), .LSB = CByte(paramElements(1)), .Name = paramElements(3)}
            For Each parmIndex As String In paramElements(2).Split("|"c)
                item.Params.Add(params(CInt(parmIndex)))
            Next

            ret.Add(item)
        Next

        Return ret
    End Function
End Class
