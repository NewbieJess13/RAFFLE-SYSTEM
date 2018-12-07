<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewParticipantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteParticipantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfPrizesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPrizesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetWinnersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdLoadPrize = New System.Windows.Forms.Button()
        Me.btn_Start = New System.Windows.Forms.Button()
        Me.L_Name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L_Winner = New System.Windows.Forms.Label()
        Me.gridview2 = New System.Windows.Forms.DataGridView()
        Me.lbl_count = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.labelID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Claimed = New System.Windows.Forms.Button()
        Me.btncountdown = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Raffle_ID = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbSite = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.gridview2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1354, 48)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewParticipantsToolStripMenuItem, Me.DeleteParticipantToolStripMenuItem, Me.ListOfPrizesToolStripMenuItem, Me.AddPrizesToolStripMenuItem, Me.ResetWinnersToolStripMenuItem})
        Me.MenuToolStripMenuItem.Image = Global.RAFFLE_SYSTEM.My.Resources.Resources.list_512
        Me.MenuToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + M"
        Me.MenuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(81, 44)
        Me.MenuToolStripMenuItem.Text = "Menu"
        Me.MenuToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.MenuToolStripMenuItem.ToolTipText = "Click to show the menu"
        '
        'AddNewParticipantsToolStripMenuItem
        '
        Me.AddNewParticipantsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.AddNewParticipantsToolStripMenuItem.Image = Global.RAFFLE_SYSTEM.My.Resources.Resources.add
        Me.AddNewParticipantsToolStripMenuItem.Name = "AddNewParticipantsToolStripMenuItem"
        Me.AddNewParticipantsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddNewParticipantsToolStripMenuItem.Size = New System.Drawing.Size(294, 24)
        Me.AddNewParticipantsToolStripMenuItem.Text = "Add New Participant"
        Me.AddNewParticipantsToolStripMenuItem.ToolTipText = "New Participant"
        '
        'DeleteParticipantToolStripMenuItem
        '
        Me.DeleteParticipantToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.DeleteParticipantToolStripMenuItem.Image = Global.RAFFLE_SYSTEM.My.Resources.Resources.participant
        Me.DeleteParticipantToolStripMenuItem.Name = "DeleteParticipantToolStripMenuItem"
        Me.DeleteParticipantToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.DeleteParticipantToolStripMenuItem.Size = New System.Drawing.Size(294, 24)
        Me.DeleteParticipantToolStripMenuItem.Text = "List Of Participants"
        Me.DeleteParticipantToolStripMenuItem.ToolTipText = "List of Participants"
        '
        'ListOfPrizesToolStripMenuItem
        '
        Me.ListOfPrizesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ListOfPrizesToolStripMenuItem.Image = Global.RAFFLE_SYSTEM.My.Resources.Resources.trophy_512
        Me.ListOfPrizesToolStripMenuItem.Name = "ListOfPrizesToolStripMenuItem"
        Me.ListOfPrizesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ListOfPrizesToolStripMenuItem.Size = New System.Drawing.Size(294, 24)
        Me.ListOfPrizesToolStripMenuItem.Text = "List of Prizes"
        Me.ListOfPrizesToolStripMenuItem.ToolTipText = "List of Prizes"
        '
        'AddPrizesToolStripMenuItem
        '
        Me.AddPrizesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.AddPrizesToolStripMenuItem.Image = Global.RAFFLE_SYSTEM.My.Resources.Resources.plus
        Me.AddPrizesToolStripMenuItem.Name = "AddPrizesToolStripMenuItem"
        Me.AddPrizesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.AddPrizesToolStripMenuItem.Size = New System.Drawing.Size(294, 24)
        Me.AddPrizesToolStripMenuItem.Text = "Add Prizes"
        Me.AddPrizesToolStripMenuItem.ToolTipText = "Add Prizes"
        '
        'ResetWinnersToolStripMenuItem
        '
        Me.ResetWinnersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ResetWinnersToolStripMenuItem.Image = Global.RAFFLE_SYSTEM.My.Resources.Resources.reset
        Me.ResetWinnersToolStripMenuItem.Name = "ResetWinnersToolStripMenuItem"
        Me.ResetWinnersToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ResetWinnersToolStripMenuItem.Size = New System.Drawing.Size(294, 24)
        Me.ResetWinnersToolStripMenuItem.Text = "Reset Winners"
        Me.ResetWinnersToolStripMenuItem.ToolTipText = "Reset Winners"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(551, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 41)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Selected Prize"
        '
        'cmdLoadPrize
        '
        Me.cmdLoadPrize.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.cmdLoadPrize.FlatAppearance.BorderSize = 0
        Me.cmdLoadPrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdLoadPrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.cmdLoadPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLoadPrize.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoadPrize.Location = New System.Drawing.Point(193, 321)
        Me.cmdLoadPrize.Name = "cmdLoadPrize"
        Me.cmdLoadPrize.Size = New System.Drawing.Size(968, 81)
        Me.cmdLoadPrize.TabIndex = 15
        Me.cmdLoadPrize.Text = "Click me to select prize"
        Me.ToolTip1.SetToolTip(Me.cmdLoadPrize, "Click me to select Prize")
        Me.cmdLoadPrize.UseVisualStyleBackColor = False
        '
        'btn_Start
        '
        Me.btn_Start.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_Start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.btn_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Start.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Start.Location = New System.Drawing.Point(546, 247)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(263, 65)
        Me.btn_Start.TabIndex = 13
        Me.btn_Start.Text = "START RAFFLE DRAW"
        Me.ToolTip1.SetToolTip(Me.btn_Start, "Start Raffle")
        Me.btn_Start.UseVisualStyleBackColor = False
        '
        'L_Name
        '
        Me.L_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_Name.BackColor = System.Drawing.Color.Transparent
        Me.L_Name.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Name.ForeColor = System.Drawing.Color.Black
        Me.L_Name.Location = New System.Drawing.Point(5, 143)
        Me.L_Name.Name = "L_Name"
        Me.L_Name.Size = New System.Drawing.Size(1338, 90)
        Me.L_Name.TabIndex = 12
        Me.L_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1348, 101)
        Me.Label1.TabIndex = 11
        '
        'L_Winner
        '
        Me.L_Winner.AutoSize = True
        Me.L_Winner.Font = New System.Drawing.Font("Century Gothic", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Winner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.L_Winner.Location = New System.Drawing.Point(460, 44)
        Me.L_Winner.Name = "L_Winner"
        Me.L_Winner.Size = New System.Drawing.Size(435, 112)
        Me.L_Winner.TabIndex = 10
        Me.L_Winner.Text = "WINNER!"
        Me.L_Winner.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.L_Winner.Visible = False
        '
        'gridview2
        '
        Me.gridview2.AllowUserToAddRows = False
        Me.gridview2.AllowUserToDeleteRows = False
        Me.gridview2.AllowUserToResizeColumns = False
        Me.gridview2.AllowUserToResizeRows = False
        Me.gridview2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridview2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridview2.BackgroundColor = System.Drawing.Color.White
        Me.gridview2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(145, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GrayText
        Me.gridview2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridview2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridview2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column3, Me.Column4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(145, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridview2.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridview2.GridColor = System.Drawing.Color.White
        Me.gridview2.Location = New System.Drawing.Point(9, 27)
        Me.gridview2.Name = "gridview2"
        Me.gridview2.ReadOnly = True
        Me.gridview2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.gridview2.RowHeadersVisible = False
        Me.gridview2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridview2.Size = New System.Drawing.Size(1335, 200)
        Me.gridview2.TabIndex = 10
        '
        'lbl_count
        '
        Me.lbl_count.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lbl_count.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_count.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_count.Location = New System.Drawing.Point(0, 735)
        Me.lbl_count.Name = "lbl_count"
        Me.lbl_count.Size = New System.Drawing.Size(1354, 25)
        Me.lbl_count.TabIndex = 13
        Me.lbl_count.Text = "Items:  0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.gridview2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 497)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1351, 235)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Winners!"
        '
        'labelID
        '
        Me.labelID.BackColor = System.Drawing.Color.Transparent
        Me.labelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelID.ForeColor = System.Drawing.Color.Black
        Me.labelID.Location = New System.Drawing.Point(26, 9)
        Me.labelID.Name = "labelID"
        Me.labelID.Size = New System.Drawing.Size(128, 23)
        Me.labelID.TabIndex = 12
        Me.labelID.Text = "id label"
        Me.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.labelID.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_Claimed)
        Me.Panel1.Controls.Add(Me.btncountdown)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmdLoadPrize)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Raffle_ID)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btn_Start)
        Me.Panel1.Controls.Add(Me.L_Name)
        Me.Panel1.Controls.Add(Me.labelID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.L_Winner)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1354, 443)
        Me.Panel1.TabIndex = 12
        '
        'btn_Claimed
        '
        Me.btn_Claimed.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_Claimed.FlatAppearance.BorderSize = 0
        Me.btn_Claimed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.btn_Claimed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btn_Claimed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Claimed.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Claimed.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Claimed.Image = Global.RAFFLE_SYSTEM.My.Resources.Resources.money_1_
        Me.btn_Claimed.Location = New System.Drawing.Point(1189, 247)
        Me.btn_Claimed.Name = "btn_Claimed"
        Me.btn_Claimed.Size = New System.Drawing.Size(77, 71)
        Me.btn_Claimed.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.btn_Claimed, "Claim prize")
        Me.btn_Claimed.UseVisualStyleBackColor = False
        Me.btn_Claimed.Visible = False
        '
        'btncountdown
        '
        Me.btncountdown.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btncountdown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btncountdown.FlatAppearance.BorderSize = 2
        Me.btncountdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btncountdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btncountdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncountdown.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncountdown.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btncountdown.Image = Global.RAFFLE_SYSTEM.My.Resources.Resources.alarm_clock
        Me.btncountdown.Location = New System.Drawing.Point(1272, 247)
        Me.btncountdown.Name = "btncountdown"
        Me.btncountdown.Size = New System.Drawing.Size(77, 71)
        Me.btncountdown.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.btncountdown, "Start Countdown")
        Me.btncountdown.UseVisualStyleBackColor = False
        Me.btncountdown.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(978, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 24)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Quantity"
        Me.Label3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1122, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(228, 108)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'Raffle_ID
        '
        Me.Raffle_ID.AutoSize = True
        Me.Raffle_ID.Location = New System.Drawing.Point(310, 14)
        Me.Raffle_ID.Name = "Raffle_ID"
        Me.Raffle_ID.Size = New System.Drawing.Size(72, 24)
        Me.Raffle_ID.TabIndex = 17
        Me.Raffle_ID.Text = "Label3"
        Me.Raffle_ID.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'cmbSite
        '
        Me.cmbSite.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmbSite.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSite.FormattingEnabled = True
        Me.cmbSite.Items.AddRange(New Object() {"", "CERAMIC", "STAFF", "GAMOSA", "NCR", "SLOC"})
        Me.cmbSite.Location = New System.Drawing.Point(591, 12)
        Me.cmbSite.Name = "cmbSite"
        Me.cmbSite.Size = New System.Drawing.Size(172, 30)
        Me.cmbSite.TabIndex = 20
        Me.cmbSite.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "ID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column3.HeaderText = "Project"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 86
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Items"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1354, 760)
        Me.Controls.Add(Me.cmbSite)
        Me.Controls.Add(Me.lbl_count)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RAFFLE DRAW v1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.gridview2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewParticipantsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteParticipantToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_Start As Button
    Friend WithEvents L_Name As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents L_Winner As Label
    Friend WithEvents gridview2 As DataGridView
    Friend WithEvents lbl_count As Label
    Friend WithEvents cmdLoadPrize As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents AddPrizesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents labelID As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Raffle_ID As Label
    Friend WithEvents ListOfPrizesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetWinnersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmbSite As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btn_Claimed As Button
    Friend WithEvents btncountdown As Button
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
