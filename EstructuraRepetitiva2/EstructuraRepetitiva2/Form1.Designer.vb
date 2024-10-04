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
        txtNota1 = New TextBox()
        Button1 = New Button()
        lblPromedio = New Label()
        txtNota2 = New TextBox()
        txtNota3 = New TextBox()
        txtNota4 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' txtNota1
        ' 
        txtNota1.Location = New Point(108, 64)
        txtNota1.Name = "txtNota1"
        txtNota1.Size = New Size(100, 23)
        txtNota1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 207)
        Button1.Name = "Button1"
        Button1.Size = New Size(391, 23)
        Button1.TabIndex = 1
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblPromedio
        ' 
        lblPromedio.AutoSize = True
        lblPromedio.Location = New Point(296, 126)
        lblPromedio.Name = "lblPromedio"
        lblPromedio.Size = New Size(41, 15)
        lblPromedio.TabIndex = 2
        lblPromedio.Text = "Label1"
        ' 
        ' txtNota2
        ' 
        txtNota2.Location = New Point(108, 93)
        txtNota2.Name = "txtNota2"
        txtNota2.Size = New Size(100, 23)
        txtNota2.TabIndex = 3
        ' 
        ' txtNota3
        ' 
        txtNota3.Location = New Point(108, 126)
        txtNota3.Name = "txtNota3"
        txtNota3.Size = New Size(100, 23)
        txtNota3.TabIndex = 4
        ' 
        ' txtNota4
        ' 
        txtNota4.Location = New Point(108, 161)
        txtNota4.Name = "txtNota4"
        txtNota4.Size = New Size(100, 23)
        txtNota4.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(392, 19)
        Label1.TabIndex = 6
        Label1.Text = "Estructura Repetitiva 2 - Promedio 4 Calificaciones" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 7
        Label2.Text = "Calificación 1:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 101)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 15)
        Label3.TabIndex = 8
        Label3.Text = "Calificación 2:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 15)
        Label4.TabIndex = 9
        Label4.Text = "Calificación 3:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 164)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 15)
        Label5.TabIndex = 10
        Label5.Text = "Calificación 4:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(256, 107)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 19)
        Label6.TabIndex = 11
        Label6.Text = "Promedio Final"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(415, 259)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNota4)
        Controls.Add(txtNota3)
        Controls.Add(txtNota2)
        Controls.Add(lblPromedio)
        Controls.Add(Button1)
        Controls.Add(txtNota1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNota1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblPromedio As Label
    Friend WithEvents txtNota2 As TextBox
    Friend WithEvents txtNota3 As TextBox
    Friend WithEvents txtNota4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

End Class
