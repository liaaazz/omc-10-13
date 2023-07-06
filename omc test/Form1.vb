Imports System.Security.Policy

Public Class DriverProfile

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        lstmax.Enabled = True
        txtboxinfo.ReadOnly = False
        txtboxcar.ReadOnly = False
        lblpayment.Enabled = True
        lblname.Enabled = True
        picpfp.Enabled = True
        'enables user to edit their information that customers may need
    End Sub
    Private Sub btndone_Click(sender As Object, e As EventArgs) Handles btndone.Click
        lstmax.Enabled = False
        lblpayment.Enabled = False
        lblname.Enabled = False
        picpfp.Enabled = False
        My.Settings.avatar = OpenFileDialog1.FileName
        My.Settings.Save()
        'completes edit function

        Dim details As String
        details = txtboxinfo.Text
        If details = "" Then
            txtboxinfo.Text = "Details"
        ElseIf details = " " Then
            txtboxinfo.Text = "Details"
        Else
        End If
        txtboxinfo.ReadOnly = True
        'if user does not complete the infomation it will display the default message

        Dim carD As String
        carD = txtboxcar.Text
        If carD = "" Then
            txtboxcar.Text = " Car Details 

 (Car Model And plate number)"
        ElseIf carD = " " Then
            txtboxcar.Text = " Car Details 

 (Car Model And plate number)"
        Else
        End If
        txtboxcar.ReadOnly = True
        'if user does not complete the infomation it will display the default message
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
        'takes user to the previour page

    End Sub

    Private Sub btnonline_Click(sender As Object, e As EventArgs) Handles btnonline.Click
        btnonline.Visible = False
        btnoffline.Visible = True
        'indicate that the user is offline
    End Sub

    Private Sub lstmax_Click(sender As Object, e As EventArgs) Handles lstmax.Click

        Dim ride As String = InputBox("What is the maximum number of riders")
        While ride <> ""
            If IsNumeric(ride) Then 'ensures only numerical value is accepted
                lstmax.Text = "Max.Pax: " & ride
                Exit While
            Else
                MsgBox("Please enter a value in number") 'indicate error when non-number is entered
                ride = InputBox("What is the maximum number of riders")
                'asks again the user to enter input but ends when users clicks on the cancel button
            End If
        End While

    End Sub

    Private Sub btninfo_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnoffline_Click(sender As Object, e As EventArgs) Handles btnoffline.Click
        btnonline.Visible = True
        btnoffline.Visible = False
        'indicate user is online
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PicCash.Click

    End Sub

    Private Sub lblpayment_Click(sender As Object, e As EventArgs) Handles lblpayment.Click, Label2.Click, Label1.Click
        Dim duitnow As String
        duitnow = MsgBox("Accept DuitNow as payment method", MsgBoxStyle.YesNo)
        If duitnow = MsgBoxResult.Yes Then
            picDuitNow.Visible = True 'visible to indicate choice of payment is acceptable to customer
        ElseIf duitnow = MsgBoxResult.No Then
            picDuitNow.Visible = False
            'indicates user does not accept the choice of payment
        End If

        Dim cash As String
        cash = MsgBox("Accept Cash as payment method", MsgBoxStyle.YesNo)
        If cash = MsgBoxResult.Yes Then
            PicCash.Visible = True 'visible to indicate choice of payment is acceptable to customer
        ElseIf cash = MsgBoxResult.No Then
            PicCash.Visible = False
            'indicates user does not accept the choice of payment
        End If

        If duitnow = MsgBoxResult.No And cash = MsgBoxResult.No Then
            MsgBox("You can add your payment method in the info box")
            'suggest to user an alternative option
        End If

    End Sub

    Private Sub lblname_Click(sender As Object, e As EventArgs) Handles lblname.Click
        Dim name As String
        name = InputBox("Please enter your name")

        If name = "" Then
            lblname.Text = "<Driver Name>"
            'when blank it will automatically display the default name
        Else
            lblname.Text = name
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picpfp.Click
        Try
            OpenFileDialog1.Title = "Open gallery"
            OpenFileDialog1.FileName = ".png"
            OpenFileDialog1.Filter = "all files|*.*"
            OpenFileDialog1.ShowDialog()
            picpfp.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        Catch ex As Exception
            'Do nothing
        End Try
        'opens files app to let user choose a picture from their device
    End Sub

    Private Sub txtboxextra_TextChanged(sender As Object, e As EventArgs) Handles txtboxcar.TextChanged

    End Sub
End Class
