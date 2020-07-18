<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapBaoCaoCongNo
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
        Me.btThemBaoCaoCongNo = New System.Windows.Forms.Button()
        Me.dtpThangBaoCaoCongNo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaBaoCaoCongNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(467, 147)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btThemBaoCaoCongNo)
        Me.TabPage1.Controls.Add(Me.dtpThangBaoCaoCongNo)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtMaBaoCaoCongNo)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(459, 118)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Báo Cáo Công Nợ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btThemBaoCaoCongNo
        '
        Me.btThemBaoCaoCongNo.Location = New System.Drawing.Point(187, 82)
        Me.btThemBaoCaoCongNo.Margin = New System.Windows.Forms.Padding(4)
        Me.btThemBaoCaoCongNo.Name = "btThemBaoCaoCongNo"
        Me.btThemBaoCaoCongNo.Size = New System.Drawing.Size(100, 28)
        Me.btThemBaoCaoCongNo.TabIndex = 1
        Me.btThemBaoCaoCongNo.Text = "Thêm"
        Me.btThemBaoCaoCongNo.UseVisualStyleBackColor = True
        '
        'dtpThangBaoCaoCongNo
        '
        Me.dtpThangBaoCaoCongNo.CustomFormat = "MM/yyyy"
        Me.dtpThangBaoCaoCongNo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThangBaoCaoCongNo.Location = New System.Drawing.Point(187, 39)
        Me.dtpThangBaoCaoCongNo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpThangBaoCaoCongNo.Name = "dtpThangBaoCaoCongNo"
        Me.dtpThangBaoCaoCongNo.Size = New System.Drawing.Size(267, 22)
        Me.dtpThangBaoCaoCongNo.TabIndex = 18
        Me.dtpThangBaoCaoCongNo.Value = New Date(2018, 5, 21, 13, 21, 46, 0)
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
        'txtMaBaoCaoCongNo
        '
        Me.txtMaBaoCaoCongNo.Enabled = False
        Me.txtMaBaoCaoCongNo.Location = New System.Drawing.Point(187, 7)
        Me.txtMaBaoCaoCongNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaBaoCaoCongNo.Name = "txtMaBaoCaoCongNo"
        Me.txtMaBaoCaoCongNo.ReadOnly = True
        Me.txtMaBaoCaoCongNo.Size = New System.Drawing.Size(267, 22)
        Me.txtMaBaoCaoCongNo.TabIndex = 17
        Me.txtMaBaoCaoCongNo.WordWrap = False
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
        'frmLapBaoCaoCongNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 165)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmLapBaoCaoCongNo"
        Me.Text = "Lập Báo Cáo Công Nợ"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btThemBaoCaoCongNo As Button
    Friend WithEvents dtpThangBaoCaoCongNo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaBaoCaoCongNo As TextBox
    Friend WithEvents Label1 As Label
End Class
