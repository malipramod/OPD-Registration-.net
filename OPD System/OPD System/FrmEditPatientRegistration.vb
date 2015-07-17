Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FrmEditPatientRegistration
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim str As String
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub


    Private Sub btnMiniMize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiniMize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        FrmOPDManagement.Show()
        Me.Close()

    End Sub

    Private Sub FrmPatientRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.ConStr)
        con.Open()
        If testModule.var.ToString() <> "" Then
            str = ""
            str = "Select *from PatientMaster where PID=" + testModule.var.ToString()
            da = New SqlDataAdapter(str, con)
            ds = New DataSet()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then

                txtTokenNo.Text = ds.Tables(0).Rows(0)("TokenNo").ToString()
                txtFirstName.Text = ds.Tables(0).Rows(0)("FirstName").ToString()
                txtMiddleName.Text = ds.Tables(0).Rows(0)("MiddleName").ToString()
                txtLastName.Text = ds.Tables(0).Rows(0)("LastName").ToString()
                cmbGender.SelectedItem = ds.Tables(0).Rows(0)("Gender").ToString()
                DTPDate.Value = ds.Tables(0).Rows(0)("Date").ToString()
                txtAge.Text = ds.Tables(0).Rows(0)("Age").ToString()
                txtCity.Text = ds.Tables(0).Rows(0)("City").ToString()
                txtAdd1.Text = ds.Tables(0).Rows(0)("Address1").ToString()
                txtAdd2.Text = ds.Tables(0).Rows(0)("Address2").ToString()
                txtAdd3.Text = ds.Tables(0).Rows(0)("Address3").ToString()
                txtMobileNo.Text = ds.Tables(0).Rows(0)("MobileNo").ToString()
                txtRecNo.Text = ds.Tables(0).Rows(0)("RecNo").ToString()
                txtAmount.Text = ds.Tables(0).Rows(0)("Fees").ToString()
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtFirstName.Text = "" Then
            MsgBox("Please Insert First Name", MsgBoxStyle.Critical, "First Name is Missing")
            txtFirstName.Focus()
        Else
            str = ""
            str = "Upadate PatientMaster set TokenNo='" + txtTokenNo.Text + "',FirstName='" + txtFirstName.Text + "',MiddleName='" + txtMiddleName.Text + "',LastName='" + txtLastName.Text + "',Gender='" + cmbGender.SelectedItem + "',Date='" + DTPDate.Value + "',Age='" + txtAge.Text + "',City='" + txtCity.Text + "',Address1='" + txtAdd1.Text + "',Address2='" + txtAdd2.Text + "',Address3='" + txtAdd3.Text + "',MobileNo='" + txtMobileNo.Text + "',Fees='" + txtAmount.Text + "' where PID=" + testModule.var
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            MsgBox("Upadated Successfully", , "Patient Master")
            FrmPatientRegistration.ClearDetails()
        End If
    End Sub

    Private Sub txtFirstName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstName.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace 
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtMiddleName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMiddleName.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace 
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtLastName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLastName.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace 
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAge.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
            Beep()
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtMobileNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobileNo.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
            Beep()
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
            Beep()
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtRecNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRecNo.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
            Beep()
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtCity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCity.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace 
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtTokenNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTokenNo.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
            Beep()
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If testModule.var.ToString() <> "" Then
            Dim m = MessageBox.Show("Are You Sure ? ", "Patient Master", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If m = Windows.Forms.DialogResult.Yes Then
                str = ""
                str = "Delete From PatientMaster where PID = '" + testModule.var.ToString() + "'"
                cmd = New SqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Your Record is Deleted", "Patient Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmPatientDetails.BindGrid()
                testModule.var = ""
                Me.Close()
                frmPatientDetails.Show()
            End If
            If m = Windows.Forms.DialogResult.No Then
                MessageBox.Show("Operation is cancelled by user", "Patient Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                testModule.var = ""
            End If
        Else
            MessageBox.Show("Please select any row to delete.", "Patient Master", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class