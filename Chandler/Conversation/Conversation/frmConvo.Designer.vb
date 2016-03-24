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
        Me.grpInteract = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rtxtNPC = New System.Windows.Forms.RichTextBox()
        Me.lblNPCName = New System.Windows.Forms.Label()
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInteract.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'grpInteract
        '
        Me.grpInteract.Controls.Add(Me.Button1)
        Me.grpInteract.Location = New System.Drawing.Point(2, 307)
        Me.grpInteract.Name = "grpInteract"
        Me.grpInteract.Size = New System.Drawing.Size(726, 130)
        Me.grpInteract.TabIndex = 1
        Me.grpInteract.TabStop = False
        Me.grpInteract.Text = "Interact"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(725, 305)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
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
        'frmConvo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 443)
        Me.Controls.Add(Me.lblNPCName)
        Me.Controls.Add(Me.rtxtNPC)
        Me.Controls.Add(Me.grpInteract)
        Me.Controls.Add(Me.picChar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmConvo"
        Me.Text = "Project Casius"
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInteract.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picChar As PictureBox
    Friend WithEvents grpInteract As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rtxtNPC As RichTextBox
    Friend WithEvents lblNPCName As Label
End Class
