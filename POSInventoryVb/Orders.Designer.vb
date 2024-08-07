<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Orders
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orders))
        Me.OrderDGV = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.homebutton = New System.Windows.Forms.Button()
        Me.addbutton = New System.Windows.Forms.Button()
        Me.OrderIdTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustIdCb = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BillDGV = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProdIdCb = New System.Windows.Forms.ComboBox()
        Me.CustNameTb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ProdNameTb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.QtyTb = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.printbutton = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.AmtLbl = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.clearbutton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.datetime = New System.Windows.Forms.Label()
        CType(Me.OrderDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BillDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderDGV
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OrderDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.OrderDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.OrderDGV.BackgroundColor = System.Drawing.Color.White
        Me.OrderDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderDGV.GridColor = System.Drawing.Color.White
        Me.OrderDGV.Location = New System.Drawing.Point(779, 630)
        Me.OrderDGV.MultiSelect = False
        Me.OrderDGV.Name = "OrderDGV"
        Me.OrderDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.OrderDGV.RowTemplate.Height = 33
        Me.OrderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OrderDGV.Size = New System.Drawing.Size(29, 10)
        Me.OrderDGV.TabIndex = 93
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(400, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(500, 43)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Super8 Grocery Warehouse"
        '
        'homebutton
        '
        Me.homebutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.homebutton.FlatAppearance.BorderSize = 0
        Me.homebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.homebutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.homebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.homebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.homebutton.Location = New System.Drawing.Point(575, 820)
        Me.homebutton.Name = "homebutton"
        Me.homebutton.Size = New System.Drawing.Size(150, 50)
        Me.homebutton.TabIndex = 88
        Me.homebutton.Text = "Home"
        Me.homebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.homebutton.UseVisualStyleBackColor = False
        '
        'addbutton
        '
        Me.addbutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.addbutton.FlatAppearance.BorderSize = 0
        Me.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addbutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.addbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.addbutton.Location = New System.Drawing.Point(400, 339)
        Me.addbutton.Name = "addbutton"
        Me.addbutton.Size = New System.Drawing.Size(150, 50)
        Me.addbutton.TabIndex = 84
        Me.addbutton.Text = "Add To Bill"
        Me.addbutton.UseVisualStyleBackColor = False
        '
        'OrderIdTb
        '
        Me.OrderIdTb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OrderIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OrderIdTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OrderIdTb.Enabled = False
        Me.OrderIdTb.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OrderIdTb.Location = New System.Drawing.Point(255, 204)
        Me.OrderIdTb.Name = "OrderIdTb"
        Me.OrderIdTb.Size = New System.Drawing.Size(100, 35)
        Me.OrderIdTb.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(147, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 27)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Order ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1300, 80)
        Me.Panel1.TabIndex = 78
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(540, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 33)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Manage Orders"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 880)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1300, 20)
        Me.Panel2.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(285, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(731, 45)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "POS with Inventory Management System"
        '
        'CustIdCb
        '
        Me.CustIdCb.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CustIdCb.FormattingEnabled = True
        Me.CustIdCb.Location = New System.Drawing.Point(535, 204)
        Me.CustIdCb.Name = "CustIdCb"
        Me.CustIdCb.Size = New System.Drawing.Size(120, 35)
        Me.CustIdCb.Sorted = True
        Me.CustIdCb.TabIndex = 94
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(385, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 27)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Customer ID"
        '
        'BillDGV
        '
        Me.BillDGV.AllowUserToResizeRows = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BillDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.BillDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BillDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BillDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.BillDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BillDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BillDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BillDGV.DefaultCellStyle = DataGridViewCellStyle4
        Me.BillDGV.Location = New System.Drawing.Point(120, 445)
        Me.BillDGV.MultiSelect = False
        Me.BillDGV.Name = "BillDGV"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BillDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.BillDGV.RowHeadersVisible = False
        Me.BillDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.BillDGV.RowTemplate.Height = 33
        Me.BillDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BillDGV.Size = New System.Drawing.Size(1060, 365)
        Me.BillDGV.TabIndex = 96
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.FillWeight = 30.0!
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.FillWeight = 250.0!
        Me.Column2.HeaderText = "Product"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.FillWeight = 30.0!
        Me.Column3.HeaderText = "Qty"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.FillWeight = 30.0!
        Me.Column4.HeaderText = "Price"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.FillWeight = 50.0!
        Me.Column5.HeaderText = "Total"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(119, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 27)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Product ID"
        '
        'ProdIdCb
        '
        Me.ProdIdCb.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProdIdCb.FormattingEnabled = True
        Me.ProdIdCb.Location = New System.Drawing.Point(249, 270)
        Me.ProdIdCb.Name = "ProdIdCb"
        Me.ProdIdCb.Size = New System.Drawing.Size(120, 35)
        Me.ProdIdCb.TabIndex = 99
        '
        'CustNameTb
        '
        Me.CustNameTb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CustNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustNameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustNameTb.Enabled = False
        Me.CustNameTb.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CustNameTb.Location = New System.Drawing.Point(873, 204)
        Me.CustNameTb.Name = "CustNameTb"
        Me.CustNameTb.Size = New System.Drawing.Size(280, 35)
        Me.CustNameTb.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(683, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 27)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Customer Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(1027, 402)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 29)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Bill:"
        '
        'ProdNameTb
        '
        Me.ProdNameTb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProdNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdNameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProdNameTb.Enabled = False
        Me.ProdNameTb.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProdNameTb.Location = New System.Drawing.Point(772, 270)
        Me.ProdNameTb.Name = "ProdNameTb"
        Me.ProdNameTb.Size = New System.Drawing.Size(410, 35)
        Me.ProdNameTb.TabIndex = 103
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(602, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 27)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "Product Name"
        '
        'QtyTb
        '
        Me.QtyTb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.QtyTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QtyTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.QtyTb.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.QtyTb.Location = New System.Drawing.Point(500, 270)
        Me.QtyTb.Name = "QtyTb"
        Me.QtyTb.Size = New System.Drawing.Size(80, 35)
        Me.QtyTb.TabIndex = 105
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(393, 272)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 27)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "Quantity"
        '
        'printbutton
        '
        Me.printbutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.printbutton.FlatAppearance.BorderSize = 0
        Me.printbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.printbutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.printbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.printbutton.Location = New System.Drawing.Point(750, 339)
        Me.printbutton.Name = "printbutton"
        Me.printbutton.Size = New System.Drawing.Size(150, 50)
        Me.printbutton.TabIndex = 108
        Me.printbutton.Text = "Print"
        Me.printbutton.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'AmtLbl
        '
        Me.AmtLbl.AutoSize = True
        Me.AmtLbl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AmtLbl.ForeColor = System.Drawing.Color.Black
        Me.AmtLbl.Location = New System.Drawing.Point(1121, 398)
        Me.AmtLbl.Name = "AmtLbl"
        Me.AmtLbl.Size = New System.Drawing.Size(69, 29)
        Me.AmtLbl.TabIndex = 106
        Me.AmtLbl.Text = "        "
        Me.AmtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(1091, 402)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 29)
        Me.Label12.TabIndex = 109
        Me.Label12.Text = "₱"
        '
        'clearbutton
        '
        Me.clearbutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.clearbutton.FlatAppearance.BorderSize = 0
        Me.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clearbutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.clearbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.clearbutton.Location = New System.Drawing.Point(575, 339)
        Me.clearbutton.Name = "clearbutton"
        Me.clearbutton.Size = New System.Drawing.Size(150, 50)
        Me.clearbutton.TabIndex = 110
        Me.clearbutton.Text = "Clear"
        Me.clearbutton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'datetime
        '
        Me.datetime.AutoSize = True
        Me.datetime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.datetime.Location = New System.Drawing.Point(115, 398)
        Me.datetime.Name = "datetime"
        Me.datetime.Size = New System.Drawing.Size(41, 29)
        Me.datetime.TabIndex = 114
        Me.datetime.Text = "    "
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1300, 900)
        Me.Controls.Add(Me.datetime)
        Me.Controls.Add(Me.clearbutton)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.printbutton)
        Me.Controls.Add(Me.AmtLbl)
        Me.Controls.Add(Me.QtyTb)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ProdNameTb)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProdIdCb)
        Me.Controls.Add(Me.CustNameTb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BillDGV)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CustIdCb)
        Me.Controls.Add(Me.OrderDGV)
        Me.Controls.Add(Me.homebutton)
        Me.Controls.Add(Me.addbutton)
        Me.Controls.Add(Me.OrderIdTb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Orders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Order Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.OrderDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BillDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OrderDGV As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents homebutton As Button
    Friend WithEvents addbutton As Button
    Friend WithEvents OrderIdTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CustIdCb As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BillDGV As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents ProdIdCb As ComboBox
    Friend WithEvents CustNameTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ProdNameTb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents QtyTb As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents printbutton As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents AmtLbl As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents clearbutton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents datetime As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
