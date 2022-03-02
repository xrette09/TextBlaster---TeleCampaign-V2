<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Coordinators
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Coordinators))
        Me.ALL_PANEL = New System.Windows.Forms.Panel()
        Me.CONTENT_PNL = New DevExpress.XtraEditors.PanelControl()
        Me.Coordinator_GC = New DevExpress.XtraGrid.GridControl()
        Me.Coordinator_GV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TOP_PNL = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GcID = New DevExpress.XtraEditors.GroupControl()
        Me.ckIdcat = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.btnfilter = New DevExpress.XtraEditors.SimpleButton()
        Me.cbmun = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.cbcluster = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.cbbrgy = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.cbpr = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectAsMessageRecipientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALL_PANEL.SuspendLayout()
        CType(Me.CONTENT_PNL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CONTENT_PNL.SuspendLayout()
        CType(Me.Coordinator_GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Coordinator_GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOP_PNL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TOP_PNL.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GcID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GcID.SuspendLayout()
        CType(Me.ckIdcat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbmun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbcluster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbrgy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbpr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ALL_PANEL
        '
        Me.ALL_PANEL.Controls.Add(Me.CONTENT_PNL)
        Me.ALL_PANEL.Controls.Add(Me.TOP_PNL)
        Me.ALL_PANEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ALL_PANEL.Location = New System.Drawing.Point(0, 0)
        Me.ALL_PANEL.Name = "ALL_PANEL"
        Me.ALL_PANEL.Size = New System.Drawing.Size(1084, 438)
        Me.ALL_PANEL.TabIndex = 1
        '
        'CONTENT_PNL
        '
        Me.CONTENT_PNL.Controls.Add(Me.Coordinator_GC)
        Me.CONTENT_PNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONTENT_PNL.Location = New System.Drawing.Point(0, 159)
        Me.CONTENT_PNL.Name = "CONTENT_PNL"
        Me.CONTENT_PNL.Size = New System.Drawing.Size(1084, 279)
        Me.CONTENT_PNL.TabIndex = 0
        '
        'Coordinator_GC
        '
        Me.Coordinator_GC.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Coordinator_GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Coordinator_GC.Location = New System.Drawing.Point(2, 2)
        Me.Coordinator_GC.MainView = Me.Coordinator_GV
        Me.Coordinator_GC.Name = "Coordinator_GC"
        Me.Coordinator_GC.Size = New System.Drawing.Size(1080, 275)
        Me.Coordinator_GC.TabIndex = 0
        Me.Coordinator_GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Coordinator_GV})
        '
        'Coordinator_GV
        '
        Me.Coordinator_GV.GridControl = Me.Coordinator_GC
        Me.Coordinator_GV.Name = "Coordinator_GV"
        Me.Coordinator_GV.OptionsBehavior.Editable = False
        Me.Coordinator_GV.OptionsSelection.MultiSelect = True
        Me.Coordinator_GV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.Coordinator_GV.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.Coordinator_GV.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.Coordinator_GV.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.[False]
        '
        'TOP_PNL
        '
        Me.TOP_PNL.Controls.Add(Me.GroupControl1)
        Me.TOP_PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.TOP_PNL.Location = New System.Drawing.Point(0, 0)
        Me.TOP_PNL.Name = "TOP_PNL"
        Me.TOP_PNL.Size = New System.Drawing.Size(1084, 159)
        Me.TOP_PNL.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.GcID)
        Me.GroupControl1.Controls.Add(Me.btnfilter)
        Me.GroupControl1.Controls.Add(Me.cbmun)
        Me.GroupControl1.Controls.Add(Me.cbcluster)
        Me.GroupControl1.Controls.Add(Me.cbbrgy)
        Me.GroupControl1.Controls.Add(Me.cbpr)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1080, 159)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Coordinator Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(781, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Precinct No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(793, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Barangay:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(533, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cluster No:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(523, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Municipality:"
        '
        'GcID
        '
        Me.GcID.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GcID.AppearanceCaption.Options.UseFont = True
        Me.GcID.Controls.Add(Me.ckIdcat)
        Me.GcID.Location = New System.Drawing.Point(14, 29)
        Me.GcID.Name = "GcID"
        Me.GcID.Size = New System.Drawing.Size(505, 113)
        Me.GcID.TabIndex = 0
        Me.GcID.Text = "Select ID Category:"
        '
        'ckIdcat
        '
        Me.ckIdcat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckIdcat.Appearance.Options.UseFont = True
        Me.ckIdcat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ckIdcat.CheckOnClick = True
        Me.ckIdcat.Cursor = System.Windows.Forms.Cursors.Default
        Me.ckIdcat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ckIdcat.Location = New System.Drawing.Point(0, 26)
        Me.ckIdcat.MultiColumn = True
        Me.ckIdcat.Name = "ckIdcat"
        Me.ckIdcat.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ckIdcat.Size = New System.Drawing.Size(505, 87)
        Me.ckIdcat.TabIndex = 0
        '
        'btnfilter
        '
        Me.btnfilter.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfilter.Appearance.Options.UseFont = True
        Me.btnfilter.ImageOptions.Image = CType(resources.GetObject("btnfilter.ImageOptions.Image"), System.Drawing.Image)
        Me.btnfilter.Location = New System.Drawing.Point(902, 100)
        Me.btnfilter.Name = "btnfilter"
        Me.btnfilter.Size = New System.Drawing.Size(129, 38)
        Me.btnfilter.TabIndex = 11
        Me.btnfilter.Text = "Filter (Enter)"
        '
        'cbmun
        '
        Me.cbmun.Location = New System.Drawing.Point(613, 45)
        Me.cbmun.Name = "cbmun"
        Me.cbmun.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbmun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbmun.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbmun.Size = New System.Drawing.Size(165, 22)
        Me.cbmun.TabIndex = 1
        '
        'cbcluster
        '
        Me.cbcluster.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbcluster.Location = New System.Drawing.Point(613, 71)
        Me.cbcluster.Name = "cbcluster"
        Me.cbcluster.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbcluster.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbcluster.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbcluster.Size = New System.Drawing.Size(165, 22)
        Me.cbcluster.TabIndex = 2
        '
        'cbbrgy
        '
        Me.cbbrgy.Location = New System.Drawing.Point(866, 46)
        Me.cbbrgy.Name = "cbbrgy"
        Me.cbbrgy.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbbrgy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbrgy.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbbrgy.Size = New System.Drawing.Size(165, 22)
        Me.cbbrgy.TabIndex = 3
        '
        'cbpr
        '
        Me.cbpr.Location = New System.Drawing.Point(866, 72)
        Me.cbpr.Name = "cbpr"
        Me.cbpr.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbpr.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbpr.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbpr.Size = New System.Drawing.Size(165, 22)
        Me.cbpr.TabIndex = 4
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarStaticItem2})
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "BarStaticItem1"
        Me.BarStaticItem1.Id = 1
        Me.BarStaticItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarStaticItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "BarStaticItem2"
        Me.BarStaticItem2.Id = 2
        Me.BarStaticItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarStaticItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1084, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 438)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1084, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 438)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1084, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 438)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAsMessageRecipientToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(221, 26)
        '
        'SelectAsMessageRecipientToolStripMenuItem
        '
        Me.SelectAsMessageRecipientToolStripMenuItem.Name = "SelectAsMessageRecipientToolStripMenuItem"
        Me.SelectAsMessageRecipientToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.SelectAsMessageRecipientToolStripMenuItem.Text = "Select as Message Recipient"
        '
        'frm_Coordinators
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 461)
        Me.Controls.Add(Me.ALL_PANEL)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.LookAndFeel.SkinName = "The Bezier"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Coordinators"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Coordinators"
        Me.ALL_PANEL.ResumeLayout(False)
        CType(Me.CONTENT_PNL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CONTENT_PNL.ResumeLayout(False)
        CType(Me.Coordinator_GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Coordinator_GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOP_PNL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TOP_PNL.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GcID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GcID.ResumeLayout(False)
        CType(Me.ckIdcat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbmun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbcluster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbrgy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbpr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ALL_PANEL As Panel
    Friend WithEvents CONTENT_PNL As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Coordinator_GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents Coordinator_GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TOP_PNL As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GcID As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ckIdcat As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents btnfilter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbmun As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cbcluster As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cbbrgy As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cbpr As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SelectAsMessageRecipientToolStripMenuItem As ToolStripMenuItem
End Class
