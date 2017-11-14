Imports ClassLibrary1

Module PersonaTest
    Sub main()
        Dim p As New Persona()
        ' lanza excepciones en los setters por cada propiedad
        Try
            p.id = -1
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Try
            p.Nombre = ""
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Try
            p.Nombre = "esta es una cadena muy larga para ser asignada"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Try
            p.fechaNacimiento = "2100-1-1"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Try
            p.fechaNacimiento = Nothing
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Try
            p.fechaNacimiento = "21"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        ' muestra getters
        ' todos deben estar con el valor predeterminado
        Console.WriteLine("ToString: " & p.toString)
        Console.WriteLine("ID: " & p.id)
        Console.WriteLine("Nombre: " & p.Nombre)
        Console.WriteLine("Nacimiento: " & p.fechaNacimiento)

        ' un test mediante constructor sobrecargado que lanza excepción
        Try
            Dim q As New Persona(0, "Juan Perez", "1989-10-28")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        ' un test ok
        Try
            Dim q As New Persona(453454, "Juan Perez", "1989-10-28")
            Console.WriteLine("ToString: " & q.toString)
            Console.WriteLine("ID: " & q.id)
            Console.WriteLine("Nombre: " & q.Nombre)
            Console.WriteLine("Nacimiento: " & q.fechaNacimiento)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub
End Module
