# Host: localhost  (Version 5.7.21-log)
# Date: 2018-05-16 10:38:46
# Generator: MySQL-Front 6.0  (Build 2.20)


#
# Structure for table "folios"
#

DROP TABLE IF EXISTS `folios`;
CREATE TABLE `folios` (
  `Folio` int(11) NOT NULL,
  `Tipo_Tramite` int(11) NOT NULL,
  `Trabajador` int(11) DEFAULT NULL,
  `Estatus` varchar(50) DEFAULT NULL,
  `Fecha_Inicio` date DEFAULT NULL,
  `Fecha_Fin` date DEFAULT NULL,
  PRIMARY KEY (`Folio`,`Tipo_Tramite`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "folios"
#


#
# Structure for table "notasbuenas"
#

DROP TABLE IF EXISTS `notasbuenas`;
CREATE TABLE `notasbuenas` (
  `Folio` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha_Genera` date DEFAULT NULL,
  `Trabajador` int(11) DEFAULT NULL,
  `Generada` int(11) DEFAULT NULL,
  `No_Oficio` int(11) DEFAULT NULL,
  `Fecha_Uso` date DEFAULT NULL,
  `Usada` bit(1) DEFAULT b'0',
  PRIMARY KEY (`Folio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "notasbuenas"
#


#
# Structure for table "notasmalas"
#

DROP TABLE IF EXISTS `notasmalas`;
CREATE TABLE `notasmalas` (
  `Folio` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha_Genera` date DEFAULT NULL,
  `Trabajador` int(11) DEFAULT NULL,
  `Generada` int(11) DEFAULT NULL,
  `No_Oficio` int(11) DEFAULT NULL,
  PRIMARY KEY (`Folio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "notasmalas"
#


#
# Structure for table "tramites"
#

DROP TABLE IF EXISTS `tramites`;
CREATE TABLE `tramites` (
  `No_Tramite` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) DEFAULT NULL,
  `Tramite_Local` bit(1) DEFAULT NULL,
  PRIMARY KEY (`No_Tramite`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

#
# Data for table "tramites"
#

INSERT INTO `tramites` VALUES (1,'TRAMITE LENTES',b'0'),(2,'ESTIMULO 10 AÑOS',b'0'),(3,'ESTIMULO 20 AÑOS',b'0'),(4,'JUBILACION',b'0');

#
# Structure for table "usuarios"
#

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Usuario` varchar(50) DEFAULT NULL,
  `Contraseña` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Usuario` (`Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

#
# Data for table "usuarios"
#

INSERT INTO `usuarios` VALUES (1,'Informatica','12345'),(2,'RecursosHumanos','12345'),(3,'Publicidad','12345'),(4,'Finanzas','12345'),(5,'Administracion','12345');

#
# Structure for table "personal"
#

DROP TABLE IF EXISTS `personal`;
CREATE TABLE `personal` (
  `Num_emp` int(11) DEFAULT NULL,
  `RFC` varchar(13) DEFAULT NULL,
  `Nombre` varchar(50) DEFAULT NULL,
  `Ap_Paterno` varchar(35) DEFAULT NULL,
  `Ap_Materno` varchar(35) DEFAULT NULL,
  `Departamento` int(11) DEFAULT NULL,
  `Puesto` varchar(50) DEFAULT NULL,
  `Fecha_Ingreso` date DEFAULT NULL,
  UNIQUE KEY `Num_emp` (`Num_emp`),
  UNIQUE KEY `RFC` (`RFC`),
  CONSTRAINT `personal_ibfk_1` FOREIGN KEY (`Num_emp`) REFERENCES `usuarios` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "personal"
#

INSERT INTO `personal` VALUES (1,'GACP730422AG2','PASCUAL DANIEL','GARCIA','CERVANTES',1,'JEFE_COMPUTO','2018-04-01'),(2,'MALM670531740','MONICA','MARTINEZ','LOPEZ',2,'JEFE_RHUMANOS','2018-04-02'),(3,'OAMO770601PQ4','OLIVIA','OBANDO','MARTINEZ',3,'PUBLICISTA','2018-04-03'),(4,'PIPE710201T17','EFRAIN','PICAZO','PEREZ',4,'AUX_ADMVO','2018-04-04'),(5,'CADC611215CF4','CARLOS ARTURO','CANSECO','DAVILA',5,'ADMINISTRADOR','2018-04-05');

#
# Structure for table "departamentos"
#

DROP TABLE IF EXISTS `departamentos`;
CREATE TABLE `departamentos` (
  `Num_Depto` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) DEFAULT NULL,
  `Jefe_Depto` int(11) DEFAULT NULL,
  PRIMARY KEY (`Num_Depto`),
  UNIQUE KEY `Nombre` (`Nombre`),
  KEY `Jefe_Depto` (`Jefe_Depto`),
  CONSTRAINT `departamentos_ibfk_1` FOREIGN KEY (`Jefe_Depto`) REFERENCES `usuarios` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

#
# Data for table "departamentos"
#

INSERT INTO `departamentos` VALUES (1,'INFORMATICA',1),(2,'RECURSOS HUMANOS',2),(3,'PUBLICIDAD Y MERCADOTECNIA',3),(4,'FINANZAS Y CONTABILIDAD',4),(5,'ADMINISTRACION',5);

#
# Procedure "Departamentos"
#

DROP PROCEDURE IF EXISTS `Departamentos`;
CREATE PROCEDURE `Departamentos`()
BEGIN
  SELECT
    `Num_Depto` AS 'ID', `Departamentos`.`Nombre` as 'Departamento', `Personal`.`Nombre` as 'Jefe de Departamento'
  FROM
    `Departamentos`,
    `Personal`
  WHERE
    `Jefe_Depto` = `Num_Emp`;
END;

#
# Procedure "HacerLogin"
#

DROP PROCEDURE IF EXISTS `HacerLogin`;
CREATE PROCEDURE `HacerLogin`(Usuario varchar(50))
BEGIN
  SELECT `Contraseña` FROM `Usuarios` WHERE `Usuarios`.`Usuario` = Usuario;
END;

#
# Procedure "Personal"
#

DROP PROCEDURE IF EXISTS `Personal`;
CREATE PROCEDURE `Personal`()
BEGIN
  SELECT
    `Num_emp` AS 'ID',
    `RFC`,
    `Personal`.`Nombre`,
    `Ap_Paterno` AS 'Apellido Paterno',
    `Ap_Materno` AS 'Apellido Materno',
    `Departamentos`.`Nombre` AS 'Depto.',
    `Puesto`,
    `Fecha_Ingreso` AS 'Alta'
  FROM
    `Personal`,
    `Departamentos`
  WHERE
    `Personal`.`Departamento` = `Departamentos`.`Num_Depto`;
END;

#
# Procedure "Tramites"
#

DROP PROCEDURE IF EXISTS `Tramites`;
CREATE PROCEDURE `Tramites`()
BEGIN
  SELECT
    `No_Tramite` AS '# Tramite', `Nombre`, IF(`Tramite_Local`, 'SI', 'NO') AS 'Tramite Local'
  FROM
    `Tramites`;
END;
