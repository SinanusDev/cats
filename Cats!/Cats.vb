Public Class Cats
    Public value As Integer = 0
    Private Sub Cats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Configuration.ThemeMode = 2 Then
            BackColor = Color.Black
            ForeColor = Color.White
        ElseIf Configuration.ThemeMode = 1 Then
            BackColor = Color.White
            ForeColor = Color.Black
        Else
            Console.WriteLine("[FATAL] Failed to read from CONFIGURATION.VB")
            Console.WriteLine("[WARNING] Restart in 2000ms...")
            Threading.Thread.Sleep(1000)
            Console.WriteLine("[WARNING] Restart in 1000ms...")
            Threading.Thread.Sleep(1000)
            Console.WriteLine("[WARNING] Restart in 0ms...")
            Console.WriteLine("[WARNING] RESTART!")
            Application.Restart()
        End If
        valdisplay.Text = value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        value = value - 1
        valdisplay.Text = value
        Dim uri As New Uri("https://iscalio.com/cats/" & value & ".jpg")
        WebBrowser1.Navigate(uri)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        value = value + 1
        valdisplay.Text = value
        Dim uri As New Uri("https://iscalio.com/cats/" & value & ".jpg")
            WebBrowser1.Navigate(uri)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GoToCat.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Configuration.Show()
    End Sub
End Class