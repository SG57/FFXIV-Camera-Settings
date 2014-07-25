Public Class Main

    Dim _memory As Memory = New Memory
    Dim _shouldSaveSettings As Boolean = False





    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("A simple program that will adjust the camera settings for FFXIV, such as zoom and field of view." & vbCrLf & vbCrLf & vbCrLf & "(C) 2014" & vbCrLf & "Cord Rehn <jordansg57@gmail.com>", MsgBoxStyle.Information, "About FFXIV Camera Settings")
    End Sub

    Private Sub DonateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonateToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=JordanSg57%40gmail%2ecom&lc=US&item_name=Freelance%20Developer&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted")
    End Sub





    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.sliderZoomMax.Value = My.Settings.ZoomMax * 100
        Me.sliderFov.Value = My.Settings.FOV * 100

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

        Me.comboProcesses.Items.Add(554444)

        If Not IsNothing(old_selected_item) Then
            If Me.comboProcesses.Items.Contains(old_selected_item) Then
                Me.comboProcesses.SelectedItem = old_selected_item
            End If
        Else
            Me.comboProcesses.SelectedItem = Nothing
        End If
    End Sub







    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles comboProcesses.DropDown
        refreshProcessComboBoxItems()
    End Sub

    Private Sub comboProcesses_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles comboProcesses.SelectionChangeCommitted
        If Not _memory.AttachToProcess(Me.comboProcesses.SelectedItem) Then
            MsgBox("Failed to attach to FFXIV process ID: " & Me.comboProcesses.SelectedItem, MsgBoxStyle.Critical, "Process Error")
            Me.comboProcesses.SelectedItem = Nothing
        Else
            _memory.writeZoomMax(Me.sliderZoomMax.Value / 100.0)
            _memory.writeFov(Me.sliderFov.Value / 100.0)
        End If
    End Sub






    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles sliderFov.ValueChanged
        If _shouldSaveSettings Then
            My.Settings.FOV = Me.sliderFov.Value / 100.0
            My.Settings.Save()
        End If

        refreshFovLabel()
        _memory.writeFov(Me.sliderFov.Value / 100.0)
    End Sub

    Private Sub TrackBar2_ValueChanged(sender As Object, e As EventArgs) Handles sliderZoomMax.ValueChanged
        If _shouldSaveSettings Then
            My.Settings.ZoomMax = Me.sliderZoomMax.Value / 100.0
            My.Settings.Save()
        End If

        refreshZoomMaxLabel()
        _memory.writeZoomMax(Me.sliderZoomMax.Value / 100.0)
    End Sub
End Class
