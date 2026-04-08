<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        pictureProfile = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        lblID = New Label()
        lblNama = New Label()
        lblEmail = New Label()
        lblTelp = New Label()
        lblDivisi = New Label()
        lblPeran = New Label()
        lblJk = New Label()
        tblTglLahir = New Label()
        lblAlamat = New Label()
        lblBahasa = New Label()
        Panel2 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(pictureProfile, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(82, 34)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(96, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(325, 30)
        Label1.TabIndex = 5
        Label1.Text = "Google Developer Student Clubs"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlText
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(803, 84)
        Panel1.TabIndex = 6
        ' 
        ' pictureProfile
        ' 
        pictureProfile.BackColor = SystemColors.ActiveBorder
        pictureProfile.Location = New Point(16, 20)
        pictureProfile.Name = "pictureProfile"
        pictureProfile.Size = New Size(135, 189)
        pictureProfile.SizeMode = PictureBoxSizeMode.Zoom
        pictureProfile.TabIndex = 8
        pictureProfile.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(186, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 17)
        Label2.TabIndex = 9
        Label2.Text = "Nama:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(186, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 17)
        Label3.TabIndex = 10
        Label3.Text = "ID Anggota:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Control
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(497, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 17)
        Label4.TabIndex = 11
        Label4.Text = "Tanggal lahir:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.Control
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(497, 180)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 17)
        Label5.TabIndex = 12
        Label5.Text = "Jenis Kelamin:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.Control
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(497, 123)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 17)
        Label6.TabIndex = 13
        Label6.Text = "Divisi:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.Control
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(187, 211)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 17)
        Label7.TabIndex = 14
        Label7.Text = "No. Telp:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.Control
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(186, 180)
        Label8.Name = "Label8"
        Label8.Size = New Size(43, 17)
        Label8.TabIndex = 15
        Label8.Text = "Email:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.Control
        Label9.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(187, 246)
        Label9.Name = "Label9"
        Label9.Size = New Size(54, 17)
        Label9.TabIndex = 16
        Label9.Text = "Alamat:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.Control
        Label10.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(497, 149)
        Label10.Name = "Label10"
        Label10.Size = New Size(46, 17)
        Label10.TabIndex = 17
        Label10.Text = "Peran:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.Control
        Label11.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(186, 282)
        Label11.Name = "Label11"
        Label11.Size = New Size(145, 17)
        Label11.TabIndex = 18
        Label11.Text = "Bahasa Pemrograman:"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.BackColor = SystemColors.Control
        lblID.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblID.Location = New Point(283, 123)
        lblID.Name = "lblID"
        lblID.Size = New Size(85, 17)
        lblID.TabIndex = 19
        lblID.Text = "ID2409121212"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = SystemColors.Control
        lblNama.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(283, 149)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(193, 17)
        lblNama.TabIndex = 20
        lblNama.Text = "Muhammad Haykal Makhmud"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.BackColor = SystemColors.Control
        lblEmail.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(283, 180)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(156, 17)
        lblEmail.TabIndex = 21
        lblEmail.Text = "email234567@gmail.com"
        ' 
        ' lblTelp
        ' 
        lblTelp.AutoSize = True
        lblTelp.BackColor = SystemColors.Control
        lblTelp.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTelp.Location = New Point(283, 211)
        lblTelp.Name = "lblTelp"
        lblTelp.Size = New Size(100, 17)
        lblTelp.TabIndex = 22
        lblTelp.Text = "0822-5423-2312"
        ' 
        ' lblDivisi
        ' 
        lblDivisi.AutoSize = True
        lblDivisi.BackColor = SystemColors.Control
        lblDivisi.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDivisi.Location = New Point(597, 123)
        lblDivisi.Name = "lblDivisi"
        lblDivisi.Size = New Size(36, 17)
        lblDivisi.TabIndex = 23
        lblDivisi.Text = "Web"
        ' 
        ' lblPeran
        ' 
        lblPeran.AutoSize = True
        lblPeran.BackColor = SystemColors.Control
        lblPeran.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPeran.Location = New Point(597, 149)
        lblPeran.Name = "lblPeran"
        lblPeran.Size = New Size(43, 17)
        lblPeran.TabIndex = 24
        lblPeran.Text = "Ketua"
        ' 
        ' lblJk
        ' 
        lblJk.AutoSize = True
        lblJk.BackColor = SystemColors.Control
        lblJk.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJk.Location = New Point(597, 180)
        lblJk.Name = "lblJk"
        lblJk.Size = New Size(55, 17)
        lblJk.TabIndex = 25
        lblJk.Text = "Laki laki"
        ' 
        ' tblTglLahir
        ' 
        tblTglLahir.AutoSize = True
        tblTglLahir.BackColor = SystemColors.Control
        tblTglLahir.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tblTglLahir.Location = New Point(597, 211)
        tblTglLahir.Name = "tblTglLahir"
        tblTglLahir.Size = New Size(74, 17)
        tblTglLahir.TabIndex = 26
        tblTglLahir.Text = "02/02/2000"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = SystemColors.Control
        lblAlamat.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAlamat.Location = New Point(283, 246)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(160, 17)
        lblAlamat.TabIndex = 27
        lblAlamat.Text = "Jl. berikut di jalan berikut"
        ' 
        ' lblBahasa
        ' 
        lblBahasa.AutoSize = True
        lblBahasa.BackColor = SystemColors.Control
        lblBahasa.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBahasa.Location = New Point(346, 282)
        lblBahasa.Name = "lblBahasa"
        lblBahasa.Size = New Size(253, 17)
        lblBahasa.TabIndex = 28
        lblBahasa.Text = "PHP, Java, JS, TS, Swift, Kotlin, Flutter, Go"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonFace
        Panel2.Controls.Add(pictureProfile)
        Panel2.Location = New Point(12, 103)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(695, 234)
        Panel2.TabIndex = 29
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(719, 349)
        Controls.Add(lblBahasa)
        Controls.Add(lblAlamat)
        Controls.Add(tblTglLahir)
        Controls.Add(lblJk)
        Controls.Add(lblPeran)
        Controls.Add(lblDivisi)
        Controls.Add(lblTelp)
        Controls.Add(lblEmail)
        Controls.Add(lblNama)
        Controls.Add(lblID)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pictureProfile, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pictureProfile As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTelp As Label
    Friend WithEvents lblDivisi As Label
    Friend WithEvents lblPeran As Label
    Friend WithEvents lblJk As Label
    Friend WithEvents tblTglLahir As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblBahasa As Label
    Friend WithEvents Panel2 As Panel
End Class
