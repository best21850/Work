Public Class Form2
    Private Sub btshow_Click(sender As Object, e As EventArgs) Handles btshow.Click
        Dim IngSaleacer As Long
        Dim IngSalehp As Long
        Dim TotalSale As Long
        Dim Commiss As Double
        Dim Commiss2 As Double
        Dim Total As Double
        IngSaleacer = txtacer.Text
        IngSalehp = txthp.Text
        TotalSale = IngSaleacer + IngSalehp
        Commiss = IngSaleacer * 0.05
        Commiss2 = IngSalehp * 0.1
        Total = Commiss + Commiss2
        lblsale.Text = TotalSale
        lblcommiss.Text = Commiss
        lblcommiss2.Text = Commiss2
        lbltotal.Text = Total
    End Sub
End Class