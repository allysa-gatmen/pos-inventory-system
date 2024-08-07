Imports System.Data.SqlClient
Public Class Customer
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=LAPTOP-B351TGH0;Initial Catalog=POSInventoryVbDb;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        disp_data()
        Dim query = "select Count(*) from CustomerTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        Dim count As Int16 = Convert.ToInt16(cmd.ExecuteScalar())
        CustCountLabel.Text = count.ToString()

        Dim query1 = "select Count(*) from OrdersTbl"
        Dim cmd1 As SqlCommand
        cmd1 = New SqlCommand(query1, con)
        Dim count1 As Int16 = Convert.ToInt16(cmd1.ExecuteScalar())
        OrderCountLabel.Text = count1.ToString()

        Dim query2 = "select Max(TotAmt) from OrdersTbl"
        Dim cmd2 As SqlCommand
        cmd2 = New SqlCommand(query2, con)
        Dim count2 As Int16 = Convert.ToInt16(cmd2.ExecuteScalar())
        MaxOrderLabel.Text = count2.ToString()

    End Sub

    Public Sub disp_data()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from CustomerTbl"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        CustomerDGV.DataSource = dt
    End Sub

    Private Sub addbutton_Click(sender As Object, e As EventArgs) Handles addbutton.Click
        If CustId.Text = "" Or CustName.Text = "" Or CustPhone.Text = "" Then
            MessageBox.Show("Incomplete data")
        Else
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into CustomerTbl values('" + CustId.Text + "','" + CustName.Text + "','" + CustPhone.Text + " ')"
            cmd.ExecuteNonQuery()

            disp_data()
            MessageBox.Show("Customer Added Successfully")
            CustId.Text = ""
            CustName.Text = ""
            CustPhone.Text = ""
        End If
    End Sub
    Private Sub editbutton_Click(sender As Object, e As EventArgs) Handles editbutton.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        If CustId.Text = "" Or CustName.Text = "" Or CustPhone.Text = "" Then
            MessageBox.Show("Incomplete data")
        Else
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update CustomerTbl set CustId='" + CustId.Text + "',CustName='" + CustName.Text + "',CustPhone='" + CustPhone.Text + "' where CustId= " & i & ""
            cmd.ExecuteNonQuery()

            disp_data()
            MessageBox.Show("Customer Edited Successfully")
            CustId.Text = ""
            CustName.Text = ""
            CustPhone.Text = ""
        End If
    End Sub

    Private Sub deletebutton_Click(sender As Object, e As EventArgs) Handles deletebutton.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        If CustId.Text = "" Then
            MessageBox.Show("Enter the customer to be deleted")
        Else
            con.Open()
            Dim ask As MsgBoxResult = MsgBox("Do you really want to delete this customer?", MessageBoxButtons.YesNo, "Delete Confirmation")
            If ask = MsgBoxResult.Yes Then
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from CustomerTbl where CustId='" + CustId.Text + "'"
                cmd.ExecuteNonQuery()

                disp_data()
                MessageBox.Show("Customer Deleted Successfully")
                CustId.Text = ""
                CustName.Text = ""
                CustPhone.Text = ""
            Else
                MsgBox("You didn't delete this customer", MessageBoxButtons.OK, "")
            End If
        End If
    End Sub
    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click
        CustId.Text = ""
        CustName.Text = ""
        CustPhone.Text = ""
    End Sub
    Private Sub CustomerDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDGV.CellClick
        Try

            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            i = Convert.ToInt32(CustomerDGV.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from CustomerTbl where CustId =" & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                CustId.Text = dr.GetValue(0).ToString()
                CustName.Text = dr.GetValue(1).ToString()
                CustPhone.Text = dr.GetValue(2).ToString()
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
            da = New SqlDataAdapter("select * from CustomerTbl where CustId like '%" & searchtb.Text & "%' Or CustName Like '%" & searchtb.Text & "%' or CustPhone like '%" & searchtb.Text & "'", con)
            Dim ds As New DataSet
            da.Fill(ds, "CustomerTbl")
            CustomerDGV.DataSource = ds.Tables("CustomerTbl").DefaultView
        End If
        If searchtb.Text = "" Then
            disp_data()
        End If
    End Sub
End Class