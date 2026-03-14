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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        picProfile = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        grpKelamin = New GroupBox()
        radioPerempuan = New RadioButton()
        radioLakilaki = New RadioButton()
        grpHobby = New GroupBox()
        cbBasket = New CheckBox()
        cbBerenang = New CheckBox()
        cbMemasak = New CheckBox()
        cbMenari = New CheckBox()
        cbMelukis = New CheckBox()
        cbMenyanyi = New CheckBox()
        cbGaming = New CheckBox()
        dbMancing = New CheckBox()
        cbMenulis = New CheckBox()
        cbBacaBuku = New CheckBox()
        btnUpload = New Button()
        btnCetak = New Button()
        txtNama = New TextBox()
        txtTelp = New TextBox()
        txtAlamat = New TextBox()
        txtUmur = New TextBox()
        dtpTglLahir = New DateTimePicker()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        grpKelamin.SuspendLayout()
        grpHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' picProfile
        ' 
        picProfile.BackColor = SystemColors.Control
        picProfile.Location = New Point(18, 133)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(150, 200)
        picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        picProfile.TabIndex = 0
        picProfile.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(191, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 21)
        Label1.TabIndex = 1
        Label1.Text = "Nama:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonHighlight
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(455, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 21)
        Label2.TabIndex = 2
        Label2.Text = "Umur:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonHighlight
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(191, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 21)
        Label3.TabIndex = 3
        Label3.Text = "No. Telp:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonHighlight
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(455, 173)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 21)
        Label5.TabIndex = 5
        Label5.Text = "Tgl. Lahir:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ButtonHighlight
        Label6.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(191, 216)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 21)
        Label6.TabIndex = 6
        Label6.Text = "Alamat:"
        ' 
        ' grpKelamin
        ' 
        grpKelamin.BackColor = SystemColors.ButtonHighlight
        grpKelamin.Controls.Add(radioPerempuan)
        grpKelamin.Controls.Add(radioLakilaki)
        grpKelamin.Location = New Point(191, 264)
        grpKelamin.Name = "grpKelamin"
        grpKelamin.Size = New Size(246, 163)
        grpKelamin.TabIndex = 7
        grpKelamin.TabStop = False
        grpKelamin.Text = "Jenis Kelamin"
        ' 
        ' radioPerempuan
        ' 
        radioPerempuan.AutoSize = True
        radioPerempuan.Location = New Point(16, 65)
        radioPerempuan.Name = "radioPerempuan"
        radioPerempuan.Size = New Size(86, 19)
        radioPerempuan.TabIndex = 1
        radioPerempuan.TabStop = True
        radioPerempuan.Text = "Perempuan"
        radioPerempuan.UseVisualStyleBackColor = True
        ' 
        ' radioLakilaki
        ' 
        radioLakilaki.AutoSize = True
        radioLakilaki.Location = New Point(16, 33)
        radioLakilaki.Name = "radioLakilaki"
        radioLakilaki.Size = New Size(72, 19)
        radioLakilaki.TabIndex = 0
        radioLakilaki.TabStop = True
        radioLakilaki.Text = "Laki-Laki"
        radioLakilaki.UseVisualStyleBackColor = True
        ' 
        ' grpHobby
        ' 
        grpHobby.BackColor = SystemColors.ButtonHighlight
        grpHobby.Controls.Add(cbBasket)
        grpHobby.Controls.Add(cbBerenang)
        grpHobby.Controls.Add(cbMemasak)
        grpHobby.Controls.Add(cbMenari)
        grpHobby.Controls.Add(cbMelukis)
        grpHobby.Controls.Add(cbMenyanyi)
        grpHobby.Controls.Add(cbGaming)
        grpHobby.Controls.Add(dbMancing)
        grpHobby.Controls.Add(cbMenulis)
        grpHobby.Controls.Add(cbBacaBuku)
        grpHobby.Location = New Point(466, 264)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(231, 163)
        grpHobby.TabIndex = 8
        grpHobby.TabStop = False
        grpHobby.Text = "Hobby"
        ' 
        ' cbBasket
        ' 
        cbBasket.AutoSize = True
        cbBasket.Location = New Point(134, 133)
        cbBasket.Name = "cbBasket"
        cbBasket.Size = New Size(60, 19)
        cbBasket.TabIndex = 9
        cbBasket.Text = "Basket"
        cbBasket.UseVisualStyleBackColor = True
        ' 
        ' cbBerenang
        ' 
        cbBerenang.AutoSize = True
        cbBerenang.Location = New Point(134, 108)
        cbBerenang.Name = "cbBerenang"
        cbBerenang.Size = New Size(76, 19)
        cbBerenang.TabIndex = 8
        cbBerenang.Text = "Berenang"
        cbBerenang.UseVisualStyleBackColor = True
        ' 
        ' cbMemasak
        ' 
        cbMemasak.AutoSize = True
        cbMemasak.Location = New Point(134, 84)
        cbMemasak.Name = "cbMemasak"
        cbMemasak.Size = New Size(77, 19)
        cbMemasak.TabIndex = 7
        cbMemasak.Text = "Memasak"
        cbMemasak.UseVisualStyleBackColor = True
        ' 
        ' cbMenari
        ' 
        cbMenari.AutoSize = True
        cbMenari.Location = New Point(134, 59)
        cbMenari.Name = "cbMenari"
        cbMenari.Size = New Size(63, 19)
        cbMenari.TabIndex = 6
        cbMenari.Text = "Menari"
        cbMenari.UseVisualStyleBackColor = True
        ' 
        ' cbMelukis
        ' 
        cbMelukis.AutoSize = True
        cbMelukis.Location = New Point(134, 34)
        cbMelukis.Name = "cbMelukis"
        cbMelukis.Size = New Size(67, 19)
        cbMelukis.TabIndex = 5
        cbMelukis.Text = "Melukis"
        cbMelukis.UseVisualStyleBackColor = True
        ' 
        ' cbMenyanyi
        ' 
        cbMenyanyi.AutoSize = True
        cbMenyanyi.Location = New Point(12, 133)
        cbMenyanyi.Name = "cbMenyanyi"
        cbMenyanyi.Size = New Size(78, 19)
        cbMenyanyi.TabIndex = 4
        cbMenyanyi.Text = "Menyanyi"
        cbMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(12, 108)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(68, 19)
        cbGaming.TabIndex = 3
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' dbMancing
        ' 
        dbMancing.AutoSize = True
        dbMancing.Location = New Point(12, 83)
        dbMancing.Name = "dbMancing"
        dbMancing.Size = New Size(73, 19)
        dbMancing.TabIndex = 2
        dbMancing.Text = "Mancing"
        dbMancing.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Location = New Point(12, 58)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(68, 19)
        cbMenulis.TabIndex = 1
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbBacaBuku
        ' 
        cbBacaBuku.AutoSize = True
        cbBacaBuku.Location = New Point(12, 33)
        cbBacaBuku.Name = "cbBacaBuku"
        cbBacaBuku.Size = New Size(81, 19)
        cbBacaBuku.TabIndex = 0
        cbBacaBuku.Text = "Baca Buku"
        cbBacaBuku.UseVisualStyleBackColor = True
        ' 
        ' btnUpload
        ' 
        btnUpload.Location = New Point(18, 344)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(75, 23)
        btnUpload.TabIndex = 9
        btnUpload.Text = "Browse"
        btnUpload.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.Goldenrod
        btnCetak.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCetak.ForeColor = SystemColors.ControlText
        btnCetak.Location = New Point(18, 385)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(144, 42)
        btnCetak.TabIndex = 10
        btnCetak.Text = "CETAK KARTU"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(265, 135)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(172, 23)
        txtNama.TabIndex = 11
        ' 
        ' txtTelp
        ' 
        txtTelp.Location = New Point(265, 173)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(172, 23)
        txtTelp.TabIndex = 12
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(265, 214)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(432, 23)
        txtAlamat.TabIndex = 13
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(538, 135)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(159, 23)
        txtUmur.TabIndex = 14
        ' 
        ' dtpTglLahir
        ' 
        dtpTglLahir.Location = New Point(538, 173)
        dtpTglLahir.Name = "dtpTglLahir"
        dtpTglLahir.Size = New Size(159, 23)
        dtpTglLahir.TabIndex = 15
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(712, 447)
        Controls.Add(dtpTglLahir)
        Controls.Add(txtUmur)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelp)
        Controls.Add(txtNama)
        Controls.Add(btnCetak)
        Controls.Add(btnUpload)
        Controls.Add(grpHobby)
        Controls.Add(grpKelamin)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(picProfile)
        Name = "Form1"
        Text = "Form1"
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        grpKelamin.ResumeLayout(False)
        grpKelamin.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picProfile As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents grpKelamin As GroupBox
    Friend WithEvents radioPerempuan As RadioButton
    Friend WithEvents radioLakilaki As RadioButton
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbBacaBuku As CheckBox
    Friend WithEvents dbMancing As CheckBox
    Friend WithEvents cbMenari As CheckBox
    Friend WithEvents cbMelukis As CheckBox
    Friend WithEvents cbMenyanyi As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbBasket As CheckBox
    Friend WithEvents cbBerenang As CheckBox
    Friend WithEvents cbMemasak As CheckBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents dtpTglLahir As DateTimePicker

End Class
