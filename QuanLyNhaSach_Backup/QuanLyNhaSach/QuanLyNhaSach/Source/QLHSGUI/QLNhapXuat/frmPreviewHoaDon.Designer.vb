<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPreviewHoaDon
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
        Me.dgvListOrdered = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.receiptID = New System.Windows.Forms.Label()
        Me.customerName = New System.Windows.Forms.Label()
        Me.dateTime = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.Label()
        Me.phoneNumber = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        CType(Me.dgvListOrdered, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(335, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HÓA ĐƠN"
        '
        'dgvListOrdered
        '
        Me.dgvListOrdered.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListOrdered.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListOrdered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListOrdered.Location = New System.Drawing.Point(12, 149)
        Me.dgvListOrdered.Name = "dgvListOrdered"
        Me.dgvListOrdered.ReadOnly = True
        Me.dgvListOrdered.Size = New System.Drawing.Size(776, 289)
        Me.dgvListOrdered.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã hóa đơn:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(628, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Họ tên:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ngày mua:"
        '
        'receiptID
        '
        Me.receiptID.AutoSize = True
        Me.receiptID.Location = New System.Drawing.Point(86, 59)
        Me.receiptID.Name = "receiptID"
        Me.receiptID.Size = New System.Drawing.Size(39, 13)
        Me.receiptID.TabIndex = 5
        Me.receiptID.Text = "Label5"
        '
        'customerName
        '
        Me.customerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.customerName.AutoSize = True
        Me.customerName.Location = New System.Drawing.Point(676, 59)
        Me.customerName.Name = "customerName"
        Me.customerName.Size = New System.Drawing.Size(39, 13)
        Me.customerName.TabIndex = 6
        Me.customerName.Text = "Label6"
        '
        'dateTime
        '
        Me.dateTime.AutoSize = True
        Me.dateTime.Location = New System.Drawing.Point(86, 88)
        Me.dateTime.Name = "dateTime"
        Me.dateTime.Size = New System.Drawing.Size(39, 13)
        Me.dateTime.TabIndex = 7
        Me.dateTime.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(628, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Địa chỉ:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(628, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "SĐT:"
        '
        'address
        '
        Me.address.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.address.AutoSize = True
        Me.address.Location = New System.Drawing.Point(677, 88)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(45, 13)
        Me.address.TabIndex = 10
        Me.address.Text = "Label10"
        '
        'phoneNumber
        '
        Me.phoneNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.phoneNumber.AutoSize = True
        Me.phoneNumber.Location = New System.Drawing.Point(676, 118)
        Me.phoneNumber.Name = "phoneNumber"
        Me.phoneNumber.Size = New System.Drawing.Size(45, 13)
        Me.phoneNumber.TabIndex = 11
        Me.phoneNumber.Text = "Label11"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 118)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Tổng trị giá:"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Location = New System.Drawing.Point(86, 118)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(45, 13)
        Me.total.TabIndex = 13
        Me.total.Text = "Label13"
        '
        'frmPreviewHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.phoneNumber)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dateTime)
        Me.Controls.Add(Me.customerName)
        Me.Controls.Add(Me.receiptID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvListOrdered)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPreviewHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPreviewHoaDon"
        CType(Me.dgvListOrdered, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvListOrdered As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents receiptID As Label
    Friend WithEvents customerName As Label
    Friend WithEvents dateTime As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents address As Label
    Friend WithEvents phoneNumber As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents total As Label
End Class
