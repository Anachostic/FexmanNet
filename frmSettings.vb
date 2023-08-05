Imports NAudio.Midi

Public Class frmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDevices()
        LoadSettings()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        SaveSettings()
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub LoadDevices()
        For i As Integer = 0 To MidiOut.NumberOfDevices - 1
            lstMIDIOutDevice.Items.Add(MidiOut.DeviceInfo(i).ProductName)
        Next
    End Sub

    Private Sub SaveSettings()
        Dim s As Settings = Settings.GetInstance

        s.LastDeviceIndex = lstMIDIOutDevice.SelectedIndex
        s.LastPatchFilePath = txtPatchFilePatch.Text

        If rdoMU100.Checked Then s.LastDevice = Enums.DeviceEnum.MU100
        If rdoMU80.Checked Then s.LastDevice = Enums.DeviceEnum.MU80
        If rdoSW1000.Checked Then s.LastDevice = Enums.DeviceEnum.SW1000
        If rdoSW60.Checked Then s.LastDevice = Enums.DeviceEnum.SW60

        s.Save()

    End Sub

    Private Sub LoadSettings()
        Dim s As Settings = Settings.GetInstance

        lstMIDIOutDevice.SelectedIndex = s.LastDeviceIndex
        txtPatchFilePatch.Text = s.LastPatchFilePath

        rdoMU100.Checked = s.LastDevice = Enums.DeviceEnum.MU100
        rdoMU80.Checked = s.LastDevice = Enums.DeviceEnum.MU80
        rdoSW1000.Checked = s.LastDevice = Enums.DeviceEnum.SW1000
        rdoSW60.Checked = s.LastDevice = Enums.DeviceEnum.SW60

    End Sub

End Class