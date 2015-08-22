Module Module1

    Sub Main()
        Dim numbers As New List(Of Integer)
        Dim sum As Integer
        For i As Integer = 1 To 1000000
            numbers.Add(i)
        Next
        For Each number As Integer In numbers
            For Each digit As Char In number.ToString
                sum = sum + Val(digit)
            Next
        Next
        Console.WriteLine(sum)
        Console.ReadLine()
    End Sub

End Module
