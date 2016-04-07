<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaves
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
        Me.btnSave1 = New System.Windows.Forms.Button()
        Me.btnSave2 = New System.Windows.Forms.Button()
        Me.btnSave3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete1 = New System.Windows.Forms.Button()
        Me.btnDelete3 = New System.Windows.Forms.Button()
        Me.btnDelete2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSave1
        '
        Me.btnSave1.Location = New System.Drawing.Point(27, 34)
        Me.btnSave1.Name = "btnSave1"
        Me.btnSave1.Size = New System.Drawing.Size(216, 56)
        Me.btnSave1.TabIndex = 0
        Me.btnSave1.Text = "Save Slot 1"
        Me.btnSave1.UseVisualStyleBackColor = True
        '
        'btnSave2
        '
        Me.btnSave2.Location = New System.Drawing.Point(27, 106)
        Me.btnSave2.Name = "btnSave2"
        Me.btnSave2.Size = New System.Drawing.Size(216, 56)
        Me.btnSave2.TabIndex = 1
        Me.btnSave2.Text = "Save Slot 2"
        Me.btnSave2.UseVisualStyleBackColor = True
        '
        'btnSave3
        '
        Me.btnSave3.Location = New System.Drawing.Point(27, 182)
        Me.btnSave3.Name = "btnSave3"
        Me.btnSave3.Size = New System.Drawing.Size(216, 56)
        Me.btnSave3.TabIndex = 2
        Me.btnSave3.Text = "Save Slot 3"
        Me.btnSave3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Choose a save..."
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(264, 232)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 32)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete1
        '
        Me.btnDelete1.Location = New System.Drawing.Point(206, 34)
        Me.btnDelete1.Name = "btnDelete1"
        Me.btnDelete1.Size = New System.Drawing.Size(37, 25)
        Me.btnDelete1.TabIndex = 5
        Me.btnDelete1.Text = "X"
        Me.btnDelete1.UseVisualStyleBackColor = True
        '
        'btnDelete3
        '
        Me.btnDelete3.Location = New System.Drawing.Point(206, 182)
        Me.btnDelete3.Name = "btnDelete3"
        Me.btnDelete3.Size = New System.Drawing.Size(37, 25)
        Me.btnDelete3.TabIndex = 8
        Me.btnDelete3.Text = "X"
        Me.btnDelete3.UseVisualStyleBackColor = True
        '
        'btnDelete2
        '
        Me.btnDelete2.Location = New System.Drawing.Point(206, 106)
        Me.btnDelete2.Name = "btnDelete2"
        Me.btnDelete2.Size = New System.Drawing.Size(37, 25)
        Me.btnDelete2.TabIndex = 9
        Me.btnDelete2.Text = "X"
        Me.btnDelete2.UseVisualStyleBackColor = True
        '
        'frmSaves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 263)
        Me.Controls.Add(Me.btnDelete2)
        Me.Controls.Add(Me.btnDelete3)
        Me.Controls.Add(Me.btnDelete1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave3)
        Me.Controls.Add(Me.btnSave2)
        Me.Controls.Add(Me.btnSave1)
        Me.Name = "frmSaves"
        Me.Text = "Project Casius"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave1 As System.Windows.Forms.Button
    Friend WithEvents btnSave2 As System.Windows.Forms.Button
    Friend WithEvents btnSave3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDelete1 As Button
    Friend WithEvents btnDelete3 As Button
    Friend WithEvents btnDelete2 As Button
End Class
