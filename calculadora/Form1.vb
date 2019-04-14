Public Class Form1

    Dim opcion As String
    Dim num1 As Nullable(Of Double) = Nothing
    Dim num2 As Nullable(Of Double) = Nothing
    Dim bandera As Boolean

    Private Sub ButtonNUEVE_Click(sender As Object, e As EventArgs) Handles ButtonNUEVE.Click
        'Dim nueve As Operaciones4 = New Operaciones4
        'Dim nuevel As Operaciones4 = New Operaciones4
        limpiar()
        'nueve.nine()
        TextBoxResultado.Text &= "9"
    End Sub

    Private Sub ButtonOCHO_Click(sender As Object, e As EventArgs) Handles ButtonOCHO.Click
        'Dim ocho As Operaciones4 = New Operaciones4
        'Dim ochoL As Operaciones4 = New Operaciones4
        limpiar()
        'ocho.eight()
        TextBoxResultado.Text &= "8"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSIETE.Click
        'Dim siete As Operaciones4 = New Operaciones4
        'Dim sietel As Operaciones4 = New Operaciones4
        limpiar()
        'siete.seven()
        TextBoxResultado.Text &= "7"

    End Sub

    Private Sub ButtonSEIS_Click(sender As Object, e As EventArgs) Handles ButtonSEIS.Click
        ' Dim seis As Operaciones4 = New Operaciones4
        'Dim seisl As Operaciones4 = New Operaciones4
        limpiar()
        'seis.six()
        TextBoxResultado.Text &= "6"
    End Sub

    Private Sub ButtonCINCO_Click(sender As Object, e As EventArgs) Handles ButtonCINCO.Click
        'Dim cinco As Operaciones4 = New Operaciones4
        'Dim cincol As Operaciones4 = New Operaciones4
        limpiar()
        'cinco.five()
        TextBoxResultado.Text &= "5"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles ButtonCUATRO.Click
        'Dim cuatro As Operaciones4 = New Operaciones4
        'Dim cuatrol As Operaciones4 = New Operaciones4
        'limpiar()
        'cuatro.four()
        TextBoxResultado.Text &= "4"
    End Sub

    Private Sub ButtonTRES_Click(sender As Object, e As EventArgs) Handles ButtonTRES.Click
        ' Dim tres As Operaciones4 = New Operaciones4
        'Dim tresl As Operaciones4 = New Operaciones4
        limpiar()
        ' tres.three()
        TextBoxResultado.Text &= "3"
    End Sub

    Private Sub ButtonDOS_Click(sender As Object, e As EventArgs) Handles ButtonDOS.Click
        ' Dim dos As Operaciones4 = New Operaciones4
        'Dim dosl As Operaciones4 = New Operaciones4
        limpiar()
        'dos.two()
        TextBoxResultado.Text &= "2"
    End Sub

    Private Sub ButtonUNO_Click(sender As Object, e As EventArgs) Handles ButtonUNO.Click
        ' Dim uno As Operaciones4 = New Operaciones4
        'Dim unol As Operaciones4 = New Operaciones4
        limpiar()
        'uno.one()
        TextBoxResultado.Text &= "1"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        'Dim cero As Operaciones4 = New Operaciones4
        'Dim cerol As Operaciones4 = New Operaciones4
        limpiar()
        'cero.zero()
        TextBoxResultado.Text &= "0"
    End Sub

    Private Sub ButtonPunto_Click(sender As Object, e As EventArgs) Handles ButtonPunto.Click
        'Dim punto2 As Operaciones4 = New Operaciones4
        'Dim punto2 As Operaciones4 = New Operaciones4
        'punto.limpiar()
        Metodopunto()
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        'Dim borrar As Operaciones4 = New Operaciones4
        metodoborrar()
    End Sub

    Private Sub ButtonResultado_Click(sender As Object, e As EventArgs) Handles ButtonResultado.Click
        'Dim resul As Operaciones4 = New Operaciones4
        accion()
        opcion = ""
    End Sub

    Private Sub ButtonSuma_Click(sender As Object, e As EventArgs) Handles ButtonSuma.Click
        'Dim suma As Operaciones4 = New Operaciones4
        accion()
        opcion = "+"
    End Sub

    Private Sub ButtonResta_Click(sender As Object, e As EventArgs) Handles ButtonResta.Click
        'Dim resta As Operaciones4 = New Operaciones4
        accion()
        opcion = "-"
    End Sub

    Private Sub ButtonMultiplicacion_Click(sender As Object, e As EventArgs) Handles ButtonMultiplicacion.Click
        'Dim multiplicacion As Operaciones4 = New Operaciones4
        accion()
        opcion = "*"
    End Sub

    Private Sub ButtonDivision_Click(sender As Object, e As EventArgs) Handles ButtonDivision.Click
        'Dim division As Operaciones4 = New Operaciones4
        accion()
        opcion = "/"
    End Sub

    '----- MÉTODOS ------
    '---- Método realizar operacion---
    Public Sub accion()
        bandera = True
        num2 = Val(TextBoxResultado.Text)
        If num1 IsNot Nothing Then
            Select Case opcion
                Case "+"
                    num1 = num1 + num2
                Case "-"
                    num1 -= num2
                Case "*"
                    num1 *= num2
                Case "/"
                    num1 /= num2
            End Select
            TextBoxResultado.Text = num1
        Else
            num1 = num2
        End If
    End Sub
    '------- Método limpiar la pantalla ------
    Public Sub limpiar()
        If bandera = True Then
            TextBoxResultado.Text = ""
            bandera = False
        ElseIf TextBoxResultado.Text = "0" Then
            TextBoxResultado.Text = ""
        End If
    End Sub
    '---- Método para no poner más de un punto ------
    Public Sub Metodopunto()
        If InStr(TextBoxResultado.Text, ".", CompareMethod.Text) = 0 Then
            TextBoxResultado.Text &= "."
        End If
    End Sub
    '----- Método para borrar todo de la pantalla ------
    Public Sub metodoborrar()
        TextBoxResultado.Text = "0"
        num2 = Nothing
        num1 = Nothing
    End Sub

End Class
