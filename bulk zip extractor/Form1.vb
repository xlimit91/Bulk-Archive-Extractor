Imports System.IO
Imports System.IO.Compression
Imports Shell32
Imports SharpCompress.Archive
Imports SharpCompress.Common

Public Class Form1
    Dim i As Integer = 0
    Dim file As String
    Dim file_count As Integer = 0
    Dim B_Set_7Z As Boolean = False
    Dim B_Set_Zip As Boolean = True
    Dim B_Set_Rar As Boolean = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_set_zip.BackColor = Color.Green
        btn_set_rar.BackColor = Color.Red
        btn_set_7z.BackColor = Color.Red

        btn_out_folder.BackColor = Color.Green
        btn_out_rar.BackColor = Color.Red
        btn_out_7z.BackColor = Color.Red
        btn_out_zip.BackColor = Color.Red

        btn_out_folder.Location = btn_out_zip.Location
        btn_out_folder.Visible = False
    End Sub

    Private Sub btn_open_Click(sender As Object, e As EventArgs) Handles btn_open.Click
        If B_Set_7Z = True Then
            OFD_Zip.Filter = "7Z Files|*7Z"
        End If

        If B_Set_Zip = True Then
            OFD_Zip.Filter = "Zip Files|*Zip"
        End If

        If B_Set_Rar = True Then
            OFD_Zip.Filter = "Rar Files|*Rar"
        End If

        btn_set_7z.Enabled = False
        btn_set_rar.Enabled = False
        btn_set_zip.Enabled = False

        If OFD_Zip.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            For Each file In OFD_Zip.FileNames
                file_count += 1
            Next

            lbl_fraction.Text = i & " out of " & file_count
            pnl_bar.Width = (i / file_count) * 100 * 2

            For Each file In OFD_Zip.FileNames
                lbx_zip_paths.Items.Add(file)
            Next

        Else

            btn_set_7z.Enabled = True
            btn_set_rar.Enabled = True
            btn_set_zip.Enabled = True

        End If
    End Sub

    Private Sub btn_set_7z_Click(sender As Object, e As EventArgs) Handles btn_set_7z.Click
        btn_set_7z.BackColor = Color.Green
        btn_set_zip.BackColor = Color.Red
        btn_set_rar.BackColor = Color.Red

        B_Set_7Z = True
        B_Set_Zip = False
        B_Set_Rar = False
    End Sub

    Private Sub btn_set_rar_Click(sender As Object, e As EventArgs) Handles btn_set_rar.Click
        btn_set_rar.BackColor = Color.Green
        btn_set_zip.BackColor = Color.Red
        btn_set_7z.BackColor = Color.Red

        B_Set_7Z = False
        B_Set_Zip = False
        B_Set_Rar = True
    End Sub

    Private Sub btn_set_zip_Click(sender As Object, e As EventArgs) Handles btn_set_zip.Click
        btn_set_zip.BackColor = Color.Green
        btn_set_rar.BackColor = Color.Red
        btn_set_7z.BackColor = Color.Red

        B_Set_7Z = False
        B_Set_Zip = True
        B_Set_Rar = False
    End Sub

    Private Sub btn_out_7z_Click(sender As Object, e As EventArgs) Handles btn_out_7z.Click
        btn_out_7z.BackColor = Color.Green
        btn_out_zip.BackColor = Color.Red
        btn_out_rar.BackColor = Color.Red
        btn_out_folder.BackColor = Color.Red
    End Sub

    Private Sub btn_out_rar_Click(sender As Object, e As EventArgs) Handles btn_out_rar.Click
        btn_out_rar.BackColor = Color.Green
        btn_out_zip.BackColor = Color.Red
        btn_out_7z.BackColor = Color.Red
        btn_out_folder.BackColor = Color.Red
    End Sub

    Private Sub btn_out_zip_Click(sender As Object, e As EventArgs) Handles btn_out_zip.Click
        btn_out_zip.BackColor = Color.Green
        btn_out_rar.BackColor = Color.Red
        btn_out_7z.BackColor = Color.Red
        btn_out_folder.BackColor = Color.Red
    End Sub

    Private Sub btn_out_folder_Click(sender As Object, e As EventArgs) Handles btn_out_folder.Click
        btn_out_folder.BackColor = Color.Green
        btn_out_zip.BackColor = Color.Red
        btn_out_rar.BackColor = Color.Red
        btn_out_7z.BackColor = Color.Red
    End Sub

    Private Sub brn_convert_Click(sender As Object, e As EventArgs) Handles brn_convert.Click

        If B_Set_7Z = True Then
            Set_7Z_Click(sender)
        End If

        If B_Set_Zip = True Then
            Set_Zip_Click(sender)
        End If

        If B_Set_Rar = True Then
            Set_Rar_Click(sender)
        End If

        'For Each file In OFD_Zip.FileNames

        '    Dim fileinfo As Array
        '    fileinfo = Split(file, "\")
        '    Dim file_number = fileinfo.Length
        '    Dim filename As String = (fileinfo(file_number - 1))
        '    filename = filename.Replace(".zip", "")

        '    lbx_zip_files.Items.Add(filename)

        '    Dim folder_make As String = file
        '    folder_make = folder_make.Replace(".zip", "")

        '    Dim sc As New Shell32.Shell()
        '    'Create directory in which you will unzip your files .
        '    System.IO.Directory.CreateDirectory(folder_make)
        '    IO.Directory.CreateDirectory(folder_make)
        '    'Declare the folder where the files will be extracted
        '    Dim output As Shell32.Folder = sc.NameSpace(folder_make)
        '    'Declare your input zip file as folder  .
        '    Dim input As Shell32.Folder = sc.NameSpace(file)
        '    'Extract the files from the zip file using the CopyHere command .
        '    output.CopyHere(input.Items, 4)

        '    i += 1

        '    lbl_fraction.Text = i & " out of " & file_count
        '    pnl_bar.Width = (i / file_count) * 100 * 2
        'Next
    End Sub

    Private Sub Set_Zip_Click(butt As Button)
        For Each file In OFD_Zip.FileNames

            Dim fileinfo As Array
            fileinfo = Split(file, "\")
            Dim file_number = fileinfo.Length
            Dim filename As String = (fileinfo(file_number - 1))
            filename = filename.Replace(".zip", "")

            lbx_zip_files.Items.Add(filename)

            Dim folder_make As String = file
            folder_make = folder_make.Replace(".zip", "")

            Dim sc As New Shell32.Shell()
            System.IO.Directory.CreateDirectory(folder_make)
            IO.Directory.CreateDirectory(folder_make)
            Dim output As Shell32.Folder = sc.NameSpace(folder_make)
            Dim input As Shell32.Folder = sc.NameSpace(file)
            output.CopyHere(input.Items, 4)

            i += 1

            lbl_fraction.Text = i & " out of " & file_count
            pnl_bar.Width = (i / file_count) * 100 * 2
        Next
    End Sub

    Private Sub Set_Rar_Click(butt As Button)
        For Each file In OFD_Zip.FileNames

            Dim fileinfo As Array
            fileinfo = Split(file, "\")
            Dim file_number = fileinfo.Length
            Dim filename As String = (fileinfo(file_number - 1))
            filename = filename.Replace(".rar", "")

            lbx_zip_files.Items.Add(filename)

            Dim folder_make As String = file
            folder_make = folder_make.Replace(".rar", "")

            Dim archive As IArchive = ArchiveFactory.Open(file)
            For Each entry In archive.Entries
                If Not entry.IsDirectory Then
                    Console.WriteLine(entry.FilePath)
                    IO.Directory.CreateDirectory(folder_make)
                    entry.WriteToDirectory(folder_make,
          ExtractOptions.ExtractFullPath Or ExtractOptions.Overwrite)
                End If
            Next

            i += 1

            lbl_fraction.Text = i & " out of " & file_count
            pnl_bar.Width = (i / file_count) * 100 * 2
        Next
    End Sub

    Private Sub Set_7Z_Click(butt As Button)
        For Each file In OFD_Zip.FileNames

            Dim fileinfo As Array
            fileinfo = Split(file, "\")
            Dim file_number = fileinfo.Length
            Dim filename As String = (fileinfo(file_number - 1))
            filename = filename.Replace(".7z", "")

            lbx_zip_files.Items.Add(filename)

            Dim folder_make As String = file
            folder_make = folder_make.Replace(".7z", "")

            Dim archive As IArchive = ArchiveFactory.Open(file)
            For Each entry In archive.Entries
                If Not entry.IsDirectory Then
                    Console.WriteLine(entry.FilePath)
                    IO.Directory.CreateDirectory(folder_make)
                    entry.WriteToDirectory(folder_make,
          ExtractOptions.ExtractFullPath Or ExtractOptions.Overwrite)
                End If
            Next

            i += 1

            lbl_fraction.Text = i & " out of " & file_count
            pnl_bar.Width = (i / file_count) * 100 * 2
        Next
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Dim remove_file As String

        remove_file = lbx_zip_paths.SelectedItem
        lbx_zip_paths.Items.Remove(remove_file)
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        lbx_zip_paths.Items.Clear()
    End Sub
End Class
