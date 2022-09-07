Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age As Integer
        Integer.TryParse(TextBox1.Text, age)
        Label1.Text = age
        If age > 18 Then
            Label1.Text = "you can vote"
            Me.BackColor = Color.Green
        Else Label1.Text = "you cannot vote"
            Me.BackColor = Color.DarkRed
            If CheckBox1.Checked Then
                Me.BackColor = Color.Blue
                If CheckBox2.Checked Then
                    Me.BackColor = Color.Orange
                End If

            End If
            If CheckBox1.Checked And CheckBox2.Checked Then
                Me.BackColor = Color.Indigo
            End If
        End If
    End Sub
End Class
