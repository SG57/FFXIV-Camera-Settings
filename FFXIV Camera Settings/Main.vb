Imports System.Net
Imports System.Runtime.InteropServices

Public Class Main

    ' url to the memory address config file
    Const MEMORY_ADDRESSES_CONFIG_URL = "https://raw.githubusercontent.com/SG57/FFXIV-Camera-Settings/master/Memory-Addresses.txt"



    Dim _memory As Memory = New Memory
    Dim _shouldSaveSettings As Boolean = False





    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("A simple program that will adjust the camera settings for FFXIV, such as zoom and field of view." & vbCrLf & vbCrLf & vbCrLf & "Copyright ©  2014" & vbCrLf & "Cord Rehn <jordansg57@gmail.com>", MsgBoxStyle.Information, "About FFXIV Camera Settings")
    End Sub

    Private Sub DonateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonateToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=JordanSg57%40gmail%2ecom&lc=US&item_name=Freelance%20Developer&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted")
    End Sub





    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateMemoryAddresses(False)

        Me.sliderZoomMax.Value = My.Settings.ZoomMax * 100
        Me.sliderFov.Value = My.Settings.FOV * 100
        Me.checkSetZoom.Checked = My.Settings.SetZoomCurrent

        _shouldSaveSettings = True

        refreshProcessComboBoxItems()
        refreshFovLabel()
        refreshZoomMaxLabel()
    End Sub





    Private Sub refreshFovLabel()
        Me.lblFov.Text = (Me.sliderFov.Value / 100.0).ToString("N2")
    End Sub

    Private Sub refreshZoomMaxLabel()
        Me.lblZoomMax.Text = (Me.sliderZoomMax.Value / 100.0).ToString("N2")
    End Sub

    Private Sub refreshProcessComboBoxItems()
        Dim old_selected_item = Me.comboProcesses.SelectedItem
        Me.comboProcesses.Items.Clear()

        Dim ffxiv_processes As Process() = Memory.GetFFXivProcesses()
        For Each proc In ffxiv_processes
            Me.comboProcesses.Items.Add(proc.Id)
        Next

        If Not IsNothing(old_selected_item) Then
            If Me.comboProcesses.Items.Contains(old_selected_item) Then
                Me.comboProcesses.SelectedItem = old_selected_item
            End If
        Else
            If ffxiv_processes.Length > 0 Then
                Me.comboProcesses.SelectedIndex = 0
            Else
                Me.comboProcesses.SelectedItem = Nothing
            End If
        End If

        comboProcesses_SelectionChangeCommitted(Nothing, Nothing)
    End Sub





    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles comboProcesses.DropDown
        refreshProcessComboBoxItems()
    End Sub

    Private Sub comboProcesses_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles comboProcesses.SelectionChangeCommitted
        If IsNothing(Me.comboProcesses.SelectedItem) Then Return

        If Not _memory.AttachToProcess(Me.comboProcesses.SelectedItem) Then
            MsgBox("Failed to attach to FFXIV process ID: " & Me.comboProcesses.SelectedItem, MsgBoxStyle.Critical, "Process Error")
            Me.comboProcesses.SelectedItem = Nothing
        Else
            Me.groupZoom.Visible = True
            Me.groupFov.Visible = True

            _memory.WriteZoomMax(Me.sliderZoomMax.Value / 100.0)
            _memory.WriteFov(Me.sliderFov.Value / 100.0)
        End If
    End Sub





    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles sliderFov.ValueChanged
        If _shouldSaveSettings Then
            My.Settings.FOV = Me.sliderFov.Value / 100.0
            My.Settings.Save()
        End If

        refreshFovLabel()
        _memory.WriteFov(Me.sliderFov.Value / 100.0)
    End Sub

    Private Sub TrackBar2_ValueChanged(sender As Object, e As EventArgs) Handles sliderZoomMax.ValueChanged
        If _shouldSaveSettings Then
            My.Settings.ZoomMax = Me.sliderZoomMax.Value / 100.0
            My.Settings.Save()
        End If

        refreshZoomMaxLabel()
        _memory.WriteZoomMax(Me.sliderZoomMax.Value / 100.0)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkSetZoom.CheckedChanged
        If _shouldSaveSettings Then
            My.Settings.SetZoomCurrent = Me.checkSetZoom.Checked
            My.Settings.Save()
        End If
    End Sub





    Private Sub CheckForUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdateToolStripMenuItem.Click
        UpdateMemoryAddresses(True)
    End Sub

    Private Sub UpdateMemoryAddresses(ByVal verbose As Boolean)
        Try
            Dim working_date As String = "7/29/2014"

            Dim config_file As String() = New WebClient().DownloadString(MEMORY_ADDRESSES_CONFIG_URL).Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            For Each line In config_file
                Dim setting() = line.Split(New String() {"="}, 2, StringSplitOptions.None)
                For Each s In setting
                    s.Trim()
                Next

                Select Case setting(0)
                    Case "workingdate"
                        working_date = setting(1)


                    Case "cameraaddress"
                        Dim camera_offsets() = setting(1).Split(New String() {","}, StringSplitOptions.RemoveEmptyEntries)

                        My.Settings.CameraAddress = New Integer(camera_offsets.Length) {}
                        For i As Integer = 0 To camera_offsets.Length
                            My.Settings.CameraAddress(i) = Convert.ToInt32(camera_offsets(i).Substring(2), 16)
                        Next


                    Case "zoomcurrentoffset"
                    Case "zoommaxoffset"
                    Case "fovcurrentoffset"
                    Case "fovmaxoffset"

                End Select
            Next

            If verbose Then
                MsgBox("Using memory addresses working as of: " & working_date, MsgBoxStyle.Information, "Updated Memory Addresses")
            End If

        Catch ex As WebException
            If verbose Then
                MsgBox("Timed out attempting to reach the update server:" &
                       vbCrLf & vbCrLf &
                       MEMORY_ADDRESSES_CONFIG_URL &
                       vbCrLf & vbCrLf &
                       "Make sure you have an internet connection and try again.", MsgBoxStyle.Critical, "Connection Timed Out")
            End If
        End Try
    End Sub
End Class
