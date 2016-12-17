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
        Me.lbx_zip_files.Location = New System.Drawing.Point(12, 142)
        Me.lbx_zip_files.Name = "lbx_zip_files"
        Me.lbx_zip_files.Size = New System.Drawing.Size(120, 95)
        Me.lbx_zip_files.TabIndex = 2
        '
        'pnl_bar_line
        '
        Me.pnl_bar_line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_bar_line.Controls.Add(Me.pnl_bar)
        Me.pnl_bar_line.Location = New System.Drawing.Point(12, 243)
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
        Me.lbl_fraction.Location = New System.Drawing.Point(12, 297)
        Me.lbl_fraction.Name = "lbl_fraction"
        Me.lbl_fraction.Size = New System.Drawing.Size(0, 13)
        Me.lbl_fraction.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 468)
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
End Class
