Public Class frm_Message
    Private Sub frm_Message_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub messageList_BTN_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles messageList_BTN.ItemClick
        Control_MessageList1.BringToFront()
    End Sub

    Private Sub deliveryStatus_BTN_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deliveryStatus_BTN.ItemClick
        Control_SMS1.BringToFront()
    End Sub
End Class