<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstMIDIOutDevice = New System.Windows.Forms.ComboBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPatchFilePatch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdoMU100 = New System.Windows.Forms.RadioButton()
        Me.rdoMU80 = New System.Windows.Forms.RadioButton()
        Me.rdoSW1000 = New System.Windows.Forms.RadioButton()
        Me.rdoSW60 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MIDI Out Device"
        '
        'lstMIDIOutDevice
        '
        Me.lstMIDIOutDevice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstMIDIOutDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstMIDIOutDevice.FormattingEnabled = True
        Me.lstMIDIOutDevice.Location = New System.Drawing.Point(111, 6)
        Me.lstMIDIOutDevice.Name = "lstMIDIOutDevice"
        Me.lstMIDIOutDevice.Size = New System.Drawing.Size(255, 23)
        Me.lstMIDIOutDevice.TabIndex = 1
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Location = New System.Drawing.Point(210, 129)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 9
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.Location = New System.Drawing.Point(291, 129)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Patch File Path"
        '
        'txtPatchFilePatch
        '
        Me.txtPatchFilePatch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPatchFilePatch.Location = New System.Drawing.Point(111, 35)
        Me.txtPatchFilePatch.Name = "txtPatchFilePatch"
        Me.txtPatchFilePatch.Size = New System.Drawing.Size(255, 23)
        Me.txtPatchFilePatch.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Device"
        '
        'rdoMU100
        '
        Me.rdoMU100.AutoSize = True
        Me.rdoMU100.Checked = True
        Me.rdoMU100.Location = New System.Drawing.Point(111, 64)
        Me.rdoMU100.Name = "rdoMU100"
        Me.rdoMU100.Size = New System.Drawing.Size(62, 19)
        Me.rdoMU100.TabIndex = 5
        Me.rdoMU100.TabStop = True
        Me.rdoMU100.Text = "MU100"
        Me.rdoMU100.UseVisualStyleBackColor = True
        '
        'rdoMU80
        '
        Me.rdoMU80.AutoSize = True
        Me.rdoMU80.Location = New System.Drawing.Point(192, 64)
        Me.rdoMU80.Name = "rdoMU80"
        Me.rdoMU80.Size = New System.Drawing.Size(56, 19)
        Me.rdoMU80.TabIndex = 6
        Me.rdoMU80.Text = "MU80"
        Me.rdoMU80.UseVisualStyleBackColor = True
        '
        'rdoSW1000
        '
        Me.rdoSW1000.AutoSize = True
        Me.rdoSW1000.Location = New System.Drawing.Point(111, 89)
        Me.rdoSW1000.Name = "rdoSW1000"
        Me.rdoSW1000.Size = New System.Drawing.Size(66, 19)
        Me.rdoSW1000.TabIndex = 7
        Me.rdoSW1000.Text = "SW1000"
        Me.rdoSW1000.UseVisualStyleBackColor = True
        '
        'rdoSW60
        '
        Me.rdoSW60.AutoSize = True
        Me.rdoSW60.Location = New System.Drawing.Point(192, 89)
        Me.rdoSW60.Name = "rdoSW60"
        Me.rdoSW60.Size = New System.Drawing.Size(54, 19)
        Me.rdoSW60.TabIndex = 8
        Me.rdoSW60.Text = "SW60"
        Me.rdoSW60.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 164)
        Me.Controls.Add(Me.rdoSW60)
        Me.Controls.Add(Me.rdoSW1000)
        Me.Controls.Add(Me.rdoMU80)
        Me.Controls.Add(Me.rdoMU100)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPatchFilePatch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.lstMIDIOutDevice)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(988, 203)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(394, 203)
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstMIDIOutDevice As ComboBox
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPatchFilePatch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rdoMU100 As RadioButton
    Friend WithEvents rdoMU80 As RadioButton
    Friend WithEvents rdoSW1000 As RadioButton
    Friend WithEvents rdoSW60 As RadioButton
End Class
