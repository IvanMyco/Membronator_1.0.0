<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BtnRun = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.openFD = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.txtSrcathDir = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Iterazioni = New System.Windows.Forms.NumericUpDown()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListSpostamenti = New System.Windows.Forms.TextBox()
        Me.txtSaveDir = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NodeMonitor = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DZ = New System.Windows.Forms.RadioButton()
        Me.DY = New System.Windows.Forms.RadioButton()
        Me.DX = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.Iterazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.AccessibleName = "BtnExit"
        Me.BtnExit.Location = New System.Drawing.Point(12, 500)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(216, 39)
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'BtnRun
        '
        Me.BtnRun.AccessibleName = "BtnRun"
        Me.BtnRun.Location = New System.Drawing.Point(12, 295)
        Me.BtnRun.Name = "BtnRun"
        Me.BtnRun.Size = New System.Drawing.Size(216, 39)
        Me.BtnRun.TabIndex = 1
        Me.BtnRun.Text = "Run"
        Me.BtnRun.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(216, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Open ST7 Model"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'openFD
        '
        Me.openFD.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(216, 39)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Set Scratch Directory"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Enabled = False
        Me.txtFileName.Location = New System.Drawing.Point(234, 31)
        Me.txtFileName.Multiline = True
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(285, 39)
        Me.txtFileName.TabIndex = 4
        '
        'txtSrcathDir
        '
        Me.txtSrcathDir.Enabled = False
        Me.txtSrcathDir.Location = New System.Drawing.Point(234, 88)
        Me.txtSrcathDir.Multiline = True
        Me.txtSrcathDir.Name = "txtSrcathDir"
        Me.txtSrcathDir.Size = New System.Drawing.Size(285, 39)
        Me.txtSrcathDir.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(234, 199)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(498, 340)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Iterazioni
        '
        Me.Iterazioni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iterazioni.Location = New System.Drawing.Point(167, 199)
        Me.Iterazioni.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Iterazioni.Name = "Iterazioni"
        Me.Iterazioni.Size = New System.Drawing.Size(61, 23)
        Me.Iterazioni.TabIndex = 8
        Me.Iterazioni.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Location = New System.Drawing.Point(12, 199)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(149, 23)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "Set Number Iterations"
        '
        'ListSpostamenti
        '
        Me.ListSpostamenti.Enabled = False
        Me.ListSpostamenti.Location = New System.Drawing.Point(12, 340)
        Me.ListSpostamenti.Multiline = True
        Me.ListSpostamenti.Name = "ListSpostamenti"
        Me.ListSpostamenti.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ListSpostamenti.Size = New System.Drawing.Size(216, 154)
        Me.ListSpostamenti.TabIndex = 11
        '
        'txtSaveDir
        '
        Me.txtSaveDir.Enabled = False
        Me.txtSaveDir.Location = New System.Drawing.Point(234, 143)
        Me.txtSaveDir.Multiline = True
        Me.txtSaveDir.Name = "txtSaveDir"
        Me.txtSaveDir.Size = New System.Drawing.Size(285, 39)
        Me.txtSaveDir.TabIndex = 13
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 143)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(216, 39)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Set Directory where to save File Step"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NodeMonitor
        '
        Me.NodeMonitor.Location = New System.Drawing.Point(12, 269)
        Me.NodeMonitor.Name = "NodeMonitor"
        Me.NodeMonitor.Size = New System.Drawing.Size(70, 20)
        Me.NodeMonitor.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DZ)
        Me.GroupBox1.Controls.Add(Me.DY)
        Me.GroupBox1.Controls.Add(Me.DX)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 240)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 49)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'DZ
        '
        Me.DZ.AutoSize = True
        Me.DZ.Location = New System.Drawing.Point(98, 19)
        Me.DZ.Name = "DZ"
        Me.DZ.Size = New System.Drawing.Size(40, 17)
        Me.DZ.TabIndex = 18
        Me.DZ.TabStop = True
        Me.DZ.Text = "DZ"
        Me.DZ.UseVisualStyleBackColor = True
        '
        'DY
        '
        Me.DY.AutoSize = True
        Me.DY.Location = New System.Drawing.Point(52, 19)
        Me.DY.Name = "DY"
        Me.DY.Size = New System.Drawing.Size(40, 17)
        Me.DY.TabIndex = 17
        Me.DY.TabStop = True
        Me.DY.Text = "DY"
        Me.DY.UseVisualStyleBackColor = True
        '
        'DX
        '
        Me.DX.AutoSize = True
        Me.DX.Location = New System.Drawing.Point(6, 19)
        Me.DX.Name = "DX"
        Me.DX.Size = New System.Drawing.Size(40, 17)
        Me.DX.TabIndex = 16
        Me.DX.TabStop = True
        Me.DX.Text = "DX"
        Me.DX.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox2.Location = New System.Drawing.Point(12, 240)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(70, 23)
        Me.TextBox2.TabIndex = 16
        Me.TextBox2.Text = "NodeMonitor"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 551)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NodeMonitor)
        Me.Controls.Add(Me.txtSaveDir)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ListSpostamenti)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Iterazioni)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtSrcathDir)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnRun)
        Me.Controls.Add(Me.BtnExit)
        Me.Name = "MainForm"
        Me.Text = "Membronator Main Form"
        CType(Me.Iterazioni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExit As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnRun As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents openFD As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents txtSrcathDir As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Iterazioni As NumericUpDown
    Protected WithEvents TextBox1 As TextBox
    Friend WithEvents ListSpostamenti As TextBox
    Friend WithEvents txtSaveDir As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents NodeMonitor As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DX As RadioButton
    Friend WithEvents DZ As RadioButton
    Friend WithEvents DY As RadioButton
    Protected WithEvents TextBox2 As TextBox
End Class
