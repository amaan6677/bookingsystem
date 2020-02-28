<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MakeAbooking
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
        Me.Destinations = New System.Windows.Forms.ComboBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.SecondName = New System.Windows.Forms.ComboBox()
        Me.TitleFirstName = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.Packages = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Destinations
        '
        Me.Destinations.FormattingEnabled = True
        Me.Destinations.Location = New System.Drawing.Point(12, 12)
        Me.Destinations.Name = "Destinations"
        Me.Destinations.Size = New System.Drawing.Size(121, 21)
        Me.Destinations.TabIndex = 0
        Me.Destinations.Text = "Destination"
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(15, 407)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(118, 31)
        Me.BtnBack.TabIndex = 1
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'SecondName
        '
        Me.SecondName.FormattingEnabled = True
        Me.SecondName.Location = New System.Drawing.Point(350, 12)
        Me.SecondName.Name = "SecondName"
        Me.SecondName.Size = New System.Drawing.Size(121, 21)
        Me.SecondName.TabIndex = 2
        Me.SecondName.Text = "Price"
        '
        'TitleFirstName
        '
        Me.TitleFirstName.FormattingEnabled = True
        Me.TitleFirstName.Location = New System.Drawing.Point(175, 12)
        Me.TitleFirstName.Name = "TitleFirstName"
        Me.TitleFirstName.Size = New System.Drawing.Size(126, 21)
        Me.TitleFirstName.TabIndex = 3
        Me.TitleFirstName.Text = "no of people"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(516, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.Text = "No of nights"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(696, 12)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(75, 28)
        Me.Search.TabIndex = 6
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Packages
        '
        Me.Packages.FormattingEnabled = True
        Me.Packages.Location = New System.Drawing.Point(15, 136)
        Me.Packages.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Packages.Name = "Packages"
        Me.Packages.Size = New System.Drawing.Size(184, 251)
        Me.Packages.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(328, 54)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(278, 154)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(292, 231)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(347, 156)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "Reviews"
        '
        'MakeAbooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 543)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Packages)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TitleFirstName)
        Me.Controls.Add(Me.SecondName)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Destinations)
        Me.Name = "MakeAbooking"
        Me.Text = "MakeAbooking"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Destinations As ComboBox
    Friend WithEvents BtnBack As Button
    Friend WithEvents SecondName As ComboBox
    Friend WithEvents TitleFirstName As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Search As Button
    Friend WithEvents Packages As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
End Class
