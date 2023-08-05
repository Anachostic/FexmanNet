Imports NAudio.Midi

Public Class frmEditEffect
    Public Property Device As MidiOut
    Public Property IsEnding As Boolean

    Public Event PatchChanged As EventHandler

    Public Delegate Sub EffectSliderChanged(s As Object, e As ValueChangedEventArgs)
    Public Delegate Sub VolumeSliderChanged(s As Object, e As ByteValueChangedEventArgs)
    Public Delegate Sub SliderMuteChanged(s As Object, e As MuteChangedEventargs)

    Dim currentPatch As New FexmanPatch

    Dim fxParms As EffectParameterCollection
    Dim fxReverb As ReverbEffectCollection
    Dim fxChorus As ChorusEffectCollection
    Dim fxVariation As VariationEffectCollection

    Dim rvbControls As New List(Of ucSlider)
    Dim choControls As New List(Of ucSlider)
    Dim varControls As New List(Of ucSlider)

    Dim reverbSliderChanged As New EffectSliderChanged(AddressOf revSlider_ValueChanged)
    Dim chorusSliderChanged As New EffectSliderChanged(AddressOf choSlider_ValueChanged)
    Dim variationSliderChanged As New EffectSliderChanged(AddressOf varSlider_ValueChanged)

    Dim lvlLineInVolumeChanged As New VolumeSliderChanged(AddressOf lvlLineIn_ValueChanged)
    Dim lvlLineInMuteChanged As New SliderMuteChanged(AddressOf lvlLineIn_MuteChanged)
    Dim lvlMicInVolumeChanged As New VolumeSliderChanged(AddressOf lvlMicIn_ValueChanged)
    Dim lvlMicInMuteChanged As New SliderMuteChanged(AddressOf lvlMicIn_MuteChanged)
    Dim lvlMidiVolumeChanged As New VolumeSliderChanged(AddressOf lvlMIDI_ValueChanged)
    Dim lvlMidiMuteChanged As New SliderMuteChanged(AddressOf lvlMIDI_MuteChanged)
    Dim lvlOutVolumeChanged As New VolumeSliderChanged(AddressOf lvlOut_ValueChanged)
    Dim lvlOutMuteChanged As New SliderMuteChanged(AddressOf lvlOut_MuteChanged)

    Dim lvlChoToRevVolumeChanged As New VolumeSliderChanged(AddressOf lvlChoToRev_ValueChanged)
    Dim lvlVarToRevVolumeChanged As New VolumeSliderChanged(AddressOf lvlVarToRev_ValueChanged)
    Dim lvlVarToChoVolumeChanged As New VolumeSliderChanged(AddressOf lvlVarToCho_ValueChanged)
    Dim lvlToRevVolumeChanged As New VolumeSliderChanged(AddressOf lvlToRev_ValueChanged)
    Dim lvlToChoVolumeChanged As New VolumeSliderChanged(AddressOf lvlToCho_ValueChanged)
    Dim lvlToVarVolumeChanged As New VolumeSliderChanged(AddressOf lvlToVar_ValueChanged)

    Dim lvlReverbVolumeChanged As New VolumeSliderChanged(AddressOf lvlReverb_ValueChanged)
    Dim lvlChorusVolumeChanged As New VolumeSliderChanged(AddressOf lvlChorus_ValueChanged)
    Dim lvlVariationVolumeChanged As New VolumeSliderChanged(AddressOf lvlVariation_ValueChanged)
    Dim lvlDryVolumeChanged As New VolumeSliderChanged(AddressOf lvlDry_ValueChanged)

    Dim lvlReverbMuteChanged As New SliderMuteChanged(AddressOf lvlReverb_MuteChanged)
    Dim lvlChorusMuteChanged As New SliderMuteChanged(AddressOf lvlChorus_MuteChanged)
    Dim lvlVariationMuteChanged As New SliderMuteChanged(AddressOf lvlVariation_MuteChanged)
    Dim lvlDryMuteChanged As New SliderMuteChanged(AddressOf lvlDry_MuteChanged)

    Public Sub New()

        InitializeComponent()

        lvlLineIn.Mutable = True
        lvlMicIn.Mutable = True
        lvlMIDI.Mutable = True
        lvlOut.Mutable = True

        lvlChoToRev.Mutable = False
        lvlToRev.Mutable = False
        lvlToCho.Mutable = False

        lvlReverb.Mutable = True
        lvlChorus.Mutable = True
        lvlVariation.Mutable = True
        lvlDry.Mutable = True

        Dim s As Settings = Settings.GetInstance
        Dim deviceType As Enums.DeviceEnum

        deviceType = CType(s.LastDevice, Enums.DeviceEnum)

        fxParms = EffectParameterCollection.GetInstance(deviceType)
        fxReverb = ReverbEffectCollection.GetInstance(fxParms, deviceType)
        fxChorus = ChorusEffectCollection.GetInstance(fxParms, deviceType)
        fxVariation = VariationEffectCollection.GetInstance(fxParms, deviceType)

        rvbControls.AddRange({rvbParm1, rvbParm2, rvbParm3, rvbParm4, rvbParm5, rvbParm6, rvbParm7, rvbParm8, rvbParm9, rvbParm10, rvbParm11, rvbParm12, rvbParm13, rvbParm14, rvbParm15, rvbParm16})
        choControls.AddRange({choParm1, choParm2, choParm3, choParm4, choParm5, choParm6, choParm7, choParm8, choParm9, choParm10, choParm11, choParm12, choParm13, choParm14, choParm15, choParm16})
        varControls.AddRange({varParm1, varParm2, varParm3, varParm4, varParm5, varParm6, varParm7, varParm8, varParm9, varParm10, varParm11, varParm12, varParm13, varParm14, varParm15, varParm16})

    End Sub

    Private Sub frmEditEffect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lstReverb.Items.Count = 0 Then
            FillCombos()
            SendSendsBulk()
            SendReturnsBulk()
        End If

        BindReverbParameterChanges()
        BindChorusParameterChanges()
        BindVariationParameterChanges()
        BindVolume()
        BindSends()
        BindReturns()

    End Sub

    Private Sub frmEditEffect_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        If Not IsEnding Then e.Cancel = True
    End Sub

    Public Sub SetPatch(device As MidiOut, patch As FexmanPatch)
        Dim fx As BaseEffect

        currentPatch = patch
        Me.Device = device

        UnbindReverbParameterChanges()
        UnbindChorusParameterChanges()
        UnbindVariationParameterChanges()
        UnbindVolume()
        UnbindSends()
        UnbindReturns()

        If lstReverb.Items.Count = 0 Then FillCombos()

        lstReverb.SelectedIndex = lstReverb.FindString(currentPatch.Reverb.EffectName)
        lstChorus.SelectedIndex = lstChorus.FindString(currentPatch.Chorus.EffectName)
        lstVariation.SelectedIndex = lstVariation.FindString(currentPatch.Variation.EffectName)

        If lstReverb.SelectedIndex = -1 Then lstReverb.SelectedIndex = 0
        If lstChorus.SelectedIndex = -1 Then lstChorus.SelectedIndex = 0
        If lstVariation.SelectedIndex = -1 Then lstVariation.SelectedIndex = 0

        fx = DirectCast(lstReverb.SelectedItem, ReverbEffect)
        SetSliders(fx, rvbControls)

        fx = DirectCast(lstChorus.SelectedItem, ChorusEffect)
        SetSliders(fx, choControls)

        fx = DirectCast(lstVariation.SelectedItem, VariationEffect)
        SetSliders(fx, varControls)

        For i = 0 To 15
            rvbControls(i).Value = currentPatch.Reverb.Parameters(i)
            choControls(i).Value = currentPatch.Chorus.Parameters(i)
            varControls(i).Value = currentPatch.Variation.Parameters(i)
        Next

        lvlToRev.Value = CByte(currentPatch.Sends.ToReverb)
        lvlToCho.Value = CByte(currentPatch.Sends.ToChorus)
        lvlChoToRev.Value = CByte(currentPatch.Sends.ChorusToReverb)
        lvlVarToRev.Value = CByte(currentPatch.Sends.VariationToReverb)
        lvlVarToCho.Value = CByte(currentPatch.Sends.VariationToChorus)

        lvlReverb.Value = CByte(currentPatch.Returns.Reverb)
        lvlChorus.Value = CByte(currentPatch.Returns.Chorus)
        lvlVariation.Value = CByte(currentPatch.Returns.Variation)
        lvlDry.Value = CByte(currentPatch.Returns.Dry)

        SendReverbBulk()
        SendChorusBulk()
        SendVariationBulk()
        SendSendsBulk()
        SendReturnsBulk()

        BindReverbParameterChanges()
        BindChorusParameterChanges()
        BindVariationParameterChanges()
        BindVolume()
        BindSends()
        BindReturns()

    End Sub

    Public Function GetPatch() As FexmanPatch
        Dim params As List(Of Integer)

        If currentPatch Is Nothing Then currentPatch = New FexmanPatch

        If lstReverb.SelectedItem IsNot Nothing Then
            currentPatch.Reverb.EffectName = DirectCast(lstReverb.SelectedItem, BaseEffect).Name
        End If

        params = New List(Of Integer)
        For i As Integer = 0 To 15
            params.Add(rvbControls(i).Value)
        Next

        currentPatch.Reverb.Parameters = params.ToArray

        If lstChorus.SelectedItem IsNot Nothing Then
            currentPatch.Chorus.EffectName = DirectCast(lstChorus.SelectedItem, BaseEffect).Name
        End If

        params = New List(Of Integer)
        For i As Integer = 0 To 15
            params.Add(choControls(i).Value)
        Next

        currentPatch.Chorus.Parameters = params.ToArray

        If lstVariation.SelectedItem IsNot Nothing Then
            currentPatch.Variation.EffectName = DirectCast(lstVariation.SelectedItem, BaseEffect).Name
        End If

        params = New List(Of Integer)
        For i As Integer = 0 To 15
            params.Add(varControls(i).Value)
        Next

        currentPatch.Variation.Parameters = params.ToArray

        With currentPatch.Volume
            .LineIn = lvlLineIn.Value
            .MicIn = lvlMicIn.Value
            .MIDI = lvlMIDI.Value
            .Output = lvlOut.Value
        End With

        With currentPatch.Sends
            .ChorusToReverb = lvlChoToRev.Value
            .VariationToReverb = lvlVarToRev.Value
            .VariationToChorus = lvlVarToCho.Value
            .ToChorus = lvlToCho.Value
            .ToReverb = lvlToRev.Value
        End With

        With currentPatch.Returns
            .Chorus = lvlChorus.Value
            .Dry = lvlDry.Value
            .Reverb = lvlReverb.Value
            .Variation = lvlVariation.Value
        End With

        Return currentPatch

    End Function

    Private Sub FillCombos()
        lstReverb.DataSource = fxReverb
        lstChorus.DataSource = fxChorus
        lstVariation.DataSource = fxVariation

    End Sub

    Private Sub SetSliders(fx As BaseEffect, parms As List(Of ucSlider))
        For i As Integer = 0 To 15
            If Not String.IsNullOrEmpty(fx.Params(i).LabelName) Then
                parms(i).SetParameter(fx.Params(i))
            Else
                parms(i).DisableParameter()
            End If

        Next

    End Sub

