<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuanLiKhachHang
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
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvListKhachHang = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btXoaKhachHang = New System.Windows.Forms.Button()
        Me.btCapNhatKhachHang = New System.Windows.Forms.Button()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTienNoKH = New System.Windows.Forms.TextBox()
        Me.txtHoTenKH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.btTimKiemTheHoTen = New System.Windows.Forms.Button()
        Me.btTimKiemTheoMAKH = New System.Windows.Forms.Button()
        Me.txtMaKHTimKiem = New System.Windows.Forms.TextBox()
        Me.txtHoTenKHTimKiem = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvListKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(135, 224)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(644, 191)
        Me.TabControl2.TabIndex = 32
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvListKhachHang)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(636, 165)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Danh Sách Khách Hàng"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvListKhachHang
        '
        Me.dgvListKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListKhachHang.Location = New System.Drawing.Point(6, 6)
        Me.dgvListKhachHang.Name = "dgvListKhachHang"
        Me.dgvListKhachHang.Size = New System.Drawing.Size(624, 153)
        Me.dgvListKhachHang.TabIndex = 19
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(139, 421)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(644, 267)
        Me.TabControl1.TabIndex = 31
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btXoaKhachHang)
        Me.TabPage1.Controls.Add(Me.btCapNhatKhachHang)
        Me.TabPage1.Controls.Add(Me.txtDiaChi)
        Me.TabPage1.Controls.Add(Me.txtSDT)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtTienNoKH)
        Me.TabPage1.Controls.Add(Me.txtHoTenKH)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtMaKH)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(636, 241)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Khách Hàng"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btXoaKhachHang
        '
        Me.btXoaKhachHang.Location = New System.Drawing.Point(320, 212)
        Me.btXoaKhachHang.Name = "btXoaKhachHang"
        Me.btXoaKhachHang.Size = New System.Drawing.Size(75, 23)
        Me.btXoaKhachHang.TabIndex = 32
        Me.btXoaKhachHang.Text = "Xóa"
        Me.btXoaKhachHang.UseVisualStyleBackColor = True
        '
        'btCapNhatKhachHang
        '
        Me.btCapNhatKhachHang.Location = New System.Drawing.Point(239, 212)
        Me.btCapNhatKhachHang.Name = "btCapNhatKhachHang"
        Me.btCapNhatKhachHang.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhatKhachHang.TabIndex = 31
        Me.btCapNhatKhachHang.Text = "Cập nhật"
        Me.btCapNhatKhachHang.UseVisualStyleBackColor = True
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(175, 85)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(294, 67)
        Me.txtDiaChi.TabIndex = 34
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(175, 182)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(294, 20)
        Me.txtSDT.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Số Điện Thoại"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(175, 158)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(294, 20)
        Me.txtEmail.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Địa Chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Tiền Nợ Khách Hàng"
        '
        'txtTienNoKH
        '
        Me.txtTienNoKH.Location = New System.Drawing.Point(175, 59)
        Me.txtTienNoKH.Name = "txtTienNoKH"
        Me.txtTienNoKH.Size = New System.Drawing.Size(294, 20)
        Me.txtTienNoKH.TabIndex = 20
        '
        'txtHoTenKH
        '
        Me.txtHoTenKH.Location = New System.Drawing.Point(175, 33)
        Me.txtHoTenKH.Name = "txtHoTenKH"
        Me.txtHoTenKH.Size = New System.Drawing.Size(294, 20)
        Me.txtHoTenKH.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Họ Tên Khách Hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Mã Khách Hàng"
        '
        'txtMaKH
        '
        Me.txtMaKH.Enabled = False
        Me.txtMaKH.Location = New System.Drawing.Point(175, 7)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.ReadOnly = True
        Me.txtMaKH.Size = New System.Drawing.Size(294, 20)
        Me.txtMaKH.TabIndex = 16
        Me.txtMaKH.WordWrap = False
        '
        'btTimKiemTheHoTen
        '
        Me.btTimKiemTheHoTen.Location = New System.Drawing.Point(282, 54)
        Me.btTimKiemTheHoTen.Name = "btTimKiemTheHoTen"
        Me.btTimKiemTheHoTen.Size = New System.Drawing.Size(75, 20)
        Me.btTimKiemTheHoTen.TabIndex = 39
        Me.btTimKiemTheHoTen.Text = "Tìm"
        Me.btTimKiemTheHoTen.UseVisualStyleBackColor = True
        '
        'btTimKiemTheoMAKH
        '
        Me.btTimKiemTheoMAKH.Location = New System.Drawing.Point(282, 28)
        Me.btTimKiemTheoMAKH.Name = "btTimKiemTheoMAKH"
        Me.btTimKiemTheoMAKH.Size = New System.Drawing.Size(75, 20)
        Me.btTimKiemTheoMAKH.TabIndex = 38
        Me.btTimKiemTheoMAKH.Text = "Tìm "
        Me.btTimKiemTheoMAKH.UseVisualStyleBackColor = True
        '
        'txtMaKHTimKiem
        '
        Me.txtMaKHTimKiem.Location = New System.Drawing.Point(125, 31)
        Me.txtMaKHTimKiem.Name = "txtMaKHTimKiem"
        Me.txtMaKHTimKiem.Size = New System.Drawing.Size(138, 20)
        Me.txtMaKHTimKiem.TabIndex = 37
        '
        'txtHoTenKHTimKiem
        '
        Me.txtHoTenKHTimKiem.Location = New System.Drawing.Point(125, 54)
        Me.txtHoTenKHTimKiem.Name = "txtHoTenKHTimKiem"
        Me.txtHoTenKHTimKiem.Size = New System.Drawing.Size(138, 20)
        Me.txtHoTenKHTimKiem.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Tên Khách Hàng"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Mã Khách Hàng"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btTimKiemTheHoTen)
        Me.GroupBox1.Controls.Add(Me.txtMaKHTimKiem)
        Me.GroupBox1.Controls.Add(Me.btTimKiemTheoMAKH)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtHoTenKHTimKiem)
        Me.GroupBox1.Location = New System.Drawing.Point(135, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 105)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm Khách Hàng"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(468, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 20)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Tìm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(468, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 20)
        Me.TextBox1.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(387, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Số Điện Thoại"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(281, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(316, 31)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "QUẢN LÝ KHÁCH HÀNG"
        '
        'frmQuanLiKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(901, 703)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmQuanLiKhachHang"
        Me.Text = "frmQuanLiKhachHang"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvListKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvListKhachHang As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btXoaKhachHang As Button
    Friend WithEvents btCapNhatKhachHang As Button
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTienNoKH As TextBox
    Friend WithEvents txtHoTenKH As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents btTimKiemTheHoTen As Button
    Friend WithEvents btTimKiemTheoMAKH As Button
    Friend WithEvents txtMaKHTimKiem As TextBox
    Friend WithEvents txtHoTenKHTimKiem As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
