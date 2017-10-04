Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Module PublicSubs
    Public Random As New Random
    Function ConvertToRAW(ByVal Image As Image, ByVal Resolution As Size, ByVal TMPDir As String) As String
        My.Computer.FileSystem.CreateDirectory(TMPDir)
        Dim source As String = IO.Path.Combine(TMPDir, "img_" & Random.Next(0, 10000).ToString("00000") & ".png")
        Image.Save(source, Imaging.ImageFormat.Png)
        Dim splash As String = IO.Path.Combine(TMPDir, "splash" & Random.Next(0, 10000).ToString("00000") & ".raw")
        Dim ffmpeg As String = IO.Path.Combine(TMPDir, "ffmpeg.exe")
        Dim arg As String = String.Format("-hide_banner -loglevel quiet -i ""{0}"" -f rawvideo -vcodec rawvideo -pix_fmt bgr24 -s {1}x{2} -y ""{3}""", source, Resolution.Width, Resolution.Height, splash)
        My.Computer.FileSystem.WriteAllBytes(ffmpeg, My.Resources.ffmpeg, False)
        Dim pi As New ProcessStartInfo(ffmpeg, arg)
        pi.CreateNoWindow = True
        pi.RedirectStandardOutput = True
        pi.RedirectStandardError = True
        pi.UseShellExecute = False
        Dim pr As New Process
        pr.StartInfo = pi
        pr.Start()
        pr.WaitForExit()
        If My.Computer.FileSystem.FileExists(splash) Then
            Return splash
        Else
            Return "error"
        End If
    End Function
    Function ConvertToRAW(ByVal Image As String, ByVal Resolution As Size, ByVal TMPDir As String) As String
        My.Computer.FileSystem.CreateDirectory(TMPDir)
        Dim splash As String = IO.Path.Combine(TMPDir, "splash" & Random.Next(0, 10000).ToString("00000") & ".raw")
        Dim ffmpeg As String = IO.Path.Combine(TMPDir, "ffmpeg.exe")
        Dim arg As String = String.Format("-hide_banner -loglevel quiet -i ""{0}"" -f rawvideo -vcodec rawvideo -pix_fmt bgr24 -s {1}x{2} -y ""{3}""", Image, Resolution.Width, Resolution.Height, splash)
        If My.Computer.FileSystem.FileExists(ffmpeg) = False Then
            My.Computer.FileSystem.WriteAllBytes(ffmpeg, My.Resources.ffmpeg, False)
        End If
        Dim pi As New ProcessStartInfo(ffmpeg, arg)
        pi.CreateNoWindow = True
        pi.RedirectStandardOutput = True
        pi.RedirectStandardError = True
        pi.UseShellExecute = False
        Dim pr As New Process
        pr.StartInfo = pi
        pr.Start()
        pr.WaitForExit()
        If My.Computer.FileSystem.FileExists(splash) Then
            Return splash
        Else
            Return "error"
        End If
    End Function
    Sub JoinFiles(ByVal Target As String, ByVal StartupSplash As String, ByVal FastbootSplash As String)
        My.Computer.FileSystem.WriteAllBytes(Target, My.Resources._720x1280_header, False)
        My.Computer.FileSystem.WriteAllBytes(Target, My.Computer.FileSystem.ReadAllBytes(StartupSplash), True)
        My.Computer.FileSystem.WriteAllBytes(Target, My.Resources._720x1280_header, True)
        My.Computer.FileSystem.WriteAllBytes(Target, My.Computer.FileSystem.ReadAllBytes(FastbootSplash), True)
    End Sub
    Sub MakeFlashableZIP(ByVal Target As String, ByVal Splash As String, ByVal TMPDir As String)
        My.Computer.FileSystem.WriteAllBytes(Target, My.Resources.New_Splash, False)
        Dim _7za As String = IO.Path.Combine(TMPDir, "7za.exe")
        Dim _7zadll As String = IO.Path.Combine(TMPDir, "7za.dll")
        My.Computer.FileSystem.WriteAllBytes(_7za, My.Resources._7za1, False)
        My.Computer.FileSystem.WriteAllBytes(_7zadll, My.Resources._7za, False)
        Dim arg As String = String.Format("a ""{0}"" ""{1}""", Target, Splash)
        Dim pi As New ProcessStartInfo(_7za, arg)
        pi.CreateNoWindow = True
        pi.RedirectStandardOutput = True
        pi.RedirectStandardError = True
        pi.UseShellExecute = False
        Dim pr As New Process
        pr.StartInfo = pi
        pr.Start()
        pr.WaitForExit()
    End Sub
    Function GetSize(ByVal SizeinBytes As Integer) As String
        Dim cs As String = SizeinBytes & " Bytes"
        Dim kb As Integer = SizeinBytes / 1024
        Dim mb As Integer = kb / 1024
        If kb >= 1 AndAlso kb < 1024 Then
            cs = kb & " KB"
        ElseIf mb >= 1 Then
            cs = mb & " MB"
        End If
        Return cs
    End Function
    Public Function LoadSplashData(ByVal Filename As String) As SplashData
        If My.Computer.FileSystem.FileExists(Filename) Then
            Dim fs As Stream = New FileStream(Filename, FileMode.Open)
            Dim bf As BinaryFormatter = New BinaryFormatter()
            Return CType(bf.Deserialize(fs), SplashData)
            fs.Close()
        End If
        Return Nothing
    End Function
    Public Sub SaveSenders(ByVal Filename As String, ByVal Data As SplashData)
        Try
            If My.Computer.FileSystem.FileExists(Filename) = True Then
                My.Computer.FileSystem.DeleteFile(Filename)
            End If
            Dim fs As Stream = New FileStream(Filename, FileMode.Create)
            Dim bf As BinaryFormatter = New BinaryFormatter()
            bf.Serialize(fs, Data)
            fs.Close()
        Catch ex As Exception

        End Try
    End Sub
End Module
<Serializable()> _
Public Class SplashData
    Sub New()
        Me.StartupImage = My.Resources.logo
        Me.FastbootImage = My.Resources.fastboot
    End Sub
    Sub New(ByVal StartupImage As Image, ByVal FastbootImage As Image)
        Me.FastbootImage = FastbootImage
        Me.StartupImage = StartupImage
    End Sub
    Property StartupImage As Image
    Property FastbootImage As Image
End Class