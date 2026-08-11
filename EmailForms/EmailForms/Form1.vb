Imports System.Net
Imports System.Net.Mail

Public Class Form1
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim resultado As DialogResult = MessageBox.Show(
            "¿Desea cerrar la aplicación?",
            "Confirmar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        ' Validaciones básicas
        If String.IsNullOrWhiteSpace(txtAsunto.Text) Then
            MessageBox.Show("Debe indicar al menos un destinatario.",
                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAsunto.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtAsunto.Text) Then
            MessageBox.Show("Debe indicar el asunto del correo.",
                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAsunto.Focus()
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            btnEnviar.Enabled = False

            Using mensaje As New MailMessage()
                mensaje.From = New MailAddress("n.gutierrez777@gmail.com", "NORMAN")

                ' Soporta varios destinatarios separados por ';'
                For Each destino As String In txtAsunto.Text.Split(";"c)
                    If Not String.IsNullOrWhiteSpace(destino) Then
                        mensaje.To.Add(destino.Trim())
                    End If
                Next

                mensaje.Subject = txtAsunto.Text
                mensaje.Body = txtCuerpo.Text
                mensaje.IsBodyHtml = False

                Using smtp As New SmtpClient("smtp.gmail.com", 587)
                    smtp.Credentials = New NetworkCredential(
                        "n.gutierrez777@gmail.com", "yolp jspf hfsr dpll")
                    smtp.EnableSsl = True
                    smtp.Send(mensaje)
                End Using
            End Using

            MessageBox.Show("Correo enviado correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al enviar el correo:" & vbCrLf & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
            btnEnviar.Enabled = True
        End Try
    End Sub

    Private Sub LimpiarCampos()
        txtPara.Clear()
        txtAsunto.Clear()
        txtCuerpo.Clear()
        txtPara.Focus()
    End Sub
End Class
