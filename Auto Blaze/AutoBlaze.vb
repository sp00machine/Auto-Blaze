Public Class AutoBlaze
    Dim Times As Integer = 0 'Represents how many seconds have elapsed since the last timed blaze
    Dim Blazed As Boolean = False 'Tells whether you have blazed at this time already with the timed blaze. Prevents constant blazing at 4:20

    Private Sub BlazeButton_Click(sender As Object, e As EventArgs) Handles BlazeButton.Click 'Calls the "Blaze" sub when you press the "Blaze it!" button
        Me.Blaze()
    End Sub

    Private Sub BlazeTimer_Tick(sender As Object, e As EventArgs) Handles BlazeTimer.Tick 'Gets called every second, handles all of the timer logic
        If ABEvery.Checked Then 'This only gets called if you set the program to blaze every specified interval
            If Times >= TickChooser.Text Then 'If times is greater than the specified interval between blazes, then it will blaze and reset the counter
                Me.Blaze()

                LoadBar.Value = LoadBar.Minimum
                Times = 0
            End If

            If TickChooser.Text >= 0 Then 'Handles the progress bar
                LoadBar.Value = (Times + 0) * LoadBar.Maximum / TickChooser.Text
            End If

            Times += 1

        Else 'If you have NOT selected the the "Blaze every X seconds" option, then the times counter and the loadbar will be reset
            Times = 0
            LoadBar.Value = LoadBar.Minimum
        End If

        If ABTimed.Checked Then 'Gets called if you want to blaze at a specific time
            If DateAndTime.Now.ToShortTimeString = TimeChooser.Text + " " + AMPMChooser.Text Then 'Blazes if the current time is equal to the user's specified time and has not already blazed
                If Blazed = False Then
                    Me.Blaze()
                    Blazed = True
                End If
            Else
                Blazed = False
            End If
        End If
    End Sub

    Private Sub Blaze() 'Plays the sound effect
        My.Computer.Audio.Play(My.Resources.blaze, AudioPlayMode.Background)
    End Sub

    Private Sub ABSuper_Click(sender As Object, e As EventArgs) Handles ABSuper.Click
        MessageBox.Show("Sorry, this feature is not yet implemented", "AutoBlaze")
        ABOff.Select()
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize 'If the program is minimized, then it will hide itself and show the tray icon
        If WindowState.Minimized Then
            ShowInTaskbar = False
            NotifyIcon1.Visible = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick 'Re opens the program if the tray icon is double clicked
        Me.WindowState = FormWindowState.Normal
        ShowInTaskbar = True
        NotifyIcon1.Visible = False
    End Sub

    Private Sub FixText(sender As Object, e As EventArgs) Handles TickChooser.TextChanged 'Makes sure that the interval chooser box ALWAYS contains an interger. Without it, the program would get confused if it was empty or had letters
        TickChooser.Text = Val(TickChooser.Text)
    End Sub

    Private Sub PictureBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDoubleClick 'Should do nothing, I use it as a "debug button" to test things

    End Sub
End Class