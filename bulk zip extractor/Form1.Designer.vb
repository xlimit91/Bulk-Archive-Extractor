<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.OFD_Zip = New System.Windows.Forms.OpenFileDialog()
        Me.btn_open = New System.Windows.Forms.Button()
        Me.lbx_zip_paths = New System.Windows.Forms.ListBox()
        Me.lbx_zip_files = New System.Windows.Forms.ListBox()
        Me.pnl_bar_line = New System.Windows.Forms.Panel()
        Me.pnl_bar = New System.Windows.Forms.Panel()
        Me.lbl_fraction = New System.Windows.Forms.Label()
        Me.btn_set_zip = New System.Windows.Forms.Button()
        Me.btn_set_rar = New System.Windows.Forms.Button()
        Me.btn_set_7z = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_out_7z = New System.Windows.Forms.Button()
        Me.btn_out_rar = New System.Windows.Forms.Button()
        Me.btn_out_zip = New System.Windows.Forms.Button()
        Me.btn_out_folder = New System.Windows.Forms.Button()
        Me.brn_convert = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.pnl_bar_line.SuspendLayout()
        Me.SuspendLayout()
        '
        'OFD_Zip
        '
        Me.OFD_Zip.Filter = "Zip Files|*zip"
        Me.OFD_Zip.Multiselect = True
        '
        'btn_open
        '
        Me.btn_open.Location = New System.Drawing.Point(12, 12)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(120, 23)
        Me.btn_open.TabIndex = 0
        Me.btn_open.Text = "OPEN"
        Me.btn_open.UseVisualStyleBackColor = True
        '
        'lbx_zip_paths
        '
        Me.lbx_zip_paths.FormattingEnabled = True
        Me.lbx_zip_paths.HorizontalScrollbar = True
        Me.lbx_zip_paths.Location = New System.Drawing.Point(12, 41)
        Me.lbx_zip_paths.Name = "lbx_zip_paths"
        Me.lbx_zip_paths.Size = New System.Drawing.Size(120, 95)
        Me.lbx_zip_paths.TabIndex = 1
        '
        'lbx_zip_files
        '
        Me.lbx_zip_files.FormattingEnabled = True
        Me.lbx_zip_files.HorizontalScrollbar = True
        Me.lbx_zip_files.Location = New System.Drawing.Point(12, 171)
        Me.lbx_zip_files.Name = "lbx_zip_files"
        Me.lbx_zip_files.Size = New System.Drawing.Size(120, 95)
        Me.lbx_zip_files.TabIndex = 2
        '
        'pnl_bar_line
        '
        Me.pnl_bar_line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_bar_line.Controls.Add(Me.pnl_bar)
        Me.pnl_bar_line.Location = New System.Drawing.Point(12, 272)
        Me.pnl_bar_line.Name = "pnl_bar_line"
        Me.pnl_bar_line.Size = New System.Drawing.Size(200, 50)
        Me.pnl_bar_line.TabIndex = 3
        '
        'pnl_bar
        '
        Me.pnl_bar.BackColor = System.Drawing.Color.Lime
        Me.pnl_bar.Location = New System.Drawing.Point(0, 0)
        Me.pnl_bar.Name = "pnl_bar"
        Me.pnl_bar.Size = New System.Drawing.Size(76, 50)
        Me.pnl_bar.TabIndex = 0
        '
        'lbl_fraction
        '
        Me.lbl_fraction.AutoSize = True
        Me.lbl_fraction.Location = New System.Drawing.Point(12, 326)
        Me.lbl_fraction.Name = "lbl_fraction"
        Me.lbl_fraction.Size = New System.Drawing.Size(0, 13)
        Me.lbl_fraction.TabIndex = 1
        '
        'btn_set_zip
        '
        Me.btn_set_zip.Location = New System.Drawing.Point(138, 12)
        Me.btn_set_zip.Name = "btn_set_zip"
        Me.btn_set_zip.Size = New System.Drawing.Size(53, 23)
        Me.btn_set_zip.TabIndex = 5
        Me.btn_set_zip.Text = "ZIP"
        Me.btn_set_zip.UseVisualStyleBackColor = True
        '
        'btn_set_rar
        '
        Me.btn_set_rar.Location = New System.Drawing.Point(197, 12)
        Me.btn_set_rar.Name = "btn_set_rar"
        Me.btn_set_rar.Size = New System.Drawing.Size(53, 23)
        Me.btn_set_rar.TabIndex = 6
        Me.btn_set_rar.Text = "RAR"
        Me.btn_set_rar.UseVisualStyleBackColor = True
        '
        'btn_set_7z
        '
        Me.btn_set_7z.Location = New System.Drawing.Point(256, 12)
        Me.btn_set_7z.Name = "btn_set_7z"
        Me.btn_set_7z.Size = New System.Drawing.Size(53, 23)
        Me.btn_set_7z.TabIndex = 7
        Me.btn_set_7z.Text = "7Z"
        Me.btn_set_7z.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(315, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "No"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'btn_out_7z
        '
        Me.btn_out_7z.Location = New System.Drawing.Point(256, 171)
        Me.btn_out_7z.Name = "btn_out_7z"
        Me.btn_out_7z.Size = New System.Drawing.Size(53, 23)
        Me.btn_out_7z.TabIndex = 11
        Me.btn_out_7z.Text = "7Z"
        Me.btn_out_7z.UseVisualStyleBackColor = True
        Me.btn_out_7z.Visible = False
        '
        'btn_out_rar
        '
        Me.btn_out_rar.Location = New System.Drawing.Point(197, 171)
        Me.btn_out_rar.Name = "btn_out_rar"
        Me.btn_out_rar.Size = New System.Drawing.Size(53, 23)
        Me.btn_out_rar.TabIndex = 10
        Me.btn_out_rar.Text = "RAR"
        Me.btn_out_rar.UseVisualStyleBackColor = True
        Me.btn_out_rar.Visible = False
        '
        'btn_out_zip
        '
        Me.btn_out_zip.Location = New System.Drawing.Point(138, 171)
        Me.btn_out_zip.Name = "btn_out_zip"
        Me.btn_out_zip.Size = New System.Drawing.Size(53, 23)
        Me.btn_out_zip.TabIndex = 9
        Me.btn_out_zip.Text = "ZIP"
        Me.btn_out_zip.UseVisualStyleBackColor = True
        Me.btn_out_zip.Visible = False
        '
        'btn_out_folder
        '
        Me.btn_out_folder.Location = New System.Drawing.Point(315, 171)
        Me.btn_out_folder.Name = "btn_out_folder"
        Me.btn_out_folder.Size = New System.Drawing.Size(53, 23)
        Me.btn_out_folder.TabIndex = 12
        Me.btn_out_folder.Text = "Folder"
        Me.btn_out_folder.UseVisualStyleBackColor = True
        '
        'brn_convert
        '
        Me.brn_convert.Location = New System.Drawing.Point(12, 142)
        Me.brn_convert.Name = "brn_convert"
        Me.brn_convert.Size = New System.Drawing.Size(120, 23)
        Me.brn_convert.TabIndex = 13
        Me.brn_convert.Text = "CONVERT"
        Me.brn_convert.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(138, 41)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(120, 23)
        Me.btn_clear.TabIndex = 14
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(138, 70)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(120, 23)
        Me.btn_remove.TabIndex = 15
        Me.btn_remove.Text = "REMOVE"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 468)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.brn_convert)
        Me.Controls.Add(Me.btn_out_folder)
        Me.Controls.Add(Me.btn_out_7z)
        Me.Controls.Add(Me.btn_out_rar)
        Me.Controls.Add(Me.btn_out_zip)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btn_set_7z)
        Me.Controls.Add(Me.btn_set_rar)
        Me.Controls.Add(Me.btn_set_zip)
        Me.Controls.Add(Me.lbl_fraction)
        Me.Controls.Add(Me.pnl_bar_line)
        Me.Controls.Add(Me.lbx_zip_files)
        Me.Controls.Add(Me.lbx_zip_paths)
        Me.Controls.Add(Me.btn_open)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnl_bar_line.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OFD_Zip As OpenFileDialog
    Friend WithEvents btn_open As Button
    Friend WithEvents lbx_zip_paths As ListBox
    Friend WithEvents lbx_zip_files As ListBox
    Friend WithEvents pnl_bar_line As Panel
    Friend WithEvents pnl_bar As Panel
    Friend WithEvents lbl_fraction As Label
    Friend WithEvents btn_set_zip As Button
    Friend WithEvents btn_set_rar As Button
    Friend WithEvents btn_set_7z As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btn_out_7z As Button
    Friend WithEvents btn_out_rar As Button
    Friend WithEvents btn_out_zip As Button
    Friend WithEvents btn_out_folder As Button
    Friend WithEvents brn_convert As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_remove As Button
End Class
