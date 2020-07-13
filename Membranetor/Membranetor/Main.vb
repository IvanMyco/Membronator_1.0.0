Public Class MainForm
    Public FLoaded As Boolean
    Public FSolved As Boolean
    Dim FDirectoryPath As String
    Dim tbScratchDir As String
    Dim FFileName As String
    Dim FModelName As String
    Dim FNodeTotal As Integer
    Dim FDirectorySave As String
    Dim PosizioneXYZ(2) As Double
    Dim SpostamentoXYZ(4) As Double
    Dim iNumPrimary As Int32
    Dim iNumSecondary As Int32
    Dim strFilename As String
    Dim strName As String
    Dim StraussNameFile As String
    Dim strDirectory As String
    Dim D As Integer
    Dim iErr As Int32


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DZ.Select()
        Iterazioni.Value = 2
        NodeMonitor.Text = ("1")
    End Sub


    Private Function HandleError(ByVal ErrorCode As Int32) As Boolean
        Dim sErrorString As String

        If ErrorCode <> ERR7_NoError Then
            sErrorString = NullString(kMaxStrLen)
            If ERR7_NoError = St7GetAPIErrorString(ErrorCode, sErrorString, kMaxStrLen) Then
                Call MsgBox(VBString(sErrorString), vbCritical)
            ElseIf ERR7_NoError = St7GetSolverErrorString(ErrorCode, sErrorString, kMaxStrLen) Then
                Call MsgBox(VBString(sErrorString), vbCritical)
            End If
            HandleError = True
        Else
            HandleError = False
        End If
    End Function
    Private Function NullString(ByVal StringLen As Integer) As String
        Dim i As Integer

        NullString = ""
        For i = 1 To StringLen
            NullString = NullString & Chr(0)
        Next i
    End Function
    Private Function VBString(ByVal NullTerminatedString As String) As String
        Dim i As Integer

        VBString = ""
        For i = 0 To NullTerminatedString.Length - 1
            If NullTerminatedString.Chars(i) = Chr(0) Then
                Exit For
            End If
            VBString = VBString & NullTerminatedString.Chars(i)
        Next i
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Application.Exit()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub BtnRun_Click(sender As Object, e As EventArgs) Handles BtnRun.Click
        Dim I As Integer
        Dim N As Integer
        tbScratchDir = txtSrcathDir.Text ' "C:\scratchdir"   'DIRECTORY DI SCRATCH A DICHIARARE
        FDirectoryPath = strDirectory ' "W:\206_SINO Wuhan_Guiyuan Temple\03_CALCULS\03_MODELS\Passerelles\02_T2\" 'DA MODIFICARE CON IL TASTO A SCELTA DIRECTORY
        FFileName = StraussNameFile   '"2020-07-09_HDA_PasserelleT2_V4_FormFindingStep" 'NOME DEL FILE
        FDirectorySave = txtSaveDir.Text   '"C:\Users\ivan.micozzi\Desktop\TestDirectory\" 'DA MODIFICARE CON LA STESSA DIRECTORY DEL FILE DI PARTENZA
        FDirectorySave = txtSaveDir.Text & "\"

        ListSpostamenti.Clear()

        iErr = St7Init()
        If HandleError(iErr) Then
            End
        End If
        FLoaded = False
        FSolved = False

        FModelName = FDirectoryPath + FFileName & ".st7"
        iErr = St7OpenFile(1, FModelName, tbScratchDir)
        If HandleError(iErr) Then
            End
        End If
        FLoaded = False
        FSolved = False


        iErr = St7SaveFileTo(1, FDirectorySave + FFileName & "_STEP_0" & ".st7")
        If HandleError(iErr) Then
            End
        End If
        FLoaded = False
        FSolved = False

        iErr = St7CloseFile(1)
        If HandleError(iErr) Then
            End
        End If
        FLoaded = False
        FSolved = False


        FModelName = FDirectorySave + FFileName & "_STEP_0" & ".st7"
        iErr = St7OpenFile(1, FModelName, tbScratchDir)
        If HandleError(iErr) Then
            End
        End If
        FLoaded = False
        FSolved = False

        iErr = St7RunSolver(1, stNonlinearStaticSolver, smBackgroundRun, btTrue)
        If HandleError(iErr) Then
            End
        End If
        FLoaded = False
        FSolved = False

        Call St7CloseFile(1)
        FDirectorySave = txtSaveDir.Text & "\"

        N = Iterazioni.Value


        For I = 0 To N - 1


            FModelName = FDirectorySave + FFileName & "_STEP_" & (I) & ".st7"
            iErr = St7OpenFile(1, FModelName, tbScratchDir)
            If HandleError(iErr) Then
                End
            End If
            FLoaded = False
            FSolved = False
            iErr = St7SaveFileTo(1, FDirectorySave + FFileName & "_STEP_" & (I + 1) & ".st7")
            If HandleError(iErr) Then
                End
            End If
            FLoaded = False
            FSolved = False

            iErr = St7RunSolver(1, stNonlinearStaticSolver, smProgressRunsmNormalCloseRun, btTrue)
            If HandleError(iErr) Then
                End
            End If
            FLoaded = False
            FSolved = False

            iErr = St7OpenResultFile(1, FDirectorySave + FFileName & "_STEP_" & (I) & ".NLA", "", btTrue, iNumPrimary, iNumSecondary)
            If HandleError(iErr) Then
                End
            End If
            FLoaded = False
            FSolved = False

            iErr = St7OpenFile(2, FDirectorySave + FFileName & "_STEP_" & (I + 1) & ".st7", tbScratchDir)
            If HandleError(iErr) Then
                End
            End If
            FLoaded = False
            FSolved = False
            Call St7GetTotal(1, tyNODE, FNodeTotal)
            Dim NodeIntegerMonitor As Integer = CInt(NodeMonitor.Text)


            For j As Integer = 1 To FNodeTotal

                Call St7GetNodeXYZ(1, j, PosizioneXYZ(0))
                Call St7GetNodeResult(1, rtNodeDisp, j, 2, SpostamentoXYZ(0))
                Dim Totale(2) As Double

                For k As Integer = 0 To PosizioneXYZ.Length - 1
                    Totale(k) = PosizioneXYZ(k) + SpostamentoXYZ(k)
                Next

                iErr = St7SetNodeXYZ(2, j, Totale(0))
                If HandleError(iErr) Then
                    End
                End If
                FLoaded = False
                FSolved = False
                Dim W As Integer = 1





            Next
            iErr = St7SaveFile(2)
            If HandleError(iErr) Then
                End
            End If
            FLoaded = False
            FSolved = False

            'ListSpostamenti.AppendText(SpostamentoXYZ(D).ToString)
            'ListSpostamenti.Text += Environment.NewLine

            'ListSpostamenti.AppendText(SpostamentoXYZ(D).ToString)
            'ListSpostamenti.Text += System.Environment.NewLine
            If NodeIntegerMonitor > FNodeTotal Then
                NodeIntegerMonitor = FNodeTotal
                MessageBox.Show("Node Monitor selected doesn't exist" & vbCrLf & "Node monitor is setted to: " & CStr(FNodeTotal))
                NodeMonitor.Text = FNodeTotal
            Else
                NodeIntegerMonitor = CInt(NodeMonitor.Text)
            End If
            Call St7GetNodeResult(1, rtNodeDisp, NodeIntegerMonitor, 2, SpostamentoXYZ(0))
            Console.WriteLine("lo spostamento è " & SpostamentoXYZ(D))
            ListSpostamenti.AppendText(SpostamentoXYZ(D).ToString & vbCrLf)
            'ListSpostamenti.Text += System.Environment.NewLine
            ' Console.WriteLine("lo spostamento è " & SpostamentoXYZ(0))

            Call St7CloseResultFile(1)
            Call St7CloseResultFile(2)
            Call St7CloseFile(1)
            Call St7CloseFile(2)

        Next
        Console.WriteLine(I)
        FModelName = FDirectorySave + FFileName & "_STEP_" & (I) & ".st7"
        iErr = St7OpenFile(1, FModelName, tbScratchDir)
        If HandleError(iErr) Then
            End
        End If
        FLoaded = False
        FSolved = False

        iErr = St7RunSolver(1, stNonlinearStaticSolver, smProgressRunsmNormalCloseRun, btTrue)
        If HandleError(iErr) Then
            End
        End If
        FLoaded = False
        FSolved = False

        iErr = St7OpenResultFile(1, FDirectorySave + FFileName & "_STEP_" & (I) & ".NLA", "", btTrue, iNumPrimary, iNumSecondary)
        If HandleError(iErr) Then
            End
        End If
        FLoaded = False
        FSolved = False

        Call St7CloseFile(1)
        Call St7CloseResultFile(1)


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        openFD.Filter = "st7 files (*.st7)|*.st7"
        'openFD.FilterIndex = 2
        'openFD.ShowDialog()
        If openFD.ShowDialog = DialogResult.OK Then
            strFilename = openFD.FileName


            For i As Integer = 0 To strFilename.Length - 1
                If strFilename(strFilename.Length - 1 - i) = "\" Then
                    strName = tRight(strFilename, i)
                    strDirectory = strFilename.Substring(0, strFilename.Length - i)
                    Exit For
                End If

            Next
            For i As Integer = 0 To strName.Length - 1
                If strName(strName.Length - 1 - i) = "." Then
                    StraussNameFile = strName.Substring(0, strName.Length - i - 1)
                End If
            Next

            'MessageBox.Show(strFilename)
            'MessageBox.Show(strDirectory)
            'MessageBox.Show(strName)
            'MessageBox.Show(StraussNameFile)

            txtFileName.Text = strName


        End If
        openFD.Dispose()








    End Sub

    Function tRight(value As String, length As Integer) As String
        ' Get rightmost characters of specified length.
        Return value.Substring(value.Length - length)
    End Function


    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles openFD.FileOk

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strScratchDir As String
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Application Configeration Files Path"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            strScratchDir = dialog.SelectedPath
            '  MessageBox.Show(strScratchDir)
            txtSrcathDir.Text = strScratchDir
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim A(2) As Double
        A = {1, 2, 3}
        Dim B(2) As Double
        B = {1, 1, 1, 5, 6}
        Dim C(2) As Double
        For i As Integer = 0 To C.Length - 1
            C(i) = A(i) + B(i)

        Next
        Dim result As String = String.Join(";", C)
        Dim N As Integer
        N = Iterazioni.Value
        MessageBox.Show(N)

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles Iterazioni.ValueChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim strSaveDir As String
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Application Configeration Files Path"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            strSaveDir = dialog.SelectedPath
            ' MessageBox.Show(strSaveDir)
            txtSaveDir.Text = strSaveDir
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles DX.CheckedChanged
        D = 0
    End Sub

    Private Sub DY_CheckedChanged(sender As Object, e As EventArgs) Handles DY.CheckedChanged
        D = 1

    End Sub

    Private Sub DZ_CheckedChanged(sender As Object, e As EventArgs) Handles DZ.CheckedChanged
        D = 2

    End Sub
End Class