Imports System.IO
Imports System.Text

Module DataModule
	Public nama, idAnggota, jk, divisi, email, alamat, telp, foto, peran, bahasa, umur As String
	Public tglLahir As Date

	Public Function GetSelectedRadioButton(grupRadio() As RadioButton) As String
		For Each rb As RadioButton In grupRadio
			If rb.Checked Then
				Return rb.Text
			End If
		Next
		Return ""
	End Function
	Public Function GetSelectedCheckBox(grupCheck() As CheckBox) As String
		Dim selectedItems As New List(Of String)
		For Each cb As CheckBox In grupCheck
			If cb.Checked Then
				selectedItems.Add(cb.Text)
			End If
		Next
		Return String.Join(", ", selectedItems)
	End Function

	Public Sub SimpanDataKeFile(filePath As String)
		Dim sb As New StringBuilder()
		sb.AppendLine("Nama;" & nama)
		sb.AppendLine("ID;" & idAnggota)
		sb.AppendLine("Umur;" & umur)
		sb.AppendLine("TglLahir;" & tglLahir)
		sb.AppendLine("JK;" & jk)
		sb.AppendLine("Divisi;" & divisi)
		sb.AppendLine("Email;" & email)
		sb.AppendLine("Alamat;" & alamat)
		sb.AppendLine("Telp;" & telp)
		sb.AppendLine("Peran;" & peran)
		sb.AppendLine("Bahasa;" & bahasa)

		File.WriteAllText(filePath, sb.ToString())
	End Sub

	Public Sub BukaDataDariFile(filePath As String)
		Dim lines As String() = File.ReadAllLines(filePath)
		For Each line As String In lines
			Dim parts() As String = line.Split(";"c)
			If parts.Length >= 2 Then
				Dim key As String = parts(0)
				Dim val As String = parts(1)

				Select Case key
					Case "Nama"
						nama = val
					Case "ID"
						idAnggota = val
					Case "Umur"
						umur = val
					Case "TglLahir"
						tglLahir = val
					Case "JK"
						jk = val
					Case "Divisi"
						divisi = val
					Case "Email"
						email = val
					Case "Alamat"
						alamat = val
					Case "Telp"
						telp = val
					Case "Peran"
						peran = val
					Case "Bahasa"
						bahasa = val
				End Select
			End If
		Next
	End Sub

End Module
