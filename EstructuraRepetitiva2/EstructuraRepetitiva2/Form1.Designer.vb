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
        SuspendLayout()
        ' 
        ' txtNota1
        ' 
        txtNota1.Location = New Point(137, 83)
        txtNota1.Name = "txtNota1"
        txtNota1.Size = New Size(100, 23)
        txtNota1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(137, 232)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblPromedio
        ' 
        lblPromedio.AutoSize = True
        lblPromedio.Location = New Point(328, 112)
        lblPromedio.Name = "lblPromedio"
        lblPromedio.Size = New Size(41, 15)
        lblPromedio.TabIndex = 2
        lblPromedio.Text = "Label1"
        ' 
        ' txtNota2
        ' 
        txtNota2.Location = New Point(137, 112)
        txtNota2.Name = "txtNota2"
        txtNota2.Size = New Size(100, 23)
        txtNota2.TabIndex = 3
        ' 
        ' txtNota3
        ' 
        txtNota3.Location = New Point(137, 151)
        txtNota3.Name = "txtNota3"
        txtNota3.Size = New Size(100, 23)
        txtNota3.TabIndex = 4
        ' 
        ' txtNota4
        ' 
        txtNota4.Location = New Point(137, 180)
        txtNota4.Name = "txtNota4"
        txtNota4.Size = New Size(100, 23)
        txtNota4.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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

End Class
