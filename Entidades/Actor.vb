Imports Entidades

Public NotInheritable Class Actor
    Inherits Persona
    Implements Entidad
    Private Shared _newid As Integer
    Private _ID As Integer

    Sub New()
        _newid = _newid + 1
        _ID = _newid
    End Sub

    Public Sub New(fechanacimiento As Date, nombre As String)
        MyBase.New(nombre, fechanacimiento)
    End Sub



    Public ReadOnly Property Id As Integer
        Get
            Return _ID

        End Get
    End Property


    Public Overrides Function ToString() As String
        Return "nombre  " & Nombre
    End Function
End Class
