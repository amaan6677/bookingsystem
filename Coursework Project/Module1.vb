Module Module1
    Public allpackages(30) As packagetype
    Public numofpackages As Integer = 0
    'public path As String = CurDir() & "\Packages3.csv"
    Public Structure packagetype
        Dim destinations As String
        Dim noofpeople As String
        Dim arrival As String
        Dim departure As String
        Dim noofnights As String
        Dim price As String
    End Structure
    Public Sub storepackagedetails()
        'Dim fullline As String = ""
        'Dim counter As Integer = 0
        'FileOpen(1, path, OpenMode.Input)
        'Do Until EOF(1)
        '    fullline = LineInput(1)
        '    Dim item() As String = Split(fullline, ",")
        '    allpackages(counter).destinations = item(0)
        '    allpackages(counter).noofnights = item(1)
        '    allpackages(counter).arrival = item(2)
        '    allpackages(counter).departure = item(3)
        '    allpackages(counter).noofnights = item(4)
        '    allpackages(counter).price = item(5)
        '    numofpackages = numofpackages + 1




        'Loop

    End Sub

    Public Sub findpackage()
        'Dim packagedestinations As New List(Of String)
        'For i = 0 To numofpackages
        '    If Not packagedestinations.Contains(allpackages(i).destinations) Then
        '        Dim onedestination As String = allpackages(i).destinations

        '        packagedestinations.Add(onedestination)
        '        MakeaBookingform.cmboDestinations.Items.Add(onedestination)




        '    End If



        'Next




    End Sub




End Module
