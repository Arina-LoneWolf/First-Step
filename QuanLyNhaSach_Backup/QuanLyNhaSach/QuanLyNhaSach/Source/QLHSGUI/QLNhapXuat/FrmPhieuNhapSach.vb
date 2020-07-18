Imports QLHSBUS
Imports QLHSDAL
Imports QLHSDTO
Imports Utility
Imports System.Windows.Forms.DateTimePicker
Imports System.Threading
Imports System.IO

Public Class FrmPhieuNhapSach
    Private phieunhapbus As PHIEUNHAPBUS
    Private chitietphieunhapbus As CHITIETPHIEUNHAPBUS
    Private theloaibus As LOAISACHBUS
    Private nextID As Integer
    Private thrChitietphieunhap As Thread
    Private thrPhieunhap As Thread
    Private Sub getIDPhieunhapthread()
        Dim phieunhap = New List(Of PHIEUNHAPDTO)
        Dim result As Result
        result = phieunhapbus.selectAll(phieunhap)
    End Sub
    Private Sub getIDChitietphieunhapthread()
        Dim chitietphieunhap = New List(Of PHIEUNHAPDTO)
        Dim result As Result
        result = phieunhapbus.selectAll(chitietphieunhap)
    End Sub
    Private Sub FrmPhieuNhapSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieunhapbus = New PHIEUNHAPBUS()
        theloaibus = New LOAISACHBUS()
        chitietphieunhapbus = New CHITIETPHIEUNHAPBUS()
        thrPhieunhap = New Thread(New ThreadStart(AddressOf getIDPhieunhapthread))
        thrChitietphieunhap = New Thread(New ThreadStart(AddressOf getIDChitietphieunhapthread))
        'Dim phieunhapbus As New Thread(ThreadLocal(Of)
        Dim result1 As Result
        Dim listtheloai = New List(Of THELOAIDTO)
        result1 = theloaibus.selectall(listtheloai) 'lay danh sach the loai
        tbMaphieunhap.ReadOnly() = True
        If (result1.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result1.SystemMessage)
            Me.Close()
            Return
        End If
        cbTheloai.DataSource = New BindingSource(listtheloai, String.Empty)
        cbTheloai.DisplayMember = "Strtenloaisach"
        cbTheloai.ValueMember = "Imaloaisach"
        'get auto ma phieu nhap

        Dim result As Result
        result = phieunhapbus.getnextID(nextID)

        tbMaphieunhap.Text = nextID.ToString()

        If (result.FlagResult = True) Then

        Else
            MessageBox.Show("Lấy ID kế tiếp của phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(Result.SystemMessage)
        End If
        result = chitietphieunhapbus.getnextID(nextID)
        If (result.FlagResult = True) Then

        Else
            MessageBox.Show("Lấy ID kế tiếp của chi tiết phiếu nhập không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Public Function Clear()
        tbxDongia.Clear()
        tbxSoLuong.Clear()
        tbxTacGia.Clear()
        tbxTenSach.Clear()
        tbxTenSach.Focus()
    End Function
    Private Sub btnQuydinh_Click(sender As Object, e As EventArgs) Handles btnQuydinh.Click
        frmQuyDinhNhap.Show()
    End Sub
    Dim indexRow As Integer = 0

    Private Sub btnThemvaodanhsach_Click(sender As Object, e As EventArgs) Handles btnThemvaodanhsach.Click
        If (tbxTenSach.Text = String.Empty Or tbxTacGia.Text = String.Empty Or tbxSoLuong.Text = String.Empty Or tbxDongia.Text = String.Empty) Then
            MessageBox.Show("Thêm vào danh sách không thành công, kiểm tra lại thông tin nhập ", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Clear()
            Return
        End If
        Select Case MsgBox("Bạn có thực sự muốn thêm " + tbxTenSach.Text() + " vào danh sách", MsgBoxStyle.YesNo, "Information")
            Case MsgBoxResult.Yes
                Try
                    If (dgvListsach.Rows(0).Cells(0).Value >= 0) Then
                        indexRow = indexRow + 1
                    End If
                    dgvListsach.Rows.Add(New String() {indexRow.ToString(), tbxTenSach.Text, cbTheloai.Text, tbxTacGia.Text, tbxSoLuong.Text, tbxDongia.Text})

                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                End Try
            Case MsgBoxResult.No
                Return

        End Select

        Dim sachBus As SACHBUS = New SACHBUS()
        Dim sachID As Integer
        sachBus.getnextID(sachID)

        Dim phieuNhap As PHIEUNHAPDTO = New PHIEUNHAPDTO(nextID, dtpNgaynhap.Value.ToString())

        chitietphieunhapbus.getnextID(nextID)
        Dim ctpn As CHITIETPHIEUNHAPDTO
        ctpn = New CHITIETPHIEUNHAPDTO()
        ctpn.Imachitietphieunhap = nextID
        ctpn.Imaphieunhap = nextID
        ctpn.Imasach = sachID
        ctpn.ItenSach = tbxTenSach.Text
        ctpn.Itacgia = tbxTacGia.Text
        ctpn.Itheloai = cbTheloai.Text
        ctpn.Isoluongnhap = tbxSoLuong.Text
        ctpn.Idongia = tbxDongia.Text

        'MessageBox.Show(String.Format("{0} {1} {2} {3} {4} {5} {6} {7}", ctpn.Imachitietphieunhap, ctpn.Imaphieunhap, ctpn.Imasach, ctpn.ItenSach, ctpn.Itacgia, ctpn.Itheloai, ctpn.Isoluongnhap, ctpn.Idongia))

        Dim result3 As Result
        result3 = phieunhapbus.insert(phieuNhap)
        If (result3.FlagResult = True) Then
            MessageBox.Show("Thêm phiếu nhập thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Dim result4 As Result
        result4 = chitietphieunhapbus.insertct(ctpn)
        If (result4.FlagResult = True) Then
            MessageBox.Show("Thêm chi tiết phiếu nhập thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim pn As PHIEUNHAPDTO
        pn = New PHIEUNHAPDTO()
        'Dim ctpn As CHITIETPHIEUNHAPDTO
        'ctpn = New CHITIETPHIEUNHAPDTO()
        '1.MAping data from GUI Control
        pn.Imaphieunhap = Int32.TryParse(tbMaphieunhap.Text, pn.Imaphieunhap)
        pn.Datengaynhap = dtpNgaynhap.Value.ToString()
        'ctpn.Imachitietphieunhap = ctpn.Imachitietphieunhap
        'ctpn.ItenSach = tbxTenSach.Text
        'ctpn.Itheloai = cbTheloai.Text
        'ctpn.Isoluongnhap = tbxSoLuong.Text
        'ctpn.Idongia = tbxDongia.Text
        '2 Insert to DB
        Dim result2 As Result
        'result2 = phieunhapbus.insert(pn)
        ' Dim result3 As Result
        'result3 = phieunhapbus.insertct(ctpn)

        tbMaphieunhap.Text = String.Empty
            'lay auto ma phieu nhap ke tiep
            Dim nextID As Integer
            result2 = phieunhapbus.getnextID(nextID)
            If (result2.FlagResult = True) Then
                tbMaphieunhap.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp không thành công. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Console.WriteLine(result2.SystemMessage)
            End If

        MessageBox.Show("Lưu phiếu nhập thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Console.WriteLine(result2.SystemMessage)

        Dim nextChitietphieunhapID As Integer
        chitietphieunhapbus.getnextID(nextChitietphieunhapID)
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        'e.Graphics.ScaleTransform(0.8F, 0.8F)
        'Dim font As Font = New Font("Courier New", 12)
        'Dim fontHeight As Double = font.GetHeight()

        'Dim startX As Integer = 10
        'Dim startY As Integer = 10
        'Dim offset As Integer = 200

        'get max string lenght from each row
        'Dim maxlen As Integer = 0
        'For Each items As String() In listOrder
        'Dim listHeader As String = String.Empty
        'listHeader &= String.Format("{0,-15}", "STT")
        'listHeader &= String.Format("{0,-15}", "Sach")
        'listHeader &= String.Format("{0,15}", "The loai")
        'listHeader &= String.Format("{0,15}", "Tac Gia")
        'listHeader &= String.Format("{0,15}", "So luong")
        'listHeader &= String.Format("{0,15}", "Don gia nhap")

        ''Dim 

        'Dim graphic As Graphics = e.Graphics
        'graphic.DrawString("DAnh sach nhap ", New Font("Courier", 18, FontStyle.Bold), New SolidBrush(Color.Black), startX, 0)
        ''chi tiet phieu nhap
        'graphic.DrawString(listHeader, New Font("Courier", 18, FontStyle.Bold), New SolidBrush(Color.Black), startX, startY + 160)
        Dim writer As TextWriter = New StreamWriter("D:\nhac\text.txt") 'tao file tai o dia muon luu chi tiet danh sach nhap
        For i As Integer = 0 To dgvListsach.Rows.Count - 2 Step +1

            For j As Integer = 0 To dgvListsach.Columns.Count - 1 Step +1

                writer.Write(vbTab & dgvListsach.Rows(i).Cells(j).Value.ToString() & vbTab & "|")

            Next

            writer.WriteLine("")
            writer.WriteLine("----------------------------------------------------------------------------------------------------------------------------")

        Next
        writer.Close()
        MessageBox.Show("Data Exported")
    End Sub
End Class