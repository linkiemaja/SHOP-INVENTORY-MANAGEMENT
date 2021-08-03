Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, lblUsername.Click, lblPassword.Click, Label2.Click

    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click



        If cmbUsername.Text = "Manager" And txtPassword.Text = "CapeNexis" And txtUsername.Text = "Manager" Then

            TabControl1.Show()
            TabControl2.Visible = False
            GroupBox1.Visible = False
        ElseIf cmbUsername.Text = "Cashier" And txtPassword.Text = "CapeNexis" And txtUsername.Text = "Cashier" Then
            TabControl2.Show()
            TabControl1.Visible = False
            GroupBox1.Visible = False

        ElseIf cmbUsername.Text = "Stock Controller" And txtPassword.Text = "CapeNexis" And txtUsername.Text = "Stock Controller" Then
            TabControl2.Show()
            TabControl2.Visible = False
            GroupBox1.Visible = False
        Else

            MsgBox("Please Enter Your Username And Password", MsgBoxStyle.Information, "Login")

        End If
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("are you sure you want to exit?", "Clossing system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub

    Private Sub CUSTOMER_DETAILSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CUSTOMER_DETAILSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CUSTOMER_DETAILSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SHOP_INVENTORYDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SHOP_INVENTORYDataSet.CUSTOMER_DETAILS' table. You can move, or remove it, as needed.
        Me.CUSTOMER_DETAILSTableAdapter.Fill(Me.SHOP_INVENTORYDataSet.CUSTOMER_DETAILS)


        cmbUsername.Items.Add("Manager")
        cmbUsername.Items.Add("Cashier")
        cmbUsername.Items.Add("Stock Controller")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result = MessageBox.Show("are you sure you want to exit?", "Clossing system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        CUSTOMER_DETAILSBindingSource.AddNew()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        CUSTOMER_DETAILSBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        CUSTOMER_DETAILSBindingSource.MovePrevious()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        CUSTOMER_DETAILSBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        On Error GoTo Feedback
        Me.Validate()
        Me.CUSTOMER_DETAILSBindingSource.EndEdit()
        Me.CUSTOMER_DETAILSTableAdapter.Update(Me.SHOP_INVENTORYDataSet)
Feedback:
        MsgBox("Check your Record", vbInformation)
        Exit Sub
    End Sub


End Class
