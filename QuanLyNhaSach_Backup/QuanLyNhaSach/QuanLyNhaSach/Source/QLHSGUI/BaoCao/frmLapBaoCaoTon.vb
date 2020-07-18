Imports QLHSBUS
Imports QLHSDTO
Imports Utility

Public Class frmLapBaoCaoTon
    Private bctBus As BAOCAOTONBUS
    Private Sub frmLapBaoCaoTon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bctBus = New BAOCAOTONBUS()
        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = bctBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaBaoCaoTon.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của báo cáo tồn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btThemBaoCaoTon_Click(sender As Object, e As EventArgs) Handles btThemBaoCaoTon.Click
        Dim bct As BAOCAOTONDTO
        bct = New BAOCAOTONDTO()

        '1. Mapping data from GUI control
        bct.MaBaoCaoTon1 = Convert.ToInt32(txtMaBaoCaoTon.Text)
        bct.Thang1 = dtbThangBaoCaoTon.Value.ToShortDateString
        '2. Business .....
        '3. Insert to DB
        Dim result As Result
        result = bctBus.insert(bct)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm báo cáo tồn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMaBaoCaoTon.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = bctBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaBaoCaoTon.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của báo cáo tồn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm báo cáo tồn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class