#Region "Reverb"

    Private Sub BindReverbParameterChanges()
        For i As Integer = 0 To rvbControls.Count - 1
            rvbControls(i).ValueChangedDelegate = reverbSliderChanged
        Next

        AddHandler lstReverb.SelectedIndexChanged, AddressOf lstReverb_SelectedIndexChanged

    End Sub

    Private Sub UnbindReverbParameterChanges()
        For i As Integer = 0 To rvbControls.Count - 1
            rvbControls(i).ValueChangedDelegate = Nothing
        Next

        RemoveHandler lstReverb.SelectedIndexChanged, AddressOf lstReverb_SelectedIndexChanged

    End Sub

    Private Sub lstReverb_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim fx As ReverbEffect
        Dim hasHandler As Boolean

        fx = DirectCast(lstReverb.SelectedItem, ReverbEffect)

        hasHandler = Not IsNothing(rvbControls(0).ValueChangedDelegate)
        If hasHandler Then UnbindReverbParameterChanges()
        SetSliders(fx, rvbControls)
        If hasHandler Then BindReverbParameterChanges()

        YamahaMIDI.SendReverbChange(Me.Device, fx)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub revSlider_ValueChanged(s As Object, e As ValueChangedEventArgs)
        Dim sld As ucSlider

        sld = DirectCast(s, ucSlider)
        YamahaMIDI.SendReverbParameterLevel(Me.Device, sld.TabIndex, sld.Value)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub SendReverbBulk()
        Dim fx As ReverbEffect

        fx = DirectCast(lstReverb.SelectedItem, ReverbEffect)

        YamahaMIDI.SendReverbChange(Me.Device, fx)

        For i As Integer = 0 To 15
            If rvbControls(i).Enabled Then
                YamahaMIDI.SendReverbParameterLevel(Me.Device, i, rvbControls(i).Value)
            End If
        Next

    End Sub

