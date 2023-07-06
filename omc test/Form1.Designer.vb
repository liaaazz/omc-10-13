<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DriverProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnoffline = New System.Windows.Forms.Button()
        Me.btndone = New System.Windows.Forms.Button()
        Me.lstmax = New System.Windows.Forms.Label()
        Me.txtboxinfo = New System.Windows.Forms.TextBox()
        Me.txtboxcar = New System.Windows.Forms.TextBox()
        Me.btnonline = New System.Windows.Forms.Button()
        Me.lblpayment = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.picpfp = New System.Windows.Forms.PictureBox()
        Me.PicCash = New System.Windows.Forms.PictureBox()
        Me.picDuitNow = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.picpfp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDuitNow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(743, 31)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(90, 41)
        Me.btnback.TabIndex = 0
        Me.btnback.Text = "back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(636, 78)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(197, 41)
        Me.btnedit.TabIndex = 0
        Me.btnedit.Text = "edit information"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnoffline
        '
        Me.btnoffline.Location = New System.Drawing.Point(743, 125)
        Me.btnoffline.Name = "btnoffline"
        Me.btnoffline.Size = New System.Drawing.Size(90, 41)
        Me.btnoffline.TabIndex = 0
        Me.btnoffline.Text = "OFFLINE"
        Me.btnoffline.UseVisualStyleBackColor = True
        '
        'btndone
        '
        Me.btndone.Location = New System.Drawing.Point(636, 31)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(90, 41)
        Me.btndone.TabIndex = 0
        Me.btndone.Text = "done"
        Me.btndone.UseVisualStyleBackColor = True
        '
        'lstmax
        '
        Me.lstmax.BackColor = System.Drawing.Color.White
        Me.lstmax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstmax.Enabled = False
        Me.lstmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lstmax.Location = New System.Drawing.Point(636, 279)
        Me.lstmax.Name = "lstmax"
        Me.lstmax.Size = New System.Drawing.Size(197, 52)
        Me.lstmax.TabIndex = 1
        Me.lstmax.Text = "Max.Pax: 0 "
        Me.lstmax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtboxinfo
        '
        Me.txtboxinfo.BackColor = System.Drawing.Color.White
        Me.txtboxinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxinfo.Location = New System.Drawing.Point(321, 146)
        Me.txtboxinfo.Multiline = True
        Me.txtboxinfo.Name = "txtboxinfo"
        Me.txtboxinfo.ReadOnly = True
        Me.txtboxinfo.Size = New System.Drawing.Size(285, 365)
        Me.txtboxinfo.TabIndex = 2
        Me.txtboxinfo.Text = "Details"
        '
        'txtboxcar
        '
        Me.txtboxcar.BackColor = System.Drawing.Color.White
        Me.txtboxcar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxcar.Location = New System.Drawing.Point(636, 347)
        Me.txtboxcar.Multiline = True
        Me.txtboxcar.Name = "txtboxcar"
        Me.txtboxcar.ReadOnly = True
        Me.txtboxcar.Size = New System.Drawing.Size(197, 164)
        Me.txtboxcar.TabIndex = 2
        Me.txtboxcar.Text = " Car Details" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (Car Model and plate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  number)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnonline
        '
        Me.btnonline.AutoSize = True
        Me.btnonline.BackColor = System.Drawing.Color.Transparent
        Me.btnonline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnonline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnonline.Location = New System.Drawing.Point(636, 125)
        Me.btnonline.Name = "btnonline"
        Me.btnonline.Size = New System.Drawing.Size(90, 41)
        Me.btnonline.TabIndex = 0
        Me.btnonline.Text = "ONLINE"
        Me.btnonline.UseVisualStyleBackColor = False
        '
        'lblpayment
        '
        Me.lblpayment.BackColor = System.Drawing.Color.Transparent
        Me.lblpayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpayment.Enabled = False
        Me.lblpayment.Location = New System.Drawing.Point(636, 179)
        Me.lblpayment.Name = "lblpayment"
        Me.lblpayment.Size = New System.Drawing.Size(197, 89)
        Me.lblpayment.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(24, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 220)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Accepted request"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(24, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 220)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Booking request"
        '
        'lblname
        '
        Me.lblname.Enabled = False
        Me.lblname.Location = New System.Drawing.Point(447, 31)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(159, 95)
        Me.lblname.TabIndex = 6
        Me.lblname.Text = "<Driver Name>"
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picpfp
        '
        Me.picpfp.Enabled = False
        Me.picpfp.Image = Global.omc_test.My.Resources.Resources.pfp
        Me.picpfp.InitialImage = Nothing
        Me.picpfp.Location = New System.Drawing.Point(321, 31)
        Me.picpfp.Name = "picpfp"
        Me.picpfp.Size = New System.Drawing.Size(97, 95)
        Me.picpfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picpfp.TabIndex = 5
        Me.picpfp.TabStop = False
        '
        'PicCash
        '
        Me.PicCash.BackColor = System.Drawing.Color.Transparent
        Me.PicCash.Enabled = False
        Me.PicCash.Image = Global.omc_test.My.Resources.Resources._new
        Me.PicCash.Location = New System.Drawing.Point(647, 189)
        Me.PicCash.Name = "PicCash"
        Me.PicCash.Size = New System.Drawing.Size(79, 68)
        Me.PicCash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicCash.TabIndex = 3
        Me.PicCash.TabStop = False
        '
        'picDuitNow
        '
        Me.picDuitNow.BackColor = System.Drawing.Color.Transparent
        Me.picDuitNow.Enabled = False
        Me.picDuitNow.Image = Global.omc_test.My.Resources.Resources.duit_now_logo_CF9ED1C41E_seeklogo1
        Me.picDuitNow.Location = New System.Drawing.Point(743, 189)
        Me.picDuitNow.Name = "picDuitNow"
        Me.picDuitNow.Size = New System.Drawing.Size(79, 68)
        Me.picDuitNow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDuitNow.TabIndex = 3
        Me.picDuitNow.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DriverProfile
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(857, 537)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.picpfp)
        Me.Controls.Add(Me.PicCash)
        Me.Controls.Add(Me.picDuitNow)
        Me.Controls.Add(Me.txtboxcar)
        Me.Controls.Add(Me.txtboxinfo)
        Me.Controls.Add(Me.lstmax)
        Me.Controls.Add(Me.btnoffline)
        Me.Controls.Add(Me.btnonline)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btndone)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblpayment)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DriverProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form Driver (1)"
        CType(Me.picpfp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDuitNow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnback As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnonline As Button
    Friend WithEvents btnoffline As Button
    Friend WithEvents btndone As Button
    Friend WithEvents lstmax As Label
    Friend WithEvents txtboxinfo As TextBox
    Friend WithEvents txtboxcar As TextBox
    Friend WithEvents picDuitNow As PictureBox
    Friend WithEvents PicCash As PictureBox
    Friend WithEvents lblpayment As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picpfp As PictureBox
    Friend WithEvents lblname As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
