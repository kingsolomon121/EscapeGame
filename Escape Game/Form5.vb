Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Button9.Text = "") Then
            Button9.Text = Button1.Text
            Button1.Text = ""
        End If
        If (Button6.Text = "") Then
            Button6.Text = Button1.Text
            Button1.Text = ""
        End If
        If (Button2.Text = "") Then
            Button2.Text = Button1.Text
            Button1.Text = ""
        End If
        Done()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (Button7.Text = "") Then
            Button7.Text = Button5.Text
            Button5.Text = ""
        End If
        If (Button8.Text = "") Then
            Button8.Text = Button5.Text
            Button5.Text = ""
        End If
        Done()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (Button5.Text = "") Then
            Button5.Text = Button8.Text
            Button8.Text = ""
        End If
        If (Button2.Text = "") Then
            Button2.Text = Button8.Text
            Button8.Text = ""
        End If
        If (Button3.Text = "") Then
            Button3.Text = Button8.Text
            Button8.Text = ""
        End If
        Done()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (Button4.Text = "") Then
            Button4.Text = Button3.Text
            Button3.Text = ""
        End If
        If (Button8.Text = "") Then
            Button8.Text = Button3.Text
            Button3.Text = ""
        End If
        Done()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (Button5.Text = "") Then
            Button5.Text = Button7.Text
            Button7.Text = ""
        End If
        If (Button6.Text = "") Then
            Button6.Text = Button7.Text
            Button7.Text = ""
        End If
        If (Button2.Text = "") Then
            Button2.Text = Button7.Text
            Button7.Text = ""
        End If
        Done()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Button7.Text = "") Then
            Button7.Text = Button2.Text
            Button2.Text = ""
        End If
        If (Button1.Text = "") Then
            Button1.Text = Button2.Text
            Button2.Text = ""
        End If
        If (Button8.Text = "") Then
            Button8.Text = Button2.Text
            Button2.Text = ""
        End If
        If (Button4.Text = "") Then
            Button4.Text = Button2.Text
            Button2.Text = ""
        End If
        Done()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Button2.Text = "") Then
            Button2.Text = Button4.Text
            Button4.Text = ""
        End If
        If (Button3.Text = "") Then
            Button3.Text = Button4.Text
            Button4.Text = ""
        End If
        If (Button9.Text = "") Then
            Button9.Text = Button4.Text
            Button4.Text = ""
        End If
        Done()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (Button1.Text = "") Then
            Button1.Text = Button6.Text
            Button6.Text = ""
        End If
        If (Button7.Text = "") Then
            Button7.Text = Button6.Text
            Button6.Text = ""
        End If
        Done()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (Button1.Text = "") Then
            Button1.Text = Button9.Text
            Button9.Text = ""
        End If
        If (Button4.Text = "") Then
            Button4.Text = Button9.Text
            Button9.Text = ""
        End If
        Done()
    End Sub
    Public Sub Done()
        If (Button5.Text = "1") And (Button7.Text = "2") And (Button6.Text = "3") And (Button8.Text = "4") And (Button2.Text = "5") And (Button1.Text = "6") And (Button3.Text = "7") And (Button4.Text = "8") And (Button9.Text = "") Then
            Me.Dispose()
            Me.Hide()
            MsgBox("You solved the puzzle! It reads 'Chapter 7, Page 153, Line 2'")
            Form1.PastLock()
        End If
    End Sub
End Class