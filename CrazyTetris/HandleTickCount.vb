Public Class HandleTickCount

    'Public Shared needspaint As Boolean

    '~~~~~

    Shared Sub DoStep()
        Dim tc As Integer = MainMenu.Game.TickCount

        tc += 1

        Select Case tc
            Case 5
                MainMenu.Game.GameBox.BackgroundImage = My.Resources._8
                Console.Beep()
            Case 10
                MainMenu.Game.GameBox.BackgroundImage = My.Resources._7
                Console.Beep()
            Case 15
                MainMenu.Game.GameBox.BackgroundImage = My.Resources._6
                Console.Beep()
            Case 20
                MainMenu.Game.GameBox.BackgroundImage = My.Resources._5
                Console.Beep()
            Case 25
                MainMenu.Game.GameBox.BackgroundImage = My.Resources._4
                Console.Beep()
            Case 30
                MainMenu.Game.GameBox.BackgroundImage = My.Resources._3
                Console.Beep()
            Case 35
                MainMenu.Game.GameBox.BackgroundImage = My.Resources._2
                Console.Beep()
            Case 40
                MainMenu.Game.GameBox.BackgroundImage = My.Resources._1
                Console.Beep()
            Case 45
                MainMenu.Game.GameBox.BackgroundImage = My.Resources._0
                Console.Beep()
            Case 50 : MainMenu.Game.GameBox.BackgroundImage = Nothing
            Case Else
                Exit Select
        End Select

        If tc > 50 Then RunGameStep()
    End Sub

    '~~~~~

    Shared Sub RunGameStep()
        MainMenu.Game.GameIsRunning = True
        'MainMenu.Game.GameBox.Hide()
        'Check if piece is ready to be moved down
        If TetrisLogic.newpiece = False _
            And TetrisLogic.needpiece = False _
            Then TetrisLogic.movepiece = True

        MainMenu.Game.GameTickCount += 1

        'DEBUG: Print GameTickCount and NextPieceList
        Console.WriteLine("GameTickCount: " + CStr(MainMenu.Game.GameTickCount))
        Console.WriteLine("Next piece collection: " + TetrisLogic.NextPieceList.ToString)
        Dim index As New Integer
        index = 1
        For index = 1 To 3
            Console.Write(TetrisLogic.NextPieceList.Item(index).ToString)
        Next
        Console.WriteLine()
        'END DEBUG

        'Check if newpiece needs regen, take the top piece off list and add new item
        If TetrisLogic.needpiece = True _
            And Not TetrisLogic.needpiece = vbNull Then
            TetrisLogic.PieceNum = TetrisLogic.NextPieceList.Item(1)
            TetrisLogic.NextPieceList.Remove(1)
            TetrisLogic.NextPieceNum = TetrisLogic.randomPiece.Next(1, 8)
            TetrisLogic.NextPieceList.Add(TetrisLogic.NextPieceNum)
            NextPieceNumToOverlay()

            TetrisLogic.newpiece = True
            TetrisLogic.needpiece = False
        End If

        'Check if PieceNum is new and place it at top of board
        If TetrisLogic.newpiece = True Then
            TetrisLogic.PieceNumToPieceMap()
            TetrisLogic.GameboardToPieceboard()
            TetrisLogic.PiecemapToPieceboard()
            TetrisLogic.newpiece = False
            MainMenu.Game.GameBox.Refresh()
            Exit Sub
            'needspaint = True
        End If

        'Check if piece is ready to be moved down and move it
        If TetrisLogic.movepiece = True Then
            MovePieceDown()
            TetrisLogic.movepiece = False
            MainMenu.Game.GameBox.Refresh()
            Exit Sub
        End If

        'DEBUG: Print all boolean variables
        Console.WriteLine($"newpiece: {TetrisLogic.newpiece} needpiece: {TetrisLogic.needpiece} movepiece: {TetrisLogic.movepiece}")

        'Cause GameBox to update graphics
        'MainMenu.Game.GameBox.Show()
    End Sub

    '****



    Shared Sub NextPieceNumToOverlay()
        Select Case TetrisLogic.NextPieceNum
            Case 1 : MainMenu.Game.NextPieceOverlay.Image = My.Resources.leftL

            Case 2 : MainMenu.Game.NextPieceOverlay.Image = My.Resources.square

            Case 3 : MainMenu.Game.NextPieceOverlay.Image = My.Resources.Tee

            Case 4 : MainMenu.Game.NextPieceOverlay.Image = My.Resources.rightZ

            Case 5 : MainMenu.Game.NextPieceOverlay.Image = My.Resources.Ibeam

            Case 6 : MainMenu.Game.NextPieceOverlay.Image = My.Resources.leftZ

            Case 7 : MainMenu.Game.NextPieceOverlay.Image = My.Resources.rightL
        End Select
    End Sub

    Shared Sub MovePieceDown()

    End Sub
End Class
