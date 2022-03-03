Imports mCore

Module TextBlast_API
    Public asdstr As String = "TEXTBLASTER v1.0" & vbCrLf & vbCrLf

#Disable Warning IDE1006 ' Naming Styles
    Public WithEvents objSMS1 As New mCore.SMS : Public objInbox1 As mCore.Inbox
    Public WithEvents objSMS2 As New mCore.SMS : Public objInbox2 As mCore.Inbox
    Public WithEvents objSMS3 As New mCore.SMS : Public objInbox3 As mCore.Inbox
    Public WithEvents objSMS4 As New mCore.SMS : Public objInbox4 As mCore.Inbox
    Public WithEvents objSMS5 As New mCore.SMS : Public objInbox5 As mCore.Inbox
    Public WithEvents objSMS6 As New mCore.SMS : Public objInbox6 As mCore.Inbox
    Public WithEvents objSMS7 As New mCore.SMS : Public objInbox7 As mCore.Inbox
    Public WithEvents objSMS8 As New mCore.SMS : Public objInbox8 As mCore.Inbox

    Public sim1_status As Boolean = False : Public sim1_isLimit As Boolean = False
    Public sim2_status As Boolean = False : Public sim2_isLimit As Boolean = False
    Public sim3_status As Boolean = False : Public sim3_isLimit As Boolean = False
    Public sim4_status As Boolean = False : Public sim4_isLimit As Boolean = False
    Public sim5_status As Boolean = False : Public sim5_isLimit As Boolean = False
    Public sim6_status As Boolean = False : Public sim6_isLimit As Boolean = False
    Public sim7_status As Boolean = False : Public sim7_isLimit As Boolean = False
    Public sim8_status As Boolean = False : Public sim8_isLimit As Boolean = False


    ReadOnly ISMS As New SMS

    Public Sub konTextBlast()
        frm_Main.Enabled = False
        'frm_Main.SplashScreenManager1.ShowWaitForm()
        sim1_status = konSim(objSMS1, My.Settings.sim1Port)
        sim2_status = konSim(objSMS2, My.Settings.sim2Port)
        sim3_status = konSim(objSMS3, My.Settings.sim3Port)
        sim4_status = konSim(objSMS4, My.Settings.sim4Port)
        sim5_status = konSim(objSMS5, My.Settings.sim5Port)
        sim6_status = konSim(objSMS6, My.Settings.sim6Port)
        sim7_status = konSim(objSMS7, My.Settings.sim7Port)
        sim8_status = konSim(objSMS8, My.Settings.sim8Port)
        'frm_Main.SplashScreenManager1.CloseWaitForm()
        frm_Main.Enabled = True

        MsgBox("SIM 1 Availability: " & sim1_status & vbCrLf & "SIM 2 Availability: " & sim2_status & vbCrLf &
               "SIM 3 Availability: " & sim3_status & vbCrLf & "SIM 4 Availability: " & sim4_status & vbCrLf &
               "SIM 5 Availability: " & sim5_status & vbCrLf & "SIM 6 Availability: " & sim6_status & vbCrLf &
               "SIM 7 Availability: " & sim7_status & vbCrLf & "SIM 8 Availability: " & sim8_status)
    End Sub

    ''' ================================================================================================
    ''' Configure Each Sim
    ''' ================================================================================================

    Public Function konSim(objSMS As mCore.SMS, comPort As String) As Boolean
        Dim sim_status As Boolean

        Try
            objSMS.License.Company = "INNOVEZ ONE"
            objSMS.License.LicenseType = "PRO-DISTRIBUTION"
            objSMS.License.Key = "DV5F-5H89-V4L2-NCHN"
            objSMS.DisableCheckPIN = True

            objSMS.Port = comPort
            objSMS.BaudRate = CType(CInt("115200"), mCore.BaudRate)
            objSMS.DataBits = CType(CInt("8"), mCore.DataBits)
            objSMS.Parity = CType("0", mCore.Parity)
            'objSMS.StopBits = 1

            objSMS1.Connect()
            sim_status = True
        Catch ex As Exception
            sim_status = False
        End Try

        Return sim_status
    End Function

    Public Sub konSim1()
        Try
            objSMS1.License.Company = "INNOVEZ ONE"
            objSMS1.License.LicenseType = "PRO-DISTRIBUTION"
            objSMS1.License.Key = "DV5F-5H89-V4L2-NCHN"
            objSMS1.DisableCheckPIN = True

            objSMS1.Port = My.Settings.sim1Port
            objSMS1.BaudRate = CType(CInt("115200"), mCore.BaudRate)
            objSMS1.DataBits = CType(CInt("8"), mCore.DataBits)
            objSMS1.Parity = CType("0", mCore.Parity)
            'objSMS1.StopBits = 1

            objSMS1.Connect()
            sim1_status = True
        Catch ex As Exception
            sim1_status = False
        End Try
    End Sub

    Public Sub konSim2()
        Try
            objSMS2.License.Company = "INNOVEZ ONE"
            objSMS2.License.LicenseType = "PRO-DISTRIBUTION"
            objSMS2.License.Key = "DV5F-5H89-V4L2-NCHN"
            objSMS2.DisableCheckPIN = True

            objSMS2.Port = My.Settings.sim2Port
            objSMS2.BaudRate = CType(CInt("115200"), mCore.BaudRate)
            objSMS2.DataBits = CType(CInt("8"), mCore.DataBits)
            objSMS2.Parity = CType("0", mCore.Parity)
            'objSMS1.StopBits = 1

            objSMS2.Connect()
            sim2_status = True
        Catch ex As Exception
            sim2_status = False
        End Try
    End Sub

    Public Sub konSim3()
        Try
            objSMS3.License.Company = "INNOVEZ ONE"
            objSMS3.License.LicenseType = "PRO-DISTRIBUTION"
            objSMS3.License.Key = "DV5F-5H89-V4L2-NCHN"
            objSMS3.DisableCheckPIN = True

            objSMS3.Port = My.Settings.sim3Port
            objSMS3.BaudRate = CType(CInt("115200"), mCore.BaudRate)
            objSMS3.DataBits = CType(CInt("8"), mCore.DataBits)
            objSMS3.Parity = CType("0", mCore.Parity)
            'objSMS1.StopBits = 1

            objSMS3.Connect()
            sim3_status = True
        Catch ex As Exception
            sim3_status = False
        End Try
    End Sub

    Public Sub konSim4()
        Try
            objSMS4.License.Company = "INNOVEZ ONE"
            objSMS4.License.LicenseType = "PRO-DISTRIBUTION"
            objSMS4.License.Key = "DV5F-5H89-V4L2-NCHN"
            objSMS4.DisableCheckPIN = True

            objSMS4.Port = My.Settings.sim4Port
            objSMS4.BaudRate = CType(CInt("115200"), mCore.BaudRate)
            objSMS4.DataBits = CType(CInt("8"), mCore.DataBits)
            objSMS4.Parity = CType("0", mCore.Parity)
            'objSMS1.StopBits = 1

            objSMS4.Connect()
            sim4_status = True
        Catch ex As Exception
            sim4_status = False
        End Try
    End Sub

    ''' ================================================================================================
    ''' Get Sim Number
    ''' ================================================================================================

    Function sim1_Number() As String
        Try
            Return objSMS1.OwnNumber

        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "asd")
            Return ""
        End Try
    End Function

    Function sim2_Number() As String
        Try
            Return objSMS2.OwnNumber
        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "asd")
            Return ""
        End Try
    End Function

    Function sim3_Number() As String
        Try
            Return objSMS3.OwnNumber
        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "asd")
            Return ""
        End Try
    End Function

    Function sim4_Number() As String
        Try
            Return objSMS4.OwnNumber
        Catch ex As mCore.GeneralException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "asd")
            Return ""
        End Try
    End Function

    ''' ================================================================================================
    ''' Set Sim to Received Message
    ''' ================================================================================================

    Public Sub configReceiveMessage()
        If sim1_status = True Then
            objSMS1.AutoDeleteNewMessage = True
            objSMS1.NewMessageIndication = True

        End If

        If sim2_status = True Then
            objSMS2.AutoDeleteNewMessage = True
            objSMS2.NewMessageIndication = True

        End If

        If sim3_status = True Then
            objSMS3.AutoDeleteNewMessage = True
            objSMS3.NewMessageIndication = True

        End If

        If sim4_status = True Then
            objSMS4.AutoDeleteNewMessage = True
            objSMS4.NewMessageIndication = True

        End If
    End Sub

    ''' ================================================================================================
    ''' When new message is Received Save to Database
    ''' ================================================================================================

    Private Sub objSMS1_NewMessageReceived(sender As Object, e As NewMessageReceivedEventArgs) Handles objSMS1.NewMessageReceived
        'ISMS.saveMessage_to_Inbox(e.Phone, e.TextMessage)
    End Sub

    Private Sub objSMS2_NewMessageReceived(sender As Object, e As NewMessageReceivedEventArgs) Handles objSMS2.NewMessageReceived
        'ISMS.saveMessage_to_Inbox(e.Phone, e.TextMessage)
    End Sub

    Private Sub objSMS3_NewMessageReceived(sender As Object, e As NewMessageReceivedEventArgs) Handles objSMS3.NewMessageReceived
        'ISMS.saveMessage_to_Inbox(e.Phone, e.TextMessage)
    End Sub

    Private Sub objSMS4_NewMessageReceived(sender As Object, e As NewMessageReceivedEventArgs) Handles objSMS4.NewMessageReceived
        'ISMS.saveMessage_to_Inbox(e.Phone, e.TextMessage)
    End Sub

#Enable Warning IDE1006 ' Naming Styles
End Module
