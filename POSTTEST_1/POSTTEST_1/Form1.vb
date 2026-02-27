Public Class Form1
    Dim ipSemester As Double
    Dim ipk As Double = 0
    Dim semesterCount As Integer
    Dim terValidasi As Boolean = False

    Private Sub ValidateInput()
        If Double.TryParse(txtIpSemester.Text, ipSemester) And ipSemester <= 4 And ipSemester >= 0 Then
            ' angka berhasil dibaca
            terValidasi = True
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ValidateInput()

        If terValidasi Then
            terValidasi = False
            semesterCount += 1
            ipk = ipk + ipSemester
            txtIpk.Text = (ipk / semesterCount).ToString("0.00")
            txtSemesterCount.Text = semesterCount.ToString()
            If ipk / semesterCount >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            ElseIf ipk / semesterCount >= 2.76 And ipk / semesterCount <= 3.0 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk / semesterCount >= 2.0 And ipk / semesterCount <= 2.75 Then
                lblPredikat.Text = "Cukup"
            Else
                lblPredikat.Text = "Kurang Memuaskan"
            End If
        Else
            MessageBox.Show("Input harus angka dan harus dari 0 - 4!")
            txtIpSemester.Text = ""
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        semesterCount = 0
        ipk = 0
        txtIpk.Text = ""
        txtIpSemester.Text = ""
        lblPredikat.Text = ""
        txtSemesterCount.Text = ""
    End Sub

End Class
