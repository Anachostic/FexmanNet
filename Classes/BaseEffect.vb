<DebuggerDisplay("{Name}")>
Public Class BaseEffect

    Public Property Name As String
    Public Property MSB As Byte
    Public Property LSB As Byte
    Public Property Params As New List(Of EffectParameter)

End Class
