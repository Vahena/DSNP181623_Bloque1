Module Ejercicio2
    Sub Ejercicio2()
        While (True)
            Try
                Dim numero As Integer
                Console.WriteLine("Ingrese un numero entero:")
                numero = Console.ReadLine()

                If (numero < 0) Then
                    Console.WriteLine("Es un numero negativo")
                ElseIf (numero > 0) Then
                    Console.WriteLine("Es un numero positivo")

                End If

                Console.WriteLine("Si desea volver al menu presione (s) si no enter:")
                Dim salir As ConsoleKeyInfo = Console.ReadKey()
                If salir.Key = ConsoleKey.S Then
                    Console.Clear()
                    Module1.Main()

                ElseIf salir.Key = ConsoleKey.Enter Then
                End If

            Catch x As Exception
                Console.WriteLine("Ingrese solo valores enteros")
            End Try
        End While

        Console.ReadLine()


    End Sub
End Module
