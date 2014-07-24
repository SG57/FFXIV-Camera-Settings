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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.comboProcesses = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numZoomMin = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblFov = New System.Windows.Forms.Label()
        Me.sliderFov = New System.Windows.Forms.TrackBar()
        Me.numZoomMax = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numZoomMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.sliderFov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numZoomMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.comboProcesses)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 67)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Process"
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
        Me.comboProcesses.Location = New System.Drawing.Point(188, 23)
        Me.comboProcesses.Name = "comboProcesses"
        Me.comboProcesses.Size = New System.Drawing.Size(121, 37)
        Me.comboProcesses.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "FFXIV Process ID :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.numZoomMax)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.numZoomMin)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 80)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Zoom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(168, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Max : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'numZoomMin
        '
        Me.numZoomMin.DecimalPlaces = 1
        Me.numZoomMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numZoomMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.numZoomMin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numZoomMin.Location = New System.Drawing.Point(51, 37)
        Me.numZoomMin.Maximum = New Decimal(New Integer() {3500, 0, 0, 0})
        Me.numZoomMin.Minimum = New Decimal(New Integer() {10, 0, 0, 65536})
        Me.numZoomMin.Name = "numZoomMin"
        Me.numZoomMin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.numZoomMin.Size = New System.Drawing.Size(97, 26)
        Me.numZoomMin.TabIndex = 18
        Me.numZoomMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numZoomMin.ThousandsSeparator = True
        Me.numZoomMin.Value = New Decimal(New Integer() {10, 0, 0, 65536})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Min : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.lblFov)
        Me.GroupBox3.Controls.Add(Me.sliderFov)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 97)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(326, 93)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Field of View"
        '
        'lblFov
        '
        Me.lblFov.AutoSize = True
        Me.lblFov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFov.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFov.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFov.Location = New System.Drawing.Point(133, 56)
        Me.lblFov.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFov.Name = "lblFov"
        Me.lblFov.Size = New System.Drawing.Size(50, 31)
        Me.lblFov.TabIndex = 23
        Me.lblFov.Text = "1.0"
        Me.lblFov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sliderFov
        '
        Me.sliderFov.LargeChange = 50
        Me.sliderFov.Location = New System.Drawing.Point(9, 28)
        Me.sliderFov.Maximum = 300
        Me.sliderFov.Minimum = 10
        Me.sliderFov.Name = "sliderFov"
        Me.sliderFov.Size = New System.Drawing.Size(305, 45)
        Me.sliderFov.TabIndex = 20
        Me.sliderFov.TickFrequency = 50
        Me.sliderFov.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.sliderFov.Value = 78
        '
        'numZoomMax
        '
        Me.numZoomMax.DecimalPlaces = 1
        Me.numZoomMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numZoomMax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.numZoomMax.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numZoomMax.Location = New System.Drawing.Point(217, 37)
        Me.numZoomMax.Maximum = New Decimal(New Integer() {3500, 0, 0, 0})
        Me.numZoomMax.Minimum = New Decimal(New Integer() {10, 0, 0, 65536})
        Me.numZoomMax.Name = "numZoomMax"
        Me.numZoomMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.numZoomMax.Size = New System.Drawing.Size(97, 26)
        Me.numZoomMax.TabIndex = 22
        Me.numZoomMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numZoomMax.ThousandsSeparator = True
        Me.numZoomMax.Value = New Decimal(New Integer() {10, 0, 0, 65536})
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(353, 278)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FFXIV Camera Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numZoomMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.sliderFov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numZoomMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents comboProcesses As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numZoomMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFov As System.Windows.Forms.Label
    Friend WithEvents sliderFov As System.Windows.Forms.TrackBar
    Friend WithEvents numZoomMax As System.Windows.Forms.NumericUpDown

End Class
