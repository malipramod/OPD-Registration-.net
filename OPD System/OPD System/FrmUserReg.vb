Imports System.Data.SqlClient
Imports System.Configuration

Public Class FrmUserReg
    Dim con As SqlConnection
    Dim str As String
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtUserName.Text = ""
        txtFirstName.Text = ""
        txtMiddlename.Text = ""
        txtLastName.Text = ""
        txtAddress.Text = ""
        cmbUserType.Text = ""
        txtSecurtyQuestion.Text = ""
        txtAnswer.Text = ""
        txtPassword.Text = ""
        txtContactNo.Text = ""
        txtUserName.Focus()


    End Sub

    Private Sub FrmUserReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=CC-PC\;Initial Catalog=OPDExamination;Persist Security Info=True;User ID=sa;Password=rudh012")
        con.Open()

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        str = ""
        str = "Insert into UserRegMaster (UserName,FirstName,MiddleName,LastName,UserType,Address,ContactNo,SecurityQuestion,Answer,Password) values ('" + txtUserName.Text + "','" + txtFirstName.Text + "','" + txtMiddlename.Text + "','" + txtLastName.Text + "','" + cmbUserType.Text + "','" + txtAddress.Text + "','" + txtContactNo.Text + "','" + txtSecurtyQuestion.Text + "','" + txtAnswer.Text + "','" + txtPassword.Text + "')"
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Record Saved Successfully!", "Donation Management")

    End Sub

    Private Sub btnMiniMize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnMiniMize_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiniMize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class