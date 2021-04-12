Imports System.Drawing.Point
Public Class Form4


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox4.Text = Form1.Location.Y
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox3.Text = Form1.Location.X
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Check.Click
        TextBox3.Text = Form1.Location.X
        TextBox4.Text = Form1.Location.Y
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = Form3.Location.X
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = Form3.Location.Y
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = Form3.Location.X
        TextBox2.Text = Form3.Location.Y
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Location = New Point(1380, 30)
        Form3.Location = New Point(1380, 30)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Location = New Point(1528, 36)
        Form1.Location = New Point(1528, 36)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.TopMost = True
        ElseIf CheckBox1.Checked = False Then
            Me.TopMost = False

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Location = New Point(1660, 38)
        Form3.Location = New Point(1660, 38)
    End Sub
End Class