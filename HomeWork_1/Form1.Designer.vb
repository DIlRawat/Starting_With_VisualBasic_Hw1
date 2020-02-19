<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentalChargesForm
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
        Me.BeginingOdomenteLabel = New System.Windows.Forms.Label()
        Me.EndingOdometerLabel = New System.Windows.Forms.Label()
        Me.NumOfDaysLabel = New System.Windows.Forms.Label()
        Me.BeginingOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.EndingOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.NumOfDaysTextBox = New System.Windows.Forms.TextBox()
        Me.MilesDrivenLabel = New System.Windows.Forms.Label()
        Me.TotalChargesLabel = New System.Windows.Forms.Label()
        Me.MilesDrivenTextBox = New System.Windows.Forms.TextBox()
        Me.TotalsTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TotalsGroupBox = New System.Windows.Forms.GroupBox()
        Me.RentalInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.TotalsGroupBox.SuspendLayout()
        Me.RentalInfoGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'BeginingOdomenteLabel
        '
        Me.BeginingOdomenteLabel.Location = New System.Drawing.Point(6, 37)
        Me.BeginingOdomenteLabel.Name = "BeginingOdomenteLabel"
        Me.BeginingOdomenteLabel.Size = New System.Drawing.Size(222, 40)
        Me.BeginingOdomenteLabel.TabIndex = 0
        Me.BeginingOdomenteLabel.Text = "Begining Odometer"
        '
        'EndingOdometerLabel
        '
        Me.EndingOdometerLabel.Location = New System.Drawing.Point(6, 91)
        Me.EndingOdometerLabel.Name = "EndingOdometerLabel"
        Me.EndingOdometerLabel.Size = New System.Drawing.Size(222, 23)
        Me.EndingOdometerLabel.TabIndex = 1
        Me.EndingOdometerLabel.Text = "Ending Odometer:"
        '
        'NumOfDaysLabel
        '
        Me.NumOfDaysLabel.Location = New System.Drawing.Point(6, 143)
        Me.NumOfDaysLabel.Name = "NumOfDaysLabel"
        Me.NumOfDaysLabel.Size = New System.Drawing.Size(191, 23)
        Me.NumOfDaysLabel.TabIndex = 2
        Me.NumOfDaysLabel.Text = "Number of Days:"
        '
        'BeginingOdometerTextBox
        '
        Me.BeginingOdometerTextBox.Location = New System.Drawing.Point(259, 34)
        Me.BeginingOdometerTextBox.Name = "BeginingOdometerTextBox"
        Me.BeginingOdometerTextBox.Size = New System.Drawing.Size(100, 26)
        Me.BeginingOdometerTextBox.TabIndex = 4
        '
        'EndingOdometerTextBox
        '
        Me.EndingOdometerTextBox.Location = New System.Drawing.Point(259, 88)
        Me.EndingOdometerTextBox.Name = "EndingOdometerTextBox"
        Me.EndingOdometerTextBox.Size = New System.Drawing.Size(100, 26)
        Me.EndingOdometerTextBox.TabIndex = 5
        '
        'NumOfDaysTextBox
        '
        Me.NumOfDaysTextBox.Location = New System.Drawing.Point(259, 143)
        Me.NumOfDaysTextBox.Name = "NumOfDaysTextBox"
        Me.NumOfDaysTextBox.Size = New System.Drawing.Size(100, 26)
        Me.NumOfDaysTextBox.TabIndex = 6
        '
        'MilesDrivenLabel
        '
        Me.MilesDrivenLabel.Location = New System.Drawing.Point(50, 33)
        Me.MilesDrivenLabel.Name = "MilesDrivenLabel"
        Me.MilesDrivenLabel.Size = New System.Drawing.Size(100, 23)
        Me.MilesDrivenLabel.TabIndex = 8
        Me.MilesDrivenLabel.Text = "Miles Driven"
        '
        'TotalChargesLabel
        '
        Me.TotalChargesLabel.Location = New System.Drawing.Point(50, 118)
        Me.TotalChargesLabel.Name = "TotalChargesLabel"
        Me.TotalChargesLabel.Size = New System.Drawing.Size(100, 23)
        Me.TotalChargesLabel.TabIndex = 9
        Me.TotalChargesLabel.Text = "Total Charges"
        '
        'MilesDrivenTextBox
        '
        Me.MilesDrivenTextBox.Location = New System.Drawing.Point(54, 76)
        Me.MilesDrivenTextBox.Name = "MilesDrivenTextBox"
        Me.MilesDrivenTextBox.ReadOnly = True
        Me.MilesDrivenTextBox.Size = New System.Drawing.Size(100, 26)
        Me.MilesDrivenTextBox.TabIndex = 10
        '
        'TotalsTextBox
        '
        Me.TotalsTextBox.Location = New System.Drawing.Point(54, 161)
        Me.TotalsTextBox.Name = "TotalsTextBox"
        Me.TotalsTextBox.ReadOnly = True
        Me.TotalsTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TotalsTextBox.TabIndex = 11
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(417, 280)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(106, 33)
        Me.CalculateButton.TabIndex = 12
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(561, 280)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(91, 33)
        Me.ClearButton.TabIndex = 13
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(681, 280)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(93, 33)
        Me.ExitButton.TabIndex = 14
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'TotalsGroupBox
        '
        Me.TotalsGroupBox.Controls.Add(Me.MilesDrivenLabel)
        Me.TotalsGroupBox.Controls.Add(Me.MilesDrivenTextBox)
        Me.TotalsGroupBox.Controls.Add(Me.TotalChargesLabel)
        Me.TotalsGroupBox.Controls.Add(Me.TotalsTextBox)
        Me.TotalsGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalsGroupBox.Location = New System.Drawing.Point(507, 31)
        Me.TotalsGroupBox.Name = "TotalsGroupBox"
        Me.TotalsGroupBox.Size = New System.Drawing.Size(267, 213)
        Me.TotalsGroupBox.TabIndex = 15
        Me.TotalsGroupBox.TabStop = False
        Me.TotalsGroupBox.Text = "Totals"
        '
        'RentalInfoGroupBox
        '
        Me.RentalInfoGroupBox.Controls.Add(Me.BeginingOdometerTextBox)
        Me.RentalInfoGroupBox.Controls.Add(Me.BeginingOdomenteLabel)
        Me.RentalInfoGroupBox.Controls.Add(Me.EndingOdometerTextBox)
        Me.RentalInfoGroupBox.Controls.Add(Me.EndingOdometerLabel)
        Me.RentalInfoGroupBox.Controls.Add(Me.NumOfDaysTextBox)
        Me.RentalInfoGroupBox.Controls.Add(Me.NumOfDaysLabel)
        Me.RentalInfoGroupBox.Location = New System.Drawing.Point(12, 40)
        Me.RentalInfoGroupBox.Name = "RentalInfoGroupBox"
        Me.RentalInfoGroupBox.Size = New System.Drawing.Size(426, 204)
        Me.RentalInfoGroupBox.TabIndex = 16
        Me.RentalInfoGroupBox.TabStop = False
        Me.RentalInfoGroupBox.Text = "Enter Rental Information"
        '
        'RentalChargesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 342)
        Me.Controls.Add(Me.RentalInfoGroupBox)
        Me.Controls.Add(Me.TotalsGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Name = "RentalChargesForm"
        Me.Text = "Rental Charges"
        Me.TotalsGroupBox.ResumeLayout(False)
        Me.TotalsGroupBox.PerformLayout()
        Me.RentalInfoGroupBox.ResumeLayout(False)
        Me.RentalInfoGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BeginingOdomenteLabel As Label
    Friend WithEvents EndingOdometerLabel As Label
    Friend WithEvents NumOfDaysLabel As Label
    Friend WithEvents BeginingOdometerTextBox As TextBox
    Friend WithEvents EndingOdometerTextBox As TextBox
    Friend WithEvents NumOfDaysTextBox As TextBox
    Friend WithEvents MilesDrivenLabel As Label
    Friend WithEvents TotalChargesLabel As Label
    Friend WithEvents MilesDrivenTextBox As TextBox
    Friend WithEvents TotalsTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents TotalsGroupBox As GroupBox
    Friend WithEvents RentalInfoGroupBox As GroupBox
End Class
