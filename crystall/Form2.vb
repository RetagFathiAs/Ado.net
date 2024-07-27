Imports System.Data
Imports System.Data.OleDb
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms


Public Class Form2

  Public texts As String


  Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
    texts = searchtext.Text
    nametxet.Text = texts

    Me.Refresh()
  End Sub
  Public Function sett()

    Dim en As String = Me.searchtext.Text

    Return (en)
  End Function

  Private Sub delbtn_Click(sender As Object, e As EventArgs)


  End Sub

  Private Sub codingbtn_Click(sender As Object, e As EventArgs) Handles codingbtn.Click



    Dim cr As New crystal_coding()
    cr.Show()
  End Sub

  Private Sub noncodingbtn_Click(sender As Object, e As EventArgs) Handles noncodingbtn.Click

    Dim f As New form
    f.Show()
  End Sub

  Private Sub searchbtn_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub nametxet_Click(sender As Object, e As EventArgs) Handles nametxet.Click

  End Sub
End Class