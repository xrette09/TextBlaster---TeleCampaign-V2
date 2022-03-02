Public Class control_SIM1

    Dim mode As String = ""
    Dim header As String = ""
    Dim message As String = ""

    Dim recipient_CpNo As String = ""
    Dim recipient_Name As String = ""
    Dim recipient_SeatNum As String = ""

    Private Sub control_SIM1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub message_TB_Click(sender As Object, e As EventArgs) Handles message_TB.Click
        frm_ComposeMessage.ShowDialog()
    End Sub

    Private Sub StDistrictToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StDistrictToolStripMenuItem.Click
        frm_Coordinators.district = "1"
        frm_Coordinators.gridControl = Me.SimGC
        frm_Coordinators.gridView = Me.SimGV
        frm_Coordinators.ShowDialog()
    End Sub

    Private Sub NdDistrictToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NdDistrictToolStripMenuItem.Click
        frm_Coordinators.district = "2"
        frm_Coordinators.gridControl = Me.SimGC
        frm_Coordinators.gridView = Me.SimGV
        frm_Coordinators.ShowDialog()
    End Sub

    Private Sub RdDistrictToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RdDistrictToolStripMenuItem.Click
        frm_Coordinators.district = "3"
        frm_Coordinators.gridControl = Me.SimGC
        frm_Coordinators.gridView = Me.SimGV
        frm_Coordinators.ShowDialog()
    End Sub
End Class
