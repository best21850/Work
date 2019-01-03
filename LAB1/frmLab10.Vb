Public Class frmLab10
    Dim decSale(4, 2) As Integer
    Dim saleName(4) As String
    Dim intIndex, decSumSale As Decimal
    Dim cnt As Integer = 0

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not IsNumeric(txtSaleA.Text) Or Not IsNumeric(txtSaleB.Text) Or Not IsNumeric(txtSaleC.Text) Then
            MsgBox("กรอกข้อมูลตัวเลขเท่านั้น")
            txtSaleA.Clear()
            txtSaleB.Clear()
            txtSaleC.Clear()
            txtSaleA.Focus()
        Else
            cnt = cboIndex.SelectedIndex
            lstData.SelectedIndex = cnt
            lstData.Items.RemoveAt(cnt)
            Dim sale(2) As Integer
            sale(0) = Val(txtSaleA.Text)
            sale(1) = Val(txtSaleB.Text)
            sale(2) = Val(txtSaleC.Text)
            For i = 0 To 2
                saleName(cnt) = txtSaleName.Text
                decSale(cnt, i) = sale(i)
            Next
            Call showData()
        End If
    End Sub
    Private Sub showData()
        Dim salea, saleb, salec As Integer
        lstData.Items.Clear()
        For i = 0 To cboIndex.Items.Count - 1
            lstData.Items.Add(saleName(i) & "," & decSale(i, 0) & "," & decSale(i, 1) & "," & decSale(i, 2))
        Next

        For i = 0 To 4
            salea = salea + decSale(i, 0)
            saleb = saleb + decSale(i, 1)
            salec = salec + decSale(i, 2)
        Next

        lblSumA.Text = salea
        lblSumB.Text = saleb
        lblSumC.Text = salec

        Dim max As Integer = decSale(0, 0) + decSale(0, 1) + decSale(0, 2)
        Dim n As Integer = 0
        For i = 1 To cboIndex.Items.Count - 1
            If max < decSale(i, 0) + decSale(i, 1) + decSale(i, 2) Then
                max = decSale(i, 0) + decSale(i, 1) + decSale(i, 2)
                n = i
            End If
            lblMaxSaleAmount.Text = max
            lblMaxSaleName.Text = saleName(n)
        Next
    End Sub
    Private Sub frmLab10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboIndex.SelectedIndex = 0
    End Sub
End Class