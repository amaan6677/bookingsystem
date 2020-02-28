<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Me.btnMakeABooking = New System.Windows.Forms.Button()
        Me.Packages = New System.Windows.Forms.Button()
        Me.Customer = New System.Windows.Forms.Button()
        Me.ManageBookings = New System.Windows.Forms.Button()
        Me.Reports = New System.Windows.Forms.Button()
        Me.Quitbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMakeABooking
        '
        Me.btnMakeABooking.Location = New System.Drawing.Point(268, 172)
        Me.btnMakeABooking.Name = "btnMakeABooking"
        Me.btnMakeABooking.Size = New System.Drawing.Size(223, 90)
        Me.btnMakeABooking.TabIndex = 0
        Me.btnMakeABooking.Text = "Make A Booking"
        Me.btnMakeABooking.UseVisualStyleBackColor = True
        '
        'Packages
        '
        Me.Packages.Location = New System.Drawing.Point(617, 46)
        Me.Packages.Name = "Packages"
        Me.Packages.Size = New System.Drawing.Size(129, 57)
        Me.Packages.TabIndex = 1
        Me.Packages.Text = "Packages"
        Me.Packages.UseVisualStyleBackColor = True
        '
        'Customer
        '
        Me.Customer.Location = New System.Drawing.Point(35, 46)
        Me.Customer.Name = "Customer"
        Me.Customer.Size = New System.Drawing.Size(129, 57)
        Me.Customer.TabIndex = 2
        Me.Customer.Text = "Customer"
        Me.Customer.UseVisualStyleBackColor = True
        '
        'ManageBookings
        '
        Me.ManageBookings.Location = New System.Drawing.Point(35, 332)
        Me.ManageBookings.Name = "ManageBookings"
        Me.ManageBookings.Size = New System.Drawing.Size(129, 55)
        Me.ManageBookings.TabIndex = 3
        Me.ManageBookings.Text = "Manage Bookings"
        Me.ManageBookings.UseVisualStyleBackColor = True
        '
        'Reports
        '
        Me.Reports.Location = New System.Drawing.Point(617, 332)
        Me.Reports.Name = "Reports"
        Me.Reports.Size = New System.Drawing.Size(139, 55)
        Me.Reports.TabIndex = 4
        Me.Reports.Text = "Reports"
        Me.Reports.UseVisualStyleBackColor = True
        '
        'Quitbtn
        '
        Me.Quitbtn.Location = New System.Drawing.Point(671, 415)
        Me.Quitbtn.Name = "Quitbtn"
        Me.Quitbtn.Size = New System.Drawing.Size(75, 23)
        Me.Quitbtn.TabIndex = 5
        Me.Quitbtn.Text = "Quit"
        Me.Quitbtn.UseVisualStyleBackColor = True
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Quitbtn)
        Me.Controls.Add(Me.Reports)
        Me.Controls.Add(Me.ManageBookings)
        Me.Controls.Add(Me.Customer)
        Me.Controls.Add(Me.Packages)
        Me.Controls.Add(Me.btnMakeABooking)
        Me.Name = "mainMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMakeABooking As Button
    Friend WithEvents Packages As Button
    Friend WithEvents Customer As Button
    Friend WithEvents ManageBookings As Button
    Friend WithEvents Reports As Button
    Friend WithEvents Quitbtn As Button
End Class
