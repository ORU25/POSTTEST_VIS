Public Class Form2
	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lblNama.Text = DataModule.Nama
		lblJk.Text = DataModule.Jk
		lblLahir.Text = DataModule.Tglahir.ToString("dd MMMM yyyy")
		lblUmur.Text = DataModule.Umur & " Tahun"
		lblTelp.Text = DataModule.Telp
		lblAlamat.Text = DataModule.Alamat

		Dim hobbies As String() = DataModule.Hobby.Split(", ")
		Dim formatHobby As String = ""
		For i As Integer = 0 To hobbies.Length - 1
			formatHobby &= hobbies(i)
            If i < hobbies.Length - 1 Then
				' enter setelah kelipatan 4 hobby
				If (i + 1) Mod 4 = 0 Then
					formatHobby &= "," & Environment.NewLine
				Else
					formatHobby &= ", "
				End If
			End If
		Next
		lblHobby.Text = formatHobby

		picProfile.Image = Image.FromFile(DataModule.Foto)
	End Sub
End Class