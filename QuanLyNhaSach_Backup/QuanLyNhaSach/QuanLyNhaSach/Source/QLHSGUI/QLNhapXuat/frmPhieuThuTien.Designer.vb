<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuThuTien
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
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbReasonPre = New System.Windows.Forms.Label()
        Me.lbPaymentPre = New System.Windows.Forms.Label()
        Me.lbEmailPre = New System.Windows.Forms.Label()
        Me.lbAddressPre = New System.Windows.Forms.Label()
        Me.lbPhonePre = New System.Windows.Forms.Label()
        Me.lbNamePre = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbDate = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbId = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbInput = New System.Windows.Forms.GroupBox()
        Me.cbHoTenID = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbMaHD = New System.Windows.Forms.Label()
        Me.cbMaHD = New System.Windows.Forms.ComboBox()
        Me.cbLyDoThu = New System.Windows.Forms.ComboBox()
        Me.tbSoTienThu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbHoTen = New System.Windows.Forms.TextBox()
        Me.lbHoten = New System.Windows.Forms.Label()
        Me.lbPhieuThuTien = New System.Windows.Forms.Label()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.printDia = New System.Windows.Forms.PrintDialog()
        Me.printDoc = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(957, 768)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(114, 34)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "Xuất phiếu"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(93, 427)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(984, 335)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Xem trước"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbReasonPre)
        Me.Panel1.Controls.Add(Me.lbPaymentPre)
        Me.Panel1.Controls.Add(Me.lbEmailPre)
        Me.Panel1.Controls.Add(Me.lbAddressPre)
        Me.Panel1.Controls.Add(Me.lbPhonePre)
        Me.Panel1.Controls.Add(Me.lbNamePre)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lbDate)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lbId)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(6, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(972, 303)
        Me.Panel1.TabIndex = 0
        '
        'lbReasonPre
        '
        Me.lbReasonPre.AutoSize = True
        Me.lbReasonPre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbReasonPre.Location = New System.Drawing.Point(625, 201)
        Me.lbReasonPre.MaximumSize = New System.Drawing.Size(300, 100)
        Me.lbReasonPre.Name = "lbReasonPre"
        Me.lbReasonPre.Size = New System.Drawing.Size(280, 44)
        Me.lbReasonPre.TabIndex = 20
        Me.lbReasonPre.Text = "Thu tiền hóa đơn 1193 và tiền bồi thường mèo thần tài 189,000đ"
        '
        'lbPaymentPre
        '
        Me.lbPaymentPre.AutoSize = True
        Me.lbPaymentPre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPaymentPre.Location = New System.Drawing.Point(634, 168)
        Me.lbPaymentPre.Name = "lbPaymentPre"
        Me.lbPaymentPre.Size = New System.Drawing.Size(121, 22)
        Me.lbPaymentPre.TabIndex = 19
        Me.lbPaymentPre.Text = "429,000 VNĐ"
        '
        'lbEmailPre
        '
        Me.lbEmailPre.AutoSize = True
        Me.lbEmailPre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmailPre.Location = New System.Drawing.Point(598, 135)
        Me.lbEmailPre.Name = "lbEmailPre"
        Me.lbEmailPre.Size = New System.Drawing.Size(234, 22)
        Me.lbEmailPre.TabIndex = 18
        Me.lbEmailPre.Text = "clumsy_mint_hi@gmail.com"
        '
        'lbAddressPre
        '
        Me.lbAddressPre.AutoSize = True
        Me.lbAddressPre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAddressPre.Location = New System.Drawing.Point(154, 201)
        Me.lbAddressPre.MaximumSize = New System.Drawing.Size(350, 100)
        Me.lbAddressPre.Name = "lbAddressPre"
        Me.lbAddressPre.Size = New System.Drawing.Size(325, 44)
        Me.lbAddressPre.TabIndex = 17
        Me.lbAddressPre.Text = "56/2 Hoàng Hoa Thám, phường 7, Bình Thạnh, Hồ Chí Minh"
        '
        'lbPhonePre
        '
        Me.lbPhonePre.AutoSize = True
        Me.lbPhonePre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPhonePre.Location = New System.Drawing.Point(178, 168)
        Me.lbPhonePre.Name = "lbPhonePre"
        Me.lbPhonePre.Size = New System.Drawing.Size(110, 22)
        Me.lbPhonePre.TabIndex = 16
        Me.lbPhonePre.Text = "0931224808"
        '
        'lbNamePre
        '
        Me.lbNamePre.AutoSize = True
        Me.lbNamePre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNamePre.Location = New System.Drawing.Point(187, 135)
        Me.lbNamePre.Name = "lbNamePre"
        Me.lbNamePre.Size = New System.Drawing.Size(121, 22)
        Me.lbNamePre.TabIndex = 15
        Me.lbNamePre.Text = "Ngô Minh Thi"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(529, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 22)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Lý do thu:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(529, 168)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 22)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Số tiền thu:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(529, 135)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 22)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Email:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(74, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 22)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Địa chỉ:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(598, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 20)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Ngày thu:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(74, 168)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 22)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Điện thoại:"
        '
        'lbDate
        '
        Me.lbDate.AutoSize = True
        Me.lbDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDate.Location = New System.Drawing.Point(693, 52)
        Me.lbDate.Name = "lbDate"
        Me.lbDate.Size = New System.Drawing.Size(97, 20)
        Me.lbDate.TabIndex = 5
        Me.lbDate.Text = "dd/mm/yyyy"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(74, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 22)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Khách hàng:"
        '
        'lbId
        '
        Me.lbId.AutoSize = True
        Me.lbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbId.Location = New System.Drawing.Point(204, 52)
        Me.lbId.Name = "lbId"
        Me.lbId.Size = New System.Drawing.Size(84, 20)
        Me.lbId.TabIndex = 2
        Me.lbId.Text = "<tự động>"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(74, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Mã phiếu thu:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label7.Location = New System.Drawing.Point(375, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(217, 29)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "PHIẾU THU TIỀN"
        '
        'gbInput
        '
        Me.gbInput.Controls.Add(Me.cbHoTenID)
        Me.gbInput.Controls.Add(Me.Label2)
        Me.gbInput.Controls.Add(Me.lbMaHD)
        Me.gbInput.Controls.Add(Me.cbMaHD)
        Me.gbInput.Controls.Add(Me.cbLyDoThu)
        Me.gbInput.Controls.Add(Me.tbSoTienThu)
        Me.gbInput.Controls.Add(Me.Label4)
        Me.gbInput.Controls.Add(Me.Label3)
        Me.gbInput.Controls.Add(Me.tbHoTen)
        Me.gbInput.Controls.Add(Me.lbHoten)
        Me.gbInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInput.Location = New System.Drawing.Point(93, 84)
        Me.gbInput.Name = "gbInput"
        Me.gbInput.Size = New System.Drawing.Size(985, 328)
        Me.gbInput.TabIndex = 7
        Me.gbInput.TabStop = False
        Me.gbInput.Text = "Thông tin phiếu thu"
        '
        'cbHoTenID
        '
        Me.cbHoTenID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbHoTenID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbHoTenID.FormattingEnabled = True
        Me.cbHoTenID.Location = New System.Drawing.Point(668, 53)
        Me.cbHoTenID.Name = "cbHoTenID"
        Me.cbHoTenID.Size = New System.Drawing.Size(259, 28)
        Me.cbHoTenID.TabIndex = 17
        Me.cbHoTenID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(934, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "VNĐ"
        '
        'lbMaHD
        '
        Me.lbMaHD.AutoSize = True
        Me.lbMaHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaHD.Location = New System.Drawing.Point(54, 103)
        Me.lbMaHD.Name = "lbMaHD"
        Me.lbMaHD.Size = New System.Drawing.Size(101, 20)
        Me.lbMaHD.TabIndex = 15
        Me.lbMaHD.Text = "Mã hóa đơn:"
        '
        'cbMaHD
        '
        Me.cbMaHD.FormattingEnabled = True
        Me.cbMaHD.Location = New System.Drawing.Point(175, 99)
        Me.cbMaHD.Name = "cbMaHD"
        Me.cbMaHD.Size = New System.Drawing.Size(250, 28)
        Me.cbMaHD.TabIndex = 14
        '
        'cbLyDoThu
        '
        Me.cbLyDoThu.FormattingEnabled = True
        Me.cbLyDoThu.Items.AddRange(New Object() {"Thu tiền hóa đơn", "Thu tiền nợ hóa đơn", "Lý do khác"})
        Me.cbLyDoThu.Location = New System.Drawing.Point(175, 53)
        Me.cbLyDoThu.Name = "cbLyDoThu"
        Me.cbLyDoThu.Size = New System.Drawing.Size(250, 28)
        Me.cbLyDoThu.TabIndex = 13
        '
        'tbSoTienThu
        '
        Me.tbSoTienThu.Location = New System.Drawing.Point(668, 100)
        Me.tbSoTienThu.Name = "tbSoTienThu"
        Me.tbSoTienThu.Size = New System.Drawing.Size(259, 27)
        Me.tbSoTienThu.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(551, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Số tiền thu:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Lý do thu:"
        '
        'tbHoTen
        '
        Me.tbHoTen.Location = New System.Drawing.Point(668, 54)
        Me.tbHoTen.Name = "tbHoTen"
        Me.tbHoTen.ReadOnly = True
        Me.tbHoTen.Size = New System.Drawing.Size(259, 27)
        Me.tbHoTen.TabIndex = 1
        '
        'lbHoten
        '
        Me.lbHoten.AutoSize = True
        Me.lbHoten.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHoten.Location = New System.Drawing.Point(481, 57)
        Me.lbHoten.Name = "lbHoten"
        Me.lbHoten.Size = New System.Drawing.Size(154, 20)
        Me.lbHoten.TabIndex = 0
        Me.lbHoten.Text = "Họ tên khách hàng:"
        '
        'lbPhieuThuTien
        '
        Me.lbPhieuThuTien.AutoSize = True
        Me.lbPhieuThuTien.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPhieuThuTien.ForeColor = System.Drawing.Color.Blue
        Me.lbPhieuThuTien.Location = New System.Drawing.Point(371, 24)
        Me.lbPhieuThuTien.Name = "lbPhieuThuTien"
        Me.lbPhieuThuTien.Size = New System.Drawing.Size(441, 45)
        Me.lbPhieuThuTien.TabIndex = 6
        Me.lbPhieuThuTien.Text = "LẬP PHIẾU THU TIỀN"
        '
        'btnShowAll
        '
        Me.btnShowAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAll.Location = New System.Drawing.Point(626, 768)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(325, 34)
        Me.btnShowAll.TabIndex = 12
        Me.btnShowAll.Text = "Xem danh sách tất cả các phiếu thu tiền"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'printDia
        '
        Me.printDia.UseEXDialog = True
        '
        'printDoc
        '
        '
        'frmPhieuThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 812)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.gbInput)
        Me.Controls.Add(Me.lbPhieuThuTien)
        Me.Name = "frmPhieuThuTien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPhieuThuTien"
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbInput.ResumeLayout(False)
        Me.gbInput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrint As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gbInput As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbHoTen As TextBox
    Friend WithEvents lbHoten As Label
    Friend WithEvents lbPhieuThuTien As Label
    Friend WithEvents cbLyDoThu As ComboBox
    Friend WithEvents btnShowAll As Button
    Friend WithEvents lbMaHD As Label
    Friend WithEvents cbMaHD As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbReasonPre As Label
    Friend WithEvents lbPaymentPre As Label
    Friend WithEvents lbEmailPre As Label
    Friend WithEvents lbAddressPre As Label
    Friend WithEvents lbPhonePre As Label
    Friend WithEvents lbNamePre As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbDate As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbId As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbSoTienThu As TextBox
    Friend WithEvents cbHoTenID As ComboBox
    Friend WithEvents printDia As PrintDialog
    Friend WithEvents printDoc As Printing.PrintDocument
End Class
