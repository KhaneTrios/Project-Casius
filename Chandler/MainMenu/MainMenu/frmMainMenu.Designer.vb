<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLoadGame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(8, 144)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(160, 48)
        Me.btnNewGame.TabIndex = 0
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Project Casius"
        '
        'btnLoadGame
        '
        Me.btnLoadGame.Location = New System.Drawing.Point(8, 216)
        Me.btnLoadGame.Name = "btnLoadGame"
        Me.btnLoadGame.Size = New System.Drawing.Size(160, 48)
        Me.btnLoadGame.TabIndex = 2
        Me.btnLoadGame.Text = "Load Game"
        Me.btnLoadGame.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 544)
        Me.Controls.Add(Me.btnLoadGame)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNewGame)
        Me.Name = "frmMainMenu"
        Me.Text = "Project Casius"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLoadGame As System.Windows.Forms.Button

End Class
