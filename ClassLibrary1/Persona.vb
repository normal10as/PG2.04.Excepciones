Public Class Persona
    Private _id As String
    Private _nombre As String
    Private _fechaNacimiento As Date

    Sub New()
        _id = ""
        _nombre = ""
        _fechaNacimiento = Nothing
    End Sub

    Sub New(ByVal Id As Integer, ByVal Nombre As String, ByVal FechaNacimiento As Date)
        Me.id = Id
        Me.Nombre = Nombre
        Me.fechaNacimiento = FechaNacimiento
    End Sub

    Public Property id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            ' evalua que el valor sea cero o menor
            If value <= 0 Or value = Nothing Then
                Throw New Exception("Id debe ser mayor a cero")
            End If
            _id = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            ' evalua que el valor sea vacio
            If value = "" Or value = Nothing Then
                Throw New Exception("El nombre no puede estar vacio")
            End If
            ' evalua que la cadena muy larga
            If value.Length > 30 Then
                Throw New Exception("El nombre es muy largo")
            End If
            _nombre = value
        End Set
    End Property

    Public Property fechaNacimiento() As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As Date)
            ' la fecha no puede ser vacia
            If value = Nothing Then
                Throw New Exception("La fecha no puede estar vacia")
            End If
            ' evalua que la fecha sea superior a hoy
            If value > Today() Then
                Throw New Exception("La fecha no debe ser superior a la actual")
            End If
            _fechaNacimiento = value
        End Set
    End Property

    Public Overrides Function toString() As String
        Return id & " " & Nombre
    End Function

End Class

