Public Class Form1
    Public judulTambah As String
    Public genre As String
    Public judulHapus As String
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        judulTambah = txtJudulTambah.Text
        genre = txtGenre.Text
        If (judulTambah = "" Or genre = "") Then
            MessageBox.Show("Judul dan Genre tidak boleh kosong")
        Else
            If (TambahBuku(judulTambah, genre)) Then
                ShowDaftarBuku(jumlahBuku)
            Else
                MessageBox.Show("Daftar buku sudah penuh!")
            End If
            txtJudulTambah.Clear()
            txtGenre.Clear()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        judulHapus = txtJudulHapus.Text
        If (judulHapus = "") Then
            MessageBox.Show("Judul tidak boleh kosong")
        Else
            If (HapusBuku(judulHapus)) Then
                ShowDaftarBuku(jumlahBuku)
            Else
                MessageBox.Show("Buku tidak ditemukan!")
            End If
            txtJudulHapus.Clear()
        End If
    End Sub

    Public Sub ShowDaftarBuku(ByRef banyakBuku)
        ListBox1.Items.Clear()
        For i As Integer = 0 To banyakBuku - 1
            ListBox1.Items.Add(daftarBuku(i, 0) & " (" & daftarBuku(i, 1) & ")")
        Next
    End Sub
End Class
