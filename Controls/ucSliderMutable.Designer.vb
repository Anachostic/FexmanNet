<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSliderMutable
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.sldParameter = New System.Windows.Forms.TrackBar()
        Me.lblParameterName = New System.Windows.Forms.Label()
        Me.chkMute = New System.Windows.Forms.CheckBox()
        CType(Me.sldParameter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sldParameter
        '
        Me.sldParameter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sldParameter.AutoSize = False
        Me.sldParameter.Location = New System.Drawing.Point(3, 42)
        Me.sldParameter.Maximum = 127
        Me.sldParameter.Name = "sldParameter"
        Me.sldParameter.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.sldParameter.Size = New System.Drawing.Size(35, 100)
        Me.sldParameter.TabIndex = 6
        '
        'lblParameterName
        '
        Me.lblParameterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblParameterName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblParameterName.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblParameterName.Location = New System.Drawing.Point(0, 0)
        Me.lblParameterName.Name = "lblParameterName"
        Me.lblParameterName.Size = New System.Drawing.Size(41, 17)
        Me.lblParameterName.TabIndex = 4
        Me.lblParameterName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chkMute
        '
        Me.chkMute.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkMute.AutoSize = True
        Me.chkMute.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkMute.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chkMute.Location = New System.Drawing.Point(0, 17)
        Me.chkMute.Name = "chkMute"
        Me.chkMute.Size = New System.Drawing.Size(41, 22)
        Me.chkMute.TabIndex = 7
        Me.chkMute.Text = "Mute"
        Me.chkMute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkMute.UseVisualStyleBackColor = True
        '
        'ucSliderMutable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkMute)
        Me.Controls.Add(Me.sldParameter)
        Me.Controls.Add(Me.lblParameterName)
        Me.Name = "ucSliderMutable"
        Me.Size = New System.Drawing.Size(41, 142)
        CType(Me.sldParameter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sldParameter As TrackBar
    Friend WithEvents lblParameterName As Label
    Friend WithEvents chkMute As CheckBox
End Class
