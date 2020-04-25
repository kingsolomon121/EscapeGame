Public Class Maze_Room1
    Dim startchk As Boolean = False

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If startchk = False Then
            MsgBox("You must click start first!")
        End If

        If startchk = True Then
            Dim timescore As Integer
            Timer1.Enabled = False
            timescore = 10 - Val(Label2.Text)
            startchk = False

            MsgBox("You have unlocked the gate.")
            Form1.success = True
            Me.Close()
        End If

    End Sub

    Private Sub PictureBox10_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox10.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox11_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox11.MouseEnter

        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If

    End Sub

    Private Sub PictureBox12_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox12.MouseEnter

        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox13_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox13.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If

    End Sub

    Private Sub PictureBox14_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox14.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox15_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox15.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox16_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox16.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox18_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox18.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox19_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox19.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox20_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox20.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox21_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox21.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox7_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox7.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox8_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox8.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox9_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox9.MouseEnter
        If startchk = True Then
            MsgBox("You hit a wall!")
            Timer1.Enabled = False
            Label2.Text = "10"
            startchk = False
            MsgBox("You have failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Val(Label2.Text) - 1
        If Label2.Text = 0 Then
            Timer1.Enabled = False
            MsgBox("Times up!!! You failed.")
            Form1.success = False
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        startchk = True
        Timer1.Enabled = True
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
