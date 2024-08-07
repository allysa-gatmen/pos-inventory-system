<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ProdCat = New System.Windows.Forms.ComboBox()
        Me.ProdId = New System.Windows.Forms.TextBox()
        Me.ProdName = New System.Windows.Forms.TextBox()
        Me.ProdQty = New System.Windows.Forms.TextBox()
        Me.ProdPrice = New System.Windows.Forms.TextBox()
        Me.addbutton = New System.Windows.Forms.Button()
        Me.editbutton = New System.Windows.Forms.Button()
        Me.deletebutton = New System.Windows.Forms.Button()
        Me.clearbutton = New System.Windows.Forms.Button()
        Me.homebutton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProductDGV = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.searchtb = New System.Windows.Forms.TextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.printbutton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.datetime = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(285, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(731, 45)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "POS with Inventory Management System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 880)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1300, 20)
        Me.Panel2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(525, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 33)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Manage Products"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1300, 80)
        Me.Panel1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(400, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(500, 43)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Super8 Grocery Warehouse"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(122, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 27)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Product ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(378, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 27)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Product Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(275, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 27)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Quantity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(1008, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 27)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Price"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(505, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 27)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Category"
        '
        'ProdCat
        '
        Me.ProdCat.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProdCat.FormattingEnabled = True
        Me.ProdCat.Items.AddRange(New Object() {"BABY CARE", "BAKERY", "BEVERAGES", "CANNED GOODS & COMMODITIES", "COOKING & CONDIMENTS", "DAIRY & EGGS", "FROZEN", "HEALTH & BEAUTY", "LAUNDRY"})
        Me.ProdCat.Location = New System.Drawing.Point(618, 260)
        Me.ProdCat.Name = "ProdCat"
        Me.ProdCat.Size = New System.Drawing.Size(407, 35)
        Me.ProdCat.Sorted = True
        Me.ProdCat.TabIndex = 18
        '
        'ProdId
        '
        Me.ProdId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProdId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProdId.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProdId.Location = New System.Drawing.Point(252, 199)
        Me.ProdId.Name = "ProdId"
        Me.ProdId.Size = New System.Drawing.Size(100, 35)
        Me.ProdId.TabIndex = 19
        '
        'ProdName
        '
        Me.ProdName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProdName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProdName.Location = New System.Drawing.Point(548, 199)
        Me.ProdName.Name = "ProdName"
        Me.ProdName.Size = New System.Drawing.Size(436, 35)
        Me.ProdName.TabIndex = 20
        '
        'ProdQty
        '
        Me.ProdQty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProdQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProdQty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProdQty.Location = New System.Drawing.Point(382, 260)
        Me.ProdQty.Name = "ProdQty"
        Me.ProdQty.Size = New System.Drawing.Size(100, 35)
        Me.ProdQty.TabIndex = 21
        '
        'ProdPrice
        '
        Me.ProdPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProdPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProdPrice.Location = New System.Drawing.Point(1078, 200)
        Me.ProdPrice.Name = "ProdPrice"
        Me.ProdPrice.Size = New System.Drawing.Size(100, 35)
        Me.ProdPrice.TabIndex = 22
        '
        'addbutton
        '
        Me.addbutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.addbutton.FlatAppearance.BorderSize = 0
        Me.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addbutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.addbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.addbutton.Location = New System.Drawing.Point(235, 329)
        Me.addbutton.Name = "addbutton"
        Me.addbutton.Size = New System.Drawing.Size(150, 50)
        Me.addbutton.TabIndex = 24
        Me.addbutton.Text = "Add"
        Me.addbutton.UseVisualStyleBackColor = False
        '
        'editbutton
        '
        Me.editbutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.editbutton.FlatAppearance.BorderSize = 0
        Me.editbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.editbutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.editbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.editbutton.Location = New System.Drawing.Point(405, 329)
        Me.editbutton.Name = "editbutton"
        Me.editbutton.Size = New System.Drawing.Size(150, 50)
        Me.editbutton.TabIndex = 25
        Me.editbutton.Text = "Edit"
        Me.editbutton.UseVisualStyleBackColor = False
        '
        'deletebutton
        '
        Me.deletebutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.deletebutton.FlatAppearance.BorderSize = 0
        Me.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.deletebutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.deletebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.deletebutton.Location = New System.Drawing.Point(575, 329)
        Me.deletebutton.Name = "deletebutton"
        Me.deletebutton.Size = New System.Drawing.Size(150, 50)
        Me.deletebutton.TabIndex = 26
        Me.deletebutton.Text = "Delete"
        Me.deletebutton.UseVisualStyleBackColor = False
        '
        'clearbutton
        '
        Me.clearbutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.clearbutton.FlatAppearance.BorderSize = 0
        Me.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clearbutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.clearbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.clearbutton.Location = New System.Drawing.Point(745, 329)
        Me.clearbutton.Name = "clearbutton"
        Me.clearbutton.Size = New System.Drawing.Size(150, 50)
        Me.clearbutton.TabIndex = 27
        Me.clearbutton.Text = "Clear"
        Me.clearbutton.UseVisualStyleBackColor = False
        '
        'homebutton
        '
        Me.homebutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.homebutton.FlatAppearance.BorderSize = 0
        Me.homebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.homebutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.homebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.homebutton.Location = New System.Drawing.Point(575, 820)
        Me.homebutton.Name = "homebutton"
        Me.homebutton.Size = New System.Drawing.Size(150, 50)
        Me.homebutton.TabIndex = 28
        Me.homebutton.Text = "Home"
        Me.homebutton.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(524, 385)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 45)
        Me.Label10.TabIndex = 29
        '
        'ProductDGV
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProductDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ProductDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ProductDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDGV.Location = New System.Drawing.Point(120, 517)
        Me.ProductDGV.MaximumSize = New System.Drawing.Size(1197, 355)
        Me.ProductDGV.MultiSelect = False
        Me.ProductDGV.Name = "ProductDGV"
        Me.ProductDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.ProductDGV.RowTemplate.Height = 33
        Me.ProductDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductDGV.Size = New System.Drawing.Size(1060, 293)
        Me.ProductDGV.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(534, 394)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(233, 45)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Product List"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(851, 450)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 40)
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'searchtb
        '
        Me.searchtb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.searchtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.searchtb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchtb.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.searchtb.Location = New System.Drawing.Point(399, 451)
        Me.searchtb.Name = "searchtb"
        Me.searchtb.PlaceholderText = " Search"
        Me.searchtb.Size = New System.Drawing.Size(450, 35)
        Me.searchtb.TabIndex = 83
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDoc
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDoc
        '
        '
        'printbutton
        '
        Me.printbutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.printbutton.FlatAppearance.BorderSize = 0
        Me.printbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.printbutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.printbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.printbutton.Location = New System.Drawing.Point(915, 329)
        Me.printbutton.Name = "printbutton"
        Me.printbutton.Size = New System.Drawing.Size(150, 50)
        Me.printbutton.TabIndex = 85
        Me.printbutton.Text = "Print"
        Me.printbutton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'datetime
        '
        Me.datetime.AutoSize = True
        Me.datetime.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.datetime.ForeColor = System.Drawing.Color.White
        Me.datetime.Location = New System.Drawing.Point(29, 439)
        Me.datetime.Name = "datetime"
        Me.datetime.Size = New System.Drawing.Size(30, 24)
        Me.datetime.TabIndex = 115
        Me.datetime.Text = "    "
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1300, 900)
        Me.Controls.Add(Me.datetime)
        Me.Controls.Add(Me.printbutton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.searchtb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ProductDGV)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.homebutton)
        Me.Controls.Add(Me.clearbutton)
        Me.Controls.Add(Me.deletebutton)
        Me.Controls.Add(Me.editbutton)
        Me.Controls.Add(Me.addbutton)
        Me.Controls.Add(Me.ProdPrice)
        Me.Controls.Add(Me.ProdQty)
        Me.Controls.Add(Me.ProdName)
        Me.Controls.Add(Me.ProdId)
        Me.Controls.Add(Me.ProdCat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1322, 956)
        Me.MinimumSize = New System.Drawing.Size(1322, 956)
        Me.Name = "Product"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Product Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProductDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ProdCat As ComboBox
    Friend WithEvents ProdId As TextBox
    Friend WithEvents ProdName As TextBox
    Friend WithEvents ProdQty As TextBox
    Friend WithEvents ProdPrice As TextBox
    Friend WithEvents addbutton As Button
    Friend WithEvents editbutton As Button
    Friend WithEvents deletebutton As Button
    Friend WithEvents clearbutton As Button
    Friend WithEvents homebutton As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ProductDGV As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents searchtb As TextBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents printbutton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents datetime As Label
End Class
