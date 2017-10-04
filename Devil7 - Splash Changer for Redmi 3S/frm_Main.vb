Public Class frm_Main
    Public Shared adbf As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "adb")
    Dim CurrentFile_ As String = "Untitled"
    Property CurrentFile As String
        Get
            Return CurrentFile_
        End Get
        Set(ByVal value As String)
            CurrentFile_ = value
            If My.Computer.FileSystem.FileExists(value) Then
                Me.Text = IO.Path.GetFileNameWithoutExtension(value) & " : - Devil7 - Splash Changer for Redmi"
            Else
                Me.Text = value & " : - Devil7 - Splash Changer for Redmi"
            End If
        End Set
    End Property
    Private Sub btn_SplashImage_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SplashImage.ItemClick
        Try
            If SaveIMG.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim tmpdir As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "tmp_" & Random.Next(0, 10000).ToString("00000"))
                Dim splash1 As String = ConvertToRAW(ImageProp_Startup.Image, New Size(720, 1280), tmpdir)
                Dim splash2 As String = ConvertToRAW(ImageProp_Fastboot.Image, New Size(720, 1280), tmpdir)
                Dim splash As String = SaveIMG.FileName
                JoinFiles(splash, splash1, splash2)
                MsgBox("Splash IMG Successfully Created...!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
            End If
        Catch ex As Exception
            MsgBox("Error Occured while Processing." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub frm_Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            My.Settings.Skin = Me.GetSkin.Name
            My.Settings.Save()
        Catch ex As Exception

        End Try
    End Sub
    Sub SetupADB()
        On Error Resume Next
        My.Computer.FileSystem.CreateDirectory(adbf)
        My.Computer.FileSystem.WriteAllBytes(adbf & "\adb.exe", My.Resources.adb, False)
        My.Computer.FileSystem.WriteAllBytes(adbf & "\AdbWinApi.dll", My.Resources.AdbWinApi, False)
        My.Computer.FileSystem.WriteAllBytes(adbf & "\AdbWinUsbApi.dll", My.Resources.AdbWinUsbApi, False)
        My.Computer.FileSystem.WriteAllBytes(adbf & "\fastboot.exe", My.Resources.fastboot1, False)
    End Sub
    Private Sub frm_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetupADB()
        Try
            cmb_Device.EditValue = cmb_Device_repo.Items(0)
        Catch ex As Exception

        End Try
        Try
            If My.Settings.Skin <> "" Then
                Me.DefaultLookAndFeel1.LookAndFeel.SkinName = My.Settings.Skin
            End If
        Catch ex As Exception

        End Try
        ImageProp_Startup.Image = My.Resources.logo
        ImageProp_Fastboot.Image = My.Resources.fastboot
        Me.CurrentFile = "Untitiled"
        If My.Application.CommandLineArgs.Count > 0 Then
            Dim f As String = My.Application.CommandLineArgs(0)
            If My.Computer.FileSystem.FileExists(f) Then
                Dim d As SplashData = LoadSplashData(f)
                If d IsNot Nothing Then
                    ImageProp_Startup.Image = d.StartupImage
                    ImageProp_Fastboot.Image = d.FastbootImage
                    Me.CurrentFile = f
                End If
            End If
        End If
    End Sub
    Private Sub btn_New_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
        ImageProp_Startup.Image = My.Resources.logo
        ImageProp_Fastboot.Image = My.Resources.fastboot
        Me.CurrentFile = "Untitled"
    End Sub

    Private Sub btn_Save_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        Try
            If My.Computer.FileSystem.FileExists(CurrentFile) Then
                Dim d As New SplashData(ImageProp_Startup.Image, ImageProp_Fastboot.Image)
                SaveSenders(CurrentFile, d)
            ElseIf SaveData.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim d As New SplashData(ImageProp_Startup.Image, ImageProp_Fastboot.Image)
                SaveSenders(SaveData.FileName, d)
                CurrentFile = SaveData.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub btn_Open_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Open.ItemClick
        Try
            If OpenData.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim d As SplashData = LoadSplashData(OpenData.FileName)
                If d IsNot Nothing Then
                    ImageProp_Startup.Image = d.StartupImage
                    ImageProp_Fastboot.Image = d.FastbootImage
                    Me.CurrentFile = OpenData.FileName
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub


    Private Sub btn_FlashableZIP_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_FlashableZIP.ItemClick
        Try
            If SaveZIP.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim tmpdir As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "tmp_" & Random.Next(0, 10000).ToString("00000"))
                Dim splash1 As String = ConvertToRAW(ImageProp_Startup.Image, New Size(720, 1280), tmpdir)
                Dim splash2 As String = ConvertToRAW(ImageProp_Fastboot.Image, New Size(720, 1280), tmpdir)
                Dim splash As String = tmpdir & "\splash.img"
                JoinFiles(splash, splash1, splash2)
                MakeFlashableZIP(SaveZIP.FileName, splash, tmpdir)
                MsgBox("Flashable Splash ZIP File Successfully Created...!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
            End If
        Catch ex As Exception
            MsgBox("Error Occured while Processing." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub btn_Device_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Device.ItemClick
        frm_Device.ShowDialog()
    End Sub

    Private Sub btn_About_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_About.ItemClick
        frm_About.ShowDialog()
    End Sub
End Class