Public Class Form1
    Private Sub CmbIniciar_Click(sender As Object, e As EventArgs) Handles CmbIniciar.Click
        Dim cantidad, nota, total As Short
        Dim promedio As Single
        Dim letra As String

        cantidad = Val(TXTCANTIDAD.Text)
        total = 0

        For i = 1 To cantidad
            nota = Val(InputBox("Introduzca la nota" & i & " del estudiante"))
            LSTRESPUESTAS.Items.Add("La nota " & i & "es: " & nota)
            total = total + nota
        Next

        promedio = total / cantidad
        LSTRESPUESTAS.Items.Add("....................")
        LSTRESPUESTAS.Items.Add("el promedio final es: " & promedio)

        LSTRESPUESTAS.Items.Add("")
        LSTRESPUESTAS.Items.Add("....................")

        If (promedio >= 91) Then
            letra = "A"
        ElseIf (promedio >= 81) Then
            letra = "B"
        ElseIf (promedio >= 71) Then
            letra = "C"
        ElseIf (promedio >= 61) Then
            letra = "D"
        Else
            letra = "F"
        End If

        If (promedio >= 61) Then
            LSTRESPUESTAS.Items.Add("Usted aprobó el curso con " & letra)
        Else
            LSTRESPUESTAS.Items.Add("Usted reprobó el curso con " & letra)
        End If

    End Sub

    Private Sub CmbLimpiar_Click(sender As Object, e As EventArgs) Handles CmbLimpiar.Click
        TXTCANTIDAD.Clear()
        LSTRESPUESTAS.Items.Clear()
        TXTCANTIDAD.Focus()

    End Sub
End Class
