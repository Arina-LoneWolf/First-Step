Imports QLHSBUS
Imports QLHSDTO
Imports Utility

Public Class frmLapBaoCaoCongNo
    Private bccnBus As BAOCAOCONGNOBUS
    Private Sub frmLapBaoCaoCongNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bccnBus = New BAOCAOCONGNOBUS()
        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = bccnBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaBaoCaoCongNo.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của báo cáo tồn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub btThemBaoCaoCongNo_Click(sender As Object, e As EventArgs) Handles btThemBaoCaoCongNo.Click
        Dim bccn As BAOCAOCONGNODTO
        bccn = New BAOCAOCONGNODTO()

        '1. Mapping data from GUI control
        bccn.MaBaoCaoCongNo1 = Convert.ToInt32(txtMaBaoCaoCongNo.Text)
        bccn.Thang1 = dtpThangBaoCaoCongNo.Value.ToShortDateString
        '2. Business .....
        '3. Insert to DB
        Dim result As Result
        result = bccnBus.insert(bccn)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm báo cáo thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMaBaoCaoCongNo.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = bccnBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaBaoCaoCongNo.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class