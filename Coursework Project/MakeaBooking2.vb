Public Class MakeaBookingform
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Arrivalbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Arrivalbox.SelectedIndexChanged
        'u r gay
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpackages.CellContentClick
        'Me.Hide()
        'Packages.Show()

        Dim firstcolumn = dgvpackages.Rows(e.RowIndex).Cells(0)
        Packages.destination = firstcolumn.Value
        Console.WriteLine(e)
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If cmboDestinations.Text <> "" Then ' if field is empty
            dgvpackages.MultiSelect = False 'Does not allow all rows to be selected 
            dgvpackages.AllowUserToAddRows = False
            Dim selecteddestination As String
            Dim path As String = CurDir() & "\Packages.csv"
            FileOpen(1, path, OpenMode.Input)
            Dim fullline As String
            fullline = LineInput(1)
            Do Until EOF(1)
                fullline = LineInput(1)
                Dim item() As String = Split(fullline, ",")
                Dim packagearray() As String = New String() {item(1), item(7), item(2), item(3), item(4), item(5)}

                dgvpackages.Rows.Add(packagearray)


            Loop
            FileClose(1)




        End If
    End Sub
    'Public Sub findpackage()
    '    Dim packagedestinations As New List(Of String)
    '    For i = 0 To numofpackages
    '        If Not packagedestinations.Contains(allpackages(i).destinations) Then
    '            Dim onedestination As String = allpackages(i).destinations

    '            packagedestinations.Add(onedestination)
    '            cmboDestinations.Items.Add(onedestination)




    '        End If



    '    Next




    'End Sub
    Private Sub cmboDestinations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboDestinations.SelectedIndexChanged

        'Dim path As String = CurDir() & "\Packages.csv"
        'FileOpen(1, path, OpenMode.Input)


        'Do Until EOF(1)
        '    Dim fullline As String
        '    fullline = LineInput(1)
        '    Dim item() As String = Split(fullline, " ,")


        '    cmboDestinations.Items.Add(item(1))

        'Loop
        'FileClose(1)





    End Sub



    Private Sub MakeaBookingform_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub NofPeople_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboNofPeople.SelectedIndexChanged

    End Sub
End Class