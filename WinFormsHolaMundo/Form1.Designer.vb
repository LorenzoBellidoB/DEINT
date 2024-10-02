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
        btnSaludo = New Button()
        txtNombre = New TextBox()
        Label1 = New Label()
        mError = New Label()
        SuspendLayout()
        ' 
        ' btnSaludo
        ' 
        btnSaludo.Location = New Point(154, 180)
        btnSaludo.Name = "btnSaludo"
        btnSaludo.Size = New Size(119, 50)
        btnSaludo.TabIndex = 0
        btnSaludo.Text = "Saludo"
        btnSaludo.UseVisualStyleBackColor = True
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(236, 76)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(154, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 2
        Label1.Text = "Nombre: "
        ' 
        ' mError
        ' 
        mError.AutoSize = True
        mError.Font = New Font("Segoe UI", 19F)
        mError.ForeColor = Color.Red
        mError.Location = New Point(454, 76)
        mError.Name = "mError"
        mError.Size = New Size(0, 36)
        mError.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(mError)
        Controls.Add(Label1)
        Controls.Add(txtNombre)
        Controls.Add(btnSaludo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSaludo As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mError As Label

End Class
