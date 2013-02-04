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
        Me.labelversion = New System.Windows.Forms.Label()
        Me.buttonplay = New System.Windows.Forms.Button()
        Me.numericupdownmaxram = New System.Windows.Forms.NumericUpDown()
        Me.labelrammax = New System.Windows.Forms.Label()
        Me.labelminram = New System.Windows.Forms.Label()
        Me.NumericUpDownminram = New System.Windows.Forms.NumericUpDown()
        Me.testbutton = New System.Windows.Forms.Button()
        CType(Me.numericupdownmaxram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownminram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonupdate
        '
        Me.buttonupdate.Location = New System.Drawing.Point(318, 213)
        Me.buttonupdate.Name = "buttonupdate"
        Me.buttonupdate.Size = New System.Drawing.Size(199, 36)
        Me.buttonupdate.TabIndex = 0
        Me.buttonupdate.Text = "Check For Updates"
        Me.buttonupdate.UseVisualStyleBackColor = True
        '
        'progbarupdate
        '
        Me.progbarupdate.Location = New System.Drawing.Point(318, 184)
        Me.progbarupdate.Name = "progbarupdate"
        Me.progbarupdate.Size = New System.Drawing.Size(199, 23)
        Me.progbarupdate.TabIndex = 1
        Me.progbarupdate.Visible = False
        '
        'labelversion
        '
        Me.labelversion.AutoSize = True
        Me.labelversion.Location = New System.Drawing.Point(14, 9)
        Me.labelversion.Name = "labelversion"
        Me.labelversion.Size = New System.Drawing.Size(88, 13)
        Me.labelversion.TabIndex = 2
        Me.labelversion.Text = "Current Version : "
        '
        'buttonplay
        '
        Me.buttonplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonplay.Location = New System.Drawing.Point(318, 83)
        Me.buttonplay.Name = "buttonplay"
        Me.buttonplay.Size = New System.Drawing.Size(199, 95)
        Me.buttonplay.TabIndex = 3
        Me.buttonplay.Text = "Play"
        Me.buttonplay.UseVisualStyleBackColor = True
        '
        'numericupdownmaxram
        '
        Me.numericupdownmaxram.Increment = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.numericupdownmaxram.Location = New System.Drawing.Point(88, 62)
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
        Me.labelrammax.Location = New System.Drawing.Point(14, 62)
        Me.labelrammax.Name = "labelrammax"
        Me.labelrammax.Size = New System.Drawing.Size(68, 16)
        Me.labelrammax.TabIndex = 5
        Me.labelrammax.Text = "MaxRam"
        '
        'labelminram
        '
        Me.labelminram.AutoSize = True
        Me.labelminram.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelminram.Location = New System.Drawing.Point(14, 36)
        Me.labelminram.Name = "labelminram"
        Me.labelminram.Size = New System.Drawing.Size(68, 16)
        Me.labelminram.TabIndex = 7
        Me.labelminram.Text = "Min Ram"
        '
        'NumericUpDownminram
        '
        Me.NumericUpDownminram.Increment = New Decimal(New Integer() {512, 0, 0, 0})
        Me.NumericUpDownminram.Location = New System.Drawing.Point(88, 36)
        Me.NumericUpDownminram.Maximum = New Decimal(New Integer() {8192, 0, 0, 0})
        Me.NumericUpDownminram.Minimum = New Decimal(New Integer() {512, 0, 0, 0})
        Me.NumericUpDownminram.Name = "NumericUpDownminram"
        Me.NumericUpDownminram.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownminram.TabIndex = 8
        Me.NumericUpDownminram.Value = New Decimal(New Integer() {512, 0, 0, 0})
        '
        'testbutton
        '
        Me.testbutton.Location = New System.Drawing.Point(12, 88)
        Me.testbutton.Name = "testbutton"
        Me.testbutton.Size = New System.Drawing.Size(75, 23)
        Me.testbutton.TabIndex = 9
        Me.testbutton.Text = "Test"
        Me.testbutton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 261)
        Me.Controls.Add(Me.testbutton)
        Me.Controls.Add(Me.NumericUpDownminram)
        Me.Controls.Add(Me.labelminram)
        Me.Controls.Add(Me.labelrammax)
        Me.Controls.Add(Me.numericupdownmaxram)
        Me.Controls.Add(Me.buttonplay)
        Me.Controls.Add(Me.labelversion)
        Me.Controls.Add(Me.progbarupdate)
        Me.Controls.Add(Me.buttonupdate)
        Me.Name = "Main"
        Me.Text = "TrapLaunch0.1"
        CType(Me.numericupdownmaxram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownminram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonupdate As System.Windows.Forms.Button
    Friend WithEvents progbarupdate As System.Windows.Forms.ProgressBar
    Friend WithEvents labelversion As System.Windows.Forms.Label
    Friend WithEvents buttonplay As System.Windows.Forms.Button
    Friend WithEvents numericupdownmaxram As System.Windows.Forms.NumericUpDown
    Friend WithEvents labelrammax As System.Windows.Forms.Label
    Friend WithEvents labelminram As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownminram As System.Windows.Forms.NumericUpDown
    Friend WithEvents testbutton As System.Windows.Forms.Button

End Class