#End Region

#Region "Chorus"

    Private Sub BindChorusParameterChanges()
        For i As Integer = 0 To choControls.Count - 1
            choControls(i).ValueChangedDelegate = chorusSliderChanged
        Next

        AddHandler lstChorus.SelectedIndexChanged, AddressOf lstChorus_SelectedIndexChanged

    End Sub

    Private Sub UnbindChorusParameterChanges()
        For i As Integer = 0 To choControls.Count - 1
            choControls(i).ValueChangedDelegate = Nothing
        Next

        RemoveHandler lstChorus.SelectedIndexChanged, AddressOf lstChorus_SelectedIndexChanged

    End Sub

    Private Sub lstChorus_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim fx As ChorusEffect
        Dim hasHandler As Boolean

        fx = DirectCast(lstChorus.SelectedItem, ChorusEffect)

        hasHandler = Not IsNothing(choControls(0).ValueChangedDelegate)
        If hasHandler Then UnbindChorusParameterChanges()
        SetSliders(fx, choControls)
        If hasHandler Then BindChorusParameterChanges()

        YamahaMIDI.SendChorusChange(Me.Device, fx)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub choSlider_ValueChanged(s As Object, e As ValueChangedEventArgs)
        Dim sld As ucSlider

        sld = DirectCast(s, ucSlider)
        YamahaMIDI.SendChorusParameterLevel(Me.Device, sld.TabIndex, sld.Value)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub SendChorusBulk()
        Dim fx As ChorusEffect

        fx = DirectCast(lstChorus.SelectedItem, ChorusEffect)

        YamahaMIDI.SendChorusChange(Me.Device, fx)

        For i As Integer = 0 To 15
            If choControls(i).Enabled Then
                YamahaMIDI.SendChorusParameterLevel(Me.Device, i, choControls(i).Value)
            End If
        Next

    End Sub

