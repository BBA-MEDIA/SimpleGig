Imports System.Deployment.Application
Imports System.Drawing.Imaging
Imports System.Drawing.Text
Imports System.IO
Imports System.Reflection.Emit
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports WMPLib


Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Specify the folder path here
        'Dim folderPath As String = "C:\YourFolderPath"

        Buttons(1) = Button1
        Buttons(2) = Button2
        Buttons(3) = Button3
        Buttons(4) = Button4
        Buttons(5) = Button5
        Buttons(6) = Button6
        Buttons(7) = Button7
        Buttons(8) = Button8
        Buttons(9) = Button9
        Buttons(10) = Button10
        Buttons(11) = Button11
        Buttons(12) = Button12
        Buttons(13) = Button13
        Buttons(14) = Button14
        Buttons(15) = Button15
        Buttons(16) = Button16
        Buttons(17) = Button17
        Buttons(18) = Button18
        Buttons(19) = Button19
        Buttons(20) = Button20


        folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)

        FileCheck()

        'MessageBox.Show("Documents folder path: " & folderPath)
        ' Call the method to load files into the ListBox
        LoadFilesToListBox(folderPath)

        RadioButton1.Checked = True

        Me.Enabled = True

        CalculateTotalTime()

    End Sub
    Private Sub FileCheck()

        FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)

        Dim MediaFile As String

        For j = 1 To 4

            If j = 1 Then MediaFile = "GROUP_A"
            If j = 2 Then MediaFile = "GROUP_B"
            If j = 3 Then MediaFile = "GROUP_C"
            If j = 4 Then MediaFile = "GROUP_D"

            Dim NewFilePath = FilePath + "\" + MediaFile

            If Not File.Exists(NewFilePath) Then
                ' Create the file
                Using writer As New StreamWriter(NewFilePath)

                    writer.WriteLine("TRACK 1")
                    writer.WriteLine("TRACK 2")
                    writer.WriteLine("TRACK 3")
                    writer.WriteLine("TRACK 4")
                    writer.WriteLine("TRACK 5")
                    writer.WriteLine("TRACK 6")
                    writer.WriteLine("TRACK 7")
                    writer.WriteLine("TRACK 8")
                    writer.WriteLine("TRACK 9")
                    writer.WriteLine("TRACK 10")
                    writer.WriteLine("TRACK 11")
                    writer.WriteLine("TRACK 12")
                    writer.WriteLine("TRACK 13")
                    writer.WriteLine("TRACK 14")
                    writer.WriteLine("TRACK 15")
                    writer.WriteLine("TRACK 16")
                    writer.WriteLine("TRACK 17")
                    writer.WriteLine("TRACK 18")
                    writer.WriteLine("TRACK 19")
                    writer.WriteLine("TRACK 20")

                End Using
                If ExportYes = 0 Then MessageBox.Show("A new " + MediaFile + " Set file has been created.", "New Group")
            Else
                'MessageBox.Show("The file " + NewFilePath + " already exists.")
            End If

        Next j

    End Sub
    Private Sub LoadFilesToListBox(folderPath As String)

        ' Clear the ListBox beBack loading new items
        ListBoxMusic.Items.Clear()
        ListBoxTemp.Items.Clear()
        ' Check if the directory exists
        If System.IO.Directory.Exists(folderPath) Then

            Dim files As String() = Directory.GetFiles(folderPath, "*.mp3") ' Only load .mp3 files
            For Each file As String In files
                ListBoxMusic.Items.Add(System.IO.Path.GetFileName(file)) ' Add file name only
                ListBoxTemp.Items.Add(System.IO.Path.GetFileName(file)) ' Add file name only
            Next
        Else
            MessageBox.Show("The folder or path does not exist.")
        End If

        FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
        FilePath = FilePath + "\" + "GROUP_A" : LoadFile()

    End Sub

    Private Sub WhiteOut()

        For j = 1 To 20

            Buttons(j).BackColor = Color.White

        Next
    End Sub
    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown

        If Button1.Text = "TRACK 1" Then Exit Sub

        Button1.Refresh()

        If TextBoxSearch.Enabled = False And Button1.BackColor = Color.White Then Exit Sub

        CurrentButton = 1

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button1.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button1.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()


    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown

        If Button2.Text = "TRACK 2" Then Exit Sub
        Button2.Refresh()
        If TextBoxSearch.Enabled = False And Button2.BackColor = Color.White Then Exit Sub

        CurrentButton = 2

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button2.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button2.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown

        If Button3.Text = "TRACK 3" Then Exit Sub
        Button3.Refresh()
        If TextBoxSearch.Enabled = False And Button3.BackColor = Color.White Then Exit Sub

        CurrentButton = 3

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button3.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button3.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button4_MouseDown(sender As Object, e As MouseEventArgs) Handles Button4.MouseDown

        If Button4.Text = "TRACK 4" Then Exit Sub
        Button4.Refresh()
        If TextBoxSearch.Enabled = False And Button4.BackColor = Color.White Then Exit Sub

        CurrentButton = 4

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button4.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button4.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button5_MouseDown(sender As Object, e As MouseEventArgs) Handles Button5.MouseDown

        If Button5.Text = "TRACK 5" Then Exit Sub
        Button5.Refresh()
        If TextBoxSearch.Enabled = False And Button5.BackColor = Color.White Then Exit Sub

        CurrentButton = 5

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button5.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button5.BackColor = Color.Green

        TextBoxRemainingTime.BackColor = Color.White

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button6_MouseDown(sender As Object, e As MouseEventArgs) Handles Button6.MouseDown

        If Button6.Text = "TRACK 6" Then Exit Sub
        Button6.Refresh()
        If TextBoxSearch.Enabled = False And Button6.BackColor = Color.White Then Exit Sub

        CurrentButton = 6

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If
        CurrentTrack = folderPath + "\" + Button6.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button6.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button7_MouseDown(sender As Object, e As MouseEventArgs) Handles Button7.MouseDown

        If Button7.Text = "TRACK 7" Then Exit Sub
        Button7.Refresh()
        If TextBoxSearch.Enabled = False And Button7.BackColor = Color.White Then Exit Sub

        CurrentButton = 7

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button7.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button7.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button8_MouseDown(sender As Object, e As MouseEventArgs) Handles Button8.MouseDown

        If Button8.Text = "TRACK 8" Then Exit Sub
        Button8.Refresh()
        If TextBoxSearch.Enabled = False And Button8.BackColor = Color.White Then Exit Sub

        CurrentButton = 8

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button8.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button8.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button9_MouseDown(sender As Object, e As MouseEventArgs) Handles Button9.MouseDown

        If Button9.Text = "TRACK 9" Then Exit Sub
        Button9.Refresh()
        If TextBoxSearch.Enabled = False And Button9.BackColor = Color.White Then Exit Sub

        CurrentButton = 9

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button9.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button9.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button10_MouseDown(sender As Object, e As MouseEventArgs) Handles Button10.MouseDown

        If Button10.Text = "TRACK 10" Then Exit Sub
        Button10.Refresh()
        If TextBoxSearch.Enabled = False And Button10.BackColor = Color.White Then Exit Sub

        CurrentButton = 10

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button10.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button10.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button11_MouseDown(sender As Object, e As MouseEventArgs) Handles Button11.MouseDown

        If Button11.Text = "TRACK 11" Then Exit Sub
        Button11.Refresh()
        If TextBoxSearch.Enabled = False And Button11.BackColor = Color.White Then Exit Sub

        CurrentButton = 11

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button11.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button11.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button12_MouseDown(sender As Object, e As MouseEventArgs) Handles Button12.MouseDown

        If Button12.Text = "TRACK 12" Then Exit Sub
        Button12.Refresh()
        If TextBoxSearch.Enabled = False And Button12.BackColor = Color.White Then Exit Sub

        CurrentButton = 12

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button12.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button12.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button13_MouseDown(sender As Object, e As MouseEventArgs) Handles Button13.MouseDown


        If Button13.Text = "TRACK 13" Then Exit Sub
        Button13.Refresh()
        If TextBoxSearch.Enabled = False And Button13.BackColor = Color.White Then Exit Sub

        CurrentButton = 13

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button13.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button13.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button14_MouseDown(sender As Object, e As MouseEventArgs) Handles Button14.MouseDown

        If Button14.Text = "TRACK 14" Then Exit Sub
        Button14.Refresh()
        If TextBoxSearch.Enabled = False And Button14.BackColor = Color.White Then Exit Sub

        CurrentButton = 14

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button14.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button14.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button15_MouseDown(sender As Object, e As MouseEventArgs) Handles Button15.MouseDown

        If Button15.Text = "TRACK 15" Then Exit Sub
        Button15.Refresh()
        If TextBoxSearch.Enabled = False And Button15.BackColor = Color.White Then Exit Sub

        CurrentButton = 15

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button15.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button15.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button16_MouseDown(sender As Object, e As MouseEventArgs) Handles Button16.MouseDown

        If Button16.Text = "TRACK 16" Then Exit Sub
        Button16.Refresh()
        If TextBoxSearch.Enabled = False And Button16.BackColor = Color.White Then Exit Sub

        CurrentButton = 16

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button16.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button16.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button17_MouseDown(sender As Object, e As MouseEventArgs) Handles Button17.MouseDown

        If Button17.Text = "TRACK 17" Then Exit Sub
        Button17.Refresh()
        If TextBoxSearch.Enabled = False And Button17.BackColor = Color.White Then Exit Sub

        CurrentButton = 17

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button17.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button17.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button18_MouseDown(sender As Object, e As MouseEventArgs) Handles Button18.MouseDown

        If Button18.Text = "TRACK 18" Then Exit Sub
        Button18.Refresh()
        If TextBoxSearch.Enabled = False And Button18.BackColor = Color.White Then Exit Sub

        CurrentButton = 18

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button18.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button18.BackColor = Color.Green
        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button19_MouseDown(sender As Object, e As MouseEventArgs) Handles Button19.MouseDown

        If Button19.Text = "TRACK 19" Then Exit Sub
        Button19.Refresh()
        If TextBoxSearch.Enabled = False And Button19.BackColor = Color.White Then Exit Sub

        CurrentButton = 19

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button19.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button19.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub Button20_MouseDown(sender As Object, e As MouseEventArgs) Handles Button20.MouseDown

        If Button20.Text = "TRACK 20" Then Exit Sub
        Button20.Refresh()
        If TextBoxSearch.Enabled = False And Button20.BackColor = Color.White Then Exit Sub

        CurrentButton = 20

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Form2.ShowDialog()
            Exit Sub

        End If

        CurrentTrack = folderPath + "\" + Button20.Text

        ' Assign the file to Windows Media Player control and play
        VolumeNow = 80
        NumericUpDownFade.Text = "80"

        AxWindowsMediaPlayer1.settings.volume = VolumeNow
        AxWindowsMediaPlayer1.URL = CurrentTrack
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        WhiteOut() : Button20.BackColor = Color.Green

        If AxWindowsMediaPlayer1.currentMedia.duration > 0 Then

            Timer1.Start()
            Exit Sub

        End If

        MessageBox.Show("Media File not Found or Empty")
        WhiteOut()

    End Sub

    Private Sub DownVolume()

        CurrentVolume = AxWindowsMediaPlayer1.settings.volume

        For VolumeNow = CurrentVolume To 0 Step -1

            AxWindowsMediaPlayer1.settings.volume = VolumeNow

            Delay()

        Next

    End Sub


    Sub Delay()

        For J = 1 To 30

            NumericUpDownFade.Value = VolumeNow
            NumericUpDownFade.Refresh()
            TextBoxElapsedTime.Text = "Fade: " + Str(VolumeNow)
            TextBoxElapsedTime.Refresh()

        Next J

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            ' Media is currently playing
            TextBoxActive.Text = ("Media is active and playing.")
            TextBoxSearch.Enabled = False
            Panel1.Enabled = False
            ListBoxMusic.Enabled = False
            ButtonExport.Enabled = False
            ButtonImport.Enabled = False
        Else
            ' Media is not playing
            TextBoxActive.Text = ("Media is not active.")
            TextBoxSearch.Enabled = True
            Panel1.Enabled = True
            ListBoxMusic.Enabled = True
            ButtonExport.Enabled = True
            ButtonImport.Enabled = True
        End If


        'If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
        ' Get the current position in seconds
        UseMediaPlayer1()


    End Sub
    Private Sub UseMediaPlayer1()

        Dim currentPosition As Double = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition

        'ListBoxMusic.Enabled = False
        'TextBoxSearch.Enabled = False

        ' Convert to minutes and seconds
        Dim minutes1 As Integer = Math.Floor(currentPosition / 60)
        Dim seconds1 As Integer = Math.Floor(currentPosition Mod 60)

        ' Update the label with the current position in time format
        TextBoxElapsedTime.Text = String.Format("Elapsed: {0:D2}:{1:D2}", minutes1, seconds1)

        Dim totalDuration As Double = AxWindowsMediaPlayer1.currentMedia.duration
        'TextBoxTotalDuration.Text = totalDuration

        ' Calculate the remaining time
        Dim remainingTime As Double = totalDuration - currentPosition

        ' Display the remaining time (in minutes and seconds)
        TextBoxRemainingTime.Text = "Remaining:" + TimeSpan.FromSeconds(remainingTime).ToString("mm\:ss")

        If remainingTime < 21 Then
            TextBoxRemainingTime.BackColor = Color.LightGreen
            TextBoxElapsedTime.BackColor = Color.LightGreen
        End If

        If remainingTime < 11 Then
            TextBoxRemainingTime.BackColor = Color.LightSalmon
            TextBoxElapsedTime.BackColor = Color.LightSalmon
        End If

        If currentPosition = 0 Then

            EndOfTrack()

        End If


    End Sub

    Private Sub UseMediaPlayer2()

        Dim currentPosition As Double = AxWindowsMediaPlayer2.Ctlcontrols.currentPosition

        ' Convert to minutes and seconds
        Dim minutes1 As Integer = Math.Floor(currentPosition / 60)
        Dim seconds1 As Integer = Math.Floor(currentPosition Mod 60)

        ' Update the label with the current position in time format
        TextBoxElapsedTime.Text = String.Format("Elapsed: {0:D2}:{1:D2}", minutes1, seconds1)

        Dim totalDuration As Double = AxWindowsMediaPlayer2.currentMedia.duration

        ' Calculate the remaining time
        Dim remainingTime As Double = totalDuration - currentPosition

        ' Display the remaining time (in minutes and seconds)
        TextBoxRemainingTime.Text = "Remaining:" + TimeSpan.FromSeconds(remainingTime).ToString("mm\:ss")

        If remainingTime < 21 Then
            TextBoxRemainingTime.BackColor = Color.LightGreen
            TextBoxElapsedTime.BackColor = Color.LightGreen
        End If

        If remainingTime < 11 Then
            TextBoxRemainingTime.BackColor = Color.LightSalmon
            TextBoxElapsedTime.BackColor = Color.LightSalmon
        End If

        If currentPosition = 0 Then

            EndOfTrack()

        End If


    End Sub
    Private Sub EndOfTrack()

        TextBoxRemainingTime.BackColor = Color.White
        TextBoxRemainingTime.Text = ""
        TextBoxElapsedTime.BackColor = Color.White
        TextBoxElapsedTime.Text = ""


        For j = 1 To 20

            Buttons(j).backcolor = Color.White

        Next

        Timer1.Stop()

    End Sub

    Private Sub ListBoxMusic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMusic.SelectedIndexChanged
        ' Check if an item is selected

        If ListBoxMusic.SelectedIndex <> -1 Then
            ' Retrieve the selected item text
            Dim selectedText As String = ListBoxMusic.SelectedItem.ToString()
            DroppedText = selectedText
            'MessageBox.Show("Selected item: " & selectedText)
        Else
            'MessageBox.Show("No item selected.")
        End If

        FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
        Dim media As IWMPMedia = wmp.newMedia(FilePath + "/" + ListBoxMusic.SelectedItem.ToString)

        ' Get the duration (in seconds)
        Dim duration As Double = media.duration
        TextBoxTotalDuration.Text = TimeSpan.FromSeconds(duration).ToString("mm\:ss")

    End Sub
    Private Sub ListBoxMusic_MouseDown(sender As Object, e As MouseEventArgs) Handles ListBoxMusic.MouseDown
        If ListBoxMusic.SelectedItem IsNot Nothing Then
            ' Start dragging the selected item
            ListBoxMusic.DoDragDrop(ListBoxMusic.SelectedItem.ToString(), DragDropEffects.Copy)
            Button1.AllowDrop = True
        End If

    End Sub
    Private Sub Button1_DragEnter(sender As Object, e As DragEventArgs) Handles Button1.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button1_DragDrop(sender As Object, e As DragEventArgs) Handles Button1.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button1.Text = droppedText
        SaveFile()
        CurrentButton = 1

    End Sub

    Private Sub Button2_DragEnter(sender As Object, e As DragEventArgs) Handles Button2.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button2_DragDrop(sender As Object, e As DragEventArgs) Handles Button2.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button2.Text = droppedText
        SaveFile()
        CurrentButton = 2

    End Sub
    Private Sub Button3_DragEnter(sender As Object, e As DragEventArgs) Handles Button3.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button3_DragDrop(sender As Object, e As DragEventArgs) Handles Button3.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button3.Text = droppedText
        SaveFile()
        CurrentButton = 3

    End Sub
    Private Sub Button4_DragEnter(sender As Object, e As DragEventArgs) Handles Button4.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button4_DragDrop(sender As Object, e As DragEventArgs) Handles Button4.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button4.Text = droppedText
        SaveFile()
        CurrentButton = 4

    End Sub
    Private Sub Button5_DragEnter(sender As Object, e As DragEventArgs) Handles Button5.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button5_DragDrop(sender As Object, e As DragEventArgs) Handles Button5.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button5.Text = droppedText
        SaveFile()
        CurrentButton = 5

    End Sub
    Private Sub Button6_DragEnter(sender As Object, e As DragEventArgs) Handles Button6.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button6_DragDrop(sender As Object, e As DragEventArgs) Handles Button6.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button6.Text = droppedText
        SaveFile()
        CurrentButton = 6

    End Sub
    Private Sub Button7_DragEnter(sender As Object, e As DragEventArgs) Handles Button7.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button7_DragDrop(sender As Object, e As DragEventArgs) Handles Button7.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button7.Text = droppedText
        SaveFile()
        CurrentButton = 7

    End Sub
    Private Sub Button8_DragEnter(sender As Object, e As DragEventArgs) Handles Button8.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button8_DragDrop(sender As Object, e As DragEventArgs) Handles Button8.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button8.Text = droppedText
        SaveFile()
        CurrentButton = 8

    End Sub
    Private Sub Button9_DragEnter(sender As Object, e As DragEventArgs) Handles Button9.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button9_DragDrop(sender As Object, e As DragEventArgs) Handles Button9.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button9.Text = droppedText
        SaveFile()
        CurrentButton = 9

    End Sub
    Private Sub Button10_DragEnter(sender As Object, e As DragEventArgs) Handles Button10.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button10_DragDrop(sender As Object, e As DragEventArgs) Handles Button10.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button10.Text = droppedText
        SaveFile()
        CurrentButton = 10

    End Sub
    Private Sub Button11_DragEnter(sender As Object, e As DragEventArgs) Handles Button11.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button11_DragDrop(sender As Object, e As DragEventArgs) Handles Button11.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button11.Text = droppedText
        SaveFile()
        CurrentButton = 11

    End Sub
    Private Sub Button12_DragEnter(sender As Object, e As DragEventArgs) Handles Button12.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button12_DragDrop(sender As Object, e As DragEventArgs) Handles Button12.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button12.Text = droppedText
        SaveFile()
        CurrentButton = 12

    End Sub

    Private Sub Button13_DragEnter(sender As Object, e As DragEventArgs) Handles Button13.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button13_DragDrop(sender As Object, e As DragEventArgs) Handles Button13.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button13.Text = droppedText
        SaveFile()
        CurrentButton = 13

    End Sub

    Private Sub Button14_DragEnter(sender As Object, e As DragEventArgs) Handles Button14.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button14_DragDrop(sender As Object, e As DragEventArgs) Handles Button14.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button14.Text = droppedText
        SaveFile()
        CurrentButton = 14

    End Sub

    Private Sub Button15_DragEnter(sender As Object, e As DragEventArgs) Handles Button15.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button15_DragDrop(sender As Object, e As DragEventArgs) Handles Button15.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button15.Text = droppedText
        SaveFile()
        CurrentButton = 15

    End Sub

    Private Sub Button16_DragEnter(sender As Object, e As DragEventArgs) Handles Button16.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button16_DragDrop(sender As Object, e As DragEventArgs) Handles Button16.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button16.Text = droppedText
        SaveFile()
        CurrentButton = 16

    End Sub

    Private Sub Button17_DragEnter(sender As Object, e As DragEventArgs) Handles Button17.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button17_DragDrop(sender As Object, e As DragEventArgs) Handles Button17.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button17.Text = droppedText
        SaveFile()
        CurrentButton = 17

    End Sub
    Private Sub Button18_DragEnter(sender As Object, e As DragEventArgs) Handles Button18.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button18_DragDrop(sender As Object, e As DragEventArgs) Handles Button18.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button18.Text = droppedText
        SaveFile()
        CurrentButton = 18

    End Sub

    Private Sub Button19_DragEnter(sender As Object, e As DragEventArgs) Handles Button19.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button19_DragDrop(sender As Object, e As DragEventArgs) Handles Button19.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button19.Text = droppedText
        SaveFile()
        CurrentButton = 19

    End Sub

    Private Sub Button20_DragEnter(sender As Object, e As DragEventArgs) Handles Button20.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy  ' Allow the drop
        Else
            e.Effect = DragDropEffects.None ' Disallow the drop
        End If
    End Sub
    Private Sub Button20_DragDrop(sender As Object, e As DragEventArgs) Handles Button20.DragDrop

        ' Retrieve the dropped text and set it into the TextBox
        Dim droppedText As String = e.Data.GetData(DataFormats.Text).ToString()
        Button20.Text = droppedText
        SaveFile()
        CurrentButton = 20

    End Sub
    Sub SaveFile()

        FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)

        If RadioButton1.Checked = True Then FilePath = FilePath + "\" + "GROUP_A"
        If RadioButton2.Checked = True Then FilePath = FilePath + "\" + "GROUP_B"
        If RadioButton3.Checked = True Then FilePath = FilePath + "\" + "GROUP_C"
        If RadioButton4.Checked = True Then FilePath = FilePath + "\" + "GROUP_D"

        ' Create or overwrite the file and write the text
        Using writer As New StreamWriter(FilePath)

            writer.WriteLine(Button1.Text)
            writer.WriteLine(Button2.Text)
            writer.WriteLine(Button3.Text)
            writer.WriteLine(Button4.Text)
            writer.WriteLine(Button5.Text)
            writer.WriteLine(Button6.Text)
            writer.WriteLine(Button7.Text)
            writer.WriteLine(Button8.Text)
            writer.WriteLine(Button9.Text)
            writer.WriteLine(Button10.Text)
            writer.WriteLine(Button11.Text)
            writer.WriteLine(Button12.Text)
            writer.WriteLine(Button13.Text)
            writer.WriteLine(Button14.Text)
            writer.WriteLine(Button15.Text)
            writer.WriteLine(Button16.Text)
            writer.WriteLine(Button17.Text)
            writer.WriteLine(Button18.Text)
            writer.WriteLine(Button19.Text)
            writer.WriteLine(Button20.Text)

        End Using

        CalculateTotalTime()

    End Sub

    Private Sub LoadFile()
        Try
            If File.Exists(FilePath) Then
                Using reader As New StreamReader(FilePath)
                    Button1.Text = reader.ReadLine()
                    Button2.Text = reader.ReadLine()
                    Button3.Text = reader.ReadLine()
                    Button4.Text = reader.ReadLine()
                    Button5.Text = reader.ReadLine()
                    Button6.Text = reader.ReadLine()
                    Button7.Text = reader.ReadLine()
                    Button8.Text = reader.ReadLine()
                    Button9.Text = reader.ReadLine()
                    Button10.Text = reader.ReadLine()
                    Button11.Text = reader.ReadLine()
                    Button12.Text = reader.ReadLine()
                    Button13.Text = reader.ReadLine()
                    Button14.Text = reader.ReadLine()
                    Button15.Text = reader.ReadLine()
                    Button16.Text = reader.ReadLine()
                    Button17.Text = reader.ReadLine()
                    Button18.Text = reader.ReadLine()
                    Button19.Text = reader.ReadLine()
                    Button20.Text = reader.ReadLine()
                End Using
            Else
                'MessageBox.Show("File not found!")
                Exit Sub
            End If

        Catch

            MessageBox.Show("File not Found at this location.")
            Exit Sub

        End Try

        'MessageBox.Show("Loaded:" + FilePath)

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click

        'SaveGroup = "GROUP_A"
        ChooseFile()
        CalculateTotalTime()

    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click

        'SaveGroup = "GROUP_B"
        ChooseFile()
        CalculateTotalTime()

    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click

        'SaveGroup = "GROUP_C"
        ChooseFile()
        CalculateTotalTime()

    End Sub

    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles RadioButton4.Click

        'SaveGroup = "GROUP_D"
        ChooseFile()
        CalculateTotalTime()

    End Sub

    Private Sub Button21_Click_1(sender As Object, e As EventArgs) Handles ButtonExport.Click

        'Dim result As DialogResult = MessageBox.Show("Export will empty and refresh tracks. Proceed?", "Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's choice
        'If result = DialogResult.No Then

        'Exit Sub

        'End If

        Dim ExportName As String
        ExportName = InputBox("Export Folder Name:", "Export", " ")

        If ExportName = " " Then
            MessageBox.Show("You must enter a name to continue.")
            Exit Sub
        ElseIf ExportName = "" Then
            Exit Sub
        End If


        Dim DestPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\" + ExportName 'DateTime.Now.ToString("yyyy-MM-dd")
        Dim SourcePath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)

        ' Define source and destination folders
        Dim sourceFolder As String = SourcePath
        Dim destinationFolder As String = DestPath

        ' Ensure the destination folder exists
        If Not Directory.Exists(destinationFolder) Then
            Directory.CreateDirectory(destinationFolder)
        End If

        ' Get all files from the source folder
        Dim files As String() = Directory.GetFiles(sourceFolder)

        ' Move each file to the destination folder
        'For Each FilePath In files
        For j = 1 To 4

            Dim Filename As String

            If j = 1 Then Filename = "GROUP_A"
            If j = 2 Then Filename = "GROUP_B"
            If j = 3 Then Filename = "GROUP_C"
            If j = 4 Then Filename = "GROUP_D"

            'Dim fileName As String = Path.GetFileName(FilePath) ' Extract the file name
            Dim destinationPath As String = Path.Combine(destinationFolder, Filename)
            File.Move(sourceFolder + "\" + Filename, destinationPath)
            Console.WriteLine($"Moved: {FilePath} -> {destinationPath}")
            'Next

        Next j

        For j = 1 To 20

            Buttons(j).text = "TRACK" + Str(j)

        Next j

        ChooseFile()

        ExportYes = 1

        FileCheck()

        ExportYes = 0

        CalculateTotalTime()

    End Sub
    Private Sub ChooseFile()

        FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)

        If RadioButton1.Checked = True Then FilePath = FilePath + "\" + "GROUP_A"
        If RadioButton2.Checked = True Then FilePath = FilePath + "\" + "GROUP_B"
        If RadioButton3.Checked = True Then FilePath = FilePath + "\" + "GROUP_C"
        If RadioButton4.Checked = True Then FilePath = FilePath + "\" + "GROUP_D"

        LoadFile()

    End Sub

    Private Sub Button22_Click_1(sender As Object, e As EventArgs) Handles ButtonImport.Click

        Try

            Using folderDialog As New FolderBrowserDialog()
                ' Set the description for the dialog
                folderDialog.Description = "Select a folder"

                ' Optional: Set the default selected path
                folderDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
                Dim SelectedFolder As String

                ' Show the dialog and check if the user clicks OK
                If folderDialog.ShowDialog() = DialogResult.OK Then
                    ' Get the selected folder path
                    SelectedFolder = folderDialog.SelectedPath

                    ' Display the selected folder in a message box or set it in a label
                    ' Display a message box with Yes and No buttons
                    Dim result As DialogResult = MessageBox.Show("Proceed with Import?", "Import", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    ' Check the user's choice
                    If result = DialogResult.No Then
                        Exit Sub
                    ElseIf result = DialogResult.Yes Then

                    End If
                Else
                    MessageBox.Show("No folder was selected.", "Import")
                End If


                Dim SourcePath As String = SelectedFolder

                Dim DestPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)

                ' Define source and destination folders
                Dim sourceFolder As String = SourcePath
                Dim destinationFolder As String = DestPath

                ' Ensure the destination folder exists
                If Not Directory.Exists(destinationFolder) Then
                    Directory.CreateDirectory(destinationFolder)
                End If

                ' Get all files from the source folder
                Dim files As String() = Directory.GetFiles(sourceFolder)

                ' Move each file to the destination folder
                'For Each FilePath In files
                For j = 1 To 4

                    Dim Filename As String

                    If j = 1 Then Filename = "GROUP_A"
                    If j = 2 Then Filename = "GROUP_B"
                    If j = 3 Then Filename = "GROUP_C"
                    If j = 4 Then Filename = "GROUP_D"

                    'Dim fileName As String = Path.GetFileName(FilePath) ' Extract the file name
                    Dim destinationPath As String = Path.Combine(destinationFolder, Filename)
                    File.Delete(destinationFolder + "\" + Filename)
                    File.Move(sourceFolder + "\" + Filename, destinationPath)
                    Console.WriteLine($"Moved: {FilePath} -> {destinationPath}")
                Next

            End Using

        Catch

            MessageBox.Show("File not Found at this location.")
            Exit Sub

        End Try


        LoadFile()

        RadioButton1.Checked = True
        ChooseFile()
        CalculateTotalTime()


    End Sub

    Private Sub CalculateTotalTime()

        Dim durationInSeconds As Double
        Dim TotalDuration As Double

        For j = 1 To 20

            CurrentTrack = folderPath + "\" + Buttons(j).Text

            ' Create a Windows Media Player instance
            Dim wmp As New WindowsMediaPlayer()

            ' Load the MP3 file
            Dim media As IWMPMedia = wmp.newMedia(CurrentTrack)

            ' Get the duration (in seconds)
            durationInSeconds = media.duration


            Dim Trackduration As TimeSpan = TimeSpan.FromSeconds(durationInSeconds)

            'TotalDuration = 0
            Dim CumulativeDuration As TimeSpan = TimeSpan.FromSeconds(TotalDuration)


            If j = 1 Then Label1.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 2 Then Label2.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 3 Then Label3.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 4 Then Label4.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 5 Then Label5.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 6 Then Label6.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 7 Then Label7.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 8 Then Label8.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 9 Then Label9.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 10 Then Label10.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 11 Then Label11.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 12 Then Label12.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 13 Then Label13.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 14 Then Label14.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 15 Then Label15.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 16 Then Label16.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 17 Then Label17.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 18 Then Label18.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 19 Then Label19.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"
            If j = 20 Then Label20.Text = Trackduration.ToString("mm\:ss") + " [" + CumulativeDuration.ToString("hh\:mm\:ss") + "]"

            TotalDuration = TotalDuration + durationInSeconds


        Next j

        ' Convert and display in a readable format
        Dim Finalduration As TimeSpan = TimeSpan.FromSeconds(TotalDuration)
        'MessageBox.Show("Duration: " & Finalduration.ToString("hh\:mm\:ss"))
        TextBoxTotalTime.Text = "Set Total: " + Finalduration.ToString("hh\:mm\:ss")

    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged

        Dim items = From it In ListBoxTemp.Items.Cast(Of Object)()
                    Where it.ToString().IndexOf(TextBoxSearch.Text, StringComparison.CurrentCultureIgnoreCase) >= 0
        Dim matchingItemList As List(Of Object) = items.ToList()

        ListBoxMusic.BeginUpdate()
        ListBoxMusic.Items.Clear()
        For Each item In matchingItemList
            ListBoxMusic.Items.Add(item)
        Next
        ListBoxMusic.EndUpdate()


    End Sub

    Private Sub ButtonSTOP_Click_1(sender As Object, e As EventArgs) Handles ButtonSTOP.Click

        AxWindowsMediaPlayer1.Ctlcontrols.stop()

        For j = 1 To 20
            Buttons(j).BackColor = Color.White
        Next j

    End Sub

    Private Sub ButtonFade_Click_1(sender As Object, e As EventArgs) Handles ButtonFade.Click

        Dim state As WMPPlayState = AxWindowsMediaPlayer1.playState

        Select Case state
            Case WMPPlayState.wmppsStopped
                Exit Sub
            Case WMPPlayState.wmppsUndefined
        End Select


        DownVolume()

        If CurrentButton = 3 Then Button3.BackColor = Color.White
        AxWindowsMediaPlayer1.Ctlcontrols.stop()

        For j = 1 To 20
            Buttons(j).BackColor = Color.White
        Next j


        TextBoxElapsedTime.Text = "Elapsed:"
        TextBoxRemainingTime.Text = "Remaining:"

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        MsgBox("Vwrsion: " & My.Application.Info.Version.ToString)

    End Sub

End Class
