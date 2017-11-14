Imports ClassLibrary1

Module AllienTest
    Sub main()
        Dim p As New Allien()
        ' lanza excepciones en los setters por cada propiedad
        ' se las captura con la excepción personalizada
        Try
            p.id = -1
        Catch ex As ValorInvalidoException
            Console.WriteLine(ex.Message)
        End Try

        Try
            p.Nombre = ""
        Catch ex As ValorInvalidoException
            Console.WriteLine(ex.Message)
        End Try

        Try
            p.Nombre = "esta es una cadena muy larga para ser asignada"
        Catch ex As ValorInvalidoException
            Console.WriteLine(ex.Message)
            ' muestra los valores adicionales almacenados en data
            For Each v As DictionaryEntry In ex.Data
                Console.WriteLine("{0} = {1}", v.Key, v.Value)
            Next
        End Try

        Try
            p.fechaNacimiento = "2100-1-1"
        Catch ex As ValorInvalidoException
            Console.WriteLine(ex.Message)
            For Each v As DictionaryEntry In ex.Data
                Console.WriteLine("{0} = {1}", v.Key, v.Value)
            Next
        End Try
        ' muestra getters
        ' todos deben estar con el valor predeterminado
        Console.WriteLine(p)
        Console.WriteLine(p.id)
        Console.WriteLine(p.Nombre)
        Console.WriteLine(p.fechaNacimiento)

        ' un test mediante constructor sobrecargado que lanza excepción
        Try
            Dim q As New Allien(0, "Juan Perez", "1989-10-28")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        ' un test ok
        Try
            Dim q As New Allien(453454, "Juan Perez", "1989-10-28")
            Console.WriteLine(q)
            Console.WriteLine(q.id)
            Console.WriteLine(q.Nombre)
            Console.WriteLine(q.fechaNacimiento)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub
End Module
