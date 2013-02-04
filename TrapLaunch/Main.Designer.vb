<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.buttonupdate = New System.Windows.Forms.Button()
        Me.progbarupdate = New System.Windows.Forms.ProgressBar()
        Me.labelmcversion = New System.Windows.Forms.Label()
        Me.buttonplay = New System.Windows.Forms.Button()
        Me.numericupdownmaxram = New System.Windows.Forms.NumericUpDown()
        Me.labelrammax = New System.Windows.Forms.Label()
        Me.labelminram = New System.Windows.Forms.Label()
        Me.NumericUpDownminram = New System.Windows.Forms.NumericUpDown()
        Me.maintab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Settings = New System.Windows.Forms.TabPage()
        Me.buttondefaultsettings = New System.Windows.Forms.Button()
        Me.labelftpusername = New System.Windows.Forms.Label()
        Me.labelftppassword = New System.Windows.Forms.Label()
        Me.labelftpserver = New System.Windows.Forms.Label()
        Me.textboxftppassword = New System.Windows.Forms.TextBox()
        Me.TextBoxftpusername = New System.Windows.Forms.TextBox()
        Me.textboxftpaddress = New System.Windows.Forms.TextBox()
        Me.labellauncherversion = New System.Windows.Forms.Label()
        CType(Me.numericupdownmaxram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownminram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.maintab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Settings.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonupdate
        '
        Me.buttonupdate.Location = New System.Drawing.Point(292, 6)
        Me.buttonupdate.Name = "buttonupdate"
        Me.buttonupdate.Size = New System.Drawing.Size(199, 36)
        Me.buttonupdate.TabIndex = 0
        Me.buttonupdate.Text = "Check For Updates"
        Me.buttonupdate.UseVisualStyleBackColor = True
        '
        'progbarupdate
        '
        Me.progbarupdate.Location = New System.Drawing.Point(292, 48)
        Me.progbarupdate.Name = "progbarupdate"
        Me.progbarupdate.Size = New System.Drawing.Size(199, 23)
        Me.progbarupdate.TabIndex = 1
        Me.progbarupdate.Visible = False
        '
        'labelmcversion
        '
        Me.labelmcversion.AutoSize = True
        Me.labelmcversion.Location = New System.Drawing.Point(310, 88)
        Me.labelmcversion.Name = "labelmcversion"
        Me.labelmcversion.Size = New System.Drawing.Size(107, 13)
        Me.labelmcversion.TabIndex = 2
        Me.labelmcversion.Text = "Current MC Version : "
        '
        'buttonplay
        '
        Me.buttonplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonplay.Location = New System.Drawing.Point(292, 113)
        Me.buttonplay.Name = "buttonplay"
        Me.buttonplay.Size = New System.Drawing.Size(199, 95)
        Me.buttonplay.TabIndex = 3
        Me.buttonplay.Text = "Play"
        Me.buttonplay.UseVisualStyleBackColor = True
        '
        'numericupdownmaxram
        '
        Me.numericupdownmaxram.Increment = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.numericupdownmaxram.Location = New System.Drawing.Point(100, 42)
        Me.numericupdownmaxram.Maximum = New Decimal(New Integer() {8192, 0, 0, 0})
        Me.numericupdownmaxram.Minimum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.numericupdownmaxram.Name = "numericupdownmaxram"
        Me.numericupdownmaxram.Size = New System.Drawing.Size(120, 20)
        Me.numericupdownmaxram.TabIndex = 4
        Me.numericupdownmaxram.Value = New Decimal(New Integer() {1024, 0, 0, 0})
        '
        'labelrammax
        '
        Me.labelrammax.AutoSize = True
        Me.labelrammax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelrammax.Location = New System.Drawing.Point(15, 42)
        Me.labelrammax.Name = "labelrammax"
        Me.labelrammax.Size = New System.Drawing.Size(72, 16)
        Me.labelrammax.TabIndex = 5
        Me.labelrammax.Text = "Max Ram"
        '
        'labelminram
        '
        Me.labelminram.AutoSize = True
        Me.labelminram.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelminram.Location = New System.Drawing.Point(15, 16)
        Me.labelminram.Name = "labelminram"
        Me.labelminram.Size = New System.Drawing.Size(68, 16)
        Me.labelminram.TabIndex = 7
        Me.labelminram.Text = "Min Ram"
        '
        'NumericUpDownminram
        '
        Me.NumericUpDownminram.Increment = New Decimal(New Integer() {512, 0, 0, 0})
        Me.NumericUpDownminram.Location = New System.Drawing.Point(100, 16)
        Me.NumericUpDownminram.Maximum = New Decimal(New Integer() {8192, 0, 0, 0})
        Me.NumericUpDownminram.Minimum = New Decimal(New Integer() {512, 0, 0, 0})
        Me.NumericUpDownminram.Name = "NumericUpDownminram"
        Me.NumericUpDownminram.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownminram.TabIndex = 8
        Me.NumericUpDownminram.Value = New Decimal(New Integer() {512, 0, 0, 0})
        '
        'maintab
        '
        Me.maintab.Controls.Add(Me.TabPage1)
        Me.maintab.Controls.Add(Me.Settings)
        Me.maintab.Location = New System.Drawing.Point(12, 12)
        Me.maintab.Name = "maintab"
        Me.maintab.SelectedIndex = 0
        Me.maintab.Size = New System.Drawing.Size(505, 240)
        Me.maintab.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.labelmcversion)
        Me.TabPage1.Controls.Add(Me.buttonplay)
        Me.TabPage1.Controls.Add(Me.progbarupdate)
        Me.TabPage1.Controls.Add(Me.buttonupdate)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(497, 214)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.Settings.Controls.Add(Me.labellauncherversion)
        Me.Settings.Controls.Add(Me.buttondefaultsettings)
        Me.Settings.Controls.Add(Me.labelftpusername)
        Me.Settings.Controls.Add(Me.labelftppassword)
        Me.Settings.Controls.Add(Me.labelftpserver)
        Me.Settings.Controls.Add(Me.textboxftppassword)
        Me.Settings.Controls.Add(Me.TextBoxftpusername)
        Me.Settings.Controls.Add(Me.textboxftpaddress)
        Me.Settings.Controls.Add(Me.labelminram)
        Me.Settings.Controls.Add(Me.NumericUpDownminram)
        Me.Settings.Controls.Add(Me.numericupdownmaxram)
        Me.Settings.Controls.Add(Me.labelrammax)
        Me.Settings.Location = New System.Drawing.Point(4, 22)
        Me.Settings.Name = "Settings"
        Me.Settings.Padding = New System.Windows.Forms.Padding(3)
        Me.Settings.Size = New System.Drawing.Size(497, 214)
        Me.Settings.TabIndex = 1
        Me.Settings.Text = "Settings"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'buttondefaultsettings
        '
        Me.buttondefaultsettings.Location = New System.Drawing.Point(6, 186)
        Me.buttondefaultsettings.Name = "buttondefaultsettings"
        Me.buttondefaultsettings.Size = New System.Drawing.Size(77, 22)
        Me.buttondefaultsettings.TabIndex = 15
        Me.buttondefaultsettings.Text = "Defaults"
        Me.buttondefaultsettings.UseVisualStyleBackColor = True
        '
        'labelftpusername
        '
        Me.labelftpusername.AutoSize = True
        Me.labelftpusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelftpusername.Location = New System.Drawing.Point(15, 95)
        Me.labelftpusername.Name = "labelftpusername"
        Me.labelftpusername.Size = New System.Drawing.Size(108, 16)
        Me.labelftpusername.TabIndex = 14
        Me.labelftpusername.Text = "Ftp UserName"
        '
        'labelftppassword
        '
        Me.labelftppassword.AutoSize = True
        Me.labelftppassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelftppassword.Location = New System.Drawing.Point(15, 121)
        Me.labelftppassword.Name = "labelftppassword"
        Me.labelftppassword.Size = New System.Drawing.Size(102, 16)
        Me.labelftppassword.TabIndex = 13
        Me.labelftppassword.Text = "Ftp Password"
        '
        'labelftpserver
        '
        Me.labelftpserver.AutoSize = True
        Me.labelftpserver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelftpserver.Location = New System.Drawing.Point(15, 68)
        Me.labelftpserver.Name = "labelftpserver"
        Me.labelftpserver.Size = New System.Drawing.Size(80, 16)
        Me.labelftpserver.TabIndex = 12
        Me.labelftpserver.Text = "Ftp Server"
        '
        'textboxftppassword
        '
        Me.textboxftppassword.Location = New System.Drawing.Point(129, 120)
        Me.textboxftppassword.Name = "textboxftppassword"
        Me.textboxftppassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textboxftppassword.Size = New System.Drawing.Size(240, 20)
        Me.textboxftppassword.TabIndex = 11
        Me.textboxftppassword.Text = "test123"
        '
        'TextBoxftpusername
        '
        Me.TextBoxftpusername.Location = New System.Drawing.Point(129, 94)
        Me.TextBoxftpusername.Name = "TextBoxftpusername"
        Me.TextBoxftpusername.Size = New System.Drawing.Size(240, 20)
        Me.TextBoxftpusername.TabIndex = 10
        Me.TextBoxftpusername.Text = "test"
        '
        'textboxftpaddress
        '
        Me.textboxftpaddress.Location = New System.Drawing.Point(129, 68)
        Me.textboxftpaddress.Name = "textboxftpaddress"
        Me.textboxftpaddress.Size = New System.Drawing.Size(240, 20)
        Me.textboxftpaddress.TabIndex = 9
        Me.textboxftpaddress.Text = "ftp://localhost"
        '
        'labellauncherversion
        '
        Me.labellauncherversion.AutoSize = True
        Me.labellauncherversion.Location = New System.Drawing.Point(89, 191)
        Me.labellauncherversion.Name = "labellauncherversion"
        Me.labellauncherversion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.labellauncherversion.Size = New System.Drawing.Size(102, 13)
        Me.labellauncherversion.TabIndex = 16
        Me.labellauncherversion.Text = "Launcher Version :  "
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 261)
        Me.Controls.Add(Me.maintab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrapLaunch0.1"
        CType(Me.numericupdownmaxram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownminram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.maintab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Settings.ResumeLayout(False)
        Me.Settings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents buttonupdate As System.Windows.Forms.Button
    Friend WithEvents progbarupdate As System.Windows.Forms.ProgressBar
    Friend WithEvents labelmcversion As System.Windows.Forms.Label
    Friend WithEvents buttonplay As System.Windows.Forms.Button
    Friend WithEvents numericupdownmaxram As System.Windows.Forms.NumericUpDown
    Friend WithEvents labelrammax As System.Windows.Forms.Label
    Friend WithEvents labelminram As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownminram As System.Windows.Forms.NumericUpDown
    Friend WithEvents maintab As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Settings As System.Windows.Forms.TabPage
    Friend WithEvents labelftpusername As System.Windows.Forms.Label
    Friend WithEvents labelftppassword As System.Windows.Forms.Label
    Friend WithEvents labelftpserver As System.Windows.Forms.Label
    Friend WithEvents textboxftppassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxftpusername As System.Windows.Forms.TextBox
    Friend WithEvents textboxftpaddress As System.Windows.Forms.TextBox
    Friend WithEvents buttondefaultsettings As System.Windows.Forms.Button
    Friend WithEvents labellauncherversion As System.Windows.Forms.Label

End Class
