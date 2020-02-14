Public Class FirstLaunch
    Public Done As Boolean = False
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Light" Then
            Configuration.ThemeMode = 1
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("c:\Cats\config.txt", True)
            file.WriteLine("mode:light")
            file.Close()
            Cats.Show()
            Me.Close()
        ElseIf ComboBox1.Text = "Dark" Then
            Configuration.ThemeMode = 2
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