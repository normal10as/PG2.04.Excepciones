Public Class Allien
    Private _id As String
    Private _nombre As String
    Private _fechaNacimiento As String

    Sub New()
        _id = ""
        _nombre = ""
        _fechaNacimiento = ""
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
            If value <= 0 Then
                Throw New ValorInvalidoException()
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
            If value = "" Then
                Throw New ValorInvalidoException("El nombre no puede estar vacio")
            End If
            ' evalua que la cadena muy larga
            If value.Length > 30 Then
                Throw New ValorInvalidoException("El nombre es muy largo", "Nombre", value)
            End If
            _nombre = value
        End Set
    End Property

    Public Property fechaNacimiento() As String
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As String)
            ' evalua que la fecha sea superior a hoy
            If value > Today() Then
                Throw New ValorInvalidoException("La fecha no debe ser superior a la actual", "fechaNacimiento", value, "Fecha Máxima", Today())
            End If
            _fechaNacimiento = value
        End Set
    End Property

    Public Overrides Function toString() As String
        Return id & " " & Nombre
    End Function

End Class
