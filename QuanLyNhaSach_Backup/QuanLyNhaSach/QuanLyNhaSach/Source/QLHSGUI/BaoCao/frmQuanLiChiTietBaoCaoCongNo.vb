Imports QLHSBUS
Imports QLHSDTO
Imports Utility

Public Class frmQuanLiChiTietBaoCaoCongNo
    Private bccnBus As BAOCAOCONGNOBUS
    Private ctbccnBus As CHITIETBAOCAOCONGNOBUS

    Private baocaoCN As BAOCAOCONGNODTO
    Private khachhang As KHACHHANGDTO
    Private Sub frmQuanLiChiTietBaoCaoCongNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bccnBus = New BAOCAOCONGNOBUS()
        ctbccnBus = New CHITIETBAOCAOCONGNOBUS()

        Dim listbccn = New List(Of BAOCAOCONGNODTO)
        Dim result As Result
        result = bccnBus.selectAll(listbccn)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
    End Sub
    Private Sub loadlistCTBaoCaoCongNo()
        Dim listctbccn = New List(Of CHITIETBAOCAOCONGNODTO)
        Dim result As Result
        result = ctbccnBus.selectAll(listctbccn)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListCTBaoCaoCongNo.Columns.Clear()
        dgvListCTBaoCaoCongNo.DataSource = Nothing

        dgvListCTBaoCaoCongNo.AutoGenerateColumns = False
        dgvListCTBaoCaoCongNo.AllowUserToAddRows = False
        dgvListCTBaoCaoCongNo.DataSource = listctbccn

        Dim clMaCTBCCN = New DataGridViewTextBoxColumn()
        clMaCTBCCN.Name = "maChiTietBaoCaoCongNo"
        clMaCTBCCN.HeaderText = "Mã Chi Báo Cáo Công Nợ"
        clMaCTBCCN.DataPropertyName = "MaChiTietBaoCaoCongNo1"
        dgvListCTBaoCaoCongNo.Columns.Add(clMaCTBCCN)

        Dim clMaKH = New DataGridViewTextBoxColumn()
        clMaKH.Name = "maKH"
        clMaKH.HeaderText = "Mã Khách Hàng"
        clMaKH.DataPropertyName = "MaKH1"
        dgvListCTBaoCaoCongNo.Columns.Add(clMaKH)

        Dim clNoDau = New DataGridViewTextBoxColumn()
        clNoDau.Name = "noDau"
        clNoDau.HeaderText = "Nợ Đầu"
        clNoDau.DataPropertyName = "NoDau1"
        dgvListCTBaoCaoCongNo.Columns.Add(clNoDau)

        Dim clPhatSinh = New DataGridViewTextBoxColumn()
        clPhatSinh.Name = "noPhatSinh"
        clPhatSinh.HeaderText = "Nợ Phát Sinh"
        clPhatSinh.DataPropertyName = "NoPhatSinh1"
        dgvListCTBaoCaoCongNo.Columns.Add(clPhatSinh)

        Dim clNoCuoi = New DataGridViewTextBoxColumn()
        clNoCuoi.Name = "noCuoi"
        clNoCuoi.HeaderText = "Nợ Cuối"
        clNoCuoi.DataPropertyName = "NoCuoi1"
        dgvListCTBaoCaoCongNo.Columns.Add(clNoCuoi)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListCTBaoCaoCongNo.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub loadlistCTBaoCaoCongNo_byMaBaoCaoCongNo(maBaoCao As Integer)
        Dim listctbccn = New List(Of CHITIETBAOCAOCONGNODTO)
        Dim result As Result
        result = ctbccnBus.selectAll_byMaBaoCao(maBaoCao, listctbccn)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListCTBaoCaoCongNo.Columns.Clear()
        dgvListCTBaoCaoCongNo.DataSource = Nothing

        dgvListCTBaoCaoCongNo.AutoGenerateColumns = False
        dgvListCTBaoCaoCongNo.AllowUserToAddRows = False
        dgvListCTBaoCaoCongNo.DataSource = listctbccn

        Dim clMaCTBCCN = New DataGridViewTextBoxColumn()
        clMaCTBCCN.Name = "maChiTietBaoCaoCongNo"
        clMaCTBCCN.HeaderText = "Mã Chi Báo Cáo Công Nợ"
        clMaCTBCCN.DataPropertyName = "MaChiTietBaoCaoCongNo1"
        dgvListCTBaoCaoCongNo.Columns.Add(clMaCTBCCN)

        Dim clMaKH = New DataGridViewTextBoxColumn()
        clMaKH.Name = "maKH"
        clMaKH.HeaderText = "Mã Khách Hàng"
        clMaKH.DataPropertyName = "MaKH1"
        dgvListCTBaoCaoCongNo.Columns.Add(clMaKH)

        Dim clNoDau = New DataGridViewTextBoxColumn()
        clNoDau.Name = "noDau"
        clNoDau.HeaderText = "Số Tiền Nợ Đầu"
        clNoDau.DataPropertyName = "NoDau1"
        dgvListCTBaoCaoCongNo.Columns.Add(clNoDau)

        Dim clPhatSinh = New DataGridViewTextBoxColumn()
        clPhatSinh.Name = "noPhatSinh"
        clPhatSinh.HeaderText = "Số Tiền Phát Sinh"
        clPhatSinh.DataPropertyName = "NoPhatSinh1"
        dgvListCTBaoCaoCongNo.Columns.Add(clPhatSinh)

        Dim clNoCuoi = New DataGridViewTextBoxColumn()
        clNoCuoi.Name = "noCuoi"
        clNoCuoi.HeaderText = "Số Tiền Nợ Cuối"
        clNoCuoi.DataPropertyName = "NoCuoi1"
        dgvListCTBaoCaoCongNo.Columns.Add(clNoCuoi)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListCTBaoCaoCongNo.DataSource)
        myCurrencyManager.Refresh()
    End Sub
    Private Sub loadListKhachHang_ByMaKH(maKH As String)
        Dim khBus = New KHACHHANGBUS()
        Dim listKH = New List(Of KHACHHANGDTO)
        Dim result = khBus.selectALL_ByType(maKH, listKH)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin khách hàng theo mã khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        khachhang = listKH(0)
        txtHoTenKH.Text = khachhang.HoTenKH1
        txtDiaChi.Text = khachhang.DiaChi1
        txtEmail.Text = khachhang.Email1
        txtSDT.Text = khachhang.Sdt1
        txtTienNo.Text = khachhang.TienNoKH1
    End Sub

    Private Sub loadListBaoCaoCongNo_byMaBaoCaoCongNo(maBaoCao As Integer)
        Dim bccnBus = New BAOCAOCONGNOBUS()
        Dim listBCCN = New List(Of BAOCAOCONGNODTO)
        Dim result = bccnBus.selectAll_byMaBaoCaoCongNo(maBaoCao, listBCCN)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin báo cáo theo mã báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        baocaoCN = listBCCN(0)
        dtpThangBaoCaoCongNo.Value = baocaoCN.Thang1
    End Sub

    Private Sub dgvListCTBaoCaoCongNo_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListCTBaoCaoCongNo.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListCTBaoCaoCongNo.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvChiTietPhieuNhap.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListCTBaoCaoCongNo.RowCount) Then
            Try
                Dim ctbccn = CType(dgvListCTBaoCaoCongNo.Rows(currentRowIndex).DataBoundItem, CHITIETBAOCAOCONGNODTO)
                txtMaCTBCCN.Text = ctbccn.MaChiTietBaoCaoCongNo1
                txtMaKH.Text = ctbccn.MaKH1
                txtSoTienNoDau.Text = ctbccn.NoDau1
                txtSoTienPhatSinh.Text = ctbccn.NoPhatSinh1
                txtSoTienNoCuoi.Text = ctbccn.NoCuoi1
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Try
            Dim maBaoCao = txtMaBCCN.Text
            loadlistCTBaoCaoCongNo_byMaBaoCaoCongNo(maBaoCao)
            loadListBaoCaoCongNo_byMaBaoCaoCongNo(maBaoCao)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMaKH_TextChanged(sender As Object, e As EventArgs) Handles txtMaKH.TextChanged
        Try
            Dim maKh = txtMaKH.Text
            loadListKhachHang_ByMaKH(maKh)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCapNhatCTBCCN_Click(sender As Object, e As EventArgs) Handles btCapNhatCTBCCN.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListCTBaoCaoCongNo.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListCTBaoCaoCongNo.RowCount) Then
            Try
                Dim ctbccn As CHITIETBAOCAOCONGNODTO
                ctbccn = New CHITIETBAOCAOCONGNODTO()

                '1. Mapping data from GUI control
                ctbccn.MaChiTietBaoCaoCongNo1 = txtMaCTBCCN.Text
                ctbccn.MaKH1 = txtMaKH.Text
                ctbccn.MaBaoCaoCongNo1 = txtMaBCCN.Text
                ctbccn.NoDau1 = txtSoTienNoDau.Text
                ctbccn.NoPhatSinh1 = txtSoTienPhatSinh.Text
                ctbccn.NoCuoi1 = txtSoTienNoCuoi.Text
                '2. Business .....
                '3. Insert to DB
                Dim result As Result
                result = ctbccnBus.update(ctbccn)
                If (result.FlagResult = True) Then
                    ' Re-Load chi tiet phieu nhap list
                    loadlistCTBaoCaoCongNo_byMaBaoCaoCongNo(txtMaBCCN.Text)
                    ' Hightlight the row has been updated on table
                    dgvListCTBaoCaoCongNo.Rows(currentRowIndex).Selected = True
                    'Try
                    '    ctpn = CType(dgvListChiTietPhieuNhap.Rows(currentRowIndex).DataBoundItem, CTPhieuNhapDTO)
                    '    txtMaCTPN.Text = ctpn.MaChiTietPhieuNhap
                    '    txtMaSach.Text = ctpn.MaSach
                    '    txtSoLuongNhap.Text = ctpn.SoLuongNhap
                    'Catch ex As Exception
                    '    Console.WriteLine(ex.StackTrace)
                    'End Try
                    MessageBox.Show("Cập nhật chi tiết báo cáo thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật chi tiết báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btXoaCTBCCN_Click(sender As Object, e As EventArgs) Handles btXoaCTBCCN.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListCTBaoCaoCongNo.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListCTBaoCaoCongNo.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa chi tiết phiếu nhập có mã số là " + txtMaCTBCCN.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = ctbccnBus.delete(txtMaCTBCCN.Text)
                        If (result.FlagResult = True) Then
                            ' Re-Load LoaiHocSinh list
                            loadlistCTBaoCaoCongNo()
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListCTBaoCaoCongNo.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListCTBaoCaoCongNo.Rows(currentRowIndex).Selected = True
                            End If
                            MessageBox.Show("Xóa chi tiết phiếu nhập thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa chi tiết phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select
        End If
    End Sub

    Private Sub txtMaBCCN_TextChanged(sender As Object, e As EventArgs) Handles txtMaBCCN.TextChanged
        Try
            Dim maBaoCao = txtMaBCCN.Text
            loadlistCTBaoCaoCongNo_byMaBaoCaoCongNo(maBaoCao)
            loadListBaoCaoCongNo_byMaBaoCaoCongNo(maBaoCao)
        Catch ex As Exception

        End Try
    End Sub


End Class