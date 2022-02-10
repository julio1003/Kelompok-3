Public Class Form3

    Private Sub DTTanggal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTTanggal.ValueChanged
        DTTanggal.Format = DateTimePickerFormat.Short
        DTTanggal.CustomFormat = "dd/mm/yyy"
        DTTanggal.Value = Format(Now)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = DTTanggal.Text

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dispose()

    End Sub
End Class