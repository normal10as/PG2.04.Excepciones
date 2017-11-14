Module CapturarException

    Sub Main()
        Try
            Dim a, b, c As Decimal
            a = 9
            ' división por cero
            b = 0
            ' desbordamiento
            'b = 99999999999999999
            ' indeterminado
            'b = ""
            c = a / b
            c = a ^ b
            Console.WriteLine(c)
        Catch ex As DivideByZeroException
            Console.WriteLine("Error de división por cero")
        Catch ex As OverflowException
            Console.WriteLine("Error de desbordamiento")
        Catch ex As Exception
            Console.WriteLine("Error indeterminado")
        Finally
            Console.ReadKey()
        End Try
    End Sub

End Module

