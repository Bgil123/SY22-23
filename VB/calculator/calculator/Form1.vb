Public Class Form1
    Dim first As Decimal
    Dim second As Decimal
    Dim opper As String
    Dim mem As Decimal
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        displaytextbox.Text = displaytextbox.Text + sender.text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        displaytextbox.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles plusbutton.Click
        Decimal.TryParse(displaytextbox.Text, first)
        opper = sender.text
        displaytextbox.Clear()
    End Sub

    Private Sub equalButton_Click(sender As Object, e As EventArgs) Handles equalbutton.Click
        Decimal.TryParse(displaytextbox.Text, second)
        If opper = "+" Then
            displaytextbox.Text = first + second
        End If
        If opper = "-" Then
            displaytextbox.Text = first - second
        End If
        If opper = "/" Then
            displaytextbox.Text = first / second
        End If
        If opper = "X" Then
            displaytextbox.Text = first * second
        End If
    End Sub

    Private Sub minusButton_Click(sender As Object, e As EventArgs) Handles minusButton.Click
        Decimal.TryParse(displaytextbox.Text, first)
        opper = sender.text
        displaytextbox.Clear()
    End Sub

    Private Sub dividButton_Click(sender As Object, e As EventArgs) Handles dividButton.Click
        Decimal.TryParse(displaytextbox.Text, first)
        opper = sender.text
        displaytextbox.Clear()
    End Sub

    Private Sub multiplyButton_Click(sender As Object, e As EventArgs) Handles multiplyButton.Click
        Decimal.TryParse(displaytextbox.Text, first)
        opper = sender.text
        displaytextbox.Clear()
    End Sub

    Private Sub sqbtton_Click(sender As Object, e As EventArgs) Handles sqrtbtton.Click
        Decimal.TryParse(displaytextbox.Text, first)
        displaytextbox.Text = Math.Sqrt(first)
    End Sub

    Private Sub sinbutton_Click(sender As Object, e As EventArgs) Handles sinbutton.Click
        Decimal.TryParse(displaytextbox.Text, first)
        displaytextbox.Text = Math.Sin(first)
    End Sub

    Private Sub cosbutton_Click(sender As Object, e As EventArgs) Handles cosbutton.Click
        Decimal.TryParse(displaytextbox.Text, first)
        displaytextbox.Text = Math.Cos(first)
    End Sub

    Private Sub tanButton_Click(sender As Object, e As EventArgs) Handles tanButton.Click
        Decimal.TryParse(displaytextbox.Text, first)
        displaytextbox.Text = Math.Tan(first)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles pibutton.Click
        displaytextbox.Text = Math.PI
    End Sub

    Private Sub Mplusbutton_Click(sender As Object, e As EventArgs) Handles Mplusbutton.Click
        Decimal.TryParse(displaytextbox.Text, mem)
    End Sub

    Private Sub MCButton_Click(sender As Object, e As EventArgs) Handles MCButton.Click
        mem = 0
    End Sub

    Private Sub MRButton_Click(sender As Object, e As EventArgs) Handles MRButton.Click
        displaytextbox.Text = mem
    End Sub
End Class