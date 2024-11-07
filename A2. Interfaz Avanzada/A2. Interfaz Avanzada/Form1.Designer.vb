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
        ComboBoxMenu = New ComboBox()
        LabelResultado = New Label()
        TextBoxNum1 = New TextBox()
        TextBoxNum2 = New TextBox()
        TextBoxNum3 = New TextBox()
        ButtonCalcular = New Button()
        LabelTitulo = New Label()
        Label1 = New Label()
        LabelOperation2 = New Label()
        LabelOperation1 = New Label()
        SuspendLayout()
        ' 
        ' ComboBoxMenu
        ' 
        ComboBoxMenu.FormattingEnabled = True
        ComboBoxMenu.Location = New Point(33, 47)
        ComboBoxMenu.Name = "ComboBoxMenu"
        ComboBoxMenu.Size = New Size(353, 23)
        ComboBoxMenu.TabIndex = 0
        ' 
        ' LabelResultado
        ' 
        LabelResultado.AutoSize = True
        LabelResultado.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelResultado.Location = New Point(254, 142)
        LabelResultado.Name = "LabelResultado"
        LabelResultado.Size = New Size(92, 21)
        LabelResultado.TabIndex = 1
        LabelResultado.Text = "Resultado:"
        ' 
        ' TextBoxNum1
        ' 
        TextBoxNum1.Location = New Point(25, 140)
        TextBoxNum1.Name = "TextBoxNum1"
        TextBoxNum1.Size = New Size(57, 23)
        TextBoxNum1.TabIndex = 2
        ' 
        ' TextBoxNum2
        ' 
        TextBoxNum2.Location = New Point(108, 140)
        TextBoxNum2.Name = "TextBoxNum2"
        TextBoxNum2.Size = New Size(57, 23)
        TextBoxNum2.TabIndex = 3
        ' 
        ' TextBoxNum3
        ' 
        TextBoxNum3.Location = New Point(191, 140)
        TextBoxNum3.Name = "TextBoxNum3"
        TextBoxNum3.Size = New Size(57, 23)
        TextBoxNum3.TabIndex = 4
        ' 
        ' ButtonCalcular
        ' 
        ButtonCalcular.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonCalcular.Location = New Point(33, 187)
        ButtonCalcular.Name = "ButtonCalcular"
        ButtonCalcular.Size = New Size(353, 38)
        ButtonCalcular.TabIndex = 5
        ButtonCalcular.Text = "Calcular"
        ButtonCalcular.UseVisualStyleBackColor = True
        ' 
        ' LabelTitulo
        ' 
        LabelTitulo.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitulo.Location = New Point(33, 73)
        LabelTitulo.Name = "LabelTitulo"
        LabelTitulo.Size = New Size(353, 28)
        LabelTitulo.TabIndex = 6
        LabelTitulo.Text = "Operación Seleccionada"
        LabelTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(75, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(271, 21)
        Label1.TabIndex = 7
        Label1.Text = "Selecciona la operación a realizar"
        ' 
        ' LabelOperation2
        ' 
        LabelOperation2.AutoSize = True
        LabelOperation2.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        LabelOperation2.Location = New Point(171, 143)
        LabelOperation2.Name = "LabelOperation2"
        LabelOperation2.Size = New Size(14, 16)
        LabelOperation2.TabIndex = 8
        LabelOperation2.Text = "×"
        ' 
        ' LabelOperation1
        ' 
        LabelOperation1.AutoSize = True
        LabelOperation1.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        LabelOperation1.Location = New Point(88, 142)
        LabelOperation1.Name = "LabelOperation1"
        LabelOperation1.Size = New Size(14, 16)
        LabelOperation1.TabIndex = 9
        LabelOperation1.Text = "×"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(425, 237)
        Controls.Add(LabelOperation1)
        Controls.Add(LabelOperation2)
        Controls.Add(Label1)
        Controls.Add(LabelTitulo)
        Controls.Add(ButtonCalcular)
        Controls.Add(TextBoxNum3)
        Controls.Add(TextBoxNum2)
        Controls.Add(TextBoxNum1)
        Controls.Add(LabelResultado)
        Controls.Add(ComboBoxMenu)
        Name = "Form1"
        Text = "A2 - Interfaz Avanzada"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBoxMenu As ComboBox
    Friend WithEvents LabelResultado As Label
    Friend WithEvents TextBoxNum1 As TextBox
    Friend WithEvents TextBoxNum2 As TextBox
    Friend WithEvents TextBoxNum3 As TextBox
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelOperation2 As Label
    Friend WithEvents LabelOperation1 As Label

End Class
