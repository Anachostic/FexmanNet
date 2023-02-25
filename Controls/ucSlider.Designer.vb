<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSlider
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
        Me.components = New System.ComponentModel.Container()
        Me.lblParameterValue = New System.Windows.Forms.Label()
        Me.lblParameterName = New System.Windows.Forms.Label()
        Me.sldParameter = New System.Windows.Forms.TrackBar()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.sldParameter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblParameterValue
        '
        Me.lblParameterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblParameterValue.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblParameterValue.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblParameterValue.Location = New System.Drawing.Point(0, 142)
        Me.lblParameterValue.Name = "lblParameterValue"
        Me.lblParameterValue.Size = New System.Drawing.Size(48, 17)
        Me.lblParameterValue.TabIndex = 50
        '
        'lblParameterName
        '
        Me.lblParameterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblParameterName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblParameterName.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblParameterName.Location = New System.Drawing.Point(0, 0)
        Me.lblParameterName.Name = "lblParameterName"
        Me.lblParameterName.Size = New System.Drawing.Size(48, 17)
        Me.lblParameterName.TabIndex = 49
        Me.lblParameterName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'sldParameter
        '
        Me.sldParameter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sldParameter.AutoSize = False
        Me.sldParameter.Location = New System.Drawing.Point(3, 18)
        Me.sldParameter.Maximum = 127
        Me.sldParameter.Name = "sldParameter"
        Me.sldParameter.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.sldParameter.Size = New System.Drawing.Size(42, 121)
        Me.sldParameter.TabIndex = 48
        '
        'ucSlider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblParameterValue)
        Me.Controls.Add(Me.lblParameterName)
        Me.Controls.Add(Me.sldParameter)
        Me.Name = "ucSlider"
        Me.Size = New System.Drawing.Size(48, 159)
        CType(Me.sldParameter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblParameterValue As Label
    Friend WithEvents lblParameterName As Label
    Friend WithEvents sldParameter As TrackBar
    Friend WithEvents ToolTip1 As ToolTip
End Class
