<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ComposeMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ComposeMessage))
        Me.ALL = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.sampleMessage_LBL = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.footer_TB = New DevExpress.XtraEditors.TextEdit()
        Me.footer_CB = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.message_TB = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.header_TB = New DevExpress.XtraEditors.TextEdit()
        Me.header_CB = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.mode_CBE = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.exit_BTN = New DevExpress.XtraEditors.SimpleButton()
        Me.save_BTN = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ALL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ALL.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.footer_TB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.message_TB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.header_TB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.mode_CBE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ALL
        '
        Me.ALL.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ALL.Controls.Add(Me.PanelControl2)
        Me.ALL.Controls.Add(Me.PanelControl3)
        Me.ALL.Controls.Add(Me.PanelControl4)
        Me.ALL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ALL.Location = New System.Drawing.Point(0, 0)
        Me.ALL.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ALL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ALL.Name = "ALL"
        Me.ALL.Size = New System.Drawing.Size(441, 410)
        Me.ALL.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl2.Controls.Add(Me.sampleMessage_LBL)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 189)
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(441, 177)
        Me.PanelControl2.TabIndex = 0
        '
        'sampleMessage_LBL
        '
        Me.sampleMessage_LBL.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.sampleMessage_LBL.Appearance.Options.UseForeColor = True
        Me.sampleMessage_LBL.Appearance.Options.UseTextOptions = True
        Me.sampleMessage_LBL.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.sampleMessage_LBL.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.sampleMessage_LBL.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.sampleMessage_LBL.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.sampleMessage_LBL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sampleMessage_LBL.Location = New System.Drawing.Point(2, 25)
        Me.sampleMessage_LBL.LookAndFeel.UseDefaultLookAndFeel = False
        Me.sampleMessage_LBL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sampleMessage_LBL.Name = "sampleMessage_LBL"
        Me.sampleMessage_LBL.Padding = New System.Windows.Forms.Padding(10)
        Me.sampleMessage_LBL.Size = New System.Drawing.Size(437, 150)
        Me.sampleMessage_LBL.TabIndex = 1
        Me.sampleMessage_LBL.Text = "Try to type message in Message Box."
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl1.Location = New System.Drawing.Point(2, 2)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Padding = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Size = New System.Drawing.Size(437, 23)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Sample Message:"
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl3.Controls.Add(Me.Panel1)
        Me.PanelControl3.Controls.Add(Me.Panel2)
        Me.PanelControl3.Controls.Add(Me.Panel5)
        Me.PanelControl3.Controls.Add(Me.Panel4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(441, 189)
        Me.PanelControl3.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.footer_TB)
        Me.Panel1.Controls.Add(Me.footer_CB)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(2, 188)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Size = New System.Drawing.Size(437, 0)
        Me.Panel1.TabIndex = 33
        '
        'footer_TB
        '
        Me.footer_TB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.footer_TB.Location = New System.Drawing.Point(75, 2)
        Me.footer_TB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.footer_TB.Name = "footer_TB"
        Me.footer_TB.Properties.AutoHeight = False
        Me.footer_TB.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.footer_TB.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.footer_TB.Size = New System.Drawing.Size(359, 0)
        Me.footer_TB.TabIndex = 26
        '
        'footer_CB
        '
        Me.footer_CB.AutoSize = True
        Me.footer_CB.Dock = System.Windows.Forms.DockStyle.Left
        Me.footer_CB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.footer_CB.Location = New System.Drawing.Point(3, 2)
        Me.footer_CB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.footer_CB.Name = "footer_CB"
        Me.footer_CB.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.footer_CB.Size = New System.Drawing.Size(72, 0)
        Me.footer_CB.TabIndex = 25
        Me.footer_CB.Text = "Footer:"
        Me.footer_CB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.footer_CB.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.message_TB)
        Me.Panel2.Controls.Add(Me.LabelControl4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(2, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Size = New System.Drawing.Size(437, 130)
        Me.Panel2.TabIndex = 32
        '
        'message_TB
        '
        Me.message_TB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.message_TB.Location = New System.Drawing.Point(76, 2)
        Me.message_TB.Name = "message_TB"
        Me.message_TB.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.message_TB.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.message_TB.Size = New System.Drawing.Size(358, 126)
        Me.message_TB.TabIndex = 22
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl4.Location = New System.Drawing.Point(3, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(73, 126)
        Me.LabelControl4.TabIndex = 23
        Me.LabelControl4.Text = "Message:  "
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.header_TB)
        Me.Panel5.Controls.Add(Me.header_CB)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(2, 30)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Size = New System.Drawing.Size(437, 28)
        Me.Panel5.TabIndex = 35
        '
        'header_TB
        '
        Me.header_TB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.header_TB.Enabled = False
        Me.header_TB.Location = New System.Drawing.Point(79, 2)
        Me.header_TB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.header_TB.Name = "header_TB"
        Me.header_TB.Properties.AutoHeight = False
        Me.header_TB.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.header_TB.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.header_TB.Size = New System.Drawing.Size(355, 24)
        Me.header_TB.TabIndex = 26
        '
        'header_CB
        '
        Me.header_CB.AutoSize = True
        Me.header_CB.Dock = System.Windows.Forms.DockStyle.Left
        Me.header_CB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.header_CB.Location = New System.Drawing.Point(3, 2)
        Me.header_CB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.header_CB.Name = "header_CB"
        Me.header_CB.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.header_CB.Size = New System.Drawing.Size(76, 24)
        Me.header_CB.TabIndex = 25
        Me.header_CB.Text = "Header:"
        Me.header_CB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.header_CB.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.mode_CBE)
        Me.Panel4.Controls.Add(Me.LabelControl3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Size = New System.Drawing.Size(437, 28)
        Me.Panel4.TabIndex = 29
        '
        'mode_CBE
        '
        Me.mode_CBE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mode_CBE.EditValue = "Simple Message"
        Me.mode_CBE.Location = New System.Drawing.Point(90, 2)
        Me.mode_CBE.Name = "mode_CBE"
        Me.mode_CBE.Properties.AutoHeight = False
        Me.mode_CBE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.mode_CBE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.mode_CBE.Properties.Items.AddRange(New Object() {"Simple Message", "With Name (English)", "With Name (Tagalog)", "With Seat Number (English)", "With Seat Number (Tagalog)"})
        Me.mode_CBE.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.mode_CBE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.mode_CBE.Size = New System.Drawing.Size(344, 24)
        Me.mode_CBE.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl3.Location = New System.Drawing.Point(3, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(87, 24)
        Me.LabelControl3.TabIndex = 24
        Me.LabelControl3.Text = "Mode:  "
        '
        'PanelControl4
        '
        Me.PanelControl4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PanelControl4.Appearance.Options.UseBackColor = True
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl4.Controls.Add(Me.exit_BTN)
        Me.PanelControl4.Controls.Add(Me.save_BTN)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(0, 366)
        Me.PanelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(441, 44)
        Me.PanelControl4.TabIndex = 70
        '
        'exit_BTN
        '
        Me.exit_BTN.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_BTN.Appearance.Options.UseFont = True
        Me.exit_BTN.ImageOptions.Image = CType(resources.GetObject("exit_BTN.ImageOptions.Image"), System.Drawing.Image)
        Me.exit_BTN.Location = New System.Drawing.Point(321, 7)
        Me.exit_BTN.Name = "exit_BTN"
        Me.exit_BTN.Size = New System.Drawing.Size(106, 29)
        Me.exit_BTN.TabIndex = 65
        Me.exit_BTN.Text = "&Close"
        '
        'save_BTN
        '
        Me.save_BTN.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_BTN.Appearance.Options.UseFont = True
        Me.save_BTN.ImageOptions.Image = CType(resources.GetObject("save_BTN.ImageOptions.Image"), System.Drawing.Image)
        Me.save_BTN.Location = New System.Drawing.Point(211, 7)
        Me.save_BTN.Name = "save_BTN"
        Me.save_BTN.Size = New System.Drawing.Size(106, 29)
        Me.save_BTN.TabIndex = 4
        Me.save_BTN.Text = "&Save"
        '
        'frm_ComposeMessage
        '
        Me.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 410)
        Me.Controls.Add(Me.ALL)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ComposeMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Message"
        CType(Me.ALL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ALL.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.footer_TB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.message_TB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.header_TB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.mode_CBE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ALL As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents sampleMessage_LBL As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel4 As Panel
    Friend WithEvents mode_CBE As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents footer_TB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents footer_CB As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents message_TB As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents exit_BTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents save_BTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents header_TB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents header_CB As CheckBox
End Class
