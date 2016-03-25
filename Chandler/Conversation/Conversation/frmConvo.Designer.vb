<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConvo))
        Me.picChar = New System.Windows.Forms.PictureBox()
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.rtxtNPC = New System.Windows.Forms.RichTextBox()
        Me.lblNPCName = New System.Windows.Forms.Label()
        Me.grp2 = New System.Windows.Forms.GroupBox()
        Me.Talk = New System.Windows.Forms.Button()
        Me.grp3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.grp4 = New System.Windows.Forms.GroupBox()
        Me.btn4Leave = New System.Windows.Forms.Button()
        Me.btn4Talk = New System.Windows.Forms.Button()
        Me.btn4Sell = New System.Windows.Forms.Button()
        Me.btn4Buy = New System.Windows.Forms.Button()
        Me.grp5 = New System.Windows.Forms.GroupBox()
        Me.btn5Ok = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp1.SuspendLayout()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp2.SuspendLayout()
        Me.grp3.SuspendLayout()
        Me.grp4.SuspendLayout()
        Me.grp5.SuspendLayout()
        Me.SuspendLayout()
        '
        'picChar
        '
        Me.picChar.Image = CType(resources.GetObject("picChar.Image"), System.Drawing.Image)
        Me.picChar.Location = New System.Drawing.Point(22, 38)
        Me.picChar.Name = "picChar"
        Me.picChar.Size = New System.Drawing.Size(260, 190)
        Me.picChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChar.TabIndex = 0
        Me.picChar.TabStop = False
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.Button5)
        Me.grp1.Controls.Add(Me.Button1)
        Me.grp1.Location = New System.Drawing.Point(0, 0)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(726, 130)
        Me.grp1.TabIndex = 1
        Me.grp1.TabStop = False
        Me.grp1.Text = "Interact"
        Me.grp1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Talk"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'picBack
        '
        Me.picBack.Image = CType(resources.GetObject("picBack.Image"), System.Drawing.Image)
        Me.picBack.Location = New System.Drawing.Point(2, 2)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(725, 305)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBack.TabIndex = 2
        Me.picBack.TabStop = False
        '
        'rtxtNPC
        '
        Me.rtxtNPC.Location = New System.Drawing.Point(307, 38)
        Me.rtxtNPC.Name = "rtxtNPC"
        Me.rtxtNPC.Size = New System.Drawing.Size(331, 91)
        Me.rtxtNPC.TabIndex = 3
        Me.rtxtNPC.Text = "Character says stuff here..."
        '
        'lblNPCName
        '
        Me.lblNPCName.AutoSize = True
        Me.lblNPCName.Location = New System.Drawing.Point(19, 13)
        Me.lblNPCName.Name = "lblNPCName"
        Me.lblNPCName.Size = New System.Drawing.Size(60, 13)
        Me.lblNPCName.TabIndex = 4
        Me.lblNPCName.Text = "NPC Name"
        '
        'grp2
        '
        Me.grp2.Controls.Add(Me.Button4)
        Me.grp2.Controls.Add(Me.Talk)
        Me.grp2.Location = New System.Drawing.Point(0, 0)
        Me.grp2.Name = "grp2"
        Me.grp2.Size = New System.Drawing.Size(726, 130)
        Me.grp2.TabIndex = 2
        Me.grp2.TabStop = False
        Me.grp2.Text = "Interact"
        Me.grp2.Visible = False
        '
        'Talk
        '
        Me.Talk.Location = New System.Drawing.Point(10, 48)
        Me.Talk.Name = "Talk"
        Me.Talk.Size = New System.Drawing.Size(148, 48)
        Me.Talk.TabIndex = 0
        Me.Talk.Text = "Fight"
        Me.Talk.UseVisualStyleBackColor = True
        '
        'grp3
        '
        Me.grp3.Controls.Add(Me.grp1)
        Me.grp3.Controls.Add(Me.Button2)
        Me.grp3.Controls.Add(Me.Button3)
        Me.grp3.Location = New System.Drawing.Point(0, 0)
        Me.grp3.Name = "grp3"
        Me.grp3.Size = New System.Drawing.Size(726, 130)
        Me.grp3.TabIndex = 2
        Me.grp3.TabStop = False
        Me.grp3.Text = "Interact"
        Me.grp3.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(10, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 48)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Talk"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'grp4
        '
        Me.grp4.Controls.Add(Me.grp3)
        Me.grp4.Controls.Add(Me.btn4Leave)
        Me.grp4.Controls.Add(Me.btn4Talk)
        Me.grp4.Controls.Add(Me.btn4Sell)
        Me.grp4.Controls.Add(Me.btn4Buy)
        Me.grp4.Location = New System.Drawing.Point(2, 313)
        Me.grp4.Name = "grp4"
        Me.grp4.Size = New System.Drawing.Size(726, 130)
        Me.grp4.TabIndex = 2
        Me.grp4.TabStop = False
        Me.grp4.Text = "Interact"
        Me.grp4.Visible = False
        '
        'btn4Leave
        '
        Me.btn4Leave.Location = New System.Drawing.Point(502, 47)
        Me.btn4Leave.Name = "btn4Leave"
        Me.btn4Leave.Size = New System.Drawing.Size(123, 48)
        Me.btn4Leave.TabIndex = 3
        Me.btn4Leave.Text = "Leave"
        Me.btn4Leave.UseVisualStyleBackColor = True
        '
        'btn4Talk
        '
        Me.btn4Talk.Location = New System.Drawing.Point(264, 47)
        Me.btn4Talk.Name = "btn4Talk"
        Me.btn4Talk.Size = New System.Drawing.Size(123, 49)
        Me.btn4Talk.TabIndex = 2
        Me.btn4Talk.Text = "Talk"
        Me.btn4Talk.UseVisualStyleBackColor = True
        '
        'btn4Sell
        '
        Me.btn4Sell.Location = New System.Drawing.Point(135, 48)
        Me.btn4Sell.Name = "btn4Sell"
        Me.btn4Sell.Size = New System.Drawing.Size(123, 47)
        Me.btn4Sell.TabIndex = 1
        Me.btn4Sell.Text = "Sell"
        Me.btn4Sell.UseVisualStyleBackColor = True
        '
        'btn4Buy
        '
        Me.btn4Buy.Location = New System.Drawing.Point(10, 48)
        Me.btn4Buy.Name = "btn4Buy"
        Me.btn4Buy.Size = New System.Drawing.Size(119, 47)
        Me.btn4Buy.TabIndex = 0
        Me.btn4Buy.Text = "Buy"
        Me.btn4Buy.UseVisualStyleBackColor = True
        '
        'grp5
        '
        Me.grp5.Controls.Add(Me.grp2)
        Me.grp5.Controls.Add(Me.btn5Ok)
        Me.grp5.Location = New System.Drawing.Point(1, 313)
        Me.grp5.Name = "grp5"
        Me.grp5.Size = New System.Drawing.Size(726, 130)
        Me.grp5.TabIndex = 2
        Me.grp5.TabStop = False
        Me.grp5.Text = "Interact"
        Me.grp5.Visible = False
        '
        'btn5Ok
        '
        Me.btn5Ok.Location = New System.Drawing.Point(187, 34)
        Me.btn5Ok.Name = "btn5Ok"
        Me.btn5Ok.Size = New System.Drawing.Size(273, 70)
        Me.btn5Ok.TabIndex = 0
        Me.btn5Ok.Text = "Ok"
        Me.btn5Ok.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(173, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 48)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Persuade"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(166, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(148, 48)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Talk"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(166, 48)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(148, 48)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Recruit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frmConvo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 443)
        Me.Controls.Add(Me.grp4)
        Me.Controls.Add(Me.lblNPCName)
        Me.Controls.Add(Me.rtxtNPC)
        Me.Controls.Add(Me.picChar)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.grp5)
        Me.Name = "frmConvo"
        Me.Text = "Project Casius"
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp1.ResumeLayout(False)
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp2.ResumeLayout(False)
        Me.grp3.ResumeLayout(False)
        Me.grp4.ResumeLayout(False)
        Me.grp5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picChar As PictureBox
    Friend WithEvents grp1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents picBack As PictureBox
    Friend WithEvents rtxtNPC As RichTextBox
    Friend WithEvents lblNPCName As Label
    Friend WithEvents grp2 As GroupBox
    Friend WithEvents grp3 As GroupBox
    Friend WithEvents grp4 As GroupBox
    Friend WithEvents grp5 As GroupBox
    Friend WithEvents btn5Ok As Button
    Friend WithEvents btn4Buy As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Talk As Button
    Friend WithEvents btn4Leave As Button
    Friend WithEvents btn4Talk As Button
    Friend WithEvents btn4Sell As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
End Class
