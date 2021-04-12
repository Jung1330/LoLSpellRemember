Imports System.Media
Imports System.ComponentModel.Component
Imports System.Windows.Forms.KeyEventArgs
Imports System.Threading
Imports System.IO
Public Class Form1

    Dim BirBir As New SoundPlayer(My.Resources.BirTik)
    Dim Birİki As New SoundPlayer(My.Resources.BirTik2)
    Dim İkiBir As New SoundPlayer(My.Resources.İkiTik)
    Dim İkiİki As New SoundPlayer(My.Resources.İkiTik2)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BirBir = New SoundPlayer(My.Resources.BirTik)
        Me.Birİki = New SoundPlayer(My.Resources.BirTik2)
        Me.İkiBir = New SoundPlayer(My.Resources.İkiTik)
        Me.İkiİki = New SoundPlayer(My.Resources.İkiTik2)
        Me.MaximumSize = New Size(0, 0)
        Me.KeyPreview = True

        Application.DoEvents()
        BackColor = Color.Coral
        TransparencyKey = BackColor
    End Sub
    Private Sub BTimer1_Tick(sender As Object, e As EventArgs) Handles BTimer1.Tick

        Me.Birİki.Play()
        BTimer1.Stop()
        Button1.BackColor = Color.FromArgb(0, 255, 0)
    End Sub

    Private Sub İTimer2_Tick(sender As Object, e As EventArgs) Handles İTimer2.Tick

        Me.İkiİki.Play()
        İTimer2.Stop()
        Button2.BackColor = Color.FromArgb(0, 255, 0)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Keys.M Then
            Me.İkiBir.Play()
            İTimer2.Start()
            Button2.BackColor = Color.Red
        End If
        Me.İkiBir.Play()
        İTimer2.Start()
        Button2.BackColor = Color.Red
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Keys.N Then
            Me.BirBir.Play()
            BTimer1.Start()
            Button1.BackColor = Color.Red
        End If
        Me.BirBir.Play()
        BTimer1.Start()
        Button1.BackColor = Color.Red
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub
End Class
