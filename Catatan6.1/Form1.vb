Public Class FormPeriksa

    Private Sub tombolJalankan_Click(sender As Object, e As EventArgs) Handles tombolJalankan.Click
        Dim intAngka As Integer
        Dim strMasukan As String
        strMasukan = InputBox("Masukkan sebuah nilai")
        intAngka = CInt(strMasukan)
        If intAngka < 10 Then
            Pesan1()
            Pesan2()
        Else
            Pesan2()
            Pesan1()
        End If
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'Menutup form
        Me.Close()
    End Sub

    Sub Pesan1()
        listKeluaran.Items.Add("Saya adalah Indonesia")
    End Sub
    Sub Pesan2()
        listKeluaran.Items.Add("Indonesia adalah Saya")
    End Sub
End Class
