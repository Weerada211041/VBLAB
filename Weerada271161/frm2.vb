Public Class frm2
    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim sale1 As Double
        Dim sale2 As Double
        Dim TotalSale As Double
        Dim Commition1 As Double
        Dim Commition2 As Double
        Dim TotalCommition As Double

        sale1 = Val(txtComputer.Text)
        sale2 = Val(txtPrinter.Text)
        TotalSale = sale1 + sale2
        Commition1 = sale1 * 5 / 100
        Commition2 = sale2 * 10 / 100
        TotalCommition = Commition1 + Commition2

        lbltotalCommition.Text = TotalCommition
        lblSale1.Text = sale1
        lblSale2.Text = sale2
        lbltotalSale.Text = TotalSale
        lblCommition1.Text = Commition1
        lblCommition2.Text = Commition2




    End Sub

    Private Sub frm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class