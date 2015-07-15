Public Class AutoBlaze
    Dim Times As Integer = 0
    Dim TickTime As Integer = 60

    Private Sub BlazeButton_Click(sender As Object, e As EventArgs) Handles BlazeButton.Click
        Me.Blaze()
    End Sub

    Private Sub Blaze()
        My.Computer.Audio.Play(My.Resources.blaze, AudioPlayMode.Background)
    End Sub

    Private Sub BlazeTimer_Tick(sender As Object, e As EventArgs) Handles BlazeTimer.Tick
        Times += 1
        TickDecider()

        If Times >= TickTime Then
            If ABTimed.Checked And (DateAndTime.Now.ToShortTimeString = TimeChooser.Text + " " + AMPMChooser.Text) Then
                Me.Blaze()
            ElseIf ABEvery.Checked
                Me.Blaze()
            End If

            LoadBar.Value = LoadBar.Minimum

            Times = 0
        End If

        If ABEvery.Checked And TickTime > 0 Then
            LoadBar.Value = Times * LoadBar.Maximum / TickTime
        End If
    End Sub

    Private Sub TickDecider()
        If ABEvery.Checked Then
            TickTime = TickChooser.Text
        Else
            TickTime = 60
        End If
    End Sub

    Private Sub ABSuper_Click(sender As Object, e As EventArgs) Handles ABSuper.Click
        MessageBox.Show("Sorry, this feature is not yet implemented", "AutoBlaze")
        ABOff.Select()
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If WindowState.Minimized Then
            ShowInTaskbar = False
            NotifyIcon1.Visible = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        Me.WindowState = FormWindowState.Normal
        ShowInTaskbar = True
        NotifyIcon1.Visible = False
    End Sub

    Private Sub FixText(sender As Object, e As EventArgs) Handles TickChooser.TextChanged
        TickChooser.Text = Val(TickChooser.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(TickTime)
    End Sub
End Class