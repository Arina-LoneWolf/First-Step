<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapBaoCaoTon
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
        Me.btThemBaoCaoTon = New System.Windows.Forms.Button()
        Me.dtbThangBaoCaoTon = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaBaoCaoTon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(13, 7)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(411, 150)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btThemBaoCaoTon)
        Me.TabPage1.Controls.Add(Me.dtbThangBaoCaoTon)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtMaBaoCaoTon)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(403, 121)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Báo Cáo Tồn"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btThemBaoCaoTon
        '
        Me.btThemBaoCaoTon.Location = New System.Drawing.Point(151, 82)
        Me.btThemBaoCaoTon.Margin = New System.Windows.Forms.Padding(4)
        Me.btThemBaoCaoTon.Name = "btThemBaoCaoTon"
        Me.btThemBaoCaoTon.Size = New System.Drawing.Size(100, 28)
        Me.btThemBaoCaoTon.TabIndex = 1
        Me.btThemBaoCaoTon.Text = "Thêm"
        Me.btThemBaoCaoTon.UseVisualStyleBackColor = True
        '
        'dtbThangBaoCaoTon
        '
        Me.dtbThangBaoCaoTon.CustomFormat = "MM/yyyy"
        Me.dtbThangBaoCaoTon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtbThangBaoCaoTon.Location = New System.Drawing.Point(151, 39)
        Me.dtbThangBaoCaoTon.Margin = New System.Windows.Forms.Padding(4)
        Me.dtbThangBaoCaoTon.Name = "dtbThangBaoCaoTon"
        Me.dtbThangBaoCaoTon.Size = New System.Drawing.Size(240, 22)
        Me.dtbThangBaoCaoTon.TabIndex = 18
        Me.dtbThangBaoCaoTon.Value = New Date(2018, 5, 21, 13, 17, 13, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tháng Báo Cáo Tồn"
        '
        'txtMaBaoCaoTon
        '
        Me.txtMaBaoCaoTon.Enabled = False
        Me.txtMaBaoCaoTon.Location = New System.Drawing.Point(151, 7)
        Me.txtMaBaoCaoTon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaBaoCaoTon.Name = "txtMaBaoCaoTon"
        Me.txtMaBaoCaoTon.ReadOnly = True
        Me.txtMaBaoCaoTon.Size = New System.Drawing.Size(240, 22)
        Me.txtMaBaoCaoTon.TabIndex = 17
        Me.txtMaBaoCaoTon.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Báo Cáo Tồn"
        '
        'frmLapBaoCaoTon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 466)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmLapBaoCaoTon"
        Me.Text = "Lập Báo Cáo Tồn"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btThemBaoCaoTon As Button
    Friend WithEvents dtbThangBaoCaoTon As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaBaoCaoTon As TextBox
    Friend WithEvents Label1 As Label
End Class
