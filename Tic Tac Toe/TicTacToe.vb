'Programer: James Clyburn
'Date: 6/14/19

Option Strict On
Public Class TicTacToe
    'Constants
    Const winTitle As String = "Winner"

    'Declarations
    Dim personTurn As Boolean = False
    Dim turnNumber As Integer = 0
    Dim winFound As Boolean = False
    Private buttons As List(Of Button)

    Private Sub TicTacToe_Load(sender As Object, e As EventArgs) Handles Me.Load
        buttons = New List(Of Button) From {A1, A2, A3, B1, B2, B3, C1, C2, C3}
    End Sub

    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click
        letterChooser(A1)
        winnerChecker()
    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.Click
        letterChooser(A2)
        winnerChecker()
    End Sub

    Private Sub A3_Click(sender As Object, e As EventArgs) Handles A3.Click
        letterChooser(A3)
        winnerChecker()
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        letterChooser(B1)
        winnerChecker()
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        letterChooser(B2)
        winnerChecker()
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        letterChooser(B3)
        winnerChecker()
    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click
        letterChooser(C1)
        winnerChecker()
    End Sub

    Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click
        letterChooser(C2)
        winnerChecker()
    End Sub

    Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click
        letterChooser(C3)
        winnerChecker()
    End Sub

    Private Sub letterChooser(location As Button)
        If personTurn = False Then
            location.Text = "X"
        Else
            location.Text = "O"
        End If
        location.Enabled = False
        turnNumber += 1
        personTurn = Not personTurn
    End Sub

    Private Sub winnerChecker()
        If A1.Text = A2.Text And A1.Text = A3.Text And Not A1.Text = "" Then
            winFound = True
            If A1.Text = "X" Then
                MsgBox("X wins!", , winTitle)
            Else
                MsgBox("O wins!", , winTitle)
            End If
        End If

        If B1.Text = B2.Text And B1.Text = B3.Text And Not B1.Text = "" Then
            winFound = True
            If B1.Text = "X" Then
                MsgBox("X wins!", , winTitle)
            Else
                MsgBox("O wins!", , winTitle)
            End If
        End If

        If C1.Text = C2.Text And C1.Text = C3.Text And Not C1.Text = "" Then
            winFound = True
            If C1.Text = "X" Then
                MsgBox("X wins!", , winTitle)
            Else
                MsgBox("O wins!", , winTitle)
            End If
        End If

        If A1.Text = B2.Text And A1.Text = C3.Text And Not A1.Text = "" Then
            winFound = True
            If A1.Text = "X" Then
                MsgBox("X Wins", , winTitle)
            Else
                MsgBox("O wins!", , winTitle)
            End If
        End If

        If A3.Text = B2.Text And A3.Text = C1.Text And Not A3.Text = "" Then
            winFound = True
            If A3.Text = "X" Then
                MsgBox("X Wins", , winTitle)
            Else
                MsgBox("O wins!", , winTitle)
            End If
        End If

        If winFound = True Then
            For index = 0 To buttons.Count - 1
                buttons(index).Enabled = False
            Next
        End If

        If winFound = False And turnNumber = 9 Then
            MsgBox("Cat!", , winTitle)
        End If
    End Sub

    Private Sub initializer()
        personTurn = False
        turnNumber = 0
        winFound = False

        For index = 0 To buttons.Count - 1
            buttons(index).Enabled = True
            buttons(index).Text = ""
        Next
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        initializer()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("This game was made by James Clyburn.", , "Creator")
    End Sub
End Class
