Public Class Form3
    Dim num As String = ""

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Dispose()
        Me.Hide()
        Form1.KeyPad()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num = num & 1
        TextBox1.Text = num
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        num = num & 2
        TextBox1.Text = num
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        num = num & 3
        TextBox1.Text = num
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        num = num & 4
        TextBox1.Text = num
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        num = num & 5
        TextBox1.Text = num
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        num = num & 6
        TextBox1.Text = num
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        num = num & 7
        TextBox1.Text = num
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        num = num & 8
        TextBox1.Text = num
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        num = num & 9
        TextBox1.Text = num
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        num = num & 0
        TextBox1.Text = num
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If (6404 = num) Then
            Me.Close()
            Me.Hide()
            Form4.Show()
            MsgBox("You open the floor plan. Next, you twist the door handle. Quietly opening the door, you first glance in the room checking the surroundings. It's all clear. The room appears to be a library. ")
            Form1.PastLock()

        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        num = ""
        TextBox1.Text = ""
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class