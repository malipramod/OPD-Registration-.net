Imports System.Data.SqlClient
Public Class frmPatientDetails
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim str As String
    Public token As Integer

    Sub BindGrid()
        str = ""
        str = "SELECT PID,TokenNo, FirstName, MiddleName, LastName, Gender, Age, City FROM PatientMaster"
        da = New SqlDataAdapter(str, con)
        ds = New DataSet()
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DGPatientMaster.DataSource = ds.Tables(0)
        Else
            DGPatientMaster.DataSource = System.DBNull.Value.ToString()
        End If
    End Sub

    Private Sub frmDonorDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.ConStr)
        con.Open()
        BindGrid()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New FrmPatientRegistration
        frm.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If var <> "" Then
            Dim frm As New FrmEditPatientRegistration
            frm.ShowDialog()
            BindGrid()
        Else
            MsgBox("Please Select any Record to Perform this operation", MsgBoxStyle.Critical, "Please Select a Reocrd")
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If var <> "" Then
            Dim m = MessageBox.Show("Are You Sure ? ", "Patient Master", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If m = Windows.Forms.DialogResult.Yes Then
                str = ""
                str = "Delete From PatientMaster where PID = '" + var + "'"
                cmd = New SqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Your Record is Deleted", "Patient Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BindGrid()
                var = ""
            End If
            If m = Windows.Forms.DialogResult.No Then
                MessageBox.Show("Operation is cancelled by user", "Patient Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                var = ""
            End If
        Else
            MessageBox.Show("Please select any row to delete.", "Patient Master", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            var = ""
        End If
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        If cmbSearchBy.Text.Equals("First Name") Then
            If txtsearch.Text <> "" Then
                str = ""
                str = "Select *from PatientMaster where FirstName like '%" + txtsearch.Text + "%'"
                da = New SqlDataAdapter(str, con)
                ds = New DataSet
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    DGPatientMaster.DataSource = ds.Tables(0)
                    DGPatientMaster.Columns(0).Visible = False
                Else
                    DGPatientMaster.DataSource = System.DBNull.Value.ToString()
                End If
            Else
                BindGrid()
            End If
        End If
    End Sub

    Private Sub DGPatientMaster_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGPatientMaster.MouseClick
        str = ""
        str = "SELECT * from PatientMaster where PID =" + DGPatientMaster.SelectedRows(0).Cells("PID").Value.ToString()
        da = New SqlDataAdapter(str, con)
        ds = New DataSet()
        da.Fill(ds)
        If (ds.Tables(0).Rows.Count > 0) Then
            testModule.var = ds.Tables(0).Rows(0)("PID").ToString()
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If token.ToString() <> "" Then
            str = ""
            str = "Select *from PatientMaster where PID=" + var.ToString() + ""
            da = New SqlDataAdapter(str, con)
            ds = New DataSet()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then

                FrmDisplay.lblNo.Text = ds.Tables(0).Rows(0)("TokenNo").ToString()
                FrmDisplay.lblguj.Text = ds.Tables(0).Rows(0)("TokenNo").ToString()
                FrmDisplay.Show()
            End If
        End If


    End Sub

    Private Sub DGPatientMaster_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGPatientMaster.CellContentClick

    End Sub

    Private Sub btnMiniMize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiniMize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        FrmOPDManagement.Show()
        Me.Close()

    End Sub
End Class
