Imports System.IO

Public Class Form1

    Dim grupHobi() As CheckBox
    Dim grupJK() As RadioButton

    Private Function CekData() As Boolean
        grupHobi = {cbBacaBuku, cbBasket, cbBerenang, cbGaming, cbMelukis, cbMemasak, cbMenari, cbMenulis, cbMenyanyi}
        grupJK = {radioLakilaki, radioPerempuan}
        If Not ValidasiTextBox(txtNama, "Nama Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtTelp, "No. Telp Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtAlamat, "Alamat Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtUmur, "Umur Tidak Boleh Kosong") Then Return False
        If Not ValidasiRadioButton(grupJK, "Pilih Jenis Kelamin Anda") Then Return False
        If Not ValidasiCheckBox(grupHobi, "Pilih Minimal 1 Hobi") Then Return False
        If Not ValidasiPictureBox(picProfile, "Gambar Tidak Boleh Kosong") Then Return False
        Return True
    End Function

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If ValidasiTextBox(txtNama, "Nama Tidak Boleh Kosong") Then
            Dim NamaFile As String = txtNama.Text.Trim()
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Pilih Gambar"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
                Dim destinationPath As String = Path.Combine(folderPath, fileName)
                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If
                File.Copy(openFileDialog.FileName, destinationPath, True)
                DataModule.Foto = destinationPath
                picProfile.Image = Image.FromFile(destinationPath)
                MessageBox.Show("Gambar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        validationModule.HanyaHuruf(sender, e)
    End Sub

    Private Sub txtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelp.KeyPress
        validationModule.HanyaAngka(sender, e)
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        validationModule.HanyaAngka(sender, e)
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If CekData() Then
            grupHobi = {cbBacaBuku, cbBasket, cbBerenang, cbGaming, cbMelukis, cbMemasak, cbMenari, cbMenulis, cbMenyanyi}
            grupJK = {radioLakilaki, radioPerempuan}
            Dim Hobby_Selected As String = GetSelectedCheckBox(grupHobi)
            Dim jk_Selected As String = GetSelectedRadioButton(grupJK)
            DataModule.Nama = txtNama.Text
            DataModule.Telp = txtTelp.Text
            DataModule.Alamat = txtAlamat.Text
            DataModule.Umur = txtUmur.Text
            DataModule.Hobby = Hobby_Selected
            DataModule.Jk = jk_Selected
            DataModule.Tglahir = dtpTglLahir.Value.ToShortDateString()
            Form2.Show()
        End If
    End Sub
End Class
