<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainform
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grdExcel = New System.Windows.Forms.DataGridView()
        Me.btnExcelAc = New System.Windows.Forms.Button()
        Me.btnAktar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        CType(Me.grdExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnAktar)
        Me.TabPage1.Controls.Add(Me.btnExcelAc)
        Me.TabPage1.Controls.Add(Me.grdExcel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(872, 434)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Excel işlemleri"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grdExcel
        '
        Me.grdExcel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdExcel.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grdExcel.Location = New System.Drawing.Point(14, 37)
        Me.grdExcel.Margin = New System.Windows.Forms.Padding(2)
        Me.grdExcel.MultiSelect = False
        Me.grdExcel.Name = "grdExcel"
        Me.grdExcel.RowTemplate.Height = 24
        Me.grdExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdExcel.Size = New System.Drawing.Size(838, 379)
        Me.grdExcel.TabIndex = 0
        '
        'btnExcelAc
        '
        Me.btnExcelAc.Location = New System.Drawing.Point(14, 5)
        Me.btnExcelAc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExcelAc.Name = "btnExcelAc"
        Me.btnExcelAc.Size = New System.Drawing.Size(79, 28)
        Me.btnExcelAc.TabIndex = 1
        Me.btnExcelAc.Text = "Excel Aç"
        Me.btnExcelAc.UseVisualStyleBackColor = True
        '
        'btnAktar
        '
        Me.btnAktar.Location = New System.Drawing.Point(98, 5)
        Me.btnAktar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAktar.Name = "btnAktar"
        Me.btnAktar.Size = New System.Drawing.Size(79, 28)
        Me.btnAktar.TabIndex = 2
        Me.btnAktar.Text = "Aktar"
        Me.btnAktar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(880, 460)
        Me.TabControl1.TabIndex = 0
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 460)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "mainform"
        Me.Text = "Entegrator v1.00"
        Me.TabPage1.ResumeLayout(False)
        CType(Me.grdExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnAktar As Button
    Friend WithEvents btnExcelAc As Button
    Friend WithEvents grdExcel As DataGridView
    Friend WithEvents TabControl1 As TabControl
End Class
