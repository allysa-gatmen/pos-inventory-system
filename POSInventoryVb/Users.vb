Imports System.Data.SqlClient
Public Class Users
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=LAPTOP-B351TGH0;Initial Catalog=POSInventoryVbDb;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        disp_data()
    End Sub

    Public Sub disp_data()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from UserTbl"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        UserDGV.DataSource = dt
    End Sub

    Private Sub addbutton_Click(sender As Object, e As EventArgs) Handles addbutton.Click
        If UsId.Text = "" Or UsName.Text = "" Or UsPass.Text = "" Or UsPhone.Text = "" Then
            MessageBox.Show("Incomplete data")
        Else
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into UserTbl values('" + UsId.Text + "','" + UsName.Text + "','" + UsPass.Text + "', '" + UsPhone.Text + " ')"
            cmd.ExecuteNonQuery()

            disp_data()
            MessageBox.Show("User Added Successfully")
            UsId.Text = ""
            UsName.Text = ""
            UsPass.Text = ""
            UsPhone.Text = ""
        End If
    End Sub
    Private Sub editbutton_Click(sender As Object, e As EventArgs) Handles editbutton.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        If UsId.Text = "" Or UsName.Text = "" Or UsPass.Text = "" Or UsPhone.Text = "" Then
            MessageBox.Show("Incomplete data")
        Else
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update UserTbl set UsId='" + UsId.Text + "',UsName='" + UsName.Text + "',UsPass='" + UsPass.Text + "',UsPhone='" + UsPhone.Text + "' where UsId= " & i & ""
            cmd.ExecuteNonQuery()

            disp_data()
            MessageBox.Show("User Edited Successfully")
            UsId.Text = ""
            UsName.Text = ""
            UsPass.Text = ""
            UsPhone.Text = ""
        End If
    End Sub

    Private Sub deletebutton_Click(sender As Object, e As EventArgs) Handles deletebutton.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        If UsId.Text = "" Then
            MessageBox.Show("Enter the user to be deleted")
        Else
            con.Open()
            Dim ask As MsgBoxResult = MsgBox("Do you really want to delete this user?", MessageBoxButtons.YesNo, "Delete Confirmation")
            If ask = MsgBoxResult.Yes Then
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from UserTbl where UsId='" + UsId.Text + "'"
                cmd.ExecuteNonQuery()

                disp_data()
                MessageBox.Show("User Deleted Successfully")
                UsId.Text = ""
                UsName.Text = ""
                UsPass.Text = ""
                UsPhone.Text = ""
            Else
                MsgBox("You didn't delete this user", MessageBoxButtons.OK, "")
            End If
        End If
    End Sub

    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click
        UsId.Text = ""
        UsName.Text = ""
        UsPass.Text = ""
        UsPass.Text = ""
    End Sub

    Private Sub UserDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDGV.CellContentClick
        Try

            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            i = Convert.ToInt32(UserDGV.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from UserTbl where UsId =" & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                UsId.Text = dr.GetValue(0).ToString()
                UsName.Text = dr.GetValue(1).ToString()
                UsPass.Text = dr.GetValue(2).ToString()
                UsPhone.Text = dr.GetValue(3).ToString()
            End While
        Catch ex As Exception
        End Try

    End Sub
    Private Sub homebutton_Click(sender As Object, e As EventArgs) Handles homebutton.Click
        Dim home = New Home
        home.Show()
        Me.Hide()
    End Sub

    Private Sub searchtb_TextChanged(sender As Object, e As EventArgs) Handles searchtb.TextChanged
        If searchtb.Text <> "" Then
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("select * from UserTbl where UsId like '%" & searchtb.Text & "%' Or UsName Like '%" & searchtb.Text & "%' or UsPass like '%" & searchtb.Text & "%' or UsPhone like '&" & searchtb.Text & "'", con)
            Dim ds As New DataSet
            da.Fill(ds, "UserTbl")
            UserDGV.DataSource = ds.Tables("UserTbl").DefaultView
        End If
        If searchtb.Text = "" Then
            disp_data()
        End If
    End Sub
End Class