Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = DataModule.nama
        lblID.Text = DataModule.idAnggota
        lblEmail.Text = DataModule.email
        lblTelp.Text = DataModule.telp
        lblDivisi.Text = DataModule.divisi
        lblPeran.Text = DataModule.peran
        lblJk.Text = DataModule.jk
        tblTglLahir.Text = DataModule.tglLahir
        lblAlamat.Text = DataModule.alamat
        lblBahasa.Text = DataModule.bahasa

        If Not String.IsNullOrEmpty(DataModule.foto) AndAlso System.IO.File.Exists(DataModule.foto) Then
            pictureProfile.Image = System.Drawing.Image.FromFile(DataModule.foto)
            pictureProfile.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
End Class