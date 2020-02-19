
'Homework 1
'Author = Dil Rawat

Public Class RentalChargesForm
    Const CHARGE_PER_DAY_DCIMAL As Decimal = 49.0
    Const CHARGE_PER_MILE_DECIMAL As Decimal = 0.2

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' exit the program
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'clear all the textboxes.
        BeginingOdometerTextBox.Clear()
        EndingOdometerTextBox.Clear()
        NumOfDaysTextBox.Clear()
        MilesDrivenTextBox.Clear()
        TotalsTextBox.Clear()

        'reset the cursor
        BeginingOdometerTextBox.Focus()

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'declare all required variables for the calculation
        Dim BeginingOdometerInteger As Integer
        Dim EndingOdometerInteger As Integer
        Dim NumberOfDaysInteger As Integer
        Dim MilesDrivenInteger As Integer
        Dim TotalsDecimal As Decimal

        'focus on the begining textbox
        BeginingOdometerTextBox.Focus()

        Try
            'try catch block to check if the entered value is valid or not
            'parsing the value as integer that has been string 
            BeginingOdometerInteger = Integer.Parse(BeginingOdometerTextBox.Text)
            Try
                'try block to check if ending odometer value is entered as integer
                'parsing the value as integer that has been string 
                EndingOdometerInteger = Integer.Parse(EndingOdometerTextBox.Text)

                Try
                    'Try Catch block To check If the entered value Is valid Or Not
                    'parsing the value as integer that has been string 
                    NumberOfDaysInteger = Integer.Parse(NumOfDaysTextBox.Text)

                    'calculate the miles driven 

                    MilesDrivenInteger = (EndingOdometerInteger - BeginingOdometerInteger)

                    'calculate total price
                    TotalsDecimal = (MilesDrivenInteger * CHARGE_PER_MILE_DECIMAL) +
                                    (CHARGE_PER_DAY_DCIMAL * NumberOfDaysInteger)

                    'output the miles driven and total charges
                    MilesDrivenTextBox.Text = MilesDrivenInteger.ToString()
                    TotalsTextBox.Text = TotalsDecimal.ToString("c")

                Catch NumOfDaysIntegerFormatException As FormatException
                    'display an error message with messagebox when integer is not entered
                    MessageBox.Show("Number of days must be a number",
                                    "Data entry error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation)
                    'focus on bad field
                    NumOfDaysTextBox.Focus()
                    'select all 
                    NumOfDaysTextBox.SelectAll()

                End Try

            Catch EndOdometerIntegerFormatException As FormatException
                'display an error message with messagebox when integer is not entered
                MessageBox.Show("Ending odometer must be a number",
                                "Data entry error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
                'focus on bad field
                EndingOdometerTextBox.Focus()
                'select all 
                EndingOdometerTextBox.SelectAll()

            End Try

        Catch BegOdometerIntegerFromatException As FormatException
            'errors in try will fail
            'dispaly an error message with messagebox
            MessageBox.Show("Begining odometer must be a number",
                            "Data Entry error", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)
            'put the focus on bad field
            BeginingOdometerTextBox.Focus()
            'select all 
            BeginingOdometerTextBox.SelectAll()

        End Try

    End Sub

    Private Sub MilesDrivenTextBox_TextChanged(sender As Object, e As EventArgs) Handles MilesDrivenTextBox.TextChanged

    End Sub
End Class
