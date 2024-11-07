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
        LabelResultado.Location = New Point(325, 142)
        LabelResultado.Name = "LabelResultado"
        LabelResultado.Size = New Size(61, 21)
        LabelResultado.TabIndex = 1
        LabelResultado.Text = "Label1"
        ' 
        ' TextBoxNum1
        ' 
        TextBoxNum1.Location = New Point(33, 144)
        TextBoxNum1.Name = "TextBoxNum1"
        TextBoxNum1.Size = New Size(68, 23)
        TextBoxNum1.TabIndex = 2
        ' 
        ' TextBoxNum2
        ' 
        TextBoxNum2.Location = New Point(228, 144)
        TextBoxNum2.Name = "TextBoxNum2"
        TextBoxNum2.Size = New Size(68, 23)
        TextBoxNum2.TabIndex = 3
        ' 
        ' TextBoxNum3
        ' 
        TextBoxNum3.Location = New Point(133, 142)
        TextBoxNum3.Name = "TextBoxNum3"
        TextBoxNum3.Size = New Size(68, 23)
        TextBoxNum3.TabIndex = 4
        ' 
        ' ButtonCalcular
        ' 
        ButtonCalcular.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonCalcular.Location = New Point(33, 187)
        ButtonCalcular.Name = "ButtonCalcular"
        ButtonCalcular.Size = New Size(353, 38)
        ButtonCalcular.TabIndex = 5
        ButtonCalcular.Text = "Button1"
        ButtonCalcular.UseVisualStyleBackColor = True
        ' 
        ' LabelTitulo
        ' 
        LabelTitulo.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitulo.Location = New Point(33, 89)
        LabelTitulo.Name = "LabelTitulo"
        LabelTitulo.Size = New Size(353, 28)
        LabelTitulo.TabIndex = 6
        LabelTitulo.Text = "Label1"
        LabelTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(184, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 21)
        Label1.TabIndex = 7
        Label1.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(425, 237)
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

End Class
