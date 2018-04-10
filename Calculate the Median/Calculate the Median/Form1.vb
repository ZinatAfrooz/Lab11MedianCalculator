Public Class fromCalMedian
    Const intMAX_SUBSCRIPT As Integer = 5 ' The maximum subscript
    Dim intNumbers(intMAX_SUBSCRIPT) As Integer ' Array declaration

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'determine the position of the median value is:
        Dim medianPosition As Integer = ((intNumbers.Length + 1) / 2) - 1

        'Calculate median value
        Dim medianValue As Integer = intNumbers(medianPosition)

        'Show the median value
        lblMedian.Text = medianValue.ToString()

    End Sub

    Private Sub fromCalMedian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create an array to hold five lottery numbers.
        'Const intMAX_SUBSCRIPT As Integer = 5 ' The maximum subscript
        'Dim intMAX_SUBSCRIPT As Integer ' The maximum subscript

        Dim intCount As Integer ' Loop counter

        'Create a random object
        Dim rand As New Random

        ' Fill the array with random numbers. Each number will be in the range 0-99.
        For intCount = 0 To intMAX_SUBSCRIPT
            intNumbers(intCount) = rand.Next(100)
        Next

        'SOrt the array 
        Array.Sort(intNumbers)


        ' Display the array elements in the labels.
        lblArray.Text = intNumbers(0).ToString() + ", " + intNumbers(1).ToString() + ", " + intNumbers(2).ToString() + ", " + intNumbers(3).ToString() + ", " + intNumbers(4).ToString()

    End Sub
End Class
