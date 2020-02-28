Public Class mainMenu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        storepackagedetails()
        findpackage()
    End Sub
    Private Sub btnMakeABooking_Click(sender As Object, e As EventArgs) Handles btnMakeABooking.Click
        Me.Hide()
        MakeaBookingform.Show()

    End Sub

    Private Sub Packages_Click(sender As Object, e As EventArgs) Handles Packages.Click
        Me.Hide()
        Packages.Show()
    End Sub
    Private Sub ManageBookings_Click(sender As Object, e As EventArgs) Handles ManageBookings.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Quitbtn.Click
        End
    End Sub

    Private Sub Customer_Click(sender As Object, e As EventArgs) Handles Customer.Click
        Me.Hide()
        Customer.Show()
    End Sub
End Class
