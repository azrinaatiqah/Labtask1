Public Class Form1

    Private Sub BtnSum_Click(sender As Object, e As EventArgs) Handles BtnSum.Click

        TxtResult.Text = (Convert.ToInt32(TxtNum1.Text) + Convert.ToInt32(TxtNum2.Text)).ToString()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub
End Class
