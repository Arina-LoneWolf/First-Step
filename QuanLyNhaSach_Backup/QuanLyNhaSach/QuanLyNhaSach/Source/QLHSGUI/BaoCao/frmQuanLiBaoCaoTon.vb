Imports QLHSBUS
Imports QLHSDTO
Imports Utility

Public Class frmQuanLiBaoCaoTon
    Private bctBus As BAOCAOTONBUS
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Try
            Dim maBaoCao = txtMaBaoCaoTK.Text
            loadlistBaoCaoCongNo_byMaBaoCaoTon(maBaoCao)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmQuanLiBaoCaoTon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bctBus = New BAOCAOTONBUS()
        ' Load list bao cao ton
        loadlistBaoCaoTon()
    End Sub
    Private Sub loadlistBaoCaoTon()
        ' Load danh sach bao cao ton len datagridview
        Dim listBaoCaoTon = New List(Of BAOCAOTONDTO)
        Dim result As Result
        result = bctBus.selectAll(listBaoCaoTon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListBaoCaoTon.Columns.Clear()
        dgvListBaoCaoTon.DataSource = Nothing

        dgvListBaoCaoTon.AutoGenerateColumns = False
        dgvListBaoCaoTon.AllowUserToAddRows = False
        dgvListBaoCaoTon.DataSource = listBaoCaoTon

        Dim clMaBCT = New DataGridViewTextBoxColumn()
        clMaBCT.Name = "maBaoCaoTon"
        clMaBCT.HeaderText = "Mã Báo Cáo Tồn"
        clMaBCT.DataPropertyName = "MaBaoCaoTon1"
        dgvListBaoCaoTon.Columns.Add(clMaBCT)

        Dim clThangBCT = New DataGridViewTextBoxColumn()
        clThangBCT.Name = "thang"
        clThangBCT.HeaderText = "Tháng"
        clThangBCT.DataPropertyName = "Thang1"
        dgvListBaoCaoTon.Columns.Add(clThangBCT)

    End Sub



    Private Sub loadlistBaoCaoTon_byThang(thang As Integer)
        ' Load danh sach bao cao ton len datagridview
        Dim listBaoCaoTon = New List(Of BAOCAOTONDTO)
        Dim result As Result
        result = bctBus.selectAll_byThang(thang, listBaoCaoTon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListBaoCaoTon.Columns.Clear()
        dgvListBaoCaoTon.DataSource = Nothing

        dgvListBaoCaoTon.AutoGenerateColumns = False
        dgvListBaoCaoTon.AllowUserToAddRows = False
        dgvListBaoCaoTon.DataSource = listBaoCaoTon

        Dim clMaBCT = New DataGridViewTextBoxColumn()
        clMaBCT.Name = "maBaoCaoTon"
        clMaBCT.HeaderText = "Mã Báo Cáo Tồn"
        clMaBCT.DataPropertyName = "MaBaoCaoTon1"
        dgvListBaoCaoTon.Columns.Add(clMaBCT)

        Dim clThangBCT = New DataGridViewTextBoxColumn()
        clThangBCT.Name = "thang"
        clThangBCT.HeaderText = "Tháng"
        clThangBCT.DataPropertyName = "Thang1"
        dgvListBaoCaoTon.Columns.Add(clThangBCT)

    End Sub
    Private Sub loadlistBaoCaoCongNo_byMaBaoCaoTon(maBaoCaoTon As Integer)
        Dim listBaoCaoTon = New List(Of BAOCAOTONDTO)
        Dim result As Result
        result = bctBus.selectAll_byMaBaoCaoTon(maBaoCaoTon, listBaoCaoTon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListBaoCaoTon.Columns.Clear()
        dgvListBaoCaoTon.DataSource = Nothing

        dgvListBaoCaoTon.AutoGenerateColumns = False
        dgvListBaoCaoTon.AllowUserToAddRows = False
        dgvListBaoCaoTon.DataSource = listBaoCaoTon

        Dim clMaBaoCaoCongNo = New DataGridViewTextBoxColumn()
        clMaBaoCaoCongNo.Name = "maBaoCaoTon"
        clMaBaoCaoCongNo.HeaderText = "Mã Báo Cáo Tồn"
        clMaBaoCaoCongNo.DataPropertyName = "MaBaoCaoTon1"
        dgvListBaoCaoTon.Columns.Add(clMaBaoCaoCongNo)

        Dim clThang = New DataGridViewTextBoxColumn()
        clThang.Name = "thang"
        clThang.HeaderText = "Tháng"
        clThang.DataPropertyName = "Thang1"
        dgvListBaoCaoTon.Columns.Add(clThang)
    End Sub

    Private Sub dgvListBaoCaoTon_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListBaoCaoTon.SelectionChanged
        Dim currentRowIndex As Integer = dgvListBaoCaoTon.CurrentCellAddress.Y

        If (-1 < currentRowIndex And currentRowIndex < dgvListBaoCaoTon.RowCount) Then
            Try
                Dim bcct = CType(dgvListBaoCaoTon.Rows(currentRowIndex).DataBoundItem, BAOCAOTONDTO)
                txtMaBaoCaoTon.Text = bcct.MaBaoCaoTon1
                dtpThangBaoCaoTon.Value = bcct.Thang1
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btXoaBaoCaoTon_Click(sender As Object, e As EventArgs) Handles btXoaBaoCaoTon.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListBaoCaoTon.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListBaoCaoTon.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa báo cáo có mã là  " + txtMaBaoCaoTon.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = bctBus.delete(Convert.ToInt32(txtMaBaoCaoTon.Text))
                        If (result.FlagResult = True) Then
                            ' Re-Load LoaiHocSinh list
                            loadlistBaoCaoTon()
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListBaoCaoTon.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListBaoCaoTon.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim bct = CType(dgvListBaoCaoTon.Rows(currentRowIndex).DataBoundItem, BAOCAOTONDTO)
                                    txtMaBaoCaoTon.Text = bct.MaBaoCaoTon1
                                    dtpThangBaoCaoTon.Value = bct.Thang1
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa báo cáo thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub dtpThangBaoCaoTonTimKiem_ValueChanged(sender As Object, e As EventArgs) Handles dtpThangBaoCaoTonTimKiem.ValueChanged
        Try
            Dim thang = dtpThangBaoCaoTonTimKiem.Value.Month
            loadlistBaoCaoTon_byThang(thang)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCapNhatBaoCaoTon_Click(sender As Object, e As EventArgs) Handles btCapNhatBaoCaoTon.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListBaoCaoTon.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListBaoCaoTon.RowCount) Then
            Try
                Dim bct As BAOCAOTONDTO
                bct = New BAOCAOTONDTO()

                '1. Mapping data from GUI control
                bct.MaBaoCaoTon1 = Convert.ToInt32(txtMaBaoCaoTon.Text)
                bct.Thang1 = dtpThangBaoCaoTon.Value

                '2. Business .....
                '3. Insert to DB
                Dim result As Result
                result = bctBus.update(bct)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadlistBaoCaoTon()
                    ' Hightlight the row has been updated on table
                    dgvListBaoCaoTon.Rows(currentRowIndex).Selected = True
                    Try
                        bct = CType(dgvListBaoCaoTon.Rows(currentRowIndex).DataBoundItem, BAOCAOTONDTO)
                        txtMaBaoCaoTon.Text = bct.MaBaoCaoTon1
                        dtpThangBaoCaoTon.Value = bct.Thang1
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật báo cáo thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
End Class