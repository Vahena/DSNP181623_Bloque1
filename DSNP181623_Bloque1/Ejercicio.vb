Module Ejercicio
    Sub Ejercicio1()
        While (True)
            Try
                Dim edad As Byte

                Console.WriteLine("Ingrese su edad:")
                edad = Console.ReadLine

                Select Case edad
                    Case 0 To 17
                        Console.WriteLine("Eres menor de edad")
                    Case 18 To 127
                        Console.WriteLine("Eres mayor de edad")
                    Case Else
                        Console.WriteLine("Deberian darte un record Guiness!")
                End Select



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

        Console.ReadLine()
    End Sub
End Module
