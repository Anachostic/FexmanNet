Public Class ucSliderMutable

    Public Property VolumeChangedDelegate As frmEditEffect.VolumeSliderChanged
    Public Property MuteChangedDelegate As frmEditEffect.SliderMuteChanged

    Public Property Label As String
        Get
            Return lblParameterName.Text
        End Get
        Set(value As String)
            lblParameterName.Text = value
        End Set
    End Property

    Public Property Value As Byte
        Get
            Return CByte(sldParameter.Value)
        End Get
        Set(value As Byte)
            If value >= sldParameter.Minimum AndAlso value <= sldParameter.Maximum Then
                sldParameter.Value = value
            End If
        End Set
    End Property

    Public Property Muted As Boolean
        Get
            Return chkMute.Checked
        End Get
        Set(value As Boolean)

            chkMute.Checked = value
        End Set
    End Property

    Public Property Mutable As Boolean
        Get
            Return chkMute.Visible
        End Get
        Set(value As Boolean)
            If value Then
                chkMute.Visible = True
                lblParameterName.Height = 17
            Else
                chkMute.Visible = False
                lblParameterName.Height = 27
            End If
        End Set
    End Property

    Public Sub New()
        InitializeComponent()

        Me.Mutable = True

    End Sub

    Private Sub sldParameter_ValueChanged(sender As Object, e As EventArgs) Handles sldParameter.ValueChanged
        If VolumeChangedDelegate IsNot Nothing Then
            Me.VolumeChangedDelegate.Invoke(Me, New ByteValueChangedEventArgs With {.NewValue = CByte(sldParameter.Value)})
        End If

    End Sub

    Private Sub chkMute_CheckedChanged(sender As Object, e As EventArgs) Handles chkMute.CheckedChanged
        If Me.MuteChangedDelegate IsNot Nothing Then
            Me.MuteChangedDelegate.Invoke(Me, New MuteChangedEventargs With {.Muted = chkMute.Checked})
        End If

        sldParameter.Enabled = Not chkMute.Checked

    End Sub

End Class
