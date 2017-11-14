Public Class ValorInvalidoException
    Inherits Exception

    Sub New()
        ' de forma predeterminada se genera un mensaje personalizado
        MyBase.New("Valor inválido")
    End Sub

    Sub New(ByVal Mensaje As String)
        ' Cosntructor para personalizar el mensaje
        MyBase.New(Mensaje)
    End Sub

    Sub New(ByVal Mensaje As String, ByVal Clave As String, ByVal Valor As String)
        ' Cosntructor para personalizar el mensaje y agregar información sobre el error
        MyBase.New(Mensaje)
        Data.Add(Clave, Valor)
    End Sub

    Sub New(ByVal Mensaje As String, ByVal Clave1 As String, ByVal Valor1 As String, ByVal Clave2 As String, ByVal Valor2 As String)
        ' Cosntructor para personalizar el mensaje y agregar información sobre el error
        MyBase.New(Mensaje)
        Data.Add(Clave1, Valor1)
        Data.Add(Clave2, Valor2)
    End Sub

End Class
