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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        mnuInputData = New ToolStripMenuItem()
        mnuLihatKartu = New ToolStripMenuItem()
        mnuSimpan = New ToolStripMenuItem()
        mnuBuka = New ToolStripMenuItem()
        mnuKeluar = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        tcDataUtama = New TabPage()
        txtUmur = New TextBox()
        Label10 = New Label()
        cmbDivisi = New ComboBox()
        radioPerempuan = New RadioButton()
        radioLaki = New RadioButton()
        txtId = New TextBox()
        txtNama = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        dtpTanggalLahir = New DateTimePicker()
        Label3 = New Label()
        Label2 = New Label()
        tcKontak = New TabPage()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtxTelp = New MaskedTextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        tcProfile = New TabPage()
        btnSimpan = New Button()
        GroupBox2 = New GroupBox()
        sbSwift = New CheckBox()
        cbKotlin = New CheckBox()
        cbFlutter = New CheckBox()
        cbGo = New CheckBox()
        cbTS = New CheckBox()
        cbJS = New CheckBox()
        cbJava = New CheckBox()
        cbPHP = New CheckBox()
        GroupBox1 = New GroupBox()
        radioAnggota = New RadioButton()
        radioKepala = New RadioButton()
        radioAdmin = New RadioButton()
        radioKetua = New RadioButton()
        btnUpload = New Button()
        picProfile = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        tcDataUtama.SuspendLayout()
        tcKontak.SuspendLayout()
        tcProfile.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuInputData, mnuLihatKartu, mnuSimpan, mnuBuka, mnuKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(446, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuInputData
        ' 
        mnuInputData.Name = "mnuInputData"
        mnuInputData.Size = New Size(74, 20)
        mnuInputData.Text = "Input Data"
        ' 
        ' mnuLihatKartu
        ' 
        mnuLihatKartu.Name = "mnuLihatKartu"
        mnuLihatKartu.Size = New Size(76, 20)
        mnuLihatKartu.Text = "Lihat Kartu"
        ' 
        ' mnuSimpan
        ' 
        mnuSimpan.Name = "mnuSimpan"
        mnuSimpan.Size = New Size(86, 20)
        mnuSimpan.Text = "Simpan Data"
        ' 
        ' mnuBuka
        ' 
        mnuBuka.Name = "mnuBuka"
        mnuBuka.Size = New Size(72, 20)
        mnuBuka.Text = "Buka Data"
        ' 
        ' mnuKeluar
        ' 
        mnuKeluar.Name = "mnuKeluar"
        mnuKeluar.Size = New Size(52, 20)
        mnuKeluar.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tcDataUtama)
        TabControl1.Controls.Add(tcKontak)
        TabControl1.Controls.Add(tcProfile)
        TabControl1.Location = New Point(12, 107)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(422, 332)
        TabControl1.TabIndex = 1
        ' 
        ' tcDataUtama
        ' 
        tcDataUtama.Controls.Add(txtUmur)
        tcDataUtama.Controls.Add(Label10)
        tcDataUtama.Controls.Add(cmbDivisi)
        tcDataUtama.Controls.Add(radioPerempuan)
        tcDataUtama.Controls.Add(radioLaki)
        tcDataUtama.Controls.Add(txtId)
        tcDataUtama.Controls.Add(txtNama)
        tcDataUtama.Controls.Add(Label6)
        tcDataUtama.Controls.Add(Label5)
        tcDataUtama.Controls.Add(Label4)
        tcDataUtama.Controls.Add(dtpTanggalLahir)
        tcDataUtama.Controls.Add(Label3)
        tcDataUtama.Controls.Add(Label2)
        tcDataUtama.Location = New Point(4, 24)
        tcDataUtama.Name = "tcDataUtama"
        tcDataUtama.Padding = New Padding(3)
        tcDataUtama.Size = New Size(414, 304)
        tcDataUtama.TabIndex = 0
        tcDataUtama.Text = "Data Utama"
        tcDataUtama.UseVisualStyleBackColor = True
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(135, 79)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(110, 23)
        txtUmur.TabIndex = 13
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(11, 85)
        Label10.Name = "Label10"
        Label10.Size = New Size(37, 15)
        Label10.TabIndex = 12
        Label10.Text = "Umur"
        ' 
        ' cmbDivisi
        ' 
        cmbDivisi.FormattingEnabled = True
        cmbDivisi.Items.AddRange(New Object() {"Web Dev", "AI Eng", "Cloud Eng", "Mobile Dev", "Devs Ops"})
        cmbDivisi.Location = New Point(135, 186)
        cmbDivisi.Name = "cmbDivisi"
        cmbDivisi.Size = New Size(139, 23)
        cmbDivisi.TabIndex = 11
        ' 
        ' radioPerempuan
        ' 
        radioPerempuan.AutoSize = True
        radioPerempuan.Location = New Point(222, 155)
        radioPerempuan.Name = "radioPerempuan"
        radioPerempuan.Size = New Size(86, 19)
        radioPerempuan.TabIndex = 10
        radioPerempuan.TabStop = True
        radioPerempuan.Text = "Perempuan"
        radioPerempuan.UseVisualStyleBackColor = True
        ' 
        ' radioLaki
        ' 
        radioLaki.AutoSize = True
        radioLaki.Location = New Point(135, 155)
        radioLaki.Name = "radioLaki"
        radioLaki.Size = New Size(70, 19)
        radioLaki.TabIndex = 9
        radioLaki.TabStop = True
        radioLaki.Text = "Laki Laki"
        radioLaki.UseVisualStyleBackColor = True
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(135, 44)
        txtId.Name = "txtId"
        txtId.Size = New Size(200, 23)
        txtId.TabIndex = 8
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(135, 15)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(200, 23)
        txtNama.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 189)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 15)
        Label6.TabIndex = 5
        Label6.Text = "Divisi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(11, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 15)
        Label5.TabIndex = 4
        Label5.Text = "Jenis Kelamin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(11, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 15)
        Label4.TabIndex = 3
        Label4.Text = "Tanggal Lahir"
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(135, 112)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(200, 23)
        dtpTanggalLahir.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 15)
        Label3.TabIndex = 1
        Label3.Text = "ID Anggota"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 0
        Label2.Text = "Nama"
        ' 
        ' tcKontak
        ' 
        tcKontak.Controls.Add(txtAlamat)
        tcKontak.Controls.Add(txtEmail)
        tcKontak.Controls.Add(mtxTelp)
        tcKontak.Controls.Add(Label9)
        tcKontak.Controls.Add(Label8)
        tcKontak.Controls.Add(Label7)
        tcKontak.Location = New Point(4, 24)
        tcKontak.Name = "tcKontak"
        tcKontak.Padding = New Padding(3)
        tcKontak.Size = New Size(414, 304)
        tcKontak.TabIndex = 1
        tcKontak.Text = "Kontak & Info"
        tcKontak.UseVisualStyleBackColor = True
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(134, 93)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(195, 23)
        txtAlamat.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(134, 54)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(195, 23)
        txtEmail.TabIndex = 5
        ' 
        ' mtxTelp
        ' 
        mtxTelp.Location = New Point(134, 15)
        mtxTelp.Mask = "0000-0000-0000"
        mtxTelp.Name = "mtxTelp"
        mtxTelp.Size = New Size(92, 23)
        mtxTelp.TabIndex = 4
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(11, 96)
        Label9.Name = "Label9"
        Label9.Size = New Size(45, 15)
        Label9.TabIndex = 3
        Label9.Text = "Alamat"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(11, 57)
        Label8.Name = "Label8"
        Label8.Size = New Size(36, 15)
        Label8.TabIndex = 2
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(11, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 15)
        Label7.TabIndex = 1
        Label7.Text = "No Telepon"
        ' 
        ' tcProfile
        ' 
        tcProfile.Controls.Add(btnSimpan)
        tcProfile.Controls.Add(GroupBox2)
        tcProfile.Controls.Add(GroupBox1)
        tcProfile.Controls.Add(btnUpload)
        tcProfile.Controls.Add(picProfile)
        tcProfile.Location = New Point(4, 24)
        tcProfile.Name = "tcProfile"
        tcProfile.Padding = New Padding(3)
        tcProfile.Size = New Size(414, 304)
        tcProfile.TabIndex = 2
        tcProfile.Text = "Profil & Aktivitas"
        tcProfile.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(235, 261)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(164, 31)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "SImpan dan Cetak Kartu"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(sbSwift)
        GroupBox2.Controls.Add(cbKotlin)
        GroupBox2.Controls.Add(cbFlutter)
        GroupBox2.Controls.Add(cbGo)
        GroupBox2.Controls.Add(cbTS)
        GroupBox2.Controls.Add(cbJS)
        GroupBox2.Controls.Add(cbJava)
        GroupBox2.Controls.Add(cbPHP)
        GroupBox2.Location = New Point(147, 102)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(252, 145)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Bahasa Pemrograman"
        ' 
        ' sbSwift
        ' 
        sbSwift.AutoSize = True
        sbSwift.Location = New Point(136, 109)
        sbSwift.Name = "sbSwift"
        sbSwift.Size = New Size(52, 19)
        sbSwift.TabIndex = 7
        sbSwift.Text = "Swift"
        sbSwift.UseVisualStyleBackColor = True
        ' 
        ' cbKotlin
        ' 
        cbKotlin.AutoSize = True
        cbKotlin.Location = New Point(136, 84)
        cbKotlin.Name = "cbKotlin"
        cbKotlin.Size = New Size(57, 19)
        cbKotlin.TabIndex = 6
        cbKotlin.Text = "Kotlin"
        cbKotlin.UseVisualStyleBackColor = True
        ' 
        ' cbFlutter
        ' 
        cbFlutter.AutoSize = True
        cbFlutter.Location = New Point(136, 59)
        cbFlutter.Name = "cbFlutter"
        cbFlutter.Size = New Size(60, 19)
        cbFlutter.TabIndex = 5
        cbFlutter.Text = "Flutter"
        cbFlutter.UseVisualStyleBackColor = True
        ' 
        ' cbGo
        ' 
        cbGo.AutoSize = True
        cbGo.Location = New Point(136, 34)
        cbGo.Name = "cbGo"
        cbGo.Size = New Size(41, 19)
        cbGo.TabIndex = 4
        cbGo.Text = "Go"
        cbGo.UseVisualStyleBackColor = True
        ' 
        ' cbTS
        ' 
        cbTS.AutoSize = True
        cbTS.Location = New Point(16, 109)
        cbTS.Name = "cbTS"
        cbTS.Size = New Size(81, 19)
        cbTS.TabIndex = 3
        cbTS.Text = "TypeScript"
        cbTS.UseVisualStyleBackColor = True
        ' 
        ' cbJS
        ' 
        cbJS.AutoSize = True
        cbJS.Location = New Point(16, 84)
        cbJS.Name = "cbJS"
        cbJS.Size = New Size(78, 19)
        cbJS.TabIndex = 2
        cbJS.Text = "JavaScript"
        cbJS.UseVisualStyleBackColor = True
        ' 
        ' cbJava
        ' 
        cbJava.AutoSize = True
        cbJava.Location = New Point(16, 59)
        cbJava.Name = "cbJava"
        cbJava.Size = New Size(48, 19)
        cbJava.TabIndex = 1
        cbJava.Text = "Java"
        cbJava.UseVisualStyleBackColor = True
        ' 
        ' cbPHP
        ' 
        cbPHP.AutoSize = True
        cbPHP.Location = New Point(16, 34)
        cbPHP.Name = "cbPHP"
        cbPHP.Size = New Size(49, 19)
        cbPHP.TabIndex = 0
        cbPHP.Text = "PHP"
        cbPHP.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radioAnggota)
        GroupBox1.Controls.Add(radioKepala)
        GroupBox1.Controls.Add(radioAdmin)
        GroupBox1.Controls.Add(radioKetua)
        GroupBox1.Location = New Point(146, 11)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(253, 78)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Peran"
        ' 
        ' radioAnggota
        ' 
        radioAnggota.AutoSize = True
        radioAnggota.Location = New Point(137, 47)
        radioAnggota.Name = "radioAnggota"
        radioAnggota.Size = New Size(71, 19)
        radioAnggota.TabIndex = 3
        radioAnggota.TabStop = True
        radioAnggota.Text = "Anggota"
        radioAnggota.UseVisualStyleBackColor = True
        ' 
        ' radioKepala
        ' 
        radioKepala.AutoSize = True
        radioKepala.Location = New Point(17, 47)
        radioKepala.Name = "radioKepala"
        radioKepala.Size = New Size(91, 19)
        radioKepala.TabIndex = 2
        radioKepala.TabStop = True
        radioKepala.Text = "Kepala Divisi"
        radioKepala.UseVisualStyleBackColor = True
        ' 
        ' radioAdmin
        ' 
        radioAdmin.AutoSize = True
        radioAdmin.Location = New Point(137, 22)
        radioAdmin.Name = "radioAdmin"
        radioAdmin.Size = New Size(61, 19)
        radioAdmin.TabIndex = 1
        radioAdmin.TabStop = True
        radioAdmin.Text = "Admin"
        radioAdmin.UseVisualStyleBackColor = True
        ' 
        ' radioKetua
        ' 
        radioKetua.AutoSize = True
        radioKetua.Location = New Point(17, 22)
        radioKetua.Name = "radioKetua"
        radioKetua.Size = New Size(55, 19)
        radioKetua.TabIndex = 0
        radioKetua.TabStop = True
        radioKetua.Text = "Ketua"
        radioKetua.UseVisualStyleBackColor = True
        ' 
        ' btnUpload
        ' 
        btnUpload.Location = New Point(31, 194)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(75, 23)
        btnUpload.TabIndex = 1
        btnUpload.Text = "Browse"
        btnUpload.UseVisualStyleBackColor = True
        ' 
        ' picProfile
        ' 
        picProfile.BackColor = SystemColors.Control
        picProfile.Location = New Point(11, 15)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(119, 173)
        picProfile.SizeMode = PictureBoxSizeMode.Zoom
        picProfile.TabIndex = 0
        picProfile.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(100, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(325, 30)
        Label1.TabIndex = 2
        Label1.Text = "Google Developer Student Clubs"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 53)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(82, 34)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "z"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(446, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        tcDataUtama.ResumeLayout(False)
        tcDataUtama.PerformLayout()
        tcKontak.ResumeLayout(False)
        tcKontak.PerformLayout()
        tcProfile.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuInputData As ToolStripMenuItem
    Friend WithEvents mnuLihatKartu As ToolStripMenuItem
    Friend WithEvents mnuSimpan As ToolStripMenuItem
    Friend WithEvents mnuBuka As ToolStripMenuItem
    Friend WithEvents mnuKeluar As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tcDataUtama As TabPage
    Friend WithEvents tcKontak As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tcProfile As TabPage
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbDivisi As ComboBox
    Friend WithEvents radioPerempuan As RadioButton
    Friend WithEvents radioLaki As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtxTelp As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radioAnggota As RadioButton
    Friend WithEvents radioKepala As RadioButton
    Friend WithEvents radioAdmin As RadioButton
    Friend WithEvents radioKetua As RadioButton
    Friend WithEvents sbSwift As CheckBox
    Friend WithEvents cbKotlin As CheckBox
    Friend WithEvents cbFlutter As CheckBox
    Friend WithEvents cbGo As CheckBox
    Friend WithEvents cbTS As CheckBox
    Friend WithEvents cbJS As CheckBox
    Friend WithEvents cbJava As CheckBox
    Friend WithEvents cbPHP As CheckBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents Label10 As Label

End Class
