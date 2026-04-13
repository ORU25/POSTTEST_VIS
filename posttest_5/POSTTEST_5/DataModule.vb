Imports MySqlConnector

Module DataModule
    Public Function getAllKaryawan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM karyawan"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return dt
    End Function
    Public Function SearchKaryawan(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
            "SELECT * FROM karyawan " & "WHERE nama LIKE @keyword OR nik LIKE @keyword " & "ORDER BY nama ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword &
                    "%")

                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return dt
    End Function

    Public Function getNIK(nik As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM karyawan WHERE nik = @nik"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@nik", nik)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return dt
    End Function

    Public Function nikSudahAda(nik As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM karyawan WHERE nik = @nik"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nik", nik)
                    Dim jumlah As Integer =
                    Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return True
        End Try
    End Function
    Public Function emailSudahAda(email As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM karyawan WHERE email = @email"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@email", email)
                    Dim jumlah As Integer =
                    Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return True
        End Try
    End Function

    Public Function simpanKaraywan(nik As String, nama As String, email As String, hp As String) As Boolean
        Try
            Dim query As String = "INSERT INTO karyawan (nik, nama, email, hp) VALUES (@nik, @nama, @email, @hp)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nik", nik)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@hp", hp)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ubahKaryawan(nik As String, nama As String, email As String, hp As String) As Boolean
        Try
            Dim query As String = "UPDATE karyawan SET nama = @nama, email = @email, hp = @hp WHERE nik = @nik"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nik", nik)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@hp", hp)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function hapusKaryawan(nik As String) As Boolean
        Try
            Dim query As String = "DELETE FROM karyawan WHERE nik = @nik"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nik", nik)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return False
        End Try
    End Function
End Module
