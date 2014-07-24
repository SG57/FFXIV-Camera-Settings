Public Class Main

    Dim _memory As Memory = New Memory



    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshProcessComboBoxItems()
        refreshFovLabel()
        Me.numZoomMin.Value = My.Settings.ZoomMin
        Me.numZoomMax.Value = My.Settings.ZoomMax
    End Sub



    Private Sub refreshFovLabel()
        Me.lblFov.Text = (Me.sliderFov.Value / 100.0).ToString("N2")
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
        ElseIf Me.comboProcesses.Items.Count > 0 Then
            Me.comboProcesses.SelectedIndex = 0
        End If
    End Sub



    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles comboProcesses.DropDown
        refreshProcessComboBoxItems()
    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles sliderFov.ValueChanged
        '
        'My.Settings.FOV = Me.sliderFov.Value / 100.0
        'My.Settings.Save()
        refreshFovLabel()
    End Sub

    Private Sub numZoomMin_ValueChanged(sender As Object, e As EventArgs) Handles numZoomMin.ValueChanged
        'My.Settings.ZoomMin = Me.numZoomMin.Value
        'My.Settings.Save()
    End Sub

    Private Sub numZoomMax_ValueChanged(sender As Object, e As EventArgs) Handles numZoomMax.ValueChanged
        'My.Settings.ZoomMax = Me.numZoomMax.Value
        'My.Settings.Save()
    End Sub
End Class
