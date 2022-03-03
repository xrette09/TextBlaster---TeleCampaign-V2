Imports System.Data.SqlClient

Public Class frm_Coordinators
    Public accessedBy As String = ""

    Dim sql As String
    Dim ids As String

    Public gridControl As DevExpress.XtraGrid.GridControl
    Public gridView As DevExpress.XtraGrid.Views.Grid.GridView

    Public district As String
    Public konnek As SqlConnection

    Private Sub frm_Coordinators_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Call konneksyonVoters_DB()

        If district = "3" Then
            Call konneksyonVoters3_DB()
            konnek = konek_3rd

        ElseIf district = "2" Then
            Call konneksyonVoters2_DB()
            konnek = konek_2nd

        ElseIf district = "1" Then
            Call konneksyonVoters1_DB()
            konnek = konek_1st
        End If

        Call mun()
        Call IdCat()
    End Sub

    '/////////////////////////////////////////////////////////////////////////

    Private Sub cbmun_Enter(sender As Object, e As EventArgs) Handles cbmun.Enter
        cbmun.BackColor = Color.LightBlue
    End Sub

    Private Sub cbmun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbmun.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If cbmun.Text = "" Then
                'lblcount.Caption = "0 Record(s) found"
            Else
                Call barangay()
                Call cluster()
                cbcluster.Focus()
            End If
        End If
    End Sub

    Private Sub cbcluster_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbcluster.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call ClusteredBarangay()
            cbbrgy.Focus()
        End If
    End Sub

    Private Sub cbbrgy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbrgy.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call pr()
            cbpr.Focus()
        End If
    End Sub

    Private Sub cbpr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbpr.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnfilter.Focus()
        End If
    End Sub

    Private Sub cbmun_Leave(sender As Object, e As EventArgs) Handles cbmun.Leave
        cbmun.BackColor = Color.White
    End Sub

    Function pr() As Boolean
        'municipality
        Dim mun As String = cbmun.Properties.GetCheckedItems.ToString
        Dim b() As String = mun.Split(",")
        Dim munStr As String = ""
        For i = 0 To UBound(b)
            If i = 0 Then
                munStr = "'" & b(i) & "'"
            Else
                munStr = munStr & ",'" & LTrim(b(i)) & "'"
            End If
        Next
        'Barangay
        Dim Brgy As String = cbbrgy.Properties.GetCheckedItems.ToString
        Dim e() As String = Brgy.Split(",")
        Dim BrgyStr As String = ""
        For t = 0 To UBound(e)
            If t = 0 Then
                BrgyStr = "'" & e(t) & "'"
            Else
                BrgyStr = BrgyStr & ",'" & LTrim(e(t)) & "'"
            End If
        Next

        cbpr.Properties.Items.Clear()
        Dim comm As SqlCommand
        If district = "3" Then
            comm = New SqlCommand("select  B.precinct from tblprecinct as A " _
                                  & "inner join tblPrecinctDetails as B on A.PrecinctID=B.ID " _
                                  & " where BarangayID in (Select ID from tblBarangay where Barangay=" & BrgyStr & ") " _
                                  & "and MunicipalityID in (select ID from tblMunicipality where Municipality in (" & munStr & "))", konek_3rd)
        ElseIf district = "2" Then
            comm = New SqlCommand("select  B.precinct from tblprecinct as A " _
                                  & "inner join tblPrecinctDetails as B on A.PrecinctID=B.ID " _
                                  & " where BarangayID in (Select ID from tblBarangay where Barangay=" & BrgyStr & ") " _
                                  & "and MunicipalityID in (select ID from tblMunicipality where Municipality in (" & munStr & "))", konek_2nd)
        ElseIf district = "1" Then
            comm = New SqlCommand("select  B.precinct from tblprecinct as A " _
                                  & "inner join tblPrecinctDetails as B on A.PrecinctID=B.ID " _
                                  & " where BarangayID in (Select ID from tblBarangay where Barangay=" & BrgyStr & ") " _
                                  & "and MunicipalityID in (select ID from tblMunicipality where Municipality in (" & munStr & "))", konek_1st)
        End If

        Dim dset = New DataSet
        dset.Load(comm.ExecuteReader, LoadOption.OverwriteChanges, "pr")
        For x As Integer = 0 To dset.Tables("pr").Rows.Count - 1
            cbpr.Properties.Items.Add(dset.Tables("pr").Rows(x).ItemArray(0).ToString)
        Next
        Return True
    End Function

    Function barangay() As Boolean
        'municipality
        Dim mun As String = cbmun.Properties.GetCheckedItems.ToString
        Dim b() As String = mun.Split(",")
        Dim munStr As String = ""
        For i = 0 To UBound(b)
            If i = 0 Then
                munStr = "'" & b(i) & "'"
            Else
                munStr = munStr & ",'" & LTrim(b(i)) & "'"
            End If
        Next

        MsgBox(munStr)

        'Call konneksyonVoters_DB()
        cbbrgy.Properties.Items.Clear()

        Dim comm As SqlCommand
        If district = "3" Then
            comm = New SqlCommand("select  A.Barangay from tblBarangay as A " _
                                  & "inner join tblCluster as B on A.ID=b.BarangayID " _
                                  & "where MunicipalityID in (select ID from tblMunicipality where Municipality in (" & munStr & ")) order by MunicipalityID asc", konek_3rd)
        ElseIf district = "2" Then
            comm = New SqlCommand("select  A.Barangay from tblBarangay as A " _
                                  & "inner join tblCluster as B on A.ID=b.BarangayID " _
                                  & "where MunicipalityID in (select ID from tblMunicipality where Municipality in (" & munStr & ")) order by MunicipalityID asc", konek_2nd)
        ElseIf district = "1" Then
            comm = New SqlCommand("select  A.Barangay from tblBarangay as A " _
                                  & "inner join tblCluster as B on A.ID=b.BarangayID " _
                                  & "where MunicipalityID in (select ID from tblMunicipality where Municipality in (" & munStr & ")) order by MunicipalityID asc", konek_1st)
        End If

        Dim dset = New DataSet
        dset.Load(comm.ExecuteReader, LoadOption.OverwriteChanges, "brgy")
        For x As Integer = 0 To dset.Tables("brgy").Rows.Count - 1
            cbbrgy.Properties.Items.Add(dset.Tables("brgy").Rows(x).ItemArray(0).ToString)
        Next
        Return True
    End Function

    Function ClusteredBarangay() As Boolean
        'municipality
        Dim mun As String = cbmun.Properties.GetCheckedItems.ToString
        Dim b() As String = mun.Split(",")
        Dim munStr As String = ""
        For i = 0 To UBound(b)
            If i = 0 Then
                munStr = "'" & b(i) & "'"
            Else
                munStr = munStr & ",'" & LTrim(b(i)) & "'"
            End If
        Next
        'Cluster
        Dim Cluster As String = cbcluster.Properties.GetCheckedItems.ToString
        Dim q() As String = Cluster.Split(",")
        Dim ClusterStr As String = ""
        For r = 0 To UBound(q)
            If r = 0 Then
                ClusterStr = "'" & q(r) & "'"
            Else
                ClusterStr = ClusterStr & ",'" & LTrim(q(r)) & "'"
            End If
        Next
        'Call konneksyonVoters_DB()
        cbbrgy.Properties.Items.Clear()

        Dim comm As SqlCommand
        If district = "3" Then
            comm = New SqlCommand("select A.Barangay from tblBarangay as A " _
                                  & "inner join tblCluster as B on A.ID=b.BarangayID " _
                                  & "where b.clusterID in (select ID from tblclusterDetails where Cluster in (" & ClusterStr & ")) and " _
                                  & "MunicipalityID in (select ID from tblMunicipality where Municipality in (" & munStr & ")) order by MunicipalityID asc", konek_3rd)
        ElseIf district = "2" Then
            comm = New SqlCommand("select A.Barangay from tblBarangay as A " _
                                  & "inner join tblCluster as B on A.ID=b.BarangayID " _
                                  & "where b.clusterID in (select ID from tblclusterDetails where Cluster in (" & ClusterStr & ")) and " _
                                  & "MunicipalityID in (select ID from tblMunicipality where Municipality in (" & munStr & ")) order by MunicipalityID asc", konek_2nd)
        ElseIf district = "1" Then
            comm = New SqlCommand("select A.Barangay from tblBarangay as A " _
                                  & "inner join tblCluster as B on A.ID=b.BarangayID " _
                                  & "where b.clusterID in (select ID from tblclusterDetails where Cluster in (" & ClusterStr & ")) and " _
                                  & "MunicipalityID in (select ID from tblMunicipality where Municipality in (" & munStr & ")) order by MunicipalityID asc", konek_1st)
        End If

        Dim dset = New DataSet
        dset.Load(comm.ExecuteReader, LoadOption.OverwriteChanges, "brgy")
        For x As Integer = 0 To dset.Tables("brgy").Rows.Count - 1
            cbbrgy.Properties.Items.Add(dset.Tables("brgy").Rows(x).ItemArray(0).ToString)
        Next
        Return True
    End Function

    Function mun() As Boolean
        'Call konneksyonVoters_DB()
        cbmun.Properties.Items.Clear()

        Dim comm As SqlCommand
        If district = "3" Then
            comm = New SqlCommand("select * from tblMunicipality where ID<>1", konek_3rd)
        ElseIf district = "2" Then
            comm = New SqlCommand("select * from tblMunicipality where ID<>1", konek_2nd)
        ElseIf district = "1" Then
            comm = New SqlCommand("select * from tblMunicipality where ID<>1", konek_1st)
        End If

        Dim dset = New DataSet
        dset.Load(comm.ExecuteReader, LoadOption.OverwriteChanges, "mun")
        For x As Integer = 0 To dset.Tables("mun").Rows.Count - 1
            cbmun.Properties.Items.Add(dset.Tables("mun").Rows(x).ItemArray(1).ToString)
        Next
        Return True
    End Function

    Function IdCat() As Boolean
        'Call konneksyonVoters_DB()
        ckIdcat.Items.Clear()

        Dim comm As SqlCommand
        If district = "3" Then
            comm = New SqlCommand("select * from tblCategory where ID<>1", konek_3rd)
        ElseIf district = "2" Then
            comm = New SqlCommand("select * from tblCategory where ID<>1", konek_2nd)
        ElseIf district = "1" Then
            comm = New SqlCommand("select * from tblCategory where ID<>1", konek_1st)
        End If

        Dim dset = New DataSet
        dset.Load(comm.ExecuteReader, LoadOption.OverwriteChanges, "cat")
        For x As Integer = 0 To dset.Tables("cat").Rows.Count - 1
            ckIdcat.Items.Add(dset.Tables("cat").Rows(x).ItemArray(1).ToString)
        Next
        Return True
    End Function

    Function cluster() As Boolean
        Dim mun As String = cbmun.Properties.GetCheckedItems.ToString
        Dim b() As String = mun.Split(",")
        Dim munStr As String = ""
        For i = 0 To UBound(b)
            If i = 0 Then
                munStr = "'" & b(i) & "'"
            Else
                munStr = munStr & ",'" & LTrim(b(i)) & "'"
            End If
        Next
        cbcluster.Properties.Items.Clear()

        Dim comm As SqlCommand
        If district = "3" Then
            comm = New SqlCommand("select Distinct B.Cluster from tblcluster as A inner join tblClusterDetails as B on A.ClusterID=B.ID" &
                                  " where MunicipalityID in (Select ID from tblmunicipality where Municipality in (" & munStr & "))", konek_3rd)
        ElseIf district = "2" Then
            comm = New SqlCommand("select Distinct B.Cluster from tblcluster as A inner join tblClusterDetails as B on A.ClusterID=B.ID" &
                                  " where MunicipalityID in (Select ID from tblmunicipality where Municipality in (" & munStr & "))", konek_2nd)
        ElseIf district = "1" Then
            comm = New SqlCommand("select Distinct B.Cluster from tblcluster as A inner join tblClusterDetails as B on A.ClusterID=B.ID" &
                                  " where MunicipalityID in (Select ID from tblmunicipality where Municipality in (" & munStr & "))", konek_1st)
        End If
        Dim dset = New DataSet
        dset.Load(comm.ExecuteReader, LoadOption.OverwriteChanges, "cluster")
        For x As Integer = 0 To dset.Tables("cluster").Rows.Count - 1
            cbcluster.Properties.Items.Add(dset.Tables("cluster").Rows(x).ItemArray(0).ToString)
        Next
        Return True
    End Function

    Private Sub cbcluster_Enter(sender As Object, e As EventArgs) Handles cbcluster.Enter
        cbcluster.BackColor = Color.LightBlue
    End Sub

    Private Sub cbcluster_Leave(sender As Object, e As EventArgs) Handles cbcluster.Leave
        cbcluster.BackColor = Color.White
    End Sub

    Private Sub cbbrgy_Enter(sender As Object, e As EventArgs) Handles cbbrgy.Enter
        cbbrgy.BackColor = Color.LightBlue
    End Sub

    Private Sub cbbrgy_Leave(sender As Object, e As EventArgs) Handles cbbrgy.Leave
        cbbrgy.BackColor = Color.White
    End Sub

    Function filterCoor() As Boolean
        Try

            Dim idcat As String = ""
            Dim b(), x, y(), q(), e(), f() As String
            If ckIdcat.CheckedItems.Count > 0 Then
                For a As Integer = 0 To ckIdcat.CheckedItems.Count - 1
                    idcat += ckIdcat.CheckedItems(a) & ", "
                Next

            End If

            'municipality
            Dim mun As String = cbmun.Properties.GetCheckedItems.ToString
            b = mun.Split(",")
            Dim munStr As String = ""
            For i = 0 To UBound(b)
                If i = 0 Then
                    munStr = "'" & b(i) & "'"
                Else
                    munStr = munStr & ",'" & LTrim(b(i)) & "'"
                End If
            Next

            'ID Category
            x = idcat.Substring(0, idcat.Length - 2)
            y = x.Split(",")
            Dim idcatStr As String = ""
            For z = 0 To UBound(y)
                If z = 0 Then
                    idcatStr = "'" & y(z) & "'"
                Else
                    idcatStr = idcatStr & ",'" & LTrim(y(z)) & "'"
                End If
            Next

            'Cluster
            Dim Cluster As String = cbcluster.Properties.GetCheckedItems.ToString
            q = Cluster.Split(",")
            Dim ClusterStr As String = ""
            For r = 0 To UBound(q)
                If r = 0 Then
                    ClusterStr = "'" & q(r) & "'"
                Else
                    ClusterStr = ClusterStr & ",'" & LTrim(q(r)) & "'"
                End If
            Next

            'Barangay
            Dim Brgy As String = cbbrgy.Properties.GetCheckedItems.ToString
            e = Brgy.Split(",")
            Dim BrgyStr As String = ""
            For t = 0 To UBound(e)
                If t = 0 Then
                    BrgyStr = "'" & e(t) & "'"
                Else
                    BrgyStr = BrgyStr & ",'" & LTrim(e(t)) & "'"
                End If
            Next

            'Precinct
            Dim pr As String = cbpr.Properties.GetCheckedItems.ToString
            f = pr.Split(",")
            Dim prStr As String = ""
            For u = 0 To UBound(f)
                If u = 0 Then
                    prStr = "'" & f(u) & "'"
                Else
                    prStr = prStr & ",'" & LTrim(f(u)) & "'"
                End If
            Next

            If cbmun.Text <> "" And cbcluster.Text = "" _
                And cbbrgy.Text = "" And cbpr.Text = "" Then
                sql = "select A.ID,B.Cluster,C.Barangay,A.Name,A.BirthDate,D.Category,A.CpNo,E.Precinct," _
                        & "G.Municipality from tblvoters as A" _
                        & " inner join tblClusterDetails as B on A.ClusterID=B.ID" _
                        & " inner join tblbarangay as C on A.BarangayID=C.ID" _
                        & " inner join tblcategory as D on A.CatID=D.ID" _
                        & " inner join tblprecinctdetails as E on A.PrecinctID=E.ID" _
                        & " inner join tblmunicipality as G on A.MunicipalityID=G.ID" _
                        & " where CatID in (Select ID from tblcategory where Category in (" & idcatStr & ")) and " _
                        & " MunicipalityID in (select ID from tblMunicipality where Municipality in (" & munStr & ")) " _
                        & " and Deceased=0 order by cluster,case CatID when 2 then 1 when 3 then 2 when 4 then 3 " _
                        & " when 5 then 4  when 6 then 5  when 7 then 6  when 8 then 7" _
                        & " when 9 then 8  when 10 then 9  when 11 then 10  when 12 then 11" _
                        & " when 13 then 12  when 1002 then 13 else 14 end ,Barangay,Name asc"
                Call populateGridControl(sql, konnek, Coordinator_GC, Coordinator_GV)
            ElseIf cbmun.Text <> "" And cbcluster.Text <> "" _
            And cbbrgy.Text = "" And cbpr.Text = "" Then
                sql = "select A.ID,B.Cluster,C.Barangay,A.Name,A.BirthDate,D.Category,A.CpNo,E.Precinct," _
                        & "G.Municipality from tblvoters as A" _
                        & " inner join tblClusterDetails as B on A.ClusterID=B.ID" _
                        & " inner join tblbarangay as C on A.BarangayID=C.ID" _
                        & " inner join tblcategory as D on A.CatID=D.ID" _
                        & " inner join tblprecinctdetails as E on A.PrecinctID=E.ID" _
                        & " inner join tblmunicipality as G on A.MunicipalityID=G.ID" _
                        & " where CatID in (Select ID from tblcategory where Category in (" & idcatStr & ")) and " _
                        & " ClusterID in (Select ID from tblClusterDetails where Cluster in (" & ClusterStr & ")) and " _
                        & " MunicipalityID in (select ID from tblMunicipality where Municipality in (" & munStr & ")) " _
                        & " and Deceased=0 order by  cluster,case CatID when 2 then 1 when 3 then 2 when 4 then 3 " _
                        & " when 5 then 4  when 6 then 5  when 7 then 6  when 8 then 7" _
                        & " when 9 then 8  when 10 then 9  when 11 then 10  when 12 then 11" _
                        & " when 13 then 12  when 1002 then 13 else 14 end,Barangay,Name asc"
                Call populateGridControl(sql, konnek, Coordinator_GC, Coordinator_GV)
            ElseIf cbmun.Text <> "" And cbcluster.Text <> "" _
             And cbbrgy.Text <> "" And cbpr.Text = "" Then
                sql = "select A.ID,B.Cluster,C.Barangay,A.Name,A.BirthDate,D.Category,A.CpNo,E.Precinct," _
                        & "G.Municipality from tblvoters as A" _
                        & " inner join tblClusterDetails as B on A.ClusterID=B.ID" _
                        & " inner join tblbarangay as C on A.BarangayID=C.ID" _
                        & " inner join tblcategory as D on A.CatID=D.ID" _
                        & " inner join tblprecinctdetails as E on A.PrecinctID=E.ID" _
                        & " inner join tblmunicipality as G on A.MunicipalityID=G.ID" _
                        & " where CatID in (Select ID from tblcategory where Category in (" & idcatStr & ")) and " _
                        & " ClusterID in (Select ID from tblClusterDetails where Cluster in (" & ClusterStr & ")) and " _
                        & " BarangayID in (Select ID from tblBarangay where Barangay in (" & BrgyStr & ")) and " _
                        & " MunicipalityID in (select ID from tblMunicipality where Municipality in (" & munStr & ")) " _
                        & " and Deceased=0 order by  cluster,case CatID when 2 then 1 when 3 then 2 when 4 then 3 " _
                        & " when 5 then 4  when 6 then 5  when 7 then 6  when 8 then 7" _
                        & " when 9 then 8  when 10 then 9  when 11 then 10  when 12 then 11" _
                        & " when 13 then 12  when 1002 then 13 else 14 end,Barangay,Name asc"
                Call populateGridControl(sql, konnek, Coordinator_GC, Coordinator_GV)
            ElseIf cbmun.Text <> "" And cbcluster.Text = "" _
                  And cbbrgy.Text <> "" And cbpr.Text = "" Then
                sql = "select A.ID,B.Cluster,C.Barangay,A.Name,A.BirthDate,D.Category,A.CpNo,E.Precinct," _
                          & "G.Municipality from tblvoters as A" _
                          & " inner join tblClusterDetails as B on A.ClusterID=B.ID" _
                          & " inner join tblbarangay as C on A.BarangayID=C.ID" _
                          & " inner join tblcategory as D on A.CatID=D.ID" _
                          & " inner join tblprecinctdetails as E on A.PrecinctID=E.ID" _
                          & " inner join tblmunicipality as G on A.MunicipalityID=G.ID" _
                          & " where CatID in (Select ID from tblcategory where Category in (" & idcatStr & ")) and " _
                          & " BarangayID in (Select ID from tblBarangay where Barangay in (" & BrgyStr & ")) and " _
                          & " MunicipalityID in (select ID from tblMunicipality where Municipality in (" & munStr & ")) " _
                          & " and Deceased=0 order by cluster,case CatID when 2 then 1 when 3 then 2 when 4 then 3 " _
                          & " when 5 then 4  when 6 then 5  when 7 then 6  when 8 then 7" _
                          & " when 9 then 8  when 10 then 9  when 11 then 10  when 12 then 11" _
                          & " when 13 then 12  when 1002 then 13 else 14 end,Barangay,Name  asc"
                Call populateGridControl(sql, konnek, Coordinator_GC, Coordinator_GV)
            ElseIf cbmun.Text <> "" And cbcluster.Text = "" _
                And cbbrgy.Text <> "" And cbpr.Text <> "" Then
                sql = "select A.ID,B.Cluster,C.Barangay,A.Name,A.BirthDate,D.Category,A.CpNo,E.Precinct," _
                        & "G.Municipality from tblvoters as A" _
                        & " inner join tblClusterDetails as B on A.ClusterID=B.ID" _
                        & " inner join tblbarangay as C on A.BarangayID=C.ID" _
                        & " inner join tblcategory as D on A.CatID=D.ID" _
                        & " inner join tblprecinctdetails as E on A.PrecinctID=E.ID" _
                        & " inner join tblmunicipality as G on A.MunicipalityID=G.ID" _
                        & " where CatID in (Select ID from tblcategory where Category in (" & idcatStr & ")) and " _
                        & " BarangayID in (Select ID from tblBarangay where Barangay in (" & BrgyStr & ")) and " _
                        & " MunicipalityID in (select ID from tblMunicipality where Municipality in (" & munStr & ")) and" _
                        & " PrecinctID in (select ID from tblPrecinctDetails where Precinct in (" & prStr & ")) " _
                        & " and Deceased=0 order by cluster,case CatID when 2 then 1 when 3 then 2 when 4 then 3 " _
                        & " when 5 then 4  when 6 then 5  when 7 then 6  when 8 then 7" _
                        & " when 9 then 8  when 10 then 9  when 11 then 10  when 12 then 11" _
                        & " when 13 then 12  when 1002 then 13 else 14 end,Barangay,Name  asc"
                Call populateGridControl(sql, konnek, Coordinator_GC, Coordinator_GV)
            ElseIf cbmun.Text = "" And cbcluster.Text = "" _
                And cbbrgy.Text = "" And cbpr.Text = "" Then
                sql = "select A.ID,B.Cluster,C.Barangay,A.Name,A.BirthDate,D.Category,A.CpNo,E.Precinct," _
                              & "G.Municipality from tblvoters as A" _
                              & " inner join tblClusterDetails as B on A.ClusterID=B.ID" _
                              & " inner join tblbarangay as C on A.BarangayID=C.ID" _
                              & " inner join tblcategory as D on A.CatID=D.ID" _
                              & " inner join tblprecinctdetails as E on A.PrecinctID=E.ID" _
                              & " inner join tblmunicipality as G on A.MunicipalityID=G.ID" _
                              & " where CatID in (Select ID from tblcategory where Category in (" & idcatStr & ")) " _
                              & " and Deceased=0 order by cluster,case CatID when 2 then 1 when 3 then 2 when 4 then 3 " _
                              & " when 5 then 4  when 6 then 5  when 7 then 6  when 8 then 7" _
                              & " when 9 then 8  when 10 then 9  when 11 then 10  when 12 then 11" _
                              & " when 13 then 12  when 1002 then 13 else 14 end,Barangay,Name  asc"
                Call populateGridControl(sql, konnek, Coordinator_GC, Coordinator_GV)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function

    Private Sub cbpr_Enter(sender As Object, e As EventArgs) Handles cbpr.Enter
        cbpr.BackColor = Color.LightBlue
    End Sub

    Private Sub cbpr_Leave(sender As Object, e As EventArgs) Handles cbpr.Leave
        cbpr.BackColor = Color.White
    End Sub

    Private Sub btnfilter_Click(sender As Object, e As EventArgs) Handles btnfilter.Click
        filterCoor()
        BarStaticItem1.Caption = "Total Count: " & Coordinator_GV.RowCount
    End Sub

    Private Sub Coordinator_GV_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles Coordinator_GV.SelectionChanged
        BarStaticItem2.Caption = "Total Selected: " & Coordinator_GV.SelectedRowsCount
    End Sub

    Private Sub frm_Coordinators_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Coordinator_GC.DataSource = Nothing
        Coordinator_GV.Columns.Clear()
    End Sub

    Private Sub SelectAsMessageRecipientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAsMessageRecipientToolStripMenuItem.Click
        ids = ""
        For Each rowNum In Coordinator_GV.GetSelectedRows
            ids = ids + Coordinator_GV.GetDataRow(rowNum)(0).ToString + ", "
        Next

        sql = "select A.ID,B.Municipality,C.Cluster AS CNo, D.Barangay, G.Purok, A.Name, A.NickNameID as NickName, A.BirthDate, DATEDIFF(YY,A.BirthDate,Getdate()) as Age, A.CpNo, E.Category as IDCat, F.Precinct as PrNo, A.ValidVoter, A.AddbyUser, A.Deceased from tblvoters as A
                                        inner join tblmunicipality as B on A.MunicipalityID=B.ID
                                        inner join tblClusterDetails as C on A.ClusterID=C.ID
                                        inner join tblbarangay as D on A.BarangayID=D.ID
                                        inner join tblcategory as E on A.CatID=E.ID 
                                        inner join tblPrecinctDetails as F on A.PrecinctID=F.ID
                                        inner join tblPurok as G on A.PurokID=G.ID  where A.ID in (" + ids.Substring(0, ids.Length - 2) + ") "

        If district = "1" Then
            Call populateGridControl(sql, konek_1st, gridControl, gridView)

        ElseIf district = "2" Then
            Call populateGridControl(sql, konek_2nd, gridControl, gridView)

        ElseIf district = "3" Then
            Call populateGridControl(sql, konek_3rd, gridControl, gridView)

        End If
    End Sub

End Class