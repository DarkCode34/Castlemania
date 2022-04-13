<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmrCharakterAuswahl
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.OptChar1 = New System.Windows.Forms.RadioButton()
        Me.OptChar2 = New System.Windows.Forms.RadioButton()
        Me.OptChar3 = New System.Windows.Forms.RadioButton()
        Me.pctChar1 = New System.Windows.Forms.PictureBox()
        Me.pctChar2 = New System.Windows.Forms.PictureBox()
        Me.pctChar3 = New System.Windows.Forms.PictureBox()
        Me.tmrAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pctChar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctChar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctChar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OptChar1
        '
        Me.OptChar1.AutoSize = True
        Me.OptChar1.Location = New System.Drawing.Point(92, 348)
        Me.OptChar1.Name = "OptChar1"
        Me.OptChar1.Size = New System.Drawing.Size(82, 24)
        Me.OptChar1.TabIndex = 0
        Me.OptChar1.TabStop = True
        Me.OptChar1.Text = "Gandalf"
        Me.OptChar1.UseVisualStyleBackColor = True
        '
        'OptChar2
        '
        Me.OptChar2.AutoSize = True
        Me.OptChar2.Location = New System.Drawing.Point(339, 348)
        Me.OptChar2.Name = "OptChar2"
        Me.OptChar2.Size = New System.Drawing.Size(69, 24)
        Me.OptChar2.TabIndex = 1
        Me.OptChar2.TabStop = True
        Me.OptChar2.Text = "Mario"
        Me.OptChar2.UseVisualStyleBackColor = True
        '
        'OptChar3
        '
        Me.OptChar3.AutoSize = True
        Me.OptChar3.Location = New System.Drawing.Point(570, 348)
        Me.OptChar3.Name = "OptChar3"
        Me.OptChar3.Size = New System.Drawing.Size(109, 24)
        Me.OptChar3.TabIndex = 2
        Me.OptChar3.TabStop = True
        Me.OptChar3.Text = "Harry Potter"
        Me.OptChar3.UseVisualStyleBackColor = True
        '
        'pctChar1
        '
        Me.pctChar1.BackColor = System.Drawing.Color.Transparent
        Me.pctChar1.Location = New System.Drawing.Point(92, 112)
        Me.pctChar1.Name = "pctChar1"
        Me.pctChar1.Size = New System.Drawing.Size(142, 216)
        Me.pctChar1.TabIndex = 3
        Me.pctChar1.TabStop = False
        '
        'pctChar2
        '
        Me.pctChar2.BackColor = System.Drawing.Color.Transparent
        Me.pctChar2.Location = New System.Drawing.Point(329, 117)
        Me.pctChar2.Name = "pctChar2"
        Me.pctChar2.Size = New System.Drawing.Size(142, 216)
        Me.pctChar2.TabIndex = 4
        Me.pctChar2.TabStop = False
        '
        'pctChar3
        '
        Me.pctChar3.BackColor = System.Drawing.Color.Transparent
        Me.pctChar3.Location = New System.Drawing.Point(570, 112)
        Me.pctChar3.Name = "pctChar3"
        Me.pctChar3.Size = New System.Drawing.Size(142, 216)
        Me.pctChar3.TabIndex = 5
        Me.pctChar3.TabStop = False
        '
        'tmrAnimation
        '
        Me.tmrAnimation.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'FmrCharakterAuswahl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Castlemania.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pctChar3)
        Me.Controls.Add(Me.pctChar2)
        Me.Controls.Add(Me.pctChar1)
        Me.Controls.Add(Me.OptChar3)
        Me.Controls.Add(Me.OptChar2)
        Me.Controls.Add(Me.OptChar1)
        Me.DoubleBuffered = True
        Me.Name = "FmrCharakterAuswahl"
        Me.Text = "CharakterAuswahl"
        CType(Me.pctChar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctChar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctChar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OptChar1 As RadioButton
    Friend WithEvents OptChar2 As RadioButton
    Friend WithEvents OptChar3 As RadioButton
    Friend WithEvents pctChar1 As PictureBox
    Friend WithEvents pctChar2 As PictureBox
    Friend WithEvents pctChar3 As PictureBox
    Friend WithEvents tmrAnimation As Timer
    Friend WithEvents Label1 As Label
End Class
