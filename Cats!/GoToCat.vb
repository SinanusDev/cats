Public Class GoToCat
    Public TempVal As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TempVal = TextBox1.Text
        Cats.value = TempVal
        Cats.valdisplay.Text = Cats.value
        Dim uri As New Uri("https://iscalio.com/cats/" & Cats.value & ".jpg")
        Cats.WebBrowser1.Navigate(uri)
        Me.Close()
    End Sub

    Private Sub GoToCat_Load(sender As Object, e As EventArgs) Handles Me.Load
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
    End Sub
End Class