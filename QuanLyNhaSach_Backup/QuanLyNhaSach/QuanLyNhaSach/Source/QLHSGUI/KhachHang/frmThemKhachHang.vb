Imports QLHSBUS
Imports QLHSDTO
Imports Utility

Public Class frmThemKhachHang
    Private khbus As KHACHHANGBUS
    Private Sub frmThemKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khbus = New KHACHHANGBUS

        ' Get Next ID
        Dim nextID As Integer '
        Dim result As Result
        result = khbus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaKH.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim kh As KHACHHANGDTO
        kh = New KHACHHANGDTO()

        '1. Mapping data from GUI control
        kh.MaKH1 = Convert.ToInt32(txtMaKH.Text)
        kh.HoTenKH1 = txtHoTenKH.Text
        kh.TienNoKH1 = txtTienNoKH.Text
        kh.DiaChi1 = txtDiaChi.Text
        kh.Email1 = txtEmail.Text
        kh.Sdt1 = txtSDT.Text
        '2. Business .....
        'check name
        If (khbus.isValidName(kh) = False) Then
            MessageBox.Show("Tên khách hàng không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtHoTenKH.Focus()
            Return
        End If

        'check email
        If (khbus.IsValidEmailFormat(txtEmail.Text) = False) Then
            MessageBox.Show("Địa chỉ email không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            Return
        End If

        '3. Insert to DB
        Dim result As Result
        result = khbus.insert(kh)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm khách hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtHoTenKH.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = khbus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaKH.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("Thêm khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub



End Class