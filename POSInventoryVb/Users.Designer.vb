<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Users))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.homebutton = New System.Windows.Forms.Button()
        Me.clearbutton = New System.Windows.Forms.Button()
        Me.deletebutton = New System.Windows.Forms.Button()
        Me.editbutton = New System.Windows.Forms.Button()
        Me.addbutton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UsName = New System.Windows.Forms.TextBox()
        Me.UsId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsPass = New System.Windows.Forms.TextBox()
        Me.UsPhone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UserDGV = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.searchtb = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.UserDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(561, 391)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(179, 45)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "User List"
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
        Me.homebutton.TabIndex = 68
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
        Me.clearbutton.Location = New System.Drawing.Point(830, 327)
        Me.clearbutton.Name = "clearbutton"
        Me.clearbutton.Size = New System.Drawing.Size(150, 50)
        Me.clearbutton.TabIndex = 67
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
        Me.deletebutton.Location = New System.Drawing.Point(660, 327)
        Me.deletebutton.Name = "deletebutton"
        Me.deletebutton.Size = New System.Drawing.Size(150, 50)
        Me.deletebutton.TabIndex = 66
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
        Me.editbutton.Location = New System.Drawing.Point(490, 327)
        Me.editbutton.Name = "editbutton"
        Me.editbutton.Size = New System.Drawing.Size(150, 50)
        Me.editbutton.TabIndex = 65
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
        Me.addbutton.Location = New System.Drawing.Point(320, 327)
        Me.addbutton.Name = "addbutton"
        Me.addbutton.Size = New System.Drawing.Size(150, 50)
        Me.addbutton.TabIndex = 64
        Me.addbutton.Text = "Add"
        Me.addbutton.UseVisualStyleBackColor = False
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
        'UsName
        '
        Me.UsName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UsName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UsName.Location = New System.Drawing.Point(551, 199)
        Me.UsName.Name = "UsName"
        Me.UsName.Size = New System.Drawing.Size(200, 35)
        Me.UsName.TabIndex = 62
        '
        'UsId
        '
        Me.UsId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UsId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsId.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UsId.Location = New System.Drawing.Point(301, 199)
        Me.UsId.Name = "UsId"
        Me.UsId.Size = New System.Drawing.Size(100, 35)
        Me.UsId.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(775, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 27)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(425, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 27)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(205, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 27)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "User ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1300, 80)
        Me.Panel1.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(525, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 33)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Manage Users"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 880)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1300, 20)
        Me.Panel2.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(285, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(731, 45)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "POS with Inventory Management System"
        '
        'UsPass
        '
        Me.UsPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UsPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsPass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UsPass.Location = New System.Drawing.Point(896, 199)
        Me.UsPass.Name = "UsPass"
        Me.UsPass.Size = New System.Drawing.Size(200, 35)
        Me.UsPass.TabIndex = 71
        '
        'UsPhone
        '
        Me.UsPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UsPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsPhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UsPhone.Location = New System.Drawing.Point(613, 260)
        Me.UsPhone.Name = "UsPhone"
        Me.UsPhone.Size = New System.Drawing.Size(160, 35)
        Me.UsPhone.TabIndex = 73
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(527, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 27)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Phone"
        '
        'UserDGV
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UserDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.UserDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UserDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDGV.Location = New System.Drawing.Point(120, 512)
        Me.UserDGV.MultiSelect = False
        Me.UserDGV.Name = "UserDGV"
        Me.UserDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.UserDGV.RowTemplate.Height = 33
        Me.UserDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UserDGV.Size = New System.Drawing.Size(1060, 292)
        Me.UserDGV.TabIndex = 74
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(851, 447)
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
        Me.searchtb.Location = New System.Drawing.Point(399, 448)
        Me.searchtb.Name = "searchtb"
        Me.searchtb.PlaceholderText = " Search"
        Me.searchtb.Size = New System.Drawing.Size(450, 35)
        Me.searchtb.TabIndex = 85
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1300, 900)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.searchtb)
        Me.Controls.Add(Me.UserDGV)
        Me.Controls.Add(Me.UsPhone)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.UsPass)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.homebutton)
        Me.Controls.Add(Me.clearbutton)
        Me.Controls.Add(Me.deletebutton)
        Me.Controls.Add(Me.editbutton)
        Me.Controls.Add(Me.addbutton)
        Me.Controls.Add(Me.UsName)
        Me.Controls.Add(Me.UsId)
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
        Me.Name = "Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " User Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UserDGV, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label2 As Label
    Friend WithEvents UsName As TextBox
    Friend WithEvents UsId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents UsPass As TextBox
    Friend WithEvents UsPhone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents UserDGV As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents searchtb As TextBox
End Class