#End Region

#Region "Variation"

    Private Sub BindVariationParameterChanges()
        For i As Integer = 0 To varControls.Count - 1
            varControls(i).ValueChangedDelegate = variationSliderChanged
        Next

        AddHandler lstVariation.SelectedIndexChanged, AddressOf lstVariation_SelectedIndexChanged

    End Sub

    Private Sub UnbindVariationParameterChanges()
        For i As Integer = 0 To varControls.Count - 1
            varControls(i).ValueChangedDelegate = Nothing
        Next

        RemoveHandler lstVariation.SelectedIndexChanged, AddressOf lstVariation_SelectedIndexChanged

    End Sub

    Private Sub lstVariation_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim fx As VariationEffect
        Dim hasHandler As Boolean

        fx = DirectCast(lstVariation.SelectedItem, VariationEffect)

        hasHandler = Not IsNothing(varControls(0).ValueChangedDelegate)
        If hasHandler Then UnbindVariationParameterChanges()
        SetSliders(fx, varControls)
        If hasHandler Then BindVariationParameterChanges()

        YamahaMIDI.SendVariationChange(Me.Device, fx)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub varSlider_ValueChanged(s As Object, e As ValueChangedEventArgs)
        Dim sld As ucSlider

        sld = DirectCast(s, ucSlider)
        YamahaMIDI.SendVariationParameterLevel(Me.Device, sld.TabIndex, sld.Value)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub SendVariationBulk()
        Dim fx As VariationEffect

        fx = DirectCast(lstVariation.SelectedItem, VariationEffect)

        YamahaMIDI.SendVariationChange(Me.Device, fx)

        For i As Integer = 0 To 15
            If varControls(i).Enabled Then
                YamahaMIDI.SendVariationParameterLevel(Me.Device, i, varControls(i).Value)
            End If
        Next

    End Sub

