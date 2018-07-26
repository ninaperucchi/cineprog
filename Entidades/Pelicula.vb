Imports Entidades

Public Class Pelicula
    Implements Entidad
    Private _nombre As String
    Private _personajes As List(Of Personaje)

    Sub New()
        _nombre = ""
        _personajes = New List(Of Personaje)
    End Sub



    Public Property Nombre As String Implements Entidad.nombre
        Get
            Return _nombre
        End Get
        Set(value As String)

            If Len(value) > 5 Then
                _nombre = value
            Else
                Throw New ArgumentException("nombre muy corto")
            End If

        End Set
    End Property


    Public Sub AddPersonaje(personaje As Personaje)

        _personajes.Add(personaje)

    End Sub

    Public Function Creditos() As List(Of String)

        Dim lista As New List(Of String)
        For Each personajes As Personaje In _personajes
            lista.Add("actor:" & personajes.Actor.Nombre & "({0})" & personajes.Nombre)

        Next
        lista.Sort()
        Return lista
    End Function

    Public Function SumarSueldos() As Decimal
        Dim sumas As Decimal
        For Each personaje As Personaje In _personajes
            sumas = sumas + personaje.Sueldo

        Next
        Return sumas
    End Function

    Public Function TopSueldos() As List(Of String)
        Dim lista As New List(Of String)
        Dim mayor, mayor2, mayor3 As Integer
        Dim nombre, nombre2, nombre3 As String
        nombre3 = ""
        nombre2 = ""
        nombre = ""
        mayor = 0
        mayor2 = 0
        mayor3 = 0
        For Each top As Personaje In _personajes
            If (top.Sueldo >= mayor) Then
                mayor3 = mayor2
                nombre3 = nombre2
                mayor2 = mayor
                nombre2 = nombre
                nombre = top.Nombre
                mayor = top.Sueldo
            End If
        Next
        lista.Add("nombre: " & nombre & " sueldo: " & mayor)
        lista.Add("nombre: " & nombre2 & " sueldo: " & mayor2)
        lista.Add("nombre: " & nombre3 & " sueldo: " & mayor3)
        Return lista
    End Function


    Public Overrides Function ToString() As String
        Return "nombre  " & _nombre
    End Function

End Class
