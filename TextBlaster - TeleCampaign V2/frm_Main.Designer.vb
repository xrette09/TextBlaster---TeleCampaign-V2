Partial Public Class frm_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, Nothing, True, True)
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.sim1Stat_LBL = New DevExpress.XtraBars.BarStaticItem()
        Me.sim2Stat_LBL = New DevExpress.XtraBars.BarStaticItem()
        Me.sim3Stat_LBL = New DevExpress.XtraBars.BarStaticItem()
        Me.Sim4Stat_LBL = New DevExpress.XtraBars.BarStaticItem()
        Me.Sim5Stat_LBL = New DevExpress.XtraBars.BarStaticItem()
        Me.sim6Stat_LBL = New DevExpress.XtraBars.BarStaticItem()
        Me.sim7Stat_LBL = New DevExpress.XtraBars.BarStaticItem()
        Me.sim8Stat_LBL = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem13 = New DevExpress.XtraBars.BarStaticItem()
        Me.server_BTN = New DevExpress.XtraBars.BarButtonItem()
        Me.textblast_BTN = New DevExpress.XtraBars.BarButtonItem()
        Me.message_BTN = New DevExpress.XtraBars.BarButtonItem()
        Me.inbox_BTN = New DevExpress.XtraBars.BarButtonItem()
        Me.outbox_BTN = New DevExpress.XtraBars.BarButtonItem()
        Me.simDetails_BTN = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.BarStaticItem7 = New DevExpress.XtraBars.BarStaticItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.server_GRP = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.messaging_GRP = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.details_GRP = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplashScreenManager1
        '
        SplashScreenManager1.ClosingDelay = 500
        '
        'ribbonControl1
        '
        Me.ribbonControl1.AutoHideEmptyItems = True
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.sim1Stat_LBL, Me.sim2Stat_LBL, Me.sim3Stat_LBL, Me.Sim4Stat_LBL, Me.Sim5Stat_LBL, Me.sim6Stat_LBL, Me.sim7Stat_LBL, Me.sim8Stat_LBL, Me.BarStaticItem13, Me.server_BTN, Me.textblast_BTN, Me.message_BTN, Me.inbox_BTN, Me.outbox_BTN, Me.simDetails_BTN, Me.SkinRibbonGalleryBarItem1, Me.BarStaticItem7})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 147
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.sim1Stat_LBL)
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.sim2Stat_LBL)
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.sim3Stat_LBL)
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.Sim4Stat_LBL)
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.Sim5Stat_LBL)
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.sim6Stat_LBL)
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.sim7Stat_LBL)
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.sim8Stat_LBL)
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice
        Me.ribbonControl1.Size = New System.Drawing.Size(1028, 87)
        Me.ribbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.ribbonControl1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[True]
        '
        'sim1Stat_LBL
        '
        Me.sim1Stat_LBL.Caption = "SIM 1"
        Me.sim1Stat_LBL.Id = 1
        Me.sim1Stat_LBL.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_SIM_Card_25px_1
        Me.sim1Stat_LBL.Name = "sim1Stat_LBL"
        '
        'sim2Stat_LBL
        '
        Me.sim2Stat_LBL.Caption = "SIM 2"
        Me.sim2Stat_LBL.Id = 2
        Me.sim2Stat_LBL.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_SIM_Card_25px_1
        Me.sim2Stat_LBL.Name = "sim2Stat_LBL"
        '
        'sim3Stat_LBL
        '
        Me.sim3Stat_LBL.Caption = "SIM 3"
        Me.sim3Stat_LBL.Id = 3
        Me.sim3Stat_LBL.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_SIM_Card_25px_1
        Me.sim3Stat_LBL.Name = "sim3Stat_LBL"
        '
        'Sim4Stat_LBL
        '
        Me.Sim4Stat_LBL.Caption = "SIM 4"
        Me.Sim4Stat_LBL.Id = 4
        Me.Sim4Stat_LBL.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_SIM_Card_25px_1
        Me.Sim4Stat_LBL.Name = "Sim4Stat_LBL"
        '
        'Sim5Stat_LBL
        '
        Me.Sim5Stat_LBL.Caption = "SIM 5"
        Me.Sim5Stat_LBL.Id = 5
        Me.Sim5Stat_LBL.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_SIM_Card_25px_1
        Me.Sim5Stat_LBL.Name = "Sim5Stat_LBL"
        '
        'sim6Stat_LBL
        '
        Me.sim6Stat_LBL.Caption = "SIM 6"
        Me.sim6Stat_LBL.Id = 6
        Me.sim6Stat_LBL.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_SIM_Card_25px_1
        Me.sim6Stat_LBL.Name = "sim6Stat_LBL"
        '
        'sim7Stat_LBL
        '
        Me.sim7Stat_LBL.Caption = "SIM 7"
        Me.sim7Stat_LBL.Id = 11
        Me.sim7Stat_LBL.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_SIM_Card_25px_1
        Me.sim7Stat_LBL.Name = "sim7Stat_LBL"
        '
        'sim8Stat_LBL
        '
        Me.sim8Stat_LBL.Caption = "SIM 8"
        Me.sim8Stat_LBL.Id = 12
        Me.sim8Stat_LBL.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_SIM_Card_25px_1
        Me.sim8Stat_LBL.Name = "sim8Stat_LBL"
        '
        'BarStaticItem13
        '
        Me.BarStaticItem13.Caption = "BarStaticItem13"
        Me.BarStaticItem13.Id = 13
        Me.BarStaticItem13.Name = "BarStaticItem13"
        '
        'server_BTN
        '
        Me.server_BTN.Caption = "Server"
        Me.server_BTN.Id = 14
        Me.server_BTN.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.database_server_connection_internet_things_line_vector_28087042
        Me.server_BTN.ImageOptions.LargeImage = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.database_server_connection_internet_things_line_vector_28087042
        Me.server_BTN.Name = "server_BTN"
        '
        'textblast_BTN
        '
        Me.textblast_BTN.Caption = "Textblast"
        Me.textblast_BTN.Id = 15
        Me.textblast_BTN.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_USB_On_40px
        Me.textblast_BTN.ImageOptions.LargeImage = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_USB_On_40px
        Me.textblast_BTN.Name = "textblast_BTN"
        '
        'message_BTN
        '
        Me.message_BTN.Caption = "Message"
        Me.message_BTN.Id = 16
        Me.message_BTN.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_Group_Message_40px
        Me.message_BTN.ImageOptions.LargeImage = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_Group_Message_40px
        Me.message_BTN.Name = "message_BTN"
        '
        'inbox_BTN
        '
        Me.inbox_BTN.Caption = "Inbox"
        Me.inbox_BTN.Id = 17
        Me.inbox_BTN.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_Inbox_40px_1
        Me.inbox_BTN.ImageOptions.LargeImage = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_Inbox_40px_1
        Me.inbox_BTN.Name = "inbox_BTN"
        '
        'outbox_BTN
        '
        Me.outbox_BTN.Caption = "Outbox"
        Me.outbox_BTN.Id = 18
        Me.outbox_BTN.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_Sent_40px
        Me.outbox_BTN.ImageOptions.LargeImage = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_Sent_40px
        Me.outbox_BTN.Name = "outbox_BTN"
        '
        'simDetails_BTN
        '
        Me.simDetails_BTN.Caption = "Sim Details"
        Me.simDetails_BTN.Id = 19
        Me.simDetails_BTN.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_Chip_Card_40px1
        Me.simDetails_BTN.ImageOptions.LargeImage = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_Chip_Card_40px1
        Me.simDetails_BTN.Name = "simDetails_BTN"
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.SkinRibbonGalleryBarItem1.Caption = "Skin Gallery"
        Me.SkinRibbonGalleryBarItem1.Id = 145
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'BarStaticItem7
        '
        Me.BarStaticItem7.Caption = "Developed By: JM Dammay (johnmarlodammay.dev@gmail.com)"
        Me.BarStaticItem7.Id = 146
        Me.BarStaticItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BarStaticItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem7.Name = "BarStaticItem7"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.server_GRP, Me.messaging_GRP, Me.details_GRP})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "ribbonPage1"
        '
        'server_GRP
        '
        Me.server_GRP.ItemLinks.Add(Me.server_BTN)
        Me.server_GRP.ItemLinks.Add(Me.textblast_BTN)
        Me.server_GRP.Name = "server_GRP"
        Me.server_GRP.Text = "SETTINGS"
        '
        'messaging_GRP
        '
        Me.messaging_GRP.ItemLinks.Add(Me.message_BTN)
        Me.messaging_GRP.ItemLinks.Add(Me.inbox_BTN)
        Me.messaging_GRP.ItemLinks.Add(Me.outbox_BTN)
        Me.messaging_GRP.Name = "messaging_GRP"
        Me.messaging_GRP.Text = "MESSAGING"
        '
        'details_GRP
        '
        Me.details_GRP.ItemLinks.Add(Me.simDetails_BTN)
        Me.details_GRP.Name = "details_GRP"
        Me.details_GRP.Text = "SIM CARD INFO"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem7)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 424)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1028, 26)
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "The Bezier"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Sim4Stat_LBL), New DevExpress.XtraBars.LinkPersistInfo(Me.Sim5Stat_LBL), New DevExpress.XtraBars.LinkPersistInfo(Me.sim6Stat_LBL)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Status bar"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Sim4Stat_LBL), New DevExpress.XtraBars.LinkPersistInfo(Me.Sim5Stat_LBL), New DevExpress.XtraBars.LinkPersistInfo(Me.sim6Stat_LBL)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Status bar"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 450)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.IsMdiContainer = True
        Me.Name = "frm_Main"
        Me.Ribbon = Me.ribbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents server_GRP As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents sim1Stat_LBL As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents sim2Stat_LBL As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents sim3Stat_LBL As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Sim4Stat_LBL As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Sim5Stat_LBL As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents sim6Stat_LBL As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents messaging_GRP As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents details_GRP As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents sim7Stat_LBL As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents sim8Stat_LBL As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem13 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents server_BTN As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents textblast_BTN As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents message_BTN As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents inbox_BTN As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents outbox_BTN As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents simDetails_BTN As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents BarStaticItem7 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
End Class
