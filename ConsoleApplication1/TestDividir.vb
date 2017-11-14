Imports ClassLibrary1

Module TestDividir
    Sub main()
        Dim a, b As Decimal
        'a = 5
        'b = 0
        Console.Write("Ingrese dividendo: ")
        a = Console.ReadLine()
        Console.Write("Ingrese divisor: ")
        b = Console.ReadLine()
        Dim oDividir As New Dividir
        Try
            Console.WriteLine("Resultado: " & oDividir.Dividir(a, b))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
    End Sub
End Module

