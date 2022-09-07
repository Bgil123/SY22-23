Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Label1.Text = nametextbox.Text
    End Sub

    Private Sub cancelbutton_Click(sender As Object, e As EventArgs) Handles cancelbutton.Click
        Me.Close()
    End Sub

    Private Sub Buybutton_Click(sender As Object, e As EventArgs) Handles Buybutton.Click
        Dim amount As Decimal
        Decimal.TryParse(amountTextBox.Text, amount)
        Dim fee As Decimal
        fee = amount * 0.03
        nametextbox.Clear()
        CCTextBox.Clear()
        ExpdateTextBox.Clear()
        ziptextbox.Clear()
        amountTextBox.Clear()
        feetextbox.Text = fee.ToString("c2")
    End Sub
End Class