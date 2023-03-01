Public Class Form2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (ProgressBar1.Value = ProgressBar1.Maximum) Then
            Timer1.Stop()
            Me.Hide()
            Form3.Show()

        Else
            ProgressBar1.PerformStep()
            Label2.Text = ProgressBar1.Value & ("%")
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.CenterToScreen()

    End Sub
End Class