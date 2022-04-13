<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmrStartBildschirm
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
        Me.pctStart = New System.Windows.Forms.PictureBox()
        CType(Me.pctStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctStart
        '
        Me.pctStart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pctStart.BackColor = System.Drawing.Color.Transparent
        Me.pctStart.Location = New System.Drawing.Point(400, 457)
        Me.pctStart.Name = "pctStart"
        Me.pctStart.Size = New System.Drawing.Size(141, 154)
        Me.pctStart.TabIndex = 0
        Me.pctStart.TabStop = False
        '
        'FmrStartBildschirm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Castlemania.My.Resources.Resources.Main
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1028, 649)
        Me.Controls.Add(Me.pctStart)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FmrStartBildschirm"
        Me.Text = "Castlemania"
        CType(Me.pctStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctStart As PictureBox
End Class
