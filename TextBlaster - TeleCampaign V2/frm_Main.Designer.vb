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
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem5 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem6 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem11 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem12 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem13 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.message_BTN = New DevExpress.XtraBars.BarButtonItem()
        Me.inbox_BTN = New DevExpress.XtraBars.BarButtonItem()
        Me.outbox_BTN = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
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
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.BarStaticItem1, Me.BarStaticItem2, Me.BarStaticItem3, Me.BarStaticItem4, Me.BarStaticItem5, Me.BarStaticItem6, Me.BarStaticItem11, Me.BarStaticItem12, Me.BarStaticItem13, Me.BarButtonItem1, Me.BarButtonItem2, Me.message_BTN, Me.inbox_BTN, Me.outbox_BTN, Me.BarButtonItem6})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 20
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.BarStaticItem1)
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.BarStaticItem2)
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.BarStaticItem3)
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.BarStaticItem4)
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.BarStaticItem5)
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.BarStaticItem6)
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.BarStaticItem11)
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.BarStaticItem12)
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.Size = New System.Drawing.Size(1018, 146)
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "SIM 1"
        Me.BarStaticItem1.Id = 1
        Me.BarStaticItem1.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_SIM_Card_25px
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "SIM 2"
        Me.BarStaticItem2.Id = 2
        Me.BarStaticItem2.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_SIM_Card_25px_1
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "SIM 3"
        Me.BarStaticItem3.Id = 3
        Me.BarStaticItem3.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_SIM_Card_25px_2
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'BarStaticItem4
        '
        Me.BarStaticItem4.Caption = "SIM 4"
        Me.BarStaticItem4.Id = 4
        Me.BarStaticItem4.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_SIM_Card_25px_3
        Me.BarStaticItem4.Name = "BarStaticItem4"
        '
        'BarStaticItem5
        '
        Me.BarStaticItem5.Caption = "SIM 5"
        Me.BarStaticItem5.Id = 5
        Me.BarStaticItem5.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_SIM_Card_25px_4
        Me.BarStaticItem5.Name = "BarStaticItem5"
        '
        'BarStaticItem6
        '
        Me.BarStaticItem6.Caption = "SIM 6"
        Me.BarStaticItem6.Id = 6
        Me.BarStaticItem6.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_SIM_Card_25px_5
        Me.BarStaticItem6.Name = "BarStaticItem6"
        '
        'BarStaticItem11
        '
        Me.BarStaticItem11.Caption = "SIM 7"
        Me.BarStaticItem11.Id = 11
        Me.BarStaticItem11.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_SIM_Card_25px_6
        Me.BarStaticItem11.Name = "BarStaticItem11"
        '
        'BarStaticItem12
        '
        Me.BarStaticItem12.Caption = "SIM 8"
        Me.BarStaticItem12.Id = 12
        Me.BarStaticItem12.ImageOptions.Image = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_SIM_Card_25px_7
        Me.BarStaticItem12.Name = "BarStaticItem12"
        '
        'BarStaticItem13
        '
        Me.BarStaticItem13.Caption = "BarStaticItem13"
        Me.BarStaticItem13.Id = 13
        Me.BarStaticItem13.Name = "BarStaticItem13"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Server Connection"
        Me.BarButtonItem1.Id = 14
        Me.BarButtonItem1.ImageOptions.LargeImage = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.database_server_connection_internet_things_line_vector_28087042
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Textblast Comport"
        Me.BarButtonItem2.Id = 15
        Me.BarButtonItem2.ImageOptions.LargeImage = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_USB_On_40px
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'message_BTN
        '
        Me.message_BTN.Caption = "Message"
        Me.message_BTN.Id = 16
        Me.message_BTN.ImageOptions.LargeImage = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_Group_Message_40px
        Me.message_BTN.Name = "message_BTN"
        '
        'inbox_BTN
        '
        Me.inbox_BTN.Caption = "Inbox"
        Me.inbox_BTN.Id = 17
        Me.inbox_BTN.ImageOptions.LargeImage = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_Inbox_40px_1
        Me.inbox_BTN.Name = "inbox_BTN"
        '
        'outbox_BTN
        '
        Me.outbox_BTN.Caption = "Outbox"
        Me.outbox_BTN.Id = 18
        Me.outbox_BTN.ImageOptions.LargeImage = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_Sent_40px
        Me.outbox_BTN.Name = "outbox_BTN"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Sim Details"
        Me.BarButtonItem6.Id = 19
        Me.BarButtonItem6.ImageOptions.LargeImage = Global.TextBlaster___TeleCampaign_V2.My.Resources.Resources.icons8_Chip_Card_40px1
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "ribbonPage1"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "SETTINGS"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.message_BTN)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.inbox_BTN)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.outbox_BTN)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "MESSAGING"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "SIM CARD INFO"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Sharp Plus"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 449)
        Me.Controls.Add(Me.ribbonControl1)
        Me.IsMdiContainer = True
        Me.Name = "frm_Main"
        Me.Ribbon = Me.ribbonControl1
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
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem5 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem6 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents BarStaticItem11 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem12 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem13 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents message_BTN As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents inbox_BTN As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents outbox_BTN As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
End Class
