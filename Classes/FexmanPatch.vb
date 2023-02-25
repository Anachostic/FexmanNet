Imports System.Runtime
Imports System.Text.Json.Nodes
Imports Newtonsoft.Json

Public Class FexmanPatch
    Public Property Name As String
    Public Property Volume As New Volume
    Public Property Sends As New Sends
    Public Property Returns As New Returns
    Public Property Reverb As New PatchEffect
    Public Property Chorus As New PatchEffect
    Public Property Variation As New PatchEffect

    Shared Function FromFile(path As String) As FexmanPatch
        Dim data As String = IO.File.ReadAllText(path)
        Dim patch As New FexmanPatch
        Dim params As List(Of Integer)

        If data.StartsWith("Fex 3.0") Then
            Dim datalines() As String
            Dim device As Enums.DeviceEnum
            Dim fxParams As EffectParameterCollection
            Dim rvbEffects As ReverbEffectCollection
            Dim choEffects As ChorusEffectCollection
            Dim varEffects As VariationEffectCollection

            device = CType(My.Settings.LastDevice, Enums.DeviceEnum)
            fxParams = EffectParameterCollection.GetInstance(device)
            rvbEffects = ReverbEffectCollection.GetInstance(fxParams, device)
            choEffects = ChorusEffectCollection.GetInstance(fxParams, device)
            varEffects = VariationEffectCollection.GetInstance(fxParams, device)

            datalines = data.Split(vbCrLf)
            patch.Name = datalines(1)

            patch.Reverb.EffectName = rvbEffects(CInt(datalines(11))).Name
            params = New List(Of Integer)
            For i As Integer = 12 To 27
                If datalines(i) = "-1" Then
                    params.Add(0)
                Else
                    params.Add(CInt(datalines(i)))
                End If
            Next
            patch.Reverb.Parameters = params.ToArray

            patch.Chorus.EffectName = choEffects(CInt(datalines(29))).Name
            params = New List(Of Integer)
            For i As Integer = 30 To 45
                If datalines(i) = "-1" Then
                    params.Add(0)
                Else
                    params.Add(CInt(datalines(i)))
                End If
            Next
            patch.Chorus.Parameters = params.ToArray

            patch.Variation.EffectName = varEffects(CInt(datalines(47))).Name
            params = New List(Of Integer)
            For i As Integer = 48 To 63
                If datalines(i) = "-1" Then
                    params.Add(0)
                Else
                    params.Add(CInt(datalines(i)))
                End If
            Next
            patch.Variation.Parameters = params.ToArray

        End If

        If data.StartsWith("{") Then
            patch = JsonConvert.DeserializeObject(Of FexmanPatch)(IO.File.ReadAllText(path))
        End If

        Return patch

    End Function

    Public Sub Save(folder As String)
        Dim data As String
        Dim filename As String

        filename = Me.GetFileName(folder)

        If Not String.IsNullOrEmpty(filename) Then
            data = JsonConvert.SerializeObject(Me)
            IO.File.WriteAllText(IO.Path.Combine(folder, filename), data)

        End If

    End Sub

    Public Function GetFileName(folder As String) As String
        Dim filename As String

        If IO.Directory.Exists(folder) Then
            filename = Me.Name
            For Each c In IO.Path.GetInvalidFileNameChars
                filename = filename.Replace(c, "_")
            Next
            filename &= ".fexpatch"

            Return filename

        Else
            Return ""
        End If
    End Function

    Public Overrides Function ToString() As String
        If Not String.IsNullOrEmpty(Me.Name) Then
            Return Me.Name
        Else
            Return "**Unnamed patch**"
        End If
    End Function
End Class

Public Class Volume
    Public Property LineIn As Integer
    Public Property MicIn As Integer
    Public Property MIDI As Integer
    Public Property Output As Integer
End Class

Public Class Sends
    Public Property ChorusToReverb As Integer
    Public Property VariationToReverb As Integer
    Public Property VariationToChorus As Integer
    Public Property ToReverb As Integer
    Public Property ToChorus As Integer
End Class

Public Class Returns
    Public Property Reverb As Integer
    Public Property Chorus As Integer
    Public Property Variation As Integer
    Public Property Dry As Integer
End Class

Public Class PatchEffect
    Public Property EffectName As String
    Public Property Parameters As Integer()
End Class