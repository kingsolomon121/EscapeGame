Public Class Form6
    Dim tally As Integer = 0
    Dim counter As Integer
    Dim begin As Boolean = False
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()
        PictureBox5.Hide()
        PictureBox6.Hide()
    End Sub

    Private Sub Form6_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (PictureBox1.Left <= 0) Then
            PictureBox1.Left += 6
        ElseIf (PictureBox1.Left >= 490) Then
            PictureBox1.Left -= 6
        End If
        If (e.KeyCode = Keys.Left) Then
            PictureBox1.Left -= 5
        End If
        If (e.KeyCode = Keys.Right) Then
            PictureBox1.Left += 5
        End If
        If (e.KeyCode = Keys.Space) Then
            counter = counter + 1
            If (counter = 1) Then
                PictureBox2.Top = PictureBox1.Top - 20
                PictureBox2.Left = PictureBox1.Left + 20
                PictureBox2.Show()
                Timer1.Enabled = True
            End If
            If (counter = 2) Then
                PictureBox3.Top = PictureBox1.Top - 40
                PictureBox3.Left = PictureBox1.Left + 20
                PictureBox3.Show()
                Timer2.Enabled = True
            End If
            If (counter = 3) Then
                PictureBox4.Top = PictureBox1.Top - 40
                PictureBox4.Left = PictureBox1.Left + 20
                PictureBox4.Show()
                Timer3.Enabled = True
            End If
            If (counter = 4) Then
                PictureBox5.Top = PictureBox1.Top - 40
                PictureBox5.Left = PictureBox1.Left + 20
                PictureBox5.Show()
                Timer4.Enabled = True
            End If
            If (counter = 5) Then
                PictureBox6.Top = PictureBox1.Top - 40
                PictureBox6.Left = PictureBox1.Left + 20
                PictureBox6.Show()
                Timer5.Enabled = True
                Timer6.Enabled = True
                TextBox1.Text = "Reloading..."
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (PictureBox2.Top > -20) Then
            PictureBox2.Top -= 1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (PictureBox3.Top > -20) Then
            PictureBox3.Top -= 1
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If (PictureBox4.Top > -20) Then
            PictureBox4.Top -= 1
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If (PictureBox5.Top > -20) Then
            PictureBox5.Top -= 1
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If (PictureBox6.Top > -20) Then
            PictureBox6.Top -= 1
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        counter = 0
        TextBox1.Text = ""
        Timer6.Enabled = False
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        PictureBox7.Top += 1
        PictureBox8.Top += 1
        PictureBox9.Top += 1
        PictureBox10.Top += 1
        If (PictureBox7.Top > 525) Then
            PictureBox7.Top = -26
            PictureBox8.Top = -26
            PictureBox9.Top = -26
            PictureBox10.Top = -26
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer7.Enabled = True
        Timer8.Enabled = True
        Timer9.Enabled = True
        Me.Enabled = False
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Dim rand As Integer = CInt(Int((2 * Rnd()) + 1))
        If (rand = 1) Then
            PictureBox7.Left += 6
            PictureBox8.Left += 6
            PictureBox9.Left += 6
            PictureBox10.Left += 6
        End If
        If (rand = 2) Then
            PictureBox7.Left -= 6
            PictureBox8.Left -= 6
            PictureBox9.Left -= 6
            PictureBox10.Left -= 6
        End If
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        If ((PictureBox7.Top - 26 >= PictureBox2.Top) And (PictureBox7.Top <= PictureBox2.Top) And (PictureBox7.Left <= PictureBox2.Left) And (PictureBox7.Left + 42 >= PictureBox2.Left)) Or ((PictureBox7.Top - 26 >= PictureBox3.Top) And (PictureBox7.Top <= PictureBox3.Top) And (PictureBox7.Left <= PictureBox3.Left) And (PictureBox7.Left + 42 >= PictureBox3.Left)) Or ((PictureBox7.Top - 26 >= PictureBox4.Top) And (PictureBox7.Top <= PictureBox4.Top) And (PictureBox7.Left <= PictureBox4.Left) And (PictureBox7.Left + 42 >= PictureBox4.Left)) Or ((PictureBox7.Top - 26 >= PictureBox5.Top) And (PictureBox7.Top <= PictureBox5.Top) And (PictureBox7.Left <= PictureBox5.Left) And (PictureBox7.Left + 42 >= PictureBox5.Left)) Or ((PictureBox7.Top - 26 >= PictureBox6.Top) And (PictureBox7.Top <= PictureBox6.Top) And (PictureBox7.Left <= PictureBox6.Left) And (PictureBox7.Left + 42 >= PictureBox6.Left)) Then
            PictureBox7.Dispose()
            PictureBox7.Hide()
        End If
        If ((PictureBox8.Top - 26 >= PictureBox2.Top) And (PictureBox8.Top <= PictureBox2.Top) And (PictureBox8.Left <= PictureBox2.Left) And (PictureBox8.Left + 42 >= PictureBox2.Left)) Or ((PictureBox8.Top - 26 >= PictureBox3.Top) And (PictureBox8.Top <= PictureBox3.Top) And (PictureBox8.Left <= PictureBox3.Left) And (PictureBox8.Left + 42 >= PictureBox3.Left)) Or ((PictureBox8.Top - 26 >= PictureBox4.Top) And (PictureBox8.Top <= PictureBox4.Top) And (PictureBox8.Left <= PictureBox4.Left) And (PictureBox8.Left + 42 >= PictureBox4.Left)) Or ((PictureBox8.Top - 26 >= PictureBox5.Top) And (PictureBox8.Top <= PictureBox5.Top) And (PictureBox8.Left <= PictureBox5.Left) And (PictureBox8.Left + 42 >= PictureBox5.Left)) Or ((PictureBox8.Top - 26 >= PictureBox6.Top) And (PictureBox8.Top <= PictureBox6.Top) And (PictureBox8.Left <= PictureBox6.Left) And (PictureBox8.Left + 42 >= PictureBox6.Left)) Then
            PictureBox8.Dispose()
            PictureBox8.Hide()
        End If
        If ((PictureBox9.Top - 26 >= PictureBox2.Top) And (PictureBox9.Top <= PictureBox2.Top) And (PictureBox9.Left <= PictureBox2.Left) And (PictureBox9.Left + 42 >= PictureBox2.Left)) Or ((PictureBox9.Top - 26 >= PictureBox3.Top) And (PictureBox9.Top <= PictureBox3.Top) And (PictureBox9.Left <= PictureBox3.Left) And (PictureBox9.Left + 42 >= PictureBox3.Left)) Or ((PictureBox9.Top - 26 >= PictureBox4.Top) And (PictureBox9.Top <= PictureBox4.Top) And (PictureBox9.Left <= PictureBox4.Left) And (PictureBox9.Left + 42 >= PictureBox4.Left)) Or ((PictureBox9.Top - 26 >= PictureBox5.Top) And (PictureBox9.Top <= PictureBox5.Top) And (PictureBox9.Left <= PictureBox5.Left) And (PictureBox9.Left + 42 >= PictureBox5.Left)) Or ((PictureBox9.Top - 26 >= PictureBox6.Top) And (PictureBox9.Top <= PictureBox6.Top) And (PictureBox9.Left <= PictureBox6.Left) And (PictureBox9.Left + 42 >= PictureBox6.Left)) Then
            PictureBox9.Dispose()
            PictureBox9.Hide()
        End If
        If ((PictureBox10.Top - 26 >= PictureBox2.Top) And (PictureBox10.Top <= PictureBox2.Top) And (PictureBox10.Left <= PictureBox2.Left) And (PictureBox10.Left + 42 >= PictureBox2.Left)) Or ((PictureBox10.Top - 26 >= PictureBox3.Top) And (PictureBox10.Top <= PictureBox3.Top) And (PictureBox10.Left <= PictureBox3.Left) And (PictureBox10.Left + 42 >= PictureBox3.Left)) Or ((PictureBox10.Top - 26 >= PictureBox4.Top) And (PictureBox10.Top <= PictureBox4.Top) And (PictureBox10.Left <= PictureBox4.Left) And (PictureBox10.Left + 42 >= PictureBox4.Left)) Or ((PictureBox10.Top - 26 >= PictureBox5.Top) And (PictureBox10.Top <= PictureBox5.Top) And (PictureBox10.Left <= PictureBox5.Left) And (PictureBox10.Left + 42 >= PictureBox5.Left)) Or ((PictureBox10.Top - 26 >= PictureBox6.Top) And (PictureBox10.Top <= PictureBox6.Top) And (PictureBox10.Left <= PictureBox6.Left) And (PictureBox10.Left + 42 >= PictureBox6.Left)) Then
            PictureBox10.Dispose()
            PictureBox10.Hide()
        End If
    End Sub
End Class