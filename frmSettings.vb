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
        My.Settings.LastDeviceIndex = lstMIDIOutDevice.SelectedIndex
        My.Settings.LastPatchFilePath = txtPatchFilePatch.Text

        If rdoMU100.Checked Then My.Settings.LastDevice = Enums.DeviceEnum.MU100
        If rdoMU80.Checked Then My.Settings.LastDevice = Enums.DeviceEnum.MU80
        If rdoSW1000.Checked Then My.Settings.LastDevice = Enums.DeviceEnum.SW1000
        If rdoSW60.Checked Then My.Settings.LastDevice = Enums.DeviceEnum.SW60

        My.Settings.Save()

    End Sub

    Private Sub LoadSettings()
        lstMIDIOutDevice.SelectedIndex = My.Settings.LastDeviceIndex
        txtPatchFilePatch.Text = My.Settings.LastPatchFilePath

        Select Case My.Settings.LastDevice
            Case Enums.DeviceEnum.SW60
                rdoMU100.Checked = False
                rdoMU80.Checked = False
                rdoSW1000.Checked = False
                rdoSW60.Checked = True

            Case Enums.DeviceEnum.SW1000
                rdoMU100.Checked = False
                rdoMU80.Checked = False
                rdoSW1000.Checked = True
                rdoSW60.Checked = False

            Case Enums.DeviceEnum.MU80
                rdoMU100.Checked = False
                rdoMU80.Checked = True
                rdoSW1000.Checked = False
                rdoSW60.Checked = False

            Case Enums.DeviceEnum.MU100
                rdoMU100.Checked = True
                rdoMU80.Checked = False
                rdoSW1000.Checked = False
                rdoSW60.Checked = False

        End Select

    End Sub

End Class