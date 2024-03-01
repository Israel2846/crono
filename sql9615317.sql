-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Servidor: sql9.freemysqlhosting.net
-- Tiempo de generación: 07-05-2023 a las 20:38:04
-- Versión del servidor: 5.5.62-0ubuntu0.14.04.1
-- Versión de PHP: 7.0.33-0ubuntu0.16.04.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `sql9615317`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Pagos`
--

CREATE TABLE `Pagos` (
  `Id_pagos` int(11) NOT NULL,
  `Folio` int(11) DEFAULT NULL,
  `Monto` int(11) DEFAULT NULL,
  `Fecha` varchar(80) DEFAULT NULL,
  `Periodo` varchar(80) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `Pagos`
--

INSERT INTO `Pagos` (`Id_pagos`, `Folio`, `Monto`, `Fecha`, `Periodo`) VALUES
(1, 123, 0, '', ''),
(3, 102, 200, '04/04/2023', 'Abril'),
(4, 139, 100, '01/05/2023', '1a Mayo'),
(5, 158, 100, '04/05/2023', '1ra mayo'),
(6, 121, 200, '5/5/23', '1a y 2a Mayo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Usuriaos`
--

CREATE TABLE `Usuriaos` (
  `Folio` int(11) NOT NULL,
  `Nombre` varchar(80) NOT NULL,
  `App` varchar(80) NOT NULL,
  `Apm` varchar(80) NOT NULL,
  `Cargo` varchar(80) NOT NULL,
  `Lug_trabajo` varchar(80) NOT NULL,
  `Puesto` varchar(80) NOT NULL,
  `Fecha_alta` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `Usuriaos`
--

INSERT INTO `Usuriaos` (`Folio`, `Nombre`, `App`, `Apm`, `Cargo`, `Lug_trabajo`, `Puesto`, `Fecha_alta`) VALUES
(101, 'Ines', '', '', '1 y 2 abril', 'Tecamac ', 'policia ', ''),
(102, 'Silvestre ', 'Rojas', 'Urquiza', '1 y 2 abril', 'Municipio de Tecamac ', 'Policia ', '02/07/2021'),
(115, '', '', '', '', '', '', ''),
(119, 'Carlos', 'Figueroa ', 'Santillan', 'Vigente ', 'Texcoco ', 'municipal ', ''),
(120, 'Martin', 'De Santiago ', 'Pardo', 'Vigente', 'CDMX ', 'Ministerio Público FGJCDMX ', ''),
(121, 'Jorge ', 'Morales ', 'Salas ', '1 y 2 mayo', 'Texcoco ', 'Policía SSC ESTATAL ', ''),
(123, 'Karina Miriam', 'Fernández ', 'Villagran', 'CANCELADO', 'Municipio de Tecamac ', 'Policia Guardia Civil ', '10/01/2021'),
(128, 'Federico ', 'Sanchez ', 'Rodríguez ', 'Permiso temporal', 'Tecamac ', 'Policía guardia civil', ''),
(129, 'Cristian Emmanuel ', 'León ', 'Jiménez', 'Vigente ', 'Nezahualcoyotl ', 'SSC Neza', ''),
(130, 'Alberto ', 'Cruz ', 'Silva ', 'Vigente', 'CDMX', 'SSC CDMX ', ''),
(131, 'Felipe', 'Ramirez ', 'Fonseca', 'Vigente', 'Tultitlán ', 'municipal Tultitlán ', ''),
(132, 'Pedro', 'Leonides', 'Ricardo', 'vigente', 'Tecamac', 'guardia civil', ''),
(133, 'Carlos', 'Butanda', 'Gutiérrez ', 'Vigente', 'Tecamac ', 'guardia civil ', ''),
(135, 'Yan Carlos', 'Mendez ', 'Hernández ', 'Vigente', 'Texcoco ', 'Policía SSC ESTATAL ', ''),
(139, 'Ruben ', 'Vazquez ', 'López ', 'CANCELADO ', 'Municipio de Tecamac ', 'Policia ', ''),
(141, 'Eduardo ', 'Casasola ', 'Arciniega ', 'CANCELADO ', 'Tecamac ', 'Guardia Civil ', ''),
(142, 'Angelina Ivonne', 'Gallardo', 'Gutiérrez ', 'CANCELADO', 'Cdmx ', 'CCS Cdmx', ''),
(143, 'Obed Alberto ', 'Garnica ', 'Zamitiz', 'CANCELADO ', 'CDMX', 'CCS CDMX', ''),
(144, 'Héctor Cesar', 'García ', 'Montesinos ', 'policía ', 'Tecamac ', 'guardía civil ', ''),
(145, 'Héctor ', 'Banda', 'Chavez', 'policía ', 'Tecamac ', 'Guardía civil ', ''),
(146, 'Josué Guadalupe ', 'Ramirez ', 'Guzmán ', 'policía ', 'CDMX', 'SSC CDMX ', ''),
(147, 'Sergio Isael', 'Rodríguez ', 'González ', 'policía ', 'Edo. Mex', 'SSP', ''),
(148, 'Anahí Berenice', 'Mejia', 'Ramirez', 'CANCELADO ', 'chicoloapan ', 'SSC', '00'),
(149, 'Jesus ', 'Roldan', '', 'policia', '', '', ''),
(150, 'Felix', 'González ', 'Sanchez', 'CANCELADO', 'Tecamac ', 'guardia civil ', ''),
(151, 'Christian ', 'Velazco', 'Torres', '', 'Ecatepec ', 'PDI FGJEM Homicidios ', ''),
(152, 'María Magdalena ', 'Castañeda ', 'Roman', 'policia', 'Tecamac ', 'Guardia civil ', ''),
(153, 'Abel', 'Betanzos ', 'Escarcega ', 'policia', 'Tecamac ', 'Guardía civil ', ''),
(154, 'Francisco Javier ', 'Ugarte ', 'Guerrero ', 'policia', 'CDMX', 'SSC CDMX', ''),
(155, 'Mitzi', 'Romero', 'Garcia', 'policia', 'Tecamac ', 'Guardia civil ', ''),
(156, 'Edwin Geovanny ', 'Martinez', 'Osnaya', 'policia', 'Tecamac ', 'Guardia civil', ''),
(157, 'Wendy', 'Flores ', 'Ramirez', 'policia', 'Tecamac ', 'Guardia civil', ''),
(158, 'Fidel Ferderico', 'Bello', 'Buendia', '1a Mayo 23', 'Nezahualcoyotl ', 'policía municipal ', ''),
(159, 'María Eugenia ', 'Magdaleno ', 'Rodriguez', 'policia', 'Tecamac ', 'Guardia Civil', '12/01/2023'),
(160, 'Julieta Alejandra', 'Ramirez', 'Osorio', 'policia', 'Ecatepec ', 'municipal Ecatepec ', '17/01/2023'),
(161, 'Luis David', 'Romero ', 'Nava', 'policia', 'Tlahuac ', 'policía SSC', '19/01/2023'),
(162, 'América Emilse', 'Luna ', 'Angeles', 'policia', 'Tecamac', 'Guardia Civil', '04/03/2023'),
(163, 'Octavio', 'Ruiz', 'Jiménez ', 'policia', 'Tecamac', 'Guardia civil', '06/03/2023'),
(164, 'José Luis', 'Pérez ', 'Guerrero ', '', 'Ecatepec ', 'Policía Municipal', '14/04/2023');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `Pagos`
--
ALTER TABLE `Pagos`
  ADD PRIMARY KEY (`Id_pagos`),
  ADD KEY `Folio` (`Folio`);

--
-- Indices de la tabla `Usuriaos`
--
ALTER TABLE `Usuriaos`
  ADD PRIMARY KEY (`Folio`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `Pagos`
--
ALTER TABLE `Pagos`
  MODIFY `Id_pagos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `Usuriaos`
--
ALTER TABLE `Usuriaos`
  MODIFY `Folio` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=165;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `Pagos`
--
ALTER TABLE `Pagos`
  ADD CONSTRAINT `Pagos_ibfk_1` FOREIGN KEY (`Folio`) REFERENCES `Usuriaos` (`Folio`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
