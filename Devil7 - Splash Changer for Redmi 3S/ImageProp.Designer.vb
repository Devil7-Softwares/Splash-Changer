<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageProp
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Resolution = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Size = New DevExpress.XtraEditors.LabelControl()
        Me.btn_Browse = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Reset = New DevExpress.XtraEditors.SimpleButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Resolution, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Size, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Browse, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Reset, 4, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.73563!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.26437!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(386, 87)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 18)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Resolution"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl2.Location = New System.Drawing.Point(3, 27)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 57)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Size"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl3.Location = New System.Drawing.Point(65, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(2, 18)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = ":"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl4.Location = New System.Drawing.Point(65, 27)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(2, 57)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = ":"
        '
        'lbl_Resolution
        '
        Me.lbl_Resolution.Appearance.Options.UseTextOptions = True
        Me.lbl_Resolution.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_Resolution.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Resolution.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Resolution.Location = New System.Drawing.Point(73, 3)
        Me.lbl_Resolution.Name = "lbl_Resolution"
        Me.lbl_Resolution.Size = New System.Drawing.Size(190, 18)
        Me.lbl_Resolution.TabIndex = 1
        Me.lbl_Resolution.Text = "-"
        '
        'lbl_Size
        '
        Me.lbl_Size.Appearance.Options.UseTextOptions = True
        Me.lbl_Size.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_Size.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Size.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Size.Location = New System.Drawing.Point(73, 27)
        Me.lbl_Size.Name = "lbl_Size"
        Me.lbl_Size.Size = New System.Drawing.Size(190, 57)
        Me.lbl_Size.TabIndex = 1
        Me.lbl_Size.Text = "-"
        '
        'btn_Browse
        '
        Me.btn_Browse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Browse.Location = New System.Drawing.Point(269, 3)
        Me.btn_Browse.Name = "btn_Browse"
        Me.TableLayoutPanel1.SetRowSpan(Me.btn_Browse, 2)
        Me.btn_Browse.Size = New System.Drawing.Size(54, 81)
        Me.btn_Browse.TabIndex = 2
        Me.btn_Browse.Text = "Browse"
        '
        'btn_Reset
        '
        Me.btn_Reset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Reset.Location = New System.Drawing.Point(329, 3)
        Me.btn_Reset.Name = "btn_Reset"
        Me.TableLayoutPanel1.SetRowSpan(Me.btn_Reset, 2)
        Me.btn_Reset.Size = New System.Drawing.Size(54, 81)
        Me.btn_Reset.TabIndex = 3
        Me.btn_Reset.Text = "Reset"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "All Supported Image Files|*.png;*.bmp;*.jpg;*.jpeg;*.gif"
        '
        'ImageProp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ImageProp"
        Me.Size = New System.Drawing.Size(386, 87)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Resolution As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Size As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_Browse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Reset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
