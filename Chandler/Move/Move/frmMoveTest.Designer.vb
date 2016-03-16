<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMoveTest
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
        Me.picTrigger = New System.Windows.Forms.PictureBox()
        Me.picAvatar = New System.Windows.Forms.PictureBox()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picTrigger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTrigger
        '
        Me.picTrigger.Image = Global.Move.My.Resources.Resources.Davis_Chandler
        Me.picTrigger.Location = New System.Drawing.Point(344, 32)
        Me.picTrigger.Name = "picTrigger"
        Me.picTrigger.Size = New System.Drawing.Size(80, 72)
        Me.picTrigger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTrigger.TabIndex = 1
        Me.picTrigger.TabStop = False
        '
        'picAvatar
        '
        Me.picAvatar.Image = Global.Move.My.Resources.Resources.Untitled_2
        Me.picAvatar.Location = New System.Drawing.Point(184, 192)
        Me.picAvatar.Name = "picAvatar"
        Me.picAvatar.Size = New System.Drawing.Size(80, 72)
        Me.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAvatar.TabIndex = 0
        Me.picAvatar.TabStop = False
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Interval = 1
        '
        'frmMoveTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 406)
        Me.Controls.Add(Me.picAvatar)
        Me.Controls.Add(Me.picTrigger)
        Me.Name = "frmMoveTest"
        Me.Text = "MoveTest"
        CType(Me.picTrigger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picAvatar As System.Windows.Forms.PictureBox
    Friend WithEvents picTrigger As System.Windows.Forms.PictureBox
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer

End Class
