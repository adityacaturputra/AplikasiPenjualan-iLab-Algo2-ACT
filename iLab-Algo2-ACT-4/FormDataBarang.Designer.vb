<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataBarang
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button_Tutup = New System.Windows.Forms.Button()
        Me.Button_Hapus = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Input = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 250)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(318, 150)
        Me.DataGridView1.TabIndex = 27
        '
        'Button_Tutup
        '
        Me.Button_Tutup.Location = New System.Drawing.Point(255, 208)
        Me.Button_Tutup.Name = "Button_Tutup"
        Me.Button_Tutup.Size = New System.Drawing.Size(75, 23)
        Me.Button_Tutup.TabIndex = 26
        Me.Button_Tutup.Text = "Tutup"
        Me.Button_Tutup.UseVisualStyleBackColor = True
        '
        'Button_Hapus
        '
        Me.Button_Hapus.Location = New System.Drawing.Point(174, 208)
        Me.Button_Hapus.Name = "Button_Hapus"
        Me.Button_Hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_Hapus.TabIndex = 25
        Me.Button_Hapus.Text = "Hapus"
        Me.Button_Hapus.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.Location = New System.Drawing.Point(93, 208)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit.TabIndex = 24
        Me.Button_Edit.Text = "Edit"
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'Button_Input
        '
        Me.Button_Input.Location = New System.Drawing.Point(12, 208)
        Me.Button_Input.Name = "Button_Input"
        Me.Button_Input.Size = New System.Drawing.Size(75, 23)
        Me.Button_Input.TabIndex = 23
        Me.Button_Input.Text = "Input"
        Me.Button_Input.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(128, 137)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 22
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(128, 113)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 21
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(128, 88)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 20
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Jumlah Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Harga Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Kode Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Form Data Pelanggan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Satuan"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(128, 162)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 29
        '
        'FormDataBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 419)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button_Tutup)
        Me.Controls.Add(Me.Button_Hapus)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.Button_Input)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDataBarang"
        Me.Text = "FormDataBarang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button_Tutup As Button
    Friend WithEvents Button_Hapus As Button
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Input As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
