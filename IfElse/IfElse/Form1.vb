Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click

        Dim num1, num2, largerNum As Double

        If Not (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then
            MessageBox.Show("Error: Please type a number!", "Error")
            Return
        End If

        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)

        If (num1 < 0 Or num2 < 0) Then
            MessageBox.Show("Error: Please enter a positive number!", "Error")
            Return
        End If

        If num1 > num2 Then
            largerNum = num1
        Else
            largerNum = num2
        End If

        txtResult.Text = "The larger numer is " & largerNum

    End Sub
End Class
