Public Class ucSlider

    Public Property Parameter As EffectParameter
    Public Property ValueChangedDelegate As frmEditEffect.EffectSliderChanged

    Public Property Label As String
        Get
            Return lblParameterName.Text
        End Get
        Set(value As String)
            lblParameterName.Text = value
        End Set
    End Property

    Public Property Value As Integer
        Get
            Return sldParameter.Value
        End Get
        Set(value As Integer)
            If value >= sldParameter.Minimum AndAlso value <= sldParameter.Maximum Then
                sldParameter.Value = value
            End If
        End Set
    End Property

    Public Sub SetParameter(fx As EffectParameter)
        Me.Parameter = fx
        lblParameterName.Text = fx.LabelName
        sldParameter.Minimum = fx.MinValue
        sldParameter.Maximum = fx.MaxValue
        sldParameter.Value = fx.MinValue

        ToolTip1.SetToolTip(lblParameterName, fx.Name)
        ToolTip1.SetToolTip(lblParameterValue, $"{fx.MinValue} - {fx.MaxValue}")
        SetDisplayValue(fx.DisplayValueKey, sldParameter.Value)

        Me.Enabled = True

    End Sub

    Public Sub DisableParameter()
        Me.Parameter = Nothing
        lblParameterName.Text = ""
        sldParameter.Minimum = 0
        sldParameter.Maximum = 0
        sldParameter.Value = 0
        lblParameterValue.Text = ""

        ToolTip1.SetToolTip(lblParameterName, "")
        ToolTip1.SetToolTip(lblParameterValue, "")

        Me.Enabled = False

    End Sub

    Private Sub sldParameter_ValueChanged(sender As Object, e As EventArgs) Handles sldParameter.ValueChanged
        SetDisplayValue(Me.Parameter.DisplayValueKey, Me.Value)
    End Sub

    Private Sub SetDisplayValue(key As String, value As Integer)
        If Me.ValueChangedDelegate IsNot Nothing Then
            Me.ValueChangedDelegate.Invoke(Me, New ValueChangedEventArgs With {.NewValue = sldParameter.Value, .Parameter = Me.Parameter})
        End If

        If Not String.IsNullOrEmpty(Me.Parameter.DisplayValueKey) Then
            Select Case key
                Case "DotOne"
                    lblParameterValue.Text = value.ToString.Insert(value.ToString.Length - 1, ".")

                Case Else
                    Dim values() As String

                    values = EffectResources.GetDisplayLookups.GetString(key).Split(vbCrLf)

                    If value > values.Length Then lblParameterValue.Text = value.ToString

                    lblParameterValue.Text = values(value)

            End Select

        Else
            lblParameterValue.Text = sldParameter.Value.ToString
        End If

    End Sub

End Class
