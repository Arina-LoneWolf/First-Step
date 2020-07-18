Imports QLHSBUS
Imports QLHSDTO
Imports QLHSDAL
Imports Utility
Imports System.Threading
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Drawing.Printing
Public Class frmPhieuThuTien
    Private frmShowAll As frmShowAllPhieuThu

    Private khBUS As KHACHHANGBUS
    Private hdBUS As HOADONBUS

    Dim tbLyDoThu = New Placeholder.PlaceholderTextBox()

    Dim maKH As Integer

    Private Sub ClearFields()
        lbNamePre.Text = String.Empty
        lbPhonePre.Text = String.Empty
        lbAddressPre.Text = String.Empty
        lbEmailPre.Text = String.Empty
        lbPaymentPre.Text = String.Empty
        lbReasonPre.Text = String.Empty
    End Sub
    Private Sub LoadIdReceiptList()
        Dim listIdHD = New List(Of Integer)
        Dim result As Result
        result = hdBUS.selectAllID(listIdHD)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách mã hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbMaHD.DataSource = listIdHD
    End Sub

    Private Sub LoadCustomerList()
        Dim listKH = New List(Of KHACHHANGDTO)
        Dim result As Result
        result = khBUS.selectAll(listKH)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        Dim listName_ID = New List(Of String)
        For Each item In listKH
            Dim name_ID As String
            name_ID = item.HoTenKH1 & " " & item.MaKH1
            listName_ID.Add(name_ID)
        Next

        cbHoTenID.DataSource = listName_ID
    End Sub

    Private Sub getID()
        Dim phieuthuBUS As PHIEUTHUTIENBUS = New PHIEUTHUTIENBUS()

        Dim id As Integer
        Dim result As Result

        result = phieuthuBUS.getNextID(id)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy ID kế tiếp của phiếu thu tiền không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        lbId.Text = id.ToString()
    End Sub

    Private Function insertPhieuThu() As Result
        Dim idKH As Integer = Nothing
        If (cbHoTenID.Visible) Then
            idKH = cbHoTenID.SelectedItem.ToString().Split(" ").LastOrDefault()
        Else
            idKH = maKH
        End If
        Dim phieuthu As PHIEUTHUTIENDTO = New PHIEUTHUTIENDTO(Integer.Parse(lbId.Text), idKH, DateTime.Now, lbPaymentPre.Text, lbReasonPre.Text)
        Dim phieuthuBUS As PHIEUTHUTIENBUS = New PHIEUTHUTIENBUS()
        Dim result As Result = phieuthuBUS.insert(phieuthu)
        If (result.FlagResult = False) Then
            Return New Result(False, "Thêm hóa đơn không thành công", result.SystemMessage)
        End If
        Return New Result(True)
    End Function

    Private Function PrintBill() As Boolean
        printDoc.DefaultPageSettings.Landscape = True
        printDoc.DefaultPageSettings.PaperSize.RawKind = PaperKind.A3

        Dim resultDialog As DialogResult = printDia.ShowDialog()
        If (resultDialog = DialogResult.OK) Then
            printDoc.Print()
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub frmPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khBUS = New KHACHHANGBUS()
        hdBUS = New HOADONBUS()

        ClearFields()
        LoadIdReceiptList()
        LoadCustomerList()

        tbLyDoThu.Font = New Font("Serif", 10)
        tbLyDoThu.PlaceholderText = "Ghi rõ lý do..."
        tbLyDoThu.Multiline = True
        tbLyDoThu.Location = New Point(cbLyDoThu.Location.X, cbLyDoThu.Location.Y + 34)
        tbLyDoThu.Size = New Size(cbLyDoThu.Size.Width, 110)
        tbLyDoThu.Visible = False
        gbInput.Controls.Add(tbLyDoThu)

        cbLyDoThu.SelectedIndex = 0
        lbReasonPre.Text = cbLyDoThu.Text + " " + cbMaHD.Text

        lbNamePre.DataBindings.Add("Text", tbHoTen, "Text")
        lbPaymentPre.DataBindings.Add("Text", tbSoTienThu, "Text")

        getID()

        Dim now = DateTime.Now
        lbDate.Text = now.ToString("dd/MM/yyyy hh:mm:ss tt")
    End Sub

    Private Sub cbLyDoThu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLyDoThu.SelectedIndexChanged
        If (cbLyDoThu.Text = "Thu tiền hóa đơn") Then
            lbMaHD.Visible = True
            cbMaHD.Visible = True
            tbLyDoThu.Visible = False
            tbHoTen.Visible = True
            cbHoTenID.Visible = False
            lbReasonPre.Text = cbLyDoThu.Text + " " + cbMaHD.Text
        ElseIf (cbLyDoThu.SelectedItem.ToString() = "Thu tiền nợ hóa đơn") Then
            lbMaHD.Visible = True
            cbMaHD.Visible = True
            tbLyDoThu.Visible = False
            tbHoTen.Visible = True
            cbHoTenID.Visible = False
            lbReasonPre.Text = cbLyDoThu.Text + " " + cbMaHD.Text
        Else
            lbMaHD.Visible = False
            cbMaHD.Visible = False
            tbLyDoThu.Visible = True
            tbHoTen.Visible = False
            cbHoTenID.Visible = True
            lbReasonPre.DataBindings.Add("Text", tbLyDoThu, "Text")
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim listKH = New List(Of KHACHHANGDTO)
        Dim result As Result
        result = khBUS.selectALL_ByType(maKH, listKH)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        If (cbLyDoThu.SelectedItem = "Thu tiền nợ hóa đơn") Then
            Dim tienNo = Convert.ToInt32(listKH.ElementAt(0).TienNoKH1)
            Dim tienTraNo = Convert.ToInt32(tbSoTienThu.Text)
            Dim soDuNo = tienNo - tienTraNo

            If (soDuNo >= 0) Then
                listKH.ElementAt(0).TienNoKH1 = soDuNo.ToString()
                result = khBUS.update(listKH.ElementAt(0))

                If (result.FlagResult = False) Then
                    MessageBox.Show("Cập nhật tiền nợ khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If
            Else
                MessageBox.Show("Số tiền thu không được vượt quá số tiền khách hàng đang nợ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        'In phiếu
        Dim resultDialog = MessageBox.Show("Xuất phiếu thu tiền?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If (resultDialog = DialogResult.OK) Then
            'In
            If PrintBill() Then
                'Lưu phiếu
                result = insertPhieuThu()

                If (result.FlagResult = False) Then
                    MessageBox.Show("Thêm phiếu thu tiền thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                Else
                    MessageBox.Show("Xuất phiếu thu tiền thành công.", "Message")
                    tbSoTienThu.Clear()
                    Return
                End If
            Else
                MessageBox.Show("Hủy xuất phiếu thu tiền", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        frmShowAll = New frmShowAllPhieuThu()
        frmShowAll.Show()
    End Sub

    Private Sub cbMaHD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaHD.SelectedIndexChanged
        Dim listHD = New List(Of HOADONDTO)
        Dim result As Result
        result = hdBUS.selectAll_ByID(cbMaHD.SelectedItem, listHD)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        maKH = listHD.ElementAt(0).MaKH

        Dim listKH = New List(Of KHACHHANGDTO)
        result = khBUS.selectALL_ByType(maKH, listKH)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        tbHoTen.Text = listKH.ElementAt(0).HoTenKH1
        lbNamePre.Text = listKH.ElementAt(0).HoTenKH1
        lbPhonePre.Text = listKH.ElementAt(0).Sdt1
        lbAddressPre.Text = listKH.ElementAt(0).DiaChi1
        lbEmailPre.Text = listKH.ElementAt(0).Email1

        If ((cbLyDoThu.Text = "Thu tiền hóa đơn") Or (cbLyDoThu.Text = "Thu tiền nợ hóa đơn")) Then
            lbReasonPre.Text = cbLyDoThu.Text + " " + cbMaHD.Text
        End If
    End Sub

    Private Sub printDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDoc.PrintPage
        e.Graphics.ScaleTransform(0.8F, 0.8F)
        Dim font As Font = New Font("Courier New", 13)

        Dim X As Integer = 30
        Dim Y As Integer = 70
        Dim title As String = "PHIẾU THU TIỀN"

        Dim id As String = "Mã phiếu thu: " & lbId.Text
        Dim date_ As String = "Ngày thu: " & DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
        Dim name As String = "Họ tên khách hàng: " & lbNamePre.Text
        Dim address As String = "Địa chỉ: " & lbAddressPre.Text
        Dim phone As String = "SĐT: " & lbPhonePre.Text
        Dim email As String = "Email: " & lbEmailPre.Text
        Dim payment As String = "Số tiền thu: " & lbPaymentPre.Text
        Dim reason As String = "Lý do thu: " & lbReasonPre.Text

        Dim graphic As Graphics = e.Graphics
        Dim pageWidth As Double = e.PageSettings.PaperSize.Width

        graphic.DrawString(title, New Font("Courier New", 18, FontStyle.Bold), New SolidBrush(Color.Red), (pageWidth - title.Length) / 2, 20)
        graphic.DrawString(id, font, New SolidBrush(Color.Black), X, Y)
        graphic.DrawString(date_, font, New SolidBrush(Color.Black), X, Y + 25)
        graphic.DrawString(name, font, New SolidBrush(Color.Black), X, Y + 50)
        graphic.DrawString(address, font, New SolidBrush(Color.Black), X, Y + 75)
        graphic.DrawString(phone, font, New SolidBrush(Color.Black), X, Y + 100)
        graphic.DrawString(email, font, New SolidBrush(Color.Black), X, Y + 125)
        graphic.DrawString(payment, font, New SolidBrush(Color.Black), X, Y + 150)
        graphic.DrawString(reason, font, New SolidBrush(Color.Black), X, Y + 175)

    End Sub
End Class