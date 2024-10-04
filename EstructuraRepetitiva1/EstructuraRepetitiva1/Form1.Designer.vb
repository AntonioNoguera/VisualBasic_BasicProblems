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
        txtNumero = New TextBox()
        Button1 = New Button()
        lstResultados = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtNumero
        ' 
        txtNumero.Location = New Point(20, 84)
        txtNumero.Name = "txtNumero"
        txtNumero.Size = New Size(120, 23)
        txtNumero.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(20, 113)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 23)
        Button1.TabIndex = 1
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lstResultados
        ' 
        lstResultados.FormattingEnabled = True
        lstResultados.ItemHeight = 15
        lstResultados.Location = New Point(182, 71)
        lstResultados.Name = "lstResultados"
        lstResultados.Size = New Size(120, 154)
        lstResultados.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(8, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(297, 16)
        Label1.TabIndex = 3
        Label1.Text = "Estructura Repetitiva 1 - Tabla de Multiplicar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 30)
        Label2.TabIndex = 4
        Label2.Text = "Ingresa el número" & vbCrLf & "a calcular la tabla"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(207, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 5
        Label3.Text = "Resultados"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(314, 237)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lstResultados)
        Controls.Add(Button1)
        Controls.Add(txtNumero)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lstResultados As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
