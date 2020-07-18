Imports QLHSBUS
Imports QLHSDAL
Imports QLHSDTO
Imports Utility
Public Class frmSach
    Private sachbus As SACHBUS
    Private theloaibus As LOAISACHBUS
    Private Sub frmSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sachbus = New SACHBUS()
        theloaibus = New LOAISACHBUS()
        'load the loai 
        Dim listtheloai = New List(Of THELOAIDTO)
        Dim result As Result
        result = theloaibus.selectall(listtheloai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbxtheloai.DataSource = New BindingSource(listtheloai, String.Empty)
        cbxtheloai.DisplayMember = "Strtenloaisach"
        cbxtheloai.ValueMember = "Imaloaisach"

        'get auto ma sach
        Dim nextID As Integer

        result = sachbus.getnextID(nextID)
        If (result.FlagResult = True) Then
            tbxmasach.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnnhap_Click(sender As Object, e As EventArgs) Handles btnnhap.Click
        Dim sach As SACHDTO
        sach = New SACHDTO()

        '1. Mapping data from GUI control
        sach.Imasach = Convert.ToInt32(tbxmasach.Text)
        sach.Strtensach = tbxtensach.Text
        sach.Strtacgia = tbxtacgia.Text
        sach.Isoluongton = Convert.ToInt32(tbxsoluong.Text)
        sach.Imaloaisach = Convert.ToInt32(cbxtheloai.SelectedValue)
        sach.Idongia = Convert.ToInt32(tbxdongia.Text)
        '2. Business .....
        If (sachbus.isValicdname(sach) = False) Then
            MessageBox.Show("Tên sách không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxtensach.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = sachbus.insert(sach)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbxtensach.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = sachbus.getnextID(nextID)
            If (result.FlagResult = True) Then
                tbxmasach.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("Thêm sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub cbxtheloai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxtheloai.SelectedIndexChanged

    End Sub
End Class