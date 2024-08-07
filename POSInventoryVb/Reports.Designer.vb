<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.searchtb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.OrderDGV = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.homebutton = New System.Windows.Forms.Button()
        Me.searchbutton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderIdTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.delete = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.printbutton = New System.Windows.Forms.Button()
        Me.dt = New System.Windows.Forms.Label()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Sumlabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(851, 369)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 40)
        Me.PictureBox1.TabIndex = 108
        Me.PictureBox1.TabStop = False
        '
        'searchtb
        '
        Me.searchtb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.searchtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.searchtb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchtb.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.searchtb.Location = New System.Drawing.Point(399, 368)
        Me.searchtb.Name = "searchtb"
        Me.searchtb.PlaceholderText = " Search"
        Me.searchtb.Size = New System.Drawing.Size(450, 35)
        Me.searchtb.TabIndex = 107
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(553, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(195, 45)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "Order List"
        '
        'OrderDGV
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OrderDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.OrderDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OrderDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderDGV.Location = New System.Drawing.Point(120, 488)
        Me.OrderDGV.MultiSelect = False
        Me.OrderDGV.Name = "OrderDGV"
        Me.OrderDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.OrderDGV.RowTemplate.Height = 33
        Me.OrderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OrderDGV.Size = New System.Drawing.Size(1060, 323)
        Me.OrderDGV.TabIndex = 105
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(536, 451)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 45)
        Me.Label10.TabIndex = 104
        '
        'homebutton
        '
        Me.homebutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.homebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.homebutton.FlatAppearance.BorderSize = 0
        Me.homebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.homebutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.homebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.homebutton.Location = New System.Drawing.Point(575, 820)
        Me.homebutton.Name = "homebutton"
        Me.homebutton.Size = New System.Drawing.Size(150, 50)
        Me.homebutton.TabIndex = 103
        Me.homebutton.Text = "Home"
        Me.homebutton.UseVisualStyleBackColor = False
        '
        'searchbutton
        '
        Me.searchbutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.searchbutton.FlatAppearance.BorderSize = 0
        Me.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.searchbutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.searchbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.searchbutton.Location = New System.Drawing.Point(484, 249)
        Me.searchbutton.Name = "searchbutton"
        Me.searchbutton.Size = New System.Drawing.Size(150, 50)
        Me.searchbutton.TabIndex = 102
        Me.searchbutton.Text = "Search"
        Me.searchbutton.UseVisualStyleBackColor = False
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1300, 80)
        Me.Panel1.TabIndex = 88
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(533, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 33)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Manage Reports"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 880)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1300, 20)
        Me.Panel2.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(285, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(731, 45)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "POS with Inventory Management System"
        '
        'OrderIdTb
        '
        Me.OrderIdTb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OrderIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OrderIdTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OrderIdTb.Enabled = False
        Me.OrderIdTb.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OrderIdTb.Location = New System.Drawing.Point(597, 427)
        Me.OrderIdTb.Name = "OrderIdTb"
        Me.OrderIdTb.Size = New System.Drawing.Size(150, 35)
        Me.OrderIdTb.TabIndex = 110
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(491, 431)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 27)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Order ID"
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.delete.FlatAppearance.BorderSize = 0
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.delete.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.delete.Location = New System.Drawing.Point(123, 491)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(47, 30)
        Me.delete.TabIndex = 114
        Me.delete.Text = "x"
        Me.delete.UseVisualStyleBackColor = False
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.Color.LightSteelBlue
        Me.clear.FlatAppearance.BorderSize = 0
        Me.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clear.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.clear.Location = New System.Drawing.Point(759, 426)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(50, 45)
        Me.clear.TabIndex = 115
        Me.clear.Text = "x"
        Me.clear.UseVisualStyleBackColor = False
        '
        'printbutton
        '
        Me.printbutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.printbutton.FlatAppearance.BorderSize = 0
        Me.printbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.printbutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.printbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.printbutton.Location = New System.Drawing.Point(666, 249)
        Me.printbutton.Name = "printbutton"
        Me.printbutton.Size = New System.Drawing.Size(150, 50)
        Me.printbutton.TabIndex = 116
        Me.printbutton.Text = "Print"
        Me.printbutton.UseVisualStyleBackColor = False
        '
        'dt
        '
        Me.dt.AutoSize = True
        Me.dt.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dt.ForeColor = System.Drawing.Color.White
        Me.dt.Location = New System.Drawing.Point(12, 289)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(30, 24)
        Me.dt.TabIndex = 117
        Me.dt.Text = "    "
        '
        'PrintDoc
        '
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
        'DTP1
        '
        Me.DTP1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DTP1.Location = New System.Drawing.Point(329, 195)
        Me.DTP1.MinDate = New Date(2022, 5, 31, 0, 0, 0, 0)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(300, 30)
        Me.DTP1.TabIndex = 118
        Me.DTP1.Value = New Date(2022, 6, 1, 0, 0, 0, 0)
        '
        'DTP2
        '
        Me.DTP2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DTP2.Location = New System.Drawing.Point(671, 195)
        Me.DTP2.MinDate = New Date(2022, 6, 1, 0, 0, 0, 0)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(300, 30)
        Me.DTP2.TabIndex = 119
        Me.DTP2.Value = New Date(2022, 6, 2, 0, 0, 0, 0)
        '
        'Timer1
        '
        '
        'Sumlabel
        '
        Me.Sumlabel.AutoSize = True
        Me.Sumlabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Sumlabel.ForeColor = System.Drawing.Color.White
        Me.Sumlabel.Location = New System.Drawing.Point(1122, 382)
        Me.Sumlabel.Name = "Sumlabel"
        Me.Sumlabel.Size = New System.Drawing.Size(40, 27)
        Me.Sumlabel.TabIndex = 121
        Me.Sumlabel.Text = "    "
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1300, 900)
        Me.Controls.Add(Me.Sumlabel)
        Me.Controls.Add(Me.DTP2)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.printbutton)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.OrderIdTb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.searchtb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.OrderDGV)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.homebutton)
        Me.Controls.Add(Me.searchbutton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Report Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents searchtb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents OrderDGV As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents homebutton As Button
    Friend WithEvents searchbutton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents OrderIdTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents delete As Button
    Friend WithEvents clear As Button
    Friend WithEvents printbutton As Button
    Friend WithEvents dt As Label
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents DTP2 As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Sumlabel As Label
End Class
