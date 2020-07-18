Imports QLHSBUS
Imports QLHSDTO
Imports Utility

Public Class frmQuanLiKhachHang
    Private khBus As KHACHHANGBUS
    Private Sub frmQuanLiKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khBus = New KHACHHANGBUS()
        Dim listkh = New List(Of KHACHHANGDTO)
        loadListKH()
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

        'dgvListKhachHang.SuspendLayout()
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

    Private Sub loadListKH_ByName(name As String)
        Dim listKH = New List(Of KHACHHANGDTO)
        Dim result As Result
        result = khBus.selectALL_ByName(name, listKH)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khách hàng theo mã khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListKhachHang.SuspendLayout()
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

        'Dim clLoaikh= New DataGridView()

        Dim clTienNo = New DataGridViewTextBoxColumn()
        clTienNo.Name = "tienNoKH"
        clTienNo.HeaderText = "Tiền Nợ Khách Hàng"
        clTienNo.DataPropertyName = "tienNoKH1"
        dgvListKhachHang.Columns.Add(clTienNo)
        'dgvListKhachHang.ResumeLayout()

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
    Private Sub loadListKH_ByMaKH(makh As String)
        Dim listKH = New List(Of KHACHHANGDTO)
        Dim result As Result
        result = khBus.selectALL_ByType(makh, listKH)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khách hàng theo mã khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListKhachHang.SuspendLayout()
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

        'Dim clLoaikh= New DataGridView()

        Dim clTienNo = New DataGridViewTextBoxColumn()
        clTienNo.Name = "tienNoKH"
        clTienNo.HeaderText = "Tiền Nợ Khách Hàng"
        clTienNo.DataPropertyName = "tienNoKH1"
        dgvListKhachHang.Columns.Add(clTienNo)
        'dgvListKhachHang.ResumeLayout()

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

    Private Sub dgvListKhachHang_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListKhachHang.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListKhachHang.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListKhachHang.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListKhachHang.RowCount) Then
            Try
                Dim kh = CType(dgvListKhachHang.Rows(currentRowIndex).DataBoundItem, KHACHHANGDTO)
                txtMaKH.Text = kh.MaKH1
                txtHoTenKH.Text = kh.HoTenKH1
                txtTienNoKH.Text = kh.TienNoKH1
                txtDiaChi.Text = kh.DiaChi1
                txtEmail.Text = kh.Email1
                txtSDT.Text = kh.Sdt1
                txtMaKHTimKiem.Text = kh.MaKH1
                txtHoTenKHTimKiem.Text = kh.HoTenKH1
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub


    Private Sub btCapNhatKhachHang_Click(sender As Object, e As EventArgs) Handles btCapNhatKhachHang.Click


        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListKhachHang.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListKhachHang.RowCount) Then
            Try
                Dim kh As KHACHHANGDTO
                kh = New KHACHHANGDTO

                '1. Mapping data from GUI control
                kh.MaKH1 = txtMaKH.Text
                kh.HoTenKH1 = txtHoTenKH.Text
                kh.TienNoKH1 = txtTienNoKH.Text
                kh.DiaChi1 = txtDiaChi.Text
                kh.Email1 = txtEmail.Text
                kh.Sdt1 = txtSDT.Text
                '2. Business .....
                If (khBus.isValidName(kh) = False) Then
                    MessageBox.Show("Tên khách hàng không đúng.")
                    txtHoTenKH.Focus()
                    Return
                End If
                '3. Insert to DB
                Dim result As Result
                result = khBus.update(kh)
                If (result.FlagResult = True) Then
                    ' Re-Load khlist
                    loadListKH_ByMaKH(txtMaKH.Text)
                    ' Hightlight the row has been updated on table
                    dgvListKhachHang.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật khách hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btXoaKhachHang_Click(sender As Object, e As EventArgs) Handles btXoaKhachHang.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListKhachHang.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListKhachHang.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa khách hàng có mã số là " + txtMaKH.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = khBus.delete(txtMaKH.Text)
                        If (result.FlagResult = True) Then
                            ' Re-Load LoaiHocSinh list
                            loadListKH()
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListKhachHang.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListKhachHang.Rows(currentRowIndex).Selected = True
                            End If
                            MessageBox.Show("Xóa khách hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btTimKiemTheoMAKH_Click(sender As Object, e As EventArgs) Handles btTimKiemTheoMAKH.Click
        Try
            Dim makh = txtMaKHTimKiem.Text
            loadListKH_ByMaKH(makh)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btTimKiemTheHoTen_Click(sender As Object, e As EventArgs) Handles btTimKiemTheHoTen.Click
        Try
            Dim name = txtHoTenKHTimKiem.Text
            loadListKH_ByName(name)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btTimKiemTheHoTen_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtHoTenKHTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtHoTenKHTimKiem.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btTimKiemTheoMAKH_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtMaKHTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtMaKHTimKiem.TextChanged

    End Sub
End Class