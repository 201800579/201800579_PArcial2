Imports System.Math


Module Module1

    'creamos los vectores
    Dim VNombre(6) As String
    Dim VProducto(6) As String
    Dim VPacks(6) As String
    Dim VSobrantes(6) As String
    Dim VSubtotal(6) As String
    Dim VDescuento(6) As String
    Dim VTotal(6) As String
    Dim Contador = 0


    'contantes
    Dim PRJugo = 8.5
    Dim PRFrituras = 11.2
    Dim PRGalletas = 4.25
    Dim PRBaterias = 15

    'variables
    Dim Packs As Integer
    Dim Sobras As Integer
    Dim Subtotal As Double
    Dim Descuento As Double
    Dim Total As Double


    Public Sub Agregar()

        VNombre(Contador) = Form1.TBNombrePack.Text
        'baterias
        If Form1.RBBaterias.Checked = True Then
            VProducto(Contador) = Form1.RBBaterias.Text

            'packs
            Packs = Form1.TBCInventario.Text / Form1.TBCDeseada.Text
            VPacks(Contador) = Packs

            'sobrantes
            Sobras = Form1.TBCInventario.Text Mod Form1.TBCDeseada.Text
            VSobrantes(Contador) = Sobras

            'subtotal
            Subtotal = Form1.TBCDeseada.Text * Packs * PRBaterias
            VSubtotal(Contador) = Round(Subtotal, 2)
            'validamos descuentos 
            '3no descuteno
            If Form1.TBCDeseada.Text < 3 Then
                Descuento = 0
                VDescuento(Contador) = Descuento
                'total
                Total = Subtotal
                VTotal(Contador) = Round(Subtotal, 2)
            End If
            '3%
            If Form1.TBCDeseada.Text >= 3 And Form1.TBCDeseada.Text < 5 Then
                Descuento = Subtotal * 0.03
                VDescuento(Contador) = Descuento
                'total
                Total = Subtotal - Descuento
                VTotal(Contador) = Round(Subtotal, 2)
            End If
            '5%
            If Form1.TBCDeseada.Text >= 5 And Form1.TBCDeseada.Text < 10 Then
                Descuento = Subtotal * 0.05
                VDescuento(Contador) = Descuento
                'total
                Total = Subtotal - Descuento
                VTotal(Contador) = Round(Subtotal, 2)
            End If
            '10%
            If Form1.TBCDeseada.Text >= 10 Then
                Descuento = Subtotal * 0.1
                VDescuento(Contador) = Descuento
                'total
                Total = Subtotal - Descuento
                VTotal(Contador) = Round(Subtotal, 2)
            End If

        End If


        'jugos
        If Form1.RBJugos.Checked = True Then
            VProducto(Contador) = Form1.RBJugos.Text


            'packs
            Packs = Form1.TBCInventario.Text / Form1.TBCDeseada.Text
            VPacks(Contador) = Packs

            'sobrantes
            Sobras = Form1.TBCInventario.Text Mod Form1.TBCDeseada.Text
            VSobrantes(Contador) = Sobras

            'subtotal
            Subtotal = Form1.TBCDeseada.Text * Packs * PRJugo
            VSubtotal(Contador) = Round(Subtotal, 2)
            'validamos descuentos 
            '3no descuteno
            If Form1.TBCDeseada.Text < 3 Then
                Descuento = 0
                VDescuento(Contador) = Descuento
                'total
                Total = Subtotal
                VTotal(Contador) = Round(Subtotal, 2)
            End If
            '3%
            If Form1.TBCDeseada.Text >= 3 And Form1.TBCDeseada.Text < 5 Then
                Descuento = Subtotal * 0.03
                VDescuento(Contador) = Descuento
                'total
                Total = Subtotal - Descuento
                VTotal(Contador) = Round(Subtotal, 2)
            End If
            '5%
            If Form1.TBCDeseada.Text >= 5 And Form1.TBCDeseada.Text < 10 Then
                Descuento = Subtotal * 0.05
                VDescuento(Contador) = Descuento
                'total
                Total = Subtotal - Descuento
                VTotal(Contador) = Round(Subtotal, 2)
            End If
            '10%
            If Form1.TBCDeseada.Text >= 10 Then
                Descuento = Subtotal * 0.1
                VDescuento(Contador) = Descuento
                'total
                Total = Subtotal - Descuento
                VTotal(Contador) = Round(Subtotal, 2)
            End If
        End If


        'galletas
        If Form1.RBGalletas.Checked = True Then
            VProducto(Contador) = Form1.RBGalletas.Text


            'packs
            Packs = Form1.TBCInventario.Text / Form1.TBCDeseada.Text
            VPacks(Contador) = Packs

            'sobrantes
            Sobras = Form1.TBCInventario.Text Mod Form1.TBCDeseada.Text
            VSobrantes(Contador) = Sobras

            'subtotal
            Subtotal = Form1.TBCDeseada.Text * Packs * PRGalletas
            VSubtotal(Contador) = Round(Subtotal, 2)
            'validamos descuentos 
            '3no descuteno
            If Form1.TBCDeseada.Text < 3 Then
                Descuento = 0
                VDescuento(Contador) = Descuento
                'total
                Total = Subtotal
                VTotal(Contador) = Round(Subtotal, 2)
            End If
            '3%
            If Form1.TBCDeseada.Text >= 3 And Form1.TBCDeseada.Text < 5 Then
                Descuento = Subtotal * 0.03
                VDescuento(Contador) = Descuento
                'total
                Total = Subtotal - Descuento
                VTotal(Contador) = Round(Subtotal, 2)
            End If
            '5%
            If Form1.TBCDeseada.Text >= 5 And Form1.TBCDeseada.Text < 10 Then
                Descuento = Subtotal * 0.05
                VDescuento(Contador) = Descuento
                'total
                Total = Subtotal - Descuento
                VTotal(Contador) = Round(Subtotal, 2)
            End If
            '10%
            If Form1.TBCDeseada.Text >= 10 Then
                Descuento = Subtotal * 0.1
                VDescuento(Contador) = Descuento
                'total
                Total = Subtotal - Descuento
                VTotal(Contador) = Round(Subtotal, 2)
            End If
        End If


        'Frituras
        If Form1.RBFritura.Checked = True Then
            VProducto(Contador) = Form1.RBFritura.Text


            'packs
            Packs = Form1.TBCInventario.Text / Form1.TBCDeseada.Text
            VPacks(Contador) = Packs

            'sobrantes
            Sobras = Form1.TBCInventario.Text Mod Form1.TBCDeseada.Text
            VSobrantes(Contador) = Sobras

            'subtotal
            Subtotal = Form1.TBCDeseada.Text * Packs * PRFrituras
            VSubtotal(Contador) = Round(Subtotal, 2)
            'validamos descuentos 
            '3no descuteno
            If Form1.TBCDeseada.Text < 3 Then
                Descuento = 0
                VDescuento(Contador) = Descuento
                'total
                Total = Subtotal
                VTotal(Contador) = Round(Subtotal, 2)
            End If
            '3%
            If Form1.TBCDeseada.Text >= 3 And Form1.TBCDeseada.Text < 5 Then
                Descuento = Subtotal * 0.03
                VDescuento(Contador) = Descuento
                'total
                Total = Subtotal - Descuento
                VTotal(Contador) = Round(Subtotal, 2)
            End If
            '5%
            If Form1.TBCDeseada.Text >= 5 And Form1.TBCDeseada.Text < 10 Then
                Descuento = Subtotal * 0.05
                VDescuento(Contador) = Descuento
                'total
                Total = Subtotal - Descuento
                VTotal(Contador) = Round(Subtotal, 2)
            End If
            '10%
            If Form1.TBCDeseada.Text >= 10 Then
                Descuento = Subtotal * 0.1
                VDescuento(Contador) = Descuento
                'total
                Total = Subtotal - Descuento
                VTotal(Contador) = Round(Subtotal, 2)
            End If
        End If

        If Contador = 6 Then
            MsgBox("Llego al limite de Cotizaciones  ", MsgBoxStyle.Information, "ADVERTENCIA")

        Else
            Form1.DTResultados.Rows.Add(VNombre(Contador), VProducto(Contador), VPacks(Contador), VSobrantes(Contador), VSubtotal(Contador), VDescuento(Contador), VTotal(Contador))
            Form1.TBCDeseada.Text = 0
            Form1.TBNombrePack.Text = ""
            Form1.TBCInventario.Text = 0
            Form1.RBBaterias.Text = 0
            Form1.RBFritura.Text = 0
            Form1.RBGalletas.Text = 0
            Form1.RBJugos.Text = 0


            Contador = Contador + 1
            MsgBox("Se Registro con Exito ", MsgBoxStyle.Information, "Guardado")

        End If





    End Sub

    Public Sub Limpiezavectores()
        Form1.TBCDeseada.Text = 0
        Form1.TBNombrePack.Text = ""
        Form1.TBCInventario.Text = 0
        Form1.RBBaterias.Text = 0
        Form1.RBFritura.Text = 0
        Form1.RBGalletas.Text = 0
        Form1.RBJugos.Text = 0
        Form1.DTResultados.Rows.Clear()

        For Contador = 0 To 8
            VNombre(Contador) = Nothing
            VPacks(Contador) = Nothing
            VProducto(Contador) = Nothing
            VTotal(Contador) = Nothing
            VDescuento(Contador) = Nothing
            VSubtotal(Contador) = Nothing
            VSobrantes(Contador) = Nothing




        Next Contador
    End Sub
End Module
