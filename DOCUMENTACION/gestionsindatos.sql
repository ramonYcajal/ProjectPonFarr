-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 29-11-2016 a las 10:53:42
-- Versión del servidor: 5.6.20
-- Versión de PHP: 5.5.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `gestion`
--
CREATE DATABASE IF NOT EXISTS `gestion` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `gestion`;

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizarCliente`(in _id integer,
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
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizarCuaderno`(
    in _id int,
    in _datos text,
    in _persona varchar(50),
    in _resuelto varchar(15),
    in _cliente varchar(50)
    )
begin
    update cuaderno set datos=_datos,persona=_persona,resuelto=_resuelto,cliente=_cliente where id=_id;
    end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizarMaterial`( in _id integer,
                                    in _material varchar(150),
                                    in _precio double,
                                    in _pvp double)
begin
                                    update material set material=_material,precio=_precio,pvp=_pvp where id=_id;
                                    end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizarParte`(in _id int,
    							 in _cliente varchar (50),
                                 in _telefono varchar (12),
                                 in _problema text,
                                 in _producto varchar (150),
                                 in _numSerie varchar (150)
                                 )
begin
	update partes set cliente=_cliente, telefono=_telefono,problema=_problema, producto=_producto, nserie=_numSerie
    where id=_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizarProveedor`(in _id integer,
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
	update proveedores set nif=_nif, perscto=_personaContacto, 		  email=_email,observaciones=_observaciones,domicilio=_domicilio, poblacion=_poblacion, provincia=_provincia, codpos=_codPos where id=_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizarPuesto`(IN `_id` INT, IN `_localizacion` VARCHAR(50), IN `_nombrePc` VARCHAR(50), IN `_usuario` VARCHAR(15), IN `_sistOperativo` VARCHAR(15), IN `_contrasena` VARCHAR(20), IN `_ip` VARCHAR(15))
begin
update puestos set localizacion=_localizacion, nombrepc=_nombrePc, usuario=_usuario, ip=_ip, soperativo=_sistOperativo,
					contrasena=_contrasena where id=_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizarRed`(in _id int,
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
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizarSubcuenta`( in _id int,
                                     in _direccion varchar(50),
                                     in _usuario varchar (50),
                                     in _contrasena varchar (20),
                                     in _ubicacion varchar(50)
                                     )
begin
	update subcuentas set direccion =_direccion, usuario=_usuario, contrasena=_contrasena, ubicacion=_ubicacion
    where id=_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizarTelefono`(in _id integer,
                                    in _nombre varchar(50),                                    
                                    in _telefono varchar(50),
                                    in _nombreTabla varchar(50)
                                    )
begin
	case _nombreTabla
    	when "cliente" then
        	update telefonoscliente set nombre=_nombre, telefono=_telefono where id=_id;
        when "proveedor" then
        	update telefonosproveedor set nombre=_nombre, telefono=_telefono where id=_id;
   	end case;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizarUsuario`(in _id integer,
                                   in _nombre varchar(50),
                                   in _nombreNuevo varchar(50)
                                   )
begin
                                   update usuarios set nombre=_nombreNuevo where id=_id;
                                   update partes set tecnico=_nombreNuevo where tecnico=_nombre;
                                   update cuaderno set persona=_nombreNuevo where persona=_nombre;
                                   end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizarYCerrarParte`(IN `_id` INT, IN `_fechaEntrada` VARCHAR(50), IN `_fechaSalida` VARCHAR(50), IN `_tecnico` VARCHAR(50), IN `_cliente` VARCHAR(50), IN `_telefono` VARCHAR(50), IN `_problema` TEXT, IN `_solucion` TEXT, IN `_producto` VARCHAR(150), IN `_numSerie` VARCHAR(150), IN `_totalEuros` DOUBLE, IN `_material` TEXT)
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
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `cerrarParte`(IN `_id` INT, IN `_fechaSalida` VARCHAR(50), IN `_tecnico` VARCHAR(50), IN `_solucion` TEXT, IN `_material` TEXT)
begin
    update partes set fechasalida=_fechaSalida, tecnico=_tecnico, solucion=_solucion,material=_material where id=_id;
    end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eliminarMaterial`( in _id integer)
