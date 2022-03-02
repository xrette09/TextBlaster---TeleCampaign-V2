Imports System.Data.SqlClient

Module SqlServer_API
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Public da As New SqlDataAdapter
    Public dset, dset2 As New DataSet

    Dim str As String


    Public konnstr_1st As String = "Data Source='" & My.Settings.Server & "';User='" & My.Settings.User & "';password='" & My.Settings.Password & "'; Initial Catalog='" & My.Settings.dbase_1st & "';"
    Public konnstr_2nd As String = "Data Source='" & My.Settings.Server & "';User='" & My.Settings.User & "';password='" & My.Settings.Password & "'; Initial Catalog='" & My.Settings.dbase_2nd & "';"
    Public konnstr_3rd As String = "Data Source='" & My.Settings.Server & "';User='" & My.Settings.User & "';password='" & My.Settings.Password & "'; Initial Catalog='" & My.Settings.dbase_3rd & "';"
    Public konnstr_textblast As String = "Data Source='" & My.Settings.Server & "';User='" & My.Settings.User & "';password='" & My.Settings.Password & "'; Initial Catalog='" & My.Settings.dbase_TextBlast & "';"

    Public konek_1st As New SqlConnection(konnstr_1st)  'Voters_3rd
    Public konek_2nd As New SqlConnection(konnstr_2nd)  'Voters_1st
    Public konek_3rd As New SqlConnection(konnstr_3rd)  'Voters_2nd
    Public konek_textblast As New SqlConnection(konnstr_textblast)  'Textblast

    ''' ================================================================================================
    ''' KONNEKSYON
    ''' ================================================================================================

    Public Sub konneksyonVoters1_DB()
        Try
            If konek_1st.State = ConnectionState.Closed Then
                konek_1st.Open() : MessageBox.Show("Voters DB Successfully Connected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch eX As Exception
            MessageBox.Show(eX.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub konneksyonVoters2_DB()
        Try
            If konek_2nd.State = ConnectionState.Closed Then
                konek_2nd.Open() : MessageBox.Show("Voters DB Successfully Connected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch eX As Exception
            MessageBox.Show(eX.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub konneksyonVoters3_DB()
        Try
            If konek_3rd.State = ConnectionState.Closed Then
                konek_3rd.Open() : MessageBox.Show("Voters DB Successfully Connected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch eX As Exception
            MessageBox.Show(eX.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub konneksyonTextBlast_DB()
        Try
            If konek_textblast.State = ConnectionState.Closed Then
                konek_textblast.Open() : MessageBox.Show("Text Blast DB Successfully Connected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch eX As Exception
            MessageBox.Show(eX.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ''' ================================================================================================
    ''' POPULATE GRID CONTROL
    ''' ================================================================================================

    Public Sub populateGridControl(ByVal sql As String, ByVal konnek As SqlConnection, ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
        da = New SqlDataAdapter(sql, konnek)

        dset = New DataSet
        da.Fill(dset, sql)
        gridControl.DataSource = dset.Tables(sql)
        gridView.PopulateColumns()
    End Sub


End Module
