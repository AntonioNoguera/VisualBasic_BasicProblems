Public Class Form1
    Private currentOperator As String = ""
    Private firstNumber As Double = 0
    Private secondNumber As Double = 0
    Private isOperatorPressed As Boolean = False

    Private Sub NumberButton_Click(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        If DisplayTextBox.Text = "0" OrElse isOperatorPressed Then
            DisplayTextBox.Text = button.Text
            isOperatorPressed = False
        Else
            DisplayTextBox.Text += button.Text
        End If
    End Sub

    Private Sub OperatorButton_Click(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        firstNumber = Double.Parse(DisplayTextBox.Text)
        currentOperator = button.Text
        isOperatorPressed = True
    End Sub

    Private Sub EqualsButton_Click(sender As Object, e As EventArgs)
        secondNumber = Double.Parse(DisplayTextBox.Text)

        Select Case currentOperator
            Case "+"
                DisplayTextBox.Text = (firstNumber + secondNumber).ToString()
            Case "-"
                DisplayTextBox.Text = (firstNumber - secondNumber).ToString()
            Case "*"
                DisplayTextBox.Text = (firstNumber * secondNumber).ToString()
            Case "/"
                If secondNumber <> 0 Then
                    ' Limitar el resultado de la división a 4 dígitos decimales
                    DisplayTextBox.Text = (firstNumber / secondNumber).ToString("F4")
                Else
                    DisplayTextBox.Text = "Error"
                End If
        End Select

        isOperatorPressed = False
    End Sub


    Private Sub ClearButton_Click(sender As Object, e As EventArgs)
        DisplayTextBox.Text = "0"
        firstNumber = 0
        secondNumber = 0
        currentOperator = ""
    End Sub

    Private Sub DotButton_Click(sender As Object, e As EventArgs)
        If Not DisplayTextBox.Text.Contains(".") Then
            DisplayTextBox.Text += "."
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Añadir el listener de los botones numéricos
        AddHandler Btn0.Click, AddressOf NumberButton_Click
        AddHandler Btn1.Click, AddressOf NumberButton_Click
        AddHandler Btn2.Click, AddressOf NumberButton_Click
        AddHandler Btn3.Click, AddressOf NumberButton_Click
        AddHandler Btn4.Click, AddressOf NumberButton_Click
        AddHandler Btn5.Click, AddressOf NumberButton_Click
        AddHandler Btn6.Click, AddressOf NumberButton_Click
        AddHandler Btn7.Click, AddressOf NumberButton_Click
        AddHandler Btn8.Click, AddressOf NumberButton_Click
        AddHandler Btn9.Click, AddressOf NumberButton_Click

        ' Asociar los botones de operadores y funcionalidades adicionales
        AddHandler BtnAdd.Click, AddressOf OperatorButton_Click    ' Botón de suma (+)
        AddHandler BtnSubtract.Click, AddressOf OperatorButton_Click    ' Botón de resta (-)
        AddHandler BtnMultiply.Click, AddressOf OperatorButton_Click    ' Botón de multiplicación (*)
        AddHandler BtnDivide.Click, AddressOf OperatorButton_Click    ' Botón de división (/)

        ' Asociar el botón de igual
        AddHandler BtnEquals.Click, AddressOf EqualsButton_Click

        ' Asociar el botón de punto decimal
        AddHandler BtnDot.Click, AddressOf DotButton_Click

        ' Asociar el botón de limpiar
        AddHandler BtnClear.Click, AddressOf ClearButton_Click
    End Sub
End Class
