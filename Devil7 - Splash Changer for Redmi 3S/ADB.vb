Module ADB

    Function RunCommand(ByVal Command As String) As String
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo(IO.Path.Combine(frm_Main.adbf, "adb.exe"), Command)

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
        Dim Outputs As String() = RunCommand(ADBCommands.Devices).Split(vbNewLine)
        For Each i As String In Outputs
            If i.StartsWith("*") = False AndAlso i.Trim <> "List of devices attached" AndAlso i.Trim <> "" Then
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
Class ADBCommands
    Public Const Mount As String = "shell su mount -o remount,rw /system"
    Public Const Devices As String = "devices"
    Public Const Root As String = "root"
    Public Const Remount As String = "remount"
    Function Push(ByVal SourceFile As String, ByVal Destination As String) As String
        Return String.Format("push ""{0}"" {1}", SourceFile, Destination)
    End Function

End Class
Public Class Device
    Dim DeviceName_ As String
    Dim Status_ As String
    Dim Type_ As String
    Sub New(ByVal Devicename As String, ByVal Status As String, ByVal Type As String)
        Me.DeviceName_ = Devicename.Trim
        Me.Status_ = Status.Trim
        Me.Type_ = Type.Trim
    End Sub
    Property DeviceName As String
        Get
            Return DeviceName_
        End Get
        Set(ByVal value As String)
            DeviceName_ = value
        End Set
    End Property
    Property Type As String
        Get
            Return Type_
        End Get
        Set(ByVal value As String)
            Type_ = value
        End Set
    End Property
    Property Status As String
        Get
            Return Status_
        End Get
        Set(ByVal value As String)
            Status_ = value
        End Set
    End Property
End Class
