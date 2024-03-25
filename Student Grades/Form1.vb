Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Dim num As Int32

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calculatebtn.Click
        num = Convert.ToInt32(Gradetxtbox.Text)

        If num <= 39 Then

            Answertxt.Text = "failed"

        ElseIf num <= 49 Then

            Answertxt.Text = "supplimentary"

        ElseIf num <= 74 Then

            Answertxt.Text = "PASS"

        Else

            Answertxt.Text = "A+"

        End If
    End Sub


End Class
