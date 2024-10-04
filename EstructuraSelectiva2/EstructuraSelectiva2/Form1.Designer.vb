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
        txtNota = New TextBox()
        Button1 = New Button()
        lblResultado = New Label()
        SuspendLayout()
        ' 
        ' txtNota
        ' 
        txtNota.Location = New Point(108, 217)
        txtNota.Name = "txtNota"
        txtNota.Size = New Size(100, 23)
        txtNota.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(148, 303)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(430, 211)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(41, 15)
        lblResultado.TabIndex = 2
        lblResultado.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResultado)
        Controls.Add(Button1)
        Controls.Add(txtNota)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNota As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblResultado As Label

End Class
