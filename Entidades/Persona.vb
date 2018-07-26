Imports Entidades

Public MustInherit Class Persona
    Implements Entidad
    Private _nombre As String
    Private _fechanacimiento As Date

    Sub New()
        _nombre = ""
        _fechanacimiento = Nothing
    End Sub

    Sub New(nombre As String, fechanacimiento As Date)
        Me._nombre = nombre
        Me._fechanacimiento = fechanacimiento
    End Sub

    Public Property FechaNacimiento As Date
        Get
            Return _fechanacimiento
        End Get
        Set(value As Date)
            _fechanacimiento = value
        End Set
    End Property


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

End Class
