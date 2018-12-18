Public Class frmLab5
    Dim decTotal As Double
    Dim decDiscount As Double
    Dim decNet As Double
    Dim decCredit As Double
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        decDiscount = 0
        Dim a1 As String = Val(txtProduct.Text)
        Dim a2 As Integer = Val(txtPrice.Text)
        Dim a3 As Integer = Val(txtUnit.Text)

        If a1 = "" Or a2 <= 0 Or a3 <= 0 Then

            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
        Else
            If radMember.Checked And radPaid.Checked Then
                If decTotal < 1000 Then
                    decDiscount = 0
                ElseIf decTotal < 5000 Then
                    decDiscount = 0.05 * decTotal
                ElseIf decTotal < 10000 Then
                    decDiscount = 0.1 * decTotal
                ElseIf decTotal >= 10000 Then
                    decDiscount = 0.15 * decTotal
                End If
                decNet = decTotal - decDiscount
            ElseIf radMember.Checked And radCredit.Checked Then
                decDiscount = 0
                decNet = decTotal
                decCredit = decTotal
            Else
                decNet = decTotal - decDiscount
                decCredit = 0
            End If
        End If

        lblTotal.Text = FormatNumber(decTotal)
        lblPaid.Text = FormatNumber(decNet)
        lblDiscount.Text = FormatNumber(decDiscount)
        lblCredit.Text = FormatNumber(decCredit)


    End Sub

    Private Sub radMember_CheckedChanged(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
        radPaid.Select()
        radCredit.Enabled = True
        gpbPaid.Enabled = True
    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        lblTotal.Text = decTotal
    End Sub

    Private Sub radPaid_CheckedChanged(sender As Object, e As EventArgs) Handles radPaid.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radOther_CheckedChanged(sender As Object, e As EventArgs) Handles radOther.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
        radPaid.Select()
        gpbPaid.Enabled = False
    End Sub

    Private Sub frmLab5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radMember.Select()
        radPaid.Select()
    End Sub
End Class