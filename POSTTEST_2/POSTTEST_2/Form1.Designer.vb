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
        GroupBox1 = New GroupBox()
        btnTambah = New Button()
        txtGenre = New TextBox()
        txtJudulTambah = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox3 = New GroupBox()
        btnHapus = New Button()
        txtJudulHapus = New TextBox()
        Label3 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ListBox1 = New ListBox()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(txtJudulTambah)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(14, 25)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(229, 168)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(122, 127)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(91, 89)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(125, 27)
        txtGenre.TabIndex = 5
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.Location = New Point(91, 44)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(125, 27)
        txtJudulTambah.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 20)
        Label2.TabIndex = 1
        Label2.Text = "Genre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnHapus)
        GroupBox3.Controls.Add(txtJudulHapus)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Location = New Point(271, 25)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(229, 168)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(122, 127)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 6
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.Location = New Point(91, 44)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(125, 27)
        txtJudulHapus.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 47)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 2
        Label3.Text = "Judul Buku"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(15, 223)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(485, 204)
        ListBox1.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(518, 450)
        Controls.Add(ListBox1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents ListBox1 As ListBox

End Class
