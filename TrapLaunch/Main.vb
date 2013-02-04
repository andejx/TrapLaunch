Public Class Main
    'sets up variables
    Dim javaminram As Decimal
    Dim javamaxram As Decimal
    Dim javaargs As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonupdate.Click
        'on button press this makes progress bar visible, then sets its value to 1
        progbarupdate.Visible = True
        progbarupdate.Value = 1
        Try
            'it then tries to connect to a server and download a current modlist
            My.Computer.Network.DownloadFile("http://test", ".\modlist.txt", "", "", False, 100, True)
            'if it succeeds then it sets progress bar a little further along, then it converts the contents of the,
            'downloaded modlist to a string, and then to a msgbox for debug purposes, this section will eventually, 
            'do the mod version checking 
            progbarupdate.Value = 20
            Dim modlist As String
            modlist = My.Computer.FileSystem.ReadAllText(".\modlist.txt")
            MsgBox(modlist)
            progbarupdate.Value = 100
        Catch webex As System.Net.WebException
            'if the server is unreachable for any reason rather than crash the program it will simply output this message.
            MsgBox("Couldn't Retrieve Latest Client Info")
            progbarupdate.Value = 0
        End Try

    End Sub

    Private Sub buttonplay_Click(sender As Object, e As EventArgs) Handles buttonplay.Click
        'start of the code for the lauching of minecraft, I have several ideas in my head about how to do this
        'best one I have at the moment is writing all the start arguments to a batch file and then tell this 
        'to launch the batch, unless I can find a way to get minecraft data to build elsewhere without
        'using command prompt.
        'at the moment this just shows.
        Dim minecraft As New Process()
        minecraft.StartInfo.UseShellExecute = False
        minecraft.StartInfo.FileName = "C:\Program Files\Java\jre8\bin\java.exe"
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownminram.ValueChanged
        'catch to stop people setting the minimum ram higher than the maximum ram and being derps.
        javaminram = NumericUpDownminram.Value
        If javaminram > javamaxram Then
            NumericUpDownminram.DownButton()
        End If
    End Sub

    Private Sub numericupdownmaxram_ValueChanged(sender As Object, e As EventArgs) Handles numericupdownmaxram.ValueChanged
        javamaxram = numericupdownmaxram.Value
    End Sub

    Private Sub testbutton_Click(sender As Object, e As EventArgs) Handles testbutton.Click
        'lil test button to output the settings in a msgbox so i can check its working
        javaargs = ("-Xms" & javaminram & "m -Xmx" & javamaxram & "m -jar "".\minecraft.bat""")
        MsgBox(javaargs)
    End Sub
End Class
