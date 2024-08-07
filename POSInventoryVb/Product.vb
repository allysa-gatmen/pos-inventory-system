Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Product
    Dim con As New SqlConnection("Data Source=LAPTOP-B351TGH0;Initial Catalog=POSInventoryVbDb;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim i As Integer
    Private Sub addbutton_Click(sender As Object, e As EventArgs) Handles addbutton.Click
        If ProdId.Text = "" Or ProdName.Text = "" Or ProdQty.Text = "" Or ProdPrice.Text = "" Then
            MessageBox.Show("Incomplete data")
        ElseIf ProdCat.Text = "" Then
            MessageBox.Show("Select category")
        Else
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into ProductTbl values('" + ProdId.Text + "','" + ProdName.Text + "','" + ProdQty.Text + "','" + ProdPrice.Text + "','" + ProdCat.SelectedItem.ToString() + "')"
            cmd.ExecuteNonQuery()

            disp_data()
            MessageBox.Show("Product Added Successfully")
            ProdId.Text = ""
            ProdName.Text = ""
            ProdQty.Text = ""
            ProdPrice.Text = ""
            ProdCat.Text = ""
        End If
    End Sub
    Public Sub disp_data()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from ProductTbl"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        ProductDGV.DataSource = dt
    End Sub
    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=LAPTOP-B351TGH0;Initial Catalog=POSInventoryVbDb;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Timer1.Enabled = True
        disp_data()
    End Sub
    Private Sub deletebutton_Click(sender As Object, e As EventArgs) Handles deletebutton.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        If ProdId.Text = "" Then
            MessageBox.Show("Enter the product to be deleted")
        Else
            con.Open()
            Dim ask As MsgBoxResult = MsgBox("Do you really want to delete this product?", MessageBoxButtons.YesNo, "Delete Confirmation")
            If ask = MsgBoxResult.Yes Then
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from ProductTbl where ProdId='" + ProdId.Text + "'"
                cmd.ExecuteNonQuery()

                disp_data()
                MessageBox.Show("Product Deleted Successfully")
                ProdId.Text = ""
                ProdName.Text = ""
                ProdQty.Text = ""
                ProdPrice.Text = ""
                ProdCat.Text = ""
            Else
                MsgBox("You didn't delete this product", MessageBoxButtons.OK, "")
            End If
        End If
    End Sub
    Private Sub ProductDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDGV.CellClick, ProductDGV.CellClick
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            i = Convert.ToInt32(ProductDGV.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from ProductTbl where ProdId =" & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                ProdId.Text = dr.GetValue(0).ToString()
                ProdName.Text = dr.GetValue(1).ToString()
                ProdQty.Text = dr.GetValue(2).ToString()
                ProdPrice.Text = dr.GetValue(3).ToString()
                ProdCat.Text = dr.GetValue(4).ToString()
            End While
        Catch ex As Exception
        End Try
    End Sub
    Private Sub editbutton_Click(sender As Object, e As EventArgs) Handles editbutton.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        If ProdId.Text = "" Or ProdName.Text = "" Or ProdQty.Text = "" Or ProdPrice.Text = "" Then
            MessageBox.Show("Incomplete data")
        Else
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update ProductTbl set ProdId='" + ProdId.Text + "',ProdName='" + ProdName.Text + "',ProdQty='" + ProdQty.Text + "',ProdPrice='" + ProdPrice.Text + "',ProdCat='" + ProdCat.SelectedItem.ToString() + "' where ProdId= " & i & ""
            cmd.ExecuteNonQuery()

            disp_data()
            MessageBox.Show("Product Edited Successfully")
            ProdId.Text = ""
            ProdName.Text = ""
            ProdQty.Text = ""
            ProdPrice.Text = ""
            ProdCat.Text = ""
        End If
    End Sub
    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click
        ProdId.Text = ""
        ProdName.Text = ""
        ProdQty.Text = ""
        ProdPrice.Text = ""
        ProdCat.Text = ""
    End Sub
    Private Sub homebutton_Click(sender As Object, e As EventArgs) Handles homebutton.Click
        Dim home = New Home
        home.Show()
        Me.Hide()
    End Sub
    Private Sub searchtb_TextChanged(sender As Object, e As EventArgs) Handles searchtb.TextChanged
        If searchtb.Text <> "" Then
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("select * from ProductTbl where ProdId like '%" & searchtb.Text & "%' Or ProdName Like '%" & searchtb.Text & "%' or ProdPrice like '%" & searchtb.Text & "'", con)
            Dim ds As New DataSet
            da.Fill(ds, "ProductTbl")
            ProductDGV.DataSource = ds.Tables("ProductTbl").DefaultView
        End If
        If searchtb.Text = "" Then
            disp_data()
        End If
    End Sub
    Private Sub printbutton_Click(sender As Object, e As EventArgs) Handles printbutton.Click
        PrintPreviewDialog1.Document = PrintDoc
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
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
        e.Graphics.DrawString("PRODUCT LIST AS OF", f8b, Brushes.Black, centermargin, 120, center)
        e.Graphics.DrawString(datetime.Text.ToString(), f8b, Brushes.Black, centermargin, 135, center)

        e.Graphics.DrawString("ID", f8, Brushes.Black, 50, 165)
        e.Graphics.DrawString("NAME", f8, Brushes.Black, 100, 165)
        e.Graphics.DrawString("QTY", f8, Brushes.Black, 450, 165)
        e.Graphics.DrawString("PRICE", f8, Brushes.Black, 500, 165)
        e.Graphics.DrawString("CATEGORY", f8, Brushes.Black, 550, 165)

        Dim height As Integer
        ProductDGV.AllowUserToAddRows = False

        For row As Integer = 0 To ProductDGV.RowCount - 1
            height += 15
            e.Graphics.DrawString(ProductDGV.Rows(row).Cells(0).Value.ToString, f8, Brushes.Black, 50, 180 + height)
            e.Graphics.DrawString(ProductDGV.Rows(row).Cells(1).Value.ToString, f8, Brushes.Black, 100, 180 + height)
            e.Graphics.DrawString(ProductDGV.Rows(row).Cells(2).Value.ToString, f8, Brushes.Black, 450, 180 + height)
            e.Graphics.DrawString(ProductDGV.Rows(row).Cells(3).Value.ToString, f8, Brushes.Black, 500, 180 + height)
            e.Graphics.DrawString(ProductDGV.Rows(row).Cells(4).Value.ToString, f8, Brushes.Black, 550, 180 + height)
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datetime.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub
End Class