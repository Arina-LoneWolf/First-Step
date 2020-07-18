<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPhieuNhapSach
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
        Me.lblMain = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvListsach = New System.Windows.Forms.DataGridView()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGiaNhap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnIn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbTheloai = New System.Windows.Forms.ComboBox()
        Me.btnThemvaodanhsach = New System.Windows.Forms.Button()
        Me.btnQuydinh = New System.Windows.Forms.Button()
        Me.tbxDongia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxSoLuong = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxTacGia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxTenSach = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpNgaynhap = New System.Windows.Forms.DateTimePicker()
        Me.tbMaphieunhap = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvListsach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Blue
        Me.lblMain.Location = New System.Drawing.Point(321, 22)
        Me.lblMain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(407, 38)
        Me.lblMain.TabIndex = 58
        Me.lblMain.Text = "LẬP PHIẾU NHẬP SÁCH"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(81, 363)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(992, 184)
        Me.TabControl2.TabIndex = 61
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvListsach)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(984, 155)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Chi tiết phiếu nhập"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvListsach
        '
        Me.dgvListsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListsach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.Sach, Me.TheLoai, Me.TacGia, Me.SoLuong, Me.DonGiaNhap})
        Me.dgvListsach.Location = New System.Drawing.Point(7, 4)
        Me.dgvListsach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvListsach.Name = "dgvListsach"
        Me.dgvListsach.RowHeadersWidth = 51
        Me.dgvListsach.Size = New System.Drawing.Size(974, 152)
        Me.dgvListsach.TabIndex = 20
        '
        'STT
        '
        Me.STT.FillWeight = 200.0!
        Me.STT.HeaderText = "STT"
        Me.STT.MinimumWidth = 6
        Me.STT.Name = "STT"
        Me.STT.Width = 125
        '
        'Sach
        '
        Me.Sach.HeaderText = "Sách"
        Me.Sach.MinimumWidth = 6
        Me.Sach.Name = "Sach"
        Me.Sach.Width = 200
        '
        'TheLoai
        '
        Me.TheLoai.HeaderText = "Thể Loại"
        Me.TheLoai.MinimumWidth = 6
        Me.TheLoai.Name = "TheLoai"
        Me.TheLoai.Width = 200
        '
        'TacGia
        '
        Me.TacGia.HeaderText = "Tác Giả"
        Me.TacGia.MinimumWidth = 6
        Me.TacGia.Name = "TacGia"
        Me.TacGia.Width = 200
        '
        'SoLuong
        '
        Me.SoLuong.HeaderText = "Số Lượng"
        Me.SoLuong.MinimumWidth = 6
        Me.SoLuong.Name = "SoLuong"
        Me.SoLuong.Width = 150
        '
        'DonGiaNhap
        '
        Me.DonGiaNhap.HeaderText = "Đơn Giá Nhập"
        Me.DonGiaNhap.MinimumWidth = 6
        Me.DonGiaNhap.Name = "DonGiaNhap"
        Me.DonGiaNhap.Width = 200
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(861, 571)
        Me.btnLuu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(100, 28)
        Me.btnLuu.TabIndex = 63
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnIn
        '
        Me.btnIn.Location = New System.Drawing.Point(969, 571)
        Me.btnIn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(100, 28)
        Me.btnIn.TabIndex = 64
        Me.btnIn.Text = "In"
        Me.btnIn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbTheloai)
        Me.GroupBox1.Controls.Add(Me.btnThemvaodanhsach)
        Me.GroupBox1.Controls.Add(Me.btnQuydinh)
        Me.GroupBox1.Controls.Add(Me.tbxDongia)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbxSoLuong)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbxTacGia)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbxTenSach)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpNgaynhap)
        Me.GroupBox1.Controls.Add(Me.tbMaphieunhap)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(81, 80)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(992, 263)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin phiếu nhập"
        '
        'cbTheloai
        '
        Me.cbTheloai.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.cbTheloai.FormattingEnabled = True
        Me.cbTheloai.Location = New System.Drawing.Point(157, 179)
        Me.cbTheloai.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbTheloai.Name = "cbTheloai"
        Me.cbTheloai.Size = New System.Drawing.Size(239, 24)
        Me.cbTheloai.TabIndex = 16
        '
        'btnThemvaodanhsach
        '
        Me.btnThemvaodanhsach.AccessibleName = "btnQuydinh"
        Me.btnThemvaodanhsach.Location = New System.Drawing.Point(407, 230)
        Me.btnThemvaodanhsach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnThemvaodanhsach.Name = "btnThemvaodanhsach"
        Me.btnThemvaodanhsach.Size = New System.Drawing.Size(180, 27)
        Me.btnThemvaodanhsach.TabIndex = 15
        Me.btnThemvaodanhsach.Text = "Thêm vào danh sách"
        Me.btnThemvaodanhsach.UseVisualStyleBackColor = True
        '
        'btnQuydinh
        '
        Me.btnQuydinh.AccessibleName = "btnQuydinh"
        Me.btnQuydinh.Location = New System.Drawing.Point(715, 39)
        Me.btnQuydinh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnQuydinh.Name = "btnQuydinh"
        Me.btnQuydinh.Size = New System.Drawing.Size(107, 27)
        Me.btnQuydinh.TabIndex = 14
        Me.btnQuydinh.Text = "Quy Định"
        Me.btnQuydinh.UseVisualStyleBackColor = True
        '
        'tbxDongia
        '
        Me.tbxDongia.AccessibleName = "tbxDuonggianhap"
        Me.tbxDongia.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.tbxDongia.Location = New System.Drawing.Point(644, 177)
        Me.tbxDongia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbxDongia.Name = "tbxDongia"
        Me.tbxDongia.Size = New System.Drawing.Size(241, 22)
        Me.tbxDongia.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AccessibleName = "lbTensach"
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(525, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Đơn Giá Nhập:"
        '
        'tbxSoLuong
        '
        Me.tbxSoLuong.AccessibleName = "tbcSoluong"
        Me.tbxSoLuong.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.tbxSoLuong.Location = New System.Drawing.Point(644, 135)
        Me.tbxSoLuong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbxSoLuong.Name = "tbxSoLuong"
        Me.tbxSoLuong.Size = New System.Drawing.Size(241, 22)
        Me.tbxSoLuong.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AccessibleName = "lbTensach"
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(525, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Số Lượng"
        '
        'tbxTacGia
        '
        Me.tbxTacGia.AccessibleName = "tbxTacgia"
        Me.tbxTacGia.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.tbxTacGia.Location = New System.Drawing.Point(644, 93)
        Me.tbxTacGia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbxTacGia.Name = "tbxTacGia"
        Me.tbxTacGia.Size = New System.Drawing.Size(241, 22)
        Me.tbxTacGia.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AccessibleName = "lbTensach"
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(525, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tác Giả:"
        '
        'Label4
        '
        Me.Label4.AccessibleName = "lbTensach"
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Thể Loại:"
        '
        'tbxTenSach
        '
        Me.tbxTenSach.AccessibleName = "tbxTensach"
        Me.tbxTenSach.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.tbxTenSach.Location = New System.Drawing.Point(156, 135)
        Me.tbxTenSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbxTenSach.Name = "tbxTenSach"
        Me.tbxTenSach.Size = New System.Drawing.Size(240, 22)
        Me.tbxTenSach.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AccessibleName = "lbTensach"
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tên Sách:"
        '
        'dtpNgaynhap
        '
        Me.dtpNgaynhap.AccessibleName = "dtpNgaynhap"
        Me.dtpNgaynhap.Location = New System.Drawing.Point(157, 91)
        Me.dtpNgaynhap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpNgaynhap.Name = "dtpNgaynhap"
        Me.dtpNgaynhap.Size = New System.Drawing.Size(240, 22)
        Me.dtpNgaynhap.TabIndex = 3
        '
        'tbMaphieunhap
        '
        Me.tbMaphieunhap.AccessibleName = "tbxMaphieunhap"
        Me.tbMaphieunhap.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.tbMaphieunhap.Location = New System.Drawing.Point(156, 39)
        Me.tbMaphieunhap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbMaphieunhap.Name = "tbMaphieunhap"
        Me.tbMaphieunhap.Size = New System.Drawing.Size(240, 22)
        Me.tbMaphieunhap.TabIndex = 2
        Me.tbMaphieunhap.Text = "<Tự Động>"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ngày Nhập:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu Nhập:"
        '
        'FrmPhieuNhapSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1103, 624)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnIn)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.lblMain)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmPhieuNhapSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPhieuNhapSach"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvListsach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMain As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnIn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnThemvaodanhsach As Button
    Friend WithEvents btnQuydinh As Button
    Friend WithEvents tbxDongia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxSoLuong As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxTacGia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxTenSach As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpNgaynhap As DateTimePicker
    Friend WithEvents tbMaphieunhap As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvListsach As DataGridView
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents Sach As DataGridViewTextBoxColumn
    Friend WithEvents TheLoai As DataGridViewTextBoxColumn
    Friend WithEvents TacGia As DataGridViewTextBoxColumn
    Friend WithEvents SoLuong As DataGridViewTextBoxColumn
    Friend WithEvents DonGiaNhap As DataGridViewTextBoxColumn
    Friend WithEvents cbTheloai As ComboBox
End Class
