<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Outbox
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
        Me.ALL = New DevExpress.XtraEditors.PanelControl()
        CType(Me.ALL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ALL
        '
        Me.ALL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ALL.Location = New System.Drawing.Point(0, 0)
        Me.ALL.Name = "ALL"
        Me.ALL.Size = New System.Drawing.Size(974, 461)
        Me.ALL.TabIndex = 5
        '
        'frm_Outbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(974, 461)
        Me.Controls.Add(Me.ALL)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Outbox"
        Me.Text = "frm_Outbox"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ALL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ALL As DevExpress.XtraEditors.PanelControl
End Class
