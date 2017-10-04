Module Fastboot
    Function RunCommand(ByVal Command As String) As String
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo(IO.Path.Combine(frm_Main.adbf, "fastboot.exe"), Command)
        oStartInfo.UseShellExecute = False
        oStartInfo.CreateNoWindow = True
        oStartInfo.RedirectStandardOutput = True
        oStartInfo.RedirectStandardError = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()
        Dim sOutput As String
        sOutput = (oProcess.StandardOutput.ReadToEnd & vbNewLine & oProcess.StandardError.ReadToEnd).Trim
        Return (sOutput)
    End Function
    Function GetDevices() As List(Of Device)
        Dim L As New List(Of Device)
        Dim Outputs As String() = RunCommand("devices").Split(vbNewLine)
        For Each i As String In Outputs
            If i.Trim <> "" Then
                Try
                    Dim devicename As String = (i.Split(vbTab)(0))
                    Dim type As String = (i.Split(vbTab)(1))
                    L.Add(New Device(devicename, "Ready", type))
                Catch ex As Exception

                End Try
            End If
        Next
        Return L
    End Function
End Module
