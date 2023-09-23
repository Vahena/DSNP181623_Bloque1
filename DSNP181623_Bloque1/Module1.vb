Module Module1

    Sub Main()
        While (True)

            Console.WriteLine("Ejercicios")
            Console.WriteLine("1- Menor o mayor de edad")
            Console.WriteLine("2- Positivo o Negativo")
            Console.WriteLine("3- Descuento")
            Console.WriteLine("4- Suma de n hasta m")
            Console.WriteLine("5- Tablas de multiplicar")
            Console.WriteLine("Escriba el numero de ejercicio o presione (s) si desea salir:")


            Dim opcion As String
            opcion = Console.ReadLine

            Select Case opcion
                Case 1
                    Console.Clear()
                    Ejercicio.Ejercicio1()

                Case 2
                    Console.Clear()
                    Ejercicio2.Ejercicio2()

                Case 3
                    Console.Clear()
                    Ejercicio3.Ejercicio3()

                Case 4
                    Console.Clear()
                    Ejercicio4.Ejercicio4()

                Case 5
                    Console.Clear()
                    Ejercicio5.ejercicio5()

                Case "s"
                    Exit While
                Case "S"
                    Exit While
                Case Else
                    Console.WriteLine("Error--Indique el numero de ejercicio. Presione enter para continuar o (s) para salir")
            End Select

            Dim continuar As ConsoleKeyInfo = Console.ReadKey
            If continuar.Key = ConsoleKey.Enter Then
                Console.Clear()
            ElseIf continuar.Key = ConsoleKey.S Then
                Return
            End If

        End While


    End Sub
End Module
