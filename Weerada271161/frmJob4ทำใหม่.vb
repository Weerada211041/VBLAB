Public Class frmJob4ทำใหม่

    Private Sub btnCaltax_Click(sender As Object, e As EventArgs) Handles btnCaltax.Click
        Const decR_BONUS As Double = 0.2
        Const decR_ALLOW As Double = 0.01
        Const decR_TAX As Double = 0.07
        Dim dblYearSalary As Double
        Dim dblBonus As Double
        Dim dblAllncome As Double
        Dim dblAllowance As Double
        Dim dblTax As Double

        dblYearSalary = Val(txtSalary.Text) * 12
        dblBonus = Val(txtSale.Text) * decR_BONUS
        dblAllncome = dblYearSalary + dblBonus
        dblAllowance = dblAllncome * decR_ALLOW
        dblTax = (dblAllncome - dblAllowance) * decR_TAX

        lblYearSalary.Text = dblYearSalary.ToString("#,###.##")
        lblBonus.Text = dblBonus.ToString("#,###.##")
        lblAllncome.Text = dblAllncome.ToString("#,###.##")
        lblAollowance.Text = dblAllowance.ToString("#,###.##")
        lblTax.Text = dblTax.ToString("#,###.##")

    End Sub

    Private Sub frmJob4ทำใหม่_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now

    End Sub

    Private Sub radShortDate_Click(sender As Object, e As EventArgs) Handles radShortDate.Click
        lblDate.Text = Format(Now, "Short Date")
    End Sub

    Private Sub radGenDate_Click(sender As Object, e As EventArgs) Handles radGenDate.Click
        lblDate.Text = Format(Now, "General Date")
    End Sub

    Private Sub radLongDate_Click(sender As Object, e As EventArgs) Handles radLongDate.Click
        lblDate.Text = Format(Now, "Long Date")
    End Sub


End Class