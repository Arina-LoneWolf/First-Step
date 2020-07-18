Imports System.Threading

Public Class frmPreviewHoaDon
    Private thread As Thread

    Public Sub New(receiptID As String, customerName As String, address As String, phoneNumber As String, dateTime As String, total As String, listDataSource As Dictionary(Of String, String()))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.receiptID.Text = receiptID
        Me.customerName.Text = customerName
        Me.address.Text = address
        Me.phoneNumber.Text = phoneNumber
        Me.dateTime.Text = dateTime.Trim()
        Me.total.Text = total

        thread = New Thread(Sub() loadList(listDataSource))
        thread.Start()

        'loadList(listDataSource)
    End Sub

    Private Sub loadList(list As Dictionary(Of String, String()))
        If (dgvListOrdered.InvokeRequired) Then
            dgvListOrdered.Invoke(Sub() loadList(list))
            Return
        End If

        dgvListOrdered.Columns.Clear()

        dgvListOrdered.AutoGenerateColumns = False
        dgvListOrdered.AllowUserToAddRows = False

        dgvListOrdered.Columns.Add("MaSach", "Mã Sách")
        dgvListOrdered.Columns.Add("TenSach", "Tên Sách")
        dgvListOrdered.Columns.Add("TenLoaiSach", "Thể loại")
        dgvListOrdered.Columns.Add("TacGia", "Tác Giả")
        dgvListOrdered.Columns.Add("SL", "Số Lượng Đặt")
        dgvListOrdered.Columns.Add("DG", "Đơn Giá")

        For Each order In list.Values
            dgvListOrdered.Rows.Add(order)
        Next
    End Sub
End Class