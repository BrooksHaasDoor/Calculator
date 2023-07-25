Public Class CalculatorForm
    ' Global Variables
    Dim currentVal As String = ""
    Dim operatorClicked As String = ""
    Dim total As Double = 0

    Private Sub DoMath()
        ' Operations
        If operatorClicked = "+" Then
            total += CDbl(currentVal)
        ElseIf operatorClicked = "-" Then
            total -= CDbl(currentVal)
        ElseIf operatorClicked = "*" Then
            total *= CDbl(currentVal)
        ElseIf operatorClicked = "/" Then
            total /= CDbl(currentVal)
        End If
    End Sub

    Private Sub Operator_Click(sender As Object, e As EventArgs) Handles AddBtn.Click, SubtractBtn.Click, MultiplyBtn.Click, DivideBtn.Click
        ' Current button variable
        Dim clickedButton As Button = DirectCast(sender, Button)

        ' Populate total & exit on first operation click
        If total = 0 Then
            total = CDbl(currentVal)
            operatorClicked = clickedButton.Text
            currentVal = ""
            Exit Sub
            ' Display previous operation
        ElseIf operatorClicked = clickedButton.Text Then
            LatestOperationTxt.Text = total & " " & operatorClicked & " " & currentVal
        End If

        ' If the stored operator is not the current operator,
        ' then update the stored operator,
        ' clear the current value,
        ' and exit
        If Not (operatorClicked = clickedButton.Text) Then
            operatorClicked = clickedButton.Text
            currentVal = ""
            Exit Sub
        End If

        DoMath()

        ' Cleanup and set the display
        operatorClicked = clickedButton.Text
        ResultTxt.Text = total
        currentVal = ""
    End Sub

    Private Sub CharacterBtn_Click(sender As Object, e As EventArgs) Handles ZeroBtn.Click, OneBtn.Click, TwoBtn.Click, ThreeBtn.Click, FourBtn.Click, FiveBtn.Click, SixBtn.Click, SevenBtn.Click, EightBtn.Click, NineBtn.Click, DecimalBtn.Click
        ' Current button variable
        Dim clickedButton As Button = DirectCast(sender, Button)

        ' Set the display & current value to "."
        ' then, exit the function
        If clickedButton.Text = "." Then
            currentVal += "."
            ResultTxt.Text = currentVal
            Exit Sub
        End If

        ' Set the display and current value
        currentVal += clickedButton.Text
        ResultTxt.Text = currentVal
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ' Reset the display and all values
        currentVal = ""
        ResultTxt.Text = currentVal
        total = 0
        operatorClicked = ""
        LatestOperationTxt.Text = ""
    End Sub

    Private Sub EqualsBtn_Click(sender As Object, e As EventArgs) Handles EqualsBtn.Click
        ' Display previous operation
        LatestOperationTxt.Text = total & " " & operatorClicked & " " & currentVal

        DoMath()

        ' Set the display
        ResultTxt.Text = total
    End Sub
End Class
