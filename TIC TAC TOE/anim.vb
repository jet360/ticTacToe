Public Class anim
    Dim x, y, v, h As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Location = New Point(x, y)
        'MessageBox.Show(Label1.Right)
        Label1.Text = Label1.Location.X

        If Label1.Location.X = 400 Then
            MessageBox.Show("true")
            h = -5
        ElseIf x = 0 Then
            h = 5
        End If

        x += h
        'MessageBox.Show(Me.Width)
    End Sub

   

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        y = Label1.Location.Y
        x = Label1.Location.X
        v = 1
        h = 5
        Timer1.Enabled = True

    End Sub
End Class