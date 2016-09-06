Module variablesYMetodos
    ' Una cosa hay que aclarar, cuando no hay que devolver nada, mejor hacer un sub-end sub y cuando
    'haya que devolver algo, mejor hacer un function-end function
    Public mensaje As String
    Public clienteId As Int32
    Public proveedorId As Int32
    Public cuadernoId As Int32



    ' la caña hasta que lo he logrado, función que oculta todos los formularios 
    ' de la aplicacion si se va a ingresar en gestion
    ' No llores sangre
    ' Y sin copia pega de internet,
    'ByVal Lista As Form
    Public Sub deshabilitar()
        Dim miControl As Control
        For Each miControl In My.Application.OpenForms
            If (TypeOf (miControl) Is Form) Then
                CType(miControl, Form).Hide()
            End If
        Next
    End Sub

    ' sabiendo deshabilitar, habilitar se hace con la gorra... de listos y héroes está 
    ' el mundo lleno
    ' No llores sangre
    ' Y sin copia pega de internet,
    Public Sub habilitar()
        Dim miControl As Control
        For Each miControl In My.Application.OpenForms
            If (TypeOf (miControl) Is Form) Then
                CType(miControl, Form).Show()
            End If
        Next
    End Sub
    'función que cierra la aplicación
    'he diseñado un formulario a tal respecto, así que de momento esta función queda sin usarse
    Public Sub salir()
        Dim msj As MsgBoxResult
        msj = MsgBox("¿Seguro que deseas salir?", vbYesNo, "Pon Farr")
        If msj = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
    'esta función es válida para dar de alta un proveedor como para dar de alta a un cliente
    ' así que en vez de ponerla una para cada formulario, la comparto de forma global.

    'esta funcion lo que hace es recorrerme los controloes que tengo en el formulario
    'comprueba si el control que está recorriendo es un textbox y si es así
    'entonces compara si ese texbox está vacío y si el nombre del textbox es uno en concreto
    'entonces muestra el mensaje de campos vacíos y se sale del for

    '------------------------------------------------------------
    ' esta función se ha modificado, al principio recibía una objeto de tipo formulario
    ' ahora recibe un objeto de tipo objeto así podré gestionar más cosas por medio
    'de una única función
    Public Function isEmpty(ByVal objeto As Object) As Boolean
        Dim resultado As Boolean
        Dim nombreControl As String
        Dim miControl As Control
        Dim nombreObjeto As String = objeto.Name
        'la idea de este select case es que recorra el formulario en cuestión que tenga para rellenar
        'mediante un select case comprueba qué nombre de formulario recibe y si se ha rellenado bien
        'o mal
        Select Case nombreObjeto
            ' comprobación para una nueva incidencia para el cuaderno de bitácora
            Case "frmCuadernoNuevaIncidencia", "frmCuadernoEditarIncidencia"
                For Each miControl In objeto.Controls
                    If (TypeOf (miControl) Is TextBox) Then
                        If miControl.Text = "" Then
                            mensaje = "Has de rellenarlo todo"
                            resultado = True
                            frmAdvertencia.Show()
                            Exit For
                        Else
                            resultado = False
                        End If
                    End If
                Next
                ' para las pestañas de la parte de gestion de la aplicación
            Case "TabPage1"
                For Each miControl In objeto.controls
                    If (TypeOf (miControl) Is TextBox) Then
                        nombreControl = miControl.Name
                        If miControl.Text = "" And nombreControl.CompareTo("txtFiltrar") <> 0 Then
                            mensaje = "Has de rellenar todos los precios y el tipo de material que es"
                            resultado = True
                            frmAdvertencia.Show()
                            Exit For
                        Else
                            resultado = False
                        End If
                    End If
                Next
            Case "TabPage3"
                For Each miControl In objeto.controls
                    If (TypeOf (miControl) Is TextBox) Then
                        If miControl.Text = "" Then
                            mensaje = "Has de darme un nombre"
                            resultado = True
                            frmAdvertencia.Show()
                            Exit For
                        Else
                            resultado = False
                        End If
                    End If
                Next
                ' comprobación para el caso de un parte nuevo
            Case "frmParteNuevo"
                For Each miControl In objeto.Controls
                    If (TypeOf (miControl) Is TextBox) Then
                        nombreControl = miControl.Name
                        If miControl.Text = "" And nombreControl.CompareTo("txtSolucion") <> 0 Then
                            mensaje = " la solución es el único cuadro que puedes dejar en blanco," +
                                " junto con el técnico y el material cuando creas un nuevo parte"
                            frmAdvertencia.Show()
                            resultado = True
                            Exit For
                        Else
                            resultado = False
                        End If
                    End If
                Next
            Case Else
                ' comprobación para el caso de agregar cliente o agregar proveedor
                For Each miControl In objeto.Controls
                    If (TypeOf (miControl) Is TextBox) Then
                        nombreControl = miControl.Name
                        If miControl.Text = "" Then
                            If nombreControl.CompareTo("txtObservaciones") <> 0 And nombreControl.CompareTo("txtNom") <> 0 And nombreControl.CompareTo("txtTlf") <> 0 Then
                                mensaje = "Sólo puedes dejar en blanco el cuadro de observaciones"
                                frmAdvertencia.Show()
                                resultado = True
                                Exit For
                            Else
                                resultado = False
                            End If
                        End If
                    End If
                Next
        End Select
        Return resultado
    End Function
    ' función que no devuelve nada, para vaciar los cuadros de texto y combobox después de insertar un registro nuevo
    '---------------------------------------

    ' esta función se ha modificado. Al principio recibía un objeto de tipo formulario
    'ahora recibe un objeto de tipo object y le puedes pasar cualquier cosa
    Public Sub vaciar(ByVal objeto As Object)
        Dim miControl As Control
        For Each miControl In objeto.Controls
            If (TypeOf (miControl) Is TextBox) Then
                miControl.Text = ""
            End If
            If (TypeOf miControl Is ComboBox) Then
                'esta parte no funciona directamente con micontrol, porque no tiene el método selectedIndex
                'entonces si el control es un combobox, entonces me crea una variable de tipo combobox
                'que sí tiene el método selected index, igualo el control a la variable de tipo combobox
                'y sólo me queda vaciar el combo
                Dim combo As ComboBox
                combo = miControl
                combo.SelectedIndex = -1
            End If
        Next
    End Sub
End Module

