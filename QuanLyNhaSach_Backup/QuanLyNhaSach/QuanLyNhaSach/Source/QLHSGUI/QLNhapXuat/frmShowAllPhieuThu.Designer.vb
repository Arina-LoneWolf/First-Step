<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShowAllPhieuThu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbPhieuThuTien = New System.Windows.Forms.Label()
        Me.dgvShow = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.dtpkDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.chkbDate = New System.Windows.Forms.CheckBox()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCusName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(432, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 0
        '
        'lbPhieuThuTien
        '
        Me.lbPhieuThuTien.AutoSize = True
        Me.lbPhieuThuTien.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPhieuThuTien.ForeColor = System.Drawing.Color.Blue
        Me.lbPhieuThuTien.Location = New System.Drawing.Point(255, 27)
        Me.lbPhieuThuTien.Name = "lbPhieuThuTien"
        Me.lbPhieuThuTien.Size = New System.Drawing.Size(526, 35)
        Me.lbPhieuThuTien.TabIndex = 7
        Me.lbPhieuThuTien.Text = "DANH SÁCH CÁC PHIẾU THU TIỀN"
        '
        'dgvShow
        '
        Me.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShow.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colCusName, Me.colDate, Me.colPayment, Me.colReason})
        Me.dgvShow.Location = New System.Drawing.Point(12, 181)
        Me.dgvShow.Name = "dgvShow"
        Me.dgvShow.RowHeadersVisible = False
        Me.dgvShow.RowHeadersWidth = 51
        Me.dgvShow.RowTemplate.Height = 24
        Me.dgvShow.Size = New System.Drawing.Size(993, 470)
        Me.dgvShow.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Mã phiếu:"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(108, 123)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(106, 22)
        Me.tbID.TabIndex = 10
        '
        'dtpkDate
        '
        Me.dtpkDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpkDate.Location = New System.Drawing.Point(405, 123)
        Me.dtpkDate.Name = "dtpkDate"
        Me.dtpkDate.Size = New System.Drawing.Size(140, 22)
        Me.dtpkDate.TabIndex = 12
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(562, 118)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 31)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'chkbDate
        '
        Me.chkbDate.AutoSize = True
        Me.chkbDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbDate.Location = New System.Drawing.Point(287, 123)
        Me.chkbDate.Name = "chkbDate"
        Me.chkbDate.Size = New System.Drawing.Size(102, 24)
        Me.chkbDate.TabIndex = 16
        Me.chkbDate.Text = "Ngày thu:"
        Me.chkbDate.UseVisualStyleBackColor = True
        '
        'colID
        '
        Me.colID.HeaderText = "Mã phiếu thu"
        Me.colID.MinimumWidth = 6
        Me.colID.Name = "colID"
        Me.colID.Width = 95
        '
        'colCusName
        '
        Me.colCusName.HeaderText = "Tên khách hàng"
        Me.colCusName.MinimumWidth = 6
        Me.colCusName.Name = "colCusName"
        Me.colCusName.Width = 150
        '
        'colDate
        '
        Me.colDate.HeaderText = "Ngày thu"
        Me.colDate.MinimumWidth = 6
        Me.colDate.Name = "colDate"
        Me.colDate.Width = 150
        '
        'colPayment
        '
        Me.colPayment.HeaderText = "Số tiền thu"
        Me.colPayment.MinimumWidth = 6
        Me.colPayment.Name = "colPayment"
        '
        'colReason
        '
        Me.colReason.HeaderText = "Lý do"
        Me.colReason.MinimumWidth = 6
        Me.colReason.Name = "colReason"
        Me.colReason.Width = 250
        '
        'frmShowAllPhieuThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 663)
        Me.Controls.Add(Me.chkbDate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dtpkDate)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvShow)
        Me.Controls.Add(Me.lbPhieuThuTien)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmShowAllPhieuThu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmShowAllPhieuThu"
        CType(Me.dgvShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbPhieuThuTien As Label
    Friend WithEvents dgvShow As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents tbID As TextBox
    Friend WithEvents dtpkDate As DateTimePicker
    Friend WithEvents btnSearch As Button
    Friend WithEvents chkbDate As CheckBox
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colCusName As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colPayment As DataGridViewTextBoxColumn
    Friend WithEvents colReason As DataGridViewTextBoxColumn
End Class
