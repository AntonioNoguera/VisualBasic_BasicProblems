<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtNum1 = New TextBox()
        txtNum2 = New TextBox()
        cmbOperacion = New ComboBox()
        Button1 = New Button()
        lblResultado = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtNum1
        ' 
        txtNum1.Location = New Point(23, 76)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(121, 23)
        txtNum1.TabIndex = 0
        ' 
        ' txtNum2
        ' 
        txtNum2.Location = New Point(23, 124)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(121, 23)
        txtNum2.TabIndex = 1
        ' 
        ' cmbOperacion
        ' 
        cmbOperacion.FormattingEnabled = True
        cmbOperacion.Items.AddRange(New Object() {"Suma", "Resta", "Multiplicación", "División"})
        cmbOperacion.Location = New Point(23, 183)
        cmbOperacion.Name = "cmbOperacion"
        cmbOperacion.Size = New Size(121, 23)
        cmbOperacion.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(23, 244)
        Button1.Name = "Button1"
        Button1.Size = New Size(323, 23)
        Button1.TabIndex = 3
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(229, 132)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(96, 15)
        lblResultado.TabIndex = 4
        lblResultado.Text = "Ingresa tus datos"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(10, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(340, 19)
        Label1.TabIndex = 5
        Label1.Text = "Estructura Selectiva 1 - Calculadora Simple"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 6
        Label2.Text = "Valor 1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(60, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 7
        Label3.Text = "Valor 2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(50, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 15)
        Label4.TabIndex = 8
        Label4.Text = "Operación"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(229, 107)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 18)
        Label5.TabIndex = 9
        Label5.Text = "Resultado"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(361, 284)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblResultado)
        Controls.Add(Button1)
        Controls.Add(cmbOperacion)
        Controls.Add(txtNum2)
        Controls.Add(txtNum1)
        Name = "Form1"
        Text = "2077402 - Noguera Guzmán"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents cmbOperacion As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
