Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FrmPatientRegistration
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

    Sub ClearDetails()
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtAdd1.Text = ""
        txtAdd2.Text = ""
        txtAdd3.Text = ""
        txtMobileNo.Text = ""
        txtCity.Text = ""
        cmbGender.SelectedIndex = -1
        txtAge.Text = ""
        txtAmount.Text = ""
        txtTokenNo.Text = ""
        txtFirstName.Focus()

    End Sub


    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        FrmOPDManagement.Show()
        Me.Close()

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub FrmPatientRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(testModule.ConStr)
        con.Open()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtFirstName.Text = "" Then
            MsgBox("Please Insert First Name", MsgBoxStyle.Critical, "First Name is Missing")
            txtFirstName.Focus()
        Else
            str = ""
            str = "Insert into PatientMaster(TokenNo,FirstName,MiddleName,LastName,Gender,Date,Age,City,Address1,Address2,Address3,MobileNo,RecNo,Fees) values('" + txtTokenNo.Text + "','" + txtFirstName.Text + "','" + txtMiddleName.Text + "','" + txtLastName.Text + "','" + cmbGender.Text + "','" + DTPDate.Value + "','" + txtAge.Text + "','" + txtCity.Text + "','" + txtAdd1.Text + "','" + txtAdd2.Text + "','" + txtAdd3.Text + "','" + txtMobileNo.Text + "','" + txtRecNo.Text + "','" + txtAmount.Text + "')"
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            MsgBox("Inserted Successfully", , "Patient Master")
            frmPatientDetails.BindGrid()
            ClearDetails()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearDetails()

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
End Class