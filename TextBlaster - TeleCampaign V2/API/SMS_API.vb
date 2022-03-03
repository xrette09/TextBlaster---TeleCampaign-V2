Public Class SMS_API

    Public Function _formatSampleMessage(ByVal mode As String, ByVal header As String, ByVal body As String) As String
        Dim sampleMessage As String = ""

        If mode = "Simple Message" Then
            sampleMessage = body
        ElseIf mode = "With Name (English)" Then
            sampleMessage = "Goodday Mr/Mrs Juan Dela Cruz! " + body
        ElseIf mode = "With Name (Tagalog)" Then
            sampleMessage = "Magandang Mr/Mrs Juan Dela Cruz! " + body
        ElseIf mode = "With Seat Number (English)" Then
            sampleMessage = "Goodday Mr/Mrs Juan Dela Cruz! " + body + " Your seatnumber is 20."
        ElseIf mode = "With Seat Number (Tagalog)" Then
            sampleMessage = "Magandang Mr/Mrs Juan Dela Cruz! " + body + "Ang numero ng iyong upuan ay 20."
        End If

        If header <> "" Then
            sampleMessage = header + vbCrLf + vbCrLf + sampleMessage
        End If

        Return sampleMessage
    End Function

    Public Function _formatFinalMessage(ByVal mode As String, ByVal header As String, ByVal body As String, ByVal name As String, ByVal seatNum As String) As String
        Dim finalMessage As String = ""

        If mode = "Simple Message" Then
            finalMessage = body
        ElseIf mode = "With Name (English)" Then
            finalMessage = "Goodday Mr/Mrs " + name + "! " + body
        ElseIf mode = "With Name (Tagalog)" Then
            finalMessage = "Magandang Mr/Mrs " + name + "! " + body
        ElseIf mode = "With Seat Number (English)" Then
            finalMessage = "Goodday Mr/Mrs " + name + "! " + body + " Your seatnumber is " + seatNum + "."
        ElseIf mode = "With Seat Number (Tagalog)" Then
            finalMessage = "Magandang Mr/Mrs " + name + "! " + body + "Ang numero ng iyong upuan ay " + seatNum + "."
        End If

        If header <> "" Then
            finalMessage = header + vbCrLf + vbCrLf + finalMessage
        End If

        Return finalMessage
    End Function

    Public Sub _saveMode(ByVal selectedControl_Sim As String, ByVal mode As String, ByVal header As String, ByVal body As String)
        If selectedControl_Sim = "1" Then
            frm_Main.frmmessage.Control_SMS1.Control_SIM11.mode = mode
            frm_Main.frmmessage.Control_SMS1.Control_SIM11.header = header
            frm_Main.frmmessage.Control_SMS1.Control_SIM11.body = body

            frm_Main.frmmessage.Control_SMS1.Control_SIM11.message_TB.Text = _formatFinalMessage(mode, header, body, frm_Main.frmmessage.Control_SMS1.Control_SIM11.recipient_Name, frm_Main.frmmessage.Control_SMS1.Control_SIM11.recipient_SeatNum)

        ElseIf selectedControl_Sim = "2" Then
            'frm_Main.frmmessage.Control_SMS1.Control_SIM21.mode = mode
            'frm_Main.frmmessage.Control_SMS1.Control_SIM21.header = header
            'frm_Main.frmmessage.Control_SMS1.Control_SIM21.body = body

        ElseIf selectedControl_Sim = "3" Then
            'frm_Main.frmmessage.Control_SMS1.Control_SIM31.mode = mode
            'frm_Main.frmmessage.Control_SMS1.Control_SIM31.header = header
            'frm_Main.frmmessage.Control_SMS1.Control_SIM31.body = body

        ElseIf selectedControl_Sim = "4" Then
            'frm_Main.frmmessage.Control_SMS1.Control_SIM41.mode = mode
            'frm_Main.frmmessage.Control_SMS1.Control_SIM41.header = header
            'frm_Main.frmmessage.Control_SMS1.Control_SIM41.body = body

        ElseIf selectedControl_Sim = "5" Then
            'frm_Main.frmmessage.Control_SMS1.Control_SIM51.mode = mode
            'frm_Main.frmmessage.Control_SMS1.Control_SIM51.header = header
            'frm_Main.frmmessage.Control_SMS1.Control_SIM51.body = body

        ElseIf selectedControl_Sim = "6" Then
            'frm_Main.frmmessage.Control_SMS1.Control_SIM61.mode = mode
            'frm_Main.frmmessage.Control_SMS1.Control_SIM61.header = header
            'frm_Main.frmmessage.Control_SMS1.Control_SIM61.body = body

        ElseIf selectedControl_Sim = "7" Then
            'frm_Main.frmmessage.Control_SMS1.Control_SIM71.mode = mode
            'frm_Main.frmmessage.Control_SMS1.Control_SIM71.header = header
            'frm_Main.frmmessage.Control_SMS1.Control_SIM71.body = body

        ElseIf selectedControl_Sim = "8" Then
            'frm_Main.frmmessage.Control_SMS1.Control_SIM81.mode = mode
            'frm_Main.frmmessage.Control_SMS1.Control_SIM81.header = header
            'frm_Main.frmmessage.Control_SMS1.Control_SIM81.body = body

        End If
    End Sub

    Public Function _Validate(ByVal cpnum As String) As Boolean
        Try
            If Int64.Parse(cpnum) >= 9000000000 And Int64.Parse(cpnum) <= 9999999999 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function _sendMessage(ByVal cpnum As String, ByVal message As String, ByVal objSMS As mCore.SMS) As Boolean
        Dim isErr As Boolean = False

        Try
            objSMS.SendSMS(cpnum, message)
            isErr = False
        Catch ex As Exception
            Try
                If ex.Message = "ERROR 4018: Invalid response to submit PDU [Response: <cr><lf>+CMS ERROR: 31<cr><lf>]" Then
                    MessageBox.Show("SIM 1: Maximum Message Sent has been reached. Please try again tommorow." & vbCrLf & ex.Message, "Network Timeout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                objSMS1.Disconnect()
                objSMS1.Connect()
            Catch exx As Exception
                MessageBox.Show("Error: Sim 1 Port has been Blocked. Please restart and reinsert sim card.", "Port error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
            isErr = True
        End Try

        Return isErr
    End Function
End Class
