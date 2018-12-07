<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Participants
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_site = New System.Windows.Forms.TextBox()
        Me.L_name = New System.Windows.Forms.Label()
        Me.L_site = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.L_ID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.grid_list = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L_Items = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.grid_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Update
        '
        Me.btn_Update.Location = New System.Drawing.Point(48, 12)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(93, 31)
        Me.btn_Update.TabIndex = 1
        Me.btn_Update.Text = "UPDATE"
        Me.btn_Update.UseVisualStyleBackColor = True
        '
        'btn_Delete
        '
        Me.btn_Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Delete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.Location = New System.Drawing.Point(849, 468)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(102, 48)
        Me.btn_Delete.TabIndex = 2
        Me.btn_Delete.Text = "DELETE"
        Me.btn_Delete.UseVisualStyleBackColor = False
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(898, 105)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(187, 26)
        Me.txt_Search.TabIndex = 3
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(48, 53)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(192, 20)
        Me.txt_name.TabIndex = 5
        Me.txt_name.Visible = False
        '
        'txt_site
        '
        Me.txt_site.Location = New System.Drawing.Point(48, 78)
        Me.txt_site.Name = "txt_site"
        Me.txt_site.Size = New System.Drawing.Size(192, 20)
        Me.txt_site.TabIndex = 6
        Me.txt_site.Visible = False
        '
        'L_name
        '
        Me.L_name.AutoSize = True
        Me.L_name.Location = New System.Drawing.Point(7, 56)
        Me.L_name.Name = "L_name"
        Me.L_name.Size = New System.Drawing.Size(35, 13)
        Me.L_name.TabIndex = 7
        Me.L_name.Text = "Name"
        Me.L_name.Visible = False
        '
        'L_site
        '
        Me.L_site.AutoSize = True
        Me.L_site.Location = New System.Drawing.Point(17, 81)
        Me.L_site.Name = "L_site"
        Me.L_site.Size = New System.Drawing.Size(25, 13)
        Me.L_site.TabIndex = 8
        Me.L_site.Text = "Site"
        Me.L_site.Visible = False
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(48, 12)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(93, 31)
        Me.btn_save.TabIndex = 9
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = True
        Me.btn_save.Visible = False
        '
        'L_ID
        '
        Me.L_ID.AutoSize = True
        Me.L_ID.Location = New System.Drawing.Point(257, 9)
        Me.L_ID.Name = "L_ID"
        Me.L_ID.Size = New System.Drawing.Size(39, 13)
        Me.L_ID.TabIndex = 10
        Me.L_ID.Text = "Label3"
        Me.L_ID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(832, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Search"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoEllipsis = True
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Snow
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 111)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(113, 20)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "List Of Winners"
        '
        'grid_list
        '
        Me.grid_list.AllowUserToAddRows = False
        Me.grid_list.AllowUserToDeleteRows = False
        Me.grid_list.AllowUserToResizeColumns = False
        Me.grid_list.AllowUserToResizeRows = False
        Me.grid_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_list.BackgroundColor = System.Drawing.Color.White
        Me.grid_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_list.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grid_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.grid_list.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(145, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_list.DefaultCellStyle = DataGridViewCellStyle5
        Me.grid_list.GridColor = System.Drawing.Color.White
        Me.grid_list.Location = New System.Drawing.Point(4, 134)
        Me.grid_list.Name = "grid_list"
        Me.grid_list.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_list.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grid_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_list.Size = New System.Drawing.Size(1091, 321)
        Me.grid_list.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Full Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Project"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'L_Items
        '
        Me.L_Items.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.L_Items.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.L_Items.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Items.Location = New System.Drawing.Point(0, 524)
        Me.L_Items.Name = "L_Items"
        Me.L_Items.Size = New System.Drawing.Size(1097, 32)
        Me.L_Items.TabIndex = 17
        Me.L_Items.Text = "Items: "
        Me.L_Items.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1097, 55)
        Me.Panel1.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 23)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Participants List"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImage = Global.RAFFLE_SYSTEM.My.Resources.Resources.Icon_Red_X
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1056, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(957, 468)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 48)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "DELETE ALL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'F_Participants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1097, 556)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.L_Items)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.grid_list)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.L_ID)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.L_site)
        Me.Controls.Add(Me.L_name)
        Me.Controls.Add(Me.txt_site)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.btn_Update)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Participants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RAFFLE DRAW v1.0"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.grid_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_site As TextBox
    Friend WithEvents L_name As Label
    Friend WithEvents L_site As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents L_ID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents grid_list As DataGridView
    Friend WithEvents L_Items As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
