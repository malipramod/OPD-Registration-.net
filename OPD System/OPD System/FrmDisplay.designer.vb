<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDisplay
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblNo = New System.Windows.Forms.Label
        Me.PnlReg = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblguj = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PnlReg.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 45
        '
        'lblNo
        '
        Me.lblNo.BackColor = System.Drawing.Color.Transparent
        Me.lblNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNo.Font = New System.Drawing.Font("Cambria", 279.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNo.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblNo.Location = New System.Drawing.Point(7, 9)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(647, 525)
        Me.lblNo.TabIndex = 127
        Me.lblNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PnlReg
        '
        Me.PnlReg.BackColor = System.Drawing.Color.Transparent
        Me.PnlReg.BackgroundImage = Global.OPD_System.My.Resources.Resources.flow_of_glow_wide_2
        Me.PnlReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlReg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlReg.Controls.Add(Me.lblNo)
        Me.PnlReg.Location = New System.Drawing.Point(12, 52)
        Me.PnlReg.Name = "PnlReg"
        Me.PnlReg.Size = New System.Drawing.Size(665, 545)
        Me.PnlReg.TabIndex = 112
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.OPD_System.My.Resources.Resources.flow_of_glow_wide_2
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblguj)
        Me.Panel1.Location = New System.Drawing.Point(683, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(668, 545)
        Me.Panel1.TabIndex = 126
        '
        'lblguj
        '
        Me.lblguj.BackColor = System.Drawing.Color.Transparent
        Me.lblguj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblguj.Font = New System.Drawing.Font("Laser Gopika", 309.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblguj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblguj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblguj.Location = New System.Drawing.Point(7, 12)
        Me.lblguj.Name = "lblguj"
        Me.lblguj.Size = New System.Drawing.Size(651, 525)
        Me.lblguj.TabIndex = 127
        Me.lblguj.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = Global.OPD_System.My.Resources.Resources.flow_of_glow_wide_2
        Me.Label3.Location = New System.Drawing.Point(-350, 642)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1368, 73)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "WELCOME  TO THE HOSPITAL"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Laser Gopika", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.OPD_System.My.Resources.Resources.flow_of_glow_wide_2
        Me.Label1.Location = New System.Drawing.Point(1013, 642)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1386, 73)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "hfjkdhkjskj"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FrmDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OPD_System.My.Resources.Resources.neon_squares_HD_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 742)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlReg)
        Me.Font = New System.Drawing.Font("GJBI-TTAvantikaEN", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FrmDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " & _
            "                                                                              "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlReg.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNo As System.Windows.Forms.Label
    Friend WithEvents PnlReg As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblguj As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
