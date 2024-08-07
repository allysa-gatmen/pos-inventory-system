Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Reports
    Dim con As New SqlConnection("Data Source=LAPTOP-B351TGH0;Initial Catalog=POSInventoryVbDb;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim n As Integer
    Private Sub homebutton_Click(sender As Object, e As EventArgs) Handles homebutton.Click
        Dim home = New Home
        home.Show()
        Me.Hide()
    End Sub
    Public Sub populate()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from OrdersTbl"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        OrderDGV.DataSource = dt
    End Sub
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=LAPTOP-B351TGH0;Initial Catalog=POSInventoryVbDb;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Timer1.Enabled = True
        populate()
        DTP1.Format = DateTimePickerFormat.Custom
        DTP1.CustomFormat = "dd/MM/yyyy"
        DTP2.Format = DateTimePickerFormat.Custom
        DTP2.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub searchtb_TextChanged(sender As Object, e As EventArgs) Handles searchtb.TextChanged
        If searchtb.Text <> "" Then
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("select * from OrdersTbl where OrderId like '%" & searchtb.Text & "%' Or CustName Like '%" & searchtb.Text & "%' or CustId like '%" & searchtb.Text & "'", con)
            Dim ds As New DataSet
            da.Fill(ds, "OrdersTbl")
            OrderDGV.DataSource = ds.Tables("OrdersTbl").DefaultView
        End If
        If searchtb.Text = "" Then
            populate()
        End If
    End Sub
    Private Sub dailybutton_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As Exception

        End Try
    End Sub
    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        If OrderIdTb.Text = "" Then
            MessageBox.Show("Enter the Order To Be Deleted")
        Else
            con.Open()
            Dim ask As MsgBoxResult = MsgBox("Do you really want to delete this order?", MessageBoxButtons.YesNo, "Delete Confirmation")
            If ask = MsgBoxResult.Yes Then
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from OrdersTbl where OrderId='" + OrderIdTb.Text + "'"
                cmd.ExecuteNonQuery()

                populate()
                MessageBox.Show("Order Deleted Successfully")
                OrderIdTb.Text = ""
            Else
                MsgBox("You didn't delete this order", MessageBoxButtons.OK, "")
            End If
        End If
    End Sub
    Private Sub OrderDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrderDGV.CellClick
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            n = Convert.ToInt32(OrderDGV.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from OrdersTbl where OrderId =" & n & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                OrderIdTb.Text = dr.GetValue(0).ToString()
            End While
        Catch ex As Exception
        End Try
    End Sub
    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        OrderIdTb.Text = ""
    End Sub
    Private Sub printbutton_Click(sender As Object, e As EventArgs) Handles printbutton.Click
        PrintPreviewDialog1.Document = PrintDoc
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim logoImage As Image = My.Resources.ResourceManager.GetObject("super8")
        e.Graphics.DrawImage(logoImage, CInt((e.PageBounds.Width - 150) / 2), 20, 150, 35)

        Dim leftmargin As Integer = PrintDoc.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PrintDoc.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PrintDoc.DefaultPageSettings.PaperSize.Width
        Dim f8 As New Font("Calibri", 12, FontStyle.Regular)
        Dim f8b As New Font("Calibri", 12, FontStyle.Bold)
        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        e.Graphics.DrawString("SUPER8 GROCERY WAREHOUSE", f8, Brushes.Black, centermargin, 50, center)
        e.Graphics.DrawString("C. Morales Mall Commercial Complex National Highway", f8, Brushes.Black, centermargin, 65, center)
        e.Graphics.DrawString("Barangay San Antonio, Biñan, Laguna", f8, Brushes.Black, centermargin, 80, center)
        e.Graphics.DrawString("Phone +63 49 411 0062", f8, Brushes.Black, centermargin, 95, center)
        e.Graphics.DrawString("ORDER LIST AS OF", f8b, Brushes.Black, centermargin, 120, center)
        e.Graphics.DrawString(dt.Text.ToString(), f8b, Brushes.Black, centermargin, 135, center)

        e.Graphics.DrawString("FROM:", f8, Brushes.Black, 50, 160)
        e.Graphics.DrawString(DTP1.Value, f8, Brushes.Black, 100, 160)
        e.Graphics.DrawString("TO:", f8, Brushes.Black, 250, 160)
        e.Graphics.DrawString(DTP2.Value, f8, Brushes.Black, 280, 160)
        e.Graphics.DrawString("TOTAL REVENUE:", f8, Brushes.Black, 480, 160)
        e.Graphics.DrawString(Sumlabel.Text, f8b, Brushes.Black, 600, 160)

        e.Graphics.DrawString("ORDERID", f8, Brushes.Black, 50, 185)
        e.Graphics.DrawString("CUSTID", f8, Brushes.Black, 150, 185)
        e.Graphics.DrawString("CUSTNAME", f8, Brushes.Black, 250, 185)
        e.Graphics.DrawString("TOTAMT", f8, Brushes.Black, 480, 185)
        e.Graphics.DrawString("DATE", f8, Brushes.Black, 600, 185)

        Dim height As Integer
        OrderDGV.AllowUserToAddRows = False

        For row As Integer = 0 To OrderDGV.RowCount - 1
            height += 15
            e.Graphics.DrawString(OrderDGV.Rows(row).Cells(0).Value.ToString, f8, Brushes.Black, 50, 190 + height)
            e.Graphics.DrawString(OrderDGV.Rows(row).Cells(1).Value.ToString, f8, Brushes.Black, 150, 190 + height)
            e.Graphics.DrawString(OrderDGV.Rows(row).Cells(2).Value.ToString, f8, Brushes.Black, 250, 190 + height)
            e.Graphics.DrawString(OrderDGV.Rows(row).Cells(3).Value.ToString, f8, Brushes.Black, 480, 190 + height)
            e.Graphics.DrawString(OrderDGV.Rows(row).Cells(4).Value.ToString, f8, Brushes.Black, 600, 190 + height)
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dt.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub searchbutton_Click(sender As Object, e As EventArgs) Handles searchbutton.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As SqlCommand = New SqlCommand("select * from OrdersTbl where Date between @date1 and @date2", con)
        cmd.Parameters.Add("date1", SqlDbType.DateTime).Value = DTP1.Value
        cmd.Parameters.Add("date2", SqlDbType.DateTime).Value = DTP2.Value

        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        OrderDGV.DataSource = dt
        con.Close()

        Dim Sum As Integer = 0
        For i = 0 To OrderDGV.Rows.Count - 1
            Sum += OrderDGV.Rows(i).Cells(3).Value
        Next
        Sumlabel.Text = Sum
    End Sub
End Class