Public Class frmJob6
    Dim total, sum As Double

    Private Sub chkCarForMe_CheckedChanged(sender As Object, e As EventArgs) Handles chkCarForMe.CheckedChanged
        If chkCarForMe.Checked Then
            lblPaidPrice.Text = total
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True

        Else
            If MsgBox("ท่านไม่ได้ซื้อรถแล้ว", vbYesNo) = vbYes Then
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False
                lblPaidPrice.Text = ""
            Else
                chkCarForMe.Checked = True
                lblPaidPrice.Text = FormatNumber(total)
            End If
        End If
    End Sub



    Private Sub chkFree1_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree1.CheckedChanged
        If chkFree1.Checked Then
            total -= 25000
        Else
            total += 25000

        End If
        lblPaidPrice.Text = FormatNumber(total)
    End Sub

    Private Sub chkFree2_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree2.CheckedChanged
        If chkFree2.Checked Then
            total -= 15000

        Else
            total += 15000

        End If
        lblPaidPrice.Text = FormatNumber(total)
    End Sub

    Private Sub chkFree3_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree3.CheckedChanged
        If chkFree3.Checked Then
            total -= 35000
        Else
            total += 35000
        End If
        lblPaidPrice.Text = FormatNumber(total)
    End Sub
    Private Sub chkItemsAdd4_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd4.CheckedChanged
        If chkItemsAdd4.Checked Then
            total += 30000
        Else
            total -= 30000
        End If
        lblPaidPrice.Text = FormatNumber(total)
    End Sub

    Private Sub chkItemsAdd2_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd2.CheckedChanged
        If chkItemsAdd2.Checked Then
            total += 50000
        Else
            total -= 50000
        End If
        lblPaidPrice.Text = FormatNumber(total)
    End Sub

    Private Sub chkItemsAdd3_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd3.CheckedChanged
        If chkItemsAdd3.Checked Then
            total += 20000
        Else
            total -= 20000
        End If
        lblPaidPrice.Text = FormatNumber(total)
    End Sub

    Private Sub frmJob6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sum = 1250000
        total = sum + Val(lblFree1.Text) + Val(lblFree2.Text) + Val(lblFree3.Text)
    End Sub

    Private Sub chkItemsAdd1_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd1.CheckedChanged
        If chkItemsAdd1.Checked Then
            total += 40000
        Else
            total -= 40000
        End If
        lblPaidPrice.Text = FormatNumber(total)
    End Sub
End Class