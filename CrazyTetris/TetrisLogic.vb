Public Class TetrisLogic

    Public Shared gameboard(9, 23) As UInteger
    Public Shared pieceboard(9, 23) As UInteger

    Public Shared piecemap(1, 3) As UInteger
    Public Shared rightEll(1, 3) As UInteger
    Public Shared leftEll(1, 3) As UInteger
    Public Shared square(1, 3) As UInteger
    Public Shared tee(1, 3) As UInteger
    Public Shared rightZee(1, 3) As UInteger
    Public Shared leftZee(1, 3) As UInteger
    Public Shared iBeam(1, 3) As UInteger

    Public Shared seed As New UInteger
    Public Shared randomPiece As New Random(seed)
    Public Shared Level As Integer
    Public Shared Score As Integer
    Public Shared InitPieceNum As Integer
    Public Shared NextPieceNum As UInteger
    Public Shared PieceNum As Integer

    Public Shared ChunkIndex As New UInteger

    Public Shared ChunkImage As Image
    Public Shared NextPieceList As New Collection

    Public Shared needpiece As Boolean
    Public Shared newpiece As New Boolean
    Public Shared movepiece As New Boolean

    '~~~~

    Public Shared Sub Initialize()
        ChunkIndex = 0
        ChunkImage = My.Resources.blank_block
        InitPieceNum = randomPiece.Next(1, 8)
        NextPieceNum = InitPieceNum
        '----
        gameboard.Initialize()
        piecemap.Initialize()
        DefinePieces()

        Dim index = 0
        For index = 0 To 4
            NextPieceList.Add(NextPieceNum)
            NextPieceNum = randomPiece.Next(1, 8)
            index += 1
        Next

        newpiece = True
        needpiece = True
    End Sub

    '****

    Public Shared Sub ChunkUpdate(
                                 ByVal worker As System.ComponentModel.BackgroundWorker,
                                 ByVal e As System.ComponentModel.DoWorkEventArgs)
        Do While MainMenu.Game.GameIsRunning = True
            If ChunkIndex = 0 Then ChunkImage = My.Resources.blank_block
            If ChunkIndex = 1 Then ChunkImage = My.Resources.redblock
            If ChunkIndex = 2 Then ChunkImage = My.Resources.yellowblock
            If ChunkIndex = 3 Then ChunkImage = My.Resources.purpleblock
            If ChunkIndex = 4 Then ChunkImage = My.Resources.orangeblock
            If ChunkIndex = 5 Then ChunkImage = My.Resources.greenblock
            If ChunkIndex = 6 Then ChunkImage = My.Resources.cyanblock
            If ChunkIndex = 7 Then ChunkImage = My.Resources.blueblock
        Loop
    End Sub

    '~~~~~~

    Public Shared Sub PieceNumToPieceMap()
        piecemap.Initialize()

        Select Case PieceNum
            Case 1
                piecemap.SetValue(leftEll.GetValue(0, 0), 0, 0)
                piecemap.SetValue(leftEll.GetValue(0, 1), 0, 1)
                piecemap.SetValue(leftEll.GetValue(0, 2), 0, 2)
                piecemap.SetValue(leftEll.GetValue(0, 3), 0, 3)
                piecemap.SetValue(leftEll.GetValue(1, 0), 1, 0)
                piecemap.SetValue(leftEll.GetValue(1, 1), 1, 1)
                piecemap.SetValue(leftEll.GetValue(1, 2), 1, 2)
                piecemap.SetValue(leftEll.GetValue(1, 3), 1, 3)
            Case 2
                piecemap.SetValue(square.GetValue(0, 0), 0, 0)
                piecemap.SetValue(square.GetValue(0, 1), 0, 1)
                piecemap.SetValue(square.GetValue(0, 2), 0, 2)
                piecemap.SetValue(square.GetValue(0, 3), 0, 3)
                piecemap.SetValue(square.GetValue(1, 0), 1, 0)
                piecemap.SetValue(square.GetValue(1, 1), 1, 1)
                piecemap.SetValue(square.GetValue(1, 2), 1, 2)
                piecemap.SetValue(square.GetValue(1, 3), 1, 3)

            Case 3
                piecemap.SetValue(tee.GetValue(0, 0), 0, 0)
                piecemap.SetValue(tee.GetValue(0, 1), 0, 1)
                piecemap.SetValue(tee.GetValue(0, 2), 0, 2)
                piecemap.SetValue(tee.GetValue(0, 3), 0, 3)
                piecemap.SetValue(tee.GetValue(1, 0), 1, 0)
                piecemap.SetValue(tee.GetValue(1, 1), 1, 1)
                piecemap.SetValue(tee.GetValue(1, 2), 1, 2)
                piecemap.SetValue(tee.GetValue(1, 3), 1, 3)

            Case 4
                piecemap.SetValue(rightZee.GetValue(0, 0), 0, 0)
                piecemap.SetValue(rightZee.GetValue(0, 1), 0, 1)
                piecemap.SetValue(rightZee.GetValue(0, 2), 0, 2)
                piecemap.SetValue(rightZee.GetValue(0, 3), 0, 3)
                piecemap.SetValue(rightZee.GetValue(1, 0), 1, 0)
                piecemap.SetValue(rightZee.GetValue(1, 1), 1, 1)
                piecemap.SetValue(rightZee.GetValue(1, 2), 1, 2)
                piecemap.SetValue(rightZee.GetValue(1, 3), 1, 3)
            Case 5
                piecemap.SetValue(iBeam.GetValue(0, 0), 0, 0)
                piecemap.SetValue(iBeam.GetValue(0, 1), 0, 1)
                piecemap.SetValue(iBeam.GetValue(0, 2), 0, 2)
                piecemap.SetValue(iBeam.GetValue(0, 3), 0, 3)
                piecemap.SetValue(iBeam.GetValue(1, 0), 1, 0)
                piecemap.SetValue(iBeam.GetValue(1, 1), 1, 1)
                piecemap.SetValue(iBeam.GetValue(1, 2), 1, 2)
                piecemap.SetValue(iBeam.GetValue(1, 3), 1, 3)
            Case 6
                piecemap.SetValue(leftZee.GetValue(0, 0), 0, 0)
                piecemap.SetValue(leftZee.GetValue(0, 1), 0, 1)
                piecemap.SetValue(leftZee.GetValue(0, 2), 0, 2)
                piecemap.SetValue(leftZee.GetValue(0, 3), 0, 3)
                piecemap.SetValue(leftZee.GetValue(1, 0), 1, 0)
                piecemap.SetValue(leftZee.GetValue(1, 1), 1, 1)
                piecemap.SetValue(leftZee.GetValue(1, 2), 1, 2)
                piecemap.SetValue(leftZee.GetValue(1, 3), 1, 3)
            Case 7
                piecemap.SetValue(rightEll.GetValue(0, 0), 0, 0)
                piecemap.SetValue(rightEll.GetValue(0, 1), 0, 1)
                piecemap.SetValue(rightEll.GetValue(0, 2), 0, 2)
                piecemap.SetValue(rightEll.GetValue(0, 3), 0, 3)
                piecemap.SetValue(rightEll.GetValue(1, 0), 1, 0)
                piecemap.SetValue(rightEll.GetValue(1, 1), 1, 1)
                piecemap.SetValue(rightEll.GetValue(1, 2), 1, 2)
                piecemap.SetValue(rightEll.GetValue(1, 3), 1, 3)
        End Select

        'DEBUG
        Dim i As UInteger
        Dim j As UInteger
        Dim T = piecemap.Length
        Dim D = piecemap.Rank
        Dim L = piecemap.GetLength(0)
        Dim W = piecemap.GetLength(1)
        Dim LU = piecemap.GetLength(0) - 1
        Dim LL = piecemap.GetLength(0) - piecemap.GetLength(0)
        Dim WU = piecemap.GetLength(1) - 1
        Dim WL = piecemap.GetLength(1) - piecemap.GetLength(1)
        Console.WriteLine("~~~~piecemap test after PieceNumToPiecemap()~~~~")
        For j = WL To WU
            Console.WriteLine()
            For i = LL To LU
                Console.Write($"{piecemap.GetValue(i, j)}")
            Next
        Next
        Console.WriteLine()
        'END DEBUG

    End Sub

    '~~~~~

    Shared Sub DefinePieces()
        rightEll.Initialize()
        'Define Right Ell (7)
        rightEll.SetValue(CUInt(7), 0, 1)
        rightEll.SetValue(CUInt(7), 0, 2)
        rightEll.SetValue(CUInt(7), 0, 3)
        rightEll.SetValue(CUInt(7), 1, 3)

        leftEll.Initialize()
        'Define Left Ell (1)
        leftEll.SetValue(CUInt(1), 0, 3)
        leftEll.SetValue(CUInt(1), 1, 3)
        leftEll.SetValue(CUInt(1), 1, 2)
        leftEll.SetValue(CUInt(1), 1, 1)

        square.Initialize()
        'Define Square (2)
        square.SetValue(CUInt(2), 0, 3)
        square.SetValue(CUInt(2), 1, 3)
        square.SetValue(CUInt(2), 0, 2)
        square.SetValue(CUInt(2), 1, 2)

        tee.Initialize()
        'Define Tee (3)
        tee.SetValue(CUInt(3), 0, 3)
        tee.SetValue(CUInt(3), 0, 2)
        tee.SetValue(CUInt(3), 0, 1)
        tee.SetValue(CUInt(3), 1, 2)

        rightZee.Initialize()
        'Define Right Zee (4)
        rightZee.SetValue(CUInt(4), 1, 3)
        rightZee.SetValue(CUInt(4), 0, 2)
        rightZee.SetValue(CUInt(4), 1, 2)
        rightZee.SetValue(CUInt(4), 0, 1)

        leftZee.Initialize()
        'Define Left Zee (6)
        leftZee.SetValue(CUInt(6), 0, 3)
        leftZee.SetValue(CUInt(6), 0, 2)
        leftZee.SetValue(CUInt(6), 1, 2)
        leftZee.SetValue(CUInt(6), 1, 1)

        iBeam.Initialize()
        'Define I Beam (5)
        iBeam.SetValue(CUInt(5), 0, 0)
        iBeam.SetValue(CUInt(5), 0, 1)
        iBeam.SetValue(CUInt(5), 0, 2)
        iBeam.SetValue(CUInt(5), 0, 3)

        'DEBUG
        Dim i As UInteger
        Dim j As UInteger
        Dim T = rightEll.Length
        Dim D = rightEll.Rank
        Dim L = rightEll.GetLength(0)
        Dim W = rightEll.GetLength(1)
        Dim LU = rightEll.GetLength(0) - 1
        Dim LL = rightEll.GetLength(0) - rightEll.GetLength(0)
        Dim WU = rightEll.GetLength(1) - 1
        Dim WL = rightEll.GetLength(1) - rightEll.GetLength(1)
        Console.WriteLine("~~~~rightEll test after DefinePieces()~~~~")
        For j = WL To WU
            Console.WriteLine()
            For i = LL To LU
                Console.Write($"{rightEll.GetValue(i, j)}")
            Next
        Next
        Console.WriteLine()
        'END DEBUG

    End Sub

    Shared Sub GameboardToPieceboard()
        Dim i As New Integer
        Dim j As New Integer
        Dim T = gameboard.Length
        Dim D = gameboard.Rank
        Dim L = gameboard.GetLength(0)
        Dim W = gameboard.GetLength(1)
        Dim LU = gameboard.GetLength(0) - 1
        Dim LL = gameboard.GetLength(0) - gameboard.GetLength(0)
        Dim WU = gameboard.GetLength(1) - 1
        Dim WL = gameboard.GetLength(1) - gameboard.GetLength(1)

        For j = WL To WU
            For i = LL To LU
                pieceboard.SetValue(gameboard.GetValue(i, j), i, j)
            Next
        Next
    End Sub

    Shared Sub CopyPieceboard()
        Dim pieceboardCopy(9, 19)
        Dim i As Integer
        Dim j As Integer
        Dim L = pieceboard.GetLength(0)
        Dim W = pieceboard.GetLength(1)
        Dim LU = pieceboard.GetLength(0) - 1
        Dim LL = pieceboard.GetLength(0) - pieceboard.GetLength(0)
        Dim WU = pieceboard.GetLength(1) - 1
        Dim WL = pieceboard.GetLength(1) - pieceboard.GetLength(1)

        For j = WL To WU
            For i = LL To LU
                If j <= 19 Then
                    pieceboardCopy.SetValue(pieceboard.GetValue(i, j), i, j)
                End If
            Next
        Next

        ReDim pieceboard(9, 19)

        For j = WL To WU
            For i = LL To LU
                If j <= 19 Then
                    pieceboard.SetValue(pieceboardCopy.GetValue(i, j), i, j)
                End If
            Next
        Next
    End Sub

    '~~~~~

    Shared Sub PiecemapToPieceboard()
        pieceboard.SetValue(piecemap.GetValue(0, 0), 5, 4)
        pieceboard.SetValue(piecemap.GetValue(0, 1), 5, 5)
        pieceboard.SetValue(piecemap.GetValue(0, 2), 5, 6)
        pieceboard.SetValue(piecemap.GetValue(0, 3), 5, 7)
        pieceboard.SetValue(piecemap.GetValue(1, 0), 6, 4)
        pieceboard.SetValue(piecemap.GetValue(1, 1), 6, 5)
        pieceboard.SetValue(piecemap.GetValue(1, 2), 6, 6)
        pieceboard.SetValue(piecemap.GetValue(1, 3), 6, 7)
    End Sub
End Class
