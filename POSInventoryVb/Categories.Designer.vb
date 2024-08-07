<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categories
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Categories))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CategoryDGV = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.homebutton = New System.Windows.Forms.Button()
        Me.clearbutton = New System.Windows.Forms.Button()
        Me.deletebutton = New System.Windows.Forms.Button()
        Me.editbutton = New System.Windows.Forms.Button()
        Me.addbutton = New System.Windows.Forms.Button()
        Me.CatName = New System.Windows.Forms.TextBox()
        Me.CatId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.searchtb = New System.Windows.Forms.TextBox()
        CType(Me.CategoryDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'CategoryDGV
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CategoryDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CategoryDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CategoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CategoryDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.CategoryDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.CategoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CategoryDGV.Location = New System.Drawing.Point(120, 462)
        Me.CategoryDGV.MultiSelect = False
        Me.CategoryDGV.Name = "CategoryDGV"
        Me.CategoryDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.CategoryDGV.RowTemplate.Height = 33
        Me.CategoryDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CategoryDGV.Size = New System.Drawing.Size(1060, 342)
        Me.CategoryDGV.TabIndex = 92
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(550, 343)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(256, 45)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Category List"
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
        Me.homebutton.TabIndex = 90
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
        Me.clearbutton.Location = New System.Drawing.Point(830, 270)
        Me.clearbutton.Name = "clearbutton"
        Me.clearbutton.Size = New System.Drawing.Size(150, 50)
        Me.clearbutton.TabIndex = 89
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
        Me.deletebutton.Location = New System.Drawing.Point(660, 270)
        Me.deletebutton.Name = "deletebutton"
        Me.deletebutton.Size = New System.Drawing.Size(150, 50)
        Me.deletebutton.TabIndex = 88
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
        Me.editbutton.Location = New System.Drawing.Point(490, 270)
        Me.editbutton.Name = "editbutton"
        Me.editbutton.Size = New System.Drawing.Size(150, 50)
        Me.editbutton.TabIndex = 87
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
        Me.addbutton.Location = New System.Drawing.Point(320, 270)
        Me.addbutton.Name = "addbutton"
        Me.addbutton.Size = New System.Drawing.Size(150, 50)
        Me.addbutton.TabIndex = 86
        Me.addbutton.Text = "Add"
        Me.addbutton.UseVisualStyleBackColor = False
        '
        'CatName
        '
        Me.CatName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CatName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CatName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CatName.Location = New System.Drawing.Point(750, 198)
        Me.CatName.Name = "CatName"
        Me.CatName.Size = New System.Drawing.Size(300, 35)
        Me.CatName.TabIndex = 84
        '
        'CatId
        '
        Me.CatId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CatId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CatId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CatId.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CatId.Location = New System.Drawing.Point(394, 198)
        Me.CatId.Name = "CatId"
        Me.CatId.Size = New System.Drawing.Size(150, 35)
        Me.CatId.TabIndex = 83
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(568, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 27)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Category Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(251, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 27)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Category ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1300, 80)
        Me.Panel1.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(525, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 33)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Manage Categories"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 880)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1300, 20)
        Me.Panel2.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(285, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(731, 45)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "POS with Inventory Management System"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(851, 399)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 40)
        Me.PictureBox1.TabIndex = 94
        Me.PictureBox1.TabStop = False
        '
        'searchtb
        '
        Me.searchtb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.searchtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.searchtb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchtb.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.searchtb.Location = New System.Drawing.Point(399, 400)
        Me.searchtb.Name = "searchtb"
        Me.searchtb.PlaceholderText = " Search"
        Me.searchtb.Size = New System.Drawing.Size(450, 35)
        Me.searchtb.TabIndex = 93
        '
        'Categories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1300, 900)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.searchtb)
        Me.Controls.Add(Me.CategoryDGV)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.homebutton)
        Me.Controls.Add(Me.clearbutton)
        Me.Controls.Add(Me.deletebutton)
        Me.Controls.Add(Me.editbutton)
        Me.Controls.Add(Me.addbutton)
        Me.Controls.Add(Me.CatName)
        Me.Controls.Add(Me.CatId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Categories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Category Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.CategoryDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents CategoryDGV As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents homebutton As Button
    Friend WithEvents clearbutton As Button
    Friend WithEvents deletebutton As Button
    Friend WithEvents editbutton As Button
    Friend WithEvents addbutton As Button
    Friend WithEvents CatName As TextBox
    Friend WithEvents CatId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents searchtb As TextBox
End Class
