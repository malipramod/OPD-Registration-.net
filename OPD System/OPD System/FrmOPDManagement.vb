Imports System.Data.SqlClient
Public Class FrmOPDManagement
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter

    Dim str As String

    Private Sub btnMiniMize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiniMize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub BtnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReg.Click
        PnlReg.Visible = True
        If PnlTrans.Visible = True Then
            PnlTrans.Visible = False
        End If
        'If PnlReport.Visible = True Then
        '    PnlReport.Visible = False
        'End If
    End Sub

    Private Sub btnTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaction.Click
        PnlTrans.Visible = True
        If PnlReg.Visible = True Then
            PnlReg.Visible = False

        End If
        'If PnlReport.Visible = True Then
        '    PnlReport.Visible = False
        'End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblouttimer.Text = System.DateTime.Now.ToLongTimeString
    End Sub

   

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        'PnlReport.Visible = True
        'If PnlReg.Visible = True Then
        '    PnlReg.Visible = False
        'End If
        'If PnlTrans.Visible = True Then
        '    PnlTrans.Visible = False
        'End If
    End Sub

    Private Sub FrmOPDManagement_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If PnlTrans.Visible = True Then
            PnlTrans.Visible = False
        End If
        If PnlReg.Visible = True Then
            PnlReg.Visible = False

        End If
        'If PnlReport.Visible = True Then
        '    PnlReport.Visible = False
        'End If
    End Sub

    Private Sub FrmOPDManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MessageBox.Show("time " + testModule.rid.ToString())
        Timer1.Start()
        lblTimer.Text = System.DateTime.Now.ToLongTimeString
        lblUserName.Text = FrmLoginForm.txtUserName.Text

        con = New SqlConnection("Data Source=CC-PC\;Initial Catalog=OPDExamination;Persist Security Info=True;User ID=sa;Password=rudh012")
        con.Open()


        If FrmLoginForm.cmbUserType.Text = "Admin" Then
            btnUserReg.Enabled = True
            frmEditUserReg.btnDelete.Enabled = True
            frmEditUserReg.cmbUserType.Enabled = True
            btnPatientTrans.Enabled = True

        End If

    End Sub

    Private Sub btnUserReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserReg.Click
        PnlReg.Visible = False
        Dim frm As New FrmUserReg
        frm.ShowDialog()
    End Sub

    Private Sub btnPatientReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPatientReg.Click
        PnlReg.Visible = False
        Dim frm As New FrmPatientRegistration
        frm.ShowDialog()
    End Sub

    Private Sub btnPatientTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPatientTrans.Click
        PnlReg.Visible = False
        Dim frm As New frmPatientDetails
        frm.ShowDialog()
    End Sub

    Private Sub btnChangePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePass.Click
        PnlTrans.Visible = False
        Dim frm As New FrmChangePassword
        frm.ShowDialog()
    End Sub

    Private Sub btnEditUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditUser.Click
        PnlTrans.Visible = False
        Dim frm As New frmEditUserReg
        frm.ShowDialog()
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        PnlTrans.Visible = False
        Dim frm As New FrmMessage
        frm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        str = ""
        str = "Update LoginMaster set LoggedOutTime = '" + lblouttimer.Text + "' where UserID= " + testModule.uid.ToString()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("You are LoggedOut Successfully", "Log Out ")

        End
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        str = ""
        str = "Update LoginMaster set LoggedOutTime = '" + lblouttimer.Text.ToString() + "' where UserID= " + testModule.uid.ToString()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("You are LoggedOut Successfully", "Log Out ")

        End
    End Sub
End Class
