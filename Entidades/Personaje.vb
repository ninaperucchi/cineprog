Public Class Personaje
    Private _nombre As String
    Private _sueldo As Decimal
    Private _actor As New Actor

    Sub New()
        _nombre = ""
        _sueldo = Nothing
        _actor = Actor
    End Sub

    Sub New(nombre As String, actor As Actor, sueldo As Decimal)
        Me._nombre = nombre
        Me._sueldo = sueldo
        _actor = actor
    End Sub

    Public Property Nombre As String
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


    Public Property Sueldo As Decimal
        Get
            Return _sueldo
        End Get
        Set(value As Decimal)

            If value >= 0 Then
                _sueldo = value
            Else
                Throw New ArgumentException("sueldo negativo")
            End If

        End Set
    End Property


    Public Property Actor As Actor
        Get
            Return _actor
        End Get
        Set(value As Actor)
            _actor = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return "personaje " & _nombre & " sueldo " & _sueldo & " actor " & _actor.Nombre
    End Function
End Class
