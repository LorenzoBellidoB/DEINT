Imports BibliotecaClases

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSaludo.Click
        Dim persona As New ClsPersona
        If Not (txtNombre.Text.Equals("")) Then
            persona.Nombre = txtNombre.Text
            MessageBox.Show("Hola, " + persona.Nombre)
            If (txtNombre.Text.Equals("Marco")) Then
                mError.Text = "Gay"
            End If

        Else
                mError.Text = "Error, no hay nadie"
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub
End Class
