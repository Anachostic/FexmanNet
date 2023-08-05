Imports NAudio.Midi

Public Class YamahaMIDI

    Private Shared ReadOnly Property SYSEX_START As Byte() = {&HF0}
    Private Shared ReadOnly Property SYSEX_XGBASE As Byte() = {&H43, &H10, &H4C} ' Yamaha ID, Device #, Model #
    Private Shared ReadOnly Property SYSEX_END As Byte() = {&HF7}

    Private Shared ReadOnly Property SYSEX_XGRESET As Byte() = {&H0, &H0, &H7E, &H0}
    Private Shared ReadOnly Property SYSEX_STEREOMODE As Byte() = {&H11, &H0, &H0, &H1}
    Private Shared ReadOnly Property SYSEX_ADPART1 As Byte() = {&H2, &H1, &H5B, &H40}
    Private Shared ReadOnly Property SYSEX_MAXVOLUME As Byte() = {&H10, &H0, &HB, &H7F}
    Private Shared ReadOnly Property SYSEX_MAXVOLUME2 As Byte() = {&H10, &H1, &HB, &H7F}

    Private Shared ReadOnly Property SYSEX_VOLUME As Byte() = {&H43, &H10, &H7A, &H0, &H0}
    Private Shared ReadOnly Property SYSEX_KAROKEOFF As Byte() = {&H43, &H10, &H49, &H1, &H0, &H1, &H0}
    Private Shared ReadOnly Property SYSEX_ADPARTON As Byte() = {&H43, &H10, &H49, &H1, &H0, &H0, &H1}

    Private Shared lock As New Object

    Public Enum VolumeEnum As Byte
        LineInleft = &H0
        LineInRight = &H1
        MIDI = &HB
        MicInLeft = &H2
        MicInRight = &H3
    End Enum

    Public Shared Function InitializeDevice(deviceIndex As Integer) As MidiOut
        Dim device As MidiOut

        device = New MidiOut(deviceIndex)

        Dim msg As New List(Of Byte)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(SYSEX_XGRESET)
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

        Threading.Thread.Sleep(2000)

        msg.Clear()
        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(SYSEX_STEREOMODE)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_KAROKEOFF)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_ADPARTON)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(SYSEX_ADPART1)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(SYSEX_MAXVOLUME)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(SYSEX_MAXVOLUME2)

        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

        Return device

    End Function

    Public Shared Sub SendReverbChange(device As MidiOut, fx As ReverbEffect)
        Dim msg As New List(Of Byte)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H2, &H1, &H0, fx.MSB, fx.LSB})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendChorusChange(device As MidiOut, fx As ChorusEffect)
        Dim msg As New List(Of Byte)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H2, &H1, &H20, fx.MSB, fx.LSB})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendVariationChange(device As MidiOut, fx As VariationEffect)
        Dim msg As New List(Of Byte)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H2, &H1, &H40, fx.MSB, fx.LSB})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendReverbParameterLevel(device As MidiOut, parameterIndex As Integer, value As Integer)
        Dim msg As New List(Of Byte)
        Dim msb As Byte
        Dim lsb As Byte

        If parameterIndex >= 10 Then
            parameterIndex += 6
        Else
            parameterIndex += 2
        End If

        If value > 127 Then
            msb = CByte(value / 127)
            lsb = CByte(value Mod 127)
        Else
            msb = 0
            lsb = CByte(value)
        End If

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H2, &H1, CByte(parameterIndex), lsb})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendChorusParameterLevel(device As MidiOut, parameterIndex As Integer, value As Integer)
        Dim msg As New List(Of Byte)
        Dim msb As Byte
        Dim lsb As Byte

        If parameterIndex >= 10 Then
            parameterIndex += 38
        Else
            parameterIndex += 34
        End If

        If value > 127 Then
            msb = CByte(value / 127)
            lsb = CByte(value Mod 127)
        Else
            msb = 0
            lsb = CByte(value)
        End If

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H2, &H1, CByte(parameterIndex), lsb})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendVariationParameterLevel(device As MidiOut, parameterIndex As Integer, value As Integer)
        Dim msg As New List(Of Byte)
        Dim msgByteIndex As Integer
        Dim msb As Byte
        Dim lsb As Byte

        If parameterIndex < 10 Then
            ' Variation lower parms are 2 bytes each
            msgByteIndex = (parameterIndex * 2) + 66
        Else
            msgByteIndex = parameterIndex + 102
        End If

        If value > 127 Then
            msb = CByte(value / 127)
            lsb = CByte(value Mod 127)
        Else
            msb = 0
            lsb = CByte(value)
        End If

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H2, &H1, CByte(msgByteIndex)})
        If parameterIndex < 10 Then
            ' variation lower parms are 2 bytes
            msg.AddRange(New Byte() {msb, lsb})
        Else
            msg.Add(lsb)
        End If
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendVolumeChange(device As MidiOut, inp As VolumeEnum, value As Byte)
        Dim msg As New List(Of Byte)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_VOLUME)
        msg.AddRange(New Byte() {inp, value})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendVolumeOutput(device As MidiOut, value As Byte)
        Dim msg As New List(Of Byte)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H0, &H0, &H4, value})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendSendChorusToReverbLevel(device As MidiOut, value As Byte)
        Dim msg As New List(Of Byte)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H2, &H1, &H2E, value})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendSendVariationToReverbLevel(device As MidiOut, value As Byte)
        Dim msg As New List(Of Byte)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H2, &H1, &H58, value})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendSendVariationToChorusLevel(device As MidiOut, value As Byte)
        Dim msg As New List(Of Byte)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H2, &H1, &H59, value})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendSendToChorusLevel(device As MidiOut, value As Byte)
        Dim msg As New List(Of Byte)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H10, &H0, &H12, value})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendSendToReverbLevel(device As MidiOut, value As Byte)
        Dim msg As New List(Of Byte)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H10, &H0, &H13, value})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendSendToVariationLevel(device As MidiOut, value As Byte)
        Dim msg As New List(Of Byte)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H10, &H0, &H14, value})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendReturnChorusLevel(device As MidiOut, value As Byte)
        Dim msg As New List(Of Byte)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H2, &H1, &H2C, value})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendReturnReverbLevel(device As MidiOut, value As Byte)
        Dim msg As New List(Of Byte)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H2, &H1, &HC, value})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendReturnVariationLevel(device As MidiOut, value As Byte)
        Dim msg As New List(Of Byte)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H2, &H1, &H56, value})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Public Shared Sub SendReturnDryLevel(device As MidiOut, value As Byte)
        Dim msg As New List(Of Byte)

        msg.AddRange(SYSEX_START)
        msg.AddRange(SYSEX_XGBASE)
        msg.AddRange(New Byte() {&H10, &H0, &H11, value})
        msg.AddRange(SYSEX_END)

        SendSysEx(device, msg.ToArray)

    End Sub

    Private Shared Sub SendSysEx(device As MidiOut, msg() As Byte, Optional debugMode As Boolean = False)
        SyncLock lock
            device.SendBuffer(msg)
        End SyncLock

        If debugMode Then
            For Each b As Byte In msg
                Debug.Write(b.ToString("x2") & " ")
            Next

            Debug.WriteLine("")

        End If

    End Sub

End Class
