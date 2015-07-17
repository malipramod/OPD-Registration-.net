<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditPatientRegistration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditPatientRegistration))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtTokenNo = New System.Windows.Forms.TextBox
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.DTPDate = New System.Windows.Forms.DateTimePicker
        Me.lblDate = New System.Windows.Forms.Label
        Me.cmbGender = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMiddleName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtMobileNo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtAdd1 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAdd2 = New System.Windows.Forms.TextBox
        Me.txtAdd3 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnMiniMize = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.lblAmmount = New System.Windows.Forms.Label
        Me.txtRecNo = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.lblTimer = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Name = "Label1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.OPD_System.My.Resources.Resources.flow_of_glow_wide_2
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtTokenNo)
        Me.Panel1.Controls.Add(Me.txtAge)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.DTPDate)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.cmbGender)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtMiddleName)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Name = "Panel1"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Name = "Label9"
        '
        'txtTokenNo
        '
        Me.txtTokenNo.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txtTokenNo, "txtTokenNo")
        Me.txtTokenNo.Name = "txtTokenNo"
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txtAge, "txtAge")
        Me.txtAge.Name = "txtAge"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Name = "Label6"
        '
        'DTPDate
        '
        Me.DTPDate.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        resources.ApplyResources(Me.DTPDate, "DTPDate")
        Me.DTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPDate.Name = "DTPDate"
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDate.Name = "lblDate"
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cmbGender, "cmbGender")
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {resources.GetString("cmbGender.Items"), resources.GetString("cmbGender.Items1")})
        Me.cmbGender.Name = "cmbGender"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Name = "Label5"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txtMiddleName, "txtMiddleName")
        Me.txtMiddleName.Name = "txtMiddleName"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txtLastName, "txtLastName")
        Me.txtLastName.Name = "txtLastName"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txtFirstName, "txtFirstName")
        Me.txtFirstName.Name = "txtFirstName"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Name = "Label2"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Name = "Label4"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.OPD_System.My.Resources.Resources.flow_of_glow_wide_2
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtMobileNo)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtCity)
        Me.Panel2.Controls.Add(Me.txtAdd1)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtAdd2)
        Me.Panel2.Controls.Add(Me.txtAdd3)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Name = "Panel2"
        '
        'txtMobileNo
        '
        Me.txtMobileNo.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txtMobileNo, "txtMobileNo")
        Me.txtMobileNo.Name = "txtMobileNo"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Name = "Label8"
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txtCity, "txtCity")
        Me.txtCity.Name = "txtCity"
        '
        'txtAdd1
        '
        Me.txtAdd1.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txtAdd1, "txtAdd1")
        Me.txtAdd1.Name = "txtAdd1"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Name = "Label11"
        '
        'txtAdd2
        '
        Me.txtAdd2.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txtAdd2, "txtAdd2")
        Me.txtAdd2.Name = "txtAdd2"
        '
        'txtAdd3
        '
        Me.txtAdd3.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txtAdd3, "txtAdd3")
        Me.txtAdd3.Name = "txtAdd3"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Name = "Label7"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Name = "Label10"
        '
        'btnBack
        '
        resources.ApplyResources(Me.btnBack, "btnBack")
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 2
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Name = "btnBack"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnMiniMize
        '
        resources.ApplyResources(Me.btnMiniMize, "btnMiniMize")
        Me.btnMiniMize.Name = "btnMiniMize"
        Me.btnMiniMize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.Name = "btnClose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.OPD_System.My.Resources.Resources.flow_of_glow_wide_2
        resources.ApplyResources(Me.Panel5, "Panel5")
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.txtAmount)
        Me.Panel5.Controls.Add(Me.lblAmmount)
        Me.Panel5.Controls.Add(Me.txtRecNo)
        Me.Panel5.Controls.Add(Me.Label25)
        Me.Panel5.Name = "Panel5"
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txtAmount, "txtAmount")
        Me.txtAmount.Name = "txtAmount"
        '
        'lblAmmount
        '
        Me.lblAmmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.lblAmmount, "lblAmmount")
        Me.lblAmmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblAmmount.Name = "lblAmmount"
        '
        'txtRecNo
        '
        Me.txtRecNo.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txtRecNo, "txtRecNo")
        Me.txtRecNo.Name = "txtRecNo"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label25, "Label25")
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label25.Name = "Label25"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = Global.OPD_System.My.Resources.Resources.abstract_vision_colors_wide_2
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.btnUpdate)
        Me.Panel4.Controls.Add(Me.btnDelete)
        Me.Panel4.Name = "Panel4"
        '
        'btnUpdate
        '
        resources.ApplyResources(Me.btnUpdate, "btnUpdate")
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 2
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 2
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblTimer
        '
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimer.ForeColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblTimer, "lblTimer")
        Me.lblTimer.Name = "lblTimer"
        '
        'FrmEditPatientRegistration
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OPD_System.My.Resources.Resources.dark_abstract_colors_wide_2
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btnMiniMize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEditPatientRegistration"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnMiniMize As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtRecNo As System.Windows.Forms.TextBox
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblAmmount As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DTPDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtTokenNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAdd2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd3 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
End Class
