Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Orders
    Dim con As New SqlConnection("Data Source=LAPTOP-B351TGH0;Initial Catalog=POSInventoryVbDb;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim n As Integer
    Dim WithEvents PD As New PrintDocument
    Dim DPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = BillDGV.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 350
    End Sub
    Private Sub FillProduct()
        con.Open()
        Dim sql = "select * from ProductTbl"
        Dim cmd As New SqlCommand(sql, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        ProdIdCb.DataSource = Tbl
        ProdIdCb.DisplayMember = "ProdId"
        ProdIdCb.ValueMember = "ProdId"
        con.Close()
    End Sub
    Private Sub FillCustomer()
        con.Open()
        Dim sql = "select * from CustomerTbl"
        Dim cmd As New SqlCommand(sql, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        CustIdCb.DataSource = Tbl
        CustIdCb.DisplayMember = "CustId"
        CustIdCb.ValueMember = "CustId"
        con.Close()
    End Sub
    Private Sub FetchName()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Dim query = "select * from CustomerTbl where CustId=" & CustIdCb.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(query, con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            CustNameTb.Text = reader(1).ToString()
        End While
        con.Close()
    End Sub
    Dim prodname As String
    Dim prodprice As Integer
    Dim ProdQty As Integer
    Private Sub FetchData()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Dim query = "select * from ProductTbl where ProdId=" & ProdIdCb.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(query, con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            prodname = reader(1).ToString()
            prodprice = Convert.ToUInt32(reader(3).ToString())
            ProdQty = Convert.ToUInt32(reader(2).ToString())
            ProdNameTb.Text = prodname
        End While
        con.Close()
        populate()
    End Sub
    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        FillProduct()
        FillCustomer()
        populate()
    End Sub
    Public Sub populate()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Dim sql = "select * from OrdersTbl"
        Dim adapter As New SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        OrderDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub CustIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CustIdCb.SelectionChangeCommitted
        FetchName()
    End Sub
    Private Sub ProdIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ProdIdCb.SelectionChangeCommitted
        FetchData()
    End Sub
    Dim newQty
    Private Sub UpdateProd()
        newQty = ProdQty - Convert.ToInt32(QtyTb.Text)
        con.Open()
        Dim Sql = "update ProductTbl set ProdQty='" + newQty.Text + " where ProdId= " + ProdIdCb.SelectedItem.ToString() + ""
        Dim cmd As New SqlCommand(Sql, con)
        cmd.ExecuteNonQuery()
        con.Close()
        populate()
    End Sub
    Private Sub homebutton_Click(sender As Object, e As EventArgs) Handles homebutton.Click
        Dim home = New Home
        home.Show()
        Me.Hide()
    End Sub

    Private Sub printbutton_Click(sender As Object, e As EventArgs) Handles printbutton.Click
        If QtyTb.Text = "" Or CustNameTb.Text = "" Or ProdNameTb.Text = "" Or CustIdCb.Text = "" Or ProdIdCb.Text = "" Then
            MessageBox.Show("Incomplete Data")
        Else
            AutoNumberNo()
            changelongpaper()
            PrintPreviewDialog1.Document = PD
            PrintPreviewDialog1.ShowDialog()
            BillDGV.Rows.Clear()
            AmtLbl.Text = ""
            Grtot = 0
            i = 0
        End If
    End Sub

    Private Sub InsertOrder()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim query As String
            query = "insert into OrdersTbl values('" + OrderIdTb.Text + "', '" + CustIdCb.SelectedValue.ToString() + "','" + CustNameTb.Text + "','" + AmtLbl.Text + "','" + datetime.Text.ToString() + "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Order Added Succesfully")
            OrderIdTb.Text = ""
            CustIdCb.Text = ""
            CustNameTb.Text = ""
            ProdIdCb.Text = ""
            ProdNameTb.Text = ""
            QtyTb.Text = ""
            con.Close()
            populate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim Grtot = 0, i = 0, Total = 0

    Private Sub delete_Click(sender As Object, e As EventArgs)
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

    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click
        OrderIdTb.Text = ""
        CustIdCb.Text = ""
        CustNameTb.Text = ""
        ProdIdCb.Text = ""
        ProdNameTb.Text = ""
        QtyTb.Text = ""
    End Sub

    Private Sub AutoNumberNo()
        Dim myReader As SqlDataReader
        con.Open()
        Dim temp As String
        Try
            Dim sql As String = "select max(isnull(OrderId,0)) 'OrderId' from OrdersTbl "
            Dim comm As SqlCommand = New SqlCommand(sql, con)
            myReader = comm.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read()
                    Dim _Count As Integer
                    If (IsDBNull(myReader.Item("OrderId"))) Then
                        _Count = 100000000
                    Else
                        _Count = myReader.Item("OrderId")
                    End If
                    temp = _Count + 1
                    Me.OrderIdTb.Text = String.Concat(temp)

                End While
            End If
            myReader.Close()
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Private Sub addbutton_Click(sender As Object, e As EventArgs) Handles addbutton.Click
        If QtyTb.Text = "" Then
            MessageBox.Show("Enter product quantity")
        ElseIf CustNameTb.Text = "" Or ProdNameTb.Text = "" Or CustIdCb.Text = "" Or ProdIdCb.Text = "" Then
            MessageBox.Show("Incomplete data")
        Else
            Dim rnum As Integer = BillDGV.Rows.Add()
            i = i + 1
            Total = prodprice * Convert.ToInt32(QtyTb.Text)
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("Column2").Value = ProdNameTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column3").Value = QtyTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column4").Value = prodprice
            BillDGV.Rows.Item(rnum).Cells("Column5").Value = Total
            Grtot = Grtot + Total
            AmtLbl.Text = Grtot
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datetime.Text = Date.Now.ToString("yyyy-MM-dd  hh:mm:ss")
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint, PrintDocument1.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 300, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage, PrintDocument1.PrintPage

        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "============================================================="
        Dim logoImage As Image = My.Resources.ResourceManager.GetObject("super8")
        e.Graphics.DrawImage(logoImage, CInt((e.PageBounds.Width - 150) / 2), 20, 150, 35)

        e.Graphics.DrawString("SUPER8 GROCERY WAREHOUSE", f8, Brushes.Black, centermargin, 50, center)
        e.Graphics.DrawString("C. Morales Mall Commercial Complex National Highway", f8, Brushes.Black, centermargin, 60, center)
        e.Graphics.DrawString("Barangay San Antonio, Biñan, Laguna", f8, Brushes.Black, centermargin, 70, center)
        e.Graphics.DrawString("Phone +63 49 411 0062", f8, Brushes.Black, centermargin, 80, center)

        e.Graphics.DrawString("ORDER ID", f8, Brushes.Black, 0, 105)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 105)
        e.Graphics.DrawString(OrderIdTb.Text.ToString(), f8, Brushes.Black, 60, 105)
        e.Graphics.DrawString(datetime.Text.ToString(), f8, Brushes.Black, 0, 120)

        e.Graphics.DrawString("QTY", f8, Brushes.Black, 0, 140)
        e.Graphics.DrawString("PRODUCT", f8, Brushes.Black, 25, 140)
        e.Graphics.DrawString("PRICE", f8, Brushes.Black, 260, 140, right)
        e.Graphics.DrawString("TOTAL", f8, Brushes.Black, rightmargin, 140, right)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 150)

        Dim height As Integer
        BillDGV.AllowUserToAddRows = False

        For row As Integer = 0 To BillDGV.RowCount - 1
            height += 15
            e.Graphics.DrawString(BillDGV.Rows(row).Cells(2).Value.ToString, f8, Brushes.Black, 0, 150 + height)
            e.Graphics.DrawString(BillDGV.Rows(row).Cells(1).Value.ToString, f8, Brushes.Black, 25, 150 + height)
            e.Graphics.DrawString(BillDGV.Rows(row).Cells(3).Value.ToString, f8, Brushes.Black, 235, 150 + height)
            e.Graphics.DrawString(BillDGV.Rows(row).Cells(4).Value.ToString, f8, Brushes.Black, 270, 150 + height)
        Next
        Dim height2 As Integer
        height2 = 165 + height

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("TOTAL:", f10, Brushes.Black, centermargin, 10 + height2, center)
        e.Graphics.DrawString(Grtot.ToString, f10b, Brushes.Black, rightmargin, 10 + height2, right)
        Dim gbarcode As New MessagingToolkit.Barcode.BarcodeEncoder
        Try
            Dim barcodeimage As Image
            barcodeimage = New Bitmap(gbarcode.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, OrderIdTb.Text.ToString()))
            e.Graphics.DrawImage(barcodeimage, CInt((e.PageBounds.Width - 150) / 2), 50 + height2, 150, 35)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        e.Graphics.DrawString("Thank you for shopping with us.", f8, Brushes.Black, centermargin, 90 + height2, center)
        e.Graphics.DrawString("THIS RECEIPT SHALL BE VALID FOR", f8, Brushes.Black, centermargin, 105 + height2, center)
        e.Graphics.DrawString("FIVE(5) YEARS FROM THE DATE", f8, Brushes.Black, centermargin, 120 + height2, center)
        e.Graphics.DrawString("OF THE PERMIT TO USE", f8, Brushes.Black, centermargin, 135 + height2, center)

        InsertOrder()
    End Sub
End Class