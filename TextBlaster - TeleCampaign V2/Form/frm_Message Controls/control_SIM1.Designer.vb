<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class control_SIM1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.bottomPanel = New DevExpress.XtraEditors.PanelControl()
        Me.textbox = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.textMsg_TB = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtMsgIDTB = New System.Windows.Forms.TextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.buttons = New System.Windows.Forms.Panel()
        Me.sendBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.stopBTN = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ALL.SuspendLayout()
        CType(Me.contentPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contentPanel.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bottomPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bottomPanel.SuspendLayout()
        Me.textbox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.textMsg_TB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 478)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1000, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 478)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1000, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 478)
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
        Me.ALL.Size = New System.Drawing.Size(1000, 478)
        Me.ALL.TabIndex = 10
        '
        'contentPanel
        '
        Me.contentPanel.Controls.Add(Me.GridControl1)
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentPanel.Location = New System.Drawing.Point(0, 0)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(1000, 335)
        Me.contentPanel.TabIndex = 11
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(996, 331)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Sim 1 Delivery Status"
        Me.GridView1.Name = "GridView1"
        '
        'bottomPanel
        '
        Me.bottomPanel.Appearance.BackColor = System.Drawing.Color.DimGray
        Me.bottomPanel.Appearance.Options.UseBackColor = True
        Me.bottomPanel.Controls.Add(Me.textbox)
        Me.bottomPanel.Controls.Add(Me.buttons)
        Me.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomPanel.Location = New System.Drawing.Point(0, 335)
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
        Me.Panel1.Controls.Add(Me.textMsg_TB)
        Me.Panel1.Controls.Add(Me.LabelControl2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(783, 139)
        Me.Panel1.TabIndex = 31
        '
        'textMsg_TB
        '
        Me.textMsg_TB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textMsg_TB.Location = New System.Drawing.Point(70, 1)
        Me.textMsg_TB.Name = "textMsg_TB"
        Me.textMsg_TB.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.textMsg_TB.Properties.Appearance.Options.UseBackColor = True
        Me.textMsg_TB.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.textMsg_TB.Properties.ReadOnly = True
        Me.textMsg_TB.Size = New System.Drawing.Size(712, 137)
        Me.textMsg_TB.TabIndex = 22
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.Location = New System.Drawing.Point(1, 1)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(69, 137)
        Me.LabelControl2.TabIndex = 23
        Me.LabelControl2.Text = "Message:  "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.txtMsgIDTB)
        Me.Panel2.Controls.Add(Me.LabelControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(783, 0)
        Me.Panel2.TabIndex = 32
        '
        'txtMsgIDTB
        '
        Me.txtMsgIDTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMsgIDTB.Enabled = False
        Me.txtMsgIDTB.Location = New System.Drawing.Point(70, 1)
        Me.txtMsgIDTB.Multiline = True
        Me.txtMsgIDTB.Name = "txtMsgIDTB"
        Me.txtMsgIDTB.ReadOnly = True
        Me.txtMsgIDTB.Size = New System.Drawing.Size(712, 0)
        Me.txtMsgIDTB.TabIndex = 27
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.Location = New System.Drawing.Point(1, 1)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 0)
        Me.LabelControl1.TabIndex = 26
        Me.LabelControl1.Text = "MsgID:  "
        '
        'buttons
        '
        Me.buttons.BackColor = System.Drawing.Color.Transparent
        Me.buttons.Controls.Add(Me.sendBTN)
        Me.buttons.Controls.Add(Me.stopBTN)
        Me.buttons.Dock = System.Windows.Forms.DockStyle.Right
        Me.buttons.Location = New System.Drawing.Point(785, 2)
        Me.buttons.Name = "buttons"
        Me.buttons.Padding = New System.Windows.Forms.Padding(2)
        Me.buttons.Size = New System.Drawing.Size(213, 139)
        Me.buttons.TabIndex = 31
        '
        'sendBTN
        '
        Me.sendBTN.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sendBTN.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.sendBTN.Appearance.Options.UseBackColor = True
        Me.sendBTN.Appearance.Options.UseFont = True
        Me.sendBTN.Dock = System.Windows.Forms.DockStyle.Top
        Me.sendBTN.Location = New System.Drawing.Point(2, 2)
        Me.sendBTN.Name = "sendBTN"
        Me.sendBTN.Padding = New System.Windows.Forms.Padding(2)
        Me.sendBTN.Size = New System.Drawing.Size(209, 67)
        Me.sendBTN.TabIndex = 19
        Me.sendBTN.Text = "SEND USING SIM1"
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
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bottomPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bottomPanel.ResumeLayout(False)
        Me.textbox.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.textMsg_TB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bottomPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents textbox As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents textMsg_TB As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtMsgIDTB As TextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents buttons As Panel
    Friend WithEvents sendBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents stopBTN As DevExpress.XtraEditors.SimpleButton
End Class
