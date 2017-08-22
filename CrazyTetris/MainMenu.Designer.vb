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
        Me.StartButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.StartButton.BackColor = System.Drawing.Color.Black
        Me.StartButton.ForeColor = System.Drawing.Color.Gold
        Me.StartButton.Location = New System.Drawing.Point(0, 0)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(0)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(900, 150)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "(P)lay Game!"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'HighScoreButton
        '
        Me.HighScoreButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HighScoreButton.BackColor = System.Drawing.Color.Black
        Me.HighScoreButton.ForeColor = System.Drawing.Color.Gold
        Me.HighScoreButton.Location = New System.Drawing.Point(0, 150)
        Me.HighScoreButton.Margin = New System.Windows.Forms.Padding(0)
        Me.HighScoreButton.Name = "HighScoreButton"
        Me.HighScoreButton.Size = New System.Drawing.Size(450, 150)
        Me.HighScoreButton.TabIndex = 1
        Me.HighScoreButton.Text = "(H)igh Scores!"
        Me.HighScoreButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.BackColor = System.Drawing.Color.Black
        Me.ExitButton.ForeColor = System.Drawing.Color.Gold
        Me.ExitButton.Location = New System.Drawing.Point(450, 150)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(450, 150)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "(E)xit Game"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AcceptButton = Me.StartButton
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(900, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.HighScoreButton)
        Me.Controls.Add(Me.StartButton)
        Me.Font = New System.Drawing.Font("AR DARLING", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrazyTetris Main Menu"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents HighScoreButton As Button
    Friend WithEvents ExitButton As Button
End Class
