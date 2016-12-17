Imports System.IO
Imports System.IO.Compression
Imports Shell32

Public Class Form1
    Dim i As Integer = 0

    Private Sub btn_open_Click(sender As Object, e As EventArgs) Handles btn_open.Click
        If OFD_Zip.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim file As String
            Dim file_count As Integer = 0

            For Each file In OFD_Zip.FileNames
                file_count += 1
            Next

            lbl_fraction.Text = i & " out of " & file_count
            pnl_bar.Width = (i / file_count) * 100 * 2

            For Each file In OFD_Zip.FileNames
                lbx_zip_paths.Items.Add(file)

                Dim fileinfo As Array
                fileinfo = Split(file, "\")
                Dim file_number = fileinfo.Length
                Dim filename As String = (fileinfo(file_number - 1))
                filename = filename.Replace(".zip", "")

                lbx_zip_files.Items.Add(filename)

                Dim folder_make As String = file
                folder_make = folder_make.Replace(".zip", "")

                Dim sc As New Shell32.Shell()
                'Create directory in which you will unzip your files .
                System.IO.Directory.CreateDirectory(folder_make)
                IO.Directory.CreateDirectory(folder_make)
                'Declare the folder where the files will be extracted
                Dim output As Shell32.Folder = sc.NameSpace(folder_make)
                'Declare your input zip file as folder  .
                Dim input As Shell32.Folder = sc.NameSpace(file)
                'Extract the files from the zip file using the CopyHere command .
                output.CopyHere(input.Items, 4)

                i += 1

                lbl_fraction.Text = i & " out of " & file_count
                pnl_bar.Width = (i / file_count) * 100 * 2
            Next
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
