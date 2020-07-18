Imports QLHSBUS
Imports QLHSDTO
Imports QLHSDAL
Imports Utility
Public Class frmShowAllPhieuThu
    Private phieuthuBUS As PHIEUTHUTIENBUS
    Private khBUS As KHACHHANGBUS

    Private Sub LoadData(listPhieuThu As List(Of PHIEUTHUTIENDTO))
        Dim listKH = New List(Of KHACHHANGDTO)
        Dim result As Result

        For Each phieuthu In listPhieuThu
            result = khBUS.selectALL_ByType(phieuthu.MaKH1, listKH)

            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If

            dgvShow.Rows.Add(phieuthu.MaPhieuThu1, listKH.ElementAt(0).HoTenKH1, phieuthu.NgayThuTien1, phieuthu.SoTienThu1, phieuthu.LyDoThu1)
        Next
    End Sub

    Private Sub frmShowAllPhieuThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieuthuBUS = New PHIEUTHUTIENBUS()
        khBUS = New KHACHHANGBUS()

        Dim listPhieuThu = New List(Of PHIEUTHUTIENDTO)
        Dim result As Result
        result = phieuthuBUS.selectAll(listPhieuThu)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu thu tiền không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        Else
            LoadData(listPhieuThu)
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        dgvShow.Rows.Clear()
        dgvShow.Refresh()

        Dim listPhieuThu = New List(Of PHIEUTHUTIENDTO)
        Dim id = tbID.Text.Trim()
        Dim date_ = dtpkDate.Value.ToString("yyyy-MM-dd")
        Dim result As Result
        If (chkbDate.Checked And (id <> String.Empty)) Then
            result = phieuthuBUS.selectAll_ByDateAndID(date_, id, listPhieuThu)

            If (result.FlagResult = False) Then
                MessageBox.Show("Không tồn tại phiếu thu nào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
        ElseIf (chkbDate.Checked And (id = String.Empty)) Then
            result = phieuthuBUS.selectAll_ByDate(date_, listPhieuThu)
            If (result.FlagResult = False) Then
                MessageBox.Show("Không tồn tại phiếu thu nào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
        ElseIf (id <> String.Empty) Then
            result = phieuthuBUS.selectByID(id, listPhieuThu)
            If (result.FlagResult = False) Then
                MessageBox.Show("Không tồn tại phiếu thu nào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
        Else
            result = phieuthuBUS.selectAll(listPhieuThu)
            If (result.FlagResult = False) Then
                MessageBox.Show("Không tồn tại phiếu thu nào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
        End If

        LoadData(listPhieuThu)
    End Sub
End Class