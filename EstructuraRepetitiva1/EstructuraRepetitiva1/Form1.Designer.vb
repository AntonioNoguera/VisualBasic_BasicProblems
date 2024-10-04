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
        SuspendLayout()
        ' 
        ' txtNumero
        ' 
        txtNumero.Location = New Point(219, 103)
        txtNumero.Name = "txtNumero"
        txtNumero.Size = New Size(100, 23)
        txtNumero.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(233, 177)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lstResultados
        ' 
        lstResultados.FormattingEnabled = True
        lstResultados.ItemHeight = 15
        lstResultados.Location = New Point(504, 74)
        lstResultados.Name = "lstResultados"
        lstResultados.Size = New Size(120, 154)
        lstResultados.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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

End Class
