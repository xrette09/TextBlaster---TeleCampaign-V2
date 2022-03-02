Imports System.ComponentModel

Public Class frm_ComposeMessage

    Dim selectedControl_Sim As String = ""

    Dim mode As String = "Simple Message"
    Dim header As String = ""
    Dim message As String = ""

    Private Sub frm_ComposeMessage_Load(sender As Object, e As EventArgs) Handles Me.Load

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
            header = header_TB.Text
            message = message_TB.Text
            Me.Close()
        End If
    End Sub

    Private Sub exit_BTN_Click(sender As Object, e As EventArgs) Handles exit_BTN.Click

        If _messageBox("Discard Changes?") = True Then
            Me.Close()
        End If
    End Sub

    Private Sub message_TB_EditValueChanged(sender As Object, e As EventArgs) Handles message_TB.EditValueChanged, header_TB.EditValueChanged, header_CB.CheckStateChanged, mode_CBE.SelectedIndexChanged
        sampleMessage_LBL.Text = _getMode()
    End Sub

    Private Sub frm_ComposeMessage_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        mode_CBE.SelectedIndex = 0
        header_CB.CheckState = CheckState.Unchecked
        header_TB.Text = ""
        message_TB.Text = ""
    End Sub

    Function _messageBox(prompt As String) As Boolean

        Dim response As DialogResult = MessageBox.Show(prompt, "TextBlaster - TeleCampaign", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then : Return True
        Else : Return False : End If
    End Function
    Sub _getHeaderStatus()
        If header_CB.Checked Then
            header_TB.Enabled = True
        Else
            header_TB.Enabled = False
        End If
    End Sub

    Function _getMode() As String
        Dim sampleMessage As String = ""

        If mode_CBE.Text = "Simple Message" Then
            sampleMessage = message_TB.Text
        ElseIf mode_CBE.Text = "With Name (English)" Then
            sampleMessage = "Goodday Mr/Mrs Juan Dela Cruz! " + message_TB.Text
        ElseIf mode_CBE.Text = "With Name (Tagalog)" Then
            sampleMessage = "Magandang Mr/Mrs Juan Dela Cruz! " + message_TB.Text
        ElseIf mode_CBE.Text = "With Seat Number (English)" Then
            sampleMessage = "Goodday Mr/Mrs Juan Dela Cruz! " + message_TB.Text + " Your seatnumber is 20."
        ElseIf mode_CBE.Text = "With Seat Number (Tagalog)" Then
            sampleMessage = "Magandang Mr/Mrs Juan Dela Cruz! " + message_TB.Text + "Ang numero ng iyong upuan ay 20."
        End If

        If header_CB.Checked Then
            sampleMessage = header_TB.Text + vbCrLf + vbCrLf + sampleMessage
        End If

        Return sampleMessage
    End Function
End Class