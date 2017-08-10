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
        Me.SuspendLayout()
        '
        'GameLayoutPanel
        '
        Me.GameLayoutPanel.AutoSize = True
        Me.GameLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GameLayoutPanel.ColumnCount = 3
        Me.GameLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GameLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GameLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GameLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GameLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.GameLayoutPanel.Name = "GameLayoutPanel"
        Me.GameLayoutPanel.RowCount = 3
        Me.GameLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.GameLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 720.0!))
        Me.GameLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.GameLayoutPanel.Size = New System.Drawing.Size(364, 628)
        Me.GameLayoutPanel.TabIndex = 0
        '
        'GameForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(364, 628)
        Me.Controls.Add(Me.GameLayoutPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "GameForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrazyTetris"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GameLayoutPanel As TableLayoutPanel
End Class
