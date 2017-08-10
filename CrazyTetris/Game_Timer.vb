Public Class Game_Timer
    Public Event Tick As EventHandler

    Protected Overridable Sub OnTick(e As EventArgs)
        RaiseEvent Tick(Me, e)
    End Sub


End Class
