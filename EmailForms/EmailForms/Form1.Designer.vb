<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnCerrar = New Button()
        btnEnviar = New Button()
        txtPara = New TextBox()
        txtAsunto = New TextBox()
        txtCuerpo = New TextBox()
        SuspendLayout()
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(333, 223)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(67, 23)
        btnCerrar.TabIndex = 0
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' btnEnviar
        ' 
        btnEnviar.Location = New Point(263, 223)
        btnEnviar.Name = "btnEnviar"
        btnEnviar.Size = New Size(64, 22)
        btnEnviar.TabIndex = 1
        btnEnviar.Text = "Eviar"
        btnEnviar.UseVisualStyleBackColor = True
        ' 
        ' txtPara
        ' 
        txtPara.Location = New Point(25, 34)
        txtPara.Name = "txtPara"
        txtPara.Size = New Size(160, 23)
        txtPara.TabIndex = 2
        ' 
        ' txtAsunto
        ' 
        txtAsunto.Location = New Point(25, 63)
        txtAsunto.Name = "txtAsunto"
        txtAsunto.Size = New Size(160, 23)
        txtAsunto.TabIndex = 3
        ' 
        ' txtCuerpo
        ' 
        txtCuerpo.Location = New Point(25, 105)
        txtCuerpo.Name = "txtCuerpo"
        txtCuerpo.Size = New Size(357, 23)
        txtCuerpo.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(410, 262)
        Controls.Add(txtCuerpo)
        Controls.Add(txtAsunto)
        Controls.Add(txtPara)
        Controls.Add(btnEnviar)
        Controls.Add(btnCerrar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnEnviar As Button
    Friend WithEvents txtPara As TextBox
    Friend WithEvents txtAsunto As TextBox
    Friend WithEvents txtCuerpo As TextBox

End Class
