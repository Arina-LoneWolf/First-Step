Imports QLHSBUS
Imports QLHSDTO
Imports Utility
Public Class frmQLTheLoai


    Private lsbus As LOAISACHBUS
    Private Sub frmQLTheLoai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsbus = New LOAISACHBUS()

        'load content
        LoadContent()


    End Sub

    Private Sub dgvTheLoai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTheLoai.CellContentClick

    End Sub



    Public Sub LoadContent()
        Dim listtheloai = New List(Of THELOAIDTO)
        Dim result As Result
        result = lsbus.selectall(listtheloai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách thể loại không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        dgvTheLoai.DataSource = Nothing
        dgvTheLoai.Columns.Clear()
        dgvTheLoai.AutoGenerateColumns = False
        dgvTheLoai.AllowUserToAddRows = False
        dgvTheLoai.DataSource = listtheloai

        Dim clMaTheLoai = New DataGridViewTextBoxColumn()
        clMaTheLoai.Name = "Imaloaisach"
        clMaTheLoai.HeaderText = "Mã Loại Sách"
        clMaTheLoai.DataPropertyName = "Imaloaisach"
        dgvTheLoai.Columns.Add(clMaTheLoai)


        Dim clTenTheLoai = New DataGridViewTextBoxColumn()
        clTenTheLoai.Name = "Strtenloaisach"
        clTenTheLoai.HeaderText = "Mã Loại Sách"
        clTenTheLoai.DataPropertyName = "Strtenloaisach"
        dgvTheLoai.Columns.Add(clTenTheLoai)
    End Sub

    Private Sub dgvTheLoai_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTheLoai.SelectionChanged
        Dim currentRowIndex As Integer = dgvTheLoai.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListKhachHang.CurrentCellAddress.X 'curent column selected
        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvTheLoai.RowCount) Then
            Try
                Dim tl = CType(dgvTheLoai.Rows(currentRowIndex).DataBoundItem, THELOAIDTO)
                tbxmatheloai.Text = tl.Imaloaisach
                tbxtentheloai.Text = tl.Strtenloaisach
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvTheLoai.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvTheLoai.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa thể loại có mã: " + tbxmatheloai.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = lsbus.delete(Convert.ToInt32(tbxmatheloai.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            LoadContent()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvTheLoai.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvTheLoai.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim nh = CType(dgvTheLoai.Rows(currentRowIndex).DataBoundItem, THELOAIDTO)
                                    tbxmatheloai.Text = nh.Imaloaisach
                                    'tbxtentheloai.Text = nh.Strtenloaisach
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Thể loại thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        Me.Close()
    End Sub

    Private Sub btncapnhat_Click(sender As Object, e As EventArgs) Handles btncapnhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvTheLoai.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvTheLoai.RowCount) Then
            Try
                Dim nh As THELOAIDTO
                nh = New THELOAIDTO()

                '1. Mapping data from GUI control
                nh.Imaloaisach = Convert.ToInt32(tbxmatheloai.Text)
                nh.Strtenloaisach = tbxtentheloai.Text

                '2. Business .....
                If (lsbus.isValidName(nh) = False) Then
                    MessageBox.Show("Tên thể loại không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tbxtentheloai.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = lsbus.update(nh)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    LoadContent()
                    ' Hightlight the row has been updated on table
                    dgvTheLoai.Rows(currentRowIndex).Selected = True
                    Try
                        nh = CType(dgvTheLoai.Rows(currentRowIndex).DataBoundItem, THELOAIDTO)
                        tbxmatheloai.Text = nh.Imaloaisach.ToString()
                        tbxtentheloai.Text = nh.Strtenloaisach
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Thể loại thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Thể loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
End Class