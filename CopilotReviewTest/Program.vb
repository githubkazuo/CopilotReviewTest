Imports System

Module Program
    'Copilot�Ń��r���[�����邽�߂̋ɂ߂ăV���v���ȃR�[�h
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim number As Integer = 42
        Dim message As String = "The answer to life, the universe, and everything is " & number.ToString()
        Console.WriteLine(message)
        Dim numbers As Integer() = {1, 2, 3, 4, 5}
        For Each num As Integer In numbers
            Console.WriteLine("Number: " & num)
        Next
    End Sub
End Module
