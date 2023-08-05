Imports System.Collections.Specialized
Imports NAudio.Midi

Public Class frmMain

    Private device As MidiOut
    Private _editForm As frmEditEffect
    Private currentPatch As New FexmanPatch
    Private presets As New List(Of String)
    Private isShiftDown As Boolean
    Private patchButtons As New List(Of Button)
    Private _settings As Settings

    Private ReadOnly Property EditForm As frmEditEffect
        Get
            If _editForm Is Nothing Then
                _editForm = New frmEditEffect
                _editForm.Text = $"Edit Patch - {Me.ConfigDescription}"
                AddHandler _editForm.PatchChanged, AddressOf PatchChangedHandler
            End If

            Return _editForm
        End Get
    End Property

    Private ReadOnly Property ConfigDescription As String
        Get
            Return $"{[Enum].GetName(GetType(Enums.DeviceEnum), Me.Settings.LastDevice)}@{MidiOut.DeviceInfo(Me.Settings.LastDeviceIndex).ProductName}"
        End Get
    End Property

    Private ReadOnly Property Settings As Settings
        Get
            If _settings Is Nothing Then
                _settings = Settings.GetInstance
            End If

            Return _settings
        End Get
    End Property

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        patchButtons.AddRange({cmdPreset1, cmdPreset2, cmdPreset3, cmdPreset4, cmdPreset5, cmdPreset6, cmdPreset7, cmdPreset8, cmdPreset9, cmdPreset10})

        LoadSettings()
        InitDevice()
        LoadPatches()
        LoadPresets()

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = False

        SaveSettings()

        If _editForm IsNot Nothing Then
            RemoveHandler _editForm.PatchChanged, AddressOf PatchChangedHandler
            _editForm.IsEnding = True
            _editForm.Close()
            _editForm.Dispose()
        End If

        If device IsNot Nothing Then device.Dispose()

    End Sub

    Private Sub frmMain_Key(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, Me.KeyUp
        isShiftDown = e.Shift
    End Sub

    Private Sub lstPresets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPresets.SelectedIndexChanged
        currentPatch = DirectCast(lstPresets.SelectedItem, FexmanPatch)
        txtName.Text = currentPatch.Name

        Me.EditForm.SetPatch(Me.device, currentPatch)

    End Sub

    Private Sub cmdEditEffect_Click(sender As Object, e As EventArgs) Handles cmdEditEffect.Click
        Me.EditForm.Device = device
        Me.EditForm.Show(Me)

    End Sub

    Private Sub cmdSaveEffect_Click(sender As Object, e As EventArgs) Handles cmdSaveEffect.Click
        currentPatch = Me.EditForm.GetPatch
        currentPatch.Name = txtName.Text

        If chkSafetyMode.Checked Then
            Dim filename As String

            filename = currentPatch.GetFileName(Me.Settings.LastPatchFilePath)
            If Not String.IsNullOrEmpty(filename) AndAlso IO.File.Exists(IO.Path.Combine(Me.Settings.LastPatchFilePath, filename)) Then
                If MsgBox("Do you want to overwrite this patch?", vbYesNo Or MsgBoxStyle.Question) <> MsgBoxResult.Yes Then
                    Exit Sub
                End If
            End If
        End If

        currentPatch.Save(Me.Settings.LastPatchFilePath)

        lblPatchChanged.Visible = False

        LoadPatches()

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub PatchChangedHandler(s As Object, e As EventArgs)
        lblPatchChanged.Visible = True
    End Sub

    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim f As New frmSettings
            f.ShowDialog(Me)

            InitDevice()
            LoadPatches()

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub InitDevice()
        If device IsNot Nothing Then device.Dispose()

        device = YamahaMIDI.InitializeDevice(Me.Settings.LastDeviceIndex)

        Me.Text = $"{My.Application.Info.Title} - {Me.ConfigDescription}"
        If _editForm IsNot Nothing Then
            _editForm.Text = $"Edit Patch - {Me.ConfigDescription}"
        End If
    End Sub

    Private Sub LoadPatches()
        lstPresets.Items.Clear()

        If Not String.IsNullOrWhiteSpace(Me.Settings.LastPatchFilePath) AndAlso IO.Directory.Exists(Me.Settings.LastPatchFilePath) Then
            For Each item In IO.Directory.GetFiles(Me.Settings.LastPatchFilePath, "*.fexpatch")
                lstPresets.Items.Add(FexmanPatch.FromFile(item))
            Next
        End If

    End Sub

    Private Sub LoadSettings()
        chkDebugMode.Checked = Me.Settings.LastDebugMode
    End Sub

    Private Sub SaveSettings()
        Dim s As Settings = Settings.GetInstance

        s.LastDebugMode = chkDebugMode.Checked

        ' store all presets
        rdoGroup1.Checked = False
        rdoGroup2.Checked = False
        rdoGroup3.Checked = False
        rdoGroup4.Checked = False
        s.Presets = New List(Of String)
        s.Presets.AddRange(presets.ToArray)

        s.Save()

    End Sub

    Private Sub LoadPresets()
        Dim s As Settings = Settings.GetInstance

        If s.Presets Is Nothing Then
            presets = New List(Of String)
            For i As Integer = 1 To 40
                presets.Add("")
            Next

        Else
            presets = New List(Of String)(Me.Settings.Presets.Cast(Of String))
        End If

        rdoGroup1.Checked = True

    End Sub

    Private Sub rdoGroup_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGroup1.CheckedChanged, rdoGroup2.CheckedChanged, rdoGroup3.CheckedChanged, rdoGroup4.CheckedChanged
        Dim bank As Integer
        Dim name As String
        Dim index As Integer
        Dim patch As FexmanPatch

        Select Case True
            Case rdoGroup1.Checked
                bank = 0
            Case rdoGroup2.Checked
                bank = 1
            Case rdoGroup3.Checked
                bank = 2
            Case rdoGroup4.Checked
                bank = 3
        End Select

        For i As Integer = 0 To 9
            name = presets.Skip(10 * bank).Skip(i).First
            If String.IsNullOrEmpty(name) Then
                patchButtons(i).Text = ""
                patchButtons(i).Tag = Nothing
                ToolTip1.SetToolTip(patchButtons(i), "Shift-click to assign current patch")
                Continue For
            End If

            index = lstPresets.FindString(name)

            If index >= 0 Then
                patch = DirectCast(lstPresets.Items(index), FexmanPatch)
                patchButtons(i).Text = patch.Name
                patchButtons(i).Tag = patch
                ToolTip1.SetToolTip(patchButtons(i), patch.Name)
            Else
                patchButtons(i).Text = ""
                patchButtons(i).Tag = Nothing
                ToolTip1.SetToolTip(patchButtons(i), "Shift-click to assign current patch")
            End If

        Next

    End Sub

    Private Sub cmdPreset_Click(sender As Object, e As EventArgs) Handles cmdPreset1.Click, cmdPreset2.Click, cmdPreset3.Click, cmdPreset4.Click, cmdPreset5.Click, cmdPreset6.Click, cmdPreset7.Click, cmdPreset8.Click, cmdPreset9.Click, cmdPreset10.Click
        Dim btn As Button
        Dim groupIndex As Integer
        Dim btnIndex As Integer

        btn = DirectCast(sender, Button)

        If isShiftDown AndAlso currentPatch IsNot Nothing Then
            btn.Tag = currentPatch
            btn.Text = currentPatch.Name

            Select Case True
                Case rdoGroup1.Checked
                    groupIndex = 0
                Case rdoGroup2.Checked
                    groupIndex = 1
                Case rdoGroup3.Checked
                    groupIndex = 2
                Case rdoGroup4.Checked
                    groupIndex = 3
            End Select

            btnIndex = patchButtons.FindIndex(Function(x) x Is sender)
            presets((groupIndex * 10) + btnIndex) = currentPatch.Name

        Else
            If btn.Tag IsNot Nothing Then
                currentPatch = DirectCast(btn.Tag, FexmanPatch)
                txtName.Text = currentPatch.Name
                Me.EditForm.SetPatch(Me.device, currentPatch)
            End If

        End If

    End Sub

End Class
