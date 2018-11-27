Public Class Form1
    Private Sub btsum_Click(sender As Object, e As EventArgs) Handles btcalculate.Click
        lalMoney.Text = txtMoney.Text * 12
        lalTax.Text = lalMoney.Text * 5 / 100
        lalTotal.Text = lalMoney.Text - lalTax.Text


    End Sub
End Class
