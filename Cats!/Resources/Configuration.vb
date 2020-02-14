Public Class Configuration

    Public ThemeMode As Integer = 0 '0 = Nothing (Error)

    Private Sub Configuration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ThemeMode = 2 Then
            BackColor = Color.Black
            ForeColor = Color.White
        ElseIf ThemeMode = 1 Then
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Light" Then
            ThemeMode = 1
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("c:\Cats\config.txt", True)
            file.WriteLine("mode:light")
            file.Close()
            Cats.Show()
            Me.Close()
        ElseIf ComboBox1.Text = "Dark" Then
            ThemeMode = 2
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("c:\Cats\config.txt", True)
            file.WriteLine("mode:dark")
            file.Close()
            Cats.Show()
            Me.Close()
        Else
            MsgBox("Please select Dark or Light", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class