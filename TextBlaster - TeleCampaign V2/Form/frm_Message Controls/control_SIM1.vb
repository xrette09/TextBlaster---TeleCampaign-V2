Imports System.ComponentModel
Imports DevExpress.Data

Public Class control_SIM1

    Dim ISMS As New SMS_API

    Public mode As String = "Simple Message"
    Public header As String = ""
    Public body As String = ""

    Public recipient_CpNo As String = ""
    Public recipient_Name As String = ""
    Public recipient_SeatNum As String = "TBA"

    Dim noCpNum_cnt As Integer = 0
    Dim cpNum_cnt As Integer = 0

    Dim selectedRow As Integer = 0



    Private Sub control_SIM1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub message_TB_Click(sender As Object, e As EventArgs) Handles message_TB.Click
        frm_ComposeMessage.selectedControl_Sim = "1"
        frm_ComposeMessage.mode = mode
        frm_ComposeMessage.header = header
        frm_ComposeMessage.body = body
        frm_ComposeMessage.ShowDialog()
    End Sub

    Private Sub StDistrictToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StDistrictToolStripMenuItem.Click
        frm_Coordinators.district = "1"
        frm_Coordinators.gridControl = Me.MessageGC
        frm_Coordinators.gridView = Me.MessageGV
        frm_Coordinators.ShowDialog()
    End Sub

    Private Sub NdDistrictToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NdDistrictToolStripMenuItem.Click
        frm_Coordinators.district = "2"
        frm_Coordinators.gridControl = Me.MessageGC
        frm_Coordinators.gridView = Me.MessageGV
        frm_Coordinators.ShowDialog()
    End Sub

    Private Sub RdDistrictToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RdDistrictToolStripMenuItem.Click
        frm_Coordinators.district = "3"
        frm_Coordinators.gridControl = Me.MessageGC
        frm_Coordinators.gridView = Me.MessageGV
        frm_Coordinators.ShowDialog()
    End Sub

    Private Sub send_BTN_Click(sender As Object, e As EventArgs) Handles send_BTN.Click
        selectedRow = MessageGV.SelectedRowsCount
        sim1_status = True
        sim1_isLimit = False
        'frm_Main.sim1Stat_LBL.Caption = "SIM 1: Busy"
        send_BTN.Enabled = False
        stop_BTN.Enabled = True

        BackgroundWorker1.WorkerSupportsCancellation = True
        BackgroundWorker1.WorkerReportsProgress = True

        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub stopBTN_Click(sender As Object, e As EventArgs) Handles stop_BTN.Click
        stop_BTN.Enabled = False
        BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        noCpNum_cnt = 0
        cpNum_cnt = 0

        For Each rowNum In MessageGV.GetSelectedRows()
            Try : recipient_Name = MessageGV.GetDataRow(rowNum)("Name").ToString : Catch ex As Exception : End Try
            Try : recipient_CpNo = MessageGV.GetDataRow(rowNum)("Contact Number").ToString : Catch ex As Exception : End Try
            Try : recipient_SeatNum = MessageGV.GetDataRow(rowNum)("Seat Number").ToString : Catch ex As Exception : End Try

            If recipient_CpNo.Length = 10 Then
                recipient_CpNo = "0" + recipient_CpNo
            End If

again:

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            If ISMS._Validate(recipient_CpNo) = True Then
                If sim1_isLimit = False Then
                    BackgroundWorker1.ReportProgress(0, ISMS._formatFinalMessage(mode, header, body, recipient_Name, recipient_SeatNum))

                    For cnt = 3 To 1 Step -1
                        If ISMS._sendMessage(recipient_CpNo, ISMS._formatFinalMessage(mode, header, body, recipient_Name, recipient_SeatNum), objSMS1) = False Then
                            sim1_isLimit = True
                            Exit For
                        End If
                    Next

                ElseIf sim1_isLimit = True Then
                    Exit For

                End If
                cpNum_cnt += 1

            Else
                noCpNum_cnt += 1
            End If

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            If sim1_isLimit = False Then
                MessageGV.UnselectRow(rowNum)
            End If

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            If BackgroundWorker1.CancellationPending Then
                Exit For
            End If

        Next

        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        If BackgroundWorker1.CancellationPending Then
            e.Cancel = True
        End If

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        message_TB.Text = e.UserState.ToString
        totalSelected_LBL.Caption = "Total Selected: " & selectedRow
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message)
        ElseIf e.Cancelled Then
            MessageBox.Show("Total Selected: " & selectedRow & vbCrLf &
                            "Total Sent: " & cpNum_cnt & vbCrLf &
                            "Total No Cp Number: " & noCpNum_cnt & vbCrLf &
                            "Remaining: " & (selectedRow - cpNum_cnt - noCpNum_cnt), "SIM 1: Message Successfully Sent!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Total Selected: " & selectedRow & vbCrLf &
                            "Total Sent: " & cpNum_cnt & vbCrLf &
                            "Total No Cp Number: " & noCpNum_cnt, "SIM 1: Message Successfully Sent!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'frm_Main.sim1Stat_LBL.Caption = "SIM 1: Available"
        send_BTN.Enabled = True
        stop_BTN.Enabled = False
    End Sub

    Private Sub MessageGV_DataSourceChanged(sender As Object, e As EventArgs) Handles MessageGV.DataSourceChanged
        totalCount_LBL.Caption = "Total Count: " & MessageGV.RowCount
    End Sub

    Private Sub MessageGV_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles MessageGV.SelectionChanged
        totalSelected_LBL.Caption = "Total Selected: " & selectedRow
        sendingStatus_LBL.Caption = "Sending " & MessageGV.RowCount - MessageGV.SelectedRowsCount & " out of " & selectedRow
        estimatedTime_LBL.Caption = "Estimated Sending Time: " & (Math.Ceiling(message_TB.ToString.Length / 140) * 6 * MessageGV.SelectedRowsCount) / 60 & "min(s)"
    End Sub
End Class
