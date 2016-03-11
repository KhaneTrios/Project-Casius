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
        Me.txtSet = New System.Windows.Forms.TextBox()
        Me.ToolTipDev = New System.Windows.Forms.ToolTip(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
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
        Me.btnSet.Location = New System.Drawing.Point(136, 120)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(72, 24)
        Me.btnSet.TabIndex = 3
        Me.btnSet.Text = "Set"
        Me.ToolTipDev.SetToolTip(Me.btnSet, "Sets the City size, to test all city sizes. Must be 1, 2, or 3.")
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'txtSet
        '
        Me.txtSet.Location = New System.Drawing.Point(24, 120)
        Me.txtSet.Name = "txtSet"
        Me.txtSet.Size = New System.Drawing.Size(96, 20)
        Me.txtSet.TabIndex = 4
        Me.txtSet.Text = "City Size"
        Me.ToolTipDev.SetToolTip(Me.txtSet, "Set the city size to 1, 2, or 3. The higher the number the larger the city.")
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(32, 160)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(95, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Pre-Completed"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DevConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 246)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.txtSet)
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
    Friend WithEvents txtSet As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipDev As System.Windows.Forms.ToolTip
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
