Module Ejercicio5
    Sub ejercicio5()


        While (True)
            Try
                Dim NumTabla As SByte
                Console.WriteLine("Ingrese el numero de la tabla:")
                NumTabla = Console.ReadLine()

                Console.WriteLine("La tabla del " + NumTabla.ToString + " es")

                For i = 1 To 10
                    Console.WriteLine(NumTabla.ToString + "x" + i.ToString + "=" + (NumTabla * i).ToString)
                Next
                Console.WriteLine("Si desea volver al menu presione (s) si no enter:")
                Dim salir As ConsoleKeyInfo = Console.ReadKey()
                If salir.Key = ConsoleKey.S Then
                    Console.Clear()
                    Module1.Main()
                ElseIf salir.Key = ConsoleKey.Enter Then
                    Console.Clear()
                End If
            Catch x As Exception
                Console.WriteLine("Error")
            End Try

        End While

    End Sub
End Module
