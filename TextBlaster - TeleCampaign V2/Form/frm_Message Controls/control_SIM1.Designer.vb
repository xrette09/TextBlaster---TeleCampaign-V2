<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class control_SIM1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem5 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem6 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem7 = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemMarqueeProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ALL = New System.Windows.Forms.Panel()
        Me.contentPanel = New DevExpress.XtraEditors.PanelControl()
        Me.SimGC = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CoordinatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StDistrictToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NdDistrictToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RdDistrictToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFromVotersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StDistrictToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NdDistrictToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RdDistrictToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFromTupadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFromExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.bottomPanel = New DevExpress.XtraEditors.PanelControl()
        Me.textbox = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.message_TB = New DevExpress.XtraEditors.MemoEdit()
        Me.message_LBL = New DevExpress.XtraEditors.LabelControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.messageID_TB = New System.Windows.Forms.TextBox()
        Me.messageID_LBL = New DevExpress.XtraEditors.LabelControl()
        Me.buttons = New System.Windows.Forms.Panel()
        Me.send_BTN = New DevExpress.XtraEditors.SimpleButton()
        Me.stopBTN = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ALL.SuspendLayout()
        CType(Me.contentPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contentPanel.SuspendLayout()
        CType(Me.SimGC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SimGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bottomPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bottomPanel.SuspendLayout()
        Me.textbox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.message_TB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.buttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem4, Me.BarStaticItem5, Me.BarStaticItem6, Me.BarStaticItem7, Me.BarEditItem1})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMarqueeProgressBar1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem7)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarStaticItem4
        '
        Me.BarStaticItem4.Caption = "Total Count: 0"
        Me.BarStaticItem4.Id = 0
        Me.BarStaticItem4.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.BarStaticItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem4.Name = "BarStaticItem4"
        '
        'BarStaticItem5
        '
        Me.BarStaticItem5.Caption = "Total Selected: 0"
        Me.BarStaticItem5.Id = 1
        Me.BarStaticItem5.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.BarStaticItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem5.Name = "BarStaticItem5"
        '
        'BarStaticItem6
        '
        Me.BarStaticItem6.Caption = "Sending 0 out of 0"
        Me.BarStaticItem6.Id = 2
        Me.BarStaticItem6.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.BarStaticItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem6.Name = "BarStaticItem6"
        '
        'BarStaticItem7
        '
        Me.BarStaticItem7.Caption = "Estimated Seding Time: 0mins"
        Me.BarStaticItem7.Id = 3
        Me.BarStaticItem7.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.BarStaticItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem7.Name = "BarStaticItem7"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1000, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 477)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1000, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 477)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1000, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 477)
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemMarqueeProgressBar1
        Me.BarEditItem1.Id = 4
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemMarqueeProgressBar1
        '
        Me.RepositoryItemMarqueeProgressBar1.Name = "RepositoryItemMarqueeProgressBar1"
        '
        'ALL
        '
        Me.ALL.Controls.Add(Me.contentPanel)
        Me.ALL.Controls.Add(Me.bottomPanel)
        Me.ALL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ALL.Location = New System.Drawing.Point(0, 0)
        Me.ALL.Name = "ALL"
        Me.ALL.Size = New System.Drawing.Size(1000, 477)
        Me.ALL.TabIndex = 10
        '
        'contentPanel
        '
        Me.contentPanel.Controls.Add(Me.SimGC)
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentPanel.Location = New System.Drawing.Point(0, 0)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(1000, 334)
        Me.contentPanel.TabIndex = 11
        '
        'SimGC
        '
        Me.SimGC.ContextMenuStrip = Me.ContextMenuStrip1
        Me.SimGC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SimGC.Location = New System.Drawing.Point(2, 2)
        Me.SimGC.MainView = Me.SimGV
        Me.SimGC.MenuManager = Me.BarManager1
        Me.SimGC.Name = "SimGC"
        Me.SimGC.Size = New System.Drawing.Size(996, 330)
        Me.SimGC.TabIndex = 0
        Me.SimGC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.SimGV})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoordinatorToolStripMenuItem, Me.ImportFromVotersToolStripMenuItem, Me.ImportFromTupadToolStripMenuItem, Me.ImportFromExcelToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(214, 114)
        '
        'CoordinatorToolStripMenuItem
        '
        Me.CoordinatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StDistrictToolStripMenuItem, Me.NdDistrictToolStripMenuItem, Me.RdDistrictToolStripMenuItem})
        Me.CoordinatorToolStripMenuItem.Name = "CoordinatorToolStripMenuItem"
        Me.CoordinatorToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.CoordinatorToolStripMenuItem.Text = "Import From Coordinators"
        '
        'StDistrictToolStripMenuItem
        '
        Me.StDistrictToolStripMenuItem.Name = "StDistrictToolStripMenuItem"
        Me.StDistrictToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StDistrictToolStripMenuItem.Text = "1st District"
        '
        'NdDistrictToolStripMenuItem
        '
        Me.NdDistrictToolStripMenuItem.Name = "NdDistrictToolStripMenuItem"
        Me.NdDistrictToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NdDistrictToolStripMenuItem.Text = "2nd District"
        '
        'RdDistrictToolStripMenuItem
        '
        Me.RdDistrictToolStripMenuItem.Name = "RdDistrictToolStripMenuItem"
        Me.RdDistrictToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RdDistrictToolStripMenuItem.Text = "3rd District"
        '
        'ImportFromVotersToolStripMenuItem
        '
        Me.ImportFromVotersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StDistrictToolStripMenuItem1, Me.NdDistrictToolStripMenuItem1, Me.RdDistrictToolStripMenuItem1})
        Me.ImportFromVotersToolStripMenuItem.Name = "ImportFromVotersToolStripMenuItem"
        Me.ImportFromVotersToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ImportFromVotersToolStripMenuItem.Text = "Import From Voters"
        '
        'StDistrictToolStripMenuItem1
        '
        Me.StDistrictToolStripMenuItem1.Name = "StDistrictToolStripMenuItem1"
        Me.StDistrictToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.StDistrictToolStripMenuItem1.Text = "1st District"
        '
        'NdDistrictToolStripMenuItem1
        '
        Me.NdDistrictToolStripMenuItem1.Name = "NdDistrictToolStripMenuItem1"
        Me.NdDistrictToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.NdDistrictToolStripMenuItem1.Text = "2nd District"
        '
        'RdDistrictToolStripMenuItem1
        '
        Me.RdDistrictToolStripMenuItem1.Name = "RdDistrictToolStripMenuItem1"
        Me.RdDistrictToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.RdDistrictToolStripMenuItem1.Text = "3rd District"
        '
        'ImportFromTupadToolStripMenuItem
        '
        Me.ImportFromTupadToolStripMenuItem.Name = "ImportFromTupadToolStripMenuItem"
        Me.ImportFromTupadToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ImportFromTupadToolStripMenuItem.Text = "Import From Tupad"
        '
        'ImportFromExcelToolStripMenuItem
        '
        Me.ImportFromExcelToolStripMenuItem.Name = "ImportFromExcelToolStripMenuItem"
        Me.ImportFromExcelToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ImportFromExcelToolStripMenuItem.Text = "Import From Excel"
        '
        'SimGV
        '
        Me.SimGV.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.SimGV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.SimGV.Appearance.GroupPanel.Options.UseFont = True
        Me.SimGV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.SimGV.GridControl = Me.SimGC
        Me.SimGV.GroupPanelText = "Sim 1 Delivery Status"
        Me.SimGV.Name = "SimGV"
        '
        'bottomPanel
        '
        Me.bottomPanel.Appearance.BackColor = System.Drawing.Color.DimGray
        Me.bottomPanel.Appearance.Options.UseBackColor = True
        Me.bottomPanel.Controls.Add(Me.textbox)
        Me.bottomPanel.Controls.Add(Me.buttons)
        Me.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomPanel.Location = New System.Drawing.Point(0, 334)
        Me.bottomPanel.Name = "bottomPanel"
        Me.bottomPanel.Size = New System.Drawing.Size(1000, 143)
        Me.bottomPanel.TabIndex = 10
        '
        'textbox
        '
        Me.textbox.BackColor = System.Drawing.Color.Transparent
        Me.textbox.Controls.Add(Me.Panel1)
        Me.textbox.Controls.Add(Me.Panel2)
        Me.textbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textbox.Location = New System.Drawing.Point(2, 2)
        Me.textbox.Name = "textbox"
        Me.textbox.Size = New System.Drawing.Size(783, 139)
        Me.textbox.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.message_TB)
        Me.Panel1.Controls.Add(Me.message_LBL)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(783, 139)
        Me.Panel1.TabIndex = 31
        '
        'message_TB
        '
        Me.message_TB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.message_TB.Location = New System.Drawing.Point(70, 1)
        Me.message_TB.Name = "message_TB"
        Me.message_TB.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.message_TB.Properties.Appearance.Options.UseBackColor = True
        Me.message_TB.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.message_TB.Properties.ReadOnly = True
        Me.message_TB.Size = New System.Drawing.Size(712, 137)
        Me.message_TB.TabIndex = 22
        '
        'message_LBL
        '
        Me.message_LBL.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.message_LBL.Appearance.Options.UseFont = True
        Me.message_LBL.Appearance.Options.UseTextOptions = True
        Me.message_LBL.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.message_LBL.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.message_LBL.Dock = System.Windows.Forms.DockStyle.Left
        Me.message_LBL.Location = New System.Drawing.Point(1, 1)
        Me.message_LBL.Name = "message_LBL"
        Me.message_LBL.Size = New System.Drawing.Size(69, 137)
        Me.message_LBL.TabIndex = 23
        Me.message_LBL.Text = "Message:  "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.messageID_TB)
        Me.Panel2.Controls.Add(Me.messageID_LBL)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(783, 0)
        Me.Panel2.TabIndex = 32
        '
        'messageID_TB
        '
        Me.messageID_TB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.messageID_TB.Enabled = False
        Me.messageID_TB.Location = New System.Drawing.Point(70, 1)
        Me.messageID_TB.Multiline = True
        Me.messageID_TB.Name = "messageID_TB"
        Me.messageID_TB.ReadOnly = True
        Me.messageID_TB.Size = New System.Drawing.Size(712, 0)
        Me.messageID_TB.TabIndex = 27
        '
        'messageID_LBL
        '
        Me.messageID_LBL.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.messageID_LBL.Appearance.Options.UseFont = True
        Me.messageID_LBL.Appearance.Options.UseTextOptions = True
        Me.messageID_LBL.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.messageID_LBL.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.messageID_LBL.Dock = System.Windows.Forms.DockStyle.Left
        Me.messageID_LBL.Location = New System.Drawing.Point(1, 1)
        Me.messageID_LBL.Name = "messageID_LBL"
        Me.messageID_LBL.Size = New System.Drawing.Size(69, 0)
        Me.messageID_LBL.TabIndex = 26
        Me.messageID_LBL.Text = "MsgID:  "
        '
        'buttons
        '
        Me.buttons.BackColor = System.Drawing.Color.Transparent
        Me.buttons.Controls.Add(Me.send_BTN)
        Me.buttons.Controls.Add(Me.stopBTN)
        Me.buttons.Dock = System.Windows.Forms.DockStyle.Right
        Me.buttons.Location = New System.Drawing.Point(785, 2)
        Me.buttons.Name = "buttons"
        Me.buttons.Padding = New System.Windows.Forms.Padding(2)
        Me.buttons.Size = New System.Drawing.Size(213, 139)
        Me.buttons.TabIndex = 31
        '
        'send_BTN
        '
        Me.send_BTN.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.send_BTN.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.send_BTN.Appearance.Options.UseBackColor = True
        Me.send_BTN.Appearance.Options.UseFont = True
        Me.send_BTN.Dock = System.Windows.Forms.DockStyle.Top
        Me.send_BTN.Location = New System.Drawing.Point(2, 2)
        Me.send_BTN.Name = "send_BTN"
        Me.send_BTN.Padding = New System.Windows.Forms.Padding(2)
        Me.send_BTN.Size = New System.Drawing.Size(209, 67)
        Me.send_BTN.TabIndex = 19
        Me.send_BTN.Text = "SEND USING SIM1"
        '
        'stopBTN
        '
        Me.stopBTN.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.stopBTN.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.stopBTN.Appearance.Options.UseBackColor = True
        Me.stopBTN.Appearance.Options.UseFont = True
        Me.stopBTN.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.stopBTN.Enabled = False
        Me.stopBTN.Location = New System.Drawing.Point(2, 71)
        Me.stopBTN.Name = "stopBTN"
        Me.stopBTN.Size = New System.Drawing.Size(209, 66)
        Me.stopBTN.TabIndex = 30
        Me.stopBTN.Text = "STOP"
        '
        'control_SIM1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ALL)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "control_SIM1"
        Me.Size = New System.Drawing.Size(1000, 500)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ALL.ResumeLayout(False)
        CType(Me.contentPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contentPanel.ResumeLayout(False)
        CType(Me.SimGC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.SimGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bottomPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bottomPanel.ResumeLayout(False)
        Me.textbox.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.message_TB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.buttons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem5 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem6 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem7 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemMarqueeProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ALL As Panel
    Friend WithEvents contentPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimGC As DevExpress.XtraGrid.GridControl
    Friend WithEvents SimGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bottomPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents textbox As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents message_TB As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents message_LBL As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents messageID_TB As TextBox
    Friend WithEvents messageID_LBL As DevExpress.XtraEditors.LabelControl
    Friend WithEvents buttons As Panel
    Friend WithEvents send_BTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents stopBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CoordinatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StDistrictToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NdDistrictToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RdDistrictToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportFromVotersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StDistrictToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NdDistrictToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RdDistrictToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImportFromTupadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportFromExcelToolStripMenuItem As ToolStripMenuItem
End Class
