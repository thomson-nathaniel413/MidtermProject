Public Class frmConverter
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' upon form load
        radInToM.Checked = True
    End Sub
End Class
