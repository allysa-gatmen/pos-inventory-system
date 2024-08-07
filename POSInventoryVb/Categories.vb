Imports System.Data.SqlClient
Public Class Categories
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cmd.CommandText = "select * from CategoryTbl"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        CategoryDGV.DataSource = dt
    End Sub

    Private Sub addbutton_Click(sender As Object, e As EventArgs) Handles addbutton.Click
        If CatId.Text = "" Or CatName.Text = "" Then
            MessageBox.Show("Incomplete data")
        Else
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into CategoryTbl values('" + CatId.Text + "','" + CatName.Text + "')"
            cmd.ExecuteNonQuery()

            disp_data()
            MessageBox.Show("Category Added Successfully")
            CatId.Text = ""
            CatName.Text = ""
        End If
    End Sub

    Private Sub editbutton_Click(sender As Object, e As EventArgs) Handles editbutton.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        If CatId.Text = "" Or CatName.Text = "" Then
            MessageBox.Show("Incomplete data")
        Else
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update CategoryTbl set CatId='" + CatId.Text + "',CatName='" + CatName.Text + "' where CatId= " & i & ""
            cmd.ExecuteNonQuery()

            disp_data()
            MessageBox.Show("Category Edited Successfully")
            CatId.Text = ""
            CatName.Text = ""
        End If
    End Sub

    Private Sub deletebutton_Click(sender As Object, e As EventArgs) Handles deletebutton.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        If CatId.Text = "" Then
            MessageBox.Show("Enter the category to be deleted")
        Else
            con.Open()
            Dim ask As MsgBoxResult = MsgBox("Do you really want to delete this category?", MessageBoxButtons.YesNo, "Delete Confirmation")
            If ask = MsgBoxResult.Yes Then
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from CategoryTbl where CatId='" + CatId.Text + "'"
                cmd.ExecuteNonQuery()

                disp_data()
                MessageBox.Show("Category Deleted Successfully")
                CatId.Text = ""
                CatName.Text = ""
            Else
                MsgBox("You didn't delete this category", MessageBoxButtons.OK, "")
            End If
        End If
    End Sub

    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click
        CatId.Text = ""
        CatName.Text = ""
    End Sub

    Private Sub CategoryDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CategoryDGV.CellContentClick
        Try

            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            i = Convert.ToInt32(CategoryDGV.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from CategoryTbl where CatId =" & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                CatId.Text = dr.GetValue(0).ToString()
                CatName.Text = dr.GetValue(1).ToString()
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
            da = New SqlDataAdapter("select * from CategoryTbl where CatName like '%" & searchtb.Text & "%' Or CatId Like '%" & searchtb.Text & "'", con)
            Dim ds As New DataSet
            da.Fill(ds, "CategoryTbl")
            CategoryDGV.DataSource = ds.Tables("CategoryTbl").DefaultView
        End If
        If searchtb.Text = "" Then
            disp_data()
        End If
    End Sub
End Class