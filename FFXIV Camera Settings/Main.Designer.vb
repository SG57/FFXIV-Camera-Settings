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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.sliderFov = New System.Windows.Forms.TrackBar()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.sliderZoomMax = New System.Windows.Forms.TrackBar()
        Me.checkSetZoom = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.groupFov = New System.Windows.Forms.GroupBox()
        Me.lblFov = New System.Windows.Forms.Label()
        Me.groupZoom = New System.Windows.Forms.GroupBox()
        Me.lblZoomMax = New System.Windows.Forms.Label()
        Me.comboProcesses = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnZoomMaxDefault = New System.Windows.Forms.Button()
        Me.btnFovDefault = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.sliderFov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sliderZoomMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.groupFov.SuspendLayout()
        Me.groupZoom.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.DonateToolStripMenuItem, Me.CheckForUpdateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(387, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'CheckForUpdateToolStripMenuItem
        '
        Me.CheckForUpdateToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckForUpdateToolStripMenuItem.Name = "CheckForUpdateToolStripMenuItem"
        Me.CheckForUpdateToolStripMenuItem.Size = New System.Drawing.Size(159, 20)
        Me.CheckForUpdateToolStripMenuItem.Text = "Update Memory Addresses"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 0
        Me.ToolTip1.InitialDelay = 1000
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Field of View"
        '
        'sliderFov
        '
        Me.sliderFov.LargeChange = 50
        Me.sliderFov.Location = New System.Drawing.Point(9, 28)
        Me.sliderFov.Maximum = 300
        Me.sliderFov.Minimum = 10
        Me.sliderFov.Name = "sliderFov"
        Me.sliderFov.Size = New System.Drawing.Size(321, 45)
        Me.sliderFov.TabIndex = 20
        Me.sliderFov.TickFrequency = 50
        Me.sliderFov.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.ToolTip1.SetToolTip(Me.sliderFov, "Set the current field of view (FOV). Higher means you can see more of your surrou" & _
        "ndings.")
        Me.sliderFov.Value = 78
        '
        'ToolTip2
        '
        Me.ToolTip2.AutoPopDelay = 0
        Me.ToolTip2.InitialDelay = 1000
        Me.ToolTip2.ReshowDelay = 100
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip2.ToolTipTitle = "Zoom Max"
        '
        'sliderZoomMax
        '
        Me.sliderZoomMax.LargeChange = 100
        Me.sliderZoomMax.Location = New System.Drawing.Point(9, 29)
        Me.sliderZoomMax.Maximum = 100000
        Me.sliderZoomMax.Minimum = 150
        Me.sliderZoomMax.Name = "sliderZoomMax"
        Me.sliderZoomMax.Size = New System.Drawing.Size(321, 45)
        Me.sliderZoomMax.TabIndex = 24
        Me.sliderZoomMax.TickFrequency = 100000
        Me.sliderZoomMax.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.ToolTip2.SetToolTip(Me.sliderZoomMax, "Set the max distance the camera can zoom out in yalms.")
        Me.sliderZoomMax.Value = 2000
        '
        'checkSetZoom
        '
        Me.checkSetZoom.Checked = True
        Me.checkSetZoom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkSetZoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.checkSetZoom.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkSetZoom.Location = New System.Drawing.Point(232, 61)
        Me.checkSetZoom.Name = "checkSetZoom"
        Me.checkSetZoom.Size = New System.Drawing.Size(98, 30)
        Me.checkSetZoom.TabIndex = 27
        Me.checkSetZoom.Text = "Set Zoom"
        Me.ToolTip2.SetToolTip(Me.checkSetZoom, "Set the current zoom amount as well as the max zoom.")
        Me.checkSetZoom.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.groupFov)
        Me.GroupBox1.Controls.Add(Me.groupZoom)
        Me.GroupBox1.Controls.Add(Me.comboProcesses)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 290)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Process"
        '
        'groupFov
        '
        Me.groupFov.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupFov.Controls.Add(Me.btnFovDefault)
        Me.groupFov.Controls.Add(Me.lblFov)
        Me.groupFov.Controls.Add(Me.sliderFov)
        Me.groupFov.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.groupFov.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupFov.Location = New System.Drawing.Point(13, 177)
        Me.groupFov.Name = "groupFov"
        Me.groupFov.Size = New System.Drawing.Size(337, 103)
        Me.groupFov.TabIndex = 24
        Me.groupFov.TabStop = False
        Me.groupFov.Text = "Field of View "
        Me.groupFov.Visible = False
        '
        'lblFov
        '
        Me.lblFov.AutoSize = True
        Me.lblFov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFov.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFov.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFov.Location = New System.Drawing.Point(133, 64)
        Me.lblFov.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFov.Name = "lblFov"
        Me.lblFov.Size = New System.Drawing.Size(50, 31)
        Me.lblFov.TabIndex = 23
        Me.lblFov.Text = "1.0"
        Me.lblFov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupZoom
        '
        Me.groupZoom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupZoom.Controls.Add(Me.btnZoomMaxDefault)
        Me.groupZoom.Controls.Add(Me.checkSetZoom)
        Me.groupZoom.Controls.Add(Me.lblZoomMax)
        Me.groupZoom.Controls.Add(Me.sliderZoomMax)
        Me.groupZoom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.groupZoom.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupZoom.Location = New System.Drawing.Point(13, 72)
        Me.groupZoom.Name = "groupZoom"
        Me.groupZoom.Size = New System.Drawing.Size(337, 99)
        Me.groupZoom.TabIndex = 23
        Me.groupZoom.TabStop = False
        Me.groupZoom.Text = "Zoom Max "
        Me.groupZoom.Visible = False
        '
        'lblZoomMax
        '
        Me.lblZoomMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblZoomMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZoomMax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblZoomMax.Location = New System.Drawing.Point(100, 61)
        Me.lblZoomMax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblZoomMax.Name = "lblZoomMax"
        Me.lblZoomMax.Size = New System.Drawing.Size(125, 31)
        Me.lblZoomMax.TabIndex = 26
        Me.lblZoomMax.Text = "2,000.00"
        Me.lblZoomMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'comboProcesses
        '
        Me.comboProcesses.DisplayMember = "0"
        Me.comboProcesses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboProcesses.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.comboProcesses.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboProcesses.ForeColor = System.Drawing.Color.Black
        Me.comboProcesses.FormattingEnabled = True
        Me.comboProcesses.Items.AddRange(New Object() {"0"})
        Me.comboProcesses.Location = New System.Drawing.Point(204, 25)
        Me.comboProcesses.Name = "comboProcesses"
        Me.comboProcesses.Size = New System.Drawing.Size(121, 37)
        Me.comboProcesses.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "FFXIV Process ID :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnZoomMaxDefault
        '
        Me.btnZoomMaxDefault.AutoSize = True
        Me.btnZoomMaxDefault.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnZoomMaxDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomMaxDefault.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.btnZoomMaxDefault.Location = New System.Drawing.Point(9, 61)
        Me.btnZoomMaxDefault.Name = "btnZoomMaxDefault"
        Me.btnZoomMaxDefault.Size = New System.Drawing.Size(71, 31)
        Me.btnZoomMaxDefault.TabIndex = 28
        Me.btnZoomMaxDefault.Text = "Default"
        Me.ToolTip2.SetToolTip(Me.btnZoomMaxDefault, "Default : 20")
        Me.btnZoomMaxDefault.UseVisualStyleBackColor = True
        '
        'btnFovDefault
        '
        Me.btnFovDefault.AutoSize = True
        Me.btnFovDefault.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFovDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFovDefault.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.btnFovDefault.Location = New System.Drawing.Point(9, 64)
        Me.btnFovDefault.Name = "btnFovDefault"
        Me.btnFovDefault.Size = New System.Drawing.Size(71, 31)
        Me.btnFovDefault.TabIndex = 29
        Me.btnFovDefault.Text = "Default"
        Me.ToolTip1.SetToolTip(Me.btnFovDefault, "Default : 0.78")
        Me.btnFovDefault.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(387, 327)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FFXIV Camera Settings"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.sliderFov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sliderZoomMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupFov.ResumeLayout(False)
        Me.groupFov.PerformLayout()
        Me.groupZoom.ResumeLayout(False)
        Me.groupZoom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents groupFov As System.Windows.Forms.GroupBox
    Friend WithEvents lblFov As System.Windows.Forms.Label
    Friend WithEvents sliderFov As System.Windows.Forms.TrackBar
    Friend WithEvents groupZoom As System.Windows.Forms.GroupBox
    Friend WithEvents lblZoomMax As System.Windows.Forms.Label
    Friend WithEvents sliderZoomMax As System.Windows.Forms.TrackBar
    Friend WithEvents comboProcesses As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents checkSetZoom As System.Windows.Forms.CheckBox
    Friend WithEvents CheckForUpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnFovDefault As System.Windows.Forms.Button
    Friend WithEvents btnZoomMaxDefault As System.Windows.Forms.Button

End Class
