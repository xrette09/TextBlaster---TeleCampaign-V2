Imports System.ComponentModel
Imports System.Text


Partial Public Class frm_Main

    Public frmmessage As New frm_Message
    Public frminbox As New frm_Inbox
    Public frmsentbox As New frm_Sentbox

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub message_BTN_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles message_BTN.ItemClick
        frmmessage = New frm_Message

        Try
            If Application.OpenForms.OfType(Of frm_Message).Any Then
                Application.OpenForms.Item("frm_Message").Activate()
            Else
                frmmessage.MdiParent = Me
                frmmessage.TopMost = True
                frmmessage.WindowState = FormWindowState.Maximized
                frmmessage.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: frm_Main -> message_BTN_ItemClick" & vbCrLf & vbCrLf & ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub inbox_BTN_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles inbox_BTN.ItemClick
        frminbox = New frm_Inbox

        Try
            If Application.OpenForms.OfType(Of frm_Inbox).Any Then
                Application.OpenForms.Item("frm_Inbox").Activate()
            Else
                frminbox.MdiParent = Me
                frminbox.TopMost = True
                frminbox.WindowState = FormWindowState.Maximized
                frminbox.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: frm_Main -> inbox_BTN_ItemClick" & vbCrLf & vbCrLf & ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub outbox_BTN_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles outbox_BTN.ItemClick
        frmsentbox = New frm_Sentbox

        Try
            If Application.OpenForms.OfType(Of frm_Sentbox).Any Then
                Application.OpenForms.Item("frm_Sentbox").Activate()
            Else
                frmsentbox.MdiParent = Me
                frmsentbox.TopMost = True
                frmsentbox.WindowState = FormWindowState.Maximized
                frmsentbox.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: frm_Main -> outbox_BTN_ItemClick" & vbCrLf & vbCrLf & ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class
