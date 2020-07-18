Imports QLHSBUS
Imports QLHSDTO
Imports Utility

Public Class frmQuanLiBaoCaoCongNo

    Private bccnBus As BAOCAOCONGNOBUS

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Try
            Dim maBaoCao = txtMaBaoCaoTK.Text
            loadlistBaoCaoCongNo_byMaBaoCaoCongNo(maBaoCao)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCapNhatBaoCaoCongNo_Click(sender As Object, e As EventArgs) Handles btCapNhatBaoCaoCongNo.Click
        Dim currentRowIndex As Integer = dgvListBaoCaoCongNo.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvListBaoCaoCongNo.RowCount) Then
            Try
                Dim bccn As BAOCAOCONGNODTO
                bccn = New BAOCAOCONGNODTO()

                '1. Mapping data from GUI control
                bccn.MaBaoCaoCongNo1 = Convert.ToInt32(txtMaBaoCaoCongNo.Text)
                bccn.Thang1 = dtpThangBaoCaoCongNo.Value
                '2. Business .....
                '3. Insert to DB
                Dim result As Result
                result = bccnBus.update(bccn)
                If (result.FlagResult = True) Then
                    ' Re-Load phieu nhap
                    loadlistBaoCaoCongNo_byThang(dtpThangBaoCaoCongNo.Value.Month)
                    ' Hightlight the row has been updated on table
                    dgvListBaoCaoCongNo.Rows(currentRowIndex).Selected = True
                    Try
                        bccn = CType(dgvListBaoCaoCongNo.Rows(currentRowIndex).DataBoundItem, BAOCAOCONGNODTO)
                        txtMaBaoCaoCongNo.Text = bccn.MaBaoCaoCongNo1
                        dtpThangBaoCaoCongNo.Value = bccn.Thang1
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


    Private Sub frmQuanLiBaoCaoCongNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bccnBus = New BAOCAOCONGNOBUS()
        loadlistBaoCaoCongNo()
    End Sub
    Private Sub loadlistBaoCaoCongNo()
        Dim listBaoCaoCongNo = New List(Of BAOCAOCONGNODTO)
        Dim result As Result
        result = bccnBus.selectAll(listBaoCaoCongNo)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListBaoCaoCongNo.Columns.Clear()
        dgvListBaoCaoCongNo.DataSource = Nothing

        dgvListBaoCaoCongNo.AutoGenerateColumns = False
        dgvListBaoCaoCongNo.AllowUserToAddRows = False
        dgvListBaoCaoCongNo.DataSource = listBaoCaoCongNo

        Dim clMaBaoCaoCongNo = New DataGridViewTextBoxColumn()
        clMaBaoCaoCongNo.Name = "maBaoCaoCongNo"
        clMaBaoCaoCongNo.HeaderText = "Mã Báo Cáo Công Nợ"
        clMaBaoCaoCongNo.DataPropertyName = "MaBaoCaoCongNo1"
        dgvListBaoCaoCongNo.Columns.Add(clMaBaoCaoCongNo)

        Dim clThang = New DataGridViewTextBoxColumn()
        clThang.Name = "thang"
        clThang.HeaderText = "Tháng"
        clThang.DataPropertyName = "Thang1"
        dgvListBaoCaoCongNo.Columns.Add(clThang)
    End Sub
    Private Sub loadlistBaoCaoCongNo_byThang(thang As Integer)
        Dim listBaoCaoCongNo = New List(Of BAOCAOCONGNODTO)
        Dim result As Result
        result = bccnBus.selectAll_byThang(thang, listBaoCaoCongNo)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListBaoCaoCongNo.Columns.Clear()
        dgvListBaoCaoCongNo.DataSource = Nothing

        dgvListBaoCaoCongNo.AutoGenerateColumns = False
        dgvListBaoCaoCongNo.AllowUserToAddRows = False
        dgvListBaoCaoCongNo.DataSource = listBaoCaoCongNo

        Dim clMaBaoCaoCongNo = New DataGridViewTextBoxColumn()
        clMaBaoCaoCongNo.Name = "maBaoCaoCongNo"
        clMaBaoCaoCongNo.HeaderText = "Mã Báo Cáo Công Nợ"
        clMaBaoCaoCongNo.DataPropertyName = "MaBaoCaoCongNo1"
        dgvListBaoCaoCongNo.Columns.Add(clMaBaoCaoCongNo)

        Dim clThang = New DataGridViewTextBoxColumn()
        clThang.Name = "thang"
        clThang.HeaderText = "Tháng"
        clThang.DataPropertyName = "Thang1"
        dgvListBaoCaoCongNo.Columns.Add(clThang)
    End Sub
    Private Sub loadlistBaoCaoCongNo_byMaBaoCaoCongNo(maBaoCaoCongNo As Integer)
        Dim listBaoCaoCongNo = New List(Of BAOCAOCONGNODTO)
        Dim result As Result
        result = bccnBus.selectAll_byMaBaoCaoCongNo(maBaoCaoCongNo, listBaoCaoCongNo)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListBaoCaoCongNo.Columns.Clear()
        dgvListBaoCaoCongNo.DataSource = Nothing

        dgvListBaoCaoCongNo.AutoGenerateColumns = False
        dgvListBaoCaoCongNo.AllowUserToAddRows = False
        dgvListBaoCaoCongNo.DataSource = listBaoCaoCongNo

        Dim clMaBaoCaoCongNo = New DataGridViewTextBoxColumn()
        clMaBaoCaoCongNo.Name = "maBaoCaoCongNo"
        clMaBaoCaoCongNo.HeaderText = "Mã Báo Cáo Công Nợ"
        clMaBaoCaoCongNo.DataPropertyName = "MaBaoCaoCongNo1"
        dgvListBaoCaoCongNo.Columns.Add(clMaBaoCaoCongNo)

        Dim clThang = New DataGridViewTextBoxColumn()
        clThang.Name = "thang"
        clThang.HeaderText = "Tháng"
        clThang.DataPropertyName = "Thang1"
        dgvListBaoCaoCongNo.Columns.Add(clThang)
    End Sub

    Private Sub dgvListBaoCaoCongNo_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListBaoCaoCongNo.SelectionChanged

        Dim currentRowIndex As Integer = dgvListBaoCaoCongNo.CurrentCellAddress.Y

        If (-1 < currentRowIndex And currentRowIndex < dgvListBaoCaoCongNo.RowCount) Then
            Try
                Dim bcct = CType(dgvListBaoCaoCongNo.Rows(currentRowIndex).DataBoundItem, BAOCAOCONGNODTO)
                txtMaBaoCaoCongNo.Text = bcct.MaBaoCaoCongNo1
                dtpThangBaoCaoCongNo.Value = bcct.Thang1
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btXoaBaoCaoCongNo_Click(sender As Object, e As EventArgs) Handles btXoaBaoCaoCongNo.Click
        Dim currentRowIndex As Integer = dgvListBaoCaoCongNo.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvListBaoCaoCongNo.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa phiếu nhập có mã phiếu là  " + txtMaBaoCaoCongNo.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = bccnBus.delete(txtMaBaoCaoCongNo.Text)
                        If (result.FlagResult = True) Then
                            ' Re-Load LoaiHocSinh list
                            loadlistBaoCaoCongNo()
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListBaoCaoCongNo.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListBaoCaoCongNo.Rows(currentRowIndex).Selected = True
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListBaoCaoCongNo.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim bccn = CType(dgvListBaoCaoCongNo.Rows(currentRowIndex).DataBoundItem, BAOCAOCONGNODTO)
                                    txtMaBaoCaoCongNo.Text = bccn.MaBaoCaoCongNo1
                                    dtpThangBaoCaoCongNo.Value = bccn.Thang1
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

    Private Sub dtpThangBaoCaoCongNoTimKiem_ValueChanged(sender As Object, e As EventArgs) Handles dtpThangBaoCaoCongNoTimKiem.ValueChanged
        Try
            Dim thang = dtpThangBaoCaoCongNoTimKiem.Value.Month
            loadlistBaoCaoCongNo_byThang(thang)
        Catch ex As Exception

        End Try
    End Sub


End Class