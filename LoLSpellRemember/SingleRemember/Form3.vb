Imports System.Media
Imports System.ComponentModel.Component
Imports System.Windows.Forms.KeyEventArgs
Imports System.Threading
Imports System.IO


Public Class Form3

    Dim T11 As New SoundPlayer(My.Resources.T11)
    Dim T22 As New SoundPlayer(My.Resources.T22)
    Dim T33 As New SoundPlayer(My.Resources.T33)
    Dim T44 As New SoundPlayer(My.Resources.T44)
    Dim T111 As New SoundPlayer(My.Resources.T111)
    Dim T112 As New SoundPlayer(My.Resources.T112)
    Dim T211 As New SoundPlayer(My.Resources.T211)
    Dim T212 As New SoundPlayer(My.Resources.T212)
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.T11 = New SoundPlayer(My.Resources.T11)
        Me.T22 = New SoundPlayer(My.Resources.T22)
        Me.T33 = New SoundPlayer(My.Resources.T33)
        Me.T44 = New SoundPlayer(My.Resources.T44)
        Me.T111 = New SoundPlayer(My.Resources.T111)
        Me.T112 = New SoundPlayer(My.Resources.T112)
        Me.T211 = New SoundPlayer(My.Resources.T211)
        Me.T212 = New SoundPlayer(My.Resources.T212)


        Me.MaximumSize = New Size(0, 0)
        Me.KeyPreview = True
        Application.DoEvents()
        BackColor = Color.Coral
        TransparencyKey = BackColor
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Keys.H Then
            Me.T11.Play()
            Me.T1.Start()
            Button1.BackColor = Color.Red
        End If
        Me.T11.Play()
        Me.T1.Start()
        Button1.BackColor = Color.Red
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Keys.J Then
            Me.T22.Play()
            Me.T4.Start()
            Button4.BackColor = Color.Red
        End If
        Me.T22.Play()
        Me.T4.Start()
        Button4.BackColor = Color.Red

    End Sub

    Private Sub T1_Tick(sender As Object, e As EventArgs) Handles T1.Tick
        Me.T111.Play()
        T1.Stop()
        Button1.BackColor = Color.FromArgb(0, 255, 0)
    End Sub

    Private Sub T2_Tick(sender As Object, e As EventArgs) Handles T2.Tick
        Me.T212.Play()                                                                      'SES DOSYASI GELECEK'
        T2.Stop()
        Button3.BackColor = Color.FromArgb(0, 255, 0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Keys.N Then
            Me.T33.Play()
            Me.T3.Start()
            Button2.BackColor = Color.Red
        End If
        Me.T33.Play()
        Me.T3.Start()
        Button2.BackColor = Color.Red
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Keys.M Then
            Me.T44.Play()
            Me.T2.Start()
            Button3.BackColor = Color.Red
        End If
        Me.T44.Play()
        Me.T2.Start()
        Button3.BackColor = Color.Red
    End Sub

    Private Sub T4_Tick(sender As Object, e As EventArgs) Handles T4.Tick
        Me.T112.Play()
        T4.Stop()
        Button4.BackColor = Color.FromArgb(0, 255, 0)
    End Sub

    Private Sub T3_Tick(sender As Object, e As EventArgs) Handles T3.Tick
        Me.T211.Play()
        T3.Stop()
        Button2.BackColor = Color.FromArgb(0, 255, 0)
    End Sub
End Class