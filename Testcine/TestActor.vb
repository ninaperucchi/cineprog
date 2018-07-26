Imports Entidades
Module TestActor

    Sub Main()
        Try
            Dim actor As Actor
            actor = New Actor
            actor.Nombre = "jose"
            actor.FechaNacimiento = #10/10/1987#
            Console.WriteLine(actor.ToString & " id: " & actor.Id)
            Dim actor2 As New Actor(#10/10/1984#, "caputo")
            Console.WriteLine(actor2.ToString & " id: " & actor2.Id)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim actor3 As New Actor(#10/10/1988#, "pepe argento")
            Console.WriteLine(actor3.ToString & " id: " & actor3.Id)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()
    End Sub

End Module
