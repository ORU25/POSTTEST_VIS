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
        lblIpSemester = New Label()
        lblIpk = New Label()
        txtIpSemester = New TextBox()
        txtIpk = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        lblPredikat = New Label()
        lblSemesterCount = New Label()
        txtSemesterCount = New TextBox()
        SuspendLayout()
        ' 
        ' lblIpSemester
        ' 
        lblIpSemester.AutoSize = True
        lblIpSemester.Location = New Point(29, 38)
        lblIpSemester.Name = "lblIpSemester"
        lblIpSemester.Size = New Size(86, 20)
        lblIpSemester.TabIndex = 0
        lblIpSemester.Text = "IP Semester"
        ' 
        ' lblIpk
        ' 
        lblIpk.AutoSize = True
        lblIpk.Location = New Point(29, 174)
        lblIpk.Name = "lblIpk"
        lblIpk.Size = New Size(89, 20)
        lblIpk.TabIndex = 1
        lblIpk.Text = "IP Kumulatif"
        ' 
        ' txtIpSemester
        ' 
        txtIpSemester.Location = New Point(162, 37)
        txtIpSemester.Name = "txtIpSemester"
        txtIpSemester.Size = New Size(170, 27)
        txtIpSemester.TabIndex = 2
        ' 
        ' txtIpk
        ' 
        txtIpk.Location = New Point(162, 173)
        txtIpk.Name = "txtIpk"
        txtIpk.Size = New Size(170, 27)
        txtIpk.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(162, 86)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(82, 36)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(250, 86)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(82, 36)
        btnReset.TabIndex = 5
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(162, 217)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(0, 20)
        lblPredikat.TabIndex = 6
        ' 
        ' lblSemesterCount
        ' 
        lblSemesterCount.AutoSize = True
        lblSemesterCount.Location = New Point(29, 140)
        lblSemesterCount.Name = "lblSemesterCount"
        lblSemesterCount.Size = New Size(121, 20)
        lblSemesterCount.TabIndex = 7
        lblSemesterCount.Text = "Banyak Semester"
        ' 
        ' txtSemesterCount
        ' 
        txtSemesterCount.Location = New Point(162, 137)
        txtSemesterCount.Name = "txtSemesterCount"
        txtSemesterCount.Size = New Size(82, 27)
        txtSemesterCount.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(375, 277)
        Controls.Add(txtSemesterCount)
        Controls.Add(lblSemesterCount)
        Controls.Add(lblPredikat)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIpk)
        Controls.Add(txtIpSemester)
        Controls.Add(lblIpk)
        Controls.Add(lblIpSemester)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIpSemester As Label
    Friend WithEvents lblIpk As Label
    Friend WithEvents txtIpSemester As TextBox
    Friend WithEvents txtIpk As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblPredikat As Label
    Friend WithEvents lblSemesterCount As Label
    Friend WithEvents txtSemesterCount As TextBox

End Class
