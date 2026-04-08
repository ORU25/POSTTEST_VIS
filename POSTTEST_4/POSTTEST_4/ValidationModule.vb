Module ValidationModule
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiMaskedTextBox(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        Else
            ep.SetError(mtb, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cb As ComboBox, pesan As String) As Boolean
        If cb.Text.Trim() = "" Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    Public Function ValidasiRadioButtonGroup(ep As ErrorProvider, ctrl As Control, pesan As String, rbs As RadioButton()) As Boolean
        Dim isChecked As Boolean = False
        For Each rb In rbs
            If rb.Checked Then
                isChecked = True
                Exit For
            End If
        Next

        If Not isChecked Then
            ep.SetError(ctrl, pesan)
            Return False
        Else
            ep.SetError(ctrl, "")
            Return True
        End If
    End Function

    Public Function ValidasiCheckBoxGroup(ep As ErrorProvider, ctrl As Control, pesan As String, cbs As CheckBox()) As Boolean
        Dim isChecked As Boolean = False
        For Each cb In cbs
            If cb.Checked Then
                isChecked = True
                Exit For
            End If
        Next

        If Not isChecked Then
            ep.SetError(ctrl, pesan)
            Return False
        Else
            ep.SetError(ctrl, "")
            Return True
        End If
    End Function
End Module
