<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLiBaoCaoTon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.txtMaBaoCaoTK = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btXoaBaoCaoTon = New System.Windows.Forms.Button()
        Me.txtMaBaoCaoTon = New System.Windows.Forms.TextBox()
        Me.btCapNhatBaoCaoTon = New System.Windows.Forms.Button()
        Me.dtpThangBaoCaoTon = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dtpThangBaoCaoTonTimKiem = New System.Windows.Forms.DateTimePicker()
        Me.dgvListBaoCaoTon = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvListBaoCaoTon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(253, 10)
        Me.btnTimKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(75, 29)
        Me.btnTimKiem.TabIndex = 23
        Me.btnTimKiem.Text = "Tìm Kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'txtMaBaoCaoTK
        '
        Me.txtMaBaoCaoTK.Location = New System.Drawing.Point(189, 13)
        Me.txtMaBaoCaoTK.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaBaoCaoTK.Name = "txtMaBaoCaoTK"
        Me.txtMaBaoCaoTK.Size = New System.Drawing.Size(54, 22)
        Me.txtMaBaoCaoTK.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 13)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Mã Báo Cáo Tồn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Tháng Báo Cáo Tồn"
        '
        'btXoaBaoCaoTon
        '
        Me.btXoaBaoCaoTon.Location = New System.Drawing.Point(172, 87)
        Me.btXoaBaoCaoTon.Margin = New System.Windows.Forms.Padding(4)
        Me.btXoaBaoCaoTon.Name = "btXoaBaoCaoTon"
        Me.btXoaBaoCaoTon.Size = New System.Drawing.Size(100, 28)
        Me.btXoaBaoCaoTon.TabIndex = 19
        Me.btXoaBaoCaoTon.Text = "Xóa"
        Me.btXoaBaoCaoTon.UseVisualStyleBackColor = True
        '
        'txtMaBaoCaoTon
        '
        Me.txtMaBaoCaoTon.Enabled = False
        Me.txtMaBaoCaoTon.Location = New System.Drawing.Point(187, 7)
        Me.txtMaBaoCaoTon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaBaoCaoTon.Name = "txtMaBaoCaoTon"
        Me.txtMaBaoCaoTon.ReadOnly = True
        Me.txtMaBaoCaoTon.Size = New System.Drawing.Size(140, 22)
        Me.txtMaBaoCaoTon.TabIndex = 8
        '
        'btCapNhatBaoCaoTon
        '
        Me.btCapNhatBaoCaoTon.Location = New System.Drawing.Point(64, 87)
        Me.btCapNhatBaoCaoTon.Margin = New System.Windows.Forms.Padding(4)
        Me.btCapNhatBaoCaoTon.Name = "btCapNhatBaoCaoTon"
        Me.btCapNhatBaoCaoTon.Size = New System.Drawing.Size(100, 28)
        Me.btCapNhatBaoCaoTon.TabIndex = 1
        Me.btCapNhatBaoCaoTon.Text = "Cập nhật"
        Me.btCapNhatBaoCaoTon.UseVisualStyleBackColor = True
        '
        'dtpThangBaoCaoTon
        '
        Me.dtpThangBaoCaoTon.CustomFormat = "MM/yyyy"
        Me.dtpThangBaoCaoTon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThangBaoCaoTon.Location = New System.Drawing.Point(187, 39)
        Me.dtpThangBaoCaoTon.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpThangBaoCaoTon.Name = "dtpThangBaoCaoTon"
        Me.dtpThangBaoCaoTon.Size = New System.Drawing.Size(140, 22)
        Me.dtpThangBaoCaoTon.TabIndex = 18
        Me.dtpThangBaoCaoTon.Value = New Date(2018, 5, 19, 0, 0, 0, 0)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnTimKiem)
        Me.TabPage2.Controls.Add(Me.txtMaBaoCaoTK)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.dtpThangBaoCaoTonTimKiem)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(339, 72)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Tìm Kiếm"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dtpThangBaoCaoTonTimKiem
        '
        Me.dtpThangBaoCaoTonTimKiem.CustomFormat = "MM/yyyy"
        Me.dtpThangBaoCaoTonTimKiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThangBaoCaoTonTimKiem.Location = New System.Drawing.Point(189, 42)
        Me.dtpThangBaoCaoTonTimKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpThangBaoCaoTonTimKiem.Name = "dtpThangBaoCaoTonTimKiem"
        Me.dtpThangBaoCaoTonTimKiem.Size = New System.Drawing.Size(137, 22)
        Me.dtpThangBaoCaoTonTimKiem.TabIndex = 20
        Me.dtpThangBaoCaoTonTimKiem.Value = New Date(2018, 5, 19, 0, 0, 0, 0)
        '
        'dgvListBaoCaoTon
        '
        Me.dgvListBaoCaoTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListBaoCaoTon.Location = New System.Drawing.Point(8, 7)
        Me.dgvListBaoCaoTon.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListBaoCaoTon.Name = "dgvListBaoCaoTon"
        Me.dgvListBaoCaoTon.Size = New System.Drawing.Size(320, 138)
        Me.dgvListBaoCaoTon.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tháng Báo Cáo Tồn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Báo Cáo Tồn"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btXoaBaoCaoTon)
        Me.TabPage1.Controls.Add(Me.txtMaBaoCaoTon)
        Me.TabPage1.Controls.Add(Me.btCapNhatBaoCaoTon)
        Me.TabPage1.Controls.Add(Me.dtpThangBaoCaoTon)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(339, 126)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Báo Cáo Tồn"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage4)
        Me.TabControl3.Location = New System.Drawing.Point(13, 122)
        Me.TabControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(347, 178)
        Me.TabControl3.TabIndex = 12
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvListBaoCaoTon)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Size = New System.Drawing.Size(339, 149)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Danh Sách Báo Cáo Tồn"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(13, 13)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(347, 101)
        Me.TabControl2.TabIndex = 11
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(13, 308)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(347, 155)
        Me.TabControl1.TabIndex = 13
        '
        'frmQuanLiBaoCaoTon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 471)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmQuanLiBaoCaoTon"
        Me.Text = "Quản Lí Báo Cáo Tồn"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvListBaoCaoTon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTimKiem As Button
    Friend WithEvents txtMaBaoCaoTK As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btXoaBaoCaoTon As Button
    Friend WithEvents txtMaBaoCaoTon As TextBox
    Friend WithEvents btCapNhatBaoCaoTon As Button
    Friend WithEvents dtpThangBaoCaoTon As DateTimePicker
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dtpThangBaoCaoTonTimKiem As DateTimePicker
    Friend WithEvents dgvListBaoCaoTon As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabControl1 As TabControl
End Class
