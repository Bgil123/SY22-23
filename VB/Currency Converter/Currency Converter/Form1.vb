Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = dollarTextBox.Text
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Me.Close()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dollars As Decimal
        Decimal.TryParse(dollarTextBox.Text, dollars)
        Dim Pesos As Decimal
        Pesos = Dollars * 20
        pesotextbox.Text = Pesos.ToString("n2")
        Dim euro As Decimal
        euro = dollars * 1
        Eurotextbox.Text = euro.ToString("n2")
        Dim yen As Decimal
        yen = dollars * 136.55
        yenTextBox.Text = yen.ToString("n2")
        Dim pounds As Decimal
        pounds = dollars * 0.85
        poundTextBox.Text = pounds.ToString("n2")
        Dim won As Decimal
        won = dollars * 1333.98
        wonTextBox.Text = won.ToString("n2")

    End Sub
End Class
