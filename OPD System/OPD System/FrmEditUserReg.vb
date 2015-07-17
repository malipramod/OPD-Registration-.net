Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmEditUserReg
    Dim con As SqlConnection
    Dim str As String
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub


    Private Sub FrmUserReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=CC-PC\;Initial Catalog=OPDExamination;Persist Security Info=True;User ID=sa;Password=rudh012")
        con.Open()
        str = ""
        str = "Select * from UserRegMaster where RegID =" + testModule.rid.ToString()
        ds = New DataSet()
        da = New SqlDataAdapter(str, con)
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            txtUserName.Text = ds.Tables(0).Rows(0)("UserName").ToString()
            txtFirstName.Text = ds.Tables(0).Rows(0)("FirstName").ToString()
            txtMiddlename.Text = ds.Tables(0).Rows(0)("MiddleName").ToString()
            txtLastName.Text = ds.Tables(0).Rows(0)("LastName").ToString()
            txtAddress.Text = ds.Tables(0).Rows(0)("Address").ToString()
            cmbUserType.SelectedItem = ds.Tables(0).Rows(0)("UserType").ToString()
            txtContactNo.Text = ds.Tables(0).Rows(0)("ContactNo").ToString()
            txtPassword.Text = ds.Tables(0).Rows(0)("Password").ToString()
            txtSecurtyQuestion.Text = ds.Tables(0).Rows(0)("SecurityQuestion").ToString()
            txtAnswer.Text = ds.Tables(0).Rows(0)("Answer").ToString()
        End If

    End Sub

    Private Sub btnMiniMize_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiniMize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

 
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        str = ""
        str = "Update UserRegMaster set UserName='" + txtUserName.Text + "',FirstName='" + txtFirstName.Text + "',MiddleName='" + txtMiddlename.Text + "',LastName='" + txtLastName.Text + "',Address='" + txtAddress.Text + "',UserType='" + cmbUserType.SelectedItem + "',ContactNo='" + txtContactNo.Text + "',Password='" + txtPassword.Text + "',SecurityQuestion='" + txtSecurtyQuestion.Text + "',Answer='" + txtAnswer.Text + "' where RegID=" + testModule.rid.ToString()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Updated Successfully", "UserReg Master")
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        str = ""
        str = "Delete From UserRegMaster Where UserID=" + Me.txtUserName.Text()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        txtUserName.Text = ""
        txtFirstName.Text = ""
        txtMiddlename.Text = ""
        txtLastName.Text = ""
        txtAddress.Text = ""
        txtContactNo.Text = ""
        txtSecurtyQuestion.Text = ""
        txtPassword.Text = ""
        txtAnswer.Text = ""
        cmbUserType.SelectedItem = ""
        MessageBox.Show("Delete Record Sucessfuly", "UserReg Master")
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class