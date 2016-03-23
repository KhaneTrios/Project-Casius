<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFollowers
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblSucFail2 = New System.Windows.Forms.Label()
        Me.lblFollowers2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(81, 85)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(126, 44)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblSucFail2
        '
        Me.lblSucFail2.AutoSize = True
        Me.lblSucFail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucFail2.Location = New System.Drawing.Point(2, 9)
        Me.lblSucFail2.Name = "lblSucFail2"
        Me.lblSucFail2.Size = New System.Drawing.Size(86, 16)
        Me.lblSucFail2.TabIndex = 1
        Me.lblSucFail2.Text = "Success/Fail"
        '
        'lblFollowers2
        '
        Me.lblFollowers2.AutoSize = True
        Me.lblFollowers2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFollowers2.Location = New System.Drawing.Point(12, 46)
        Me.lblFollowers2.Name = "lblFollowers2"
        Me.lblFollowers2.Size = New System.Drawing.Size(76, 20)
        Me.lblFollowers2.TabIndex = 2
        Me.lblFollowers2.Text = "Followers"
        '
        'frmFollowers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 141)
        Me.Controls.Add(Me.lblFollowers2)
        Me.Controls.Add(Me.lblSucFail2)
        Me.Controls.Add(Me.btnOk)
        Me.Name = "frmFollowers"
        Me.Text = "frmFollowers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOk As Button
    Friend WithEvents lblSucFail2 As Label
    Friend WithEvents lblFollowers2 As Label
End Class
