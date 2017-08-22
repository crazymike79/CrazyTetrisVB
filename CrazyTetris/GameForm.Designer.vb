<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameForm
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
        Me.GameLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.NextBox = New System.Windows.Forms.Panel()
        Me.NextLabelOverlay = New System.Windows.Forms.Label()
        Me.NextPieceOverlay = New System.Windows.Forms.PictureBox()
        Me.ScoreBox = New System.Windows.Forms.Panel()
        Me.ScoreOverlay = New System.Windows.Forms.Label()
        Me.ScoreNumOverlay = New System.Windows.Forms.Label()
        Me.LevelBox = New System.Windows.Forms.Panel()
        Me.LevelNumOverlay = New System.Windows.Forms.Label()
        Me.LevelOverlay = New System.Windows.Forms.Label()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.GamePanel = New System.Windows.Forms.Panel()
        Me.GameBox = New System.Windows.Forms.PictureBox()
        Me.ChunkUpdater = New System.ComponentModel.BackgroundWorker()
        Me.GameLayoutPanel.SuspendLayout()
        Me.NextBox.SuspendLayout()
        CType(Me.NextPieceOverlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ScoreBox.SuspendLayout()
        Me.LevelBox.SuspendLayout()
        Me.GamePanel.SuspendLayout()
        CType(Me.GameBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GameLayoutPanel
        '
        Me.GameLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GameLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.GameLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameLayoutPanel.ColumnCount = 3
        Me.GameLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.GameLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.GameLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.GameLayoutPanel.Controls.Add(Me.NextBox, 1, 0)
        Me.GameLayoutPanel.Controls.Add(Me.ScoreBox, 2, 0)
        Me.GameLayoutPanel.Controls.Add(Me.LevelBox, 0, 0)
        Me.GameLayoutPanel.Controls.Add(Me.MenuButton, 0, 2)
        Me.GameLayoutPanel.Controls.Add(Me.GamePanel, 0, 1)
        Me.GameLayoutPanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.GameLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.GameLayoutPanel.Margin = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.GameLayoutPanel.Name = "GameLayoutPanel"
        Me.GameLayoutPanel.RowCount = 3
        Me.GameLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.GameLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600.0!))
        Me.GameLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.GameLayoutPanel.Size = New System.Drawing.Size(300, 680)
        Me.GameLayoutPanel.TabIndex = 0
        '
        'NextBox
        '
        Me.NextBox.BackgroundImage = Global.CrazyTetris.My.Resources.Resources.ScoreBoxEmpty
        Me.NextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NextBox.Controls.Add(Me.NextLabelOverlay)
        Me.NextBox.Controls.Add(Me.NextPieceOverlay)
        Me.NextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.NextBox.Location = New System.Drawing.Point(100, 0)
        Me.NextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.NextBox.Name = "NextBox"
        Me.NextBox.Size = New System.Drawing.Size(100, 40)
        Me.NextBox.TabIndex = 4
        '
        'NextLabelOverlay
        '
        Me.NextLabelOverlay.Dock = System.Windows.Forms.DockStyle.Top
        Me.NextLabelOverlay.Font = New System.Drawing.Font("AR DARLING", 8.099999!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextLabelOverlay.Location = New System.Drawing.Point(0, 0)
        Me.NextLabelOverlay.Margin = New System.Windows.Forms.Padding(0)
        Me.NextLabelOverlay.Name = "NextLabelOverlay"
        Me.NextLabelOverlay.Size = New System.Drawing.Size(100, 15)
        Me.NextLabelOverlay.TabIndex = 1
        Me.NextLabelOverlay.Text = "Next Piece"
        Me.NextLabelOverlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.NextLabelOverlay.UseMnemonic = False
        '
        'NextPieceOverlay
        '
        Me.NextPieceOverlay.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NextPieceOverlay.Image = Global.CrazyTetris.My.Resources.Resources.blank_block
        Me.NextPieceOverlay.Location = New System.Drawing.Point(0, 15)
        Me.NextPieceOverlay.Margin = New System.Windows.Forms.Padding(0)
        Me.NextPieceOverlay.Name = "NextPieceOverlay"
        Me.NextPieceOverlay.Size = New System.Drawing.Size(100, 25)
        Me.NextPieceOverlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.NextPieceOverlay.TabIndex = 0
        Me.NextPieceOverlay.TabStop = False
        '
        'ScoreBox
        '
        Me.ScoreBox.BackgroundImage = Global.CrazyTetris.My.Resources.Resources.ScoreBoxEmpty
        Me.ScoreBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ScoreBox.Controls.Add(Me.ScoreOverlay)
        Me.ScoreBox.Controls.Add(Me.ScoreNumOverlay)
        Me.ScoreBox.Location = New System.Drawing.Point(200, 0)
        Me.ScoreBox.Margin = New System.Windows.Forms.Padding(0)
        Me.ScoreBox.Name = "ScoreBox"
        Me.ScoreBox.Size = New System.Drawing.Size(100, 40)
        Me.ScoreBox.TabIndex = 5
        '
        'ScoreOverlay
        '
        Me.ScoreOverlay.Dock = System.Windows.Forms.DockStyle.Top
        Me.ScoreOverlay.Font = New System.Drawing.Font("AR DARLING", 9.900001!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreOverlay.Location = New System.Drawing.Point(0, 0)
        Me.ScoreOverlay.Margin = New System.Windows.Forms.Padding(0)
        Me.ScoreOverlay.Name = "ScoreOverlay"
        Me.ScoreOverlay.Size = New System.Drawing.Size(100, 20)
        Me.ScoreOverlay.TabIndex = 0
        Me.ScoreOverlay.Text = "Score"
        Me.ScoreOverlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ScoreOverlay.UseMnemonic = False
        '
        'ScoreNumOverlay
        '
        Me.ScoreNumOverlay.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ScoreNumOverlay.Font = New System.Drawing.Font("AR DARLING", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreNumOverlay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ScoreNumOverlay.Location = New System.Drawing.Point(0, 20)
        Me.ScoreNumOverlay.Margin = New System.Windows.Forms.Padding(0)
        Me.ScoreNumOverlay.Name = "ScoreNumOverlay"
        Me.ScoreNumOverlay.Size = New System.Drawing.Size(100, 20)
        Me.ScoreNumOverlay.TabIndex = 1
        Me.ScoreNumOverlay.Text = "000,000,000"
        Me.ScoreNumOverlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LevelBox
        '
        Me.LevelBox.BackgroundImage = Global.CrazyTetris.My.Resources.Resources.ScoreBoxEmpty
        Me.LevelBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LevelBox.Controls.Add(Me.LevelNumOverlay)
        Me.LevelBox.Controls.Add(Me.LevelOverlay)
        Me.LevelBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.LevelBox.Location = New System.Drawing.Point(0, 0)
        Me.LevelBox.Margin = New System.Windows.Forms.Padding(0)
        Me.LevelBox.Name = "LevelBox"
        Me.LevelBox.Size = New System.Drawing.Size(100, 40)
        Me.LevelBox.TabIndex = 1
        '
        'LevelNumOverlay
        '
        Me.LevelNumOverlay.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LevelNumOverlay.Font = New System.Drawing.Font("AR DARLING", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelNumOverlay.Location = New System.Drawing.Point(0, 20)
        Me.LevelNumOverlay.Margin = New System.Windows.Forms.Padding(0)
        Me.LevelNumOverlay.Name = "LevelNumOverlay"
        Me.LevelNumOverlay.Size = New System.Drawing.Size(100, 20)
        Me.LevelNumOverlay.TabIndex = 1
        Me.LevelNumOverlay.Text = "00"
        Me.LevelNumOverlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LevelNumOverlay.UseMnemonic = False
        '
        'LevelOverlay
        '
        Me.LevelOverlay.Dock = System.Windows.Forms.DockStyle.Top
        Me.LevelOverlay.Font = New System.Drawing.Font("AR DARLING", 9.900001!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelOverlay.Location = New System.Drawing.Point(0, 0)
        Me.LevelOverlay.Margin = New System.Windows.Forms.Padding(0)
        Me.LevelOverlay.Name = "LevelOverlay"
        Me.LevelOverlay.Size = New System.Drawing.Size(100, 20)
        Me.LevelOverlay.TabIndex = 0
        Me.LevelOverlay.Text = "Level"
        Me.LevelOverlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LevelOverlay.UseMnemonic = False
        '
        'MenuButton
        '
        Me.MenuButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GameLayoutPanel.SetColumnSpan(Me.MenuButton, 3)
        Me.MenuButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MenuButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuButton.Font = New System.Drawing.Font("AR DARLING", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuButton.Location = New System.Drawing.Point(0, 640)
        Me.MenuButton.Margin = New System.Windows.Forms.Padding(0)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(300, 40)
        Me.MenuButton.TabIndex = 7
        Me.MenuButton.Text = "Main Menu"
        Me.MenuButton.UseVisualStyleBackColor = False
        '
        'GamePanel
        '
        Me.GamePanel.BackgroundImage = Global.CrazyTetris.My.Resources.Resources.gameback
        Me.GamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameLayoutPanel.SetColumnSpan(Me.GamePanel, 3)
        Me.GamePanel.Controls.Add(Me.GameBox)
        Me.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GamePanel.Location = New System.Drawing.Point(0, 40)
        Me.GamePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.GamePanel.Name = "GamePanel"
        Me.GamePanel.Size = New System.Drawing.Size(300, 600)
        Me.GamePanel.TabIndex = 8
        '
        'GameBox
        '
        Me.GameBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GameBox.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.GameBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GameBox.Location = New System.Drawing.Point(0, 0)
        Me.GameBox.Margin = New System.Windows.Forms.Padding(0)
        Me.GameBox.Name = "GameBox"
        Me.GameBox.Size = New System.Drawing.Size(300, 600)
        Me.GameBox.TabIndex = 0
        Me.GameBox.TabStop = False
        Me.GameBox.UseWaitCursor = True
        Me.GameBox.WaitOnLoad = True
        '
        'ChunkUpdater
        '
        Me.ChunkUpdater.WorkerReportsProgress = True
        Me.ChunkUpdater.WorkerSupportsCancellation = True
        '
        'GameForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.MenuButton
        Me.ClientSize = New System.Drawing.Size(300, 680)
        Me.ControlBox = False
        Me.Controls.Add(Me.GameLayoutPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GameForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrazyTetris"
        Me.TopMost = True
        Me.GameLayoutPanel.ResumeLayout(False)
        Me.NextBox.ResumeLayout(False)
        CType(Me.NextPieceOverlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ScoreBox.ResumeLayout(False)
        Me.LevelBox.ResumeLayout(False)
        Me.GamePanel.ResumeLayout(False)
        CType(Me.GameBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GameLayoutPanel As TableLayoutPanel
    Friend WithEvents LevelBox As Panel
    Friend WithEvents ScoreBox As Panel
    Friend WithEvents MenuButton As Button
    Friend WithEvents NextBox As Panel
    Friend WithEvents NextPieceOverlay As PictureBox
    Friend WithEvents ScoreOverlay As Label
    Friend WithEvents LevelOverlay As Label
    Friend WithEvents ScoreNumOverlay As Label
    Friend WithEvents NextLabelOverlay As Label
    Public WithEvents LevelNumOverlay As Label
    Friend WithEvents ChunkUpdater As System.ComponentModel.BackgroundWorker
    Protected Friend WithEvents GamePanel As Panel
    Friend WithEvents GameBox As PictureBox
    'Friend WithEvents ScoreBox As PictureBox
End Class
