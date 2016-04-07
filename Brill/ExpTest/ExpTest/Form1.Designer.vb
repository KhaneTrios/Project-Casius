<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ExpShow = New System.Windows.Forms.Label()
        Me.Updater = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LvlShow = New System.Windows.Forms.Label()
        Me.TotLvl = New System.Windows.Forms.Label()
        Me.exptot = New System.Windows.Forms.Label()
        Me.exp = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Merc Something"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.ControlText
        Me.ProgressBar1.ForeColor = System.Drawing.Color.OrangeRed
        Me.ProgressBar1.Location = New System.Drawing.Point(94, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(144, 24)
        Me.ProgressBar1.TabIndex = 1
        '
        'ExpShow
        '
        Me.ExpShow.AutoSize = True
        Me.ExpShow.Location = New System.Drawing.Point(57, 50)
        Me.ExpShow.Name = "ExpShow"
        Me.ExpShow.Size = New System.Drawing.Size(31, 13)
        Me.ExpShow.TabIndex = 2
        Me.ExpShow.Text = "9999"
        '
        'Updater
        '
        Me.Updater.Enabled = True
        Me.Updater.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Exp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Level"
        '
        'LvlShow
        '
        Me.LvlShow.AutoSize = True
        Me.LvlShow.Location = New System.Drawing.Point(60, 75)
        Me.LvlShow.Name = "LvlShow"
        Me.LvlShow.Size = New System.Drawing.Size(31, 13)
        Me.LvlShow.TabIndex = 5
        Me.LvlShow.Text = "9999"
        '
        'TotLvl
        '
        Me.TotLvl.AutoSize = True
        Me.TotLvl.Location = New System.Drawing.Point(109, 50)
        Me.TotLvl.Name = "TotLvl"
        Me.TotLvl.Size = New System.Drawing.Size(39, 13)
        Me.TotLvl.TabIndex = 6
        Me.TotLvl.Text = "Label3"
        '
        'exptot
        '
        Me.exptot.AutoSize = True
        Me.exptot.Location = New System.Drawing.Point(199, 50)
        Me.exptot.Name = "exptot"
        Me.exptot.Size = New System.Drawing.Size(39, 13)
        Me.exptot.TabIndex = 7
        Me.exptot.Text = "Label3"
        '
        'exp
        '
        Me.exp.Enabled = True
        Me.exp.Interval = 10
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox1.Location = New System.Drawing.Point(112, 75)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Exp + 15"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 96)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.exptot)
        Me.Controls.Add(Me.TotLvl)
        Me.Controls.Add(Me.LvlShow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExpShow)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Exp Testing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ExpShow As Label
    Friend WithEvents Updater As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LvlShow As Label
    Friend WithEvents TotLvl As Label
    Friend WithEvents exptot As Label
    Friend WithEvents exp As Timer
    Friend WithEvents CheckBox1 As CheckBox
End Class
