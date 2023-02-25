<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditEffect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabReverb = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rvbParm16 = New FexmanNet.ucSlider()
        Me.rvbParm15 = New FexmanNet.ucSlider()
        Me.rvbParm14 = New FexmanNet.ucSlider()
        Me.rvbParm13 = New FexmanNet.ucSlider()
        Me.rvbParm12 = New FexmanNet.ucSlider()
        Me.rvbParm11 = New FexmanNet.ucSlider()
        Me.rvbParm10 = New FexmanNet.ucSlider()
        Me.rvbParm9 = New FexmanNet.ucSlider()
        Me.rvbParm8 = New FexmanNet.ucSlider()
        Me.rvbParm7 = New FexmanNet.ucSlider()
        Me.rvbParm6 = New FexmanNet.ucSlider()
        Me.rvbParm5 = New FexmanNet.ucSlider()
        Me.rvbParm4 = New FexmanNet.ucSlider()
        Me.rvbParm3 = New FexmanNet.ucSlider()
        Me.rvbParm2 = New FexmanNet.ucSlider()
        Me.rvbParm1 = New FexmanNet.ucSlider()
        Me.lstReverb = New System.Windows.Forms.ListBox()
        Me.tabChorus = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.choParm16 = New FexmanNet.ucSlider()
        Me.choParm15 = New FexmanNet.ucSlider()
        Me.choParm14 = New FexmanNet.ucSlider()
        Me.choParm13 = New FexmanNet.ucSlider()
        Me.choParm12 = New FexmanNet.ucSlider()
        Me.choParm11 = New FexmanNet.ucSlider()
        Me.choParm10 = New FexmanNet.ucSlider()
        Me.choParm9 = New FexmanNet.ucSlider()
        Me.choParm8 = New FexmanNet.ucSlider()
        Me.choParm7 = New FexmanNet.ucSlider()
        Me.choParm6 = New FexmanNet.ucSlider()
        Me.choParm5 = New FexmanNet.ucSlider()
        Me.choParm4 = New FexmanNet.ucSlider()
        Me.choParm3 = New FexmanNet.ucSlider()
        Me.choParm2 = New FexmanNet.ucSlider()
        Me.choParm1 = New FexmanNet.ucSlider()
        Me.lstChorus = New System.Windows.Forms.ListBox()
        Me.tabVariation = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.varParm16 = New FexmanNet.ucSlider()
        Me.varParm15 = New FexmanNet.ucSlider()
        Me.varParm14 = New FexmanNet.ucSlider()
        Me.varParm13 = New FexmanNet.ucSlider()
        Me.varParm12 = New FexmanNet.ucSlider()
        Me.varParm11 = New FexmanNet.ucSlider()
        Me.varParm10 = New FexmanNet.ucSlider()
        Me.varParm9 = New FexmanNet.ucSlider()
        Me.varParm8 = New FexmanNet.ucSlider()
        Me.varParm7 = New FexmanNet.ucSlider()
        Me.varParm6 = New FexmanNet.ucSlider()
        Me.varParm5 = New FexmanNet.ucSlider()
        Me.varParm4 = New FexmanNet.ucSlider()
        Me.varParm3 = New FexmanNet.ucSlider()
        Me.varParm2 = New FexmanNet.ucSlider()
        Me.varParm1 = New FexmanNet.ucSlider()
        Me.lstVariation = New System.Windows.Forms.ListBox()
        Me.tabLevels = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lvlToCho = New FexmanNet.ucSliderMutable()
        Me.lvlToRev = New FexmanNet.ucSliderMutable()
        Me.lvlChoToRev = New FexmanNet.ucSliderMutable()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lvlDry = New FexmanNet.ucSliderMutable()
        Me.lvlVariation = New FexmanNet.ucSliderMutable()
        Me.lvlChorus = New FexmanNet.ucSliderMutable()
        Me.lvlReverb = New FexmanNet.ucSliderMutable()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lvlOut = New FexmanNet.ucSliderMutable()
        Me.lvlMIDI = New FexmanNet.ucSliderMutable()
        Me.lvlMicIn = New FexmanNet.ucSliderMutable()
        Me.lvlLineIn = New FexmanNet.ucSliderMutable()
        Me.lvlVarToRev = New FexmanNet.ucSliderMutable()
        Me.lvlVarToCho = New FexmanNet.ucSliderMutable()
        Me.TabControl1.SuspendLayout()
        Me.tabReverb.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabChorus.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tabVariation.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tabLevels.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabReverb)
        Me.TabControl1.Controls.Add(Me.tabChorus)
        Me.TabControl1.Controls.Add(Me.tabVariation)
        Me.TabControl1.Controls.Add(Me.tabLevels)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1030, 224)
        Me.TabControl1.TabIndex = 1
        '
        'tabReverb
        '
        Me.tabReverb.Controls.Add(Me.GroupBox1)
        Me.tabReverb.Location = New System.Drawing.Point(4, 24)
        Me.tabReverb.Name = "tabReverb"
        Me.tabReverb.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReverb.Size = New System.Drawing.Size(1022, 196)
        Me.tabReverb.TabIndex = 0
        Me.tabReverb.Text = "Reverb"
        Me.tabReverb.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rvbParm16)
        Me.GroupBox1.Controls.Add(Me.rvbParm15)
        Me.GroupBox1.Controls.Add(Me.rvbParm14)
        Me.GroupBox1.Controls.Add(Me.rvbParm13)
        Me.GroupBox1.Controls.Add(Me.rvbParm12)
        Me.GroupBox1.Controls.Add(Me.rvbParm11)
        Me.GroupBox1.Controls.Add(Me.rvbParm10)
        Me.GroupBox1.Controls.Add(Me.rvbParm9)
        Me.GroupBox1.Controls.Add(Me.rvbParm8)
        Me.GroupBox1.Controls.Add(Me.rvbParm7)
        Me.GroupBox1.Controls.Add(Me.rvbParm6)
        Me.GroupBox1.Controls.Add(Me.rvbParm5)
        Me.GroupBox1.Controls.Add(Me.rvbParm4)
        Me.GroupBox1.Controls.Add(Me.rvbParm3)
        Me.GroupBox1.Controls.Add(Me.rvbParm2)
        Me.GroupBox1.Controls.Add(Me.rvbParm1)
        Me.GroupBox1.Controls.Add(Me.lstReverb)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1003, 184)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reverb Settings"
        '
        'rvbParm16
        '
        Me.rvbParm16.Label = ""
        Me.rvbParm16.Location = New System.Drawing.Point(942, 17)
        Me.rvbParm16.Name = "rvbParm16"
        Me.rvbParm16.Parameter = Nothing
        Me.rvbParm16.Size = New System.Drawing.Size(48, 159)
        Me.rvbParm16.TabIndex = 15
        Me.rvbParm16.Value = 0
        Me.rvbParm16.ValueChangedDelegate = Nothing
        '
        'rvbParm15
        '
        Me.rvbParm15.Label = ""
        Me.rvbParm15.Location = New System.Drawing.Point(888, 17)
        Me.rvbParm15.Name = "rvbParm15"
        Me.rvbParm15.Parameter = Nothing
        Me.rvbParm15.Size = New System.Drawing.Size(48, 159)
        Me.rvbParm15.TabIndex = 14
        Me.rvbParm15.Value = 0
        Me.rvbParm15.ValueChangedDelegate = Nothing
        '
        'rvbParm14
        '
        Me.rvbParm14.Label = ""
        Me.rvbParm14.Location = New System.Drawing.Point(834, 17)
        Me.rvbParm14.Name = "rvbParm14"
        Me.rvbParm14.Parameter = Nothing
        Me.rvbParm14.Size = New System.Drawing.Size(48, 159)
        Me.rvbParm14.TabIndex = 13
        Me.rvbParm14.Value = 0
        Me.rvbParm14.ValueChangedDelegate = Nothing
        '
        'rvbParm13
        '
        Me.rvbParm13.Label = ""
        Me.rvbParm13.Location = New System.Drawing.Point(780, 17)
        Me.rvbParm13.Name = "rvbParm13"
        Me.rvbParm13.Parameter = Nothing
        Me.rvbParm13.Size = New System.Drawing.Size(48, 159)
        Me.rvbParm13.TabIndex = 12
        Me.rvbParm13.Value = 0
        Me.rvbParm13.ValueChangedDelegate = Nothing
        '
        'rvbParm12
        '
        Me.rvbParm12.Label = ""
        Me.rvbParm12.Location = New System.Drawing.Point(726, 17)
        Me.rvbParm12.Name = "rvbParm12"
        Me.rvbParm12.Parameter = Nothing
        Me.rvbParm12.Size = New System.Drawing.Size(48, 159)
        Me.rvbParm12.TabIndex = 11
        Me.rvbParm12.Value = 0
        Me.rvbParm12.ValueChangedDelegate = Nothing
        '
        'rvbParm11
        '
        Me.rvbParm11.Label = ""
        Me.rvbParm11.Location = New System.Drawing.Point(672, 17)
        Me.rvbParm11.Name = "rvbParm11"
        Me.rvbParm11.Parameter = Nothing
        Me.rvbParm11.Size = New System.Drawing.Size(48, 159)
        Me.rvbParm11.TabIndex = 10
        Me.rvbParm11.Value = 0
        Me.rvbParm11.ValueChangedDelegate = Nothing
        '
        'rvbParm10
        '
        Me.rvbParm10.Label = ""
        Me.rvbParm10.Location = New System.Drawing.Point(618, 17)
        Me.rvbParm10.Name = "rvbParm10"
        Me.rvbParm10.Parameter = Nothing
        Me.rvbParm10.Size = New System.Drawing.Size(48, 159)
        Me.rvbParm10.TabIndex = 9
        Me.rvbParm10.Value = 0
        Me.rvbParm10.ValueChangedDelegate = Nothing
        '
        'rvbParm9
        '
        Me.rvbParm9.Label = ""
        Me.rvbParm9.Location = New System.Drawing.Point(564, 17)
        Me.rvbParm9.Name = "rvbParm9"
        Me.rvbParm9.Parameter = Nothing
        Me.rvbParm9.Size = New System.Drawing.Size(48, 159)
        Me.rvbParm9.TabIndex = 8
        Me.rvbParm9.Value = 0
        Me.rvbParm9.ValueChangedDelegate = Nothing
        '
        'rvbParm8
        '
        Me.rvbParm8.Label = ""
        Me.rvbParm8.Location = New System.Drawing.Point(510, 17)
        Me.rvbParm8.Name = "rvbParm8"
        Me.rvbParm8.Parameter = Nothing
        Me.rvbParm8.Size = New System.Drawing.Size(48, 159)
        Me.rvbParm8.TabIndex = 7
        Me.rvbParm8.Value = 0
        Me.rvbParm8.ValueChangedDelegate = Nothing
        '
        'rvbParm7
        '
        Me.rvbParm7.Label = ""
        Me.rvbParm7.Location = New System.Drawing.Point(456, 17)
        Me.rvbParm7.Name = "rvbParm7"
        Me.rvbParm7.Parameter = Nothing
        Me.rvbParm7.Size = New System.Drawing.Size(48, 159)
        Me.rvbParm7.TabIndex = 6
        Me.rvbParm7.Value = 0
        Me.rvbParm7.ValueChangedDelegate = Nothing
        '
        'rvbParm6
        '
        Me.rvbParm6.Label = ""
        Me.rvbParm6.Location = New System.Drawing.Point(402, 17)
        Me.rvbParm6.Name = "rvbParm6"
        Me.rvbParm6.Parameter = Nothing
        Me.rvbParm6.Size = New System.Drawing.Size(48, 159)
        Me.rvbParm6.TabIndex = 5
        Me.rvbParm6.Value = 0
        Me.rvbParm6.ValueChangedDelegate = Nothing
        '
        'rvbParm5
        '
        Me.rvbParm5.Label = ""
        Me.rvbParm5.Location = New System.Drawing.Point(348, 17)
        Me.rvbParm5.Name = "rvbParm5"
        Me.rvbParm5.Parameter = Nothing
        Me.rvbParm5.Size = New System.Drawing.Size(48, 159)
        Me.rvbParm5.TabIndex = 5
        Me.rvbParm5.Value = 0
        Me.rvbParm5.ValueChangedDelegate = Nothing
        '
        'rvbParm4
        '
        Me.rvbParm4.Label = ""
        Me.rvbParm4.Location = New System.Drawing.Point(294, 17)
        Me.rvbParm4.Name = "rvbParm4"
        Me.rvbParm4.Parameter = Nothing
        Me.rvbParm4.Size = New System.Drawing.Size(48, 159)
        Me.rvbParm4.TabIndex = 3
        Me.rvbParm4.Value = 0
        Me.rvbParm4.ValueChangedDelegate = Nothing
        '
        'rvbParm3
        '
        Me.rvbParm3.Label = ""
        Me.rvbParm3.Location = New System.Drawing.Point(240, 17)
        Me.rvbParm3.Name = "rvbParm3"
        Me.rvbParm3.Parameter = Nothing
        Me.rvbParm3.Size = New System.Drawing.Size(48, 159)
        Me.rvbParm3.TabIndex = 3
        Me.rvbParm3.Value = 0
        Me.rvbParm3.ValueChangedDelegate = Nothing
        '
        'rvbParm2
        '
        Me.rvbParm2.Label = ""
        Me.rvbParm2.Location = New System.Drawing.Point(186, 17)
        Me.rvbParm2.Name = "rvbParm2"
        Me.rvbParm2.Parameter = Nothing
        Me.rvbParm2.Size = New System.Drawing.Size(48, 159)
        Me.rvbParm2.TabIndex = 1
        Me.rvbParm2.Value = 0
        Me.rvbParm2.ValueChangedDelegate = Nothing
        '
        'rvbParm1
        '
        Me.rvbParm1.Label = ""
        Me.rvbParm1.Location = New System.Drawing.Point(132, 17)
        Me.rvbParm1.Name = "rvbParm1"
        Me.rvbParm1.Parameter = Nothing
        Me.rvbParm1.Size = New System.Drawing.Size(48, 159)
        Me.rvbParm1.TabIndex = 0
        Me.rvbParm1.Value = 0
        Me.rvbParm1.ValueChangedDelegate = Nothing
        '
        'lstReverb
        '
        Me.lstReverb.DisplayMember = "Name"
        Me.lstReverb.FormattingEnabled = True
        Me.lstReverb.ItemHeight = 15
        Me.lstReverb.Location = New System.Drawing.Point(6, 22)
        Me.lstReverb.Name = "lstReverb"
        Me.lstReverb.Size = New System.Drawing.Size(120, 154)
        Me.lstReverb.TabIndex = 0
        '
        'tabChorus
        '
        Me.tabChorus.Controls.Add(Me.GroupBox2)
        Me.tabChorus.Location = New System.Drawing.Point(4, 24)
        Me.tabChorus.Name = "tabChorus"
        Me.tabChorus.Padding = New System.Windows.Forms.Padding(3)
        Me.tabChorus.Size = New System.Drawing.Size(1022, 196)
        Me.tabChorus.TabIndex = 1
        Me.tabChorus.Text = "Chorus"
        Me.tabChorus.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.choParm16)
        Me.GroupBox2.Controls.Add(Me.choParm15)
        Me.GroupBox2.Controls.Add(Me.choParm14)
        Me.GroupBox2.Controls.Add(Me.choParm13)
        Me.GroupBox2.Controls.Add(Me.choParm12)
        Me.GroupBox2.Controls.Add(Me.choParm11)
        Me.GroupBox2.Controls.Add(Me.choParm10)
        Me.GroupBox2.Controls.Add(Me.choParm9)
        Me.GroupBox2.Controls.Add(Me.choParm8)
        Me.GroupBox2.Controls.Add(Me.choParm7)
        Me.GroupBox2.Controls.Add(Me.choParm6)
        Me.GroupBox2.Controls.Add(Me.choParm5)
        Me.GroupBox2.Controls.Add(Me.choParm4)
        Me.GroupBox2.Controls.Add(Me.choParm3)
        Me.GroupBox2.Controls.Add(Me.choParm2)
        Me.GroupBox2.Controls.Add(Me.choParm1)
        Me.GroupBox2.Controls.Add(Me.lstChorus)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1003, 184)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chorus Settings"
        '
        'choParm16
        '
        Me.choParm16.Label = ""
        Me.choParm16.Location = New System.Drawing.Point(942, 17)
        Me.choParm16.Name = "choParm16"
        Me.choParm16.Parameter = Nothing
        Me.choParm16.Size = New System.Drawing.Size(48, 159)
        Me.choParm16.TabIndex = 15
        Me.choParm16.Value = 0
        Me.choParm16.ValueChangedDelegate = Nothing
        '
        'choParm15
        '
        Me.choParm15.Label = ""
        Me.choParm15.Location = New System.Drawing.Point(888, 17)
        Me.choParm15.Name = "choParm15"
        Me.choParm15.Parameter = Nothing
        Me.choParm15.Size = New System.Drawing.Size(48, 159)
        Me.choParm15.TabIndex = 14
        Me.choParm15.Value = 0
        Me.choParm15.ValueChangedDelegate = Nothing
        '
        'choParm14
        '
        Me.choParm14.Label = ""
        Me.choParm14.Location = New System.Drawing.Point(834, 17)
        Me.choParm14.Name = "choParm14"
        Me.choParm14.Parameter = Nothing
        Me.choParm14.Size = New System.Drawing.Size(48, 159)
        Me.choParm14.TabIndex = 13
        Me.choParm14.Value = 0
        Me.choParm14.ValueChangedDelegate = Nothing
        '
        'choParm13
        '
        Me.choParm13.Label = ""
        Me.choParm13.Location = New System.Drawing.Point(780, 17)
        Me.choParm13.Name = "choParm13"
        Me.choParm13.Parameter = Nothing
        Me.choParm13.Size = New System.Drawing.Size(48, 159)
        Me.choParm13.TabIndex = 12
        Me.choParm13.Value = 0
        Me.choParm13.ValueChangedDelegate = Nothing
        '
        'choParm12
        '
        Me.choParm12.Label = ""
        Me.choParm12.Location = New System.Drawing.Point(726, 17)
        Me.choParm12.Name = "choParm12"
        Me.choParm12.Parameter = Nothing
        Me.choParm12.Size = New System.Drawing.Size(48, 159)
        Me.choParm12.TabIndex = 11
        Me.choParm12.Value = 0
        Me.choParm12.ValueChangedDelegate = Nothing
        '
        'choParm11
        '
        Me.choParm11.Label = ""
        Me.choParm11.Location = New System.Drawing.Point(672, 17)
        Me.choParm11.Name = "choParm11"
        Me.choParm11.Parameter = Nothing
        Me.choParm11.Size = New System.Drawing.Size(48, 159)
        Me.choParm11.TabIndex = 10
        Me.choParm11.Value = 0
        Me.choParm11.ValueChangedDelegate = Nothing
        '
        'choParm10
        '
        Me.choParm10.Label = ""
        Me.choParm10.Location = New System.Drawing.Point(618, 17)
        Me.choParm10.Name = "choParm10"
        Me.choParm10.Parameter = Nothing
        Me.choParm10.Size = New System.Drawing.Size(48, 159)
        Me.choParm10.TabIndex = 9
        Me.choParm10.Value = 0
        Me.choParm10.ValueChangedDelegate = Nothing
        '
        'choParm9
        '
        Me.choParm9.Label = ""
        Me.choParm9.Location = New System.Drawing.Point(564, 17)
        Me.choParm9.Name = "choParm9"
        Me.choParm9.Parameter = Nothing
        Me.choParm9.Size = New System.Drawing.Size(48, 159)
        Me.choParm9.TabIndex = 8
        Me.choParm9.Value = 0
        Me.choParm9.ValueChangedDelegate = Nothing
        '
        'choParm8
        '
        Me.choParm8.Label = ""
        Me.choParm8.Location = New System.Drawing.Point(510, 17)
        Me.choParm8.Name = "choParm8"
        Me.choParm8.Parameter = Nothing
        Me.choParm8.Size = New System.Drawing.Size(48, 159)
        Me.choParm8.TabIndex = 7
        Me.choParm8.Value = 0
        Me.choParm8.ValueChangedDelegate = Nothing
        '
        'choParm7
        '
        Me.choParm7.Label = ""
        Me.choParm7.Location = New System.Drawing.Point(456, 17)
        Me.choParm7.Name = "choParm7"
        Me.choParm7.Parameter = Nothing
        Me.choParm7.Size = New System.Drawing.Size(48, 159)
        Me.choParm7.TabIndex = 6
        Me.choParm7.Value = 0
        Me.choParm7.ValueChangedDelegate = Nothing
        '
        'choParm6
        '
        Me.choParm6.Label = ""
        Me.choParm6.Location = New System.Drawing.Point(402, 17)
        Me.choParm6.Name = "choParm6"
        Me.choParm6.Parameter = Nothing
        Me.choParm6.Size = New System.Drawing.Size(48, 159)
        Me.choParm6.TabIndex = 5
        Me.choParm6.Value = 0
        Me.choParm6.ValueChangedDelegate = Nothing
        '
        'choParm5
        '
        Me.choParm5.Label = ""
        Me.choParm5.Location = New System.Drawing.Point(348, 17)
        Me.choParm5.Name = "choParm5"
        Me.choParm5.Parameter = Nothing
        Me.choParm5.Size = New System.Drawing.Size(48, 159)
        Me.choParm5.TabIndex = 4
        Me.choParm5.Value = 0
        Me.choParm5.ValueChangedDelegate = Nothing
        '
        'choParm4
        '
        Me.choParm4.Label = ""
        Me.choParm4.Location = New System.Drawing.Point(294, 17)
        Me.choParm4.Name = "choParm4"
        Me.choParm4.Parameter = Nothing
        Me.choParm4.Size = New System.Drawing.Size(48, 159)
        Me.choParm4.TabIndex = 3
        Me.choParm4.Value = 0
        Me.choParm4.ValueChangedDelegate = Nothing
        '
        'choParm3
        '
        Me.choParm3.Label = ""
        Me.choParm3.Location = New System.Drawing.Point(240, 17)
        Me.choParm3.Name = "choParm3"
        Me.choParm3.Parameter = Nothing
        Me.choParm3.Size = New System.Drawing.Size(48, 159)
        Me.choParm3.TabIndex = 2
        Me.choParm3.Value = 0
        Me.choParm3.ValueChangedDelegate = Nothing
        '
        'choParm2
        '
        Me.choParm2.Label = ""
        Me.choParm2.Location = New System.Drawing.Point(186, 17)
        Me.choParm2.Name = "choParm2"
        Me.choParm2.Parameter = Nothing
        Me.choParm2.Size = New System.Drawing.Size(48, 159)
        Me.choParm2.TabIndex = 1
        Me.choParm2.Value = 0
        Me.choParm2.ValueChangedDelegate = Nothing
        '
        'choParm1
        '
        Me.choParm1.Label = ""
        Me.choParm1.Location = New System.Drawing.Point(132, 17)
        Me.choParm1.Name = "choParm1"
        Me.choParm1.Parameter = Nothing
        Me.choParm1.Size = New System.Drawing.Size(48, 159)
        Me.choParm1.TabIndex = 0
        Me.choParm1.Value = 0
        Me.choParm1.ValueChangedDelegate = Nothing
        '
        'lstChorus
        '
        Me.lstChorus.DisplayMember = "Name"
        Me.lstChorus.FormattingEnabled = True
        Me.lstChorus.ItemHeight = 15
        Me.lstChorus.Location = New System.Drawing.Point(6, 22)
        Me.lstChorus.Name = "lstChorus"
        Me.lstChorus.Size = New System.Drawing.Size(120, 154)
        Me.lstChorus.TabIndex = 0
        '
        'tabVariation
        '
        Me.tabVariation.Controls.Add(Me.GroupBox3)
        Me.tabVariation.Location = New System.Drawing.Point(4, 24)
        Me.tabVariation.Name = "tabVariation"
        Me.tabVariation.Size = New System.Drawing.Size(1022, 196)
        Me.tabVariation.TabIndex = 2
        Me.tabVariation.Text = "Variation"
        Me.tabVariation.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.varParm16)
        Me.GroupBox3.Controls.Add(Me.varParm15)
        Me.GroupBox3.Controls.Add(Me.varParm14)
        Me.GroupBox3.Controls.Add(Me.varParm13)
        Me.GroupBox3.Controls.Add(Me.varParm12)
        Me.GroupBox3.Controls.Add(Me.varParm11)
        Me.GroupBox3.Controls.Add(Me.varParm10)
        Me.GroupBox3.Controls.Add(Me.varParm9)
        Me.GroupBox3.Controls.Add(Me.varParm8)
        Me.GroupBox3.Controls.Add(Me.varParm7)
        Me.GroupBox3.Controls.Add(Me.varParm6)
        Me.GroupBox3.Controls.Add(Me.varParm5)
        Me.GroupBox3.Controls.Add(Me.varParm4)
        Me.GroupBox3.Controls.Add(Me.varParm3)
        Me.GroupBox3.Controls.Add(Me.varParm2)
        Me.GroupBox3.Controls.Add(Me.varParm1)
        Me.GroupBox3.Controls.Add(Me.lstVariation)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1003, 184)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Variation Settings"
        '
        'varParm16
        '
        Me.varParm16.Label = ""
        Me.varParm16.Location = New System.Drawing.Point(942, 17)
        Me.varParm16.Name = "varParm16"
        Me.varParm16.Parameter = Nothing
        Me.varParm16.Size = New System.Drawing.Size(48, 159)
        Me.varParm16.TabIndex = 15
        Me.varParm16.Value = 0
        Me.varParm16.ValueChangedDelegate = Nothing
        '
        'varParm15
        '
        Me.varParm15.Label = ""
        Me.varParm15.Location = New System.Drawing.Point(888, 17)
        Me.varParm15.Name = "varParm15"
        Me.varParm15.Parameter = Nothing
        Me.varParm15.Size = New System.Drawing.Size(48, 159)
        Me.varParm15.TabIndex = 14
        Me.varParm15.Value = 0
        Me.varParm15.ValueChangedDelegate = Nothing
        '
        'varParm14
        '
        Me.varParm14.Label = ""
        Me.varParm14.Location = New System.Drawing.Point(834, 17)
        Me.varParm14.Name = "varParm14"
        Me.varParm14.Parameter = Nothing
        Me.varParm14.Size = New System.Drawing.Size(48, 159)
        Me.varParm14.TabIndex = 13
        Me.varParm14.Value = 0
        Me.varParm14.ValueChangedDelegate = Nothing
        '
        'varParm13
        '
        Me.varParm13.Label = ""
        Me.varParm13.Location = New System.Drawing.Point(780, 17)
        Me.varParm13.Name = "varParm13"
        Me.varParm13.Parameter = Nothing
        Me.varParm13.Size = New System.Drawing.Size(48, 159)
        Me.varParm13.TabIndex = 12
        Me.varParm13.Value = 0
        Me.varParm13.ValueChangedDelegate = Nothing
        '
        'varParm12
        '
        Me.varParm12.Label = ""
        Me.varParm12.Location = New System.Drawing.Point(726, 17)
        Me.varParm12.Name = "varParm12"
        Me.varParm12.Parameter = Nothing
        Me.varParm12.Size = New System.Drawing.Size(48, 159)
        Me.varParm12.TabIndex = 11
        Me.varParm12.Value = 0
        Me.varParm12.ValueChangedDelegate = Nothing
        '
        'varParm11
        '
        Me.varParm11.Label = ""
        Me.varParm11.Location = New System.Drawing.Point(672, 17)
        Me.varParm11.Name = "varParm11"
        Me.varParm11.Parameter = Nothing
        Me.varParm11.Size = New System.Drawing.Size(48, 159)
        Me.varParm11.TabIndex = 10
        Me.varParm11.Value = 0
        Me.varParm11.ValueChangedDelegate = Nothing
        '
        'varParm10
        '
        Me.varParm10.Label = ""
        Me.varParm10.Location = New System.Drawing.Point(618, 17)
        Me.varParm10.Name = "varParm10"
        Me.varParm10.Parameter = Nothing
        Me.varParm10.Size = New System.Drawing.Size(48, 159)
        Me.varParm10.TabIndex = 9
        Me.varParm10.Value = 0
        Me.varParm10.ValueChangedDelegate = Nothing
        '
        'varParm9
        '
        Me.varParm9.Label = ""
        Me.varParm9.Location = New System.Drawing.Point(564, 17)
        Me.varParm9.Name = "varParm9"
        Me.varParm9.Parameter = Nothing
        Me.varParm9.Size = New System.Drawing.Size(48, 159)
        Me.varParm9.TabIndex = 8
        Me.varParm9.Value = 0
        Me.varParm9.ValueChangedDelegate = Nothing
        '
        'varParm8
        '
        Me.varParm8.Label = ""
        Me.varParm8.Location = New System.Drawing.Point(510, 17)
        Me.varParm8.Name = "varParm8"
        Me.varParm8.Parameter = Nothing
        Me.varParm8.Size = New System.Drawing.Size(48, 159)
        Me.varParm8.TabIndex = 7
        Me.varParm8.Value = 0
        Me.varParm8.ValueChangedDelegate = Nothing
        '
        'varParm7
        '
        Me.varParm7.Label = ""
        Me.varParm7.Location = New System.Drawing.Point(456, 17)
        Me.varParm7.Name = "varParm7"
        Me.varParm7.Parameter = Nothing
        Me.varParm7.Size = New System.Drawing.Size(48, 159)
        Me.varParm7.TabIndex = 6
        Me.varParm7.Value = 0
        Me.varParm7.ValueChangedDelegate = Nothing
        '
        'varParm6
        '
        Me.varParm6.Label = ""
        Me.varParm6.Location = New System.Drawing.Point(402, 17)
        Me.varParm6.Name = "varParm6"
        Me.varParm6.Parameter = Nothing
        Me.varParm6.Size = New System.Drawing.Size(48, 159)
        Me.varParm6.TabIndex = 5
        Me.varParm6.Value = 0
        Me.varParm6.ValueChangedDelegate = Nothing
        '
        'varParm5
        '
        Me.varParm5.Label = ""
        Me.varParm5.Location = New System.Drawing.Point(348, 17)
        Me.varParm5.Name = "varParm5"
        Me.varParm5.Parameter = Nothing
        Me.varParm5.Size = New System.Drawing.Size(48, 159)
        Me.varParm5.TabIndex = 4
        Me.varParm5.Value = 0
        Me.varParm5.ValueChangedDelegate = Nothing
        '
        'varParm4
        '
        Me.varParm4.Label = ""
        Me.varParm4.Location = New System.Drawing.Point(294, 17)
        Me.varParm4.Name = "varParm4"
        Me.varParm4.Parameter = Nothing
        Me.varParm4.Size = New System.Drawing.Size(48, 159)
        Me.varParm4.TabIndex = 3
        Me.varParm4.Value = 0
        Me.varParm4.ValueChangedDelegate = Nothing
        '
        'varParm3
        '
        Me.varParm3.Label = ""
        Me.varParm3.Location = New System.Drawing.Point(240, 17)
        Me.varParm3.Name = "varParm3"
        Me.varParm3.Parameter = Nothing
        Me.varParm3.Size = New System.Drawing.Size(48, 159)
        Me.varParm3.TabIndex = 2
        Me.varParm3.Value = 0
        Me.varParm3.ValueChangedDelegate = Nothing
        '
        'varParm2
        '
        Me.varParm2.Label = ""
        Me.varParm2.Location = New System.Drawing.Point(186, 17)
        Me.varParm2.Name = "varParm2"
        Me.varParm2.Parameter = Nothing
        Me.varParm2.Size = New System.Drawing.Size(48, 159)
        Me.varParm2.TabIndex = 1
        Me.varParm2.Value = 0
        Me.varParm2.ValueChangedDelegate = Nothing
        '
        'varParm1
        '
        Me.varParm1.Label = ""
        Me.varParm1.Location = New System.Drawing.Point(132, 17)
        Me.varParm1.Name = "varParm1"
        Me.varParm1.Parameter = Nothing
        Me.varParm1.Size = New System.Drawing.Size(48, 159)
        Me.varParm1.TabIndex = 0
        Me.varParm1.Value = 0
        Me.varParm1.ValueChangedDelegate = Nothing
        '
        'lstVariation
        '
        Me.lstVariation.DisplayMember = "Name"
        Me.lstVariation.FormattingEnabled = True
        Me.lstVariation.ItemHeight = 15
        Me.lstVariation.Location = New System.Drawing.Point(6, 22)
        Me.lstVariation.Name = "lstVariation"
        Me.lstVariation.Size = New System.Drawing.Size(120, 154)
        Me.lstVariation.TabIndex = 0
        '
        'tabLevels
        '
        Me.tabLevels.Controls.Add(Me.GroupBox4)
        Me.tabLevels.Location = New System.Drawing.Point(4, 24)
        Me.tabLevels.Name = "tabLevels"
        Me.tabLevels.Size = New System.Drawing.Size(1022, 196)
        Me.tabLevels.TabIndex = 3
        Me.tabLevels.Text = "Levels"
        Me.tabLevels.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1003, 184)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Level Settings"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lvlVarToCho)
        Me.GroupBox7.Controls.Add(Me.lvlVarToRev)
        Me.GroupBox7.Controls.Add(Me.lvlToCho)
        Me.GroupBox7.Controls.Add(Me.lvlToRev)
        Me.GroupBox7.Controls.Add(Me.lvlChoToRev)
        Me.GroupBox7.Location = New System.Drawing.Point(244, 22)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(273, 159)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Sends"
        '
        'lvlToCho
        '
        Me.lvlToCho.Label = "To Chorus"
        Me.lvlToCho.Location = New System.Drawing.Point(53, 17)
        Me.lvlToCho.Mutable = False
        Me.lvlToCho.MuteChangedDelegate = Nothing
        Me.lvlToCho.Muted = False
        Me.lvlToCho.Name = "lvlToCho"
        Me.lvlToCho.Size = New System.Drawing.Size(41, 142)
        Me.lvlToCho.TabIndex = 1
        Me.lvlToCho.Value = CType(127, Byte)
        Me.lvlToCho.VolumeChangedDelegate = Nothing
        '
        'lvlToRev
        '
        Me.lvlToRev.Label = "To Reverb"
        Me.lvlToRev.Location = New System.Drawing.Point(6, 17)
        Me.lvlToRev.Mutable = False
        Me.lvlToRev.MuteChangedDelegate = Nothing
        Me.lvlToRev.Muted = False
        Me.lvlToRev.Name = "lvlToRev"
        Me.lvlToRev.Size = New System.Drawing.Size(41, 142)
        Me.lvlToRev.TabIndex = 0
        Me.lvlToRev.Value = CType(127, Byte)
        Me.lvlToRev.VolumeChangedDelegate = Nothing
        '
        'lvlChoToRev
        '
        Me.lvlChoToRev.Label = "Chorus to Rev"
        Me.lvlChoToRev.Location = New System.Drawing.Point(120, 17)
        Me.lvlChoToRev.Mutable = False
        Me.lvlChoToRev.MuteChangedDelegate = Nothing
        Me.lvlChoToRev.Muted = False
        Me.lvlChoToRev.Name = "lvlChoToRev"
        Me.lvlChoToRev.Size = New System.Drawing.Size(41, 142)
        Me.lvlChoToRev.TabIndex = 2
        Me.lvlChoToRev.Value = CType(127, Byte)
        Me.lvlChoToRev.VolumeChangedDelegate = Nothing
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lvlDry)
        Me.GroupBox6.Controls.Add(Me.lvlVariation)
        Me.GroupBox6.Controls.Add(Me.lvlChorus)
        Me.GroupBox6.Controls.Add(Me.lvlReverb)
        Me.GroupBox6.Location = New System.Drawing.Point(542, 22)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(198, 159)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Returns"
        '
        'lvlDry
        '
        Me.lvlDry.Label = "Dry"
        Me.lvlDry.Location = New System.Drawing.Point(147, 17)
        Me.lvlDry.Mutable = False
        Me.lvlDry.MuteChangedDelegate = Nothing
        Me.lvlDry.Muted = False
        Me.lvlDry.Name = "lvlDry"
        Me.lvlDry.Size = New System.Drawing.Size(41, 142)
        Me.lvlDry.TabIndex = 3
        Me.lvlDry.Value = CType(127, Byte)
        Me.lvlDry.VolumeChangedDelegate = Nothing
        '
        'lvlVariation
        '
        Me.lvlVariation.Label = "Variat"
        Me.lvlVariation.Location = New System.Drawing.Point(100, 17)
        Me.lvlVariation.Mutable = False
        Me.lvlVariation.MuteChangedDelegate = Nothing
        Me.lvlVariation.Muted = False
        Me.lvlVariation.Name = "lvlVariation"
        Me.lvlVariation.Size = New System.Drawing.Size(41, 142)
        Me.lvlVariation.TabIndex = 2
        Me.lvlVariation.Value = CType(127, Byte)
        Me.lvlVariation.VolumeChangedDelegate = Nothing
        '
        'lvlChorus
        '
        Me.lvlChorus.Label = "Chorus"
        Me.lvlChorus.Location = New System.Drawing.Point(53, 17)
        Me.lvlChorus.Mutable = False
        Me.lvlChorus.MuteChangedDelegate = Nothing
        Me.lvlChorus.Muted = False
        Me.lvlChorus.Name = "lvlChorus"
        Me.lvlChorus.Size = New System.Drawing.Size(41, 142)
        Me.lvlChorus.TabIndex = 1
        Me.lvlChorus.Value = CType(127, Byte)
        Me.lvlChorus.VolumeChangedDelegate = Nothing
        '
        'lvlReverb
        '
        Me.lvlReverb.Label = "Reverb"
        Me.lvlReverb.Location = New System.Drawing.Point(6, 17)
        Me.lvlReverb.Mutable = False
        Me.lvlReverb.MuteChangedDelegate = Nothing
        Me.lvlReverb.Muted = False
        Me.lvlReverb.Name = "lvlReverb"
        Me.lvlReverb.Size = New System.Drawing.Size(41, 142)
        Me.lvlReverb.TabIndex = 0
        Me.lvlReverb.Value = CType(127, Byte)
        Me.lvlReverb.VolumeChangedDelegate = Nothing
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lvlOut)
        Me.GroupBox5.Controls.Add(Me.lvlMIDI)
        Me.GroupBox5.Controls.Add(Me.lvlMicIn)
        Me.GroupBox5.Controls.Add(Me.lvlLineIn)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 22)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(198, 159)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Master Volume"
        '
        'lvlOut
        '
        Me.lvlOut.Label = "Out"
        Me.lvlOut.Location = New System.Drawing.Point(147, 17)
        Me.lvlOut.Mutable = False
        Me.lvlOut.MuteChangedDelegate = Nothing
        Me.lvlOut.Muted = False
        Me.lvlOut.Name = "lvlOut"
        Me.lvlOut.Size = New System.Drawing.Size(41, 142)
        Me.lvlOut.TabIndex = 3
        Me.lvlOut.Value = CType(127, Byte)
        Me.lvlOut.VolumeChangedDelegate = Nothing
        '
        'lvlMIDI
        '
        Me.lvlMIDI.Label = "MIDI"
        Me.lvlMIDI.Location = New System.Drawing.Point(100, 17)
        Me.lvlMIDI.Mutable = False
        Me.lvlMIDI.MuteChangedDelegate = Nothing
        Me.lvlMIDI.Muted = False
        Me.lvlMIDI.Name = "lvlMIDI"
        Me.lvlMIDI.Size = New System.Drawing.Size(41, 142)
        Me.lvlMIDI.TabIndex = 2
        Me.lvlMIDI.Value = CType(127, Byte)
        Me.lvlMIDI.VolumeChangedDelegate = Nothing
        '
        'lvlMicIn
        '
        Me.lvlMicIn.Label = "Mic In"
        Me.lvlMicIn.Location = New System.Drawing.Point(53, 17)
        Me.lvlMicIn.Mutable = False
        Me.lvlMicIn.MuteChangedDelegate = Nothing
        Me.lvlMicIn.Muted = False
        Me.lvlMicIn.Name = "lvlMicIn"
        Me.lvlMicIn.Size = New System.Drawing.Size(41, 142)
        Me.lvlMicIn.TabIndex = 1
        Me.lvlMicIn.Value = CType(127, Byte)
        Me.lvlMicIn.VolumeChangedDelegate = Nothing
        '
        'lvlLineIn
        '
        Me.lvlLineIn.Label = "Line In"
        Me.lvlLineIn.Location = New System.Drawing.Point(6, 17)
        Me.lvlLineIn.Mutable = False
        Me.lvlLineIn.MuteChangedDelegate = Nothing
        Me.lvlLineIn.Muted = False
        Me.lvlLineIn.Name = "lvlLineIn"
        Me.lvlLineIn.Size = New System.Drawing.Size(41, 142)
        Me.lvlLineIn.TabIndex = 0
        Me.lvlLineIn.Value = CType(127, Byte)
        Me.lvlLineIn.VolumeChangedDelegate = Nothing
        '
        'lvlVarToRev
        '
        Me.lvlVarToRev.Label = "Var to Reverb"
        Me.lvlVarToRev.Location = New System.Drawing.Point(167, 17)
        Me.lvlVarToRev.Mutable = False
        Me.lvlVarToRev.MuteChangedDelegate = Nothing
        Me.lvlVarToRev.Muted = False
        Me.lvlVarToRev.Name = "lvlVarToRev"
        Me.lvlVarToRev.Size = New System.Drawing.Size(41, 142)
        Me.lvlVarToRev.TabIndex = 3
        Me.lvlVarToRev.Value = CType(127, Byte)
        Me.lvlVarToRev.VolumeChangedDelegate = Nothing
        '
        'lvlVarToCho
        '
        Me.lvlVarToCho.Label = "Var to Chorus"
        Me.lvlVarToCho.Location = New System.Drawing.Point(214, 17)
        Me.lvlVarToCho.Mutable = False
        Me.lvlVarToCho.MuteChangedDelegate = Nothing
        Me.lvlVarToCho.Muted = False
        Me.lvlVarToCho.Name = "lvlVarToCho"
        Me.lvlVarToCho.Size = New System.Drawing.Size(41, 142)
        Me.lvlVarToCho.TabIndex = 4
        Me.lvlVarToCho.Value = CType(127, Byte)
        Me.lvlVarToCho.VolumeChangedDelegate = Nothing
        '
        'frmEditEffect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 243)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditEffect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Patch"
        Me.TabControl1.ResumeLayout(False)
        Me.tabReverb.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.tabChorus.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.tabVariation.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.tabLevels.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabReverb As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstReverb As ListBox
    Friend WithEvents tabChorus As TabPage
    Friend WithEvents tabVariation As TabPage
    Friend WithEvents tabLevels As TabPage
    Friend WithEvents rvbParm16 As ucSlider
    Friend WithEvents rvbParm15 As ucSlider
    Friend WithEvents rvbParm14 As ucSlider
    Friend WithEvents rvbParm13 As ucSlider
    Friend WithEvents rvbParm12 As ucSlider
    Friend WithEvents rvbParm11 As ucSlider
    Friend WithEvents rvbParm10 As ucSlider
    Friend WithEvents rvbParm9 As ucSlider
    Friend WithEvents rvbParm8 As ucSlider
    Friend WithEvents rvbParm7 As ucSlider
    Friend WithEvents rvbParm6 As ucSlider
    Friend WithEvents rvbParm5 As ucSlider
    Friend WithEvents rvbParm4 As ucSlider
    Friend WithEvents rvbParm3 As ucSlider
    Friend WithEvents rvbParm2 As ucSlider
    Friend WithEvents rvbParm1 As ucSlider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents choParm16 As ucSlider
    Friend WithEvents choParm15 As ucSlider
    Friend WithEvents choParm14 As ucSlider
    Friend WithEvents choParm13 As ucSlider
    Friend WithEvents choParm12 As ucSlider
    Friend WithEvents choParm11 As ucSlider
    Friend WithEvents choParm10 As ucSlider
    Friend WithEvents choParm9 As ucSlider
    Friend WithEvents choParm8 As ucSlider
    Friend WithEvents choParm7 As ucSlider
    Friend WithEvents choParm6 As ucSlider
    Friend WithEvents choParm5 As ucSlider
    Friend WithEvents choParm4 As ucSlider
    Friend WithEvents choParm3 As ucSlider
    Friend WithEvents choParm2 As ucSlider
    Friend WithEvents choParm1 As ucSlider
    Friend WithEvents lstChorus As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents varParm16 As ucSlider
    Friend WithEvents varParm15 As ucSlider
    Friend WithEvents varParm14 As ucSlider
    Friend WithEvents varParm13 As ucSlider
    Friend WithEvents varParm12 As ucSlider
    Friend WithEvents varParm11 As ucSlider
    Friend WithEvents varParm10 As ucSlider
    Friend WithEvents varParm9 As ucSlider
    Friend WithEvents varParm8 As ucSlider
    Friend WithEvents varParm7 As ucSlider
    Friend WithEvents varParm6 As ucSlider
    Friend WithEvents varParm5 As ucSlider
    Friend WithEvents varParm4 As ucSlider
    Friend WithEvents varParm3 As ucSlider
    Friend WithEvents varParm2 As ucSlider
    Friend WithEvents varParm1 As ucSlider
    Friend WithEvents lstVariation As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lvlToCho As ucSliderMutable
    Friend WithEvents lvlToRev As ucSliderMutable
    Friend WithEvents lvlChoToRev As ucSliderMutable
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lvlDry As ucSliderMutable
    Friend WithEvents lvlVariation As ucSliderMutable
    Friend WithEvents lvlChorus As ucSliderMutable
    Friend WithEvents lvlReverb As ucSliderMutable
    Friend WithEvents lvlOut As ucSliderMutable
    Friend WithEvents lvlMIDI As ucSliderMutable
    Friend WithEvents lvlMicIn As ucSliderMutable
    Friend WithEvents lvlLineIn As ucSliderMutable
    Friend WithEvents lvlVarToCho As ucSliderMutable
    Friend WithEvents lvlVarToRev As ucSliderMutable
End Class
