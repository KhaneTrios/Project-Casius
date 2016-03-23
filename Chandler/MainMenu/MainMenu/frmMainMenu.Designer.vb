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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnName = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLd = New System.Windows.Forms.Button()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.btnCreds = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(8, 104)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(208, 80)
        Me.btnNewGame.TabIndex = 0
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Project Casius"
        '
        'btnLoadGame
        '
        Me.btnLoadGame.Location = New System.Drawing.Point(8, 208)
        Me.btnLoadGame.Name = "btnLoadGame"
        Me.btnLoadGame.Size = New System.Drawing.Size(208, 80)
        Me.btnLoadGame.TabIndex = 2
        Me.btnLoadGame.Text = "Load Game"
        Me.btnLoadGame.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(410, 166)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(154, 20)
        Me.txtName.TabIndex = 3
        '
        'btnName
        '
        Me.btnName.Location = New System.Drawing.Point(446, 192)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(87, 32)
        Me.btnName.TabIndex = 4
        Me.btnName.Text = "Ok"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(588, 169)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(377, 240)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 24)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLd
        '
        Me.btnLd.Location = New System.Drawing.Point(502, 240)
        Me.btnLd.Name = "btnLd"
        Me.btnLd.Size = New System.Drawing.Size(102, 24)
        Me.btnLd.TabIndex = 7
        Me.btnLd.Text = "Load"
        Me.btnLd.UseVisualStyleBackColor = True
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(410, 127)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(102, 20)
        Me.txtNum.TabIndex = 8
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(563, 126)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(29, 13)
        Me.lblNum.TabIndex = 9
        Me.lblNum.Text = "Num"
        '
        'btnCreds
        '
        Me.btnCreds.Location = New System.Drawing.Point(8, 312)
        Me.btnCreds.Name = "btnCreds"
        Me.btnCreds.Size = New System.Drawing.Size(208, 80)
        Me.btnCreds.TabIndex = 10
        Me.btnCreds.Text = "Credits"
        Me.btnCreds.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(8, 416)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(208, 80)
        Me.btnQuit.TabIndex = 11
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 544)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCreds)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.btnLd)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnName)
        Me.Controls.Add(Me.txtName)
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
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnName As Button
    Friend WithEvents lblName As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnLd As Button
    Friend WithEvents txtNum As TextBox
    Friend WithEvents lblNum As Label
    Friend WithEvents btnCreds As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
End Class
