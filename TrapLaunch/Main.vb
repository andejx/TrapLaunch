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
    Dim checkbuildnumberexists As Boolean
    Dim clientbuildnumber As String
    Dim checkservernumberexists As Boolean
    Dim serverbuildnumber As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'To change version number, go to Project -> TrapLaunch Properties -> Assembly Information.
        Me.Text = "TrapEZ-MC : " & My.Application.Info.Version.ToString
        labellauncherversion.Text = "Launcher Version: " & My.Application.Info.Version.ToString

        'checks to see if folders exist and creates them if they don't
        Dim checkclientfolder As Boolean
        checkclientfolder = Directory.Exists(".\clientfiles")
        If checkclientfolder = False Then
            Directory.CreateDirectory(".\launcherconfigs\")
            Directory.CreateDirectory(".\clientfiles")
            Directory.CreateDirectory(".\clientfiles\mods")
            Directory.CreateDirectory(".\clientfiles\coremods")
        End If


        'checks if launcher config exists, if it doesn't it calls configgenerate() and makes one.
        Dim checkconfigfile As Boolean
        checkconfigfile = File.Exists(".\launcherconfigs\config")
        If checkconfigfile = False Then
            configgenerate()
        Else
            'if a config does exist it reads the values and sets the settings!
            configread()
        End If


        'checks to see if clientbuildnumber file exists, if not creates default one
        checkbuildnumberexists = File.Exists(".\launcherconfigs\clientbuildnumber")
        If checkbuildnumberexists = False Then
            File.WriteAllText(".\launcherconfigs\clientbuildnumber", "0.0")
            clientbuildnumber = File.ReadAllText(".\launcherconfigs\clientbuildnumber")
            labelclientversion.Text = "Current Client Version : " & clientbuildnumber
        Else
            'if it does exist sets the version number as 'clientbuildnumber'
            clientbuildnumber = File.ReadAllText(".\launcherconfigs\clientbuildnumber")
            labelclientversion.Text = "Current Client Version : " & clientbuildnumber
        End If

        'checks to see if serverbuildnumber exists, if not makes one
        checkservernumberexists = File.Exists(".\launcherconfigs\serverbuildnumber")
        If checkservernumberexists = False Then
            File.WriteAllText(".\launcherconfigs\serverbuildnumber", "0")
            serverbuildnumber = File.ReadAllText(".\launcherconfigs\serverbuildnumber")
        Else
            serverbuildnumber = File.ReadAllText(".\launcherconfigs\serverbuildnumber")
            labelserverversion.Text = "Current Server Version : " & serverbuildnumber
        End If

        'downloads latest serverbuildnumber and sets version as 'serverbuildnumber'
        Try
            remoteFile = "/serverbuildnumber"
            localFile = ".\launcherconfigs\serverbuildnumber"
            ftpdownload()
            serverbuildnumber = File.ReadAllText(".\launcherconfigs\serverbuildnumber")
            labelserverversion.Text = "Current Server Version : " & serverbuildnumber
        Catch webex As System.Net.WebException
            labelserverversion.Text = "Current Server Version : " & serverbuildnumber & " Unverified"
        End Try
        

        'compares the two buildnumbers, if both same turn green, if not show red
        If clientbuildnumber <> serverbuildnumber Then
            labelclientversion.BackColor = Color.IndianRed
            labelserverversion.BackColor = Color.IndianRed
        Else
            labelclientversion.BackColor = Color.PaleGreen
            labelserverversion.BackColor = Color.PaleGreen
        End If


    End Sub

    Private Sub clientlistgen()
        'writes list of files in clientfiles\mods\ to clientmodlist
        'finally found a way of doing it that didn't bring the path with it.
        Dim o As New System.IO.DirectoryInfo(".\clientfiles\mods\")
        Dim myfiles() As System.IO.FileInfo
        myfiles = o.GetFiles("*")
        Using write1 As StreamWriter = File.AppendText(".\launcherconfigs\clientmodlist")
            For y As Integer = 0 To myfiles.Length - 1
                write1.WriteLine(myfiles(y).Name())
            Next
        End Using

    End Sub

    Private Sub configgenerate()
        'writes up a default config with empty lines for things unknown
        Using write1 As StreamWriter = File.AppendText(".\launcherconfigs\config")
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
        configread = File.ReadAllLines(".\launcherconfigs\config")
        NumericUpDownminram.Value = configread(0)
        numericupdownmaxram.Value = configread(1)
        textboxftpaddress.Text = configread(2)
        TextBoxftpusername.Text = configread(3)
        textboxftppassword.Text = configread(4)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonupdate.Click
        'builds clientmodlist
        clientlistgen()

        ''on button press this makes progress bar visible, then sets its value to 1
        'progbarupdate.Visible = True
        'progbarupdate.Value = 1

        'Try
        '    'it then tries to connect to a server and download a current modlist
        '    remoteFile = "/modlist"
        '    localFile = "modlist"
        '    ftpdownload()
        '    'if it succeeds then it sets progress bar a little further along, then it converts the contents of the,
        '    'downloaded modlist to a string, and then to a msgbox for debug purposes, this section will eventually, 
        '    'do the mod version checking 
        '    progbarupdate.Value = 20
        '    Dim modlist As String
        '    modlist = My.Computer.FileSystem.ReadAllText("modlist")
        '    MsgBox(modlist)
        '    progbarupdate.Value = 100
        'Catch webex As System.Net.WebException
        '    'if the server is unreachable for any reason rather than crash the program it will simply output this message.
        '    MsgBox("Couldn't Retrieve Latest Client Info")
        '    progbarupdate.Value = 0
        'End Try
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
        If javamaxram < javaminram Then
            numericupdownmaxram.UpButton()
        End If
    End Sub


    Private Sub textboxftpaddress_TextChanged(sender As Object, e As EventArgs) Handles textboxftpaddress.TextChanged
        'sets string as contents of the textbox whenever its changed
        host = textboxftpaddress.Text
    End Sub


    Private Sub textboxftpusername_TextChanged(sender As Object, e As EventArgs) Handles TextBoxftpusername.TextChanged
        'sets string as contents of the textbox whenever its changed
        username = TextBoxftpusername.Text
    End Sub


    Private Sub textboxftppassword_TextChanged(sender As Object, e As EventArgs) Handles textboxftppassword.TextChanged
        'sets string as contents of the textbox whenever its changed
        password = textboxftppassword.Text
    End Sub


    Private Sub ftpdownload()
        'does the ftp downloadin based on w/e the program has 
        'remoteFile and localFile strings set to. ie ".remote/modlist.txt" ,".local/modlist.txt"

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
        'saves config to file before closing
        File.Delete(".\launcherconfigs\config")
        Using write1 As StreamWriter = File.AppendText(".\launcherconfigs\config")
            write1.WriteLine(javaminram)
            write1.WriteLine(javamaxram)
            write1.WriteLine(host)
            write1.WriteLine(username)
            write1.WriteLine(password)
            write1.Close()
        End Using


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
        File.Delete(".\launcherconfigs\config")
        Using write1 As StreamWriter = File.AppendText(".\launcherconfigs\config")
            write1.WriteLine("512")
            write1.WriteLine("1024")
            write1.WriteLine("ftp://localhost")
            write1.WriteLine("test")
            write1.WriteLine("test123")
            write1.Close()
        End Using
        configread()
    End Sub

    Private Sub maintab_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles maintab.SelectedIndexChanged
        'also saves config options to file whenever the "main" tab is selected.
        File.Delete(".\launcherconfigs\config")
        Using write1 As StreamWriter = File.AppendText(".\launcherconfigs\config")
            write1.WriteLine(javaminram)
            write1.WriteLine(javamaxram)
            write1.WriteLine(host)
            write1.WriteLine(username)
            write1.WriteLine(password)
            write1.Close()
        End Using
    End Sub
End Class
