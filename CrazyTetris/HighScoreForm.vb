Public Class HighScoreForm
    Inherits Form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        MainMenu.Visible = True
        Close()
    End Sub

    Private Sub HighScoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class