#End Region

#Region "Master Volume"

    Private Sub BindVolume()
        lvlLineIn.VolumeChangedDelegate = lvlLineInVolumeChanged
        lvlLineIn.MuteChangedDelegate = lvlLineInMuteChanged
        lvlMicIn.VolumeChangedDelegate = lvlMicInVolumeChanged
        lvlMicIn.MuteChangedDelegate = lvlMidiMuteChanged
        lvlMIDI.VolumeChangedDelegate = lvlMidiVolumeChanged
        lvlMIDI.MuteChangedDelegate = lvlMidiMuteChanged
        lvlOut.VolumeChangedDelegate = lvlOutVolumeChanged
        lvlOut.MuteChangedDelegate = lvlOutMuteChanged

    End Sub

    Private Sub UnbindVolume()
        lvlLineIn.VolumeChangedDelegate = Nothing
        lvlLineIn.MuteChangedDelegate = Nothing
        lvlMicIn.VolumeChangedDelegate = Nothing
        lvlMicIn.MuteChangedDelegate = Nothing
        lvlMIDI.VolumeChangedDelegate = Nothing
        lvlMIDI.MuteChangedDelegate = Nothing
        lvlOut.VolumeChangedDelegate = Nothing
        lvlOut.MuteChangedDelegate = Nothing

    End Sub

    Private Sub lvlLineIn_ValueChanged(sender As Object, e As ByteValueChangedEventArgs)
        YamahaMIDI.SendVolumeChange(Me.Device, YamahaMIDI.VolumeEnum.LineInleft, e.NewValue)
        YamahaMIDI.SendVolumeChange(Me.Device, YamahaMIDI.VolumeEnum.LineInRight, e.NewValue)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlLineIn_MuteChanged(sender As Object, e As MuteChangedEventargs)
        If e.Muted Then
            YamahaMIDI.SendVolumeChange(Me.Device, YamahaMIDI.VolumeEnum.LineInleft, 0)
            YamahaMIDI.SendVolumeChange(Me.Device, YamahaMIDI.VolumeEnum.LineInRight, 0)
        Else
            YamahaMIDI.SendVolumeChange(Me.Device, YamahaMIDI.VolumeEnum.LineInleft, lvlLineIn.Value)
            YamahaMIDI.SendVolumeChange(Me.Device, YamahaMIDI.VolumeEnum.LineInRight, lvlLineIn.Value)

        End If

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlMicIn_ValueChanged(sender As Object, e As ByteValueChangedEventArgs)
        YamahaMIDI.SendVolumeChange(Me.Device, YamahaMIDI.VolumeEnum.MicInLeft, e.NewValue)
        YamahaMIDI.SendVolumeChange(Me.Device, YamahaMIDI.VolumeEnum.MicInRight, e.NewValue)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlMicIn_MuteChanged(sender As Object, e As MuteChangedEventargs)
        If e.Muted Then
            YamahaMIDI.SendVolumeChange(Me.Device, YamahaMIDI.VolumeEnum.MicInLeft, 0)
            YamahaMIDI.SendVolumeChange(Me.Device, YamahaMIDI.VolumeEnum.MicInRight, 0)
        Else
            YamahaMIDI.SendVolumeChange(Me.Device, YamahaMIDI.VolumeEnum.MicInLeft, lvlMicIn.Value)
            YamahaMIDI.SendVolumeChange(Me.Device, YamahaMIDI.VolumeEnum.MicInRight, lvlMicIn.Value)
        End If

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlMIDI_ValueChanged(sender As Object, e As ByteValueChangedEventArgs)
        YamahaMIDI.SendVolumeChange(Me.Device, YamahaMIDI.VolumeEnum.MIDI, e.NewValue)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlMIDI_MuteChanged(sender As Object, e As MuteChangedEventargs)
        If e.Muted Then
            YamahaMIDI.SendVolumeChange(Me.Device, YamahaMIDI.VolumeEnum.MIDI, 0)
        Else
            YamahaMIDI.SendVolumeChange(Me.Device, YamahaMIDI.VolumeEnum.MicInLeft, lvlMIDI.Value)
        End If

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlOut_ValueChanged(sender As Object, e As ByteValueChangedEventArgs)
        YamahaMIDI.SendVolumeOutput(Me.Device, e.NewValue)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlOut_MuteChanged(sender As Object, e As MuteChangedEventargs)
        If e.Muted Then
            YamahaMIDI.SendVolumeOutput(Me.Device, 0)
        Else
            YamahaMIDI.SendVolumeOutput(Me.Device, lvlOut.Value)
        End If

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

