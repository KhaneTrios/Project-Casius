<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recruit
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
        Me.btnRec = New System.Windows.Forms.Button()
        Me.btnRecCancel = New System.Windows.Forms.Button()
        Me.chkRecAsk = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnRec
        '
        Me.btnRec.Location = New System.Drawing.Point(16, 48)
        Me.btnRec.Name = "btnRec"
        Me.btnRec.Size = New System.Drawing.Size(128, 32)
        Me.btnRec.TabIndex = 0
        Me.btnRec.Text = "Attempt Recruitment"
        Me.btnRec.UseVisualStyleBackColor = True
        '
        'btnRecCancel
        '
        Me.btnRecCancel.Location = New System.Drawing.Point(224, 48)
        Me.btnRecCancel.Name = "btnRecCancel"
        Me.btnRecCancel.Size = New System.Drawing.Size(96, 32)
        Me.btnRecCancel.TabIndex = 1
        Me.btnRecCancel.Text = "Cancel"
        Me.btnRecCancel.UseVisualStyleBackColor = True
        '
        'chkRecAsk
        '
        Me.chkRecAsk.AutoSize = True
        Me.chkRecAsk.Location = New System.Drawing.Point(0, 88)
        Me.chkRecAsk.Name = "chkRecAsk"
        Me.chkRecAsk.Size = New System.Drawing.Size(108, 17)
        Me.chkRecAsk.TabIndex = 2
        Me.chkRecAsk.Text = "Don't show again"
        Me.chkRecAsk.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 8)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(320, 32)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "You can attempt to recruit civilians to aid your cause but you can risk losing ci" &
    "ty strength if you fail to recruit civilians"
        '
        'Recruit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 114)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.chkRecAsk)
        Me.Controls.Add(Me.btnRecCancel)
        Me.Controls.Add(Me.btnRec)
        Me.Name = "Recruit"
        Me.Text = "Recruit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRec As System.Windows.Forms.Button
    Friend WithEvents btnRecCancel As System.Windows.Forms.Button
    Friend WithEvents chkRecAsk As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
