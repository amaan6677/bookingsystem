<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MakeaBookingform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmboDestinations = New System.Windows.Forms.ComboBox()
        Me.cmboNofPeople = New System.Windows.Forms.ComboBox()
        Me.SecondName = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.dgvpackages = New System.Windows.Forms.DataGridView()
        Me.Arrivalbox = New System.Windows.Forms.ComboBox()
        Me.Departurebox = New System.Windows.Forms.ComboBox()
        Me.Destinationcolumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Noofpeoplecolumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Arrivaldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartureDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nofnights = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Infoofpackage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvpackages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmboDestinations
        '
        Me.cmboDestinations.FormattingEnabled = True
        Me.cmboDestinations.Location = New System.Drawing.Point(48, 33)
        Me.cmboDestinations.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmboDestinations.Name = "cmboDestinations"
        Me.cmboDestinations.Size = New System.Drawing.Size(238, 33)
        Me.cmboDestinations.TabIndex = 1
        Me.cmboDestinations.Text = "Destination"
        '
        'cmboNofPeople
        '
        Me.cmboNofPeople.FormattingEnabled = True
        Me.cmboNofPeople.Location = New System.Drawing.Point(48, 125)
        Me.cmboNofPeople.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmboNofPeople.Name = "cmboNofPeople"
        Me.cmboNofPeople.Size = New System.Drawing.Size(248, 33)
        Me.cmboNofPeople.TabIndex = 4
        Me.cmboNofPeople.Text = "no of people"
        '
        'SecondName
        '
        Me.SecondName.FormattingEnabled = True
        Me.SecondName.Location = New System.Drawing.Point(1028, 125)
        Me.SecondName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.SecondName.Name = "SecondName"
        Me.SecondName.Size = New System.Drawing.Size(238, 33)
        Me.SecondName.TabIndex = 5
        Me.SecondName.Text = "Price"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1360, 23)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(194, 33)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.Text = "No of nights"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(1840, 23)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(172, 62)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'dgvpackages
        '
        Me.dgvpackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpackages.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Destinationcolumn, Me.Noofpeoplecolumn, Me.Arrivaldate, Me.DepartureDate, Me.Nofnights, Me.totalprice, Me.Infoofpackage})
        Me.dgvpackages.Location = New System.Drawing.Point(15, 204)
        Me.dgvpackages.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dgvpackages.Name = "dgvpackages"
        Me.dgvpackages.Size = New System.Drawing.Size(2384, 1008)
        Me.dgvpackages.TabIndex = 8
        '
        'Arrivalbox
        '
        Me.Arrivalbox.FormattingEnabled = True
        Me.Arrivalbox.Location = New System.Drawing.Point(382, 33)
        Me.Arrivalbox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Arrivalbox.Name = "Arrivalbox"
        Me.Arrivalbox.Size = New System.Drawing.Size(238, 33)
        Me.Arrivalbox.TabIndex = 9
        Me.Arrivalbox.Text = "Arrival"
        '
        'Departurebox
        '
        Me.Departurebox.FormattingEnabled = True
        Me.Departurebox.Location = New System.Drawing.Point(1028, 23)
        Me.Departurebox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Departurebox.Name = "Departurebox"
        Me.Departurebox.Size = New System.Drawing.Size(264, 33)
        Me.Departurebox.TabIndex = 10
        Me.Departurebox.Text = "Departure"
        '
        'Destinationcolumn
        '
        Me.Destinationcolumn.HeaderText = "Destination"
        Me.Destinationcolumn.Name = "Destinationcolumn"
        Me.Destinationcolumn.Width = 150
        '
        'Noofpeoplecolumn
        '
        Me.Noofpeoplecolumn.HeaderText = "No of People"
        Me.Noofpeoplecolumn.Name = "Noofpeoplecolumn"
        '
        'Arrivaldate
        '
        Me.Arrivaldate.HeaderText = "Arrival"
        Me.Arrivaldate.Name = "Arrivaldate"
        '
        'DepartureDate
        '
        Me.DepartureDate.HeaderText = "Departure"
        Me.DepartureDate.Name = "DepartureDate"
        '
        'Nofnights
        '
        Me.Nofnights.HeaderText = "No Of Nights"
        Me.Nofnights.Name = "Nofnights"
        '
        'totalprice
        '
        Me.totalprice.HeaderText = "Price"
        Me.totalprice.Name = "totalprice"
        '
        'Infoofpackage
        '
        Me.Infoofpackage.HeaderText = "Information"
        Me.Infoofpackage.Name = "Infoofpackage"
        Me.Infoofpackage.Width = 500
        '
        'MakeaBookingform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2580, 1237)
        Me.Controls.Add(Me.Departurebox)
        Me.Controls.Add(Me.Arrivalbox)
        Me.Controls.Add(Me.dgvpackages)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.SecondName)
        Me.Controls.Add(Me.cmboNofPeople)
        Me.Controls.Add(Me.cmboDestinations)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "MakeaBookingform"
        Me.Text = "MakeaBooking2"
        CType(Me.dgvpackages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmboDestinations As ComboBox
    Friend WithEvents cmboNofPeople As ComboBox
    Friend WithEvents SecondName As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents dgvpackages As DataGridView
    Friend WithEvents Arrivalbox As ComboBox
    Friend WithEvents Departurebox As ComboBox
    Friend WithEvents Destinationcolumn As DataGridViewTextBoxColumn
    Friend WithEvents Noofpeoplecolumn As DataGridViewTextBoxColumn
    Friend WithEvents Arrivaldate As DataGridViewTextBoxColumn
    Friend WithEvents DepartureDate As DataGridViewTextBoxColumn
    Friend WithEvents Nofnights As DataGridViewTextBoxColumn
    Friend WithEvents totalprice As DataGridViewTextBoxColumn
    Friend WithEvents Infoofpackage As DataGridViewTextBoxColumn
End Class
