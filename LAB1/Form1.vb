Public Class Form1
    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        lbl1.Text = txt1.Text * 12
        lbl2.Text = lbl1.Text * 0.05
        lbl3.Text = lbl1.Text - lbl2.Text
    End Sub
End Class
