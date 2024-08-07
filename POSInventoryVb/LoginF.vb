Imports System.Data.SqlClient
Public Class LoginF
    Dim con As New SqlConnection("Data Source=LAPTOP-B351TGH0;Initial Catalog=POSInventoryVbDb;Integrated Security=True")

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        un.Text = ""
        pw.Text = ""
    End Sub

    Private Sub loginbutton_Click(sender As Object, e As EventArgs) Handles loginbutton.Click
        If un.Text = "" Then
            MsgBox("Enter the username")
        ElseIf pw.Text = "" Then
            MsgBox("Enter the password")
        Else
            con.Open()
            Dim query = "select * from UserTbl where UsName='" + un.Text + "' and UsPass='" + pw.Text + "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong username or password")
            Else
                MsgBox("Successfully Logged In")
                Dim home = New Home
                home.Show()
                Me.Hide()
            End If
            con.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If pw.UseSystemPasswordChar = True Then
            pw.UseSystemPasswordChar = False
        Else
            pw.UseSystemPasswordChar = True
        End If
    End Sub
End Class
