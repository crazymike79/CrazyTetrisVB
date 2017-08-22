Public Class MainMenu
    Inherits Form

    Property IsNewGame As Boolean
    Public Shared Game As New GameForm() With {.Visible = False}

    Private Sub OnInitialize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Console.WriteLine("Maybe Play music or something?")
        IsNewGame = True
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If IsNewGame = True Then
            Game.Dispose()
            Game = New GameForm With {.Visible = False}
            TetrisLogic.seed = DateAndTime.Now.Second
            TetrisLogic.randomPiece = New Random(TetrisLogic.seed)
            TetrisLogic.Initialize()
            IsNewGame = False
        End If
        Game.Visible = True
        Visible = False
    End Sub

    Private Sub HighScoreButton_Click(sender As Object, e As EventArgs) Handles HighScoreButton.Click
        Dim HighScores As New HighScoreForm() With {
            .Visible = True
        }
        Visible = False
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Environment.Exit(0)
    End Sub


End Class