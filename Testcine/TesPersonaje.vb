Imports Entidades
Module TesPersonaje

    Sub Main()
        Dim personaje As New Personaje
        Dim actor As New Actor
        Try
            personaje.Nombre = "raulito"
            actor.FechaNacimiento = #10/10/1987#
            personaje.Sueldo = 456543
            actor.Nombre = "alfonsin"
            personaje.Actor = actor
            Console.WriteLine(personaje.ToString)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


        Dim personaje2 As New Personaje
        Dim actor2 As New Actor
        Try
            personaje2.Nombre = "raul"
            actor2.FechaNacimiento = #10/10/1987#
            personaje2.Sueldo = -44
            actor2.Nombre = "lo"
            personaje2.Actor = actor2
            Console.WriteLine(personaje2.ToString)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try



        Console.ReadKey()


    End Sub

End Module
