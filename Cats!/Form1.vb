Imports Cats_.Configuration
Public Class Form1
    Private Sub Form1_Loaded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
        Dim fileReader As System.IO.StreamReader
        fileReader =
        My.Computer.FileSystem.OpenTextFileReader("C:\\Cats\config.txt")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        If stringReader = "mode:dark" Then
            Configuration.ThemeMode = 2
            Cats.Show()
            Me.Hide()
        ElseIf stringReader = "mode:light" Then
            Configuration.ThemeMode = 1
            Cats.Show()
            Me.Hide()
        Else
            Console.WriteLine("[ERROR] Failed to read config.txt")
            Console.WriteLine("[INFO] Opening Sub FirstLaunch();")
            Configuration.ThemeMode = 0
            fileReader.Close()
            FirstLaunch.Show()
            Me.Hide()
        End If
        Timer1.Enabled = False
    End Sub
End Class
