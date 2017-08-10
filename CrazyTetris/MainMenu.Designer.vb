<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.StartButton = New System.Windows.Forms.Button()
        Me.HighScoreButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Black
        Me.StartButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.StartButton.ForeColor = System.Drawing.Color.Gold
        Me.StartButton.Location = New System.Drawing.Point(0, 0)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(1168, 200)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "(P)lay Game!"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'HighScoreButton
        '
        Me.HighScoreButton.BackColor = System.Drawing.Color.Black
        Me.HighScoreButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.HighScoreButton.ForeColor = System.Drawing.Color.Gold
        Me.HighScoreButton.Location = New System.Drawing.Point(0, 200)
        Me.HighScoreButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.HighScoreButton.Name = "HighScoreButton"
        Me.HighScoreButton.Size = New System.Drawing.Size(585, 112)
        Me.HighScoreButton.TabIndex = 1
        Me.HighScoreButton.Text = "(Hi)gh Scores!"
        Me.HighScoreButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Black
        Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExitButton.ForeColor = System.Drawing.Color.Gold
        Me.ExitButton.Location = New System.Drawing.Point(583, 200)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(585, 112)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "(E)xit Game"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(24.0!, 49.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1168, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.HighScoreButton)
        Me.Controls.Add(Me.StartButton)
        Me.Font = New System.Drawing.Font("AR DARLING", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "MainMenu"
        Me.Text = "CrazyTetris Main Menu"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents HighScoreButton As Button
    Friend WithEvents ExitButton As Button
End Class
