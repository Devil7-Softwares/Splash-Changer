Public Class frm_Device

    Sub RefreshList()
        On Error Resume Next
        If InvokeRequired Then
            Me.Invoke(Sub()
                          Dim l As New List(Of Device)
                          l.AddRange(Fastboot.GetDevices().ToArray)
                          l.AddRange(ADB.GetDevices().ToArray)
                          lst_Devices.DataSource = l
                      End Sub)
        Else
            Dim l As New List(Of Device)
            l.AddRange(Fastboot.GetDevices().ToArray)
            l.AddRange(ADB.GetDevices().ToArray)
            lst_Devices.DataSource = l
        End If
    End Sub
    Private Sub btn_GetDevices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GetDevices.Click
        Try
            RefreshList()
        Catch ex As Exception

        End Try
    End Sub
    Private Const WM_DEVICECHANGE As Integer = &H219
    Private Const DBT_DEVICEARRIVAL As Integer = &H8000
    Private Const DBT_DEVICEREMOVECOMPLETE As Integer = 7
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_DEVICECHANGE Then
            If m.WParam.ToInt32 = 7 Then
                Dim t As New Threading.Thread(Sub()
                                                  RefreshList()
                                                  Threading.Thread.Sleep(2000)
                                                  RefreshList()
                                              End Sub)
                t.Start()
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub btn_FlashSplash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FlashSplash.Click
        Try
            If GridView_Devices.SelectedRowsCount = 1 Then
                Dim r = CType(GridView_Devices.GetRow(GridView_Devices.GetSelectedRows(0)), Device)
                If r.Type = "fastboot" Then
                    Dim tmpdir As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "tmp_" & Random.Next(0, 10000).ToString("00000"))
                    Dim splash1 As String = ConvertToRAW(frm_Main.ImageProp_Startup.Image, New Size(720, 1280), tmpdir)
                    Dim splash2 As String = ConvertToRAW(frm_Main.ImageProp_Fastboot.Image, New Size(720, 1280), tmpdir)
                    Dim splash As String = tmpdir & "\splash.img"
                    JoinFiles(splash, splash1, splash2)
                    Dim cmd As String = String.Format("-s {0} flash splash ""{1}""", r.DeviceName, splash)
                    Dim o As String = Fastboot.RunCommand(cmd)
                    RichTextBox1.AppendText(o & vbNewLine)
                ElseIf r.Type = "device" Or r.Type = "recovery" Or r.Type = "sideload" Then
                    MsgBox("Device should be in fastboot mode to flash.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                End If
            Else
                MsgBox("You need to select atlease one device to process this.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub btn_Reboot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reboot.Click
        Try
            If GridView_Devices.SelectedRowsCount = 1 Then
                Dim r = CType(GridView_Devices.GetRow(GridView_Devices.GetSelectedRows(0)), Device)
                If r.Type = "fastboot" Then
                    Dim cmd As String = String.Format("-s {0} reboot", r.DeviceName)
                    Dim o As String = Fastboot.RunCommand(cmd)
                    RichTextBox1.AppendText(o & vbNewLine)
                ElseIf r.Type = "device" Or r.Type = "recovery" Or r.Type = "sideload" Then
                    Dim cmd As String = String.Format("-s {0} reboot", r.DeviceName)
                    Dim o As String = ADB.RunCommand(cmd)
                    RichTextBox1.AppendText(o & vbNewLine)
                End If
            Else
                MsgBox("You need to select atlease one device to process this.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub btn_RebootToBootloader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RebootToBootloader.Click
        Try
            If GridView_Devices.SelectedRowsCount = 1 Then
                Dim r = CType(GridView_Devices.GetRow(GridView_Devices.GetSelectedRows(0)), Device)
                If r.Type = "fastboot" Then
                    Dim cmd As String = String.Format("-s {0} reboot bootloader", r.DeviceName)
                    Dim o As String = Fastboot.RunCommand(cmd)
                    RichTextBox1.AppendText(o & vbNewLine)
                ElseIf r.Type = "device" Or r.Type = "recovery" Or r.Type = "sideload" Then
                    Dim cmd As String = String.Format("-s {0} reboot bootloader", r.DeviceName)
                    Dim o As String = ADB.RunCommand(cmd)
                    RichTextBox1.AppendText(o & vbNewLine)
                End If

            Else
                MsgBox("You need to select atlease one device to process this.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub btn_RebootToRecovery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RebootToRecovery.Click
        Try
            If GridView_Devices.SelectedRowsCount = 1 Then
                Dim r = CType(GridView_Devices.GetRow(GridView_Devices.GetSelectedRows(0)), Device)
                If r.Type = "fastboot" Then
                    MsgBox("You can't directly reboot to recovery from fastboot mode.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                ElseIf r.Type = "device" Or r.Type = "recovery" Or r.Type = "sideload" Then
                    Dim cmd As String = String.Format("-s {0} reboot recovery", r.DeviceName)
                    Dim o As String = ADB.RunCommand(cmd)
                    RichTextBox1.AppendText(o & vbNewLine)
                End If
            Else
                MsgBox("You need to select atlease one device to process this.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub frm_Device_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            RefreshList()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Backup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Backup.Click
        Try
            If GridView_Devices.SelectedRowsCount = 1 Then
                Dim r = CType(GridView_Devices.GetRow(GridView_Devices.GetSelectedRows(0)), Device)
                If r.Type = "fastboot" Then
                    MsgBox("You can't backup splash in fastboot mode.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                ElseIf r.Type = "device" Or r.Type = "recovery" Or r.Type = "sideload" Then
                    If SaveIMG.ShowDialog = Windows.Forms.DialogResult.OK Then
                        RichTextBox1.Text = ""
                        Dim cmd1 As String = String.Format("-s {0} shell dd if=/dev/block/bootdevice/by-name/splash of=/sdcard/splash.img", r.DeviceName)
                        Dim cmd2 As String = String.Format("-s {0} pull /sdcard/splash.img ""{1}""", r.DeviceName, SaveIMG.FileName)
                        Dim o As String = ADB.RunCommand(cmd1)
                        Dim o1 As String = ADB.RunCommand(cmd2)
                        RichTextBox1.AppendText(o & vbNewLine & o1)
                    End If
                End If
            Else
                MsgBox("You need to select atlease one device to process this.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub btn_Restore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Restore.Click
        Try
            If GridView_Devices.SelectedRowsCount = 1 Then
                Dim r = CType(GridView_Devices.GetRow(GridView_Devices.GetSelectedRows(0)), Device)
                If r.Type = "fastboot" Then
                    If OpenIMG.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Dim cmd As String = String.Format("-s {0} flash splash ""{1}""", r.DeviceName, OpenIMG.FileName)
                        Dim o As String = Fastboot.RunCommand(cmd)
                        RichTextBox1.AppendText(o & vbNewLine)
                    End If
                ElseIf r.Type = "device" Or r.Type = "recovery" Or r.Type = "sideload" Then
                    MsgBox("Device should be in fastboot mode to restore splash.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                End If
            Else
                MsgBox("You need to select atlease one device to process this.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        Try
            RichTextBox1.Select(RichTextBox1.Text.Length - 1, 1)
            RichTextBox1.ScrollToCaret()
        Catch ex As Exception

        End Try
    End Sub
End Class