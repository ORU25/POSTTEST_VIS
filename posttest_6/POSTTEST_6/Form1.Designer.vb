<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNama = New TextBox()
        txtNIK = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvKaryawan = New DataGridView()
        txtEmail = New TextBox()
        Label4 = New Label()
        mtbHP = New MaskedTextBox()
        txtCari = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        btnForm2 = New Button()
        CType(dgvKaryawan, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(26, 15)
        Label2.TabIndex = 1
        Label2.Text = "NIK"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(16, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(129, 52)
        txtNama.Margin = New Padding(3, 2, 3, 2)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(445, 23)
        txtNama.TabIndex = 3
        ' 
        ' txtNIK
        ' 
        txtNIK.Location = New Point(129, 21)
        txtNIK.Margin = New Padding(3, 2, 3, 2)
        txtNIK.Name = "txtNIK"
        txtNIK.Size = New Size(445, 23)
        txtNIK.TabIndex = 4
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(299, 158)
        btnSimpan.Margin = New Padding(3, 2, 3, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(65, 26)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(370, 158)
        btnUbah.Margin = New Padding(3, 2, 3, 2)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(65, 26)
        btnUbah.TabIndex = 7
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(441, 158)
        btnHapus.Margin = New Padding(3, 2, 3, 2)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(65, 26)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(512, 158)
        btnBatal.Margin = New Padding(3, 2, 3, 2)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(65, 26)
        btnBatal.TabIndex = 9
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvKaryawan
        ' 
        dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKaryawan.Location = New Point(16, 244)
        dgvKaryawan.Margin = New Padding(3, 2, 3, 2)
        dgvKaryawan.Name = "dgvKaryawan"
        dgvKaryawan.RowHeadersWidth = 51
        dgvKaryawan.Size = New Size(558, 186)
        dgvKaryawan.TabIndex = 10
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(129, 86)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(445, 23)
        txtEmail.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 124)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 12
        Label4.Text = "No. HP"
        ' 
        ' mtbHP
        ' 
        mtbHP.Location = New Point(129, 121)
        mtbHP.Mask = "000000000000"
        mtbHP.Name = "mtbHP"
        mtbHP.Size = New Size(178, 23)
        mtbHP.TabIndex = 13
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(16, 203)
        txtCari.Margin = New Padding(3, 2, 3, 2)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Cari nik atau nama karyawan "
        txtCari.Size = New Size(219, 23)
        txtCari.TabIndex = 15
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnForm2
        ' 
        btnForm2.Location = New Point(481, 203)
        btnForm2.Margin = New Padding(3, 2, 3, 2)
        btnForm2.Name = "btnForm2"
        btnForm2.Size = New Size(93, 26)
        btnForm2.TabIndex = 16
        btnForm2.Text = "Tanggungan"
        btnForm2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(607, 449)
        Controls.Add(btnForm2)
        Controls.Add(txtCari)
        Controls.Add(mtbHP)
        Controls.Add(Label4)
        Controls.Add(txtEmail)
        Controls.Add(dgvKaryawan)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtNIK)
        Controls.Add(txtNama)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Sistem Manajemen Data Karyawan PT.XYZ"
        CType(dgvKaryawan, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIK As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvKaryawan As DataGridView
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mtbHP As MaskedTextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnForm2 As Button

End Class
