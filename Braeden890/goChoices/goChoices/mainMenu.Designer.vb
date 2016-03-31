<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.className = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 469)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(185, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 64)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Inventory" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(60, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(228, 30)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Welcome back, mighty" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'className
        '
        Me.className.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.className.Location = New System.Drawing.Point(288, 9)
        Me.className.Name = "className"
        Me.className.Size = New System.Drawing.Size(219, 30)
        Me.className.TabIndex = 23
        Me.className.Text = "Plot Character"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(185, 173)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 64)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Skills" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(185, 243)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 64)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Fight"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 504)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.className)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "mainMenu"
        Me.Text = "mainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents className As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
