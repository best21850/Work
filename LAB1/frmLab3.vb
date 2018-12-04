Public Class frmLab3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btup.Click
        txtInput.Text = Val(txtInput.Text) + 2
    End Sub

    Private Sub lblFWhite_Click(sender As Object, e As EventArgs) Handles lblFWhite.Click
        txtInput.ForeColor = Color.White
    End Sub

    Private Sub lblFRed_Click(sender As Object, e As EventArgs) Handles lblFRed.Click
        txtInput.ForeColor = Color.Red
    End Sub

    Private Sub lblFBlue_Click(sender As Object, e As EventArgs) Handles lblFBlue.Click
        txtInput.ForeColor = Color.Blue
    End Sub

    Private Sub lblFGreen_Click(sender As Object, e As EventArgs) Handles lblFGreen.Click
        txtInput.ForeColor = Color.Green
    End Sub

    Private Sub lblFViolet_Click(sender As Object, e As EventArgs) Handles lblFViolet.Click
        txtInput.ForeColor = Color.Violet
    End Sub

    Private Sub lblFBlack_Click(sender As Object, e As EventArgs) Handles lblFBlack.Click
        txtInput.ForeColor = Color.Black
    End Sub

    Private Sub lblFOrange_Click(sender As Object, e As EventArgs) Handles lblFOrange.Click
        txtInput.ForeColor = Color.Orange
    End Sub

    Private Sub lblFYellow_Click(sender As Object, e As EventArgs) Handles lblFYellow.Click
        txtInput.ForeColor = Color.Yellow
    End Sub

    Private Sub lblFBrown_Click(sender As Object, e As EventArgs) Handles lblFBrown.Click
        txtInput.ForeColor = Color.Brown
    End Sub

    Private Sub lblFSky_Click(sender As Object, e As EventArgs) Handles lblFSky.Click
        txtInput.ForeColor = Color.SkyBlue
    End Sub

    Private Sub lblBRed_Click(sender As Object, e As EventArgs) Handles lblBRed.Click
        txtInput.BackColor = Color.Red
    End Sub

    Private Sub lblnBBlue_Click(sender As Object, e As EventArgs) Handles lblnBBlue.Click
        txtInput.BackColor = Color.Blue
    End Sub

    Private Sub lblBGreen_Click(sender As Object, e As EventArgs) Handles lblBGreen.Click
        txtInput.BackColor = Color.Green
    End Sub

    Private Sub lblBViolet_Click(sender As Object, e As EventArgs) Handles lblBViolet.Click
        txtInput.BackColor = Color.Violet
    End Sub

    Private Sub lblBBlack_Click(sender As Object, e As EventArgs) Handles lblBBlack.Click
        txtInput.BackColor = Color.Black
    End Sub

    Private Sub lblBOrange_Click(sender As Object, e As EventArgs) Handles lblBOrange.Click
        txtInput.BackColor = Color.Orange
    End Sub

    Private Sub lblBYellow_Click(sender As Object, e As EventArgs) Handles lblBYellow.Click
        txtInput.BackColor = Color.Yellow
    End Sub

    Private Sub lblBBrown_Click(sender As Object, e As EventArgs) Handles lblBBrown.Click
        txtInput.BackColor = Color.Brown
    End Sub

    Private Sub lblBwhite_Click(sender As Object, e As EventArgs) Handles lblBwhite.Click
        txtInput.BackColor = Color.White
    End Sub

    Private Sub lblBSky_Click(sender As Object, e As EventArgs) Handles lblBSky.Click
        txtInput.BackColor = Color.SkyBlue
    End Sub

    Private Sub frmLab3_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Btdown_Click(sender As Object, e As EventArgs) Handles Btdown.Click
        txtInput.Text = Val(txtInput.Text) - 2
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosize.SelectedIndexChanged
        txtInput.Font = New Font(txtInput.Font.Name, cbosize.SelectedItem, FontStyle.Regular)
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub
End Class