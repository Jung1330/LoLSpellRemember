Imports System.IO
Imports System.Threading
Imports System.ComponentModel.Component
Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox3.Enabled = False
        TextBox5.Enabled = False
        Application.DoEvents()
        Button1.Enabled = False
        Button4.Enabled = False
        Button3.Enabled = False
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = Form1.İTimer2.Interval

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Form1.İTimer2.Interval
        Button4.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.İTimer2.Interval = Val(TextBox2.Text * 1000)
        Button1.Enabled = True
    End Sub

    Private Sub Ac_Click(sender As Object, e As EventArgs) Handles Ac.Click
        Ac.Visible = False
        Kapa.Visible = True
        Me.MinimumSize = New Size(227, 242)


    End Sub

    Private Sub Kapa_Click(sender As Object, e As EventArgs) Handles Kapa.Click
        Kapa.Visible = False
        Ac.Visible = True
        Me.MaximumSize = New Size(227, 242)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox3.Text = Form3.T2.Interval


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox5.Text = Form3.T2.Interval
        TextBox3.Text = Form3.T4.Interval
        Button3.Enabled = True


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Form3.T2.Interval = Val(TextBox4.Text * 1000)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Form3.Close()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Form1.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form1.Close()
        Form3.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form3.T4.Interval = Val(TextBox6.Text * 1000)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TextBox5.Text = Form3.T4.Interval

    End Sub

    Private Sub BoyutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BoyutToolStripMenuItem1.Click
        Form4.Show()
    End Sub

    Private Sub BoyutBotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoyutBotToolStripMenuItem.Click
        Form1.Close()
        Me.Close()
        Form3.Close()
        Form4.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.TopMost = True
        ElseIf CheckBox1.Checked = False Then
            Me.TopMost = False

        End If
    End Sub
End Class

'Bu kaynağa ulaştıysanız Github.com/Jung1330 bağlantısından indirmişsiniz demektir.
'Yapımcım : Jung