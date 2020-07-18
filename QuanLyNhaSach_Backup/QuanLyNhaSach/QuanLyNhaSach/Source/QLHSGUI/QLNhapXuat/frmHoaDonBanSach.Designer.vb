<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHoaDonBanSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoaDonBanSach))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvListOrdered = New System.Windows.Forms.DataGridView()
        Me.previewReceipt = New System.Windows.Forms.Button()
        Me.printReceipt = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.receiptID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bookToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.addBook = New System.Windows.Forms.Button()
        Me.removeBook = New System.Windows.Forms.Button()
        Me.updateBook = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.quantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.findBook = New System.Windows.Forms.Button()
        Me.dgvListSach = New System.Windows.Forms.DataGridView()
        Me.bookName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.bookID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.findCustomer = New System.Windows.Forms.Button()
        Me.customerID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvListKhachHang = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.customerName = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgvListOrdered, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvListKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(259, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HÓA ĐƠN BÁN SÁCH"
        '
        'dgvListOrdered
        '
        Me.dgvListOrdered.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListOrdered.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListOrdered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListOrdered.Location = New System.Drawing.Point(12, 330)
        Me.dgvListOrdered.Name = "dgvListOrdered"
        Me.dgvListOrdered.ReadOnly = True
        Me.dgvListOrdered.Size = New System.Drawing.Size(760, 219)
        Me.dgvListOrdered.TabIndex = 15
        '
        'previewReceipt
        '
        Me.previewReceipt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.previewReceipt.Location = New System.Drawing.Point(100, 301)
        Me.previewReceipt.Name = "previewReceipt"
        Me.previewReceipt.Size = New System.Drawing.Size(75, 23)
        Me.previewReceipt.TabIndex = 16
        Me.previewReceipt.Text = "Xem trước"
        Me.previewReceipt.UseVisualStyleBackColor = True
        '
        'printReceipt
        '
        Me.printReceipt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.printReceipt.AutoSize = True
        Me.printReceipt.Location = New System.Drawing.Point(12, 301)
        Me.printReceipt.Name = "printReceipt"
        Me.printReceipt.Size = New System.Drawing.Size(82, 23)
        Me.printReceipt.TabIndex = 17
        Me.printReceipt.Text = "Xuất hóa đơn"
        Me.printReceipt.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(5, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Mã hóa đơn"
        '
        'receiptID
        '
        Me.receiptID.ForeColor = System.Drawing.Color.Red
        Me.receiptID.Location = New System.Drawing.Point(76, 75)
        Me.receiptID.Name = "receiptID"
        Me.receiptID.ReadOnly = True
        Me.receiptID.Size = New System.Drawing.Size(142, 20)
        Me.receiptID.TabIndex = 24
        Me.receiptID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(510, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Tổng trị giá"
        '
        'totalTextBox
        '
        Me.totalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totalTextBox.Location = New System.Drawing.Point(575, 298)
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.Size = New System.Drawing.Size(161, 20)
        Me.totalTextBox.TabIndex = 26
        Me.totalTextBox.Text = "0"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(741, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "VNĐ"
        '
        'addBook
        '
        Me.addBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addBook.Location = New System.Drawing.Point(293, 15)
        Me.addBook.Name = "addBook"
        Me.addBook.Size = New System.Drawing.Size(75, 23)
        Me.addBook.TabIndex = 9
        Me.addBook.Text = "Thêm"
        Me.bookToolTip.SetToolTip(Me.addBook, "Thêm đầu sách vào danh sách bằng cách chọn trong bảng bên dưới")
        Me.addBook.UseVisualStyleBackColor = True
        '
        'removeBook
        '
        Me.removeBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.removeBook.Location = New System.Drawing.Point(293, 65)
        Me.removeBook.Name = "removeBook"
        Me.removeBook.Size = New System.Drawing.Size(75, 23)
        Me.removeBook.TabIndex = 10
        Me.removeBook.Text = "Xóa"
        Me.bookToolTip.SetToolTip(Me.removeBook, "Xóa đầu sách bằng cách chọn trong bảng các đầu sách đã đặt")
        Me.removeBook.UseVisualStyleBackColor = True
        '
        'updateBook
        '
        Me.updateBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.updateBook.Location = New System.Drawing.Point(293, 40)
        Me.updateBook.Name = "updateBook"
        Me.updateBook.Size = New System.Drawing.Size(75, 23)
        Me.updateBook.TabIndex = 18
        Me.updateBook.Text = "Sửa"
        Me.bookToolTip.SetToolTip(Me.updateBook, "Sửa số lượng bằng cách chọn đầu sách trong bảng các đầu sách đã đặt")
        Me.updateBook.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 101)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.84615!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(760, 194)
        Me.TableLayoutPanel1.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.updateBook)
        Me.GroupBox1.Controls.Add(Me.quantityTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.findBook)
        Me.GroupBox1.Controls.Add(Me.dgvListSach)
        Me.GroupBox1.Controls.Add(Me.bookName)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.removeBook)
        Me.GroupBox1.Controls.Add(Me.addBook)
        Me.GroupBox1.Controls.Add(Me.bookID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 188)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập sách"
        '
        'quantityTextBox
        '
        Me.quantityTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quantityTextBox.Location = New System.Drawing.Point(61, 67)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.Size = New System.Drawing.Size(153, 20)
        Me.quantityTextBox.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Số lượng"
        '
        'findBook
        '
        Me.findBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.findBook.Location = New System.Drawing.Point(220, 15)
        Me.findBook.Name = "findBook"
        Me.findBook.Size = New System.Drawing.Size(67, 23)
        Me.findBook.TabIndex = 15
        Me.findBook.Text = "Tìm"
        Me.findBook.UseVisualStyleBackColor = True
        '
        'dgvListSach
        '
        Me.dgvListSach.AllowUserToAddRows = False
        Me.dgvListSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListSach.Location = New System.Drawing.Point(6, 92)
        Me.dgvListSach.Name = "dgvListSach"
        Me.dgvListSach.ReadOnly = True
        Me.dgvListSach.Size = New System.Drawing.Size(362, 90)
        Me.dgvListSach.TabIndex = 14
        '
        'bookName
        '
        Me.bookName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bookName.Location = New System.Drawing.Point(61, 41)
        Me.bookName.Name = "bookName"
        Me.bookName.Size = New System.Drawing.Size(153, 20)
        Me.bookName.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Tên sách"
        '
        'bookID
        '
        Me.bookID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bookID.Location = New System.Drawing.Point(61, 17)
        Me.bookID.Name = "bookID"
        Me.bookID.Size = New System.Drawing.Size(153, 20)
        Me.bookID.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã sách"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.findCustomer)
        Me.GroupBox2.Controls.Add(Me.customerID)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dgvListKhachHang)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.customerName)
        Me.GroupBox2.Location = New System.Drawing.Point(383, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(374, 188)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nhập khách hàng"
        '
        'findCustomer
        '
        Me.findCustomer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.findCustomer.Location = New System.Drawing.Point(293, 15)
        Me.findCustomer.Name = "findCustomer"
        Me.findCustomer.Size = New System.Drawing.Size(75, 23)
        Me.findCustomer.TabIndex = 28
        Me.findCustomer.Text = "Tìm"
        Me.findCustomer.UseVisualStyleBackColor = True
        '
        'customerID
        '
        Me.customerID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.customerID.Location = New System.Drawing.Point(103, 17)
        Me.customerID.Name = "customerID"
        Me.customerID.Size = New System.Drawing.Size(184, 20)
        Me.customerID.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Mã KH"
        '
        'dgvListKhachHang
        '
        Me.dgvListKhachHang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListKhachHang.Location = New System.Drawing.Point(7, 73)
        Me.dgvListKhachHang.Name = "dgvListKhachHang"
        Me.dgvListKhachHang.ReadOnly = True
        Me.dgvListKhachHang.Size = New System.Drawing.Size(361, 109)
        Me.dgvListKhachHang.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Tên khách hàng"
        '
        'customerName
        '
        Me.customerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.customerName.Location = New System.Drawing.Point(103, 48)
        Me.customerName.Name = "customerName"
        Me.customerName.Size = New System.Drawing.Size(184, 20)
        Me.customerName.TabIndex = 19
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
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
        'frmHoaDonBanSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.totalTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.receiptID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.printReceipt)
        Me.Controls.Add(Me.previewReceipt)
        Me.Controls.Add(Me.dgvListOrdered)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHoaDonBanSach"
        Me.Text = "frmHoaDonBanSach"
        CType(Me.dgvListOrdered, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvListSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvListKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvListOrdered As DataGridView
    Friend WithEvents previewReceipt As Button
    Friend WithEvents printReceipt As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents receiptID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents totalTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents bookToolTip As ToolTip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents updateBook As Button
    Friend WithEvents quantityTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents findBook As Button
    Friend WithEvents dgvListSach As DataGridView
    Friend WithEvents bookName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents removeBook As Button
    Friend WithEvents addBook As Button
    Friend WithEvents bookID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents findCustomer As Button
    Friend WithEvents customerID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvListKhachHang As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents customerName As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
