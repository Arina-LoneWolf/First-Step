Imports QLHSBUS
Imports Utility
Imports QLHSDTO
Public Class frmTheLoai
    Private tlbus As LOAISACHBUS
    Private Sub frmTheLoai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tlbus = New LOAISACHBUS()
        Dim nextID As Integer
        Dim result As Result
        result = tlbus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbxmatheloai.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim ls As THELOAIDTO
        ls = New THELOAIDTO()

        '1. Mapping data from GUI control
        ls.Imaloaisach = Convert.ToInt32(tbxmatheloai.Text)
        ls.Strtenloaisach = tbxtentheloai.Text

        '2. Business .....
        If (tlbus.isValidName(ls) = False) Then
            MessageBox.Show("Tên loại sách không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxtentheloai.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = tlbus.insert(ls)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbxtentheloai.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = tlbus.getNextID(nextID)
            If (result.FlagResult = True) Then
                tbxmatheloai.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("Thêm loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class