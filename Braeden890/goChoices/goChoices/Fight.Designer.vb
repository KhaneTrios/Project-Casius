<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fight
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.skillOne = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.heroName = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.className = New System.Windows.Forms.Label()
        Me.skillTwo = New System.Windows.Forms.Button()
        Me.skillThree = New System.Windows.Forms.Button()
        Me.skillFour = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.enemyBox = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.enemyName = New System.Windows.Forms.Label()
        Me.heroMana = New System.Windows.Forms.ProgressBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemyBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(681, 694)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 356)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(152, 13)
        Me.ProgressBar1.TabIndex = 1
        Me.ProgressBar1.Value = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(231, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "100"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hero Health: "
        '
        'ProgressBar2
        '
        Me.ProgressBar2.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar2.Location = New System.Drawing.Point(604, 379)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(152, 13)
        Me.ProgressBar2.TabIndex = 4
        Me.ProgressBar2.Value = 100
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(641, 397)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Enemy Health: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(718, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "100"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 431)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Attack"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(681, 431)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "enemy atk" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button3.UseVisualStyleBackColor = True
        '
        'skillOne
        '
        Me.skillOne.Location = New System.Drawing.Point(12, 523)
        Me.skillOne.Name = "skillOne"
        Me.skillOne.Size = New System.Drawing.Size(185, 94)
        Me.skillOne.TabIndex = 9
        Me.skillOne.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 498)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Skills:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'heroName
        '
        Me.heroName.Location = New System.Drawing.Point(545, 576)
        Me.heroName.Name = "heroName"
        Me.heroName.Size = New System.Drawing.Size(130, 141)
        Me.heroName.TabIndex = 11
        Me.heroName.Text = "Test Fight Button"
        Me.heroName.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(678, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "99"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(681, 326)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "50-100"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 327)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "99"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(124, 327)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "99"
        '
        'className
        '
        Me.className.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.className.Location = New System.Drawing.Point(407, 9)
        Me.className.Name = "className"
        Me.className.Size = New System.Drawing.Size(103, 30)
        Me.className.TabIndex = 18
        '
        'skillTwo
        '
        Me.skillTwo.Location = New System.Drawing.Point(203, 523)
        Me.skillTwo.Name = "skillTwo"
        Me.skillTwo.Size = New System.Drawing.Size(185, 94)
        Me.skillTwo.TabIndex = 19
        Me.skillTwo.UseVisualStyleBackColor = True
        '
        'skillThree
        '
        Me.skillThree.Location = New System.Drawing.Point(12, 623)
        Me.skillThree.Name = "skillThree"
        Me.skillThree.Size = New System.Drawing.Size(185, 94)
        Me.skillThree.TabIndex = 20
        Me.skillThree.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.skillThree.UseVisualStyleBackColor = True
        '
        'skillFour
        '
        Me.skillFour.Location = New System.Drawing.Point(203, 623)
        Me.skillFour.Name = "skillFour"
        Me.skillFour.Size = New System.Drawing.Size(185, 94)
        Me.skillFour.TabIndex = 21
        Me.skillFour.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(213, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(188, 30)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "All hail the mighty "
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(16, 143)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 146)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'enemyBox
        '
        Me.enemyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.enemyBox.Location = New System.Drawing.Point(604, 159)
        Me.enemyBox.Name = "enemyBox"
        Me.enemyBox.Size = New System.Drawing.Size(152, 146)
        Me.enemyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemyBox.TabIndex = 24
        Me.enemyBox.TabStop = False
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(68, 115)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 23)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "heroName" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'enemyName
        '
        Me.enemyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.enemyName.Location = New System.Drawing.Point(604, 115)
        Me.enemyName.Name = "enemyName"
        Me.enemyName.Size = New System.Drawing.Size(100, 23)
        Me.enemyName.TabIndex = 26
        Me.enemyName.Text = "enemyName" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'heroMana
        '
        Me.heroMana.ForeColor = System.Drawing.Color.Blue
        Me.heroMana.Location = New System.Drawing.Point(12, 366)
        Me.heroMana.Name = "heroMana"
        Me.heroMana.Size = New System.Drawing.Size(152, 13)
        Me.heroMana.TabIndex = 27
        Me.heroMana.Value = 100
        '
        'Fight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 729)
        Me.Controls.Add(Me.heroMana)
        Me.Controls.Add(Me.enemyName)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.enemyBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.skillFour)
        Me.Controls.Add(Me.skillThree)
        Me.Controls.Add(Me.skillTwo)
        Me.Controls.Add(Me.className)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.heroName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.skillOne)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Fight"
        Me.Text = "Fighting Screen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemyBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents skillOne As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents heroName As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Updaete As System.Windows.Forms.Timer
    Friend WithEvents Randomizer As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Plugger As System.Windows.Forms.Timer
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents className As Label
    Friend WithEvents skillTwo As Button
    Friend WithEvents skillThree As Button
    Friend WithEvents skillFour As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents enemyBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents enemyName As System.Windows.Forms.Label
    Friend WithEvents heroMana As System.Windows.Forms.ProgressBar
End Class