#End Region

#Region "Sends"

    Private Sub BindSends()
        lvlChoToRev.VolumeChangedDelegate = lvlChoToRevVolumeChanged
        lvlVarToCho.VolumeChangedDelegate = lvlVarToChoVolumeChanged
        lvlVarToRev.VolumeChangedDelegate = lvlVarToRevVolumeChanged
        lvlToRev.VolumeChangedDelegate = lvlToRevVolumeChanged
        lvlToCho.VolumeChangedDelegate = lvlToChoVolumeChanged

    End Sub

    Private Sub UnbindSends()
        lvlChoToRev.VolumeChangedDelegate = Nothing
        lvlVarToCho.VolumeChangedDelegate = Nothing
        lvlVarToRev.VolumeChangedDelegate = Nothing
        lvlToRev.VolumeChangedDelegate = Nothing
        lvlToCho.VolumeChangedDelegate = Nothing

    End Sub

    Private Sub lvlChoToRev_ValueChanged(sender As Object, e As ByteValueChangedEventArgs)
        YamahaMIDI.SendSendChorusToReverbLevel(Me.Device, e.NewValue)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlVarToRev_ValueChanged(sender As Object, e As ByteValueChangedEventArgs)
        YamahaMIDI.SendSendVariationToReverbLevel(Me.Device, e.NewValue)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlVarToCho_ValueChanged(sender As Object, e As ByteValueChangedEventArgs)
        YamahaMIDI.SendSendVariationToChorusLevel(Me.Device, e.NewValue)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlToRev_ValueChanged(sender As Object, e As ByteValueChangedEventArgs)
        YamahaMIDI.SendSendToReverbLevel(Me.Device, e.NewValue)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlToCho_ValueChanged(sender As Object, e As ByteValueChangedEventArgs)
        YamahaMIDI.SendSendToChorusLevel(Me.Device, e.NewValue)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlToVar_ValueChanged(sender As Object, e As ByteValueChangedEventArgs)
        YamahaMIDI.SendSendToVariationLevel(Me.Device, e.NewValue)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub SendSendsBulk()
        YamahaMIDI.SendSendChorusToReverbLevel(Me.Device, lvlChoToRev.Value)
        YamahaMIDI.SendSendVariationToReverbLevel(Me.Device, lvlVarToRev.Value)
        YamahaMIDI.SendSendVariationToChorusLevel(Me.Device, lvlVarToCho.Value)
        YamahaMIDI.SendSendToReverbLevel(Me.Device, lvlToRev.Value)
        YamahaMIDI.SendSendToChorusLevel(Me.Device, lvlToCho.Value)

    End Sub

