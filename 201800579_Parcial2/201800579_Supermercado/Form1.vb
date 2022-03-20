Public Class Form1
    'validamos antes de llamar a nuestro metodo
    Private Sub TSAceptar_Click(sender As Object, e As EventArgs) Handles TSAceptar.Click
        'validamos que se ingrese el nombre del pack
        If TBNombrePack.Text = "" Then
            MsgBox("Usted no a Ingresado el Nombre del Pack", MsgBoxStyle.Information, "Advertencia")
            TBNombrePack.Focus()
        Else
            'validamos ingrese la cantidad en el inventario
            If TBCInventario.Text = 0 Then
                MsgBox("Usted no a Ingresado la cantidad que se posee en el inventario", MsgBoxStyle.Information, "Advertencia")
                TBCInventario.Focus()
            Else
                If TBCDeseada.Text = 0 Then
                    MsgBox("Usted no a Ingresado la cantidad Deseada", MsgBoxStyle.Information, "Advertencia")
                    TBCDeseada.Focus()
                Else
                    'validamos que se seleccione una opcion de producto
                    If ((RBJugos.Checked = True) Or (RBFritura.Checked = True) Or (RBBaterias.Checked = True) Or (RBGalletas.Checked = True)) Then
                        'validamos que el invantario sea mayor a la cantidad desesada
                        If TBCInventario.Text > TBCDeseada.Text Then
                            Agregar()
                        Else
                            MsgBox("La cantidad en el inventario debe ser mayor a la deseada", MsgBoxStyle.Information, "Advertencia")
                        End If
                    Else
                        MsgBox("Usted no a Seleccionado un Producto", MsgBoxStyle.Information, "Advertencia")
                    End If
                End If
            End If
        End If
    End Sub

    'validamos que solo se ingresen valores numericos para el textbox de numero
    Private Sub TBCDeseada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBCDeseada.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'validamos que solo se ingresen valores numericos para el textbox de numero
    Private Sub TBCInventario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBCInventario.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TSSalir_Click(sender As Object, e As EventArgs) Handles TSSalir.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Close()
        Else
            TBNombrePack.Focus()
        End If
    End Sub

    Private Sub TSData_Click(sender As Object, e As EventArgs) Handles TSData.Click
        DTResultados.Rows.Clear()
        TBCDeseada.Text = 0
        TBNombrePack.Text = ""
        TBCInventario.Text = 0
        RBBaterias.Text = 0
        RBFritura.Text = 0
        RBGalletas.Text = 0
        RBJugos.Text = 0

    End Sub

    Private Sub TSVectores_Click(sender As Object, e As EventArgs) Handles TSVectores.Click
        Limpiezavectores()
    End Sub
End Class
