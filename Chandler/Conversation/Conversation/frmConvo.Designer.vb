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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConvo))
        Me.picChar = New System.Windows.Forms.PictureBox()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.rtxtNPC = New System.Windows.Forms.RichTextBox()
        Me.lblNPCName = New System.Windows.Forms.Label()
        Me.grpInteract = New System.Windows.Forms.GroupBox()
        Me.lblFollowers = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.btnAction6 = New System.Windows.Forms.Button()
        Me.btnAction5 = New System.Windows.Forms.Button()
        Me.btnAction4 = New System.Windows.Forms.Button()
        Me.btnAction3 = New System.Windows.Forms.Button()
        Me.btnAction2 = New System.Windows.Forms.Button()
        Me.btnAction1 = New System.Windows.Forms.Button()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPause2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPause1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblCounter = New System.Windows.Forms.Label()
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInteract.SuspendLayout()
        Me.SuspendLayout()
        '
        'picChar
        '
        Me.picChar.Image = CType(resources.GetObject("picChar.Image"), System.Drawing.Image)
        Me.picChar.Location = New System.Drawing.Point(22, 38)
        Me.picChar.Name = "picChar"
        Me.picChar.Size = New System.Drawing.Size(265, 244)
        Me.picChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChar.TabIndex = 0
        Me.picChar.TabStop = False
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
        Me.rtxtNPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtNPC.Location = New System.Drawing.Point(307, 38)
        Me.rtxtNPC.Name = "rtxtNPC"
        Me.rtxtNPC.ReadOnly = True
        Me.rtxtNPC.Size = New System.Drawing.Size(331, 109)
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
        'grpInteract
        '
        Me.grpInteract.Controls.Add(Me.lblFollowers)
        Me.grpInteract.Controls.Add(Me.lblMoney)
        Me.grpInteract.Controls.Add(Me.btnAction6)
        Me.grpInteract.Controls.Add(Me.btnAction5)
        Me.grpInteract.Controls.Add(Me.btnAction4)
        Me.grpInteract.Controls.Add(Me.btnAction3)
        Me.grpInteract.Controls.Add(Me.btnAction2)
        Me.grpInteract.Controls.Add(Me.btnAction1)
        Me.grpInteract.Location = New System.Drawing.Point(2, 313)
        Me.grpInteract.Name = "grpInteract"
        Me.grpInteract.Size = New System.Drawing.Size(720, 144)
        Me.grpInteract.TabIndex = 5
        Me.grpInteract.TabStop = False
        Me.grpInteract.Text = "Interact"
        '
        'lblFollowers
        '
        Me.lblFollowers.AutoSize = True
        Me.lblFollowers.Location = New System.Drawing.Point(628, 0)
        Me.lblFollowers.Name = "lblFollowers"
        Me.lblFollowers.Size = New System.Drawing.Size(51, 13)
        Me.lblFollowers.TabIndex = 6
        Me.lblFollowers.Text = "Followers"
        Me.lblFollowers.Visible = False
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Location = New System.Drawing.Point(628, 0)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(39, 13)
        Me.lblMoney.TabIndex = 6
        Me.lblMoney.Text = "Money"
        Me.lblMoney.Visible = False
        '
        'btnAction6
        '
        Me.btnAction6.Location = New System.Drawing.Point(496, 85)
        Me.btnAction6.Name = "btnAction6"
        Me.btnAction6.Size = New System.Drawing.Size(201, 52)
        Me.btnAction6.TabIndex = 5
        Me.btnAction6.Text = "Action 6"
        Me.btnAction6.UseVisualStyleBackColor = True
        '
        'btnAction5
        '
        Me.btnAction5.Location = New System.Drawing.Point(496, 19)
        Me.btnAction5.Name = "btnAction5"
        Me.btnAction5.Size = New System.Drawing.Size(201, 52)
        Me.btnAction5.TabIndex = 4
        Me.btnAction5.Text = "Action 5"
        Me.btnAction5.UseVisualStyleBackColor = True
        '
        'btnAction4
        '
        Me.btnAction4.Location = New System.Drawing.Point(254, 85)
        Me.btnAction4.Name = "btnAction4"
        Me.btnAction4.Size = New System.Drawing.Size(201, 52)
        Me.btnAction4.TabIndex = 3
        Me.btnAction4.Text = "Action 4"
        Me.btnAction4.UseVisualStyleBackColor = True
        '
        'btnAction3
        '
        Me.btnAction3.Location = New System.Drawing.Point(254, 19)
        Me.btnAction3.Name = "btnAction3"
        Me.btnAction3.Size = New System.Drawing.Size(201, 52)
        Me.btnAction3.TabIndex = 2
        Me.btnAction3.Text = "Action 3"
        Me.btnAction3.UseVisualStyleBackColor = True
        '
        'btnAction2
        '
        Me.btnAction2.Location = New System.Drawing.Point(6, 85)
        Me.btnAction2.Name = "btnAction2"
        Me.btnAction2.Size = New System.Drawing.Size(201, 52)
        Me.btnAction2.TabIndex = 1
        Me.btnAction2.Text = "Action 2"
        Me.btnAction2.UseVisualStyleBackColor = True
        '
        'btnAction1
        '
        Me.btnAction1.Location = New System.Drawing.Point(6, 19)
        Me.btnAction1.Name = "btnAction1"
        Me.btnAction1.Size = New System.Drawing.Size(201, 52)
        Me.btnAction1.TabIndex = 0
        Me.btnAction1.Text = "Action 1"
        Me.btnAction1.UseVisualStyleBackColor = True
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 1
        '
        'tmrPause2
        '
        Me.tmrPause2.Interval = 2000
        '
        'tmrPause1
        '
        Me.tmrPause1.Interval = 1000
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Location = New System.Drawing.Point(599, 269)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(44, 13)
        Me.lblCounter.TabIndex = 6
        Me.lblCounter.Text = "Counter"
        '
        'frmConvo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 462)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.grpInteract)
        Me.Controls.Add(Me.lblNPCName)
        Me.Controls.Add(Me.rtxtNPC)
        Me.Controls.Add(Me.picChar)
        Me.Controls.Add(Me.picBack)
        Me.Name = "frmConvo"
        Me.Text = "Project Casius"
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInteract.ResumeLayout(False)
        Me.grpInteract.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picChar As PictureBox
    Friend WithEvents picBack As PictureBox
    Friend WithEvents rtxtNPC As RichTextBox
    Friend WithEvents lblNPCName As Label
    Friend WithEvents grpInteract As GroupBox
    Friend WithEvents btnAction6 As Button
    Friend WithEvents btnAction5 As Button
    Friend WithEvents btnAction4 As Button
    Friend WithEvents btnAction3 As Button
    Friend WithEvents btnAction2 As Button
    Friend WithEvents btnAction1 As Button
    Friend WithEvents lblMoney As Label
    Friend WithEvents lblFollowers As Label
    Friend WithEvents tmrUpdate As Timer
    Friend WithEvents tmrPause2 As Timer
    Friend WithEvents tmrPause1 As Timer
    Friend WithEvents lblCounter As Label
End Class
