Public Class frmJob6
    Private Sub frmJob6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        lblPaidPrice.Enabled = False
    End Sub

    Private Sub chkCarForMe_CheckedChanged(sender As Object, e As EventArgs) Handles chkCarForMe.CheckedChanged
        If chkCarForMe.Checked Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            lblPaidPrice.Enabled = True
            lblPaidPrice.Text = Val(lblStartPrice.Text) + Val(lblFree1.Text) + Val(lblFree2.Text) + Val(lblFree3.Text)
        Else
            If MsgBox("คุณต้องการยกเลิกการซื้อรถใช่หรือไม่", vbYesNo) = vbYes Then
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                lblPaidPrice.Text = ""

            Else
                chkCarForMe.Enabled = True
            End If
        End If

    End Sub

    Private Sub chkItemsAdd1_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd1.CheckedChanged
        If chkItemsAdd1.Checked Then
            lblPaidPrice.Text = Val(lblItemsPrice1.Text) + Val(lblPaidPrice.Text)
        Else
            lblPaidPrice.Text -= Val(lblItemsPrice1.Text)
        End If
    End Sub

    Private Sub chkItemsAdd2_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd2.CheckedChanged
        If chkItemsAdd2.Checked Then
            lblPaidPrice.Text = Val(lblItemsPrice2.Text) + Val(lblPaidPrice.Text)
        Else
            lblPaidPrice.Text -= Val(lblItemsPrice2.Text)
        End If
    End Sub

    Private Sub chkItemsAdd3_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd3.CheckedChanged
        If chkItemsAdd3.Checked Then
            lblPaidPrice.Text = Val(lblItemsPrice3.Text) + Val(lblPaidPrice.Text)
        Else
            lblPaidPrice.Text -= Val(lblItemsPrice3.Text)
        End If
    End Sub

    Private Sub chkItemsAdd4_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd4.CheckedChanged
        If chkItemsAdd4.Checked Then
            lblPaidPrice.Text = Val(lblItemsPrice4.Text) + Val(lblPaidPrice.Text)
        Else
            lblPaidPrice.Text -= Val(lblItemsPrice4.Text)
        End If
    End Sub

    Private Sub chkFree1_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree1.CheckedChanged
        If chkFree1.Checked Then
            lblPaidPrice.Text -= Val(lblFree1.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree1.Text)
        End If
    End Sub

    Private Sub chkFree2_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree2.CheckedChanged
        If chkFree2.Checked Then
            lblPaidPrice.Text -= Val(lblFree2.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree2.Text)
        End If
    End Sub

    Private Sub chkFree3_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree3.CheckedChanged
        If chkFree3.Checked Then
            lblPaidPrice.Text -= Val(lblFree3.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree3.Text)
        End If
    End Sub
End Class