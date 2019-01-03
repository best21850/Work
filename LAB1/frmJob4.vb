Public Class frmJob4
    Dim dblYearSalary As Long
    Dim dblBonus As Long
    Dim dblAllIncome As Long
    Dim dblAllowance As Long
    Dim dblTax As Double
    Private Sub btnCalTax_Click(sender As Object, e As EventArgs) Handles btnCalTax.Click
        Dim decR_BONUS As Double
        Dim decR_TAX As Double
        Dim decR_ALLOW As Double
        Dim datNowDate As Date
        decR_ALLOW = 0.01
        decR_BONUS = 0.2
        decR_TAX = 0.07
        dblYearSalary = Val(txtSalary.Text) * 12
        dblBonus = Val(txtSale.Text * decR_BONUS)
        dblAllIncome = Val(dblYearSalary + dblBonus)
        dblAllowance = Val(dblAllIncome * decR_ALLOW)
        dblTax = Val(dblAllIncome - dblAllowance) * decR_TAX
        lblYearSalary.Text = dblYearSalary
        lblBonus.Text = dblBonus
        lblAllIncomes.Text = dblAllIncome
        lblAllowences.Text = dblAllowance
        lblTax.Text = dblTax.ToString("#,##0.00")
    End Sub

    Private Sub frmJob4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Format(Now, "General Date")
    End Sub
    Private Sub radShortDate_Click(sender As Object, e As EventArgs) Handles radShortDate.Click, radShortDate.CheckedChanged
        lblDate.Text = Format(Now, "short Date")
    End Sub

    Private Sub radGenDate_Click(sender As Object, e As EventArgs) Handles radGenDate.Click, radGenDate.CheckedChanged
        lblDate.Text = Format(Now, "General Date")
    End Sub

    Private Sub radLongDate_Click(sender As Object, e As EventArgs) Handles radLongDate.Click, radLongDate.CheckedChanged
        lblDate.Text = Format(Now, "Long Date")
    End Sub
End Class