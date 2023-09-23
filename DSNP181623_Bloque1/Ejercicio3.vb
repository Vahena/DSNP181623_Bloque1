Module Ejercicio3
    Sub Ejercicio3()
        While (True)
            Try
                Console.WriteLine("Ingrese el monto de compra: $")
                Dim monto, total As Double
                Dim descuento As Double
                monto = Console.ReadLine()

                If (monto > 0 And monto < 250) Then
                    Console.WriteLine("Descuento del 5%")
                    descuento = 0.05 * monto
                ElseIf (monto >= 250 And monto < 500) Then
                    Console.WriteLine("Descuento del 10%")
                    descuento = 0.1 * monto
                ElseIf (monto >= 500 And monto < 1000) Then
                    Console.WriteLine("Descuento del 20%")
                    descuento = 0.2 * monto
                ElseIf (monto >= 1000) Then
                    Console.WriteLine("Descuento del 30%")
                    descuento = 0.3 * monto
                End If

                Console.WriteLine("Descuento total: $" + descuento.ToString)

                total = monto - descuento
                Console.WriteLine("Su total a pagar es de: $" + total.ToString)
                Console.WriteLine("Si desea volver al menu presione (s) si no enter:")
                Dim salir As ConsoleKeyInfo = Console.ReadKey()
                If salir.Key = ConsoleKey.S Then
                    Console.Clear()
                    Module1.Main()
                End If

            Catch x As Exception
                Console.WriteLine("Ingrese valores enteros")
            End Try
        End While
    End Sub
End Module
