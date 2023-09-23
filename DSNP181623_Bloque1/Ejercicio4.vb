Module Ejercicio4
    Sub Ejercicio4()
        While (True)
            Try
                Dim numero1, numero2, suma As Long
                Console.WriteLine("Ingrese el primer valor entero:")
                numero1 = Console.ReadLine()

                Console.WriteLine("Ingrese el segundo valor entero:")
                numero2 = Console.ReadLine


                suma = 0
                If numero1 < numero2 Then
                    For i As Integer = numero1 To numero2
                        suma += i
                    Next
                    Console.WriteLine("La suma total de " + numero1.ToString + " hasta " + numero2.ToString + " es:" + suma.ToString)
                ElseIf numero1 > numero2 Then
                    Console.WriteLine("El primer numero debe ser menor que el segundo")
                End If

                Console.WriteLine("Si desea volver al menu presione (s) si no enter:")
                Dim salir As ConsoleKeyInfo = Console.ReadKey()
                If salir.Key = ConsoleKey.S Then
                    Console.Clear()
                    Module1.Main()
                ElseIf salir.Key = ConsoleKey.Enter Then
                End If
            Catch x As Exception
                Console.WriteLine("Error")
            End Try
        End While





    End Sub
End Module
