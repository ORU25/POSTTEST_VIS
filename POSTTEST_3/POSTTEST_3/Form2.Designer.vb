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
        picProfile = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        lblNama = New Label()
        lblUmur = New Label()
        lblTelp = New Label()
        lblLahir = New Label()
        lblAlamat = New Label()
        lblJk = New Label()
        lblHobby = New Label()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picProfile
        ' 
        picProfile.BackgroundImageLayout = ImageLayout.Zoom
        picProfile.Location = New Point(0, 178)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(277, 306)
        picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        picProfile.TabIndex = 0
        picProfile.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(301, 202)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 21)
        Label1.TabIndex = 1
        Label1.Text = "Nama:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(303, 232)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 21)
        Label2.TabIndex = 2
        Label2.Text = "Umur:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(303, 264)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 21)
        Label3.TabIndex = 3
        Label3.Text = "No. Telp:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(303, 330)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 21)
        Label4.TabIndex = 4
        Label4.Text = "Alamat:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(301, 296)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 21)
        Label5.TabIndex = 5
        Label5.Text = "Tanggal Lahir:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(303, 368)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 21)
        Label6.TabIndex = 6
        Label6.Text = "Jenis Kelamin:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(303, 401)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 21)
        Label7.TabIndex = 7
        Label7.Text = "Hobby:"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(429, 202)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(52, 21)
        lblNama.TabIndex = 8
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.Transparent
        lblUmur.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUmur.Location = New Point(429, 232)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(50, 21)
        lblUmur.TabIndex = 9
        lblUmur.Text = "Umur"
        ' 
        ' lblTelp
        ' 
        lblTelp.AutoSize = True
        lblTelp.BackColor = Color.Transparent
        lblTelp.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTelp.Location = New Point(431, 264)
        lblTelp.Name = "lblTelp"
        lblTelp.Size = New Size(37, 21)
        lblTelp.TabIndex = 10
        lblTelp.Text = "Telp"
        ' 
        ' lblLahir
        ' 
        lblLahir.AutoSize = True
        lblLahir.BackColor = Color.Transparent
        lblLahir.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLahir.Location = New Point(431, 296)
        lblLahir.Name = "lblLahir"
        lblLahir.Size = New Size(68, 21)
        lblLahir.TabIndex = 11
        lblLahir.Text = "Tgl Lahir"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAlamat.Location = New Point(431, 330)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(59, 21)
        lblAlamat.TabIndex = 12
        lblAlamat.Text = "Alamat"
        ' 
        ' lblJk
        ' 
        lblJk.AutoSize = True
        lblJk.BackColor = Color.Transparent
        lblJk.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJk.Location = New Point(431, 368)
        lblJk.Name = "lblJk"
        lblJk.Size = New Size(24, 21)
        lblJk.TabIndex = 13
        lblJk.Text = "Jk"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.BackColor = Color.Transparent
        lblHobby.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHobby.Location = New Point(431, 401)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(56, 21)
        lblHobby.TabIndex = 14
        lblHobby.Text = "Hobby"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(758, 478)
        Controls.Add(lblHobby)
        Controls.Add(lblJk)
        Controls.Add(lblAlamat)
        Controls.Add(lblLahir)
        Controls.Add(lblTelp)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(picProfile)
        Name = "Form2"
        Text = "Form2"
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picProfile As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTelp As Label
    Friend WithEvents lblLahir As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblJk As Label
    Friend WithEvents lblHobby As Label
End Class