#End Region

#Region "Returns"

    Private Sub BindReturns()
        lvlReverb.VolumeChangedDelegate = lvlReverbVolumeChanged
        lvlChorus.VolumeChangedDelegate = lvlChorusVolumeChanged
        lvlVariation.VolumeChangedDelegate = lvlVariationVolumeChanged
        lvlDry.VolumeChangedDelegate = lvlDryVolumeChanged

        lvlReverb.MuteChangedDelegate = lvlReverbMuteChanged
        lvlChorus.MuteChangedDelegate = lvlChorusMuteChanged
        lvlVariation.MuteChangedDelegate = lvlVariationMuteChanged
        lvlDry.MuteChangedDelegate = lvlDryMuteChanged

    End Sub

    Private Sub UnbindReturns()
        lvlReverb.VolumeChangedDelegate = Nothing
        lvlChorus.VolumeChangedDelegate = Nothing
        lvlVariation.VolumeChangedDelegate = Nothing
        lvlDry.VolumeChangedDelegate = Nothing

        lvlReverb.MuteChangedDelegate = Nothing
        lvlChorus.MuteChangedDelegate = Nothing
        lvlVariation.MuteChangedDelegate = Nothing
        lvlDry.MuteChangedDelegate = Nothing

    End Sub

    Private Sub lvlReverb_ValueChanged(sender As Object, e As ByteValueChangedEventArgs)
        YamahaMIDI.SendReturnReverbLevel(Me.Device, e.NewValue)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlChorus_ValueChanged(sender As Object, e As ByteValueChangedEventArgs)
        YamahaMIDI.SendReturnChorusLevel(Me.Device, e.NewValue)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlVariation_ValueChanged(sender As Object, e As ByteValueChangedEventArgs)
        YamahaMIDI.SendReturnVariationLevel(Me.Device, e.NewValue)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlDry_ValueChanged(sender As Object, e As ByteValueChangedEventArgs)
        YamahaMIDI.SendReturnDryLevel(Me.Device, e.NewValue)

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlReverb_MuteChanged(sender As Object, e As MuteChangedEventargs)
        If e.Muted Then
            YamahaMIDI.SendReturnReverbLevel(Me.Device, 0)
        Else
            YamahaMIDI.SendReturnReverbLevel(Me.Device, lvlReverb.Value)
        End If

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlChorus_MuteChanged(sender As Object, e As MuteChangedEventargs)
        If e.Muted Then
            YamahaMIDI.SendReturnChorusLevel(Me.Device, 0)
        Else
            YamahaMIDI.SendReturnChorusLevel(Me.Device, lvlChorus.Value)
        End If

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlVariation_MuteChanged(sender As Object, e As MuteChangedEventargs)
        If e.Muted Then
            YamahaMIDI.SendReturnVariationLevel(Me.Device, 0)
        Else
            YamahaMIDI.SendReturnVariationLevel(Me.Device, lvlVariation.Value)
        End If

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub lvlDry_MuteChanged(sender As Object, e As MuteChangedEventargs)
        If e.Muted Then
            YamahaMIDI.SendReturnDryLevel(Me.Device, 0)
        Else
            YamahaMIDI.SendReturnDryLevel(Me.Device, lvlDry.Value)
        End If

        RaiseEvent PatchChanged(Me, New EventArgs)

    End Sub

    Private Sub SendReturnsBulk()
        YamahaMIDI.SendReturnReverbLevel(Me.Device, lvlReverb.Value)
        YamahaMIDI.SendReturnChorusLevel(Me.Device, lvlChorus.Value)
        YamahaMIDI.SendReturnVariationLevel(Me.Device, lvlVariation.Value)
        YamahaMIDI.SendReturnDryLevel(Me.Device, lvlDry.Value)

    End Sub

#End Region

End Class