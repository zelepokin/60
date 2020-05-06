Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim k, c, x1, b, kp As Integer, a As Long
        a = InputBox("a=")
        k = 0
        b = a
        While b <> 0
            c = b Mod 10
            k = k + 1
            b = b \ 10
        End While
        x1 = a \ 10 ^ (k - 1)
        While a <> 0
            c = a Mod 10
            If c = x1 Then kp = kp + 1
            a = a \ 10
        End While
        MsgBox("kp=" & kp)
    End Sub
End Class
