<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Open = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SplashImage = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_FlashableZIP = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Device = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_About = New DevExpress.XtraBars.BarButtonItem()
        Me.cmb_Device = New DevExpress.XtraBars.BarEditItem()
        Me.cmb_Device_repo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RibbonPage_Home = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_Project = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Make = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Device = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_Skin = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Misc = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PictureBox_Startup = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.ImageProp_Startup = New D7SCH_LAND.ImageProp()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.PictureBox_Fastboot = New System.Windows.Forms.PictureBox()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.ImageProp_Fastboot = New D7SCH_LAND.ImageProp()
        Me.OpenData = New System.Windows.Forms.OpenFileDialog()
        Me.SaveData = New System.Windows.Forms.SaveFileDialog()
        Me.SaveIMG = New System.Windows.Forms.SaveFileDialog()
        Me.SaveZIP = New System.Windows.Forms.SaveFileDialog()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Device_repo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PictureBox_Startup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PictureBox_Fastboot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.btn_New, Me.btn_Open, Me.btn_Save, Me.btn_SplashImage, Me.btn_FlashableZIP, Me.btn_Device, Me.btn_About, Me.cmb_Device})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 12
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage_Home, Me.RibbonPage1})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmb_Device_repo})
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(703, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem1.Id = 1
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'btn_New
        '
        Me.btn_New.Caption = "New"
        Me.btn_New.Description = "Reset and Start New Project"
        Me.btn_New.Hint = "Reset and Start New Project"
        Me.btn_New.Id = 2
        Me.btn_New.ImageOptions.Image = Global.D7SCH_LAND.My.Resources.Resources.Document_New
        Me.btn_New.ImageOptions.LargeImage = Global.D7SCH_LAND.My.Resources.Resources.Document_New
        Me.btn_New.Name = "btn_New"
        '
        'btn_Open
        '
        Me.btn_Open.Caption = "Open"
        Me.btn_Open.Description = "Open Saved Project File"
        Me.btn_Open.Hint = "Open Saved Project File"
        Me.btn_Open.Id = 3
        Me.btn_Open.ImageOptions.Image = Global.D7SCH_LAND.My.Resources.Resources.Document_Open
        Me.btn_Open.ImageOptions.LargeImage = Global.D7SCH_LAND.My.Resources.Resources.Document_Open
        Me.btn_Open.Name = "btn_Open"
        '
        'btn_Save
        '
        Me.btn_Save.Caption = "Save"
        Me.btn_Save.Description = "Save Current Project to File"
        Me.btn_Save.Hint = "Save Current Project to File"
        Me.btn_Save.Id = 4
        Me.btn_Save.ImageOptions.Image = Global.D7SCH_LAND.My.Resources.Resources.Document_Save
        Me.btn_Save.ImageOptions.LargeImage = Global.D7SCH_LAND.My.Resources.Resources.Document_Save
        Me.btn_Save.Name = "btn_Save"
        '
        'btn_SplashImage
        '
        Me.btn_SplashImage.Caption = "IMG File"
        Me.btn_SplashImage.Description = "Create Splash from selected Images and save it as ""img"" file for flashing."
        Me.btn_SplashImage.Hint = "Create Splash from selected Images and save it as ""img"" file for flashing."
        Me.btn_SplashImage.Id = 5
        Me.btn_SplashImage.ImageOptions.Image = Global.D7SCH_LAND.My.Resources.Resources.File_Format_Img
        Me.btn_SplashImage.ImageOptions.LargeImage = Global.D7SCH_LAND.My.Resources.Resources.File_Format_Img
        Me.btn_SplashImage.Name = "btn_SplashImage"
        '
        'btn_FlashableZIP
        '
        Me.btn_FlashableZIP.Caption = "Flashable ZIP"
        Me.btn_FlashableZIP.Description = "Create Splash as ""Flashable ZIP"" for flashing from custom recovery like TWRP."
        Me.btn_FlashableZIP.Hint = "Create Splash as ""Flashable ZIP"" for flashing from custom recovery like TWRP."
        Me.btn_FlashableZIP.Id = 6
        Me.btn_FlashableZIP.ImageOptions.Image = Global.D7SCH_LAND.My.Resources.Resources.File_Format_ZIP
        Me.btn_FlashableZIP.ImageOptions.LargeImage = Global.D7SCH_LAND.My.Resources.Resources.File_Format_ZIP
        Me.btn_FlashableZIP.Name = "btn_FlashableZIP"
        '
        'btn_Device
        '
        Me.btn_Device.Caption = "Android Device Tools"
        Me.btn_Device.Description = "Flash Splash to Device / Backup or Restore Splash"
        Me.btn_Device.Hint = "Flash Splash to Device / Backup or Restore Splash"
        Me.btn_Device.Id = 7
        Me.btn_Device.ImageOptions.Image = Global.D7SCH_LAND.My.Resources.Resources.Android_Device
        Me.btn_Device.ImageOptions.LargeImage = Global.D7SCH_LAND.My.Resources.Resources.Android_Device
        Me.btn_Device.Name = "btn_Device"
        '
        'btn_About
        '
        Me.btn_About.Caption = "About"
        Me.btn_About.Id = 10
        Me.btn_About.ImageOptions.Image = Global.D7SCH_LAND.My.Resources.Resources.about
        Me.btn_About.ImageOptions.LargeImage = Global.D7SCH_LAND.My.Resources.Resources.about
        Me.btn_About.Name = "btn_About"
        '
        'cmb_Device
        '
        Me.cmb_Device.Caption = "Device"
        Me.cmb_Device.Edit = Me.cmb_Device_repo
        Me.cmb_Device.EditWidth = 200
        Me.cmb_Device.Id = 11
        Me.cmb_Device.Name = "cmb_Device"
        Me.cmb_Device.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'cmb_Device_repo
        '
        Me.cmb_Device_repo.AutoHeight = False
        Me.cmb_Device_repo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Device_repo.Items.AddRange(New Object() {"Redmi 2/2S/Prime 3/3S/3X/Prime 4/4A/4X"})
        Me.cmb_Device_repo.Name = "cmb_Device_repo"
        Me.cmb_Device_repo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'RibbonPage_Home
        '
        Me.RibbonPage_Home.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_Project, Me.rpg_Make, Me.rpg_Device})
        Me.RibbonPage_Home.Name = "RibbonPage_Home"
        Me.RibbonPage_Home.Text = "Home"
        '
        'rpg_Project
        '
        Me.rpg_Project.ItemLinks.Add(Me.btn_New)
        Me.rpg_Project.ItemLinks.Add(Me.btn_Open)
        Me.rpg_Project.ItemLinks.Add(Me.btn_Save)
        Me.rpg_Project.Name = "rpg_Project"
        Me.rpg_Project.Text = "Project"
        '
        'rpg_Make
        '
        Me.rpg_Make.ItemLinks.Add(Me.btn_SplashImage)
        Me.rpg_Make.ItemLinks.Add(Me.btn_FlashableZIP)
        Me.rpg_Make.Name = "rpg_Make"
        Me.rpg_Make.Text = "Make"
        '
        'rpg_Device
        '
        Me.rpg_Device.ItemLinks.Add(Me.btn_Device)
        Me.rpg_Device.ItemLinks.Add(Me.cmb_Device)
        Me.rpg_Device.Name = "rpg_Device"
        Me.rpg_Device.Text = "Device"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_Skin, Me.rpg_Misc})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Other"
        '
        'rpg_Skin
        '
        Me.rpg_Skin.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.rpg_Skin.Name = "rpg_Skin"
        Me.rpg_Skin.Text = "Skin"
        '
        'rpg_Misc
        '
        Me.rpg_Misc.ItemLinks.Add(Me.btn_About)
        Me.rpg_Misc.Name = "rpg_Misc"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 535)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(703, 31)
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 143)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(703, 392)
        Me.PanelControl1.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupControl2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(699, 388)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.PictureBox_Startup)
        Me.GroupControl1.Controls.Add(Me.PanelControl2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(343, 382)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Startup Splash Screen"
        '
        'PictureBox_Startup
        '
        Me.PictureBox_Startup.BackColor = System.Drawing.Color.Black
        Me.PictureBox_Startup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox_Startup.Image = CType(resources.GetObject("PictureBox_Startup.Image"), System.Drawing.Image)
        Me.PictureBox_Startup.Location = New System.Drawing.Point(2, 20)
        Me.PictureBox_Startup.Name = "PictureBox_Startup"
        Me.PictureBox_Startup.Size = New System.Drawing.Size(339, 296)
        Me.PictureBox_Startup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Startup.TabIndex = 1
        Me.PictureBox_Startup.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.ImageProp_Startup)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(2, 316)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(339, 64)
        Me.PanelControl2.TabIndex = 0
        '
        'ImageProp_Startup
        '
        Me.ImageProp_Startup.DefaultImage = Global.D7SCH_LAND.My.Resources.Resources.logo
        Me.ImageProp_Startup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageProp_Startup.Image = Global.D7SCH_LAND.My.Resources.Resources.logo
        Me.ImageProp_Startup.ImageBox = Me.PictureBox_Startup
        Me.ImageProp_Startup.Location = New System.Drawing.Point(2, 2)
        Me.ImageProp_Startup.Name = "ImageProp_Startup"
        Me.ImageProp_Startup.Size = New System.Drawing.Size(335, 60)
        Me.ImageProp_Startup.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.PictureBox_Fastboot)
        Me.GroupControl2.Controls.Add(Me.PanelControl3)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(352, 3)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(344, 382)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Fastboot Screen"
        '
        'PictureBox_Fastboot
        '
        Me.PictureBox_Fastboot.BackColor = System.Drawing.Color.Black
        Me.PictureBox_Fastboot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox_Fastboot.Image = CType(resources.GetObject("PictureBox_Fastboot.Image"), System.Drawing.Image)
        Me.PictureBox_Fastboot.Location = New System.Drawing.Point(2, 20)
        Me.PictureBox_Fastboot.Name = "PictureBox_Fastboot"
        Me.PictureBox_Fastboot.Size = New System.Drawing.Size(340, 296)
        Me.PictureBox_Fastboot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Fastboot.TabIndex = 1
        Me.PictureBox_Fastboot.TabStop = False
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.ImageProp_Fastboot)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(2, 316)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(340, 64)
        Me.PanelControl3.TabIndex = 0
        '
        'ImageProp_Fastboot
        '
        Me.ImageProp_Fastboot.DefaultImage = Global.D7SCH_LAND.My.Resources.Resources.fastboot
        Me.ImageProp_Fastboot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageProp_Fastboot.Image = Global.D7SCH_LAND.My.Resources.Resources.fastboot
        Me.ImageProp_Fastboot.ImageBox = Me.PictureBox_Fastboot
        Me.ImageProp_Fastboot.Location = New System.Drawing.Point(2, 2)
        Me.ImageProp_Fastboot.Name = "ImageProp_Fastboot"
        Me.ImageProp_Fastboot.Size = New System.Drawing.Size(336, 60)
        Me.ImageProp_Fastboot.TabIndex = 1
        '
        'OpenData
        '
        Me.OpenData.DefaultExt = "sdat"
        Me.OpenData.FileName = "Splash.sdat"
        Me.OpenData.Filter = "Splash Data (*.sdat)|*.sdat"
        Me.OpenData.FilterIndex = 0
        '
        'SaveData
        '
        Me.SaveData.DefaultExt = "sdat"
        Me.SaveData.FileName = "Splash.sdat"
        Me.SaveData.Filter = "Splash Data (*.sdat)|*.sdat"
        Me.SaveData.FilterIndex = 0
        '
        'SaveIMG
        '
        Me.SaveIMG.DefaultExt = "img"
        Me.SaveIMG.FileName = "Splash.img"
        Me.SaveIMG.Filter = "IMG Files (*.img)|*.img"
        '
        'SaveZIP
        '
        Me.SaveZIP.DefaultExt = "zip"
        Me.SaveZIP.FileName = "Flashable Splash.zip"
        Me.SaveZIP.Filter = "Compressed ZIP Files (*.zip)|*.zip"
        Me.SaveZIP.FilterIndex = 0
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 566)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(713, 567)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Devil 7 - Splash Changer for Redmi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Device_repo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.PictureBox_Startup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.PictureBox_Fastboot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage_Home As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_Project As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents rpg_Make As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpg_Device As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_Skin As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Open As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SplashImage As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_FlashableZIP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Device As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureBox_Startup As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Fastboot As System.Windows.Forms.PictureBox
    Friend WithEvents ImageProp_Startup As D7SCH_LAND.ImageProp
    Friend WithEvents ImageProp_Fastboot As D7SCH_LAND.ImageProp
    Friend WithEvents OpenData As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveData As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveIMG As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveZIP As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btn_About As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Misc As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents cmb_Device As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cmb_Device_repo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox


End Class
