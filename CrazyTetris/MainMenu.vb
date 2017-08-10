Public Class MainMenu
    Inherits Form

    Private Sub OnInitialize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        'Maybe Play music or something?
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Dim GameBoard As New GameForm() With {
            .Visible = True
        }
        Visible = False
    End Sub

    Private Sub HighScoreButton_Click(sender As Object, e As EventArgs) Handles HighScoreButton.Click
        Dim HighScores As New HighScoreForm() With {
            .Visible = True
        }
        Me.Visible = False
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ExitGame()
    End Sub

    Public Sub ExitGame()
        GameForm.gameIsRunning = False
        Environment.Exit(0)
    End Sub
End Class