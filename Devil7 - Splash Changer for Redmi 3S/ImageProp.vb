Public Class ImageProp
    Property ImageBox As PictureBox = Nothing
    Dim img As Image = Nothing
    Property Image As Image
        Get
            Return img
        End Get
        Set(ByVal value As Image)
            img = value
            RaiseEvent ImageChanged(value)
            Try
                Dim b As New Bitmap(My.Resources.Redmi3S)
                Dim g As Graphics = Graphics.FromImage(b)
                g.DrawImage(img, New Rectangle(15, 68, 362, 640))
                g.Dispose()
                ImageBox.Image = b
                lbl_Resolution.Text = img.Size.ToString
                Dim gs As New IO.MemoryStream
                img.Save(gs, img.RawFormat)
                lbl_Size.Text = GetSize(gs.Length)
                gs.Dispose()
            Catch ex As Exception

            End Try
        End Set
    End Property
    Property DefaultImage As Image = Nothing
    Event ImageChanged(ByVal Image As Image)
    Private Sub btn_Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Browse.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                Me.Image = Image.FromFile(OpenFileDialog1.FileName)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btn_Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reset.Click
        Try
            Me.Image = Me.DefaultImage
        Catch ex As Exception

        End Try
    End Sub
End Class
