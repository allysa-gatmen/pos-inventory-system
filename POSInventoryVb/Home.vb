Public Class Home
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles probutton.Click
        Dim home = New Home
        Product.Show()
        Me.Hide()
    End Sub

    Private Sub custbutton_Click(sender As Object, e As EventArgs) Handles custbutton.Click
        Dim home = New Home
        Customer.Show()
        Me.Hide()
    End Sub

    Private Sub catbutton_Click(sender As Object, e As EventArgs) Handles catbutton.Click
        Dim home = New Home
        Categories.Show()
        Me.Hide()
    End Sub

    Private Sub orderbutton_Click(sender As Object, e As EventArgs) Handles orderbutton.Click
        Dim home = New Home
        Orders.Show()
        Me.Hide()
    End Sub

    Private Sub usbutton_Click(sender As Object, e As EventArgs) Handles usbutton.Click
        Dim home = New Home
        Users.Show()
        Me.Hide()
    End Sub

    Private Sub logoutbutton_Click(sender As Object, e As EventArgs) Handles logoutbutton.Click
        Dim ask As MsgBoxResult = MsgBox("Do you really want to log out?", MessageBoxButtons.YesNo, "Logout Confirmation")
        If ask = MsgBoxResult.Yes Then
            MessageBox.Show("Successfully Logged Out")
            Dim Home = New Home
            LoginF.Show()
            Me.Hide()
        Else
            MsgBox("You didn't logout", MessageBoxButtons.OK, "")
        End If
    End Sub

    Private Sub reportbutton_Click(sender As Object, e As EventArgs) Handles reportbutton.Click
        Dim home = New Home
        Reports.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub
End Class