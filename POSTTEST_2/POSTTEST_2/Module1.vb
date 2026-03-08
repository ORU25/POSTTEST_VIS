Module Module1
    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0

    Public Function TambahBuku(judul As String, genre As String) As Boolean
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1
            Return True
        Else
            Return False
        End If
    End Function

    Public Function HapusBuku(judul As String) As Boolean
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0) = judul Then
                For j As Integer = i To jumlahBuku - 2
                    daftarBuku(j, 0) = daftarBuku(j + 1, 0)
                    daftarBuku(j, 1) = daftarBuku(j + 1, 1)
                Next
                jumlahBuku -= 1
                Return True
            End If
        Next
        Return False
    End Function
End Module