begin
delete from material where id=_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eliminarPuesto`(in _id int)
begin
	delete from puestos where id=_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eliminarSubcuenta`(in _id int)
begin
	delete from subcuentas where id=_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eliminarTelefonos`(IN `_id` INT, IN `_nombreTabla` VARCHAR(50))
begin
case _nombreTabla
when "cliente" then
delete  from telefonoscliente where id=_id;
when "proveedor" then
delete  from telefonosproveedor where id=_id;
end case;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eliminarUsuario`(in _id integer)
begin
delete  from usuarios where id=_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `filtrarClientes`( in _filtro varchar(50))
begin
select * from clientes where clientes.nombre like _filtro;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `filtrarCorreo`(in _cliente varchar(50))
begin
	select * from correos where nombre like _cliente;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `filtrarCuaderno`(IN `_cliente` VARCHAR(50), IN `_persona` VARCHAR(50), IN `_resuelto` VARCHAR(50))
begin
                                 select * from cuaderno where cliente like _cliente and persona = _persona and resuelto = _resuelto;
                                 end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `filtrarMaterial`(IN `_material` VARCHAR(15))
begin
                                  select * from material where material.material like _material;
                                  end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `filtrarProveedores`(in _filtro varchar(150))
begin
select * from proveedores where nombre like _filtro;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `filtrarRed`(in _nombreCliente varchar (150))
begin
	select * from red where cliente like _nombreCliente;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `filtrarUsuario`(in _filtro varchar(20))
begin
	select nombre from usuarios where nombre like _filtro;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertarCliente`(IN `_nombre` VARCHAR(150), IN `_nif` VARCHAR(9), IN `_personaContacto` VARCHAR(150), IN `_email` VARCHAR(150), IN `_observaciones` TEXT, IN `_domicilio` VARCHAR(150), IN `_poblacion` VARCHAR(150), IN `_provincia` VARCHAR(50), IN `_codpos` VARCHAR(5))
begin
                                 insert into clientes (nombre,nif,perscto,email,observaciones,domicilio,poblacion,provincia,codpos)values(_nombre,_nif,_personaContacto,_email,_observaciones,_domicilio,_poblacion,_provincia,_codpos);
                                 end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertarCorreo`(IN `_proveedor` VARCHAR(50), IN `_idUsuario` VARCHAR(50), IN `_nombre` VARCHAR(50), IN `_direccionCorreo` VARCHAR(50), IN `_usuarioConexion` VARCHAR(50), IN `_nombreCuentaConexion` VARCHAR(50), IN `_contrasena` VARCHAR(20), IN `_servidorCorreoEntrante` VARCHAR(50), IN `_servidorCorreoSaliente` VARCHAR(50), IN `_observaciones` TEXT, IN `_subdominio` VARCHAR(50), IN `_usuarioGestion` VARCHAR(50), IN `_contrasenaGestion` VARCHAR(20), IN `_webGestion` VARCHAR(50))
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
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertarCuaderno`(
    in _fecha varchar(50),
    in _datos text,    
    in _persona varchar(50),
    in _resuelto varchar(15),
    in _cliente varchar(50)
    )
begin
    insert into cuaderno(fecha,datos,persona,resuelto,cliente)
    values(_fecha,_datos,_persona,_resuelto,_cliente);
    end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertarMaterial`(IN `_material` VARCHAR(150), IN `_precio` DOUBLE, IN `_pvp` DOUBLE)
