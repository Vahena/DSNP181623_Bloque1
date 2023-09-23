Module Module1

    Sub Main()
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



                Console.WriteLine("Si desea salir presione (s) si no enter:")
                Dim salir As ConsoleKeyInfo = Console.ReadKey()
                If salir.Key = ConsoleKey.S Then
                    Return
                ElseIf salir.Key = ConsoleKey.Enter Then
                End If
            Catch x As Exception
                Console.WriteLine("Ingrese valores enteros")
            End Try

        End While

        Console.ReadLine()

    End Sub

End Module
