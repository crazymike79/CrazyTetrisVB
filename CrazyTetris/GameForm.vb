Imports System.Collections.ObjectModel

Public Class GameForm
        Inherits Form

    '~~~~VARIABLES~~~~

    Property TickCount As Integer
    Property GameTickCount As Integer
    Public GameIsRunning As New Boolean
    Dim WithEvents Tick_Timer As New Timer() With {.Interval = 200}
    Shared g As Graphics
    Public DrawBitmap As New Bitmap(300, 600)


    '~~~~EVENTS~~~~

    Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
        End Sub

        '~~~~~

        Protected Overridable Sub MenuButton_Click(
                                              sender As Object,
                                              e As EventArgs) _
                                              Handles MenuButton.Click
            MainMenu.Visible = True
            Visible = False
        End Sub

        '~~~~~

        Protected Overridable Sub OnInitialize(
                                          sender As Object,
                                          e As EventArgs) _
                                          Handles Me.Load

            GameBox.BringToFront()
            If TickCount = 0 Then GameBox.BackgroundImage = My.Resources._9
            Tick_Timer.Start()
            Console.Beep()
        End Sub

        '~~~~~

        Protected Overridable Sub OnVisible(
                                       sender As Object,
                                       e As EventArgs) _
                                       Handles Me.VisibleChanged
            If sender.Visible = True Then
                Tick_Timer.Start()
                GameIsRunning = True
            End If
            If sender.Visible = False Then
                Tick_Timer.Stop()
                GameIsRunning = False
            End If
        End Sub

        '~~~~~

        Protected Overridable Sub OnGamePanelClose(
                                              sender As Object,
                                              e As EventArgs) _
                                              Handles Me.FormClosed
            ChunkUpdater.CancelAsync()
            Tick_Timer.Stop()
            TickCount = 0
            MainMenu.IsNewGame = True
            MainMenu.Visible = True
        End Sub

        '~~~~~

        Protected Overridable Sub OnTimer_Tick(
                                          sender As Object,
                                          e As EventArgs) _
                                          Handles Tick_Timer.Tick
            If GameIsRunning = False Then
                Close()
            End If
            TickCount += 1
            MainMenu.Game.ScoreNumOverlay.Text = TetrisLogic.Score
            MainMenu.Game.LevelNumOverlay.Text = TetrisLogic.Level
            If ChunkUpdater.IsBusy = False Then _
                 ChunkUpdater.RunWorkerAsync()
            HandleTickCount.DoStep()
        End Sub

        '~~~~~

        Private Sub ChunkUpdater_DoWork(
                                   sender As Object,
                                   e As System.ComponentModel.DoWorkEventArgs) _
                                   Handles ChunkUpdater.DoWork
            Dim worker As System.ComponentModel.BackgroundWorker
            worker = CType(sender, System.ComponentModel.BackgroundWorker)
            TetrisLogic.ChunkUpdate(worker, e)
        End Sub

    '~~~~~

    'Private Sub GameBox_Paint(sender As Object, e As PaintEventArgs) Handles GameBox.Paint
    '    g = e.Graphics
    'Dim DrawBitmap As New Bitmap(300, 600)
    'Dim i As Integer
    'Dim j As Integer
    'Dim L = TetrisLogic.pieceboard.GetLength(0)
    'Dim W = TetrisLogic.pieceboard.GetLength(1)
    'Dim LU = TetrisLogic.pieceboard.GetLength(0) - 1
    'Dim LL = TetrisLogic.pieceboard.GetLength(0) - TetrisLogic.pieceboard.GetLength(0)
    'Dim WU = TetrisLogic.pieceboard.GetLength(1) - 1
    'Dim WL = TetrisLogic.pieceboard.GetLength(1) - TetrisLogic.pieceboard.GetLength(1)

    'For j = WL To WU
    '    For i = LL To LU
    '        If j >= 4 Then
    '            Dim p As New Point(i * 30, (j - 4) * 30)
    '            TetrisLogic.ChunkIndex = CUInt(TetrisLogic.pieceboard.GetValue(i, j))
    '            Dim ChunkBitmap As New Bitmap(TetrisLogic.ChunkImage)
    '            Dim pt As New Point(0, 0)
    '            Dim color As New Color
    '            Dim rect As RectangleF = TetrisLogic.ChunkImage.GetBounds(GraphicsUnit.Pixel)

    '            For y = rect.Y To rect.Height
    '                For x = rect.X To rect.Width
    '                    color = ChunkBitmap.GetPixel(pt.X, pt.Y)
    '                    DrawBitmap.SetPixel(p.X + pt.X, p.Y + pt.Y, color)
    '                Next
    '            Next
    '            'DEBUG: Confirm ChunkIndex and p after image drawing
    '            Console.WriteLine _
    '                ($"~~~~Drew Image {TetrisLogic.ChunkIndex} to GameBox at location {p}~~~~") 'DEBUG
    '        End If
    '    Next
    'Next
    'End Sub

    Sub MakeDrawBitmap()
        Dim DrawBitmap As New Bitmap(300, 600)
        Dim i As Integer
        Dim j As Integer
        Dim L = TetrisLogic.pieceboard.GetLength(0)
        Dim W = TetrisLogic.pieceboard.GetLength(1)
        Dim LU = TetrisLogic.pieceboard.GetLength(0) - 1
        Dim LL = TetrisLogic.pieceboard.GetLength(0) - TetrisLogic.pieceboard.GetLength(0)
        Dim WU = TetrisLogic.pieceboard.GetLength(1) - 1
        Dim WL = TetrisLogic.pieceboard.GetLength(1) - TetrisLogic.pieceboard.GetLength(1)

        For j = WL To WU
            For i = LL To LU
                If j > 1 Then
                    Dim p As New Point(i * 30, (j - 2) * 30)
                    TetrisLogic.ChunkIndex = CUInt(TetrisLogic.pieceboard.GetValue(i, j))
                    Dim ChunkBitmap As New Bitmap(TetrisLogic.ChunkImage)
                    'Dim pt As New Point(0, 0)
                    Dim color As New Color
                    Dim rect As RectangleF = TetrisLogic.ChunkImage.GetBounds(GraphicsUnit.Pixel)
                    Dim x, y As New Integer
                    x = rect.X
                    y = rect.Y

                    For y = rect.Y To (rect.Height - 1)
                        For x = rect.X To (rect.Width - 1)
                            color = ChunkBitmap.GetPixel(x, y)
                            DrawBitmap.SetPixel(p.X + x, p.Y + y, color)
                            'Console.WriteLine($"Drew pixel ({p.X + x}, {p.Y + y}) the color {color}.")
                        Next
                    Next
                    Console.WriteLine _
                    ($"~~~~Drew Image {ChunkBitmap} to DrawBitmap at location {p}~~~~") 'DEBUG
                End If
            Next
        Next
        'DEBUG: 
        Console.WriteLine($"DrawBitmap Bounds: {DrawBitmap.GetBounds(GraphicsUnit.Pixel)}")
        GameBox.Image = DrawBitmap
        Console.WriteLine("Image Set!!!")
    End Sub
End Class
