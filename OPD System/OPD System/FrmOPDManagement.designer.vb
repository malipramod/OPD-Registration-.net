<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOPDManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOPDManagement))
        Me.BtnReg = New System.Windows.Forms.Button
        Me.btnTransaction = New System.Windows.Forms.Button
        Me.btnReports = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnMiniMize = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblUserName = New System.Windows.Forms.Label
        Me.lblTimer = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblouttimer = New System.Windows.Forms.Label
        Me.PnlTrans = New System.Windows.Forms.Panel
        Me.btnDisplay = New System.Windows.Forms.Button
        Me.btnEditUser = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnChangePass = New System.Windows.Forms.Button
        Me.btnPatientTrans = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnPatientReg = New System.Windows.Forms.Button
        Me.btnUserReg = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btnLogout = New System.Windows.Forms.Button
        Me.PnlReg = New System.Windows.Forms.Panel
        Me.PnlTrans.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlReg.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnReg
        '
        Me.BtnReg.BackColor = System.Drawing.Color.White
        Me.BtnReg.BackgroundImage = CType(resources.GetObject("BtnReg.BackgroundImage"), System.Drawing.Image)
        Me.BtnReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnReg.FlatAppearance.BorderSize = 3
        Me.BtnReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReg.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReg.ForeColor = System.Drawing.Color.White
        Me.BtnReg.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnReg.Location = New System.Drawing.Point(326, 40)
        Me.BtnReg.Name = "BtnReg"
        Me.BtnReg.Size = New System.Drawing.Size(215, 58)
        Me.BtnReg.TabIndex = 52
        Me.BtnReg.Text = "&Registration"
        Me.BtnReg.UseVisualStyleBackColor = False
        '
        'btnTransaction
        '
        Me.btnTransaction.BackColor = System.Drawing.Color.White
        Me.btnTransaction.BackgroundImage = CType(resources.GetObject("btnTransaction.BackgroundImage"), System.Drawing.Image)
        Me.btnTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTransaction.FlatAppearance.BorderSize = 3
        Me.btnTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaction.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.White
        Me.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnTransaction.Location = New System.Drawing.Point(563, 40)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(320, 58)
        Me.btnTransaction.TabIndex = 53
        Me.btnTransaction.Text = "&Transaction / Edit"
        Me.btnTransaction.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.White
        Me.btnReports.BackgroundImage = CType(resources.GetObject("btnReports.BackgroundImage"), System.Drawing.Image)
        Me.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReports.FlatAppearance.BorderSize = 3
        Me.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnReports.Location = New System.Drawing.Point(906, 40)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(154, 58)
        Me.btnReports.TabIndex = 54
        Me.btnReports.Text = "Re&ports"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Location = New System.Drawing.Point(1301, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(53, 25)
        Me.btnClose.TabIndex = 104
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMiniMize
        '
        Me.btnMiniMize.BackgroundImage = CType(resources.GetObject("btnMiniMize.BackgroundImage"), System.Drawing.Image)
        Me.btnMiniMize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMiniMize.Location = New System.Drawing.Point(1259, 8)
        Me.btnMiniMize.Name = "btnMiniMize"
        Me.btnMiniMize.Size = New System.Drawing.Size(40, 24)
        Me.btnMiniMize.TabIndex = 105
        Me.btnMiniMize.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 721)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 26)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "UserName :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUserName.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(136, 722)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(0, 26)
        Me.lblUserName.TabIndex = 117
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTimer.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTimer.Location = New System.Drawing.Point(504, 722)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(75, 26)
        Me.lblTimer.TabIndex = 119
        Me.lblTimer.Text = "(time)"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(336, 722)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 26)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "Logged In Time : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(976, 716)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(377, 31)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "By NeuronExcellence Infotech"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblouttimer
        '
        Me.lblouttimer.AutoSize = True
        Me.lblouttimer.BackColor = System.Drawing.Color.Transparent
        Me.lblouttimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblouttimer.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblouttimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblouttimer.Location = New System.Drawing.Point(582, 662)
        Me.lblouttimer.Name = "lblouttimer"
        Me.lblouttimer.Size = New System.Drawing.Size(75, 26)
        Me.lblouttimer.TabIndex = 125
        Me.lblouttimer.Text = "(time)"
        Me.lblouttimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblouttimer.Visible = False
        '
        'PnlTrans
        '
        Me.PnlTrans.BackColor = System.Drawing.Color.Transparent
        Me.PnlTrans.BackgroundImage = Global.OPD_System.My.Resources.Resources.flow_of_glow_wide_2
        Me.PnlTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlTrans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlTrans.Controls.Add(Me.btnDisplay)
        Me.PnlTrans.Controls.Add(Me.btnEditUser)
        Me.PnlTrans.Controls.Add(Me.Label4)
        Me.PnlTrans.Controls.Add(Me.btnChangePass)
        Me.PnlTrans.Controls.Add(Me.btnPatientTrans)
        Me.PnlTrans.Controls.Add(Me.Label3)
        Me.PnlTrans.Location = New System.Drawing.Point(402, 140)
        Me.PnlTrans.Name = "PnlTrans"
        Me.PnlTrans.Size = New System.Drawing.Size(595, 321)
        Me.PnlTrans.TabIndex = 132
        Me.PnlTrans.Visible = False
        '
        'btnDisplay
        '
        Me.btnDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDisplay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDisplay.FlatAppearance.BorderSize = 2
        Me.btnDisplay.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisplay.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDisplay.Location = New System.Drawing.Point(39, 118)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(207, 35)
        Me.btnDisplay.TabIndex = 99
        Me.btnDisplay.Text = "&Display Message"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnEditUser
        '
        Me.btnEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEditUser.FlatAppearance.BorderSize = 2
        Me.btnEditUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditUser.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditUser.Location = New System.Drawing.Point(39, 211)
        Me.btnEditUser.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(205, 35)
        Me.btnEditUser.TabIndex = 98
        Me.btnEditUser.Text = "Edit &User Profile"
        Me.btnEditUser.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(-8, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 46)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Edit"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnChangePass
        '
        Me.btnChangePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnChangePass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnChangePass.FlatAppearance.BorderSize = 2
        Me.btnChangePass.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnChangePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnChangePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePass.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnChangePass.Location = New System.Drawing.Point(39, 254)
        Me.btnChangePass.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(216, 35)
        Me.btnChangePass.TabIndex = 91
        Me.btnChangePass.Text = "&Change Password"
        Me.btnChangePass.UseVisualStyleBackColor = True
        '
        'btnPatientTrans
        '
        Me.btnPatientTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPatientTrans.Enabled = False
        Me.btnPatientTrans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPatientTrans.FlatAppearance.BorderSize = 2
        Me.btnPatientTrans.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPatientTrans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPatientTrans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnPatientTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatientTrans.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatientTrans.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPatientTrans.Location = New System.Drawing.Point(39, 73)
        Me.btnPatientTrans.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPatientTrans.Name = "btnPatientTrans"
        Me.btnPatientTrans.Size = New System.Drawing.Size(199, 35)
        Me.btnPatientTrans.TabIndex = 88
        Me.btnPatientTrans.Text = "&Patient Register Transaction"
        Me.btnPatientTrans.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(1, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 46)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Transaction"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(1, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 46)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registration"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPatientReg
        '
        Me.btnPatientReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPatientReg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPatientReg.FlatAppearance.BorderSize = 2
        Me.btnPatientReg.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPatientReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPatientReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnPatientReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatientReg.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatientReg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPatientReg.Location = New System.Drawing.Point(39, 73)
        Me.btnPatientReg.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPatientReg.Name = "btnPatientReg"
        Me.btnPatientReg.Size = New System.Drawing.Size(244, 35)
        Me.btnPatientReg.TabIndex = 88
        Me.btnPatientReg.Text = "&Patients Registration"
        Me.btnPatientReg.UseVisualStyleBackColor = True
        '
        'btnUserReg
        '
        Me.btnUserReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUserReg.Enabled = False
        Me.btnUserReg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUserReg.FlatAppearance.BorderSize = 2
        Me.btnUserReg.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnUserReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserReg.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserReg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserReg.Location = New System.Drawing.Point(39, 119)
        Me.btnUserReg.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUserReg.Name = "btnUserReg"
        Me.btnUserReg.Size = New System.Drawing.Size(210, 35)
        Me.btnUserReg.TabIndex = 93
        Me.btnUserReg.Text = "&User Registration"
        Me.btnUserReg.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(364, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(175, 201)
        Me.PictureBox2.TabIndex = 94
        Me.PictureBox2.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 2
        Me.btnLogout.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(40, 163)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(135, 35)
        Me.btnLogout.TabIndex = 97
        Me.btnLogout.Text = "LOG &OUT"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'PnlReg
        '
        Me.PnlReg.BackColor = System.Drawing.Color.Transparent
        Me.PnlReg.BackgroundImage = Global.OPD_System.My.Resources.Resources.flow_of_glow_wide_2
        Me.PnlReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlReg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlReg.Controls.Add(Me.btnLogout)
        Me.PnlReg.Controls.Add(Me.PictureBox2)
        Me.PnlReg.Controls.Add(Me.btnUserReg)
        Me.PnlReg.Controls.Add(Me.btnPatientReg)
        Me.PnlReg.Controls.Add(Me.Label2)
        Me.PnlReg.Location = New System.Drawing.Point(160, 140)
        Me.PnlReg.Name = "PnlReg"
        Me.PnlReg.Size = New System.Drawing.Size(567, 229)
        Me.PnlReg.TabIndex = 135
        Me.PnlReg.Visible = False
        '
        'FrmOPDManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OPD_System.My.Resources.Resources.neon_squares_HD_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1380, 742)
        Me.Controls.Add(Me.PnlReg)
        Me.Controls.Add(Me.PnlTrans)
        Me.Controls.Add(Me.lblouttimer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMiniMize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnTransaction)
        Me.Controls.Add(Me.BtnReg)
        Me.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FrmOPDManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " & _
            "                                                                              "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlTrans.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlReg.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnReg As System.Windows.Forms.Button
    Friend WithEvents btnTransaction As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMiniMize As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblouttimer As System.Windows.Forms.Label
    Friend WithEvents PnlTrans As System.Windows.Forms.Panel
    Friend WithEvents btnEditUser As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnChangePass As System.Windows.Forms.Button
    Friend WithEvents btnPatientTrans As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPatientReg As System.Windows.Forms.Button
    Friend WithEvents btnUserReg As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents PnlReg As System.Windows.Forms.Panel

End Class
