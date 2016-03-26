<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevConsole
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevConsole))
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.ToolTipDev = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnTagSet = New System.Windows.Forms.Button()
        Me.btnRand = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.chkComplete = New System.Windows.Forms.CheckBox()
        Me.chkRecruit = New System.Windows.Forms.CheckBox()
        Me.cmboType = New System.Windows.Forms.ComboBox()
        Me.cmboTag = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(32, 208)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(80, 24)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load"
        Me.ToolTipDev.SetToolTip(Me.btnLoad, "Load level")
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(160, 208)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(80, 24)
        Me.btnEnd.TabIndex = 2
        Me.btnEnd.Text = "End"
        Me.ToolTipDev.SetToolTip(Me.btnEnd, "End program")
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(118, 102)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(72, 21)
        Me.btnSet.TabIndex = 3
        Me.btnSet.Text = "Set"
        Me.ToolTipDev.SetToolTip(Me.btnSet, "Sets the City size, to test all city sizes. Must be 1, 2, or 3.")
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'btnTagSet
        '
        Me.btnTagSet.Location = New System.Drawing.Point(118, 129)
        Me.btnTagSet.Name = "btnTagSet"
        Me.btnTagSet.Size = New System.Drawing.Size(72, 21)
        Me.btnTagSet.TabIndex = 10
        Me.btnTagSet.Text = "Set"
        Me.ToolTipDev.SetToolTip(Me.btnTagSet, "Sets the City size, to test all city sizes. Must be 1, 2, or 3.")
        Me.btnTagSet.UseVisualStyleBackColor = True
        '
        'btnRand
        '
        Me.btnRand.Location = New System.Drawing.Point(196, 130)
        Me.btnRand.Name = "btnRand"
        Me.btnRand.Size = New System.Drawing.Size(59, 21)
        Me.btnRand.TabIndex = 11
        Me.btnRand.Text = "Rand"
        Me.ToolTipDev.SetToolTip(Me.btnRand, "Sets the City size, to test all city sizes. Must be 1, 2, or 3.")
        Me.btnRand.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(8, 8)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(248, 80)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'chkComplete
        '
        Me.chkComplete.AutoSize = True
        Me.chkComplete.Location = New System.Drawing.Point(17, 159)
        Me.chkComplete.Name = "chkComplete"
        Me.chkComplete.Size = New System.Drawing.Size(95, 17)
        Me.chkComplete.TabIndex = 6
        Me.chkComplete.Text = "Pre-Completed"
        Me.chkComplete.UseVisualStyleBackColor = True
        '
        'chkRecruit
        '
        Me.chkRecruit.AutoSize = True
        Me.chkRecruit.Location = New System.Drawing.Point(136, 159)
        Me.chkRecruit.Name = "chkRecruit"
        Me.chkRecruit.Size = New System.Drawing.Size(81, 17)
        Me.chkRecruit.TabIndex = 7
        Me.chkRecruit.Text = "Insta-recruit"
        Me.chkRecruit.UseVisualStyleBackColor = True
        '
        'cmboType
        '
        Me.cmboType.FormattingEnabled = True
        Me.cmboType.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmboType.Location = New System.Drawing.Point(32, 103)
        Me.cmboType.Name = "cmboType"
        Me.cmboType.Size = New System.Drawing.Size(80, 21)
        Me.cmboType.TabIndex = 8
        Me.cmboType.Text = "NPC Type"
        '
        'cmboTag
        '
        Me.cmboTag.FormattingEnabled = True
        Me.cmboTag.Items.AddRange(New Object() {"a", "b", "c", "d", "e", "f"})
        Me.cmboTag.Location = New System.Drawing.Point(32, 130)
        Me.cmboTag.Name = "cmboTag"
        Me.cmboTag.Size = New System.Drawing.Size(80, 21)
        Me.cmboTag.TabIndex = 9
        Me.cmboTag.Text = "NPC Tag"
        '
        'DevConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 246)
        Me.Controls.Add(Me.btnRand)
        Me.Controls.Add(Me.btnTagSet)
        Me.Controls.Add(Me.cmboTag)
        Me.Controls.Add(Me.cmboType)
        Me.Controls.Add(Me.chkRecruit)
        Me.Controls.Add(Me.chkComplete)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "DevConsole"
        Me.Text = "DevConsole"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents ToolTipDev As System.Windows.Forms.ToolTip
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents chkComplete As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecruit As CheckBox
    Friend WithEvents cmboType As ComboBox
    Friend WithEvents cmboTag As ComboBox
    Friend WithEvents btnTagSet As Button
    Friend WithEvents btnRand As Button
End Class
