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
        Button1 = New Button()
        txtEdad = New TextBox()
        lblResultado = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 144)
        Button1.Name = "Button1"
        Button1.Size = New Size(321, 23)
        Button1.TabIndex = 0
        Button1.Text = "Verificar Mayoría de Edad"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtEdad
        ' 
        txtEdad.Location = New Point(50, 88)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(91, 23)
        txtEdad.TabIndex = 1
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(212, 91)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(88, 15)
        lblResultado.TabIndex = 2
        lblResultado.Text = "Ingresa tu edad"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(318, 19)
        Label1.TabIndex = 3
        Label1.Text = "Estructura Selectiva 3 - Mayoría de Edad"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(50, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 4
        Label2.Text = "Ingresa tu edad:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(212, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 16)
        Label3.TabIndex = 5
        Label3.Text = "Resultado:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(345, 176)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblResultado)
        Controls.Add(txtEdad)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "2077402 - Noguera Guzmán"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
