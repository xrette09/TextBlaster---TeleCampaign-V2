<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class control_MessageList
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
        Me.ALL = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CreateNewMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMessageRecipientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectFromCoordinatorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoordinatorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VotersListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NdDistrictToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoordinatorsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VotersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RdDistrictToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SendMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sim1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sim2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sim3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sim4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sim5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sim6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sim7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sim8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DeleteMessageRecipientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ALL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ALL.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ALL
        '
        Me.ALL.Controls.Add(Me.GridControl1)
        Me.ALL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ALL.Location = New System.Drawing.Point(0, 0)
        Me.ALL.Name = "ALL"
        Me.ALL.Size = New System.Drawing.Size(1000, 500)
        Me.ALL.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(996, 496)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateNewMessageToolStripMenuItem, Me.AddMessageRecipientsToolStripMenuItem, Me.DeleteMessageRecipientsToolStripMenuItem, Me.ToolStripSeparator1, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.SendMessageToolStripMenuItem, Me.ViewSummaryToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(214, 170)
        '
        'CreateNewMessageToolStripMenuItem
        '
        Me.CreateNewMessageToolStripMenuItem.Name = "CreateNewMessageToolStripMenuItem"
        Me.CreateNewMessageToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.CreateNewMessageToolStripMenuItem.Text = "Create New Message"
        '
        'AddMessageRecipientsToolStripMenuItem
        '
        Me.AddMessageRecipientsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectFromCoordinatorsToolStripMenuItem, Me.NdDistrictToolStripMenuItem, Me.RdDistrictToolStripMenuItem})
        Me.AddMessageRecipientsToolStripMenuItem.Name = "AddMessageRecipientsToolStripMenuItem"
        Me.AddMessageRecipientsToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.AddMessageRecipientsToolStripMenuItem.Text = "Add Message Recipients"
        '
        'SelectFromCoordinatorsToolStripMenuItem
        '
        Me.SelectFromCoordinatorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoordinatorsToolStripMenuItem, Me.VotersListToolStripMenuItem})
        Me.SelectFromCoordinatorsToolStripMenuItem.Name = "SelectFromCoordinatorsToolStripMenuItem"
        Me.SelectFromCoordinatorsToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SelectFromCoordinatorsToolStripMenuItem.Text = "1st District"
        '
        'CoordinatorsToolStripMenuItem
        '
        Me.CoordinatorsToolStripMenuItem.Name = "CoordinatorsToolStripMenuItem"
        Me.CoordinatorsToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CoordinatorsToolStripMenuItem.Text = "Coordinators"
        '
        'VotersListToolStripMenuItem
        '
        Me.VotersListToolStripMenuItem.Name = "VotersListToolStripMenuItem"
        Me.VotersListToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.VotersListToolStripMenuItem.Text = "Voters List"
        '
        'NdDistrictToolStripMenuItem
        '
        Me.NdDistrictToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoordinatorsToolStripMenuItem1, Me.VotersToolStripMenuItem})
        Me.NdDistrictToolStripMenuItem.Name = "NdDistrictToolStripMenuItem"
        Me.NdDistrictToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.NdDistrictToolStripMenuItem.Text = "2nd District"
        '
        'CoordinatorsToolStripMenuItem1
        '
        Me.CoordinatorsToolStripMenuItem1.Name = "CoordinatorsToolStripMenuItem1"
        Me.CoordinatorsToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.CoordinatorsToolStripMenuItem1.Text = "Coordinators"
        '
        'VotersToolStripMenuItem
        '
        Me.VotersToolStripMenuItem.Name = "VotersToolStripMenuItem"
        Me.VotersToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.VotersToolStripMenuItem.Text = "Voters"
        '
        'RdDistrictToolStripMenuItem
        '
        Me.RdDistrictToolStripMenuItem.Name = "RdDistrictToolStripMenuItem"
        Me.RdDistrictToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.RdDistrictToolStripMenuItem.Text = "3rd District"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(210, 6)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(210, 6)
        '
        'SendMessageToolStripMenuItem
        '
        Me.SendMessageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Sim1ToolStripMenuItem, Me.Sim2ToolStripMenuItem, Me.Sim3ToolStripMenuItem, Me.Sim4ToolStripMenuItem, Me.Sim5ToolStripMenuItem, Me.Sim6ToolStripMenuItem, Me.Sim7ToolStripMenuItem, Me.Sim8ToolStripMenuItem})
        Me.SendMessageToolStripMenuItem.Name = "SendMessageToolStripMenuItem"
        Me.SendMessageToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.SendMessageToolStripMenuItem.Text = "Send Using Sim"
        '
        'Sim1ToolStripMenuItem
        '
        Me.Sim1ToolStripMenuItem.Name = "Sim1ToolStripMenuItem"
        Me.Sim1ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.Sim1ToolStripMenuItem.Text = "Sim1"
        '
        'Sim2ToolStripMenuItem
        '
        Me.Sim2ToolStripMenuItem.Name = "Sim2ToolStripMenuItem"
        Me.Sim2ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.Sim2ToolStripMenuItem.Text = "Sim2"
        '
        'Sim3ToolStripMenuItem
        '
        Me.Sim3ToolStripMenuItem.Name = "Sim3ToolStripMenuItem"
        Me.Sim3ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.Sim3ToolStripMenuItem.Text = "Sim3"
        '
        'Sim4ToolStripMenuItem
        '
        Me.Sim4ToolStripMenuItem.Name = "Sim4ToolStripMenuItem"
        Me.Sim4ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.Sim4ToolStripMenuItem.Text = "Sim4"
        '
        'Sim5ToolStripMenuItem
        '
        Me.Sim5ToolStripMenuItem.Name = "Sim5ToolStripMenuItem"
        Me.Sim5ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.Sim5ToolStripMenuItem.Text = "Sim5"
        '
        'Sim6ToolStripMenuItem
        '
        Me.Sim6ToolStripMenuItem.Name = "Sim6ToolStripMenuItem"
        Me.Sim6ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.Sim6ToolStripMenuItem.Text = "Sim6"
        '
        'Sim7ToolStripMenuItem
        '
        Me.Sim7ToolStripMenuItem.Name = "Sim7ToolStripMenuItem"
        Me.Sim7ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.Sim7ToolStripMenuItem.Text = "Sim7"
        '
        'Sim8ToolStripMenuItem
        '
        Me.Sim8ToolStripMenuItem.Name = "Sim8ToolStripMenuItem"
        Me.Sim8ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.Sim8ToolStripMenuItem.Text = "Sim8"
        '
        'ViewSummaryToolStripMenuItem
        '
        Me.ViewSummaryToolStripMenuItem.Name = "ViewSummaryToolStripMenuItem"
        Me.ViewSummaryToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ViewSummaryToolStripMenuItem.Text = "View Summary"
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Message List"
        Me.GridView1.Name = "GridView1"
        '
        'DeleteMessageRecipientsToolStripMenuItem
        '
        Me.DeleteMessageRecipientsToolStripMenuItem.Name = "DeleteMessageRecipientsToolStripMenuItem"
        Me.DeleteMessageRecipientsToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.DeleteMessageRecipientsToolStripMenuItem.Text = "Delete Message Recipients"
        '
        'control_MessageList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ALL)
        Me.Name = "control_MessageList"
        Me.Size = New System.Drawing.Size(1000, 500)
        CType(Me.ALL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ALL.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ALL As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CreateNewMessageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewSummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddMessageRecipientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectFromCoordinatorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoordinatorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VotersListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NdDistrictToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoordinatorsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VotersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RdDistrictToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SendMessageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sim1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sim2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sim3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sim4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sim5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sim6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sim7ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sim8ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents DeleteMessageRecipientsToolStripMenuItem As ToolStripMenuItem
End Class
