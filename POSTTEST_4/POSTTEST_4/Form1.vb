Imports System.IO

Public Class Form1
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub mtxTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxTelp.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If (txtNama.Text.Trim() = "") Then
            MessageBox.Show("Nama harus diisi sebelum mengupload gambar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
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
            DataModule.foto = destinationPath
            picProfile.Image = Image.FromFile(destinationPath)
            MessageBox.Show("Gambar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        Dim isValid As Boolean = True

        If Not ValidasiTextBox(ErrorProvider1, txtNama, "Inputan tidak boleh kosong") Then isValid = False
        If Not ValidasiTextBox(ErrorProvider1, txtId, "Inputan tidak boleh kosong") Then isValid = False
        If Not ValidasiTextBox(ErrorProvider1, txtUmur, "Inputan tidak boleh kosong") Then isValid = False
        If Not ValidasiTextBox(ErrorProvider1, txtEmail, "Inputan tidak boleh kosong") Then isValid = False
        If Not ValidasiTextBox(ErrorProvider1, txtAlamat, "Inputan tidak boleh kosong") Then isValid = False

        If Not ValidasiComboBox(ErrorProvider1, cmbDivisi, "Inputan tidak boleh kosong") Then isValid = False
        If Not ValidasiMaskedTextBox(ErrorProvider1, mtxTelp, "Inputan tidak boleh kosong") Then isValid = False

        Dim jkRadios() As RadioButton = {radioLaki, radioPerempuan}
        If Not ValidasiRadioButtonGroup(ErrorProvider1, radioPerempuan, "Inputan tidak boleh kosong", jkRadios) Then isValid = False

        Dim peranRadios() As RadioButton = {radioKetua, radioAdmin, radioKepala, radioAnggota}
        If Not ValidasiRadioButtonGroup(ErrorProvider1, radioAnggota, "Inputan tidak boleh kosong", peranRadios) Then isValid = False

        Dim bahasaChecks() As CheckBox = {cbGo, cbJava, cbJS, cbFlutter, cbKotlin, cbPHP, cbTS, sbSwift}
        If Not ValidasiCheckBoxGroup(ErrorProvider1, GroupBox2, "Inputan tidak boleh kosong", bahasaChecks) Then isValid = False

        If Not isValid Then
            MessageBox.Show("Ada inputan yang masih kosong. Silakan periksa tanda peringatan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DataModule.nama = txtNama.Text.Trim()
        DataModule.idAnggota = txtId.Text.Trim()
        DataModule.umur = txtUmur.Text.Trim()
        DataModule.tglLahir = dtpTanggalLahir.Value.ToShortDateString()
        DataModule.jk = If(radioLaki.Checked, radioLaki.Text, radioPerempuan.Text)
        DataModule.divisi = cmbDivisi.Text
        DataModule.email = txtEmail.Text.Trim()
        DataModule.alamat = txtAlamat.Text.Trim()
        DataModule.telp = mtxTelp.Text

        Dim radios() As RadioButton = {radioKetua, radioAdmin, radioKepala, radioAnggota}
        DataModule.peran = DataModule.GetSelectedRadioButton(radios)

        Dim checkboxes() As CheckBox = {cbGo, cbJava, cbJS, cbFlutter, cbKotlin, cbPHP, cbTS, sbSwift}
        DataModule.bahasa = DataModule.GetSelectedCheckBox(checkboxes)

        If MessageBox.Show("Apakah Anda yakin ingin menyimpan dan mencetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Form2.Show()
        End If
    End Sub

    Private Sub mnuInputData_Click(sender As Object, e As EventArgs) Handles mnuInputData.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show(
            "Apakah yakin ingin keluar?",
            "Konfirmasi Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub mnuLihatKartu_Click(sender As Object, e As EventArgs) Handles mnuLihatKartu.Click
        Form2.Show()
    End Sub

    Private Sub mnuSimpan_Click(sender As Object, e As EventArgs) Handles mnuSimpan.Click
        If DataModule.nama = "" Then
            MessageBox.Show("Silakan klik 'Simpan dan Cetak Kartu' terlebih dahulu untuk merekam data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            DataModule.SimpanDataKeFile(SaveFileDialog1.FileName)
            MessageBox.Show("Data berhasil disimpan ke " & SaveFileDialog1.FileName, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub mnuBuka_Click(sender As Object, e As EventArgs) Handles mnuBuka.Click
        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            DataModule.BukaDataDariFile(OpenFileDialog1.FileName)
            tampilkanData()
            MessageBox.Show("Data berhasil di-load ke DataModule dan di-apply ke form!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tampilkanData()
        txtNama.Text = DataModule.nama
        txtId.Text = DataModule.idAnggota
        txtUmur.Text = DataModule.umur
        cmbDivisi.Text = DataModule.divisi
        txtEmail.Text = DataModule.email
        txtAlamat.Text = DataModule.alamat
        mtxTelp.Text = DataModule.telp

        Dim tgl As DateTime
        If DateTime.TryParse(DataModule.tglLahir, tgl) Then dtpTanggalLahir.Value = tgl

        radioLaki.Checked = False : radioPerempuan.Checked = False
        If Not String.IsNullOrEmpty(DataModule.jk) Then
            If DataModule.jk.Contains("Laki") Then radioLaki.Checked = True
            If DataModule.jk = "Perempuan" Then radioPerempuan.Checked = True
        End If

        radioKetua.Checked = False : radioAdmin.Checked = False : radioKepala.Checked = False : radioAnggota.Checked = False
        If Not String.IsNullOrEmpty(DataModule.peran) Then
            If DataModule.peran = "Ketua" Then radioKetua.Checked = True
            If DataModule.peran = "Admin" Then radioAdmin.Checked = True
            If DataModule.peran = "Kepala" Then radioKepala.Checked = True
            If DataModule.peran = "Anggota" Then radioAnggota.Checked = True
        End If

        cbGo.Checked = False : cbJava.Checked = False : cbJS.Checked = False : cbFlutter.Checked = False
        cbKotlin.Checked = False : cbPHP.Checked = False : cbTS.Checked = False : sbSwift.Checked = False
        If Not String.IsNullOrEmpty(DataModule.bahasa) Then
            If DataModule.bahasa.Contains("Go") Then cbGo.Checked = True
            If DataModule.bahasa.Contains("Java") AndAlso Not DataModule.bahasa.Contains("JavaScript") Then cbJava.Checked = True
            If DataModule.bahasa.Contains("JavaScript") Then cbJS.Checked = True
            If DataModule.bahasa.Contains("Flutter") Then cbFlutter.Checked = True
            If DataModule.bahasa.Contains("Kotlin") Then cbKotlin.Checked = True
            If DataModule.bahasa.Contains("PHP") Then cbPHP.Checked = True
            If DataModule.bahasa.Contains("TypeScript") Then cbTS.Checked = True
            If DataModule.bahasa.Contains("Swift") Then sbSwift.Checked = True
        End If
    End Sub
End Class
