Imports Entidades
Module TestPelicula
    Sub Main()
        Try

            Dim titanic As New Pelicula
            titanic.Nombre = "titanic"
            Dim actor As New Actor(#10/10/1987#, "yanina")
            Dim actor2 As New Actor(#10/10/1940#, "geremias")
            Dim actor3 As New Actor(#10/10/1933#, "maximiliano")
            Dim actor4 As New Actor(#10/10/1999#, "fabio")
            Dim actor5 As New Actor(#10/10/1988#, "gaturo")

            Dim personaje0 As New Personaje("quepes", actor, 3000)
            Dim personaje1 As New Personaje("caputo", actor2, 4000)
            Dim personaje2 As New Personaje("adam sandler", actor3, 5000)
            Dim personaje3 As New Personaje("quepert", actor4, 5000)
            Dim personaje4 As New Personaje("pesada", actor5, 8000)
            titanic.AddPersonaje(personaje0)
            titanic.AddPersonaje(personaje1)
            titanic.AddPersonaje(personaje2)
            titanic.AddPersonaje(personaje3)
            titanic.AddPersonaje(personaje4)
            Console.WriteLine(titanic.ToString())
            Console.WriteLine(titanic.SumarSueldos())
            Dim lista As List(Of String)
            lista = titanic.TopSueldos()
            For Each a As String In lista
                Console.WriteLine(a)
            Next



        Catch exc As Exception
            Console.WriteLine(exc.Message)
        End Try


        Try

            Dim it As New Pelicula
            it.Nombre = "it"
            Dim actor As New Actor(#10/10/1987#, "yani")
            Dim actor2 As New Actor(#10/10/1940#, "gere")
            Dim actor3 As New Actor(#10/10/1933#, "maxi")
            Dim actor4 As New Actor(#10/10/1999#, "fabi")
            Dim actor5 As New Actor(#10/10/1988#, "gato")

            Dim personaje0 As New Personaje("quep", actor, -60)
            Dim personaje1 As New Personaje("capu", actor2, -4000)
            Dim personaje2 As New Personaje("hada", actor3, -600)
            Dim personaje3 As New Personaje("quep", actor4, -70)
            Dim personaje4 As New Personaje("pesa", actor5, -800)

        Catch ex As Exception

            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try




    End Sub
End Module
