<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Message
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.messageList_BTN = New DevExpress.XtraBars.BarButtonItem()
        Me.individualMessage_BTN = New DevExpress.XtraBars.BarButtonItem()
        Me.deliveryStatus_BTN = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ALL = New DevExpress.XtraEditors.PanelControl()
        Me.Control_MessageList1 = New TextBlaster___TeleCampaign_V2.control_MessageList()
        Me.Control_SMS1 = New TextBlaster___TeleCampaign_V2.control_SMS()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ALL.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.messageList_BTN, Me.individualMessage_BTN, Me.deliveryStatus_BTN})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.messageList_BTN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.individualMessage_BTN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.deliveryStatus_BTN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Text = "Tools"
        '
        'messageList_BTN
        '
        Me.messageList_BTN.Caption = "Message List"
        Me.messageList_BTN.Id = 0
        Me.messageList_BTN.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_Sent_25px1
        Me.messageList_BTN.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.messageList_BTN.ItemAppearance.Normal.Options.UseFont = True
        Me.messageList_BTN.Name = "messageList_BTN"
        '
        'individualMessage_BTN
        '
        Me.individualMessage_BTN.Caption = "Individual Message"
        Me.individualMessage_BTN.Id = 1
        Me.individualMessage_BTN.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_ID_Card_25px
        Me.individualMessage_BTN.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.individualMessage_BTN.ItemAppearance.Normal.Options.UseFont = True
        Me.individualMessage_BTN.Name = "individualMessage_BTN"
        '
        'deliveryStatus_BTN
        '
        Me.deliveryStatus_BTN.Caption = "Delivery Status"
        Me.deliveryStatus_BTN.Id = 2
        Me.deliveryStatus_BTN.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_In_Transit_25px
        Me.deliveryStatus_BTN.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.deliveryStatus_BTN.ItemAppearance.Normal.Options.UseFont = True
        Me.deliveryStatus_BTN.Name = "deliveryStatus_BTN"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 1
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        Me.Bar2.Visible = False
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        Me.Bar3.Visible = False
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(974, 53)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 438)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(974, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 53)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 385)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(974, 53)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 385)
        '
        'ALL
        '
        Me.ALL.Controls.Add(Me.Control_MessageList1)
        Me.ALL.Controls.Add(Me.Control_SMS1)
        Me.ALL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ALL.Location = New System.Drawing.Point(0, 53)
        Me.ALL.Name = "ALL"
        Me.ALL.Size = New System.Drawing.Size(974, 385)
        Me.ALL.TabIndex = 4
        '
        'Control_MessageList1
        '
        Me.Control_MessageList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Control_MessageList1.Location = New System.Drawing.Point(2, 2)
        Me.Control_MessageList1.Name = "Control_MessageList1"
        Me.Control_MessageList1.Size = New System.Drawing.Size(970, 381)
        Me.Control_MessageList1.TabIndex = 1
        '
        'Control_SMS1
        '
        Me.Control_SMS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Control_SMS1.Location = New System.Drawing.Point(2, 2)
        Me.Control_SMS1.Name = "Control_SMS1"
        Me.Control_SMS1.Size = New System.Drawing.Size(970, 381)
        Me.Control_SMS1.TabIndex = 2
        '
        'frm_Message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 461)
        Me.Controls.Add(Me.ALL)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Message"
        Me.Text = "frm_Message"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ALL.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents messageList_BTN As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents individualMessage_BTN As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents deliveryStatus_BTN As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ALL As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Control_MessageList1 As control_MessageList
    Friend WithEvents Control_SMS1 As control_SMS
End Class
