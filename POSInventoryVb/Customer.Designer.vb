<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.homebutton = New System.Windows.Forms.Button()
        Me.clearbutton = New System.Windows.Forms.Button()
        Me.deletebutton = New System.Windows.Forms.Button()
        Me.editbutton = New System.Windows.Forms.Button()
        Me.addbutton = New System.Windows.Forms.Button()
        Me.CustPhone = New System.Windows.Forms.TextBox()
        Me.CustName = New System.Windows.Forms.TextBox()
        Me.CustId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerDGV = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.OrderCountLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MaxOrderLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.CustCountLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.searchtb = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.CustomerDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(518, 435)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(265, 45)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Customer List"
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
        Me.homebutton.TabIndex = 51
        Me.homebutton.Text = "Home"
        Me.homebutton.UseVisualStyleBackColor = False
        '
        'clearbutton
        '
        Me.clearbutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.clearbutton.FlatAppearance.BorderSize = 0
        Me.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clearbutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.clearbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.clearbutton.Location = New System.Drawing.Point(830, 374)
        Me.clearbutton.Name = "clearbutton"
        Me.clearbutton.Size = New System.Drawing.Size(150, 50)
        Me.clearbutton.TabIndex = 50
        Me.clearbutton.Text = "Clear"
        Me.clearbutton.UseVisualStyleBackColor = False
        '
        'deletebutton
        '
        Me.deletebutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.deletebutton.FlatAppearance.BorderSize = 0
        Me.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.deletebutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.deletebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.deletebutton.Location = New System.Drawing.Point(660, 374)
        Me.deletebutton.Name = "deletebutton"
        Me.deletebutton.Size = New System.Drawing.Size(150, 50)
        Me.deletebutton.TabIndex = 49
        Me.deletebutton.Text = "Delete"
        Me.deletebutton.UseVisualStyleBackColor = False
        '
        'editbutton
        '
        Me.editbutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.editbutton.FlatAppearance.BorderSize = 0
        Me.editbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.editbutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.editbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.editbutton.Location = New System.Drawing.Point(490, 374)
        Me.editbutton.Name = "editbutton"
        Me.editbutton.Size = New System.Drawing.Size(150, 50)
        Me.editbutton.TabIndex = 48
        Me.editbutton.Text = "Edit"
        Me.editbutton.UseVisualStyleBackColor = False
        '
        'addbutton
        '
        Me.addbutton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.addbutton.FlatAppearance.BorderSize = 0
        Me.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addbutton.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.addbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.addbutton.Location = New System.Drawing.Point(320, 374)
        Me.addbutton.Name = "addbutton"
        Me.addbutton.Size = New System.Drawing.Size(150, 50)
        Me.addbutton.TabIndex = 47
        Me.addbutton.Text = "Add"
        Me.addbutton.UseVisualStyleBackColor = False
        '
        'CustPhone
        '
        Me.CustPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CustPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustPhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CustPhone.Location = New System.Drawing.Point(986, 196)
        Me.CustPhone.Name = "CustPhone"
        Me.CustPhone.Size = New System.Drawing.Size(200, 35)
        Me.CustPhone.TabIndex = 44
        '
        'CustName
        '
        Me.CustName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CustName.Location = New System.Drawing.Point(578, 196)
        Me.CustName.Name = "CustName"
        Me.CustName.Size = New System.Drawing.Size(300, 35)
        Me.CustName.TabIndex = 43
        '
        'CustId
        '
        Me.CustId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CustId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustId.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CustId.Location = New System.Drawing.Point(264, 196)
        Me.CustId.Name = "CustId"
        Me.CustId.Size = New System.Drawing.Size(100, 35)
        Me.CustId.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(900, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 27)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(388, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 27)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Customer Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(115, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 27)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Customer ID"
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
        Me.Panel1.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(525, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 33)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Manage Customers"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 880)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1300, 20)
        Me.Panel2.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(285, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(731, 45)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "POS with Inventory Management System"
        '
        'CustomerDGV
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CustomerDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.CustomerDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomerDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDGV.Location = New System.Drawing.Point(120, 554)
        Me.CustomerDGV.MultiSelect = False
        Me.CustomerDGV.Name = "CustomerDGV"
        Me.CustomerDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.CustomerDGV.RowTemplate.Height = 33
        Me.CustomerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomerDGV.Size = New System.Drawing.Size(1060, 250)
        Me.CustomerDGV.TabIndex = 75
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.OrderCountLabel)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(239, 259)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 87)
        Me.Panel3.TabIndex = 76
        '
        'OrderCountLabel
        '
        Me.OrderCountLabel.AutoSize = True
        Me.OrderCountLabel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OrderCountLabel.ForeColor = System.Drawing.Color.Gray
        Me.OrderCountLabel.Location = New System.Drawing.Point(88, 38)
        Me.OrderCountLabel.Name = "OrderCountLabel"
        Me.OrderCountLabel.Size = New System.Drawing.Size(78, 33)
        Me.OrderCountLabel.TabIndex = 39
        Me.OrderCountLabel.Text = "NUM"
        Me.OrderCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(43, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 27)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Orders Count"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.MaxOrderLabel)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Location = New System.Drawing.Point(525, 259)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(250, 87)
        Me.Panel4.TabIndex = 77
        '
        'MaxOrderLabel
        '
        Me.MaxOrderLabel.AutoSize = True
        Me.MaxOrderLabel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MaxOrderLabel.ForeColor = System.Drawing.Color.Gray
        Me.MaxOrderLabel.Location = New System.Drawing.Point(76, 39)
        Me.MaxOrderLabel.Name = "MaxOrderLabel"
        Me.MaxOrderLabel.Size = New System.Drawing.Size(78, 33)
        Me.MaxOrderLabel.TabIndex = 39
        Me.MaxOrderLabel.Text = "NUM"
        Me.MaxOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(17, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(218, 27)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Highest Paid Order"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.CustCountLabel)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Location = New System.Drawing.Point(811, 259)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(250, 87)
        Me.Panel5.TabIndex = 78
        '
        'CustCountLabel
        '
        Me.CustCountLabel.AutoSize = True
        Me.CustCountLabel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CustCountLabel.ForeColor = System.Drawing.Color.Gray
        Me.CustCountLabel.Location = New System.Drawing.Point(88, 39)
        Me.CustCountLabel.Name = "CustCountLabel"
        Me.CustCountLabel.Size = New System.Drawing.Size(78, 33)
        Me.CustCountLabel.TabIndex = 38
        Me.CustCountLabel.Text = "NUM"
        Me.CustCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(24, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(200, 27)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Customers Count"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(851, 491)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 40)
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'searchtb
        '
        Me.searchtb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.searchtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.searchtb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchtb.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.searchtb.Location = New System.Drawing.Point(399, 492)
        Me.searchtb.Name = "searchtb"
        Me.searchtb.PlaceholderText = " Search"
        Me.searchtb.Size = New System.Drawing.Size(450, 35)
        Me.searchtb.TabIndex = 85
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1300, 900)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.searchtb)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.CustomerDGV)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.homebutton)
        Me.Controls.Add(Me.clearbutton)
        Me.Controls.Add(Me.deletebutton)
        Me.Controls.Add(Me.editbutton)
        Me.Controls.Add(Me.addbutton)
        Me.Controls.Add(Me.CustPhone)
        Me.Controls.Add(Me.CustName)
        Me.Controls.Add(Me.CustId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Customer Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CustomerDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As Label
    Friend WithEvents homebutton As Button
    Friend WithEvents clearbutton As Button
    Friend WithEvents deletebutton As Button
    Friend WithEvents editbutton As Button
    Friend WithEvents addbutton As Button
    Friend WithEvents CustPhone As TextBox
    Friend WithEvents CustName As TextBox
    Friend WithEvents CustId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CustomerDGV As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents CustCountLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents OrderCountLabel As Label
    Friend WithEvents MaxOrderLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents searchtb As TextBox
End Class
