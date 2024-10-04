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
        SuspendLayout()
        ' 
        ' txtNum1
        ' 
        txtNum1.Location = New Point(65, 76)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(121, 23)
        txtNum1.TabIndex = 0
        ' 
        ' txtNum2
        ' 
        txtNum2.Location = New Point(65, 129)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(121, 23)
        txtNum2.TabIndex = 1
        ' 
        ' cmbOperacion
        ' 
        cmbOperacion.FormattingEnabled = True
        cmbOperacion.Items.AddRange(New Object() {"Suma", "Resta", "Multiplicación", "División"})
        cmbOperacion.Location = New Point(65, 177)
        cmbOperacion.Name = "cmbOperacion"
        cmbOperacion.Size = New Size(121, 23)
        cmbOperacion.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(99, 294)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(378, 293)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(41, 15)
        lblResultado.TabIndex = 4
        lblResultado.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResultado)
        Controls.Add(Button1)
        Controls.Add(cmbOperacion)
        Controls.Add(txtNum2)
        Controls.Add(txtNum1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents cmbOperacion As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblResultado As Label

End Class
