Module Module1

    Sub Main()
        Dim numero As Double
        Console.Write("Ingrese un numero: ")
        numero = Double.Parse(Console.ReadLine())

        If (numero >= 0) Then

            Console.WriteLine(" Es un numero positivo")

        Else Console.WriteLine("Es un numero negativo")

        End If
    End Sub

End Module
