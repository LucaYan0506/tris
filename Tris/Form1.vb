
Public Class Form1
    Dim A(10) As String
    Dim i, c, punteggiox, punteggioO, l, numero, y As Integer
    Dim giocatore1, giocatore2 As String
    Dim bottone(10) As String
    Dim t As New Form2
    Dim nuovo As New Form3

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        MsgBox("Made by Luca")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        giocatore1 = "Il giocatore1 (X)"
        giocatore2 = "Il giocatore2 (O)"
        AnnullaToolStripMenuItem.Enabled = False
        Do
            i = i + 1
            A(i) = "X"
            i = i + 1
            A(i) = "O"
        Loop Until i = 10
    End Sub

    Private Sub A1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.Click
        c = c + 1
        A1.Text = A(c)
        A1.Enabled = False
        numero = numero + 1
        bottone(numero) = "A1"
        If numero > 0 Then
            AnnullaToolStripMenuItem.Enabled = True
        Else
            AnnullaToolStripMenuItem.Enabled = False
        End If
        If A1.Text = "X" Then
            Label3.ForeColor = Color.Red
            Label1.ForeColor = Color.Black
        ElseIf A1.Text = "O" Then
            Label1.ForeColor = Color.Red
            Label3.ForeColor = Color.Black
        End If
        If A1.Text = "X" And A2.Text = "X" And A3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If A1.Text = "O" And A2.Text = "O" And A3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If A1.Text = "X" And B1.Text = "X" And C1.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If A1.Text = "O" And B1.Text = "O" And C1.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If A1.Text = "X" And B2.Text = "X" And C3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If A1.Text = "O" And B2.Text = "O" And C3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If c = 9 And l = 0 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If c = 10 And l = 1 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If numero > 0 Then
            AnnullaToolStripMenuItem.Enabled = True
        Else
            AnnullaToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub A2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A2.Click
        c = c + 1
        A2.Text = A(c)
        A2.Enabled = False
        numero = numero + 1
        bottone(numero) = "A2"
        If A2.Text = "X" Then
            Label3.ForeColor = Color.Red
            Label1.ForeColor = Color.Black
        ElseIf A2.Text = "O" Then
            Label1.ForeColor = Color.Red
            Label3.ForeColor = Color.Black
        End If
        If A1.Text = "X" And A2.Text = "X" And A3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If A1.Text = "O" And A2.Text = "O" And A3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If A2.Text = "X" And B2.Text = "X" And C2.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If A2.Text = "O" And B2.Text = "O" And C2.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If c = 9 And l = 0 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If c = 10 And l = 1 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If numero > 0 Then
            AnnullaToolStripMenuItem.Enabled = True
        Else
            AnnullaToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub A3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A3.Click
        c = c + 1
        A3.Text = A(c)
        A3.Enabled = False
        numero = numero + 1
        bottone(numero) = "A3"
        If A3.Text = "X" Then
            Label3.ForeColor = Color.Red
            Label1.ForeColor = Color.Black
        ElseIf A3.Text = "O" Then
            Label1.ForeColor = Color.Red
            Label3.ForeColor = Color.Black
        End If
        If A1.Text = "X" And A2.Text = "X" And A3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If A1.Text = "O" And A2.Text = "O" And A3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If A3.Text = "X" And B3.Text = "X" And C3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If A3.Text = "O" And B3.Text = "O" And C3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If C1.Text = "X" And B2.Text = "X" And A3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If C1.Text = "O" And B2.Text = "O" And A3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If c = 9 And l = 0 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If c = 10 And l = 1 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If numero > 0 Then
            AnnullaToolStripMenuItem.Enabled = True
        Else
            AnnullaToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        c = c + 1
        B1.Text = A(c)
        B1.Enabled = False
        numero = numero + 1
        bottone(numero) = "B1"
        If B1.Text = "X" Then
            Label3.ForeColor = Color.Red
            Label1.ForeColor = Color.Black
        ElseIf B1.Text = "O" Then
            Label1.ForeColor = Color.Red
            Label3.ForeColor = Color.Black
        End If
        If B1.Text = "X" And B2.Text = "X" And B3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If B1.Text = "O" And B2.Text = "O" And B3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If A1.Text = "X" And B1.Text = "X" And C1.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If A1.Text = "O" And B1.Text = "O" And C1.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If c = 9 And l = 0 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If c = 10 And l = 1 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If numero > 0 Then
            AnnullaToolStripMenuItem.Enabled = True
        Else
            AnnullaToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        c = c + 1
        B2.Text = A(c)
        B2.Enabled = False
        numero = numero + 1
        bottone(numero) = "B2"
        If B2.Text = "X" Then
            Label3.ForeColor = Color.Red
            Label1.ForeColor = Color.Black
        ElseIf B2.Text = "O" Then
            Label1.ForeColor = Color.Red
            Label3.ForeColor = Color.Black
        End If
        If B1.Text = "X" And B2.Text = "X" And B3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If B1.Text = "O" And B2.Text = "O" And B3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If A2.Text = "X" And B2.Text = "X" And C2.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If A2.Text = "O" And B2.Text = "O" And C2.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If A1.Text = "X" And B2.Text = "X" And C3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If A1.Text = "O" And B2.Text = "O" And C3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If C1.Text = "X" And B2.Text = "X" And A3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If C1.Text = "O" And B2.Text = "O" And A3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If c = 9 And l = 0 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If c = 10 And l = 1 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If numero > 0 Then
            AnnullaToolStripMenuItem.Enabled = True
        Else
            AnnullaToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        c = c + 1
        B3.Text = A(c)
        B3.Enabled = False
        numero = numero + 1
        bottone(numero) = "B3"
        If B3.Text = "X" Then
            Label3.ForeColor = Color.Red
            Label1.ForeColor = Color.Black
        ElseIf B3.Text = "O" Then
            Label1.ForeColor = Color.Red
            Label3.ForeColor = Color.Black
        End If
        If B1.Text = "X" And B2.Text = "X" And B3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If B1.Text = "O" And B2.Text = "O" And B3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If A3.Text = "X" And B3.Text = "X" And C3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If A3.Text = "O" And B3.Text = "O" And C3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If c = 9 And l = 0 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If c = 10 And l = 1 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If numero > 0 Then
            AnnullaToolStripMenuItem.Enabled = True
        Else
            AnnullaToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub C1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1.Click
        c = c + 1
        C1.Text = A(c)
        C1.Enabled = False
        numero = numero + 1
        bottone(numero) = "C1"
        If C1.Text = "X" Then
            Label3.ForeColor = Color.Red
            Label1.ForeColor = Color.Black
        ElseIf C1.Text = "O" Then
            Label1.ForeColor = Color.Red
            Label3.ForeColor = Color.Black
        End If
        If C1.Text = "X" And C2.Text = "X" And C3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If C1.Text = "O" And C2.Text = "O" And C3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If A1.Text = "X" And B1.Text = "X" And C1.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If A1.Text = "O" And B1.Text = "O" And C1.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If C1.Text = "X" And B2.Text = "X" And A3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If C1.Text = "O" And B2.Text = "O" And A3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If c = 9 And l = 0 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If c = 10 And l = 1 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If numero > 0 Then
            AnnullaToolStripMenuItem.Enabled = True
        Else
            AnnullaToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub C2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C2.Click
        c = c + 1
        C2.Text = A(c)
        C2.Enabled = False
        numero = numero + 1
        bottone(numero) = "C2"
        If C2.Text = "X" Then
            Label3.ForeColor = Color.Red
            Label1.ForeColor = Color.Black
        ElseIf C2.Text = "O" Then
            Label1.ForeColor = Color.Red
            Label3.ForeColor = Color.Black
        End If
        If C1.Text = "X" And C2.Text = "X" And C3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If C1.Text = "O" And C2.Text = "O" And C3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If A2.Text = "X" And B2.Text = "X" And C2.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If A2.Text = "O" And B2.Text = "O" And C2.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If c = 9 And l = 0 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If c = 10 And l = 1 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If numero > 0 Then
            AnnullaToolStripMenuItem.Enabled = True
        Else
            AnnullaToolStripMenuItem.Enabled = False
        End If
    End Sub


    Private Sub C3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C3.Click
        c = c + 1
        C3.Text = A(c)
        C3.Enabled = False
        numero = numero + 1
        bottone(numero) = "C3"
        If C3.Text = "X" Then
            Label3.ForeColor = Color.Red
            Label1.ForeColor = Color.Black
        ElseIf C3.Text = "O" Then
            Label1.ForeColor = Color.Red
            Label3.ForeColor = Color.Black
        End If
        If C1.Text = "X" And C2.Text = "X" And C3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0

        End If
        If C1.Text = "O" And C2.Text = "O" And C3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If A3.Text = "X" And B3.Text = "X" And C3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If A3.Text = "O" And B3.Text = "O" And C3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If A1.Text = "X" And B2.Text = "X" And C3.Text = "X" Then
            MsgBox(giocatore1 & " won")
            punteggiox = punteggiox + 1
            Punteggio1.Text = punteggiox
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If A1.Text = "O" And B2.Text = "O" And C3.Text = "O" Then
            MsgBox(giocatore2 & " won")
            punteggioO = punteggioO + 1
            Punteggio2.Text = punteggioO
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If c = 9 And l = 0 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 1
            l = c
            numero = 0
        End If
        If c = 10 And l = 1 Then
            MsgBox("Draw")
            A1.Enabled = True
            A1.Text = ""
            A2.Enabled = True
            A2.Text = ""
            A3.Enabled = True
            A3.Text = ""
            B1.Enabled = True
            B1.Text = ""
            B2.Enabled = True
            B2.Text = ""
            B3.Enabled = True
            B3.Text = ""
            C1.Enabled = True
            C1.Text = ""
            C2.Enabled = True
            C2.Text = ""
            C3.Enabled = True
            C3.Text = ""
            c = 0
            l = c
            numero = 0
        End If
        If numero > 0 Then
            AnnullaToolStripMenuItem.Enabled = True
        Else
            AnnullaToolStripMenuItem.Enabled = False
        End If
    End Sub


    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click
        A1.Enabled = True
        A1.Text = ""
        A2.Enabled = True
        A2.Text = ""
        A3.Enabled = True
        A3.Text = ""
        B1.Enabled = True
        B1.Text = ""
        B2.Enabled = True
        B2.Text = ""
        B3.Enabled = True
        B3.Text = ""
        C1.Enabled = True
        C1.Text = ""
        C2.Enabled = True
        C2.Text = ""
        C3.Enabled = True
        C3.Text = ""
        c = 0
        numero = 1
        punteggiox = 0
        Punteggio1.Text = punteggiox
        punteggioO = 0
        Punteggio2.Text = punteggioO
    End Sub

    Private Sub GiocatoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GiocatoreToolStripMenuItem.Click
        giocatore1 = InputBox("inserisci il nome del primo giocatore")
        If giocatore1 = "" Or giocatore1 = " " Then
            giocatore1 = Label1.Text
            Label1.Text = giocatore1
        Else
            Label1.Text = giocatore1 & " (X)"
        End If
        giocatore2 = InputBox("inserisci il nome del secondo giocatore")
        If giocatore2 = "" Or giocatore2 = " " Then
            giocatore2 = Label3.Text
            Label3.Text = giocatore2
        Else
            Label3.Text = giocatore2 & " (O)"
        End If
        y = FreeFile()
        FileOpen(y, "giocattori", OpenMode.Output)
        WriteLine(y, Label1.Text)
        WriteLine(y, Label3.Text)
        FileClose(y)
    End Sub

    Private Sub AnnullaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnnullaToolStripMenuItem.Click
        If numero = 1 Then
            AnnullaToolStripMenuItem.Enabled = False
        End If
        Select Case bottone(numero)
            Case "A1"
                A1.Text = ""
                A1.Enabled = True
                c = c - 1
                numero = numero - 1
                If Label1.ForeColor = Color.Black Then
                    Label1.ForeColor = Color.Red
                Else
                    Label1.ForeColor = Color.Black
                End If
                If Label3.ForeColor = Color.Black Then
                    Label3.ForeColor = Color.Red
                Else
                    Label3.ForeColor = Color.Black
                End If
            Case "A2"
                A2.Text = ""
                A2.Enabled = True
                c = c - 1
                numero = numero - 1
                If Label1.ForeColor = Color.Black Then
                    Label1.ForeColor = Color.Red
                Else
                    Label1.ForeColor = Color.Black
                End If
                If Label3.ForeColor = Color.Black Then
                    Label3.ForeColor = Color.Red
                Else
                    Label3.ForeColor = Color.Black
                End If
            Case "A3"
                A3.Text = ""
                A3.Enabled = True
                c = c - 1
                numero = numero - 1
                If Label1.ForeColor = Color.Black Then
                    Label1.ForeColor = Color.Red
                Else
                    Label1.ForeColor = Color.Black
                End If
                If Label3.ForeColor = Color.Black Then
                    Label3.ForeColor = Color.Red
                Else
                    Label3.ForeColor = Color.Black
                End If
            Case "B1"
                B1.Text = ""
                B1.Enabled = True
                c = c - 1
                numero = numero - 1
                If Label1.ForeColor = Color.Black Then
                    Label1.ForeColor = Color.Red
                Else
                    Label1.ForeColor = Color.Black
                End If
                If Label3.ForeColor = Color.Black Then
                    Label3.ForeColor = Color.Red
                Else
                    Label3.ForeColor = Color.Black
                End If
            Case "B2"
                B2.Text = ""
                B2.Enabled = True
                c = c - 1
                numero = numero - 1
                If Label1.ForeColor = Color.Black Then
                    Label1.ForeColor = Color.Red
                Else
                    Label1.ForeColor = Color.Black
                End If
                If Label3.ForeColor = Color.Black Then
                    Label3.ForeColor = Color.Red
                Else
                    Label3.ForeColor = Color.Black
                End If
            Case "B3"
                B3.Text = ""
                B3.Enabled = True
                c = c - 1
                numero = numero - 1
                If Label1.ForeColor = Color.Black Then
                    Label1.ForeColor = Color.Red
                Else
                    Label1.ForeColor = Color.Black
                End If
                If Label3.ForeColor = Color.Black Then
                    Label3.ForeColor = Color.Red
                Else
                    Label3.ForeColor = Color.Black
                End If
            Case "C1"
                C1.Text = ""
                C1.Enabled = True
                c = c - 1
                numero = numero - 1
                If Label1.ForeColor = Color.Black Then
                    Label1.ForeColor = Color.Red
                Else
                    Label1.ForeColor = Color.Black
                End If
                If Label3.ForeColor = Color.Black Then
                    Label3.ForeColor = Color.Red
                Else
                    Label3.ForeColor = Color.Black
                End If
            Case "C2"
                C2.Text = ""
                C2.Enabled = True
                c = c - 1
                numero = numero - 1
                If Label1.ForeColor = Color.Black Then
                    Label1.ForeColor = Color.Red
                Else
                    Label1.ForeColor = Color.Black
                End If
                If Label3.ForeColor = Color.Black Then
                    Label3.ForeColor = Color.Red
                Else
                    Label3.ForeColor = Color.Black
                End If
            Case "C3"
                C3.Text = ""
                C3.Enabled = True
                c = c - 1
                numero = numero - 1
                If Label1.ForeColor = Color.Black Then
                    Label1.ForeColor = Color.Red
                Else
                    Label1.ForeColor = Color.Black
                End If
                If Label3.ForeColor = Color.Black Then
                    Label3.ForeColor = Color.Red
                Else
                    Label3.ForeColor = Color.Black
                End If
        End Select
        If numero > 0 Then
            AnnullaToolStripMenuItem.Enabled = True
        Else
            AnnullaToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub RegolaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegolaToolStripMenuItem.Click
        t.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        nuovo.ShowDialog()
    End Sub
End Class
