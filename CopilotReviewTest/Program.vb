Imports System

Module Program
    'Copilotでレビューさせるための極めてシンプルなコード
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim number As Integer = 42
        Dim message As String = "The answer to life, the universe, and everything is " & number.ToString()
        Console.WriteLine(message)
    End Sub
End Module
