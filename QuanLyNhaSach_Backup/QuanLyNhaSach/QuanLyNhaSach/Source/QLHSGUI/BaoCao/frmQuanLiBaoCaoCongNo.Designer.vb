<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLiBaoCaoCongNo
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btXoaBaoCaoCongNo = New System.Windows.Forms.Button()
        Me.txtMaBaoCaoCongNo = New System.Windows.Forms.TextBox()
        Me.btCapNhatBaoCaoCongNo = New System.Windows.Forms.Button()
        Me.dtpThangBaoCaoCongNo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvListBaoCaoCongNo = New System.Windows.Forms.DataGridView()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.txtMaBaoCaoTK = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpThangBaoCaoCongNoTimKiem = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvListBaoCaoCongNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(13, 308)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(347, 155)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btXoaBaoCaoCongNo)
        Me.TabPage1.Controls.Add(Me.txtMaBaoCaoCongNo)
        Me.TabPage1.Controls.Add(Me.btCapNhatBaoCaoCongNo)
        Me.TabPage1.Controls.Add(Me.dtpThangBaoCaoCongNo)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(339, 126)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Báo Cáo Công Nợ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btXoaBaoCaoCongNo
        '
        Me.btXoaBaoCaoCongNo.Location = New System.Drawing.Point(172, 87)
        Me.btXoaBaoCaoCongNo.Margin = New System.Windows.Forms.Padding(4)
        Me.btXoaBaoCaoCongNo.Name = "btXoaBaoCaoCongNo"
        Me.btXoaBaoCaoCongNo.Size = New System.Drawing.Size(100, 28)
        Me.btXoaBaoCaoCongNo.TabIndex = 19
        Me.btXoaBaoCaoCongNo.Text = "Xóa"
        Me.btXoaBaoCaoCongNo.UseVisualStyleBackColor = True
        '
        'txtMaBaoCaoCongNo
        '
        Me.txtMaBaoCaoCongNo.Enabled = False
        Me.txtMaBaoCaoCongNo.Location = New System.Drawing.Point(187, 7)
        Me.txtMaBaoCaoCongNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaBaoCaoCongNo.Name = "txtMaBaoCaoCongNo"
        Me.txtMaBaoCaoCongNo.ReadOnly = True
        Me.txtMaBaoCaoCongNo.Size = New System.Drawing.Size(140, 22)
        Me.txtMaBaoCaoCongNo.TabIndex = 8
        '
        'btCapNhatBaoCaoCongNo
        '
        Me.btCapNhatBaoCaoCongNo.Location = New System.Drawing.Point(64, 87)
        Me.btCapNhatBaoCaoCongNo.Margin = New System.Windows.Forms.Padding(4)
        Me.btCapNhatBaoCaoCongNo.Name = "btCapNhatBaoCaoCongNo"
        Me.btCapNhatBaoCaoCongNo.Size = New System.Drawing.Size(100, 28)
        Me.btCapNhatBaoCaoCongNo.TabIndex = 1
        Me.btCapNhatBaoCaoCongNo.Text = "Cập nhật"
        Me.btCapNhatBaoCaoCongNo.UseVisualStyleBackColor = True
        '
        'dtpThangBaoCaoCongNo
        '
        Me.dtpThangBaoCaoCongNo.CustomFormat = "MM/yyyy"
        Me.dtpThangBaoCaoCongNo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThangBaoCaoCongNo.Location = New System.Drawing.Point(187, 39)
        Me.dtpThangBaoCaoCongNo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpThangBaoCaoCongNo.Name = "dtpThangBaoCaoCongNo"
        Me.dtpThangBaoCaoCongNo.Size = New System.Drawing.Size(140, 22)
        Me.dtpThangBaoCaoCongNo.TabIndex = 18
        Me.dtpThangBaoCaoCongNo.Value = New Date(2018, 5, 19, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tháng Báo Cáo Công Nợ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Báo Cáo Công Nợ"
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage4)
        Me.TabControl3.Location = New System.Drawing.Point(13, 122)
        Me.TabControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(347, 178)
        Me.TabControl3.TabIndex = 9
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvListBaoCaoCongNo)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Size = New System.Drawing.Size(339, 149)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Danh Sách Báo Cáo Công Nợ"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvListBaoCaoCongNo
        '
        Me.dgvListBaoCaoCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListBaoCaoCongNo.Location = New System.Drawing.Point(8, 7)
        Me.dgvListBaoCaoCongNo.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListBaoCaoCongNo.Name = "dgvListBaoCaoCongNo"
        Me.dgvListBaoCaoCongNo.Size = New System.Drawing.Size(320, 138)
        Me.dgvListBaoCaoCongNo.TabIndex = 0
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(13, 13)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(347, 101)
        Me.TabControl2.TabIndex = 8
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnTimKiem)
        Me.TabPage2.Controls.Add(Me.txtMaBaoCaoTK)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.dtpThangBaoCaoCongNoTimKiem)
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
        Me.Label4.Size = New System.Drawing.Size(144, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Mã Báo Cáo Công Nợ"
        '
        'dtpThangBaoCaoCongNoTimKiem
        '
        Me.dtpThangBaoCaoCongNoTimKiem.CustomFormat = "MM/yyyy"
        Me.dtpThangBaoCaoCongNoTimKiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThangBaoCaoCongNoTimKiem.Location = New System.Drawing.Point(189, 42)
        Me.dtpThangBaoCaoCongNoTimKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpThangBaoCaoCongNoTimKiem.Name = "dtpThangBaoCaoCongNoTimKiem"
        Me.dtpThangBaoCaoCongNoTimKiem.Size = New System.Drawing.Size(137, 22)
        Me.dtpThangBaoCaoCongNoTimKiem.TabIndex = 20
        Me.dtpThangBaoCaoCongNoTimKiem.Value = New Date(2018, 5, 19, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Tháng Báo Cáo Công Nợ"
        '
        'frmQuanLiBaoCaoCongNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 465)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "frmQuanLiBaoCaoCongNo"
        Me.Text = "Quản Lí Báo Cáo Công Nợ"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvListBaoCaoCongNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btXoaBaoCaoCongNo As Button
    Friend WithEvents txtMaBaoCaoCongNo As TextBox
    Friend WithEvents btCapNhatBaoCaoCongNo As Button
    Friend WithEvents dtpThangBaoCaoCongNo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgvListBaoCaoCongNo As DataGridView
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dtpThangBaoCaoCongNoTimKiem As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents txtMaBaoCaoTK As TextBox
    Friend WithEvents Label4 As Label
End Class
