Imports MySql.Data.MySqlClient
Public Class frmBarraDeProgreso
    Dim conexion As MySqlConnection
    Dim comando As MySqlCommand
    Private Sub frmBarraDeProgreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        imgAceptarGrande.Visible = False
        imgAceptarPequena.Visible = False
        imgPonFarr.Visible = False
        CheckForIllegalCrossThreadCalls = False
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim i As Integer
        'For i = 1 To 100
        '    BackgroundWorker1.ReportProgress(i)
        '    Threading.Thread.Sleep(500)
        'Next
        'BASE DE DATOS
        txtProgreso.Text = "Es la primera vez que me ejecutas, deja que me tome un tiempo para configurarlo todo"
        Threading.Thread.Sleep(5000)
        Try
            txtProgreso.Text = "Creando base de datos..."
            Dim cadena As String
            Dim sentencia As String
            sentencia = "create database gestion"
            cadena = "server=localhost;;uid=root;pwd="
            conexion = New MySqlConnection(cadena)
            conexion.Open()
            comando = New MySqlCommand(sentencia, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = 14
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Dispose()
        End Try

        'CREANDO TABLAS
        txtProgreso.Text = "creando tablas..."
        Dim fichero As IO.StreamReader
        fichero = IO.File.OpenText("gestion.sql")
        Dim str As String
        str = ""
        Do Until fichero.Peek = -1
            str = str + fichero.ReadLine
        Loop
        fichero.Close()
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 29
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Dispose()
        End Try


        'CREANDO PROCEDIMIENTOS ALMACENADOS
        txtProgreso.Text = "Creando procedimientos..."
        'PROCEDIMIENTO ACTUALIZAR CLIENTE
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `actualizarCliente`(in _id integer,
    							   in _nombre varchar(150),
                                   in _nif varchar(150),
                                   in _personaContacto varchar(150),
                                   in _email varchar(150),
                                   in _observaciones varchar(150),
                                   in _domicilio varchar(150),
                                   in _poblacion varchar(150),
                                   in _provincia varchar(50),
                                   in _codPos varchar(5)
                                   )
                begin
	                update clientes set nombre=_nombre, nif=_nif, perscto=_personaContacto,email=_email,observaciones=_observaciones, domicilio=_domicilio,poblacion=_poblacion, provincia=_provincia, codpos=_codPos where id=_id;
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO ACTUALIZAR CUADERNO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `actualizarCuaderno`(
                     in _id int,
                     in _datos text,
                     in _persona varchar(50),
                             in _resuelto varchar(15),
                     in _cliente varchar(50)
                         )
                begin
                     update cuaderno set datos=_datos,persona=_persona,resuelto=_resuelto,cliente=_cliente where id=_id;
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO ACTUALIZAR MATERIAL
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `actualizarMaterial`( in _id integer,
                                    in _material varchar(150),
                                    in _precio double,
                                    in _pvp double)
                            begin
                                    update material set material=_material,precio=_precio,pvp=_pvp where id=_id;
                                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO ACTUALIZAR PARTE
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `actualizarParte`(in _id int,
    							 in _cliente varchar (50),
                                 in _telefono varchar (12),
                                 in _problema text,
                                 in _producto varchar (150),
                                 in _numSerie varchar (150)
                                 )
                begin
	            update partes set cliente=_cliente, telefono=_telefono,problema=_problema, producto=_producto, nserie=_numSerie
                 where id=_id;
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIIENTO ACTUALIZAR PROVEEDOR
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `actualizarProveedor`(in _id integer,
                                     in _nif varchar(9),
                                     in _personaContacto varchar(150),
                                     in _email varchar(150),
                                     in _observaciones text,
                                     in _domicilio varchar(150),
                                     in _poblacion varchar (150),
                                     in _provincia varchar (50),
                                     in _codPos varchar (5)
                                     )
                begin
	            update proveedores set nif=_nif, perscto=_personaContacto, email=_email,observaciones=_observaciones,domicilio=_domicilio, poblacion=_poblacion, provincia=_provincia, codpos=_codPos where id=_id;
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO ACTUALIZAR PUESTO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `actualizarPuesto`(IN `_id` INT, IN `_localizacion` VARCHAR(50), IN `_nombrePc` VARCHAR(50), IN `_usuario` VARCHAR(15), IN `_sistOperativo` VARCHAR(15), IN `_contrasena` VARCHAR(20), IN `_ip` VARCHAR(15))
            begin
            update puestos set localizacion=_localizacion, nombrepc=_nombrePc, usuario=_usuario, ip=_ip, soperativo=_sistOperativo,
					contrasena=_contrasena where id=_id;
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO ACTUALIZAR RED
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `actualizarRed`(in _id int,
                               in _cliente varchar (150),
                               in _servidorNombre varchar(15),
                               in _servidorIp varchar (15),
                               in _grupo varchar (15),
                               in _router varchar (15),
                               in _dns1 varchar (15),
                               in _dns2 varchar(15),
                               in _mascara varchar(15),
                               in _usuarioRouter varchar (50),
                               in _contrasenaRouter varchar (50)
                               )
            begin
	            update red set cliente=_cliente, servidornom=_servidorNombre, servidorip=_servidorIp,grupo=_grupo,
    				router=_router, dns1=_dns1, dns2=_dns2, mascara=_mascara, usuariorouter=_usuarioRouter,
                    contrasenarouter=_contrasenaRouter
                where id=_id;
              end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO ACTUALIZAR SUBCUENTA
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `actualizarSubcuenta`( in _id int,
                                     in _direccion varchar(50),
                                     in _usuario varchar (50),
                                     in _contrasena varchar (20),
                                     in _ubicacion varchar(50)
                                     )
                begin
	                update subcuentas set direccion =_direccion, usuario=_usuario, contrasena=_contrasena, ubicacion=_ubicacion
                    where id=_id;
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO ACTUALIZAR TELEFONO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `actualizarTelefono`(in _id integer,
                                    in _nombre varchar(50),                                    
                                    in _telefono varchar(50),
                                    in _nombreTabla varchar(50)
                                    )
                begin
	                case _nombreTabla
    	                when 'cliente' then
        	                update telefonoscliente set nombre=_nombre, telefono=_telefono where id=_id;
                        when 'proveedor' then
        	                update telefonosproveedor set nombre=_nombre, telefono=_telefono where id=_id;
   	                end case;
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO ACTUALIZAR USUARIO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `actualizarUsuario`(in _id integer,
                                   in _nombre varchar(50),
                                   in _nombreNuevo varchar(50)
                                   )
                            begin
                                   update usuarios set nombre=_nombreNuevo where id=_id;
                                   update partes set tecnico=_nombreNuevo where tecnico=_nombre;
                                   update cuaderno set persona=_nombreNuevo where persona=_nombre;
                                   end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO ACTUALIZAR Y CERRAR PARTE
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `actualizarYCerrarParte`(IN `_id` INT, IN `_fechaEntrada` VARCHAR(50), IN `_fechaSalida` VARCHAR(50), IN `_tecnico` VARCHAR(50), IN `_cliente` VARCHAR(50), IN `_telefono` VARCHAR(50), IN `_problema` TEXT, IN `_solucion` TEXT, IN `_producto` VARCHAR(150), IN `_numSerie` VARCHAR(150), IN `_totalEuros` DOUBLE, IN `_material` TEXT)
                begin
	                update partes set fechaentrada=_fechaEntrada,
    			                fechasalida=_fechaSalida,
                                tecnico=_tecnico,
                                cliente=_cliente,
                                telefono=_telefono,
                                problema=_problema,
                                solucion=_solucion,
                                producto=_producto,
                                nserie=_numSerie,
                                totalEuros=_totalEuros,
                                material=_material
                    where id=_id;
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO CERRAR PARTE
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `cerrarParte`(IN `_id` INT, IN `_fechaSalida` VARCHAR(50), IN `_tecnico` VARCHAR(50), IN `_solucion` TEXT, IN `_material` TEXT)
            begin
                update partes set fechasalida=_fechaSalida, tecnico=_tecnico, solucion=_solucion,material=_material where id=_id;
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO ELIMINAR MATERIAL
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `eliminarMaterial`( in _id integer)
                    begin
                    delete from material where id=_id;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO ELIMINAR PUESTO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `eliminarPuesto`(in _id int)
                    begin
	                    delete from puestos where id=_id;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO ELIMINAR SUBCUENTA
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `eliminarSubcuenta`(in _id int)
                    begin
	                    delete from subcuentas where id=_id;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO ELIMINAR TELEFONOS
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `eliminarTelefonos`(IN `_id` INT, IN `_nombreTabla` VARCHAR(50))
                begin
                case _nombreTabla
                when 'cliente' then
                delete  from telefonoscliente where id=_id;
                when 'proveedor' then
                delete  from telefonosproveedor where id=_id;
                end case;
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO ELIMINAR USUARIO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `eliminarUsuario`(in _id integer)
                    begin
                    delete  from usuarios where id=_id;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO FILTRAR CLIENTES
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `filtrarClientes`( in _filtro varchar(50))
                begin
                select * from clientes where clientes.nombre like _filtro;
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO FILTRAR CORREO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `filtrarCorreo`(in _cliente varchar(50))
                    begin
	                    select * from correos where nombre like _cliente;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO FILTRAR CUADERNO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `filtrarCuaderno`(IN `_cliente` VARCHAR(50), IN `_persona` VARCHAR(50), IN `_resuelto` VARCHAR(50))
            begin
          select * from cuaderno where cliente like _cliente and persona = _persona and resuelto = _resuelto;
            end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO FILTRAR MATERIAL
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `filtrarMaterial`(IN `_material` VARCHAR(15))
                begin
                 select * from material where material.material like _material;
                  end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO FILTRAR PROVEEDORES
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `filtrarProveedores`(in _filtro varchar(150))
                    begin
                    select * from proveedores where nombre like _filtro;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO FILTRAR RED
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `filtrarRed`(in _nombreCliente varchar (150))
                    begin
	                    select * from red where cliente like _nombreCliente;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO FILTRAR USUARIO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `filtrarUsuario`(in _filtro varchar(20))
                    begin
	                    select nombre from usuarios where nombre like _filtro;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIIENTO INSERTAR CLIENTE
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `insertarCliente`(IN `_nombre` VARCHAR(150), IN `_nif` VARCHAR(9), IN `_personaContacto` VARCHAR(150), IN `_email` VARCHAR(150), IN `_observaciones` TEXT, IN `_domicilio` VARCHAR(150), IN `_poblacion` VARCHAR(150), IN `_provincia` VARCHAR(50), IN `_codpos` VARCHAR(5))
                    begin
                 insert into clientes (nombre,nif,perscto,email,observaciones,domicilio,poblacion,provincia,codpos)values(_nombre,_nif,_personaContacto,_email,_observaciones,_domicilio,_poblacion,_provincia,_codpos);
                   end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO INSERTAR CORREO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `insertarCorreo`(IN `_proveedor` VARCHAR(50), IN `_idUsuario` VARCHAR(50), IN `_nombre` VARCHAR(50), IN `_direccionCorreo` VARCHAR(50), IN `_usuarioConexion` VARCHAR(50), IN `_nombreCuentaConexion` VARCHAR(50), IN `_contrasena` VARCHAR(20), IN `_servidorCorreoEntrante` VARCHAR(50), IN `_servidorCorreoSaliente` VARCHAR(50), IN `_observaciones` TEXT, IN `_subdominio` VARCHAR(50), IN `_usuarioGestion` VARCHAR(50), IN `_contrasenaGestion` VARCHAR(20), IN `_webGestion` VARCHAR(50))
                begin
	                insert into correos (proveedor,idusuario,nombre,direccioncorreo,
                                         usuarioconexion,nombrecuentacon,
                                      contrasena,scorreoentrante,scorreosaliente,observaciones,
                                         subdominio,usugestion,contragestion,webgestion)
                           values( _proveedor,
                                  _idUsuario,
                                  _nombre,
                                  _direccionCorreo,
                                  _usuarioConexion,
                                  _nombreCuentaConexion,
                                  _contrasena,
                                  _servidorCorreoEntrante,
                                  _servidorCorreoSaliente,
                                  _observaciones,
                                  _subdominio,
                                  _usuarioGestion,
                                  _contrasenaGestion,
                                  _webGestion
                                  );
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO INSERTAR CUADERNO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `insertarCuaderno`(
                    in _fecha varchar(50),
                    in _datos text,    
                    in _persona varchar(50),
                    in _resuelto varchar(15),
                    in _cliente varchar(50)
                    )
                begin
                    insert into cuaderno(fecha,datos,persona,resuelto,cliente)
                    values(_fecha,_datos,_persona,_resuelto,_cliente);
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO INSERTAR MATERIAL
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `insertarMaterial`(IN `_material` VARCHAR(150), IN `_precio` DOUBLE, IN `_pvp` DOUBLE)
                begin
               insert into material (material,precio,pvp)values(_material,_precio,_pvp);
               end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO INSERTAR PARTE
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `insertarParte`(IN `_fechaEntrada` VARCHAR(50), IN `_cliente` VARCHAR(50), IN `_telefono` VARCHAR(12), IN `_problema` TEXT, IN `_producto` VARCHAR(150), IN `_numSerie` VARCHAR(150), IN `_fechaSalida` VARCHAR(50), IN `_tecnico` VARCHAR(50), IN `_solucion` TEXT, IN `_total` DOUBLE, IN `_material` TEXT)
                        begin
                            insert into partes(fechaentrada,cliente,telefono,problema,producto,nserie,fechasalida,tecnico,solucion,totalEuros,material)
                            values(_fechaEntrada,_cliente,_telefono,_problema,_producto,_numSerie,_fechaSalida,_tecnico,_solucion,_total,_material);
                            end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO INSERTAR PROVEEDOR
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `insertarProveedor`(in _nombre varchar(150),
                                   in _nif varchar (9),
                                   in _personaContacto varchar (150),
                                   in _email varchar(150),
                                   in _observaciones text,
                                   in _domicilio varchar(150),
                                   in _poblacion varchar (150),
                                   in _provincia varchar(50),
                                   in _codpos varchar (5)
                                   )
                            begin
                                   insert into proveedores (nombre,nif,perscto,email,observaciones,domicilio, poblacion, provincia,codpos) values(_nombre,_nif,_personaContacto,_email,_observaciones,_domicilio,_poblacion,_provincia,_codpos);
                                   end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO INSERTAR PUESTO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `insertarPuesto`(in _idRed integer,
                                in _localizacion varchar(50),
                                in _nombrePC varchar(15),
                                in _usuario varchar(15),
                                in _ip varchar(15),
                                in _SistOperativo varchar(15),
                                in _contrasena varchar(20)
                                )
                                begin
	                                insert into puestos (idred,localizacion,nombrepc,usuario,ip,soperativo,contrasena)
                                    values(_idRed,_localizacion,_nombrePC,_usuario,_ip,_SistOperativo,_contrasena);
                                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO INSERTAR RED
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `insertarRed`(in _cliente varchar(150),
                             in _servidorNom varchar(15),
                             in _servidorIP varchar(15),
                             in _grupo varchar(15),
                             in _router varchar(15),
                             in _dns1 varchar(15),
                             in _dns2 varchar(15),
                             in _mascara varchar(15),
                             in _usuarioRouter varchar(50),
                             in _contrasenaRouter varchar(50)
                             )
                            begin
	                            insert into red (cliente,servidornom,servidorip,grupo,router,dns1,dns2,mascara,usuariorouter,contrasenarouter)
                                values(_cliente, _servidorNom,_servidorIP,_grupo,_router,_dns1,_dns2,_mascara,_usuarioRouter,_contrasenaRouter);
                            end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO INSERTAR SUBCUENTA
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `insertarSubcuenta`(in _idCorreo int,
                                   in _direccion varchar (50),
                                   in _usuario varchar (20),
                                   in _contrasena varchar (20),
                                   in _ubicacion varchar (50)
                                   )
                            begin
	                            insert into subcuentas(idcorreo,direccion,usuario,contrasena,ubicacion)
    			                            values( _idCorreo ,
                                                    _direccion ,
                                                    _usuario ,
                                                    _contrasena,
                                                    _ubicacion
                                                   );
                            end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO INSERTAR TELEFONO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `insertarTelefono`(IN `_id` INT, IN `_nombre` VARCHAR(50), IN `_telefono` VARCHAR(50), IN `_nombreTabla` VARCHAR(50))
                    begin
	                    case _nombreTabla
    	                    when 'cliente' then
        	                    insert into telefonoscliente (id_cliente, nombre,telefono) values(_id,_nombre,_telefono);
                            when 'proveedor' then
        	                    insert into telefonosproveedor (id_proveedor, nombre,telefono)values (_id,_nombre,_telefono);
                        end case;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO INSERTAR TELEFONOS
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `insertarTelefonos`(in _idRetorno integer,
                                   in _nombre varchar (15),
                                   in _telefono varchar(12),
                                   in _nombreTabla varchar(15)
                                   )
                                    begin
                                   case _nombreTabla
                                   when 'cliente' then
                                   insert into telefonoscliente(id_cliente,nombre,telefono) values(_idRetorno, _nombre, _telefono);
                                   when 'proveedor' then
                                   insert into telefonosproveedor (id_proveedor, nombre, telefono) values(_idRetorno, _nombre,_telefono);
                                   end case;
                                   end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO INSERTAR USUARIO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `insertarUsuario`(
                        in _nombre varchar(50)
                        )
                    begin
                        insert into usuarios(nombre) values (_nombre);
                        end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO LOGIN
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `login`(
                        in _nombre varchar(50),
                        in _contrasena varchar(50),
                        out _resultado int,
                        out _id int
                        )
                    begin
                        select count(*) into _resultado from administracion where usuario=_nombre and contrasena=_contrasena;
                        select id into _id from administracion where usuario =_nombre and contrasena=_contrasena;
                        end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR CLIENTE
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `mostrarCliente`( in _id integer)
                    begin
                    select * from clientes where clientes.id=_id;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR CLIENTES
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `mostrarClientes`()
                begin
                select * from clientes;
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR CORREO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `mostrarCorreo`(in _id int)
                    begin
	                    select * from correos where id=_id;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR CORREOS
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `mostrarCorreos`()
                    begin
	                    select * from correos;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR CUADERNO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `mostrarCuaderno`()
                        begin
                        select * from cuaderno;
                        end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR INCIDENCIA CUADERNO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `mostrarIncidenciaCuaderno`(in _id integer)
                    begin
                    select * from cuaderno where id=_id;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'MOSTRAR INCIDENCIAS
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `mostrarIncidencias`()
                    begin 
                    select * from estadoincidencia;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR MATERIAL
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `mostrarMaterial`()
                begin
                select* from material;
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR PARTE
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `mostrarParte`(in _id int)
                    begin
	                    select * from partes where id=_id;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR PARTES
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `mostrarPartes`()
                begin
                select * from partes;
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR PROVEEDOR
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `mostrarProveedor`(IN `_id` INT)
                    begin
                    select * from proveedores where id=_id;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR PROVEEDORES
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `mostrarProveedores`()
                    begin
                    select * from proveedores;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR PUESTOS
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `mostrarPuestos`(in _id integer)
                    begin
	                    select * from puestos where idred=_id;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR RED
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `mostrarRed`(in _id integer)
                    begin
	                    select * from red where id=_id;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR REDES
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `mostrarRedes`()
                    begin
	                    select * from red;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR SUBCUENTAS
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `mostrarSubcuentas`(in _idCorreo int)
                begin
	                select * from subcuentas where idcorreo=_idCorreo;
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR TELEFONOS
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE PROCEDURE `mostrarTelefonos`(IN `_id` INT, IN `_nombreTabla` VARCHAR(50))
                                begin
                                  case _nombreTabla
                                  when 'cliente' then
                                  select * from telefonoscliente where id_cliente=_id;
                                  when 'proveedor' then
                                  select * from telefonosproveedor where id_proveedor=_id;
                                  end case;
                                  end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTOS MOSTRAR ULTIMO ID
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = " CREATE  PROCEDURE `mostrarUltimoId`(IN `_nombreTabla` VARCHAR(15), OUT `_id` INT)
                    begin
                            Case _nombreTabla
                       when 'cliente' then
                        Select  id into _id from clientes order by id desc limit 1;
                             when 'proveedor' then
                         Select  id into _id from proveedores order by id desc limit 1;
                       when 'red' then
                         Select  id into _id from red order by id desc limit 1;
                       when 'correos' then
                       Select  id into _id from correos order by id desc limit 1;
                      End Case;
                    End"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR USUARIOS
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `mostrarUsuarios`()
                begin
                select * from usuarios;
                end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO MOSTRAR USUARIOS CUADERNO
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `mostrarUsuariosCuaderno`()
                    begin
                    select nombre from usuarios union select persona from cuaderno;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'PROCEDIMIENTO CAMBIO DE CONTRASEÑA
        Try
            conexion = New MySqlConnection("Server=localhost;database=gestion;Uid=root;Pwd=")
            str = "CREATE  PROCEDURE `cambiarContrasena`(IN `_nombre` VARCHAR(50), IN `_contrasenaVieja` VARCHAR(50), IN `_contrasenaNueva` VARCHAR(50), OUT `_resultado` INT)
                    begin
	                    declare contar  int;
                        select count(*) into contar from administracion where usuario=_nombre and contrasena=_contrasenaVieja;
                        if contar=1 then
    	                    set _resultado=1;
       	                    update administracion set contrasena=_contrasenaNueva where usuario=_nombre;
                        else
    	                    set _resultado=0;
                       end if;
                    end"
            conexion.Open()
            comando = New MySqlCommand(str, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            i = i + 1
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(500)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        txtProgreso.Text = "Proceso terminado con éxito, ya puede utilizar pon farr"
        imgAceptarGrande.Visible = True
        imgAceptarPequena.Visible = True
        imgPonFarr.Visible = True
    End Sub

    Private Sub imgAceptarGrande_MouseDown(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseDown
        imgAceptarGrande.Visible = False
    End Sub
    Private Sub imgAceptarGrande_MouseUp(sender As Object, e As MouseEventArgs) Handles imgAceptarGrande.MouseUp
        imgAceptarGrande.Visible = True
        Me.Close()
    End Sub
End Class