Imports System.ComponentModel

Public Class frm_ComposeMessage

    Dim ISMS As New SMS_API

    Public selectedControl_Sim As String = ""
    Public mode As String = ""
    Public header As String = ""
    Public body As String = ""

    Private Sub frm_ComposeMessage_Load(sender As Object, e As EventArgs) Handles Me.Load
        mode_CBE.Text = mode
        body_TB.Text = body

        If header <> "" Then
            header_CB.CheckState = CheckState.Checked
            header_TB.Text = header
        Else
            header_CB.CheckState = CheckState.Unchecked
            header_TB.Text = ""
        End If
    End Sub

    Private Sub header_CB_CheckStateChanged(sender As Object, e As EventArgs) Handles header_CB.CheckStateChanged
        If header_CB.CheckState = CheckState.Checked Then
            header_TB.Enabled = True
        Else
            header_TB.Enabled = False
        End If
    End Sub

    Private Sub save_BTN_Click(sender As Object, e As EventArgs) Handles save_BTN.Click
        If _messageBox("Save message settings?") = True Then
            Call ISMS._saveMode(selectedControl_Sim, mode_CBE.Text, header_TB.Text, body_TB.Text)
            Me.Close()
        End If
    End Sub

    Private Sub exit_BTN_Click(sender As Object, e As EventArgs) Handles exit_BTN.Click
        If _messageBox("Discard Changes?") = True Then
            Me.Close()
        End If
    End Sub

    Private Sub body_TB_EditValueChanged(sender As Object, e As EventArgs) Handles body_TB.EditValueChanged, header_TB.EditValueChanged, header_CB.CheckStateChanged, mode_CBE.SelectedIndexChanged
        sampleMessage_LBL.Text = ISMS._formatSampleMessage(mode_CBE.Text, header_TB.Text, body_TB.Text)
    End Sub

    Private Sub frm_ComposeMessage_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        mode_CBE.SelectedIndex = 0
        header_CB.CheckState = CheckState.Unchecked
        header_TB.Text = ""
        body_TB.Text = ""
    End Sub

    Function _messageBox(prompt As String) As Boolean
        Dim response As DialogResult = MessageBox.Show(prompt, "TextBlaster - TeleCampaign", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then : Return True
        Else : Return False : End If
    End Function

    Sub _getHeaderStatus(ByVal headerStatus As CheckState)
        If header_CB.Checked Then
            header_TB.Enabled = True
        Else
            header_TB.Enabled = False
        End If
    End Sub

End Class