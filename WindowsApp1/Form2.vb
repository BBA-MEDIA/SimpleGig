Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click

        Dim result As DialogResult = MessageBox.Show("Do you want to remove this track?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's choice
        If result = DialogResult.Yes Then
            Buttons(CurrentButton).text = "TRACK" + Str(CurrentButton)
            Form1.SaveFile()
        Else
            Me.Close()

        End If

        Me.Close()

    End Sub

    Private Sub ButtonShuffle_Click(sender As Object, e As EventArgs) Handles ButtonShuffleR.Click

        Dim result As DialogResult = MessageBox.Show("Do you want to shuffle tracks right? Track 20 will be removed.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's choice
        If result = DialogResult.Yes Then

            For j = 20 To CurrentButton + 1 Step -1

                If Mid(Buttons(j - 1).Text, 1, 5) <> "TRACK" Then

                    Buttons(j).text = Buttons(j - 1).text
                    Buttons(j - 1).text = "TRACK" + Str(j - 1)

                End If

            Next j

            Form1.SaveFile()

        Else
            Me.Close()

        End If

        Me.Close()

    End Sub

    Private Sub ButtonShuffleL_Click(sender As Object, e As EventArgs) Handles ButtonShuffleL.Click

        Dim result As DialogResult = MessageBox.Show("Do you want to shuffle tracks left? Track" + Str(CurrentButton - 1) + " Will be removed.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's choice
        If result = DialogResult.Yes Then

            For j = CurrentButton To 19

                'If Mid(Buttons(j + 1).Text, 1, 5) <> "TRACK" Then

                Buttons(j - 1).text = Buttons(j).text
                'Buttons(j).text = "TRACK" + Str(j)

                'End If

            Next j

            Form1.SaveFile()

        Else
            Me.Close()

        End If

        Me.Close()

    End Sub
End Class