Public Class ValueChangedEventArgs
    Inherits EventArgs

    Public Property Parameter As EffectParameter
    Public Property NewValue As Integer
End Class

Public Class ByteValueChangedEventArgs
    Inherits EventArgs

    Public Property Parameter As EffectParameter
    Public Property NewValue As Byte
End Class