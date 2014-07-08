Public Class Form1

    Dim playerimg As Bitmap = My.Resources.x
    Dim cpuimg As Bitmap = My.Resources.o
    Dim cTurn As Integer
    Dim ended As Boolean = False


    Enum turn As Integer
        player = 1
        cpu = 0
    End Enum

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Update()
        start()

        'Dim im As PictureBox = CType(TableLayoutPanel1.Controls.Item(0), PictureBox)

        If cTurn = turn.cpu Then
            cpuPlay()
        End If

    End Sub

    Private Sub start()
        Dim r As New Random()


        cTurn = r.Next(2)
        MessageBox.Show(cTurn)


        If turn.cpu = cTurn Then
            MessageBox.Show("I will start the game")


        Else
            MessageBox.Show("you will start the game")

        End If


    End Sub

    Function allEmp() As ArrayList
        Dim emptLs As New ArrayList
        If ended = False Then

            For Each Ctr As PictureBox In TableLayoutPanel1.Controls
                'MessageBox.Show(IsNothing(Ctr.Image))
                If IsNothing(Ctr.Image) Then
                    emptLs.Add(Ctr)
                End If

            Next

        End If

        Return emptLs

        'MessageBox.Show(emptLs.Count)
    End Function


    Sub cpuPlay()

        If allEmp.Count > 0 Then

            Dim r As New Random
            Dim i As Integer = r.Next(allEmp.Count)

            CType(allEmp.Item(i), PictureBox).Image = cpuimg

            If isWinner(cpuimg) Then
                MessageBox.Show("cpu won")
                ended = True
            End If


        Else
            ended = True
        End If

        cTurn = turn.player

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Not ended And cTurn = turn.player And IsNothing(PictureBox1.Image) Then
            PictureBox1.Image = playerimg
           
            If isWinner(playerimg) Then
                MessageBox.Show("you won!!")
                ended = True
            End If
            cpuPlay()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Not ended And cTurn = turn.player And IsNothing(PictureBox2.Image) Then
            PictureBox2.Image = playerimg


            If isWinner(playerimg) Then
                MessageBox.Show("you won!!")
                ended = True
            End If
            cpuPlay()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Not ended And cTurn = turn.player And IsNothing(PictureBox3.Image) Then
            PictureBox3.Image = playerimg


            If isWinner(playerimg) Then
                MessageBox.Show("you won!!")
                ended = True
            End If
            cpuPlay()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Not ended And cTurn = turn.player And IsNothing(PictureBox4.Image) Then
            PictureBox4.Image = playerimg


            If isWinner(playerimg) Then
                MessageBox.Show("you won!!")
                ended = True
            End If
            cpuPlay()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If Not ended And cTurn = turn.player And IsNothing(PictureBox5.Image) Then
            PictureBox5.Image = playerimg


            If isWinner(playerimg) Then
                MessageBox.Show("you won!!")
                ended = True
            End If
            cpuPlay()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If Not ended And cTurn = turn.player And IsNothing(PictureBox6.Image) Then
            PictureBox6.Image = playerimg


            If isWinner(playerimg) Then
                MessageBox.Show("you won!!")
                ended = True
            End If
            cpuPlay()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If Not ended And cTurn = turn.player And IsNothing(PictureBox7.Image) Then
            PictureBox7.Image = playerimg
            cpuPlay()

            If isWinner(playerimg) Then
                MessageBox.Show("you won!!")
                ended = True
            End If
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If Not ended And cTurn = turn.player And IsNothing(PictureBox8.Image) Then
            PictureBox8.Image = playerimg

            If isWinner(playerimg) Then
                MessageBox.Show("you won!!")
                ended = True
            End If
            cpuPlay()
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If Not ended And cTurn = turn.player And IsNothing(PictureBox9.Image) Then
            PictureBox9.Image = playerimg


            If isWinner(playerimg) Then
                MessageBox.Show("you won!!")
                ended = True
            End If
            cpuPlay()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each picbox As PictureBox In TableLayoutPanel1.Controls
            picbox.Image = Nothing
            ended = False

            If isWinner(playerimg) Then
                MessageBox.Show("you won!!")
                ended = True
            End If
        Next
    End Sub


    Private Function isWinner(cPlayer As Image) As Boolean

        Return (cPlayer.Equals(pic(0)) And cPlayer.Equals(pic(1)) And cPlayer.Equals(pic(2))) Or
            (cPlayer.Equals(pic(3)) And cPlayer.Equals(pic(4)) And cPlayer.Equals(pic(5))) Or
             (cPlayer.Equals(pic(6)) And cPlayer.Equals(pic(7)) And cPlayer.Equals(pic(8))) Or
              (cPlayer.Equals(pic(3)) And cPlayer.Equals(pic(0)) And cPlayer.Equals(pic(6))) Or
               (cPlayer.Equals(pic(1)) And cPlayer.Equals(pic(7)) And cPlayer.Equals(pic(4))) Or
                (cPlayer.Equals(pic(2)) And cPlayer.Equals(pic(5)) And cPlayer.Equals(pic(8))) Or
                 (cPlayer.Equals(pic(2)) And cPlayer.Equals(pic(4)) And cPlayer.Equals(pic(6))) Or
                  (cPlayer.Equals(pic(8)) And cPlayer.Equals(pic(4)) And cPlayer.Equals(pic(0)))




    End Function

    Private Function pic(index As Integer) As Image

        Return CType(TableLayoutPanel1.Controls.Item(index), PictureBox).Image

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        anim.Show()
    End Sub
End Class


