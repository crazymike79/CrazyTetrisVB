Imports System.Collections.ObjectModel

Public Class GameForm
    Inherits Form

    Dim TickCount As Integer = 0
    Dim WithEvents Tick_Timer As New Timer() With {.Interval = 500}
    Friend gameIsRunning As Boolean = True



    Protected Overridable Sub OnInitialize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        'Visible = True
        Tick_Timer.Start()
        GameFormRows.Add(ScoreBox)
        GameFormRows.Add(My.Resources.gameback)
        GameFormRows.Add(MenuButton)
        ScoreBox.Add(My.Resources.ScoreBoxEmpty)
        ScoreBox.Add(My.Resources.ScoreBoxEmpty)
        ScoreBox.Add(My.Resources.ScoreBoxEmpty)

    End Sub

    Protected Overridable Sub OnTimer_Tick(sender As Object, e As EventArgs) Handles Tick_Timer.Tick
        Console.Beep()
    End Sub

    Friend Level As Integer
    Friend Score As Integer
    Friend NextPiece As Image
    Dim MenuButton As New Button() With {.Text = "Exit To Main Menu"}
    Dim ScoreBox As New Collection(Of Image)
    Dim GameFormRows As New Collection()

    Private Sub GameLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles GameLayoutPanel.Paint

    End Sub

End Class