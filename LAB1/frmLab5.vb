﻿Public Class frmLab5
    Dim decTotal As Double
    Dim decDiscount As Double
    Dim decNet As Double
    Dim decCredit As Double

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        lblTotal.Text = Val(txtPrice.Text) * Val(txtUnit.Text)
    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        lblTotal.Text = Val(txtUnit.Text) * Val(txtPrice.Text)
    End Sub

    Private Sub radMember_Click(sender As Object, e As EventArgs) Handles radMember.Click
        gpdPind.Enabled = True
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""

    End Sub

    Private Sub radOther_Click(sender As Object, e As EventArgs) Handles radOther.Click
        gpdPind.Enabled = False
        radPian.Select()
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub frmLab5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub radPian_Click(sender As Object, e As EventArgs) Handles radPian.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radCredit_Click(sender As Object, e As EventArgs) Handles radCredit.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim r1 As String = txtProduct.Text
        Dim r2 As Integer = Val(txtPrice.Text)
        Dim r3 As Integer = Val(txtUnit.Text)
        Dim r4 As Double
        If r1 = "" Or r2 <= 0 Or r3 <= 0 Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
        Else
            If radMember.Checked And radPian.Checked Then
                If lblTotal.Text < 1000 Then
                    decDiscount = 0
                    lblDiscount.Text = Val(lblTotal.Text * decDiscount)
                ElseIf lblTotal.Text < 5000 Then
                    decDiscount = 0.05
                    lblDiscount.Text = Val(lblTotal.Text * decDiscount)
                ElseIf lblTotal.Text < 10000 Then
                    decDiscount = 0.1
                    lblDiscount.Text = Val(lblTotal.Text * decDiscount)
                ElseIf lblTotal.Text >= 10000 Then
                    decDiscount = 0.15
                    lblDiscount.Text = Val(lblTotal.Text * decDiscount)
                End If
                lblPaid.Text = Val(lblTotal.Text) - Val(lblTotal.Text * decDiscount)
                lblCredit.Text = 0
            ElseIf radMember.Checked And radCredit.Checked Then
                decDiscount = 0
                lblDiscount.Text = 0
                lblPaid.Text = 0
                lblCredit.Text = lblTotal.Text
            ElseIf radOther.Checked Then
                decDiscount = 0
                lblDiscount.Text = 0
                lblPaid.Text = lblTotal.Text
                lblCredit.Text = 0
            End If
        End If

    End Sub
End Class