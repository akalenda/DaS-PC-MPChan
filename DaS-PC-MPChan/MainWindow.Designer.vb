﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Dim lblNodes As System.Windows.Forms.Label
        Dim lblNodeDiv As System.Windows.Forms.Label
        Dim lblYourId As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.chkDebugDrawing = New System.Windows.Forms.CheckBox()
        Me.lblVer = New System.Windows.Forms.Label()
        Me.chkExpand = New System.Windows.Forms.CheckBox()
        Me.txtCurrNodes = New System.Windows.Forms.TextBox()
        Me.nmbMaxNodes = New System.Windows.Forms.NumericUpDown()
        Me.txtTargetSteamID = New System.Windows.Forms.TextBox()
        Me.txtSelfSteamID = New System.Windows.Forms.TextBox()
        Me.btnAttemptId = New System.Windows.Forms.Button()
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.tabActive = New System.Windows.Forms.TabPage()
        Me.dgvMPNodes = New DSCM.ExtendedDataGridView()
        Me.tabFavorites = New System.Windows.Forms.TabPage()
        Me.dgvFavoriteNodes = New System.Windows.Forms.DataGridView()
        Me.tabRecent = New System.Windows.Forms.TabPage()
        Me.dgvRecentNodes = New System.Windows.Forms.DataGridView()
        Me.tabDSCMNet = New System.Windows.Forms.TabPage()
        Me.txtIRCDebug = New System.Windows.Forms.TextBox()
        Me.dgvDSCMNet = New DSCM.ExtendedDataGridView()
        Me.tabHelp = New System.Windows.Forms.TabPage()
        Me.helpView = New System.Windows.Forms.WebBrowser()
        Me.tabLocal = New System.Windows.Forms.TabPage()
        Me.txtTimePlayed = New System.Windows.Forms.TextBox()
        Me.txtClearCount = New System.Windows.Forms.TextBox()
        Me.txtDeaths = New System.Windows.Forms.TextBox()
        Me.txtZPos = New System.Windows.Forms.TextBox()
        Me.txtYPos = New System.Windows.Forms.TextBox()
        Me.txtXPos = New System.Windows.Forms.TextBox()
        Me.txtTeamType = New System.Windows.Forms.TextBox()
        Me.txtPhantomType = New System.Windows.Forms.TextBox()
        Me.txtSin = New System.Windows.Forms.TextBox()
        Me.txtWatchdogActive = New System.Windows.Forms.TextBox()
        Me.txtLocalSteamName = New System.Windows.Forms.TextBox()
        Me.btnAddFavorite = New System.Windows.Forms.Button()
        Me.btnRemFavorite = New System.Windows.Forms.Button()
        Me.lblNewVersion = New System.Windows.Forms.Label()
        Me.chkDSCMNet = New System.Windows.Forms.CheckBox()
        Me.dsProcessStatus = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        lblNodes = New System.Windows.Forms.Label()
        lblNodeDiv = New System.Windows.Forms.Label()
        lblYourId = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.nmbMaxNodes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabs.SuspendLayout
        Me.tabActive.SuspendLayout
        CType(Me.dgvMPNodes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabFavorites.SuspendLayout
        CType(Me.dgvFavoriteNodes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabRecent.SuspendLayout
        CType(Me.dgvRecentNodes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabDSCMNet.SuspendLayout
        CType(Me.dgvDSCMNet,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabHelp.SuspendLayout
        Me.tabLocal.SuspendLayout
        Me.SuspendLayout
        '
        'lblNodes
        '
        lblNodes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        lblNodes.AutoSize = true
        lblNodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        lblNodes.Location = New System.Drawing.Point(633, 6)
        lblNodes.Name = "lblNodes"
        lblNodes.Size = New System.Drawing.Size(49, 16)
        lblNodes.TabIndex = 55
        lblNodes.Text = "Nodes"
        '
        'lblNodeDiv
        '
        lblNodeDiv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        lblNodeDiv.AutoSize = true
        lblNodeDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        lblNodeDiv.Location = New System.Drawing.Point(726, 6)
        lblNodeDiv.Name = "lblNodeDiv"
        lblNodeDiv.Size = New System.Drawing.Size(12, 16)
        lblNodeDiv.TabIndex = 56
        lblNodeDiv.Text = "/"
        '
        'lblYourId
        '
        lblYourId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        lblYourId.AutoSize = true
        lblYourId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        lblYourId.Location = New System.Drawing.Point(531, 34)
        lblYourId.Name = "lblYourId"
        lblYourId.Size = New System.Drawing.Size(111, 16)
        lblYourId.TabIndex = 61
        lblYourId.Text = "Your Steam64 ID:"
        '
        'Label1
        '
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Label1.AutoSize = true
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label1.Location = New System.Drawing.Point(10, 19)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(118, 16)
        Label1.TabIndex = 63
        Label1.Text = "Your Steam Name"
        '
        'Label2
        '
        Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Label2.AutoSize = true
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label2.Location = New System.Drawing.Point(10, 43)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(140, 16)
        Label2.TabIndex = 65
        Label2.Text = "PVP Watchdog Active"
        '
        'Label3
        '
        Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Label3.AutoSize = true
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label3.Location = New System.Drawing.Point(10, 67)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(27, 16)
        Label3.TabIndex = 67
        Label3.Text = "Sin"
        '
        'Label4
        '
        Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Label4.AutoSize = true
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label4.Location = New System.Drawing.Point(10, 91)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(96, 16)
        Label4.TabIndex = 69
        Label4.Text = "Phantom Type"
        '
        'Label5
        '
        Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Label5.AutoSize = true
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label5.Location = New System.Drawing.Point(10, 115)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(79, 16)
        Label5.TabIndex = 71
        Label5.Text = "Team Type"
        '
        'Label6
        '
        Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Label6.AutoSize = true
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label6.Location = New System.Drawing.Point(9, 223)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(43, 16)
        Label6.TabIndex = 73
        Label6.Text = "X Pos"
        '
        'Label7
        '
        Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Label7.AutoSize = true
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label7.Location = New System.Drawing.Point(9, 247)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(44, 16)
        Label7.TabIndex = 75
        Label7.Text = "Y Pos"
        '
        'Label8
        '
        Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Label8.AutoSize = true
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label8.Location = New System.Drawing.Point(9, 271)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(43, 16)
        Label8.TabIndex = 77
        Label8.Text = "Z Pos"
        '
        'Label9
        '
        Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Label9.AutoSize = true
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label9.Location = New System.Drawing.Point(317, 43)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(51, 16)
        Label9.TabIndex = 79
        Label9.Text = "Deaths"
        '
        'Label10
        '
        Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Label10.AutoSize = true
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label10.Location = New System.Drawing.Point(317, 67)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(35, 16)
        Label10.TabIndex = 81
        Label10.Text = "NG+"
        '
        'Label11
        '
        Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Label11.AutoSize = true
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Label11.Location = New System.Drawing.Point(317, 91)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(85, 16)
        Label11.TabIndex = 83
        Label11.Text = "Time Played"
        '
        'chkDebugDrawing
        '
        Me.chkDebugDrawing.AutoSize = true
        Me.chkDebugDrawing.BackColor = System.Drawing.SystemColors.Control
        Me.chkDebugDrawing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkDebugDrawing.Location = New System.Drawing.Point(12, 4)
        Me.chkDebugDrawing.Name = "chkDebugDrawing"
        Me.chkDebugDrawing.Size = New System.Drawing.Size(113, 20)
        Me.chkDebugDrawing.TabIndex = 46
        Me.chkDebugDrawing.Text = "Node Drawing"
        Me.chkDebugDrawing.UseVisualStyleBackColor = false
        '
        'lblVer
        '
        Me.lblVer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblVer.AutoSize = true
        Me.lblVer.BackColor = System.Drawing.SystemColors.Control
        Me.lblVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblVer.Location = New System.Drawing.Point(700, 463)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(76, 13)
        Me.lblVer.TabIndex = 49
        Me.lblVer.Text = "2016.06.18.02"
        '
        'chkExpand
        '
        Me.chkExpand.AutoSize = true
        Me.chkExpand.BackColor = System.Drawing.SystemColors.Control
        Me.chkExpand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkExpand.Location = New System.Drawing.Point(12, 27)
        Me.chkExpand.Name = "chkExpand"
        Me.chkExpand.Size = New System.Drawing.Size(115, 20)
        Me.chkExpand.TabIndex = 52
        Me.chkExpand.Text = "Expand DSCM"
        Me.chkExpand.UseVisualStyleBackColor = false
        '
        'txtCurrNodes
        '
        Me.txtCurrNodes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtCurrNodes.Location = New System.Drawing.Point(688, 5)
        Me.txtCurrNodes.Name = "txtCurrNodes"
        Me.txtCurrNodes.ReadOnly = true
        Me.txtCurrNodes.Size = New System.Drawing.Size(38, 20)
        Me.txtCurrNodes.TabIndex = 54
        '
        'nmbMaxNodes
        '
        Me.nmbMaxNodes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.nmbMaxNodes.Enabled = false
        Me.nmbMaxNodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.nmbMaxNodes.Location = New System.Drawing.Point(737, 3)
        Me.nmbMaxNodes.Maximum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.nmbMaxNodes.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nmbMaxNodes.Name = "nmbMaxNodes"
        Me.nmbMaxNodes.Size = New System.Drawing.Size(40, 22)
        Me.nmbMaxNodes.TabIndex = 57
        Me.nmbMaxNodes.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'txtTargetSteamID
        '
        Me.txtTargetSteamID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtTargetSteamID.Location = New System.Drawing.Point(534, 64)
        Me.txtTargetSteamID.Name = "txtTargetSteamID"
        Me.txtTargetSteamID.Size = New System.Drawing.Size(243, 20)
        Me.txtTargetSteamID.TabIndex = 59
        Me.txtTargetSteamID.Text = "Target (Steam64 ID or Profile URL)"
        '
        'txtSelfSteamID
        '
        Me.txtSelfSteamID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtSelfSteamID.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtSelfSteamID.Location = New System.Drawing.Point(645, 32)
        Me.txtSelfSteamID.Name = "txtSelfSteamID"
        Me.txtSelfSteamID.ReadOnly = true
        Me.txtSelfSteamID.Size = New System.Drawing.Size(132, 23)
        Me.txtSelfSteamID.TabIndex = 62
        '
        'btnAttemptId
        '
        Me.btnAttemptId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnAttemptId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAttemptId.Location = New System.Drawing.Point(534, 85)
        Me.btnAttemptId.Name = "btnAttemptId"
        Me.btnAttemptId.Size = New System.Drawing.Size(243, 23)
        Me.btnAttemptId.TabIndex = 65
        Me.btnAttemptId.Text = "Attempt Connection to Player"
        Me.btnAttemptId.UseVisualStyleBackColor = true
        '
        'tabs
        '
        Me.tabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tabs.Controls.Add(Me.tabActive)
        Me.tabs.Controls.Add(Me.tabFavorites)
        Me.tabs.Controls.Add(Me.tabRecent)
        Me.tabs.Controls.Add(Me.tabDSCMNet)
        Me.tabs.Controls.Add(Me.tabHelp)
        Me.tabs.Controls.Add(Me.tabLocal)
        Me.tabs.Location = New System.Drawing.Point(10, 115)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(765, 328)
        Me.tabs.TabIndex = 67
        Me.tabs.Visible = false
        '
        'tabActive
        '
        Me.tabActive.BackColor = System.Drawing.SystemColors.Control
        Me.tabActive.Controls.Add(Me.dgvMPNodes)
        Me.tabActive.Location = New System.Drawing.Point(4, 22)
        Me.tabActive.Name = "tabActive"
        Me.tabActive.Padding = New System.Windows.Forms.Padding(3)
        Me.tabActive.Size = New System.Drawing.Size(757, 302)
        Me.tabActive.TabIndex = 0
        Me.tabActive.Text = "Active"
        '
        'dgvMPNodes
        '
        Me.dgvMPNodes.AllowUserToAddRows = false
        Me.dgvMPNodes.AllowUserToDeleteRows = false
        Me.dgvMPNodes.AllowUserToResizeRows = false
        Me.dgvMPNodes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMPNodes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMPNodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMPNodes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMPNodes.Location = New System.Drawing.Point(6, 6)
        Me.dgvMPNodes.Name = "dgvMPNodes"
        Me.dgvMPNodes.ReadOnly = true
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMPNodes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMPNodes.RowHeadersVisible = false
        Me.dgvMPNodes.Size = New System.Drawing.Size(740, 288)
        Me.dgvMPNodes.TabIndex = 53
        '
        'tabFavorites
        '
        Me.tabFavorites.BackColor = System.Drawing.SystemColors.Control
        Me.tabFavorites.Controls.Add(Me.dgvFavoriteNodes)
        Me.tabFavorites.Location = New System.Drawing.Point(4, 22)
        Me.tabFavorites.Name = "tabFavorites"
        Me.tabFavorites.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFavorites.Size = New System.Drawing.Size(757, 302)
        Me.tabFavorites.TabIndex = 1
        Me.tabFavorites.Text = "Favorites"
        '
        'dgvFavoriteNodes
        '
        Me.dgvFavoriteNodes.AllowUserToAddRows = false
        Me.dgvFavoriteNodes.AllowUserToDeleteRows = false
        Me.dgvFavoriteNodes.AllowUserToResizeRows = false
        Me.dgvFavoriteNodes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFavoriteNodes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvFavoriteNodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFavoriteNodes.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvFavoriteNodes.Location = New System.Drawing.Point(6, 6)
        Me.dgvFavoriteNodes.Name = "dgvFavoriteNodes"
        Me.dgvFavoriteNodes.ReadOnly = true
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFavoriteNodes.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvFavoriteNodes.RowHeadersVisible = false
        Me.dgvFavoriteNodes.Size = New System.Drawing.Size(370, 290)
        Me.dgvFavoriteNodes.TabIndex = 54
        '
        'tabRecent
        '
        Me.tabRecent.BackColor = System.Drawing.SystemColors.Control
        Me.tabRecent.Controls.Add(Me.dgvRecentNodes)
        Me.tabRecent.Location = New System.Drawing.Point(4, 22)
        Me.tabRecent.Name = "tabRecent"
        Me.tabRecent.Size = New System.Drawing.Size(757, 302)
        Me.tabRecent.TabIndex = 2
        Me.tabRecent.Text = "Recent"
        '
        'dgvRecentNodes
        '
        Me.dgvRecentNodes.AllowUserToAddRows = false
        Me.dgvRecentNodes.AllowUserToDeleteRows = false
        Me.dgvRecentNodes.AllowUserToResizeRows = false
        Me.dgvRecentNodes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecentNodes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvRecentNodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRecentNodes.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvRecentNodes.Location = New System.Drawing.Point(6, 6)
        Me.dgvRecentNodes.Name = "dgvRecentNodes"
        Me.dgvRecentNodes.ReadOnly = true
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecentNodes.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvRecentNodes.RowHeadersVisible = false
        Me.dgvRecentNodes.Size = New System.Drawing.Size(370, 293)
        Me.dgvRecentNodes.TabIndex = 55
        '
        'tabDSCMNet
        '
        Me.tabDSCMNet.BackColor = System.Drawing.SystemColors.Control
        Me.tabDSCMNet.Controls.Add(Me.txtIRCDebug)
        Me.tabDSCMNet.Controls.Add(Me.dgvDSCMNet)
        Me.tabDSCMNet.Location = New System.Drawing.Point(4, 22)
        Me.tabDSCMNet.Name = "tabDSCMNet"
        Me.tabDSCMNet.Size = New System.Drawing.Size(757, 302)
        Me.tabDSCMNet.TabIndex = 3
        Me.tabDSCMNet.Text = "DSCM-Net"
        '
        'txtIRCDebug
        '
        Me.txtIRCDebug.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtIRCDebug.Location = New System.Drawing.Point(6, 279)
        Me.txtIRCDebug.Name = "txtIRCDebug"
        Me.txtIRCDebug.Size = New System.Drawing.Size(740, 20)
        Me.txtIRCDebug.TabIndex = 55
        '
        'dgvDSCMNet
        '
        Me.dgvDSCMNet.AllowUserToAddRows = false
        Me.dgvDSCMNet.AllowUserToDeleteRows = false
        Me.dgvDSCMNet.AllowUserToResizeRows = false
        Me.dgvDSCMNet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDSCMNet.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvDSCMNet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDSCMNet.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvDSCMNet.Location = New System.Drawing.Point(6, 6)
        Me.dgvDSCMNet.Name = "dgvDSCMNet"
        Me.dgvDSCMNet.ReadOnly = true
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDSCMNet.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvDSCMNet.RowHeadersVisible = false
        Me.dgvDSCMNet.Size = New System.Drawing.Size(740, 267)
        Me.dgvDSCMNet.TabIndex = 54
        '
        'tabHelp
        '
        Me.tabHelp.Controls.Add(Me.helpView)
        Me.tabHelp.Location = New System.Drawing.Point(4, 22)
        Me.tabHelp.Name = "tabHelp"
        Me.tabHelp.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHelp.Size = New System.Drawing.Size(757, 302)
        Me.tabHelp.TabIndex = 4
        Me.tabHelp.Text = "Help"
        Me.tabHelp.UseVisualStyleBackColor = true
        '
        'helpView
        '
        Me.helpView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.helpView.Location = New System.Drawing.Point(3, 3)
        Me.helpView.MinimumSize = New System.Drawing.Size(20, 20)
        Me.helpView.Name = "helpView"
        Me.helpView.Size = New System.Drawing.Size(751, 293)
        Me.helpView.TabIndex = 0
        '
        'tabLocal
        '
        Me.tabLocal.Controls.Add(Me.txtTimePlayed)
        Me.tabLocal.Controls.Add(Label11)
        Me.tabLocal.Controls.Add(Me.txtClearCount)
        Me.tabLocal.Controls.Add(Label10)
        Me.tabLocal.Controls.Add(Me.txtDeaths)
        Me.tabLocal.Controls.Add(Label9)
        Me.tabLocal.Controls.Add(Me.txtZPos)
        Me.tabLocal.Controls.Add(Label8)
        Me.tabLocal.Controls.Add(Me.txtYPos)
        Me.tabLocal.Controls.Add(Label7)
        Me.tabLocal.Controls.Add(Me.txtXPos)
        Me.tabLocal.Controls.Add(Label6)
        Me.tabLocal.Controls.Add(Me.txtTeamType)
        Me.tabLocal.Controls.Add(Label5)
        Me.tabLocal.Controls.Add(Me.txtPhantomType)
        Me.tabLocal.Controls.Add(Label4)
        Me.tabLocal.Controls.Add(Me.txtSin)
        Me.tabLocal.Controls.Add(Label3)
        Me.tabLocal.Controls.Add(Me.txtWatchdogActive)
        Me.tabLocal.Controls.Add(Label2)
        Me.tabLocal.Controls.Add(Me.txtLocalSteamName)
        Me.tabLocal.Controls.Add(Label1)
        Me.tabLocal.Location = New System.Drawing.Point(4, 22)
        Me.tabLocal.Name = "tabLocal"
        Me.tabLocal.Size = New System.Drawing.Size(757, 302)
        Me.tabLocal.TabIndex = 5
        Me.tabLocal.Text = "Local Info"
        Me.tabLocal.UseVisualStyleBackColor = true
        '
        'txtTimePlayed
        '
        Me.txtTimePlayed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtTimePlayed.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTimePlayed.Location = New System.Drawing.Point(408, 89)
        Me.txtTimePlayed.Name = "txtTimePlayed"
        Me.txtTimePlayed.ReadOnly = true
        Me.txtTimePlayed.Size = New System.Drawing.Size(106, 23)
        Me.txtTimePlayed.TabIndex = 84
        '
        'txtClearCount
        '
        Me.txtClearCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtClearCount.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtClearCount.Location = New System.Drawing.Point(408, 65)
        Me.txtClearCount.Name = "txtClearCount"
        Me.txtClearCount.ReadOnly = true
        Me.txtClearCount.Size = New System.Drawing.Size(51, 23)
        Me.txtClearCount.TabIndex = 82
        '
        'txtDeaths
        '
        Me.txtDeaths.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtDeaths.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtDeaths.Location = New System.Drawing.Point(408, 41)
        Me.txtDeaths.Name = "txtDeaths"
        Me.txtDeaths.ReadOnly = true
        Me.txtDeaths.Size = New System.Drawing.Size(51, 23)
        Me.txtDeaths.TabIndex = 80
        '
        'txtZPos
        '
        Me.txtZPos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtZPos.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtZPos.Location = New System.Drawing.Point(58, 269)
        Me.txtZPos.Name = "txtZPos"
        Me.txtZPos.ReadOnly = true
        Me.txtZPos.Size = New System.Drawing.Size(70, 23)
        Me.txtZPos.TabIndex = 78
        '
        'txtYPos
        '
        Me.txtYPos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtYPos.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtYPos.Location = New System.Drawing.Point(58, 245)
        Me.txtYPos.Name = "txtYPos"
        Me.txtYPos.ReadOnly = true
        Me.txtYPos.Size = New System.Drawing.Size(70, 23)
        Me.txtYPos.TabIndex = 76
        '
        'txtXPos
        '
        Me.txtXPos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtXPos.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtXPos.Location = New System.Drawing.Point(58, 221)
        Me.txtXPos.Name = "txtXPos"
        Me.txtXPos.ReadOnly = true
        Me.txtXPos.Size = New System.Drawing.Size(70, 23)
        Me.txtXPos.TabIndex = 74
        '
        'txtTeamType
        '
        Me.txtTeamType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtTeamType.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTeamType.Location = New System.Drawing.Point(159, 113)
        Me.txtTeamType.Name = "txtTeamType"
        Me.txtTeamType.ReadOnly = true
        Me.txtTeamType.Size = New System.Drawing.Size(51, 23)
        Me.txtTeamType.TabIndex = 72
        '
        'txtPhantomType
        '
        Me.txtPhantomType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtPhantomType.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtPhantomType.Location = New System.Drawing.Point(159, 89)
        Me.txtPhantomType.Name = "txtPhantomType"
        Me.txtPhantomType.ReadOnly = true
        Me.txtPhantomType.Size = New System.Drawing.Size(51, 23)
        Me.txtPhantomType.TabIndex = 70
        '
        'txtSin
        '
        Me.txtSin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtSin.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtSin.Location = New System.Drawing.Point(159, 65)
        Me.txtSin.Name = "txtSin"
        Me.txtSin.ReadOnly = true
        Me.txtSin.Size = New System.Drawing.Size(51, 23)
        Me.txtSin.TabIndex = 68
        '
        'txtWatchdogActive
        '
        Me.txtWatchdogActive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtWatchdogActive.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtWatchdogActive.Location = New System.Drawing.Point(159, 41)
        Me.txtWatchdogActive.Name = "txtWatchdogActive"
        Me.txtWatchdogActive.ReadOnly = true
        Me.txtWatchdogActive.Size = New System.Drawing.Size(51, 23)
        Me.txtWatchdogActive.TabIndex = 66
        '
        'txtLocalSteamName
        '
        Me.txtLocalSteamName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtLocalSteamName.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtLocalSteamName.Location = New System.Drawing.Point(137, 17)
        Me.txtLocalSteamName.Name = "txtLocalSteamName"
        Me.txtLocalSteamName.ReadOnly = true
        Me.txtLocalSteamName.Size = New System.Drawing.Size(179, 23)
        Me.txtLocalSteamName.TabIndex = 64
        '
        'btnAddFavorite
        '
        Me.btnAddFavorite.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAddFavorite.Location = New System.Drawing.Point(269, 453)
        Me.btnAddFavorite.Name = "btnAddFavorite"
        Me.btnAddFavorite.Size = New System.Drawing.Size(113, 23)
        Me.btnAddFavorite.TabIndex = 68
        Me.btnAddFavorite.Text = "Add Favorite"
        Me.btnAddFavorite.UseVisualStyleBackColor = true
        Me.btnAddFavorite.Visible = false
        '
        'btnRemFavorite
        '
        Me.btnRemFavorite.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRemFavorite.Location = New System.Drawing.Point(388, 453)
        Me.btnRemFavorite.Name = "btnRemFavorite"
        Me.btnRemFavorite.Size = New System.Drawing.Size(113, 23)
        Me.btnRemFavorite.TabIndex = 70
        Me.btnRemFavorite.Text = "Remove Favorite"
        Me.btnRemFavorite.UseVisualStyleBackColor = true
        Me.btnRemFavorite.Visible = false
        '
        'lblNewVersion
        '
        Me.lblNewVersion.AutoSize = true
        Me.lblNewVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblNewVersion.ForeColor = System.Drawing.Color.Red
        Me.lblNewVersion.Location = New System.Drawing.Point(9, 72)
        Me.lblNewVersion.Name = "lblNewVersion"
        Me.lblNewVersion.Size = New System.Drawing.Size(183, 16)
        Me.lblNewVersion.TabIndex = 71
        Me.lblNewVersion.Text = "New testing version available"
        Me.lblNewVersion.Visible = false
        '
        'chkDSCMNet
        '
        Me.chkDSCMNet.AutoSize = true
        Me.chkDSCMNet.BackColor = System.Drawing.SystemColors.Control
        Me.chkDSCMNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkDSCMNet.Location = New System.Drawing.Point(12, 50)
        Me.chkDSCMNet.Name = "chkDSCMNet"
        Me.chkDSCMNet.Size = New System.Drawing.Size(119, 20)
        Me.chkDSCMNet.TabIndex = 73
        Me.chkDSCMNet.Text = "Join DSCM-Net"
        Me.chkDSCMNet.UseVisualStyleBackColor = false
        '
        'dsProcessStatus
        '
        Me.dsProcessStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.dsProcessStatus.Location = New System.Drawing.Point(10, 455)
        Me.dsProcessStatus.Name = "dsProcessStatus"
        Me.dsProcessStatus.ReadOnly = true
        Me.dsProcessStatus.Size = New System.Drawing.Size(187, 20)
        Me.dsProcessStatus.TabIndex = 74
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(10, 88)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(182, 23)
        Me.btnUpdate.TabIndex = 75
        Me.btnUpdate.Text = "Update DSCM"
        Me.btnUpdate.UseVisualStyleBackColor = true
        Me.btnUpdate.Visible = false
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 480)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dsProcessStatus)
        Me.Controls.Add(Me.chkDSCMNet)
        Me.Controls.Add(Me.lblNewVersion)
        Me.Controls.Add(Me.btnRemFavorite)
        Me.Controls.Add(Me.btnAddFavorite)
        Me.Controls.Add(Me.tabs)
        Me.Controls.Add(Me.btnAttemptId)
        Me.Controls.Add(Me.txtSelfSteamID)
        Me.Controls.Add(lblYourId)
        Me.Controls.Add(Me.txtTargetSteamID)
        Me.Controls.Add(Me.nmbMaxNodes)
        Me.Controls.Add(lblNodeDiv)
        Me.Controls.Add(lblNodes)
        Me.Controls.Add(Me.txtCurrNodes)
        Me.Controls.Add(Me.chkExpand)
        Me.Controls.Add(Me.lblVer)
        Me.Controls.Add(Me.chkDebugDrawing)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "MainWindow"
        Me.Text = "Wulf's Dark Souls Connectivity Mod"
        CType(Me.nmbMaxNodes,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabs.ResumeLayout(false)
        Me.tabActive.ResumeLayout(false)
        CType(Me.dgvMPNodes,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabFavorites.ResumeLayout(false)
        CType(Me.dgvFavoriteNodes,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabRecent.ResumeLayout(false)
        CType(Me.dgvRecentNodes,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabDSCMNet.ResumeLayout(false)
        Me.tabDSCMNet.PerformLayout
        CType(Me.dgvDSCMNet,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabHelp.ResumeLayout(false)
        Me.tabLocal.ResumeLayout(false)
        Me.tabLocal.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents chkDebugDrawing As System.Windows.Forms.CheckBox
    Friend WithEvents lblVer As Label
    Friend WithEvents chkExpand As CheckBox
    Friend WithEvents txtCurrNodes As TextBox
    Friend WithEvents nmbMaxNodes As NumericUpDown
    Friend WithEvents txtTargetSteamID As TextBox
    Friend WithEvents txtSelfSteamID As TextBox
    Friend WithEvents btnAttemptId As System.Windows.Forms.Button
    Friend WithEvents tabs As TabControl
    Friend WithEvents tabActive As TabPage
    Friend WithEvents tabFavorites As TabPage
    Friend WithEvents tabRecent As TabPage
    Friend WithEvents btnAddFavorite As Button
    Friend WithEvents btnRemFavorite As Button
    Friend WithEvents dgvFavoriteNodes As DataGridView
    Friend WithEvents dgvRecentNodes As DataGridView
    Friend WithEvents lblNewVersion As Label
    Friend WithEvents tabDSCMNet As TabPage
    Friend WithEvents chkDSCMNet As CheckBox
    Friend WithEvents txtIRCDebug As System.Windows.Forms.TextBox
    Friend WithEvents dsProcessStatus As System.Windows.Forms.TextBox
    Friend WithEvents tabHelp As System.Windows.Forms.TabPage
    Friend WithEvents helpView As System.Windows.Forms.WebBrowser
    Friend WithEvents dgvMPNodes As Global.DSCM.ExtendedDataGridView
    Friend WithEvents dgvDSCMNet As Global.DSCM.ExtendedDataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents tabLocal As System.Windows.Forms.TabPage
    Friend WithEvents txtLocalSteamName As System.Windows.Forms.TextBox
    Friend WithEvents txtWatchdogActive As System.Windows.Forms.TextBox
    Friend WithEvents txtSin As TextBox
    Friend WithEvents txtPhantomType As System.Windows.Forms.TextBox
    Friend WithEvents txtTeamType As System.Windows.Forms.TextBox
    Friend WithEvents txtZPos As System.Windows.Forms.TextBox
    Friend WithEvents txtYPos As System.Windows.Forms.TextBox
    Friend WithEvents txtXPos As System.Windows.Forms.TextBox
    Friend WithEvents txtDeaths As TextBox
    Friend WithEvents txtClearCount As TextBox
    Friend WithEvents txtTimePlayed As TextBox
End Class
