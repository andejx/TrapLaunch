Imports System.IO

Public Class Main
    'sets up variables
    Dim javaminram As Decimal
    Dim javamaxram As Decimal
    Dim javaargs As String
    Dim remoteFile As String
    Dim localFile As String
    Dim host As String
    Dim username As String
    Dim password As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim checkconfig As Boolean
        'checks if launcher config exists, if it doesn't it calls configgenerate() and makes one.
        checkconfig = File.Exists("./config.txt")
        If checkconfig = False Then
            configgenerate()
        Else
            'if a config does exist it reads the values and sets the settings!
            configread()
        End If
    End Sub

    Private Sub configgenerate()
        'writes up a default config.txt with empty lines for things unknown
        Using write1 As StreamWriter = File.AppendText("config.txt")
            write1.WriteLine("TrapCraft0.2") 'launcher version
            write1.WriteLine(" ") 'minecraft client version
            write1.WriteLine("512") 'minram
            write1.WriteLine("1024") 'maxram
            write1.WriteLine("ftp://localhost") 'ftphost
            write1.WriteLine("test") 'ftpusername
            write1.WriteLine("test123") 'ftppassword
            write1.Close()
        End Using
        configread()
    End Sub

    Private Sub configread()
        Dim configread() As String
        configread = File.ReadAllLines("./config.txt")
        labellauncherversion.Text = "Launcher Version : " & configread(0)
        NumericUpDownminram.Value = configread(2)
        numericupdownmaxram.Value = configread(3)
        textboxftpaddress.Text = configread(4)
        TextBoxftpusername.Text = configread(5)
        textboxftppassword.Text = configread(6)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonupdate.Click
        'on button press this makes progress bar visible, then sets its value to 1
        progbarupdate.Visible = True
        progbarupdate.Value = 1
        Try
            'it then tries to connect to a server and download a current modlist
            remoteFile = "/modlist.txt"
            localFile = "./modlist.txt"
            ftpdownload()
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
        'sets max ram whenever it's changed
        javamaxram = numericupdownmaxram.Value
    End Sub


    Private Sub ftpdownload()
        'does the ftp downloadin based on w/e the program has 
        'remoteFile and localFile strings set to. ie ".remote/modlist.txt" ,".local/modlist.txt"
        host = textboxftpaddress.Text
        username = TextBoxftpusername.Text
        password = textboxftppassword.Text

        Dim URI As String = host & remoteFile
        Dim ftp As System.Net.FtpWebRequest = _
            CType(Net.FtpWebRequest.Create(URI), Net.FtpWebRequest)

        ftp.Credentials = New  _
    System.Net.NetworkCredential(username, password)
        ftp.KeepAlive = True
        ftp.UseBinary = True
        ftp.Method = System.Net.WebRequestMethods.Ftp.DownloadFile
        Using response As System.Net.FtpWebResponse = _
      CType(ftp.GetResponse, System.Net.FtpWebResponse)
            Using responseStream As IO.Stream = response.GetResponseStream
                'loop to read & write to file
                Using fs As New IO.FileStream(localFile, IO.FileMode.Create)
                    Dim buffer(2047) As Byte
                    Dim read As Integer = 0
                    Do
                        read = responseStream.Read(buffer, 0, buffer.Length)
                        fs.Write(buffer, 0, read)
                    Loop Until read = 0 'see Note(1)
                    responseStream.Close()
                    fs.Flush()
                    fs.Close()
                End Using
                responseStream.Close()
            End Using
            response.Close()
        End Using
        remoteFile = ""
        localFile = ""
    End Sub


    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Makes an are you sure you want to close window.
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure?", "Close program?", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub buttondefaultsettings_Click(sender As Object, e As EventArgs) Handles buttondefaultsettings.Click
        'resets all config options by regenerating the config file then rereading the config.
        File.Delete("./config.txt")
        Using write1 As StreamWriter = File.AppendText("config.txt")
            write1.WriteLine("TrapCraft0.2")
            write1.WriteLine(" ")
            write1.WriteLine("512") 
            write1.WriteLine("1024")
            write1.WriteLine("ftp://localhost")
            write1.WriteLine("test")
            write1.WriteLine("test123")
            write1.Close()
        End Using
        configread()
    End Sub

End Class
