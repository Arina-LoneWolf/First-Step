Imports QLHSBUS
Imports QLHSDTO
Imports Utility
Public Class frmQLSach

    Private sbus As SACHBUS
    Private theloaibus As LOAISACHBUS
    Private Sub frmQLSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sbus = New SACHBUS()
        theloaibus = New LOAISACHBUS()
        Dim listtheloai = New List(Of THELOAIDTO)
        Dim result As Result
        result = theloaibus.selectall(listtheloai)
        result = theloaibus.selectall(listtheloai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        ComboBox1.DataSource = New BindingSource(listtheloai, String.Empty)
        ComboBox1.DisplayMember = "Strtenloaisach"
        ComboBox1.ValueMember = "Imaloaisach"

        cbxtheloai.DataSource = New BindingSource(listtheloai, String.Empty)
        cbxtheloai.DisplayMember = "Strtenloaisach"
        cbxtheloai.ValueMember = "Imaloaisach"

        LoadContent()
    End Sub




    Public Sub LoadContent()
        Dim listsach = New List(Of SACHDTO)
        Dim result As Result
        result = sbus.selectAll(listsach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đầu sách không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        dgvsach.DataSource = Nothing
        dgvsach.Columns.Clear()
        dgvsach.AutoGenerateColumns = False
        dgvsach.AllowUserToAddRows = False
        dgvsach.DataSource = listsach

        Dim clMaSach = New DataGridViewTextBoxColumn()
        clMaSach.Name = "Imasach"
        clMaSach.HeaderText = "Mã Sách"
        clMaSach.DataPropertyName = "Imasach"
        dgvsach.Columns.Add(clMaSach)

        Dim clTenSach = New DataGridViewTextBoxColumn()
        clTenSach.Name = "Strtensach"
        clTenSach.HeaderText = "Ten Sach"
        clTenSach.DataPropertyName = "Strtensach"
        dgvsach.Columns.Add(clTenSach)

        Dim clMaLoaiSach = New DataGridViewTextBoxColumn()
        clMaLoaiSach.Name = "Imaloaisach"
        clMaLoaiSach.HeaderText = "TheLoai"
        clMaLoaiSach.DataPropertyName = "Imaloaisach"
        dgvsach.Columns.Add(clMaLoaiSach)


        Dim clTacGia = New DataGridViewTextBoxColumn()
        clTacGia.Name = "Strtacgia"
        clTacGia.HeaderText = "tác giả"
        clTacGia.DataPropertyName = "Strtacgia"
        dgvsach.Columns.Add(clTacGia)


        Dim clSoLuongTon = New DataGridViewTextBoxColumn()
        clSoLuongTon.Name = "Isoluongton"
        clSoLuongTon.HeaderText = "Số lượng tồn"
        clSoLuongTon.DataPropertyName = "Isoluongton"
        dgvsach.Columns.Add(clSoLuongTon)

        Dim clDonGia = New DataGridViewTextBoxColumn()
        clDonGia.Name = "Idongia"
        clDonGia.HeaderText = "Đơn giá"
        clDonGia.DataPropertyName = "Idongia"
        dgvsach.Columns.Add(clDonGia)
    End Sub

    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        Me.Close()
    End Sub

    Private Sub dgvsach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvsach.SelectionChanged
        Dim currentRowIndex As Integer = dgvsach.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListKhachHang.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvsach.RowCount) Then
            Try
                Dim sach = CType(dgvsach.Rows(currentRowIndex).DataBoundItem, SACHDTO)
                tbxmasach.Text = sach.Imasach
                tbxsoluong.Text = sach.Isoluongton
                tbxtacgia.Text = sach.Strtacgia
                tbxtensach.Text = sach.Strtensach
                tbxdongia.Text = sach.Idongia
                cbxtheloai.SelectedValue = sach.Imaloaisach

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub btncapnhat_Click(sender As Object, e As EventArgs) Handles btncapnhat.Click
        Dim currentRowIndex As Integer = dgvsach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvsach.RowCount) Then
            Try
                Dim nh As SACHDTO

                nh = New SACHDTO()

                '1. Mapping data from GUI control
                nh.Imasach = Convert.ToInt32(tbxmasach.Text)
                nh.Strtensach = tbxtensach.Text
                nh.Imaloaisach = cbxtheloai.SelectedValue
                nh.Strtacgia = tbxtacgia.Text
                nh.Idongia = Convert.ToInt32(tbxdongia.Text)
                '2. Business .....

                '3. Insert to DB

                Dim result As Result
                result = sbus.update(nh)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    LoadContent()
                    ' Hightlight the row has been updated on table
                    dgvsach.Rows(currentRowIndex).Selected = True
                    Try
                        nh = CType(dgvsach.Rows(currentRowIndex).DataBoundItem, SACHDTO)
                        tbxmasach.Text = nh.Imasach.ToString()
                        tbxtensach.Text = nh.Strtensach
                        cbxtheloai.SelectedValue = nh.Imaloaisach
                        tbxtacgia.Text = nh.Strtacgia
                        tbxdongia.Text = nh.Idongia.ToString()

                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvsach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvsach.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa thể loại có mã: " + tbxmasach.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        Dim sach As SACHDTO

                        sach = New SACHDTO()
                        sach.Imasach = Convert.ToInt32(tbxmasach.Text)
                        '1. Delete from DB
                        Dim result As Result
                        result = sbus.delete(sach)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            LoadContent()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvsach.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvsach.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim nh = CType(dgvsach.Rows(currentRowIndex).DataBoundItem, THELOAIDTO)
                                    tbxmasach.Text = nh.Imaloaisach
                                    'tbxtentheloai.Text = nh.Strtenloaisach
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
End Class