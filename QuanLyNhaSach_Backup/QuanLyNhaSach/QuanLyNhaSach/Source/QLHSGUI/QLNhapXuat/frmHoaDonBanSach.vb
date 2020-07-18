Imports QLHSBUS
Imports QLHSDTO
Imports QLHSDAL
Imports Utility
Imports System.Threading
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Drawing.Printing

Public Class frmHoaDonBanSach
    Private frmPreview As frmPreviewHoaDon

    Private sachBus As SACHBUS
    Private khBus As KHACHHANGBUS

    Private total As UInteger = 0
    Private listOrder As Dictionary(Of String, String())

    Private Sub loadListSach()
        Dim listSach = New List(Of SACHDTO)
        Dim result As Result
        result = sachBus.selectAll(listSach)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đầu sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListSach.Columns.Clear()
        dgvListSach.AutoGenerateColumns = False
        dgvListSach.DataSource = listSach

        Dim clMS = New DataGridViewTextBoxColumn()
        clMS.Name = "Imasach"
        clMS.HeaderText = "Mã Sách"
        clMS.DataPropertyName = "Imasach"
        dgvListSach.Columns.Add(clMS)

        Dim clTenSach = New DataGridViewTextBoxColumn()
        clTenSach.Name = "Strtensach"
        clTenSach.HeaderText = "Tên Sách"
        clTenSach.DataPropertyName = "Strtensach"
        dgvListSach.Columns.Add(clTenSach)

        Dim clMLS = New DataGridViewTextBoxColumn()
        clMLS.Name = "Imaloaisach"
        clMLS.HeaderText = "Mã Loại Sách"
        clMLS.DataPropertyName = "Imaloaisach"
        dgvListSach.Columns.Add(clMLS)

        Dim clTacGia = New DataGridViewTextBoxColumn()
        clTacGia.Name = "Strtacgia"
        clTacGia.HeaderText = "Tác Giả"
        clTacGia.DataPropertyName = "Strtacgia"
        dgvListSach.Columns.Add(clTacGia)

        Dim clSLT = New DataGridViewTextBoxColumn()
        clSLT.Name = "Isoluongton"
        clSLT.HeaderText = "Số Lượng Tồn"
        clSLT.DataPropertyName = "Isoluongton"
        dgvListSach.Columns.Add(clSLT)

        Dim clDG = New DataGridViewTextBoxColumn()
        clDG.Name = "Idongia"
        clDG.HeaderText = "Đơn Giá"
        clDG.DataPropertyName = "Idongia"
        dgvListSach.Columns.Add(clDG)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListSach.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub loadListKH()
        Dim listKH = New List(Of KHACHHANGDTO)
        Dim result As Result
        result = khBus.selectAll(listKH)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListKhachHang.Columns.Clear()
        dgvListKhachHang.DataSource = Nothing

        dgvListKhachHang.AutoGenerateColumns = False
        dgvListKhachHang.AllowUserToAddRows = False
        dgvListKhachHang.DataSource = listKH

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "maKH"
        clMa.HeaderText = "Mã Khách Hàng"
        clMa.DataPropertyName = "maKH1"
        dgvListKhachHang.Columns.Add(clMa)

        Dim clTenKH = New DataGridViewTextBoxColumn()
        clTenKH.Name = "hoTenKH"
        clTenKH.HeaderText = "Họ Tên Khách Hàng"
        clTenKH.DataPropertyName = "hoTenKH1"
        dgvListKhachHang.Columns.Add(clTenKH)



        Dim clTienNo = New DataGridViewTextBoxColumn()
        clTienNo.Name = "tienNoKH"
        clTienNo.HeaderText = "Tiền Nợ Khách Hàng"
        clTienNo.DataPropertyName = "tienNoKH1"
        dgvListKhachHang.Columns.Add(clTienNo)


        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "diaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "diaChi1"
        dgvListKhachHang.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "email1"
        dgvListKhachHang.Columns.Add(clEmail)

        Dim clSDT = New DataGridViewTextBoxColumn()
        clSDT.Name = "sdt"
        clSDT.HeaderText = "SDT"
        clSDT.DataPropertyName = "sdt1"
        dgvListKhachHang.Columns.Add(clSDT)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListKhachHang.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub loadListOrder()
        dgvListOrdered.Columns.Clear()
        dgvListOrdered.DataSource = Nothing

        dgvListOrdered.AutoGenerateColumns = False
        dgvListOrdered.AllowUserToAddRows = False

        dgvListOrdered.Columns.Add("MaSach", "Mã Sách")
        dgvListOrdered.Columns.Add("TenSach", "Tên Sách")
        dgvListOrdered.Columns.Add("TenLoaiSach", "Thể Loại")
        dgvListOrdered.Columns.Add("TacGia", "Tác Giả")
        dgvListOrdered.Columns.Add("SL", "Số Lượng Đặt")
        dgvListOrdered.Columns.Add("DG", "Đơn Giá")
    End Sub

    Private Sub getID()
        Dim hdBus As HOADONBUS = New HOADONBUS()

        Dim id As Integer
        Dim result As Result

        result = hdBus.getNextID(id)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy ID kế tiếp của hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        receiptID.Text = id.ToString()
    End Sub

    Private Function errorChecking_KH() As Boolean
        If (customerID.Text = String.Empty) Then
            Return False
        End If

        If (customerName.Text.Length < 1) Then
            Return False
        End If

        If (customerID.Text <> String.Empty) Then
            Dim listKH As List(Of KHACHHANGDTO) = New List(Of KHACHHANGDTO)
            Dim khBus As KHACHHANGBUS = New KHACHHANGBUS()
            khBus.selectALL_ByType(customerID.Text, listKH)

            If (listKH.ElementAt(0).TienNoKH1 > 20000) Then
                MessageBox.Show("Tiền nợ vượt mức tối đa")
                Return False
            End If
        End If
        Return True
    End Function

    Private Function errorChecking_Sach() As Boolean
        If (bookID.Text = String.Empty) Then
            Return False
        End If

        If (bookName.Text.Length < 1) Then
            Return False
        End If

        If (quantityTextBox.Text = String.Empty) Then
            Return False
        End If

        If (quantityTextBox.Text <> String.Empty) Then
            Try
                If (Integer.Parse(quantityTextBox.Text) <= 0) Then
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End If

        If (bookID.Text <> String.Empty And quantityTextBox.Text <> String.Empty) Then
            Dim slTon As Integer

            Dim listSach As List(Of SACHDTO) = New List(Of SACHDTO)
            Dim sachBus As SACHBUS = New SACHBUS()
            sachBus.selectAll_ByType(bookID.Text, listSach)

            slTon = listSach.ElementAt(0).Isoluongton - Integer.Parse(quantityTextBox.Text)

            If (slTon < 20) Then
                MessageBox.Show("Số lượng tồn tối thiểu nhỏ hơn quy định")
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub clearControls_KH()
        customerID.Text = String.Empty
        customerName.Text = String.Empty
    End Sub

    Private Sub clearControls_Sach()
        bookID.Text = String.Empty
        bookName.Text = String.Empty
        quantityTextBox.Text = String.Empty
    End Sub

    Private Function insertHoaDon() As Result
        Dim hoaDon As HOADONDTO = New HOADONDTO(Integer.Parse(receiptID.Text), DateTime.Now, customerID.Text, totalTextBox.Text)
        Dim hdBus As HOADONBUS = New HOADONBUS()
        Dim result As Result = hdBus.insert(hoaDon)
        If (result.FlagResult = False) Then
            Return New Result(False, "Thêm hóa đơn không thành công", result.SystemMessage)
        End If
        Return New Result(True)
    End Function

    Private Function insertCTHD() As Result
        Dim nextID As Integer
        Dim result As Result = New Result

        Dim cthdBus As CHITIETHOADONBUS = New CHITIETHOADONBUS()
        result = cthdBus.getNextID(nextID)
        If (result.FlagResult = False) Then
            Return New Result(False, "Lấy ID CTHD kế tiếp không thành công", result.SystemMessage)
        End If

        For rowInd As Integer = 0 To dgvListOrdered.Rows.Count - 1
            result = cthdBus.getNextID(nextID)
            If (result.FlagResult = False) Then
                Return New Result(False, "Lấy ID CTHD kế tiếp không thành công", result.SystemMessage)
            End If

            Dim thanhTien As Integer = Integer.Parse(dgvListOrdered.Rows(rowInd).Cells("SL").Value.ToString()) * Integer.Parse(dgvListOrdered.Rows(rowInd).Cells("DG").Value.ToString())
            cthdBus.insert(New CHITIETHOADON(nextID,
                                             Integer.Parse(receiptID.Text),
                                             Integer.Parse(dgvListOrdered.Rows(rowInd).Cells("MaSach").Value.ToString()),
                                             Integer.Parse(dgvListOrdered.Rows(rowInd).Cells("SL").Value.ToString()),
                                             Integer.Parse(dgvListOrdered.Rows(rowInd).Cells("DG").Value.ToString()),
                                             thanhTien))
        Next
        Return New Result(True)
    End Function

    Private Function printPDFReceipt() As Boolean
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintDocument1.DefaultPageSettings.PaperSize.RawKind = PaperKind.A3

        Dim resultDialog As DialogResult = PrintDialog1.ShowDialog()

        If (resultDialog = DialogResult.OK) Then
            Try
                PrintDocument1.Print()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End If
        Return False
    End Function

    Private Sub frmHoaDonBanSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khBus = New KHACHHANGBUS()
        sachBus = New SACHBUS()

        listOrder = New Dictionary(Of String, String())

        getID()
        
        loadListKH()        
        loadListSach()
        loadListOrder()
    End Sub

    Private Sub dgvListKhachHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListKhachHang.CellClick
        If (e.RowIndex <> -1) Then
            customerID.Text = dgvListKhachHang.Rows(e.RowIndex).Cells("maKH").Value.ToString().Trim()
            customerName.Text = dgvListKhachHang.Rows(e.RowIndex).Cells("hoTenKH").Value.ToString().Trim()
        Else
            clearControls_KH()
        End If
    End Sub

    Private Sub dgvListSach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSach.CellClick
        If (e.RowIndex <> -1) Then
            bookID.Text = dgvListSach.Rows(e.RowIndex).Cells("Imasach").Value.ToString().Trim()
            bookName.Text = dgvListSach.Rows(e.RowIndex).Cells("Strtensach").Value.ToString().Trim()
        Else
            clearControls_Sach()
        End If
    End Sub

    Private Sub dgvListOrdered_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListOrdered.CellClick
        If (e.RowIndex <> -1) Then
            bookID.Text = dgvListOrdered.Rows(e.RowIndex).Cells("MaSach").Value.ToString().Trim()
            bookName.Text = dgvListOrdered.Rows(e.RowIndex).Cells("TenSach").Value.ToString().Trim()
            quantityTextBox.Text = dgvListOrdered.Rows(e.RowIndex).Cells("SL").Value.ToString().Trim()
        Else
            clearControls_Sach()
        End If
    End Sub

    Private Sub previewReceipt_Click(sender As Object, e As EventArgs) Handles previewReceipt.Click
        Dim result As Result = New Result()

        result.FlagResult = errorChecking_KH()
        If (result.FlagResult = False) Then
            MessageBox.Show("Thiếu thông tin khách hàng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        If (dgvListOrdered.Rows.Count = 0) Then
            MessageBox.Show("Thiếu thông tin đầu sách.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        frmPreview = New frmPreviewHoaDon(receiptID.Text,
                                          customerName.Text,
                                          dgvListKhachHang.CurrentRow().Cells("diaChi").Value.ToString(),
                                          dgvListKhachHang.CurrentRow().Cells("sdt").Value.ToString(),
                                          DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"),
                                          totalTextBox.Text & " VNĐ",
                                          listOrder)
        frmPreview.Show()
    End Sub

    Private Sub printReceipt_Click(sender As Object, e As EventArgs) Handles printReceipt.Click
        Dim resultDialog = MessageBox.Show("Xuất hóa đơn?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        Dim result As Result = New Result()

        If (resultDialog = DialogResult.OK) Then
            Dim resBool As Boolean = errorChecking_KH()

            If (resBool = True And dgvListOrdered.Rows.Count > 0) Then
                resBool = printPDFReceipt()
                If (resBool = False) Then
                    MessageBox.Show("Hủy xuất hóa đơn", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                result = insertHoaDon()
                If (result.FlagResult = False) Then
                    MessageBox.Show("Nhập thông tin vào hóa đơn không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                    
                result = insertCTHD()
                If (result.FlagResult = False) Then
                    MessageBox.Show("Nhập thông tin vào chi tiết hóa đơn không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                'lay danh sach dau sach theo ID tu dgvListOrdered
                Dim listSach As List(Of SACHDTO) = New List(Of SACHDTO)
                Dim sachBus As SACHBUS = New SACHBUS()

                For rowInd As Integer = 0 To dgvListOrdered.Rows.Count - 1
                    sachBus.selectAll_ByType(dgvListOrdered.Rows(rowInd).Cells("MaSach").Value.ToString(), listSach)
                    listSach.ElementAt(0).Isoluongton -= Integer.Parse(dgvListOrdered.Rows(rowInd).Cells("SL").Value.ToString())
                    sachBus.update(listSach.ElementAt(0))
                Next

                MessageBox.Show("Xuất hóa đơn thành công", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                clearControls_KH()
                clearControls_Sach()

                listOrder.Clear()
                dgvListOrdered.Rows.Clear()

                total = 0
                totalTextBox.Text = total

                loadListSach()
            End If

            getID()
        End If
    End Sub

    Private Sub findCustomer_Click(sender As Object, e As EventArgs) Handles findCustomer.Click
        If (customerID.Text = String.Empty And customerName.Text = String.Empty) Then
            loadListKH()
        End If

        If (customerID.Text <> String.Empty) Then
            Dim listByID = New List(Of KHACHHANGDTO)
            Dim result As Result = khBus.selectALL_ByType(customerID.Text, listByID)

            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If

            dgvListKhachHang.DataSource = listByID
        End If

        If (customerName.Text <> String.Empty) Then
            Dim listKHByName = New List(Of KHACHHANGDTO)
            Dim result As Result = khBus.selectALL_ByName(customerName.Text, listKHByName)

            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If

            dgvListKhachHang.DataSource = listKHByName
        End If
    End Sub

    Private Sub findBook_Click(sender As Object, e As EventArgs) Handles findBook.Click
        If (bookID.Text = String.Empty And bookName.Text = String.Empty) Then
            loadListSach()
        End If

        If (bookID.Text <> String.Empty) Then
            Dim listSachByID = New List(Of SACHDTO)
            Dim result As Result = sachBus.selectAll_ByType(bookID.Text, listSachByID)

            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách đầu sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If

            dgvListSach.DataSource = listSachByID
        End If

        If (bookName.Text <> String.Empty) Then
            Dim listSachByName = New List(Of SACHDTO)
            Dim result As Result = sachBus.selectAll_ByName(bookName.Text, listSachByName)

            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách đầu sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If

            dgvListSach.DataSource = listSachByName
        End If
    End Sub

    Private Sub addBook_Click(sender As Object, e As EventArgs) Handles addBook.Click
        Dim result As Result = New Result()
        result.FlagResult = errorChecking_Sach()
        If (result.FlagResult = False) Then
            MessageBox.Show("Thiếu thông tin đầu sách.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        Dim listLS = New List(Of THELOAIDTO)
        Dim lsBus As LOAISACHBUS = New LOAISACHBUS()
        result = lsBus.selectall(listLS, UInteger.Parse(dgvListSach.CurrentRow().Cells("Imaloaisach").Value.ToString()))
        If (result.FlagResult = False Or listLS.Count = 0) Then
            MessageBox.Show("Lấy tên loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        Dim tenLS As String = listLS.ElementAt(0).Strtenloaisach
        Try
            listOrder.Add(bookID.Text.Trim(),
                      {
                      bookID.Text.Trim(),
                      bookName.Text.Trim(),
                      tenLS,
                      dgvListSach.CurrentRow().Cells("Strtacgia").Value.ToString(),
                      quantityTextBox.Text.Trim(),
                      dgvListSach.CurrentRow().Cells("Idongia").Value.ToString()
                      })

            dgvListOrdered.Rows.Add(listOrder.Last.Value)

            total += UInteger.Parse(quantityTextBox.Text.Trim()) * UInteger.Parse(dgvListSach.CurrentRow().Cells("Idongia").Value.ToString().Trim())
            totalTextBox.Text = String.Format("{0:#,##0}", total)

            clearControls_Sach()
        Catch ex As Exception
            MessageBox.Show("Trùng mã sách đã đặt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub updateBook_Click(sender As Object, e As EventArgs) Handles updateBook.Click
        If (dgvListOrdered.Rows.Count = 0) Then
            Return
        End If

        Dim result As Result = New Result()
        result.FlagResult = errorChecking_Sach()
        If (result.FlagResult = False) Then
            MessageBox.Show("Số lượng đặt không hợp lệ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        total -= UInteger.Parse(dgvListOrdered.CurrentRow().Cells("SL").Value.ToString()) * UInteger.Parse(dgvListOrdered.CurrentRow().Cells("DG").Value.ToString())
        total += UInteger.Parse(quantityTextBox.Text.Trim()) * UInteger.Parse(dgvListOrdered.CurrentRow().Cells("DG").Value.ToString())
        totalTextBox.Text = String.Format("{0:#,##0}", total)

        'update quantity at pos 4
        listOrder(dgvListSach.CurrentRow().Cells("Imasach").Value.ToString())(4) = quantityTextBox.Text.Trim()

        dgvListOrdered.CurrentRow().Cells("SL").Value = quantityTextBox.Text.Trim()

        clearControls_Sach()
    End Sub

    Private Sub removeBook_Click(sender As Object, e As EventArgs) Handles removeBook.Click
        If (dgvListOrdered.Rows.Count = 0) Then
            total = 0
            Return
        End If

        total -= UInteger.Parse(dgvListOrdered.CurrentRow().Cells("SL").Value.ToString()) * UInteger.Parse(dgvListOrdered.CurrentRow().Cells("DG").Value.ToString())
        totalTextBox.Text = String.Format("{0:#,##0}", total)

        listOrder.Remove(dgvListOrdered.CurrentRow().Cells("MaSach").Value.ToString())
        dgvListOrdered.Rows.RemoveAt(dgvListOrdered.CurrentRow().Index)

        clearControls_Sach()
    End Sub

    Private Sub frmHoaDonBanSach_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = MessageBox.Show("Đóng form hóa đơn?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.Cancel
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.ScaleTransform(0.8F, 0.8F)

        Dim font As Font = New Font("Courier New", 12)

        Dim fontHeight As Double = font.GetHeight()

        Dim startX As Integer = 10
        Dim startY As Integer = 10
        Dim offset As Integer = 200

        'get max string length from each row
        Dim maxLen As Integer = 0
        For Each items As String() In listOrder.Values.ToList()
            Dim maxLenStr As Integer = items.Max(Function(str) str.Length())
            If (maxLenStr > maxLen) Then
                maxLen = maxLenStr
            End If
        Next

        Dim listHeader As String = String.Empty
        listHeader &= String.Format("{0,-15}", "Mã Sách")
        listHeader &= String.Format("{0,-15}", "Tên Sách")
        listHeader &= String.Format("{0,15}", "Thể Loại")
        listHeader &= String.Format("{0,15}", "Tác Giả")
        listHeader &= String.Format("{0,15}", "Số Lượng")
        listHeader &= String.Format("{0,15}", "Đơn Giá")

        Dim id As String = "Mã hóa đơn: " & receiptID.Text
        Dim receiptDate As String = "Ngày mua: " & DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
        Dim name As String = "Họ tên khách hàng: " & customerName.Text
        Dim address As String = "Địa chỉ: " & dgvListKhachHang.CurrentRow().Cells("diaChi").Value.ToString()
        Dim phone As String = "SĐT: " & dgvListKhachHang.CurrentRow().Cells("sdt").Value.ToString()

        Dim graphic As Graphics = e.Graphics
        graphic.DrawString("HÓA ĐƠN", New Font("Courier New", 18, FontStyle.Bold), New SolidBrush(Color.Red), startX, 0)
        'chi tiet hoa don
        graphic.DrawString(id, font, New SolidBrush(Color.Black), startX, startY + 20)
        graphic.DrawString(receiptDate, font, New SolidBrush(Color.Black), startX, startY + 40)
        graphic.DrawString(name, font, New SolidBrush(Color.Black), startX, startY + 80)
        graphic.DrawString(address, font, New SolidBrush(Color.Black), startX, startY + 100)
        graphic.DrawString(phone, font, New SolidBrush(Color.Black), startX, startY + 120)

        graphic.DrawString(listHeader, font, New SolidBrush(Color.Black), startX, startY + 160)

        For Each order As String() In listOrder.Values.ToList()
            Dim orderString As String = String.Empty

            For orderIndex As Integer = 0 To order.Length() - 1
                'Ma sach va don gia
                If (orderIndex = 0 Or orderIndex = order.Length() - 2) Then
                    orderString &= String.Format("{0,-5}", order(orderIndex)) & vbTab
                    Continue For
                End If
                'Thanh tien
                If (orderIndex = order.Length() - 1) Then
                    orderString &= String.Format("{0:-10}", order(orderIndex)) & vbTab
                    Continue For
                End If
                Dim format As String = "{0,-" & maxLen & "}"
                orderString &= String.Format(Format, order(orderIndex)) & vbTab
            Next

            orderString &= "VNĐ"

            graphic.DrawString(orderString, font, New SolidBrush(Color.Gray), startX, startY + offset)

            offset += CType(fontHeight, Integer) + 5
        Next

            graphic.DrawString("Tổng giá trị: " & String.Format("{0:#,##0}", total) & " VNĐ", font, New SolidBrush(Color.Black), startX, startY + offset + 50)
    End Sub
End Class
