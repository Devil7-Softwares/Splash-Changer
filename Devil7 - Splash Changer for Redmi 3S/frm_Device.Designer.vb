<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Device
    Inherits XtraFormTemp

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Device))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_Restore = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Backup = New DevExpress.XtraEditors.SimpleButton()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.btn_Reboot = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_RebootToBootloader = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_FlashSplash = New DevExpress.XtraEditors.SimpleButton()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.btn_GetDevices = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_RebootToRecovery = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lst_Devices = New DevExpress.XtraGrid.GridControl()
        Me.GridView_Devices = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SaveIMG = New System.Windows.Forms.SaveFileDialog()
        Me.OpenIMG = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.lst_Devices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Devices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btn_Restore)
        Me.PanelControl1.Controls.Add(Me.btn_Backup)
        Me.PanelControl1.Controls.Add(Me.SeparatorControl2)
        Me.PanelControl1.Controls.Add(Me.btn_Reboot)
        Me.PanelControl1.Controls.Add(Me.btn_RebootToBootloader)
        Me.PanelControl1.Controls.Add(Me.btn_FlashSplash)
        Me.PanelControl1.Controls.Add(Me.SeparatorControl1)
        Me.PanelControl1.Controls.Add(Me.btn_GetDevices)
        Me.PanelControl1.Controls.Add(Me.btn_RebootToRecovery)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 392)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(710, 56)
        Me.PanelControl1.TabIndex = 0
        '
        'btn_Restore
        '
        Me.btn_Restore.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Restore.Location = New System.Drawing.Point(267, 2)
        Me.btn_Restore.Name = "btn_Restore"
        Me.btn_Restore.Size = New System.Drawing.Size(89, 52)
        Me.btn_Restore.TabIndex = 9
        Me.btn_Restore.Text = "Restore Splash"
        '
        'btn_Backup
        '
        Me.btn_Backup.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Backup.Location = New System.Drawing.Point(192, 2)
        Me.btn_Backup.Name = "btn_Backup"
        Me.btn_Backup.Size = New System.Drawing.Size(75, 52)
        Me.btn_Backup.TabIndex = 7
        Me.btn_Backup.Text = "Backup Splash"
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.AutoSizeMode = True
        Me.SeparatorControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.SeparatorControl2.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.SeparatorControl2.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl2.Location = New System.Drawing.Point(172, 2)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(20, 52)
        Me.SeparatorControl2.TabIndex = 8
        '
        'btn_Reboot
        '
        Me.btn_Reboot.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Reboot.Location = New System.Drawing.Point(428, 2)
        Me.btn_Reboot.Name = "btn_Reboot"
        Me.btn_Reboot.Size = New System.Drawing.Size(60, 52)
        Me.btn_Reboot.TabIndex = 5
        Me.btn_Reboot.Text = "Reboot"
        '
        'btn_RebootToBootloader
        '
        Me.btn_RebootToBootloader.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_RebootToBootloader.Location = New System.Drawing.Point(488, 2)
        Me.btn_RebootToBootloader.Name = "btn_RebootToBootloader"
        Me.btn_RebootToBootloader.Size = New System.Drawing.Size(110, 52)
        Me.btn_RebootToBootloader.TabIndex = 3
        Me.btn_RebootToBootloader.Text = "Reboot to Bootloader"
        '
        'btn_FlashSplash
        '
        Me.btn_FlashSplash.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_FlashSplash.Location = New System.Drawing.Point(97, 2)
        Me.btn_FlashSplash.Name = "btn_FlashSplash"
        Me.btn_FlashSplash.Size = New System.Drawing.Size(75, 52)
        Me.btn_FlashSplash.TabIndex = 2
        Me.btn_FlashSplash.Text = "Flash Splash"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SeparatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(77, 2)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(20, 52)
        Me.SeparatorControl1.TabIndex = 1
        '
        'btn_GetDevices
        '
        Me.btn_GetDevices.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_GetDevices.Location = New System.Drawing.Point(2, 2)
        Me.btn_GetDevices.Name = "btn_GetDevices"
        Me.btn_GetDevices.Size = New System.Drawing.Size(75, 52)
        Me.btn_GetDevices.TabIndex = 0
        Me.btn_GetDevices.Text = "Refresh"
        '
        'btn_RebootToRecovery
        '
        Me.btn_RebootToRecovery.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_RebootToRecovery.Location = New System.Drawing.Point(598, 2)
        Me.btn_RebootToRecovery.Name = "btn_RebootToRecovery"
        Me.btn_RebootToRecovery.Size = New System.Drawing.Size(110, 52)
        Me.btn_RebootToRecovery.TabIndex = 6
        Me.btn_RebootToRecovery.Text = "Reboot to Recovery"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lst_Devices)
        Me.GroupControl1.Controls.Add(Me.RichTextBox1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(710, 392)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Devices"
        '
        'lst_Devices
        '
        Me.lst_Devices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_Devices.Location = New System.Drawing.Point(2, 20)
        Me.lst_Devices.MainView = Me.GridView_Devices
        Me.lst_Devices.Name = "lst_Devices"
        Me.lst_Devices.Size = New System.Drawing.Size(706, 274)
        Me.lst_Devices.TabIndex = 1
        Me.lst_Devices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Devices})
        '
        'GridView_Devices
        '
        Me.GridView_Devices.GridControl = Me.lst_Devices
        Me.GridView_Devices.Name = "GridView_Devices"
        Me.GridView_Devices.OptionsBehavior.Editable = False
        Me.GridView_Devices.OptionsBehavior.ReadOnly = True
        Me.GridView_Devices.OptionsView.ShowGroupPanel = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Black
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Yellow
        Me.RichTextBox1.Location = New System.Drawing.Point(2, 294)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(706, 96)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'SaveIMG
        '
        Me.SaveIMG.DefaultExt = "img"
        Me.SaveIMG.FileName = "Splash.img"
        Me.SaveIMG.Filter = "IMG Files (*.img)|*.img"
        '
        'OpenIMG
        '
        Me.OpenIMG.DefaultExt = "img"
        Me.OpenIMG.FileName = "*.img"
        Me.OpenIMG.Filter = "IMG Files (*.img)|*.img"
        Me.OpenIMG.FilterIndex = 0
        '
        'frm_Device
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 448)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(720, 480)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(720, 480)
        Me.Name = "frm_Device"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Android Device Functions"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.lst_Devices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Devices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lst_Devices As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Devices As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents btn_GetDevices As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_FlashSplash As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Reboot As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_RebootToBootloader As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_RebootToRecovery As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Backup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveIMG As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btn_Restore As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents OpenIMG As System.Windows.Forms.OpenFileDialog
End Class