begin
                                  insert into material (material,precio,pvp)values(_material,_precio,_pvp);
                                  end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertarParte`(IN `_fechaEntrada` VARCHAR(50), IN `_cliente` VARCHAR(50), IN `_telefono` VARCHAR(12), IN `_problema` TEXT, IN `_producto` VARCHAR(150), IN `_numSerie` VARCHAR(150), IN `_fechaSalida` VARCHAR(50), IN `_tecnico` VARCHAR(50), IN `_solucion` TEXT, IN `_total` DOUBLE, IN `_material` TEXT)
begin
    insert into partes(fechaentrada,cliente,telefono,problema,producto,nserie,fechasalida,tecnico,solucion,totalEuros,material)
    values(_fechaEntrada,_cliente,_telefono,_problema,_producto,_numSerie,_fechaSalida,_tecnico,_solucion,_total,_material);
    end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertarProveedor`(in _nombre varchar(150),
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
                                   end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertarPuesto`(in _idRed integer,
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
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertarRed`(in _cliente varchar(150),
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
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertarSubcuenta`(in _idCorreo int,
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
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertarTelefono`(IN `_id` INT, IN `_nombre` VARCHAR(50), IN `_telefono` VARCHAR(50), IN `_nombreTabla` VARCHAR(50))
begin
	case _nombreTabla
    	when "cliente" then
        	insert into telefonoscliente (id_cliente, nombre,telefono) values(_id,_nombre,_telefono);
        when "proveedor" then
        	insert into telefonosproveedor (id_proveedor, nombre,telefono)values (_id,_nombre,_telefono);
    end case;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertarTelefonos`(in _idRetorno integer,
                                   in _nombre varchar (15),
                                   in _telefono varchar(12),
                                   in _nombreTabla varchar(15)
                                   )
begin
                                   case _nombreTabla
                                   when "cliente" then
                                   insert into telefonoscliente(id_cliente,nombre,telefono) values(_idRetorno, _nombre, _telefono);
                                   when "proveedor" then
                                   insert into telefonosproveedor (id_proveedor, nombre, telefono) values(_idRetorno, _nombre,_telefono);
                                   end case;
                                   end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertarUsuario`(
    in _nombre varchar(50)
    )
begin
    insert into usuarios(nombre) values (_nombre);
    end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `login`(
    in _nombre varchar(50),
    in _contrasena varchar(50),
    out _resultado int
    )
begin
    select count(*) into _resultado from administracion where usuario=_nombre and contrasena=_contrasena;
    end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarCliente`( in _id integer)
begin
select * from clientes where clientes.id=_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarClientes`()
begin
select * from clientes;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarCorreo`(in _id int)
begin
	select * from correos where id=_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarCorreos`()
begin
	select * from correos;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarCuaderno`()
begin
select * from cuaderno;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarIncidenciaCuaderno`(in _id integer)
begin
select * from cuaderno where id=_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarIncidencias`()
begin 
select * from estadoincidencia;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarMaterial`()
begin
select* from material;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarParte`(in _id int)
begin
	select * from partes where id=_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarPartes`()
begin
select * from partes;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarProveedor`(IN `_id` INT)
begin
select * from proveedores where id=_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarProveedores`()
begin
select * from proveedores;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarPuestos`(in _id integer)
begin
	select * from puestos where idred=_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarRed`(in _id integer)
begin
	select * from red where id=_id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarRedes`()
begin
	select * from red;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarSubcuentas`(in _idCorreo int)
begin
	select * from subcuentas where idcorreo=_idCorreo;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarTelefonos`(IN `_id` INT, IN `_nombreTabla` VARCHAR(50))
begin
                                  case _nombreTabla
                                  when "cliente" then
                                  select * from telefonoscliente where id_cliente=_id;
                                  when "proveedor" then
                                  select * from telefonosproveedor where id_proveedor=_id;
                                  end case;
                                  end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarUltimoId`(IN `_nombreTabla` VARCHAR(15), OUT `_id` INT)
begin
 case _nombreTabla
   when "cliente" then
    select id into _id from clientes order by id desc limit 1;
                                                           when "proveedor" then
     select id into _id from proveedores order by id desc limit 1;
   when "red" then
     select id into _id from red order by id desc limit 1;
   when "correos" then
   select id into _id from correos order by id desc limit 1;
  end case;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarUsuarios`()
begin
select * from usuarios;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarUsuariosCuaderno`()
begin
select nombre from usuarios union select persona from cuaderno;
end$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `administracion`
--

CREATE TABLE IF NOT EXISTS `administracion` (
`id` int(11) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `contrasena` varchar(50) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE IF NOT EXISTS `clientes` (
`id` int(11) NOT NULL,
  `nombre` varchar(150) DEFAULT NULL,
  `nif` varchar(9) DEFAULT NULL,
  `perscto` varchar(150) DEFAULT NULL,
  `email` varchar(150) DEFAULT NULL,
  `observaciones` text,
  `domicilio` varchar(150) DEFAULT NULL,
  `poblacion` varchar(150) DEFAULT NULL,
  `provincia` varchar(50) DEFAULT NULL,
  `codpos` varchar(5) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=59 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `correos`
--

CREATE TABLE IF NOT EXISTS `correos` (
`id` int(11) NOT NULL,
  `proveedor` varchar(50) DEFAULT NULL,
  `idusuario` varchar(50) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `direccioncorreo` varchar(50) DEFAULT NULL,
  `usuarioconexion` varchar(50) DEFAULT NULL,
  `nombrecuentacon` varchar(50) DEFAULT NULL,
  `contrasena` varchar(20) DEFAULT NULL,
  `scorreoentrante` varchar(50) DEFAULT NULL,
  `scorreosaliente` varchar(50) DEFAULT NULL,
  `observaciones` text,
  `subdominio` varchar(50) DEFAULT NULL,
  `usugestion` varchar(50) DEFAULT NULL,
  `contragestion` varchar(20) DEFAULT NULL,
  `webgestion` varchar(50) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=26 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuaderno`
--

CREATE TABLE IF NOT EXISTS `cuaderno` (
`id` int(11) NOT NULL,
  `fecha` varchar(50) DEFAULT NULL,
  `datos` text,
  `persona` varchar(50) DEFAULT NULL,
  `resuelto` varchar(15) DEFAULT NULL,
  `cliente` varchar(50) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadoincidencia`
--

CREATE TABLE IF NOT EXISTS `estadoincidencia` (
`id` int(11) NOT NULL,
  `estadoIncidencia` varchar(12) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `material`
--

CREATE TABLE IF NOT EXISTS `material` (
`id` int(11) NOT NULL,
  `material` varchar(100) DEFAULT NULL,
  `precio` double DEFAULT NULL,
  `pvp` double DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `partes`
--

CREATE TABLE IF NOT EXISTS `partes` (
`id` int(11) NOT NULL,
  `fechaentrada` varchar(50) DEFAULT NULL,
  `fechasalida` varchar(50) DEFAULT NULL,
  `tecnico` varchar(50) DEFAULT NULL,
  `cliente` varchar(50) DEFAULT NULL,
  `telefono` varchar(12) DEFAULT NULL,
  `problema` text,
  `solucion` text,
  `producto` varchar(150) DEFAULT NULL,
  `nserie` varchar(150) DEFAULT NULL,
  `totalEuros` double DEFAULT NULL,
  `material` text
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=41 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE IF NOT EXISTS `proveedores` (
`id` int(11) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `nif` varchar(9) DEFAULT NULL,
  `perscto` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `observaciones` text,
  `domicilio` varchar(250) DEFAULT NULL,
  `poblacion` varchar(150) DEFAULT NULL,
  `provincia` varchar(50) DEFAULT NULL,
  `codpos` varchar(5) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `puestos`
--

CREATE TABLE IF NOT EXISTS `puestos` (
`id` int(11) NOT NULL,
  `idred` int(11) DEFAULT NULL,
  `localizacion` varchar(50) DEFAULT NULL,
  `nombrepc` varchar(15) DEFAULT NULL,
  `usuario` varchar(15) DEFAULT NULL,
  `ip` varchar(15) DEFAULT NULL,
  `soperativo` varchar(20) DEFAULT NULL,
  `contrasena` varchar(20) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=22 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `red`
--

CREATE TABLE IF NOT EXISTS `red` (
`id` int(11) NOT NULL,
  `cliente` varchar(150) DEFAULT NULL,
  `servidornom` varchar(15) DEFAULT NULL,
  `servidorip` varchar(15) DEFAULT NULL,
  `grupo` varchar(15) DEFAULT NULL,
  `router` varchar(15) DEFAULT NULL,
  `dns1` varchar(15) DEFAULT NULL,
  `dns2` varchar(15) DEFAULT NULL,
  `mascara` varchar(15) DEFAULT NULL,
  `usuariorouter` varchar(50) DEFAULT NULL,
  `contrasenarouter` varchar(50) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=18 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `subcuentas`
--

CREATE TABLE IF NOT EXISTS `subcuentas` (
`id` int(11) NOT NULL,
  `idcorreo` int(11) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `usuario` varchar(20) DEFAULT NULL,
  `contrasena` varchar(20) DEFAULT NULL,
  `ubicacion` varchar(50) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `telefonoscliente`
--

CREATE TABLE IF NOT EXISTS `telefonoscliente` (
`id` int(11) NOT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `telefono` varchar(12) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=102 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `telefonosproveedor`
--

CREATE TABLE IF NOT EXISTS `telefonosproveedor` (
`id` int(11) NOT NULL,
  `id_proveedor` int(11) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `telefono` varchar(12) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=17 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE IF NOT EXISTS `usuarios` (
`id` int(11) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=18 ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `administracion`
--
ALTER TABLE `administracion`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `correos`
--
ALTER TABLE `correos`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `cuaderno`
--
ALTER TABLE `cuaderno`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `estadoincidencia`
--
ALTER TABLE `estadoincidencia`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `material`
--
ALTER TABLE `material`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `partes`
--
ALTER TABLE `partes`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `proveedores`
--
ALTER TABLE `proveedores`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `puestos`
--
ALTER TABLE `puestos`
 ADD PRIMARY KEY (`id`), ADD KEY `idred` (`idred`), ADD KEY `idred_2` (`idred`);

--
-- Indices de la tabla `red`
--
ALTER TABLE `red`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `subcuentas`
--
ALTER TABLE `subcuentas`
 ADD PRIMARY KEY (`id`), ADD KEY `idcorreo` (`idcorreo`);

--
-- Indices de la tabla `telefonoscliente`
--
ALTER TABLE `telefonoscliente`
 ADD PRIMARY KEY (`id`), ADD KEY `id_cliente` (`id_cliente`);

--
-- Indices de la tabla `telefonosproveedor`
--
ALTER TABLE `telefonosproveedor`
 ADD PRIMARY KEY (`id`), ADD KEY `id_proveedor` (`id_proveedor`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
 ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `administracion`
--
ALTER TABLE `administracion`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=59;
--
-- AUTO_INCREMENT de la tabla `correos`
--
ALTER TABLE `correos`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=26;
--
-- AUTO_INCREMENT de la tabla `cuaderno`
--
ALTER TABLE `cuaderno`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT de la tabla `estadoincidencia`
--
ALTER TABLE `estadoincidencia`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `material`
--
ALTER TABLE `material`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT de la tabla `partes`
--
ALTER TABLE `partes`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=41;
--
-- AUTO_INCREMENT de la tabla `proveedores`
--
ALTER TABLE `proveedores`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT de la tabla `puestos`
--
ALTER TABLE `puestos`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT de la tabla `red`
--
ALTER TABLE `red`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT de la tabla `subcuentas`
--
ALTER TABLE `subcuentas`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT de la tabla `telefonoscliente`
--
ALTER TABLE `telefonoscliente`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=102;
--
-- AUTO_INCREMENT de la tabla `telefonosproveedor`
--
ALTER TABLE `telefonosproveedor`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=18;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `puestos`
--
ALTER TABLE `puestos`
ADD CONSTRAINT `puestos_ibfk_1` FOREIGN KEY (`idred`) REFERENCES `red` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `subcuentas`
--
ALTER TABLE `subcuentas`
ADD CONSTRAINT `subcuentas_ibfk_1` FOREIGN KEY (`idcorreo`) REFERENCES `correos` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `telefonoscliente`
--
ALTER TABLE `telefonoscliente`
ADD CONSTRAINT `telefonoscliente_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `clientes` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `telefonosproveedor`
--
ALTER TABLE `telefonosproveedor`
ADD CONSTRAINT `telefonosproveedor_ibfk_1` FOREIGN KEY (`id_proveedor`) REFERENCES `proveedores` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
