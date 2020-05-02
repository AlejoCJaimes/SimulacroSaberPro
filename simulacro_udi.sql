-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 02-05-2020 a las 10:05:22
-- Versión del servidor: 10.4.11-MariaDB
-- Versión de PHP: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `simulacro_udi`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `query_res_doc` (IN `_titpru` VARCHAR(200), IN `_fecha1` DATE, IN `_fecha2` DATE, IN `_numprueba` VARCHAR(10), IN `consult` VARCHAR(40))  BEGIN
    CASE consult
	WHEN 'query_1' THEN
		SELECT p.descripcion as Pregunta 
		FROM pregunta p JOIN pruebapreguntas pg ON p.id = pg.idpregunta 
		where pg.num_prueba = (select count(*) as cantidad from pruebapreguntas pg
        	GROUP BY pg.idpregunta ORDER BY 
		cantidad DESC LIMIT 1)
        	GROUP BY pg.idpregunta 
		ORDER BY pregunta 
		DESC limit 1;
        WHEN 'query_2' THEN
                SELECT e.descripcion as ENUNCIADO, count(*) as cantidad
		FROM enunciado e JOIN pregunta p ON e.id = p.id_enunciado
		GROUP BY p.id_enunciado ORDER BY
		cantidad DESC LIMIT 1 ;	 
	WHEN 'query_3' THEN
		select CONCAT(e.Nombre,' ',e.Apellido) as Estudiante, (select count(*)
		from preguntaopciones po 
		JOIN pregunta p ON p.Id = po.Id_Pregunta 
		JOIN pruebapreguntas pre ON pre.IdPregunta = p.Id 
		JOIN prueba pru ON pru.NumPrueba = pre.num_prueba 
		JOIN estudianteprueba est ON est.NumPrueba = pru.NumPrueba
		WHERE e.Ident_num = est.Ident_num_estud AND po.Id_Opciones in ( select (min(po.Id_Opciones) + 		ep.Opc_estudiante) as opcionseleccionada 
		from preguntaopciones po, estudiantepregunta ep 
		where ep.IdPregunta = po.Id_Pregunta AND e.Ident_num = ep.Ident_Estud
		GROUP BY ep.Opc_estudiante, po.Id_Pregunta) 
		AND pru.titulo LIKE _titpru AND po.Opc_correcta = 1 
		GROUP BY po.Opc_correcta, e.Nombre, e.Apellido) as correctas,(select count(*)
		from preguntaopciones po 
		JOIN pregunta p ON p.Id = po.Id_Pregunta 
		JOIN pruebapreguntas pre ON pre.IdPregunta = p.Id 
		JOIN prueba pru ON pru.NumPrueba = pre.num_prueba 
		JOIN estudianteprueba est ON est.NumPrueba = pru.NumPrueba
		WHERE e.Ident_num = est.Ident_num_estud AND po.Id_Opciones in ( select (min(po.Id_Opciones) + 		ep.Opc_estudiante) as opcionseleccionada 
		from preguntaopciones po, estudiantepregunta ep 
		where ep.IdPregunta = po.Id_Pregunta AND e.Ident_num = ep.Ident_Estud
		GROUP BY ep.Opc_estudiante, po.Id_Pregunta) 
		AND pru.titulo LIKE _titpru AND po.Opc_correcta = 0 
		GROUP BY po.Opc_correcta, e.Nombre, e.Apellido) as incorrectas
		from estudiante e
		join estudianteprueba est ON e.Ident_num = est.Ident_num_estud
		JOIN pruebapreguntas pp ON pp.num_prueba = est.NumPrueba
		where est.NumPrueba = _numprueba
		GROUP BY correctas,incorrectas,est.NumPrueba,e.Nombre,e.Apellido;
		
		WHEN 'query_4' THEN
		
		SELECT pru.titulo as Prueba, pru.fecha_creacion as "Fecha Creacion", count(*) as "Cantidad de 				Preguntas"
		FROM prueba pru
		JOIN pruebapreguntas pp ON pru.numprueba = pp.num_prueba
		WHERE pru.Fecha_creacion BETWEEN _fecha1 AND _fecha2
		GROUP BY pru.Titulo,pru.Fecha_creacion;

	WHEN 'query_5' THEN
		select CONCAT(e.Nombre,' ',e.Apellido) as Estudiante,count(*) as correctas
		from preguntaopciones po 
		JOIN pregunta p ON p.Id = po.Id_Pregunta 
		JOIN pruebapreguntas pre ON pre.IdPregunta = p.Id 
		JOIN prueba pru ON pru.NumPrueba = pre.num_prueba 
		JOIN estudianteprueba est ON est.NumPrueba = pru.NumPrueba
		JOIN estudiante e ON e.Ident_num = est.Ident_num_estud
		WHERE po.Id_Opciones in ( select (min(po.Id_Opciones) + ep.Opc_estudiante) as opcionseleccionada 
		from preguntaopciones po, estudiantepregunta ep 
		where ep.IdPregunta = po.Id_Pregunta AND e.Ident_num = ep.Ident_Estud
		GROUP BY ep.Opc_estudiante, po.Id_Pregunta) 
		AND pru.titulo LIKE _titpru AND po.Opc_correcta = 1 
		GROUP BY po.Opc_correcta, e.Nombre, e.Apellido
		ORDER BY correctas DESC;
    
    	END CASE;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `_query_res_est` (IN `_cedEst` VARCHAR(15), IN `_titpru` VARCHAR(200), IN `consultar` VARCHAR(20))  BEGIN
	CASE consultar
	WHEN 'query_1' THEN
	SELECT CONCAT(e.nombre,' ',e.apellido) as Estudiante, count(*) as "Pruebas Presentadas"
	FROM estudiante e
	JOIN estudianteprueba epru ON e.ident_num=epru.ident_num_estud 
	where e.ident_num = _cedEst;
	
	WHEN 'query_2_c1' THEN
	SELECT COUNT(*) AS "Preguntas_Competencia", (select count(*) from preguntaopciones po JOIN pregunta p on 		p.Id = po.Id_Pregunta JOIN pruebapreguntas pre on pre.IdPregunta = p.Id JOIN prueba pru ON pru.NumPrueba = 		pre.num_prueba where po.Id_Opciones in ( select (min(po.Id_Opciones) + ep.Opc_estudiante) as 		opcionseleccionada from competencias c, preguntaopciones po, estudiantepregunta ep where ep.Ident_Estud = 		_cedEst and ep.IdPregunta = po.Id_Pregunta AND c.Id = p.idCompetencia AND c.Nombre = 'Lectura Critica'
	GROUP BY ep.Opc_estudiante, po.Id_Pregunta,c.Nombre) AND UPPER(pru.titulo) LIKE _titpru AND 		po.Opc_correcta = 1 GROUP BY po.Opc_correcta) as correctas
	from competencias c
	JOIN pregunta p ON c.Id = p.idCompetencia
	JOIN pruebapreguntas pre ON pre.IdPregunta = p.Id 
	JOIN prueba pru ON pru.NumPrueba = pre.num_prueba 
	JOIN estudianteprueba ep ON pru.numprueba = ep.numprueba
	WHERE c.nombre = 'Lectura Critica' AND UPPER(pru.titulo) LIKE _titpru
	AND ep.ident_num_estud = _cedEst;

	WHEN 'query_2_c2' THEN
	SELECT COUNT(*) AS "Preguntas_Competencia", (select count(*) from preguntaopciones po JOIN pregunta p on 		p.Id = po.Id_Pregunta JOIN pruebapreguntas pre on pre.IdPregunta = p.Id JOIN prueba pru ON pru.NumPrueba = 		pre.num_prueba where po.Id_Opciones in ( select (min(po.Id_Opciones) + ep.Opc_estudiante) as 		opcionseleccionada from competencias c, preguntaopciones po, estudiantepregunta ep where ep.Ident_Estud = 		_cedEst and ep.IdPregunta = po.Id_Pregunta AND c.Id = p.idCompetencia AND c.Nombre = 'Competencias Ciudadanas'
	GROUP BY ep.Opc_estudiante, po.Id_Pregunta,c.Nombre) AND UPPER(pru.titulo) LIKE _titpru AND 		po.Opc_correcta = 1 GROUP BY po.Opc_correcta) as correctas
	from competencias c
	JOIN pregunta p ON c.Id = p.idCompetencia
	JOIN pruebapreguntas pre ON pre.IdPregunta = p.Id 
	JOIN prueba pru ON pru.NumPrueba = pre.num_prueba 
	JOIN estudianteprueba ep ON pru.numprueba = ep.numprueba
	WHERE c.nombre = 'Competencias Ciudadanas' AND UPPER(pru.titulo) LIKE _titpru
	AND ep.ident_num_estud = _cedEst;

	WHEN 'query_2_c3' THEN
	SELECT COUNT(*) AS "Preguntas_Competencia", (select count(*) from preguntaopciones po JOIN pregunta p on 			p.Id = po.Id_Pregunta JOIN pruebapreguntas pre on pre.IdPregunta = p.Id JOIN prueba pru ON pru.NumPrueba = 			pre.num_prueba where po.Id_Opciones in ( select (min(po.Id_Opciones) + ep.Opc_estudiante) as 				opcionseleccionada from competencias c, preguntaopciones po, estudiantepregunta ep where ep.Ident_Estud = 			_cedEst and ep.IdPregunta = po.Id_Pregunta AND c.Id = p.idCompetencia AND c.Nombre = 'Razonamiento Cuantitativo'
	GROUP BY ep.Opc_estudiante, po.Id_Pregunta,c.Nombre) AND UPPER(pru.titulo) LIKE _titpru AND 					po.Opc_correcta = 1 GROUP BY po.Opc_correcta) as correctas
	from competencias c
	JOIN pregunta p ON c.Id = p.idCompetencia
	JOIN pruebapreguntas pre ON pre.IdPregunta = p.Id 
	JOIN prueba pru ON pru.NumPrueba = pre.num_prueba 
	JOIN estudianteprueba ep ON pru.numprueba = ep.numprueba
	WHERE c.nombre = 'Razonamiento Cuantitativo' AND UPPER(pru.titulo) LIKE _titpru
	AND ep.ident_num_estud = _cedEst;

	WHEN 'query_2_c4' THEN
	SELECT COUNT(*) AS "Preguntas_Competencia", (select count(*) from preguntaopciones po JOIN pregunta p on 		p.Id = po.Id_Pregunta JOIN pruebapreguntas pre on pre.IdPregunta = p.Id JOIN prueba pru ON pru.NumPrueba = 		pre.num_prueba where po.Id_Opciones in ( select (min(po.Id_Opciones) + ep.Opc_estudiante) as 			opcionseleccionada from competencias c, preguntaopciones po, estudiantepregunta ep where ep.Ident_Estud = 		_cedEst and ep.IdPregunta = po.Id_Pregunta AND c.Id = p.idCompetencia AND c.Nombre = 'Inglés'
	GROUP BY ep.Opc_estudiante, po.Id_Pregunta,c.Nombre) AND UPPER(pru.titulo) LIKE _titpru AND 				po.Opc_correcta = 1 GROUP BY po.Opc_correcta) as correctas
	from competencias c
	JOIN pregunta p ON c.Id = p.idCompetencia
	JOIN pruebapreguntas pre ON pre.IdPregunta = p.Id 
	JOIN prueba pru ON pru.NumPrueba = pre.num_prueba 
	JOIN estudianteprueba ep ON pru.numprueba = ep.numprueba
	WHERE c.nombre = 'Inglés' AND UPPER(pru.titulo) LIKE _titpru
	AND ep.ident_num_estud = _cedEst;
	
	WHEN 'query_3' THEN
	SELECT count(*) as "Cantidad de Preguntas"
		FROM prueba pru
		JOIN pruebapreguntas pp ON pru.numprueba = pp.num_prueba
		WHERE (pru.titulo) LIKE _titpru
		GROUP BY pru.Titulo;
	END CASE;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ciudad`
--

CREATE TABLE `ciudad` (
  `codigo` varchar(5) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `codDpto` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ciudad`
--

INSERT INTO `ciudad` (`codigo`, `nombre`, `codDpto`) VALUES
('11001', 'BOGOTA', '11'),
('13001', 'CARTAGENA', '13'),
('13006', 'ACHI', '13'),
('13030', 'ALTOS DEL ROSARIO', '13'),
('13042', 'ARENAL', '13'),
('13052', 'ARJONA', '13'),
('13062', 'ARROYOHONDO', '13'),
('13074', 'BARRANCO DE LOBA', '13'),
('13140', 'CALAMAR', '13'),
('13160', 'CANTAGALLO', '13'),
('13188', 'CICUCO', '13'),
('13212', 'CORDOBA', '13'),
('13222', 'CLEMENCIA', '13'),
('13244', 'EL CARMEN DE BOLIVAR', '13'),
('13248', 'EL GUAMO', '13'),
('13268', 'EL PENON', '13'),
('13300', 'HATILLO DE LOBA', '13'),
('13430', 'MAGANGUE', '13'),
('13433', 'MAHATES', '13'),
('13440', 'MARGARITA', '13'),
('13442', 'MARIA LA BAJA', '13'),
('13458', 'MONTECRISTO', '13'),
('13468', 'MOMPOS', '13'),
('13473', 'MORALES', '13'),
('13549', 'PINILLOS', '13'),
('13580', 'REGIDOR', '13'),
('13600', 'RIO VIEJO', '13'),
('13620', 'SAN CRISTOBAL', '13'),
('13647', 'SAN ESTANISLAO', '13'),
('13650', 'SAN FERNANDO', '13'),
('13654', 'SAN JACINTO', '13'),
('13655', 'SAN JACINTO DEL CAUCA', '13'),
('13657', 'SAN JUAN NEPOMUCENO', '13'),
('13667', 'SAN MARTIN DE LOBA', '13'),
('13670', 'SAN PABLO', '13'),
('13673', 'SANTA CATALINA', '13'),
('13683', 'SANTA ROSA', '13'),
('13688', 'SANTA ROSA DEL SUR', '13'),
('13744', 'SIMITI', '13'),
('13760', 'SOPLAVIENTO', '13'),
('13780', 'TALAIGUA NUEVO', '13'),
('13810', 'TIQUISIO', '13'),
('13836', 'TURBACO', '13'),
('13838', 'TURBANA', '13'),
('13873', 'VILLANUEVA', '13'),
('13894', 'ZAMBRANO', '13'),
('15001', 'TUNJA', '15'),
('15022', 'ALMEIDA', '15'),
('15047', 'AQUITANIA', '15'),
('15051', 'ARCABUCO', '15'),
('15087', 'BELEN', '15'),
('15090', 'BERBEO', '15'),
('15092', 'BETEITIVA', '15'),
('15097', 'BOAVITA', '15'),
('15104', 'BOYACA', '15'),
('15106', 'BRICENO', '15'),
('15109', 'BUENAVISTA', '15'),
('15114', 'BUSBANZA', '15'),
('15131', 'CALDAS', '15'),
('15135', 'CAMPOHERMOSO', '15'),
('15162', 'CERINZA', '15'),
('15172', 'CHINAVITA', '15'),
('15176', 'CHIQUINQUIRA', '15'),
('15180', 'CHISCAS', '15'),
('15183', 'CHITA', '15'),
('15185', 'CHITARAQUE', '15'),
('15187', 'CHIVATA', '15'),
('15189', 'CIENEGA', '15'),
('15204', 'COMBITA', '15'),
('15212', 'COPER', '15'),
('15215', 'CORRALES', '15'),
('15218', 'COVARACHIA', '15'),
('15223', 'CUBARA', '15'),
('15224', 'CUCAITA', '15'),
('15226', 'CUITIVA', '15'),
('15232', 'CHIQUIZA', '15'),
('15236', 'CHIVOR', '15'),
('15238', 'DUITAMA', '15'),
('15244', 'EL COCUY', '15'),
('15248', 'EL ESPINO', '15'),
('15272', 'FIRAVITOBA', '15'),
('15276', 'FLORESTA', '15'),
('15293', 'GACHANTIVA', '15'),
('15296', 'GAMEZA', '15'),
('15299', 'GARAGOA', '15'),
('15317', 'GUACAMAYAS', '15'),
('15322', 'GUATEQUE', '15'),
('15325', 'GUAYATA', '15'),
('15332', 'GUICAN', '15'),
('15362', 'IZA', '15'),
('15367', 'JENESANO', '15'),
('15368', 'JERICO', '15'),
('15377', 'LABRANZAGRANDE', '15'),
('15380', 'LA CAPILLA', '15'),
('15401', 'LA VICTORIA', '15'),
('15403', 'LA UVITA', '15'),
('15407', 'VILLA DE LEYVA', '15'),
('15425', 'MACANAL', '15'),
('15442', 'MARIPI', '15'),
('15455', 'MIRAFLORES', '15'),
('15464', 'MONGUA', '15'),
('15466', 'MONGUI', '15'),
('15469', 'MONIQUIRA', '15'),
('15476', 'MOTAVITA', '15'),
('15480', 'MUZO', '15'),
('15491', 'NOBSA', '15'),
('15494', 'NUEVO COLON', '15'),
('15500', 'OICATA', '15'),
('15507', 'OTANCHE', '15'),
('15511', 'PACHAVITA', '15'),
('15514', 'PAEZ', '15'),
('15516', 'PAIPA', '15'),
('15518', 'PAJARITO', '15'),
('15522', 'PANQUEBA', '15'),
('15531', 'PAUNA', '15'),
('15533', 'PAYA', '15'),
('15537', 'PAZ DE RIO', '15'),
('15542', 'PESCA', '15'),
('15550', 'PISBA', '15'),
('15572', 'PUERTO BOYACA', '15'),
('15580', 'QUIPAMA', '15'),
('15599', 'RAMIRIQUI', '15'),
('15600', 'RAQUIRA', '15'),
('15621', 'RONDON', '15'),
('15632', 'SABOYA', '15'),
('15638', 'SACHICA', '15'),
('15646', 'SAMACA', '15'),
('15660', 'SAN EDUARDO', '15'),
('15664', 'SAN JOSE DE PARE', '15'),
('15667', 'SAN LUIS DE GACENO', '15'),
('15673', 'SAN MATEO', '15'),
('15676', 'SAN MIGUEL DE SEMA', '15'),
('15681', 'SAN PABLO DE BORBUR', '15'),
('15686', 'SANTANA', '15'),
('15690', 'SANTA MARIA', '15'),
('15693', 'SANTA ROSA DE VITERBO', '15'),
('15696', 'SANTA SOFIA', '15'),
('15720', 'SATIVANORTE', '15'),
('15723', 'SATIVASUR', '15'),
('15740', 'SIACHOQUE', '15'),
('15753', 'SOATA', '15'),
('15755', 'SOCOTA', '15'),
('15757', 'SOCHA', '15'),
('15759', 'SOGAMOSO', '15'),
('15761', 'SOMONDOCO', '15'),
('15762', 'SORA', '15'),
('15763', 'SOTAQUIRA', '15'),
('15764', 'SORACA', '15'),
('15774', 'SUSACON', '15'),
('15776', 'SUTAMARCHAN', '15'),
('15778', 'SUTATENZA', '15'),
('15790', 'TASCO', '15'),
('15798', 'TENZA', '15'),
('15804', 'TIBANA', '15'),
('15806', 'TIBASOSA', '15'),
('15808', 'TINJACA', '15'),
('15810', 'TIPACOQUE', '15'),
('15814', 'TOCA', '15'),
('15816', 'TOGUI', '15'),
('15820', 'TOPAGA', '15'),
('15822', 'TOTA', '15'),
('15832', 'TUNUNGUA', '15'),
('15835', 'TURMEQUE', '15'),
('15837', 'TUTA', '15'),
('15839', 'TUTAZA', '15'),
('15842', 'UMBITA', '15'),
('15861', 'VENTAQUEMADA', '15'),
('15879', 'VIRACACHA', '15'),
('15897', 'ZETAQUIRA', '15'),
('17001', 'MANIZALES', '17'),
('17013', 'AGUADAS', '17'),
('17042', 'ANSERMA', '17'),
('17050', 'ARANZAZU', '17'),
('17088', 'BELALCAZAR', '17'),
('17174', 'CHINCHINA', '17'),
('17272', 'FILADELFIA', '17'),
('17380', 'LA DORADA', '17'),
('17388', 'LA MERCED', '17'),
('17433', 'MANZANARES', '17'),
('17442', 'MARMATO', '17'),
('17444', 'MARQUETALIA', '17'),
('17446', 'MARULANDA', '17'),
('17486', 'NEIRA', '17'),
('17495', 'NORCASIA', '17'),
('17513', 'PACORA', '17'),
('17524', 'PALESTINA', '17'),
('17541', 'PENSILVANIA', '17'),
('17614', 'RIOSUCIO', '17'),
('17616', 'RISARALDA', '17'),
('17653', 'SALAMINA', '17'),
('17662', 'SAMANA', '17'),
('17665', 'SAN JOSE', '17'),
('17777', 'SUPIA', '17'),
('17867', 'VICTORIA', '17'),
('17873', 'VILLAMARIA', '17'),
('17877', 'VITERBO', '17'),
('18001', 'FLORENCIA', '18'),
('18029', 'ALBANIA', '18'),
('18094', 'BELEN DE LOS ANDAQUIES', '18'),
('18150', 'CARTAGENA DEL CHAIRA', '18'),
('18205', 'CURILLO', '18'),
('18247', 'EL DONCELLO', '18'),
('18256', 'EL PAUJIL', '18'),
('18410', 'LA MONTANITA', '18'),
('18460', 'MILAN', '18'),
('18479', 'MORELIA', '18'),
('18592', 'PUERTO RICO', '18'),
('18610', 'SAN JOSE DE LA FRAGUA', '18'),
('18753', 'SAN VICENTE DEL CAGUAN', '18'),
('18756', 'SOLANO', '18'),
('18785', 'SOLITA', '18'),
('18860', 'VALPARAISO', '18'),
('19001', 'POPAYAN', '19'),
('19022', 'ALMAGUER', '19'),
('19050', 'ARGELIA', '19'),
('19075', 'BALBOA', '19'),
('19100', 'BOLIVAR', '19'),
('19110', 'BUENOS AIRES', '19'),
('19130', 'CAJIBIO', '19'),
('19137', 'CALDONO', '19'),
('19142', 'CALOTO', '19'),
('19212', 'CORINTO', '19'),
('19256', 'EL TAMBO', '19'),
('19290', 'FLORENCIA', '19'),
('19300', 'GUACHENE', '19'),
('19318', 'GUAPI', '19'),
('19355', 'INZA', '19'),
('19364', 'JAMBALO', '19'),
('19392', 'LA SIERRA', '19'),
('19397', 'LA VEGA', '19'),
('19418', 'LOPEZ', '19'),
('19450', 'MERCADERES', '19'),
('19455', 'MIRANDA', '19'),
('19473', 'MORALES', '19'),
('19513', 'PADILLA', '19'),
('19517', 'PAEZ', '19'),
('19532', 'PATIA', '19'),
('19533', 'PIAMONTE', '19'),
('19548', 'PIENDAMO', '19'),
('19573', 'PUERTO TEJADA', '19'),
('19585', 'PURACE', '19'),
('19622', 'ROSAS', '19'),
('19693', 'SAN SEBASTIAN', '19'),
('19698', 'SANTANDER DE QUILICHAO', '19'),
('19701', 'SANTA ROSA', '19'),
('19743', 'SILVIA', '19'),
('19760', 'SOTARA', '19'),
('19780', 'SUAREZ', '19'),
('19785', 'SUCRE', '19'),
('19807', 'TIMBIO', '19'),
('19809', 'TIMBIQUI', '19'),
('19821', 'TORIBIO', '19'),
('19824', 'TOTORO', '19'),
('19845', 'VILLA RICA', '19'),
('20001', 'VALLEDUPAR', '20'),
('20011', 'AGUACHICA', '20'),
('20013', 'AGUSTIN CODAZZI', '20'),
('20032', 'ASTREA', '20'),
('20045', 'BECERRIL', '20'),
('20060', 'BOSCONIA', '20'),
('20175', 'CHIMICHAGUA', '20'),
('20178', 'CHIRIGUANA', '20'),
('20228', 'CURUMANI', '20'),
('20238', 'EL COPEY', '20'),
('20250', 'EL PASO', '20'),
('20295', 'GAMARRA', '20'),
('20310', 'GONZALEZ', '20'),
('20383', 'LA GLORIA', '20'),
('20400', 'LA JAGUA DE IBIRICO', '20'),
('20443', 'MANAURE', '20'),
('20517', 'PAILITAS', '20'),
('20550', 'PELAYA', '20'),
('20570', 'PUEBLO BELLO', '20'),
('20614', 'RIO DE ORO', '20'),
('20621', 'LA PAZ', '20'),
('20710', 'SAN ALBERTO', '20'),
('20750', 'SAN DIEGO', '20'),
('20770', 'SAN MARTIN', '20'),
('20787', 'TAMALAMEQUE', '20'),
('23001', 'MONTERIA', '23'),
('23068', 'AYAPEL', '23'),
('23079', 'BUENAVISTA', '23'),
('23090', 'CANALETE', '23'),
('23162', 'CERETE', '23'),
('23168', 'CHIMA', '23'),
('23182', 'CHINU', '23'),
('23189', 'CIENAGA DE ORO', '23'),
('23300', 'COTORRA', '23'),
('23350', 'LA APARTADA', '23'),
('23417', 'LORICA', '23'),
('23419', 'LOS CORDOBAS', '23'),
('23464', 'MOMIL', '23'),
('23466', 'MONTELIBANO', '23'),
('23500', 'MONITOS', '23'),
('23555', 'PLANETA RICA', '23'),
('23570', 'PUEBLO NUEVO', '23'),
('23574', 'PUERTO ESCONDIDO', '23'),
('23580', 'PUERTO LIBERTADOR', '23'),
('23586', 'PURISIMA', '23'),
('23660', 'SAHAGUN', '23'),
('23670', 'SAN ANDRES DE SOTAVENTO', '23'),
('23672', 'SAN ANTERO', '23'),
('23675', 'SAN BERNARDO DEL VIENTO', '23'),
('23678', 'SAN CARLOS', '23'),
('23686', 'SAN PELAYO', '23'),
('23807', 'TIERRALTA', '23'),
('23855', 'VALENCIA', '23'),
('25001', 'AGUA DE DIOS', '25'),
('25019', 'ALBAN', '25'),
('25035', 'ANAPOIMA', '25'),
('25040', 'ANOLAIMA', '25'),
('25053', 'ARBELAEZ', '25'),
('25086', 'BELTRAN', '25'),
('25095', 'BITUIMA', '25'),
('25099', 'BOJACA', '25'),
('25120', 'CABRERA', '25'),
('25123', 'CACHIPAY', '25'),
('25126', 'CAJICA', '25'),
('25148', 'CAPARRAPI', '25'),
('25151', 'CAQUEZA', '25'),
('25154', 'CARMEN DE CARUPA', '25'),
('25168', 'CHAGUANI', '25'),
('25175', 'CHIA', '25'),
('25178', 'CHIPAQUE', '25'),
('25181', 'CHOACHI', '25'),
('25183', 'CHOCONTA', '25'),
('25200', 'COGUA', '25'),
('25214', 'COTA', '25'),
('25224', 'CUCUNUBA', '25'),
('25245', 'EL COLEGIO', '25'),
('25258', 'EL PENON', '25'),
('25260', 'EL ROSAL', '25'),
('25269', 'FACATATIVA', '25'),
('25279', 'FOMEQUE', '25'),
('25281', 'FOSCA', '25'),
('25286', 'FUNZA', '25'),
('25288', 'FUQUENE', '25'),
('25290', 'FUSAGASUGA', '25'),
('25293', 'GACHALA', '25'),
('25295', 'GACHANCIPA', '25'),
('25297', 'GACHETA', '25'),
('25299', 'GAMA', '25'),
('25307', 'GIRARDOT', '25'),
('25312', 'GRANADA', '25'),
('25317', 'GUACHETA', '25'),
('25320', 'GUADUAS', '25'),
('25322', 'GUASCA', '25'),
('25324', 'GUATAQUI', '25'),
('25326', 'GUATAVITA', '25'),
('25328', 'GUAYABAL DE SIQUIMA', '25'),
('25335', 'GUAYABETAL', '25'),
('25339', 'GUTIERREZ', '25'),
('25368', 'JERUSALEN', '25'),
('25372', 'JUNIN', '25'),
('25377', 'LA CALERA', '25'),
('25386', 'LA MESA', '25'),
('25394', 'LA PALMA', '25'),
('25398', 'LA PENA', '25'),
('25402', 'LA VEGA', '25'),
('25407', 'LENGUAZAQUE', '25'),
('25426', 'MACHETA', '25'),
('25430', 'MADRID', '25'),
('25436', 'MANTA', '25'),
('25438', 'MEDINA', '25'),
('25473', 'MOSQUERA', '25'),
('25483', 'NARINO', '25'),
('25486', 'NEMOCON', '25'),
('25488', 'NILO', '25'),
('25489', 'NIMAIMA', '25'),
('25491', 'NOCAIMA', '25'),
('25506', 'VENECIA', '25'),
('25513', 'PACHO', '25'),
('25518', 'PAIME', '25'),
('25524', 'PANDI', '25'),
('25530', 'PARATEBUENO', '25'),
('25535', 'PASCA', '25'),
('25572', 'PUERTO SALGAR', '25'),
('25580', 'PULI', '25'),
('25592', 'QUEBRADANEGRA', '25'),
('25594', 'QUETAME', '25'),
('25596', 'QUIPILE', '25'),
('25599', 'APULO', '25'),
('25612', 'RICAURTE', '25'),
('25645', 'SAN ANTONIO DEL TEQUENDAM', '25'),
('25649', 'SAN BERNARDO', '25'),
('25653', 'SAN CAYETANO', '25'),
('25658', 'SAN FRANCISCO', '25'),
('25662', 'SAN JUAN DE RIO SECO', '25'),
('25718', 'SASAIMA', '25'),
('25736', 'SESQUILE', '25'),
('25740', 'SIBATE', '25'),
('25743', 'SILVANIA', '25'),
('25745', 'SIMIJACA', '25'),
('25754', 'SOACHA', '25'),
('25758', 'SOPO', '25'),
('25769', 'SUBACHOQUE', '25'),
('25772', 'SUESCA', '25'),
('25777', 'SUPATA', '25'),
('25779', 'SUSA', '25'),
('25781', 'SUTATAUSA', '25'),
('25785', 'TABIO', '25'),
('25793', 'TAUSA', '25'),
('25797', 'TENA', '25'),
('25799', 'TENJO', '25'),
('25805', 'TIBACUY', '25'),
('25807', 'TIBIRITA', '25'),
('25815', 'TOCAIMA', '25'),
('25817', 'TOCANCIPA', '25'),
('25823', 'TOPAIPI', '25'),
('25839', 'UBALA', '25'),
('25841', 'UBAQUE', '25'),
('25843', 'VILLA DE SAN DIEGO DE UBA', '25'),
('25845', 'UNE', '25'),
('25851', 'UTICA', '25'),
('25862', 'VERGARA', '25'),
('25867', 'VIANI', '25'),
('25871', 'VILLAGOMEZ', '25'),
('25873', 'VILLAPINZON', '25'),
('25875', 'VILLETA', '25'),
('25878', 'VIOTA', '25'),
('25885', 'YACOPI', '25'),
('25898', 'ZIPACON', '25'),
('25899', 'ZIPAQUIRA', '25'),
('27001', 'QUIBDO', '27'),
('27006', 'ACANDI', '27'),
('27025', 'ALTO BAUDO', '27'),
('27050', 'ATRATO', '27'),
('27073', 'BAGADO', '27'),
('27075', 'BAHIA SOLANO', '27'),
('27077', 'BAJO BAUDO', '27'),
('27086', 'BELEN DE BAJIRA', '27'),
('27099', 'BOJAYA', '27'),
('27135', 'EL CANTON DEL SAN PABLO', '27'),
('27150', 'CARMEN DEL DARIEN', '27'),
('27160', 'CERTEGUI', '27'),
('27205', 'CONDOTO', '27'),
('27245', 'EL CARMEN DE ATRATO', '27'),
('27250', 'EL LITORAL DEL SAN JUAN', '27'),
('27361', 'ISTMINA', '27'),
('27372', 'JURADO', '27'),
('27413', 'LLORO', '27'),
('27425', 'MEDIO ATRATO', '27'),
('27430', 'MEDIO BAUDO', '27'),
('27450', 'MEDIO SAN JUAN', '27'),
('27491', 'NOVITA', '27'),
('27495', 'NUQUI', '27'),
('27580', 'RIO IRO', '27'),
('27600', 'RIO QUITO', '27'),
('27615', 'RIOSUCIO', '27'),
('27660', 'SAN JOSE DEL PALMAR', '27'),
('27745', 'SIPI', '27'),
('27787', 'TADO', '27'),
('27800', 'UNGUIA', '27'),
('27810', 'UNION PANAMERICANA', '27'),
('41001', 'NEIVA', '41'),
('41006', 'ACEVEDO', '41'),
('41013', 'AGRADO', '41'),
('41016', 'AIPE', '41'),
('41020', 'ALGECIRAS', '41'),
('41026', 'ALTAMIRA', '41'),
('41078', 'BARAYA', '41'),
('41132', 'CAMPOALEGRE', '41'),
('41206', 'COLOMBIA', '41'),
('41244', 'ELIAS', '41'),
('41298', 'GARZON', '41'),
('41306', 'GIGANTE', '41'),
('41319', 'GUADALUPE', '41'),
('41349', 'HOBO', '41'),
('41357', 'IQUIRA', '41'),
('41359', 'ISNOS', '41'),
('41378', 'LA ARGENTINA', '41'),
('41396', 'LA PLATA', '41'),
('41483', 'NATAGA', '41'),
('41503', 'OPORAPA', '41'),
('41518', 'PAICOL', '41'),
('41524', 'PALERMO', '41'),
('41530', 'PALESTINA', '41'),
('41548', 'PITAL', '41'),
('41551', 'PITALITO', '41'),
('41615', 'RIVERA', '41'),
('41660', 'SALADOBLANCO', '41'),
('41668', 'SAN AGUSTIN', '41'),
('41676', 'SANTA MARIA', '41'),
('41770', 'SUAZA', '41'),
('41791', 'TARQUI', '41'),
('41797', 'TESALIA', '41'),
('41799', 'TELLO', '41'),
('41801', 'TERUEL', '41'),
('41807', 'TIMANA', '41'),
('41872', 'VILLAVIEJA', '41'),
('41885', 'YAGUARA', '41'),
('44001', 'RIOHACHA', '44'),
('44035', 'ALBANIA', '44'),
('44078', 'BARRANCAS', '44'),
('44090', 'DIBULLA', '44'),
('44098', 'DISTRACCION', '44'),
('44110', 'EL MOLINO', '44'),
('44279', 'FONSECA', '44'),
('44378', 'HATONUEVO', '44'),
('44420', 'LA JAGUA DEL PILAR', '44'),
('44430', 'MAICAO', '44'),
('44560', 'MANAURE', '44'),
('44650', 'SAN JUAN DEL CESAR', '44'),
('44847', 'URIBIA', '44'),
('44855', 'URUMITA', '44'),
('44874', 'VILLANUEVA', '44'),
('47001', 'SANTA MARTA', '47'),
('47030', 'ALGARROBO', '47'),
('47053', 'ARACATACA', '47'),
('47058', 'ARIGUANI', '47'),
('47161', 'CERRO SAN ANTONIO', '47'),
('47170', 'CHIVOLO', '47'),
('47189', 'CIENAGA', '47'),
('47205', 'CONCORDIA', '47'),
('47245', 'EL BANCO', '47'),
('47258', 'EL PINON', '47'),
('47268', 'EL RETEN', '47'),
('47288', 'FUNDACION', '47'),
('47318', 'GUAMAL', '47'),
('47460', 'NUEVA GRANADA', '47'),
('47541', 'PEDRAZA', '47'),
('47545', 'PIJINO DEL CARMEN', '47'),
('47551', 'PIVIJAY', '47'),
('47555', 'PLATO', '47'),
('47570', 'PUEBLOVIEJO', '47'),
('47605', 'REMOLINO', '47'),
('47660', 'SABANAS DE SAN ANGEL', '47'),
('47675', 'SALAMINA', '47'),
('47692', 'SAN', '47'),
('47703', 'SAN ZENON', '47'),
('47707', 'SANTA ANA', '47'),
('47720', 'SANTA BARBARA DE PINTO', '47'),
('47745', 'SITIONUEVO', '47'),
('47798', 'TENERIFE', '47'),
('47960', 'ZAPAYAN', '47'),
('47980', 'ZONA BANANERA', '47'),
('50001', 'VILLAVICENCIO', '50'),
('50006', 'ACACIAS', '50'),
('5001', 'MEDELLIN', '5'),
('5002', 'ABEJORRAL', '5'),
('5004', 'ABRIAQUI', '5'),
('50110', 'BARRANCA DE UPIA', '50'),
('50124', 'CABUYARO', '50'),
('50150', 'CASTILLA LA NUEVA', '50'),
('5021', 'ALEJANDRIA', '5'),
('50223', 'CUBARRAL', '50'),
('50226', 'CUMARAL', '50'),
('50245', 'EL CALVARIO', '50'),
('50251', 'EL CASTILLO', '50'),
('50270', 'EL DORADO', '50'),
('50287', 'FUENTE DE ORO', '50'),
('5030', 'AMAGA', '5'),
('5031', 'AMALFI', '5'),
('50313', 'GRANADA', '50'),
('50318', 'GUAMAL', '50'),
('50325', 'MAPIRIPAN', '50'),
('50330', 'MESETAS', '50'),
('5034', 'ANDES', '5'),
('50350', 'LA MACARENA', '50'),
('5036', 'ANGELOPOLIS', '5'),
('50370', 'URIBE', '50'),
('5038', 'ANGOSTURA', '5'),
('5040', 'ANORI', '5'),
('50400', 'LEJANIAS', '50'),
('5042', 'SANTAFE DE ANTIOQUIA', '5'),
('5044', 'ANZA', '5'),
('5045', 'APARTADO', '5'),
('50450', 'PUERTO CONCORDIA', '50'),
('5051', 'ARBOLETES', '5'),
('5055', 'ARGELIA', '5'),
('50568', 'PUERTO GAITAN', '50'),
('50573', 'PUERTO LOPEZ', '50'),
('50577', 'PUERTO LLERAS', '50'),
('5059', 'ARMENIA', '5'),
('50590', 'PUERTO RICO', '50'),
('50606', 'RESTREPO', '50'),
('50680', 'SAN CARLOS DE GUAROA', '50'),
('50683', 'SAN JUAN DE ARAMA', '50'),
('50686', 'SAN JUANITO', '50'),
('50689', 'SAN MARTIN', '50'),
('50711', 'VISTA HERMOSA', '50'),
('5079', 'BARBOSA', '5'),
('5086', 'BELMIRA', '5'),
('5088', 'BELLO', '5'),
('5091', 'BETANIA', '5'),
('5093', 'BETULIA', '5'),
('5101', 'CIUDAD BOLIVAR', '5'),
('5107', 'BRICENO', '5'),
('5113', 'BURITICA', '5'),
('5120', 'CACERES', '5'),
('5125', 'CAICEDO', '5'),
('5129', 'CALDAS', '5'),
('5134', 'CAMPAMENTO', '5'),
('5138', 'CA?ASGORDAS', '5'),
('5142', 'CARACOLI', '5'),
('5145', 'CARAMANTA', '5'),
('5147', 'CAREPA', '5'),
('5148', 'EL CARMEN DE VIBORAL', '5'),
('5150', 'CAROLINA', '5'),
('5154', 'CAUCASIA', '5'),
('5172', 'CHIGORODO', '5'),
('5190', 'CISNEROS', '5'),
('5197', 'COCORNA', '5'),
('52001', 'PASTO', '52'),
('52019', 'ALBAN', '52'),
('52022', 'ALDANA', '52'),
('52036', 'ANCUYA', '52'),
('52051', 'ARBOLEDA', '52'),
('5206', 'CONCEPCION', '5'),
('52079', 'BARBACOAS', '52'),
('52083', 'BELEN', '52'),
('5209', 'CONCORDIA', '5'),
('52110', 'BUESACO', '52'),
('5212', 'COPACABANA', '5'),
('52203', 'COLON', '52'),
('52207', 'CONSACA', '52'),
('52210', 'CONTADERO', '52'),
('52215', 'CORDOBA', '52'),
('52224', 'CUASPUD', '52'),
('52227', 'CUMBAL', '52'),
('52233', 'CUMBITARA', '52'),
('52240', 'CHACHAGUI', '52'),
('52250', 'EL CHARCO', '52'),
('52254', 'EL PENOL', '52'),
('52256', 'EL ROSARIO', '52'),
('52258', 'EL TABLON DE GOMEZ', '52'),
('52260', 'EL TAMBO', '52'),
('52287', 'FUNES', '52'),
('52317', 'GUACHUCAL', '52'),
('52320', 'GUAITARILLA', '52'),
('52323', 'GUALMATAN', '52'),
('5234', 'DABEIBA', '5'),
('52352', 'ILES', '52'),
('52354', 'IMUES', '52'),
('52356', 'IPIALES', '52'),
('5237', 'DON MATIAS', '5'),
('52378', 'LA CRUZ', '52'),
('52381', 'LA FLORIDA', '52'),
('52385', 'LA LLANADA', '52'),
('52390', 'LA TOLA', '52'),
('52399', 'LA UNION', '52'),
('5240', 'EBEJICO', '5'),
('52405', 'LEIVA', '52'),
('52411', 'LINARES', '52'),
('52418', 'LOS ANDES', '52'),
('52427', 'MAG?I', '52'),
('52435', 'MALLAMA', '52'),
('52473', 'MOSQUERA', '52'),
('52480', 'NARINO', '52'),
('52490', 'OLAYA HERRERA', '52'),
('5250', 'EL BAGRE', '5'),
('52506', 'OSPINA', '52'),
('52520', 'FRANCISCO PIZARRO', '52'),
('52540', 'POLICARPA', '52'),
('52560', 'POTOSI', '52'),
('52565', 'PROVIDENCIA', '52'),
('52573', 'PUERRES', '52'),
('52585', 'PUPIALES', '52'),
('52612', 'RICAURTE', '52'),
('52621', 'ROBERTO PAYAN', '52'),
('5264', 'ENTRERRIOS', '5'),
('5266', 'ENVIGADO', '5'),
('52678', 'SAMANIEGO', '52'),
('52683', 'SANDONA', '52'),
('52685', 'SAN BERNARDO', '52'),
('52687', 'SAN LORENZO', '52'),
('52693', 'SAN PABLO', '52'),
('52694', 'SAN PEDRO DE CARTAGO', '52'),
('52696', 'SANTA BARBARA', '52'),
('52699', 'SANTACRUZ', '52'),
('52720', 'SAPUYES', '52'),
('52786', 'TAMINANGO', '52'),
('52788', 'TANGUA', '52'),
('5282', 'FREDONIA', '5'),
('52835', 'TUMACO', '52'),
('52838', 'TUQUERRES', '52'),
('5284', 'FRONTINO', '5'),
('52885', 'YACUANQUER', '52'),
('5306', 'GIRALDO', '5'),
('5308', 'GIRARDOTA', '5'),
('5310', 'GOMEZ PLATA', '5'),
('5313', 'GRANADA', '5'),
('5315', 'GUADALUPE', '5'),
('5318', 'GUARNE', '5'),
('5321', 'GUATAPE', '5'),
('5347', 'HELICONIA', '5'),
('5353', 'HISPANIA', '5'),
('5360', 'ITAG?I', '5'),
('5361', 'ITUANGO', '5'),
('5364', 'JARDIN', '5'),
('5368', 'JERICO', '5'),
('5376', 'LA CEJA', '5'),
('5380', 'LA ESTRELLA', '5'),
('5390', 'LA PINTADA', '5'),
('5400', 'LA UNION', '5'),
('54001', 'CUCUTA', '54'),
('54003', 'ABREGO', '54'),
('54051', 'ARBOLEDAS', '54'),
('54099', 'BOCHALEMA', '54'),
('54109', 'BUCARASICA', '54'),
('5411', 'LIBORINA', '5'),
('54125', 'CACOTA', '54'),
('54128', 'CACHIRA', '54'),
('54172', 'CHINACOTA', '54'),
('54174', 'CHITAGA', '54'),
('54206', 'CONVENCION', '54'),
('54223', 'CUCUTILLA', '54'),
('54239', 'DURANIA', '54'),
('54245', 'EL CARMEN', '54'),
('5425', 'MACEO', '5'),
('54250', 'EL TARRA', '54'),
('54261', 'EL ZULIA', '54'),
('54313', 'GRAMALOTE', '54'),
('54344', 'HACARI', '54'),
('54347', 'HERRAN', '54'),
('54377', 'LABATECA', '54'),
('54385', 'LA ESPERANZA', '54'),
('54398', 'LA PLAYA', '54'),
('5440', 'MARINILLA', '5'),
('54405', 'LOS PATIOS', '54'),
('54418', 'LOURDES', '54'),
('54480', 'MUTISCUA', '54'),
('54498', 'OCANA', '54'),
('54518', 'PAMPLONA', '54'),
('54520', 'PAMPLONITA', '54'),
('54553', 'PUERTO SANTANDER', '54'),
('54599', 'RAGONVALIA', '54'),
('54660', 'SALAZAR', '54'),
('5467', 'MONTEBELLO', '5'),
('54670', 'SAN CALIXTO', '54'),
('54673', 'SAN CAYETANO', '54'),
('54680', 'SANTIAGO', '54'),
('54720', 'SARDINATA', '54'),
('54743', 'SILOS', '54'),
('5475', 'MURINDO', '5'),
('5480', 'MUTATA', '5'),
('54800', 'TEORAMA', '54'),
('54810', 'TIBU', '54'),
('54820', 'TOLEDO', '54'),
('5483', 'NARINO', '5'),
('54871', 'VILLA CARO', '54'),
('54874', 'VILLA DEL ROSARIO', '54'),
('5490', 'NECOCLI', '5'),
('5495', 'NECHI', '5'),
('5501', 'OLAYA', '5'),
('5541', 'PENOL', '5'),
('5543', 'PEQUE', '5'),
('5576', 'PUEBLORRICO', '5'),
('5579', 'PUERTO BERRIO', '5'),
('5585', 'PUERTO NARE', '5'),
('5591', 'PUERTO TRIUNFO', '5'),
('5604', 'REMEDIOS', '5'),
('5607', 'RETIRO', '5'),
('5615', 'RIONEGRO', '5'),
('5628', 'SABANALARGA', '5'),
('5631', 'SABANETA', '5'),
('5642', 'SALGAR', '5'),
('5647', 'SAN ANDRES', '5'),
('5649', 'SAN CARLOS', '5'),
('5652', 'SAN FRANCISCO', '5'),
('5656', 'SAN JERONIMO', '5'),
('5658', 'SAN JOSE DE LA MONTANA', '5'),
('5659', 'SAN JUAN DE URABA', '5'),
('5660', 'SAN LUIS', '5'),
('5664', 'SAN PEDRO', '5'),
('5665', 'SAN PEDRO DE URABA', '5'),
('5667', 'SAN RAFAEL', '5'),
('5670', 'SAN ROQUE', '5'),
('5674', 'SAN VICENTE', '5'),
('5679', 'SANTA BARBARA', '5'),
('5686', 'SANTA ROSA DE OSOS', '5'),
('5690', 'SANTO DOMINGO', '5'),
('5697', 'EL SANTUARIO', '5'),
('5736', 'SEGOVIA', '5'),
('5756', 'SONSON', '5'),
('5761', 'SOPETRAN', '5'),
('5789', 'TAMESIS', '5'),
('5790', 'TARAZA', '5'),
('5792', 'TARSO', '5'),
('5809', 'TITIRIBI', '5'),
('5819', 'TOLEDO', '5'),
('5837', 'TURBO', '5'),
('5842', 'URAMITA', '5'),
('5847', 'URRAO', '5'),
('5854', 'VALDIVIA', '5'),
('5856', 'VALPARAISO', '5'),
('5858', 'VEGACHI', '5'),
('5861', 'VENECIA', '5'),
('5873', 'VIGIA DEL FUERTE', '5'),
('5885', 'YALI', '5'),
('5887', 'YARUMAL', '5'),
('5890', 'YOLOMBO', '5'),
('5893', 'YONDO', '5'),
('5895', 'ZARAGOZA', '5'),
('63001', 'ARMENIA', '63'),
('63111', 'BUENAVISTA', '63'),
('63130', 'CALARCA', '63'),
('63190', 'CIRCASIA', '63'),
('63212', 'CORDOBA', '63'),
('63272', 'FILANDIA', '63'),
('63302', 'GENOVA', '63'),
('63401', 'LA TEBAIDA', '63'),
('63470', 'MONTENEGRO', '63'),
('63548', 'PIJAO', '63'),
('63594', 'QUIMBAYA', '63'),
('63690', 'SALENTO', '63'),
('66001', 'PEREIRA', '66'),
('66045', 'APIA', '66'),
('66075', 'BALBOA', '66'),
('66088', 'BELEN DE UMBRIA', '66'),
('66170', 'DOSQUEBRADAS', '66'),
('66318', 'GUATICA', '66'),
('66383', 'LA CELIA', '66'),
('66400', 'LA VIRGINIA', '66'),
('66440', 'MARSELLA', '66'),
('66456', 'MISTRATO', '66'),
('66572', 'PUEBLO RICO', '66'),
('66594', 'QUINCHIA', '66'),
('66682', 'SANTA ROSA DE CABAL', '66'),
('66687', 'SANTUARIO', '66'),
('68001', 'BUCARAMANGA', '68'),
('68013', 'AGUADA', '68'),
('68020', 'ALBANIA', '68'),
('68051', 'ARATOCA', '68'),
('68077', 'BARBOSA', '68'),
('68079', 'BARICHARA', '68'),
('68081', 'BARRANCABERMEJA', '68'),
('68092', 'BETULIA', '68'),
('68101', 'BOLIVAR', '68'),
('68121', 'CABRERA', '68'),
('68132', 'CALIFORNIA', '68'),
('68147', 'CAPITANEJO', '68'),
('68152', 'CARCASI', '68'),
('68160', 'CEPITA', '68'),
('68162', 'CERRITO', '68'),
('68167', 'CHARALA', '68'),
('68169', 'CHARTA', '68'),
('68176', 'CHIMA', '68'),
('68179', 'CHIPATA', '68'),
('68190', 'CIMITARRA', '68'),
('68207', 'CONCEPCION', '68'),
('68209', 'CONFINES', '68'),
('68211', 'CONTRATACION', '68'),
('68217', 'COROMORO', '68'),
('68229', 'CURITI', '68'),
('68235', 'EL CARMEN DE CHUCURI', '68'),
('68245', 'EL GUACAMAYO', '68'),
('68250', 'EL PENON', '68'),
('68255', 'EL PLAYON', '68'),
('68264', 'ENCINO', '68'),
('68266', 'ENCISO', '68'),
('68271', 'FLORIAN', '68'),
('68276', 'FLORIDABLANCA', '68'),
('68296', 'GALAN', '68'),
('68298', 'GAMBITA', '68'),
('68307', 'GIRON', '68'),
('68318', 'GUACA', '68'),
('68320', 'GUADALUPE', '68'),
('68322', 'GUAPOTA', '68'),
('68324', 'GUAVATA', '68'),
('68327', 'G?EPSA', '68'),
('68344', 'HATO', '68'),
('68368', 'JESUS MARIA', '68'),
('68370', 'JORDAN', '68'),
('68377', 'LA BELLEZA', '68'),
('68385', 'LANDAZURI', '68'),
('68397', 'LA PAZ', '68'),
('68406', 'LEBRIJA', '68'),
('68418', 'LOS SANTOS', '68'),
('68425', 'MACARAVITA', '68'),
('68432', 'MALAGA', '68'),
('68444', 'MATANZA', '68'),
('68464', 'MOGOTES', '68'),
('68468', 'MOLAGAVITA', '68'),
('68498', 'OCAMONTE', '68'),
('68500', 'OIBA', '68'),
('68502', 'ONZAGA', '68'),
('68522', 'PALMAR', '68'),
('68524', 'PALMAS DEL SOCORRO', '68'),
('68533', 'PARAMO', '68'),
('68547', 'PIEDECUESTA', '68'),
('68549', 'PINCHOTE', '68'),
('68572', 'PUENTE NACIONAL', '68'),
('68573', 'PUERTO PARRA', '68'),
('68575', 'PUERTO WILCHES', '68'),
('68615', 'RIONEGRO', '68'),
('68655', 'SABANA DE TORRES', '68'),
('68669', 'SAN ANDRES', '68'),
('68673', 'SAN BENITO', '68'),
('68679', 'SAN GIL', '68'),
('68682', 'SAN JOAQUIN', '68'),
('68684', 'SAN JOSE DE MIRANDA', '68'),
('68686', 'SAN MIGUEL', '68'),
('68689', 'SAN VICENTE DE CHUCURI', '68'),
('68705', 'SANTA BARBARA', '68'),
('68720', 'SANTA HELENA DEL OPON', '68'),
('68745', 'SIMACOTA', '68'),
('68755', 'SOCORRO', '68'),
('68770', 'SUAITA', '68'),
('68773', 'SUCRE', '68'),
('68780', 'SURATA', '68'),
('68820', 'TONA', '68'),
('68855', 'VALLE DE SAN JOSE', '68'),
('68861', 'VELEZ', '68'),
('68867', 'VETAS', '68'),
('68872', 'VILLANUEVA', '68'),
('68895', 'ZAPATOCA', '68'),
('70001', 'SINCELEJO', '70'),
('70110', 'BUENAVISTA', '70'),
('70124', 'CAIMITO', '70'),
('70204', 'COLOSO', '70'),
('70215', 'COROZAL', '70'),
('70221', 'COVE?AS', '70'),
('70230', 'CHALAN', '70'),
('70233', 'EL ROBLE', '70'),
('70235', 'GALERAS', '70'),
('70265', 'GUARANDA', '70'),
('70400', 'LA UNION', '70'),
('70418', 'LOS PALMITOS', '70'),
('70429', 'MAJAGUAL', '70'),
('70473', 'MORROA', '70'),
('70508', 'OVEJAS', '70'),
('70523', 'PALMITO', '70'),
('70670', 'SAMPUES', '70'),
('70678', 'SAN BENITO ABAD', '70'),
('70702', 'SAN JUAN DE BETULIA', '70'),
('70708', 'SAN MARCOS', '70'),
('70713', 'SAN ONOFRE', '70'),
('70717', 'SAN PEDRO', '70'),
('70742', 'SINCE', '70'),
('70771', 'SUCRE', '70'),
('70820', 'SANTIAGO DE TOLU', '70'),
('70823', 'TOLUVIEJO', '70'),
('73001', 'IBAGUE', '73'),
('73024', 'ALPUJARRA', '73'),
('73026', 'ALVARADO', '73'),
('73030', 'AMBALEMA', '73'),
('73043', 'ANZOATEGUI', '73'),
('73055', 'ARMERO', '73'),
('73067', 'ATACO', '73'),
('73124', 'CAJAMARCA', '73'),
('73148', 'CARMEN DE APICALA', '73'),
('73152', 'CASABIANCA', '73'),
('73168', 'CHAPARRAL', '73'),
('73200', 'COELLO', '73'),
('73217', 'COYAIMA', '73'),
('73226', 'CUNDAY', '73'),
('73236', 'DOLORES', '73'),
('73268', 'ESPINAL', '73'),
('73270', 'FALAN', '73'),
('73275', 'FLANDES', '73'),
('73283', 'FRESNO', '73'),
('73319', 'GUAMO', '73'),
('73347', 'HERVEO', '73'),
('73349', 'HONDA', '73'),
('73352', 'ICONONZO', '73'),
('73408', 'LERIDA', '73'),
('73411', 'LIBANO', '73'),
('73443', 'MARIQUITA', '73'),
('73449', 'MELGAR', '73'),
('73461', 'MURILLO', '73'),
('73483', 'NATAGAIMA', '73'),
('73504', 'ORTEGA', '73'),
('73520', 'PALOCABILDO', '73'),
('73547', 'PIEDRAS', '73'),
('73555', 'PLANADAS', '73'),
('73563', 'PRADO', '73'),
('73585', 'PURIFICACION', '73'),
('73616', 'RIOBLANCO', '73'),
('73622', 'RONCESVALLES', '73'),
('73624', 'ROVIRA', '73'),
('73671', 'SALDANA', '73'),
('73675', 'SAN ANTONIO', '73'),
('73678', 'SAN LUIS', '73'),
('73686', 'SANTA ISABEL', '73'),
('73770', 'SUAREZ', '73'),
('73854', 'VALLE DE SAN JUAN', '73'),
('73861', 'VENADILLO', '73'),
('73870', 'VILLAHERMOSA', '73'),
('73873', 'VILLARRICA', '73'),
('76001', 'CALI', '76'),
('76020', 'ALCALA', '76'),
('76036', 'ANDALUCIA', '76'),
('76041', 'ANSERMANUEVO', '76'),
('76054', 'ARGELIA', '76'),
('76100', 'BOLIVAR', '76'),
('76109', 'BUENAVENTURA', '76'),
('76111', 'GUADALAJARA DE BUGA', '76'),
('76113', 'BUGALAGRANDE', '76'),
('76122', 'CAICEDONIA', '76'),
('76126', 'CALIMA', '76'),
('76130', 'CANDELARIA', '76'),
('76147', 'CARTAGO', '76'),
('76233', 'DAGUA', '76'),
('76243', 'EL AGUILA', '76'),
('76246', 'EL CAIRO', '76'),
('76248', 'EL CERRITO', '76'),
('76250', 'EL DOVIO', '76'),
('76275', 'FLORIDA', '76'),
('76306', 'GINEBRA', '76'),
('76318', 'GUACARI', '76'),
('76364', 'JAMUNDI', '76'),
('76377', 'LA CUMBRE', '76'),
('76400', 'LA UNION', '76'),
('76403', 'LA VICTORIA', '76'),
('76497', 'OBANDO', '76'),
('76520', 'PALMIRA', '76'),
('76563', 'PRADERA', '76'),
('76606', 'RESTREPO', '76'),
('76616', 'RIOFRIO', '76'),
('76622', 'ROLDANILLO', '76'),
('76670', 'SAN PEDRO', '76'),
('76736', 'SEVILLA', '76'),
('76823', 'TORO', '76'),
('76828', 'TRUJILLO', '76'),
('76834', 'TULUA', '76'),
('76845', 'ULLOA', '76'),
('76863', 'VERSALLES', '76'),
('76869', 'VIJES', '76'),
('76890', 'YOTOCO', '76'),
('76892', 'YUMBO', '76'),
('76895', 'ZARZAL', '76'),
('8001', 'BARRANQUILLA', '8'),
('8078', 'BARANOA', '8'),
('81001', 'ARAUCA', '81'),
('81065', 'ARAUQUITA', '81'),
('81220', 'CRAVO NORTE', '81'),
('81300', 'FORTUL', '81'),
('8137', 'CAMPO DE LA CRUZ', '8'),
('8141', 'CANDELARIA', '8'),
('81591', 'PUERTO RONDON', '81'),
('81736', 'SARAVENA', '81'),
('81794', 'TAME', '81'),
('8296', 'GALAPA', '8'),
('8372', 'JUAN DE ACOSTA', '8'),
('8421', 'LURUACO', '8'),
('8433', 'MALAMBO', '8'),
('8436', 'MANATI', '8'),
('85001', 'YOPAL', '85'),
('85010', 'AGUAZUL', '85'),
('85015', 'CHAMEZA', '85'),
('85125', 'HATO COROZAL', '85'),
('85136', 'LA SALINA', '85'),
('85139', 'MANI', '85'),
('85162', 'MONTERREY', '85'),
('8520', 'PALMAR DE VARELA', '8'),
('85225', 'NUNCHIA', '85'),
('85230', 'OROCUE', '85'),
('85250', 'PAZ DE ARIPORO', '85'),
('85263', 'PORE', '85'),
('85279', 'RECETOR', '85'),
('85300', 'SABANALARGA', '85'),
('85315', 'SACAMA', '85'),
('85325', 'SAN LUIS DE PALENQUE', '85'),
('85400', 'TAMARA', '85'),
('85410', 'TAURAMENA', '85'),
('85430', 'TRINIDAD', '85'),
('85440', 'VILLANUEVA', '85'),
('8549', 'PIOJO', '8'),
('8558', 'POLONUEVO', '8'),
('8560', 'PONEDERA', '8'),
('8573', 'PUERTO COLOMBIA', '8'),
('86001', 'MOCOA', '86'),
('8606', 'REPELON', '8'),
('86219', 'COLON', '86'),
('86320', 'ORITO', '86'),
('8634', 'SABANAGRANDE', '8'),
('8638', 'SABANALARGA', '8'),
('86568', 'PUERTO ASIS', '86'),
('86569', 'PUERTO CAICEDO', '86'),
('86571', 'PUERTO GUZMAN', '86'),
('86573', 'LEGUIZAMO', '86'),
('86749', 'SIBUNDOY', '86'),
('8675', 'SANTA LUCIA', '8'),
('86755', 'SAN FRANCISCO', '86'),
('86757', 'SAN MIGUEL', '86'),
('86760', 'SANTIAGO', '86'),
('8685', 'SANTO TOMAS', '8'),
('86865', 'VALLE DEL GUAMUEZ', '86'),
('86885', 'VILLAGARZON', '86'),
('8758', 'SOLEDAD', '8'),
('8770', 'SUAN', '8'),
('88001', 'SAN ANDRES', '88'),
('8832', 'TUBARA', '8'),
('8849', 'USIACURI', '8'),
('88564', 'PROVIDENCIA', '88'),
('91001', 'LETICIA', '91'),
('91263', 'EL ENCANTO', '91'),
('91405', 'LA CHORRERA', '91'),
('91407', 'LA PEDRERA', '91'),
('91430', 'LA VICTORIA', '91'),
('91460', 'MIRITI - PARANA', '91'),
('91530', 'PUERTO ALEGRIA', '91'),
('91536', 'PUERTO ARICA', '91'),
('91540', 'PUERTO NARINO', '91'),
('91669', 'PUERTO SANTANDER', '91'),
('91798', 'TARAPACA', '91'),
('94001', 'INIRIDA', '94'),
('94343', 'BARRANCO MINAS', '94'),
('94663', 'MAPIRIPANA', '94'),
('94883', 'SAN FELIPE', '94'),
('94884', 'PUERTO COLOMBIA', '94'),
('94885', 'LA GUADALUPE', '94'),
('94886', 'CACAHUAL', '94'),
('94887', 'PANA PANA', '94'),
('94888', 'MORICHAL', '94'),
('95001', 'SAN JOSE DEL GUAVIARE', '95'),
('95015', 'CALAMAR', '95'),
('95025', 'EL RETORNO', '95'),
('95200', 'MIRAFLORES', '95'),
('97001', 'MITU', '97'),
('97161', 'CARURU', '97'),
('97511', 'PACOA', '97'),
('97666', 'TARAIRA', '97'),
('97777', 'PAPUNAUA', '97'),
('97889', 'YAVARATE', '97'),
('99001', 'PUERTO CARRE?O', '99'),
('99524', 'LA PRIMAVERA', '99'),
('99624', 'SANTA ROSALIA', '99'),
('99773', 'CUMARIBO', '99');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `competencias`
--

CREATE TABLE `competencias` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(30) NOT NULL,
  `Descripción` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `competencias`
--

INSERT INTO `competencias` (`Id`, `Nombre`, `Descripción`) VALUES
(1, 'Competencias Ciudadanas', 'Esta prueba evalúa la capacidad de los estudiantes para participar, en su calidad de\r\nciudadanos, de manera constructiva y activa en la sociedad.'),
(2, 'Razonamiento Cuantitativo', 'Este módulo evalúa competencias relacionadas con las habilidades matemáticas que todo\r\nciudadano debe tener, independientemente de su profesión u oficio, para desempeñarse\r\nadecuadamente en contextos cotidianos que involucran información de carácter cuantitativo.\r\nEstas habilidades implican la comprensión, diseño y correcta aplicación de métodos,\r\nprocedimientos y argumentos fundamentados en contenidos matemáticos denominados\r\n“genéricos”, por ser contenidos que al utilizarse de manera correcta permiten a los profesionales\r\nplantear posiciones críticas, tomar decisiones y generar estrategias cuando se ven enfrentados\r\na información que puede ser o ha sido tratada de manera cuantitativa.'),
(3, 'Lectura Critíca', 'Este módulo evalúa la competencia relacionada con la capacidad que tiene el lector\r\npara dar cuenta de las relaciones entre los discursos y las prácticas socioculturales que\r\nlas involucran y condicionan, lo cual significa que el lector debe reconstruir el sentido\r\nprofundo de un texto en el marco del reconocimiento del contexto en el que se produce y\r\nde las condiciones discursivas (ideológicas, textuales, sociales) en las que se emite. Las\r\ndimensiones que configuran la competencia en lectura crítica son: 1) dimensión textual\r\nevidente; 2) dimensión relacional intertextual; 3) dimensión enunciativa; 4) dimensión\r\nvalorativa; y, 5) dimensión sociocultural.'),
(4, 'Inglés', 'Este módulo evalúa la competencia para comunicarse efectivamente en inglés. Esta\r\ncompetencia, alineada con el Marco Común Europeo, permite clasificar a los examinados en\r\ncuatro niveles de desempeño A1, A2, B1, B2.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamento`
--

CREATE TABLE `departamento` (
  `codigo` varchar(5) NOT NULL,
  `nombre` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `departamento`
--

INSERT INTO `departamento` (`codigo`, `nombre`) VALUES
('11', 'BogotaD.C.'),
('13', 'Bolivar'),
('15', 'Boyaca'),
('17', 'Caldas'),
('18', 'Caqueta'),
('19', 'Cauca'),
('20', 'Cesar'),
('23', 'Cordoba'),
('25', 'Cundinamarca'),
('27', 'Choco'),
('41', 'Huila'),
('44', 'La Guajira'),
('47', 'Magdalena'),
('5', 'Antioquia'),
('50', 'Meta'),
('52', 'Narino'),
('54', 'Norte de Santander'),
('63', 'Quindio'),
('66', 'Risaralda'),
('68', 'Santander'),
('70', 'Sucre'),
('73', 'Tolima'),
('76', 'Valle del Cauca'),
('8', 'Atlantico'),
('81', 'Arauca'),
('85', 'Casanare'),
('86', 'Putumayo'),
('88', 'San Andres'),
('91', 'Amazonas'),
('94', 'Guainia'),
('95', 'Guaviare'),
('97', 'Vaupes'),
('99', 'Vichada');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `enunciado`
--

CREATE TABLE `enunciado` (
  `Id` int(11) NOT NULL,
  `Titulo` varchar(300) NOT NULL,
  `Descripcion` varchar(7000) NOT NULL,
  `Grafica` varchar(300) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `enunciado`
--

INSERT INTO `enunciado` (`Id`, `Titulo`, `Descripcion`, `Grafica`) VALUES
(1, '1. ACTIVISTAS AL PODER', '1. Un grupo de activistas que defiende los derechos de los animales busca evitar que un centro de investigación siga utilizando cerdos para sus experimentos, pues los tratamientos incluyen procedimientos que se consideran maltrato y que en algunos casos terminan en la muerte de los animales. Por su parte, los investigadores defienden su uso, pues estos animales proveen la mejor plataforma para desarrollar sus medicinas sin poner en riesgo vidas humanas. Además, mencionan que el laboratorio no viola ninguna de las normas existentes sobre investigación con animales y que su labor permite proteger la vida de las personas.', NULL),
(2, '2. TEMPORADA DE LLUVIAS', '2. Después de una fuerte temporada de lluvias, el Gobierno nacional despliega ayudas para atender a la población afectada. No obstante, los daños materiales y de afectación a la vida y a la salud de las personas son muy grandes. Se hace un llamado a la ciudadanía para que aporte dinero y materiales y así poder brindar una mejor respuesta a la emergencia. Tras este llamado, la respuesta de la ciudadanía es casi nula.', NULL),
(3, '3. EPOCAS DE LLUVIA', '3. Durante las épocas de lluvias, en muchas zonas rurales de Colombia se inundan escuelas y se interrumpen los caminos para llegar a estas. ', NULL),
(4, '10. CONSIDERABLES PROBLEMAS DE BASURA', '10. Para solucionar los problemas de basura de la capital del departamento, se decidió construir un relleno sanitario en un lote de otro municipio cercano, al cual se le compensaría económicamente por prestar este servicio a la capital. Según el gobierno departamental, la escogencia del lote se hizo conjuntamente con las autoridades ambientales y con la alcaldía del municipio. El proyecto del relleno sanitario cuenta con todas las licencias ambientales requeridas y su construcción es necesaria para la salubridad de la capital. En una consulta popular, los habitantes del municipio cercano votaron 96 % en contra de la construcción del relleno, porque consideran que este es una amenaza para la salud de la población y el ecosistema, y disminuiría el valor de la tierra circundante. ', NULL),
(5, '15. CIRCUCISIÓN', '15. Durante siglos, los practicantes judíos y musulmanes les han practicado la circuncisión a sus hijos. En Alemania, un juez tomó la decisión de prohibir la circuncisión a niños menores de 14 años de edad. A esa edad, cada niño decidirá por sí mismo si se la realiza. Las grandes comunidades de judíos y musulmanes piensan que este es un ataque en contra de sus creencias e invitan a seguir practicando circuncisiones a temprana edad. El asunto ha generado polémica, pues se considera un nuevo ataque a las costumbres y herencia judía y musulmana, pueblos que siguen siendo discriminados por su cultura a pesar de sus grandes aportes económicos a los países europeos. ', NULL),
(6, '19. MEDICINA POPULAR', '19.La medicina popular colombiana conserva una amplia serie de conocimientos empíricos sobre gran diversidad de recursos botánicos, que han sido esenciales para el cuidado de la salud. Pero, con la oficialización de la medicina a finales del siglo XIX, la creación de las primeras escuelas de medicina y de farmacia y la creación de una legislación que buscaba regular estas disciplinas, muchos de estos conocimientos fueron rechazados al igual que sus prácticas médicas. Paradójicamente, mientras la medicina oficial negaba los conocimientos populares, se servía de ellos para desarrollar muchos de los avances farmacéuticos de los que se vale la medicina oficial para sus tratamientos. Por otro lado, según la Organización Mundial de la Salud, la atención primaria en salud por parte de la medicina oficial cubre apenas a un 20 % de la población en los países en vías de desarrollo, mientras que el 80 % tiene que recurrir a otras prácticas médicas populares y lo hace en gran parte por la poca garantía de acceso y de aseguramiento de la población pobre. Lo anterior sigue generando inconformidad en quienes practican la medicina oficial pues consideran que la medicina popular no representa un conocimiento válido porque no se fundamenta en pruebas científicas y no está regulada. Sin embargo, ambas medicinas pueden llegar a ser complementarias si se estudian de manera juiciosa y se determinan cuáles de las prácticas y de los recursos botánicos usados por la medicina popular son perjudiciales y cuáles brindan alternativas de salud a las poblaciones necesitadas. De esta manera, también se promueve la inclusión, el reconocimiento y el respeto por la diversidad cultural y por los conocimientos populares.\r\nTomado y adaptado de: Prieto Gaona, Oriana. (2011). Proyecto de investigación sobre medicina popular.\r\n', NULL),
(7, 'Promocion de estudios', '0. La promoción de estudios académicos para determinar cuáles de las prácticas usadas por la medicina popular son perjudiciales y cuáles brindan alternativas de salud ', NULL),
(8, '65. LA DOCTRINA TRUMAN', '84. En su discurso de posesión como presidente de Estados Unidos el 20 de enero de 1949, Harry Truman anunció al mundo entero su concepto de “trato justo”. Un componente esencial del concepto era su llamado a Estados Unidos y al mundo para resolver los problemas de las “áreas subdesarrolladas” del globo:\r\nLa doctrina Truman inició una nueva era en la comprensión y el manejo de los asuntos mundiales, en particular de aquellos que se referían a los países económicamente menos avanzados. El propósito era bastante ambicioso: crear las condiciones necesarias para reproducir en todo el mundo los rasgos característicos de las sociedades avanzadas de la época: altos niveles de industrialización y urbanización, tecnificación de la agricultura, rápido crecimiento de la producción material y los niveles de vida, y adopción generalizada de la educación y los valores culturales modernos. En concepto de Truman, el capital, la ciencia y la tecnología eran los principales componentes que harían posible tal revolución masiva. Solo así el sueño americano de paz y abundancia podría extenderse a todos los pueblos del planeta.\r\nLa invención del Tercer Mundo. Construcción y deconstrucción del desarrollo (Introducción). Arturo Escobar\r\n Más de la mitad de la población del mundo vive en condiciones cercanas a la miseria. Su alimentación es inadecuada, es víctima de la enfermedad. Su vida económica es primitiva y está estancada. Su pobreza constituye un obstáculo y una amenaza tanto para ellos como para las áreas más prósperas. Por primera vez en la historia, la humanidad posee el conocimiento y la capacidad para aliviar el sufrimiento de estas gentes… Creo que deberíamos poner a disposición de los amantes de la paz los beneficios de nuestro acervo de conocimiento técnico para ayudarlos a lograr sus aspiraciones de una vida mejor… Lo que tenemos en mente es un programa de desarrollo basado en los conceptos del trato justo y democrático… Producir más es la clave para la paz y la prosperidad. Y la clave para producir más es una aplicación mayor y más vigorosa del conocimiento técnico y científico moderno (Truman, 1964).\r\n', NULL),
(9, '15. Truman', '15. Dice truman:', NULL),
(10, 'Niña Wendy, Valérie y todas las demás', 'A finales de 2000, Wendy, una adolescente hondureña, fue violada en grupo por pandilleros de la Mara Salvatrucha. Tras el ritual conocido como “el trencito”, los mareros decidieron hacer negocio y corrieron la voz de que cobraban cincuenta lempiras a quien quisiera tener relaciones con la muchacha.\r\nEl pasado diciembre la policía detuvo en Málaga a una rumana que había firmado un contrato para vender sus dos hijas a unos proxenetas. Por 5.000 euros aceptó que fueran llevadas a España a prostituirse. \r\nLuisa, universitaria bogotana, empezó en un videochat. Le pagaban por desnudarse ante la cámara. De allí pasó a concertar citas vía celular y ya con clientes se enroló en un lujoso burdel: “Si estoy con un man que me gusta porque sí, ¿por qué no voy a estar con otro por plata?”. (…) \r\nLa Valeska vive en función de la plata. Ejerce la prostitución desde los 17 años, cuando aburrida del maltrato de su padre dejó la comodidad del barrio Laureles para ofrecerse en Bogotá. (…)\r\nPoca gente pasa el umbral, pero son varias las vías para llegar al sexo pago. A pesar de esta verdad de a puño, muchos se resisten a la evidencia disponible y enfatizan una doctrina cada vez más terca e improcedente para la prevención: la prostitución siempre es forzada. Sin embargo, ¿cuántas personas venden su cuerpo empujadas por la miseria, cuántas obligadas por proxenetas, ¿cuántas seducidas y abandonadas, ¿cuántas huyendo del abuso, ¿cuántas por morbo o curiosidad, ¿cuántas por arribistas, ¿cuántas por la adrenalina, ¿cuántas por hipersexuales? ¿Cuántas Wendys por cada Valeska o cada Luisa? Nadie sabe, las respuestas no son obvias e incluso la disponibilidad de testimonios puede estar sesgada. Además de los antecedentes familiares o las experiencias individuales, el entorno y la época influyen. \r\nEn Colombia, aunque tenemos indicios de que el negocio de las prepagos está en franca expansión, no conocemos el tamaño de la actividad ni su composición. Nadie comprende bien por qué se inician, por qué se mantienen o por qué dejan la actividad, y cada vez es mayor la influencia de quienes no están interesados en que se sepa. \r\nLa industria del rescate es ya una poderosa alianza multinacional de burócratas, periodistas y oenegés (ONG) que logró simplificar hasta el absurdo el diagnóstico, demostrando de paso que no solo tiene más prejuicios que la Iglesia, los viejos criminólogos o los médicos higienistas sino que carece de cualquier vocación para entender lo que ocurre, lo que piensan o lo que quieren las víctimas. Esa alianza pretende intervenir un mercado sobre el que se sabe no solo poco, sino cada vez menos. (…)\r\n“No me arrepiento absolutamente de nada”, dice una prostituta. Los momentos en el burdel “fueron unos de los mejores de mi vida, por el simple hecho de haber conocido a Giovanni y haber encontrado esa mujer nueva que soy ahora… Utilizar el sexo como medio para encontrar lo que todo el mundo busca: reconocimiento, placer, autoestima y, en definitiva, amor y cariño... ¿Qué hay de patológico en eso?”.\r\n Rubio, M. (2012, junio). Wendy, Valérie y todas las demás. El malpensante, vol. 131. Tomado y adaptado de: http://www.elmalpensante.com/index.php?doc=display_contenido&id=2573 ', NULL),
(11, '2. RESIDUOS DOMESTICOS', '2. En una ciudad se producen en promedio 600 toneladas diarias de residuos domésticos, de las cuales el 25% corresponde a papel y cartón, materiales fácilmente reciclables; además, por cada tonelada de papel y cartón que se recicla • se evita la tala de 17 árboles adultos y la plantación masiva de especies para la producción de pasta de papel. • se ahorran 140 litros de petróleo y 50.000 litros de agua. Tomado y adaptado de: http://www.papelesecologicos.com/index.php?option=com_content&view=article&id=51&Itemid=60.', NULL),
(12, 'responder', 'Responder', NULL),
(13, '63. FORMULA PARA MEDIR DISTANCIAS', '63. Usualmente, las distancias en el espacio se miden en años luz. Un año luz corresponde a la distancia que recorre la luz en un año (aproximadamante 9,46 × 1012 km). Un estudiante sabe que el diámetro de la Vía Láctea mide aproximadamente 1021 m, y para determinar la cantidad de años luz a la que esto equivale usa la siguiente expresión:', NULL),
(14, '2. Responder', '2. Federico fue el ganador de $100.000 en una minilotería, él por un costo de $1.000 apostó a tres dígitos diferentes y ganó porque los dígitos que seleccionó coincidieron con los sorteados (no importaba el orden). ', NULL),
(15, '45. Pregunta matemática', '45. Resolver', NULL),
(16, '16. BEST CITY IN THE WORLD', '16. Many major cities in the world today have large populations of people who have recently arrived; they have emigrated from other countries. Perhaps you, too, have left a familiar place to come to a new city or a new country. Or you may live in a city where there are large numbers of newcomers. Adapting to a new place forces people to seek out new friends, face new problems, and often learn a new language.', NULL),
(17, '8. Answer', '8. Answer', NULL),
(18, '97. Answer:', '97. Anwer:', NULL),
(19, '2. What a story', '2. Stephen William Hawking, a well-known scientist from Oxford, studied physics at Oxford University. When he was 21 and was doing studies on the universe at Cambridge University, the doctors found he had a neuro motor problem. Later, his problem got worse but he wanted to finish his studies. He thought he was going to live only a few months because most people like him only live for 18 months after diagnosis. In 1985, he had an operation and lost his ability to speak. At first, he could talk by spelling words moving his eyes when someone showed him a letter. Then, he was able to choose words from a computer screen with a switch.In 1998, his first book, which was about the universe, was very popular, but many people did not finish it because it was dif ficult to understand. In 2005, he wrote a simple version called A brief History of Time.“Before I got ill, my life was boring,” he said. But then he had dreams about giving something good to the world, so he began to improve his work and now we can understand the universe better. He said his success came from the help of his wife and children, other people, and governmentorganizations. Hawking worked as a Lucasian Proffessor of mathematics at the University of Cambridge, a job that Newton also had had in 1663. ', NULL),
(20, '3. Howking', '3. Howking', NULL),
(21, '1. Inversiones', 'Una persona que vive en Colombia tiene inversiones en dólares en Estados Unidos, y sabe que\r\nla tasa de cambio del dólar respecto al peso colombiano se mantendrá constante este mes,\r\nsiendo 1 dólar equivalente a 2.000 pesos colombianos y que su inversión, en dólares, le dará\r\nganancias del 3 % en el mismo periodo. Un amigo le asegura que en pesos sus ganancias\r\ntambién serán del 3 %. ', NULL),
(22, '2. Rectangulos', 'Si en un rectángulo se aumenta la longitud de uno de sus lados en 100 %', NULL),
(23, '3.', 'Una escuela de natación cuenta con un total de 16 estudiantes. Para las clases se usan 2 piscinas\r\ncon distinta profundidad. Por seguridad, las personas con una estatura inferior a 1,80 m se envían\r\na la piscina menos profunda, y las demás, a la más profunda.', NULL),
(24, '4.', 'En un juego, el animador elige tres números positivos, X, Z y W, y una vez elegidos debe\r\nproveerles a los participantes información que permita hallar los números, declarando ganador al\r\njugador que primero los encuentre. En una ocasión, el animador les suministró como pistas a los\r\nparticipantes los valores R = XZ, S = XW y T = ZW, información suficiente para hallar los valores\r\nde X, Z y W. Una de las jugadoras quiere hallar X primero', NULL),
(25, '5.', 'A partir de un conjunto de números S, cuyo promedio es 9 y desviación estándar 3, se construye\r\nun nuevo conjunto de números T, tomando cada elemento de S y sumándole 4 unidades. Si, por\r\nejemplo, 8 es un elemento de S, entonces el número 8 + 4 = 12 es un elemento de T', NULL),
(26, '6.', 'Se pueden encontrar números racionales mayores que un número entero k, de manera que sean\r\ncada vez más cercanos a él, calculando (k + 1/ j) (con j entero positivo). Cuanto más grande sea j,\r\nmás cercano a k será el racional construido.', NULL),
(27, '7.JAMES SALTER’S DAYS IN FILM', 'James Salter was a pilot in the United States Air Force. He abandoned\r\nthe military profession in 1957 after the publication of his first novel,\r\nThe Hunters. He is best known as a novelist, but during the sixties and\r\nseventies, he worked in film making. Salter made documentaries, wrote\r\ntexts for films, and even was the director of a film called Three, starring\r\nCharlotte Rampling and Sam Waterston.\r\nIn Passionate Falsehoods, which was adapted from Salter’s book Burning\r\nthe Days, published in The New Yorker in 1997, Salter tells the story of his\r\nlife in film.\r\nSalter’s time in the film world is both good and bad. In Rome, he met\r\ndirectors and stars. In New York, he explored the city with Robert\r\nRedford and enjoyed being famous. Deborah Treisman and Michael\r\nAgger have talked about Salter. Nick Paumgarten in The Last Book,\r\ndescribes Salter’s opinion about his film career:\r\n“Of sixteen texts for movies, only four were popular. There was money,\r\nattractive women, and entrance into rooms where there were stories more\r\nfor the dinner table than for the page.” Salter thought he was wasting\r\nhis time.\r\nPerhaps he wasted his time in a larger artistic way, but it still makes\r\nfor attractive reading. The Last Book is available to everyone in online\r\nstores.', NULL),
(28, '8. Swift Pizza and Sandwich House', 'Today we have the pleasure of showing you the best letter written by\r\nour customer Mark. He wins £25 for writing about us this week. He is\r\nso happy with the orders at Swift Pizza and Sandwich House that he\r\nwants to declare a holiday to celebrate his experience here: “Happy\r\nburgerday and Merry Sandwichmas to everyone!” he wrote.\r\nWednesday May 18, 2011.\r\n', NULL),
(29, '9.', 'Bogotá, la ciudad con mayores reservas de sangre, es un ejemplo de déficit de sangre: el índice de\r\ndonación está en 22 donantes por cada 1000 habitantes, cuando el indicador debería estar en 40\r\ndonantes por cada 1000 habitantes.', NULL),
(30, '10. Inteligencia Vial', 'Con el fin de disminuir la accidentalidad en cierto tramo de carretera, se estudian dos propuestas para\r\nhacer más visibles las señales\r\n1- colocar una banda fluorescente alrededor de cada molde\r\n2- pintar cada molde con pintura fluorescente\r\nDado que las dos propuestas son igualmente beneficiosas para el fin propuesto, se debe tomar la\r\ndecisión más económica posible, sabiendo que cada centímetro de material usado en la propuesta 1\r\ntiene el mismo costo que cada centímetro cuadrado de molde pintado', NULL),
(31, '11. CIUDAD Y LITERATURA ', 'La ciudad puede ser perfectamente un tema literario, escogido por el interés o la necesidad de un autor\r\ndeterminado. Ahora pululan escritores que se autodenominan o son señalados por alguna “crítica”\r\ncomo escritores urbanos. \r\nNo obstante, considero que muchos de ellos tan sólo se acercan de manera\r\nsuperficial a ese calificativo y lo hacen equívocamente al pretender referirse a la ciudad a través de una\r\nmera nominación de calles, de bares en esas calles, de personajes en esos bares de esas calles, como si\r\nla descripción más o menos pormenorizada de esas pequeñas geografías nos develara una ciudad en\r\ntoda su complejidad.\r\n\r\nLa ciudad es, en sí misma, un tema literario. Además, es el escenario donde transcurren y han\r\ntranscurrido miles y miles de historias de hombres y mujeres. La ciudad es la materia prima de los\r\nsueños y las pesadillas del hombre moderno, el paisaje en el cual se han formado sentimental e\r\nintelectualmente muchas generaciones de narradores en todo el mundo.\r\nEsa condición de escenario ambulante y permanente hace que la ciudad sea casi un imperativo temático\r\no, mejor, el espacio natural de la imaginación narrativa contemporánea. Por supuesto que existen otros\r\ntemas y otros imaginarios, distintos a los urbanos; pero quiero señalar de forma especial la\r\nimpresionante presencia de lo citadino en la literatura y, en este caso, primordialmente en la cuentística\r\nuniversal del presente siglo.\r\n\r\nFrente a la pregunta de qué es lo urbano en literatura, habría que contestar que urbano no es\r\nnecesariamente lo que sucede o acontece dentro de la urbe. Una narración puede ubicarse\r\nlegítimamente en la ciudad pero estar refiriéndose a una forma de pensar, actuar y expresarse \"rural”\r\no ajena al universo comprendido por lo urbano. Esto último, lo urbano, posee sus maneras específicas\r\nde manifestarse, sus lenguajes, sus problemáticas singulares: en definitiva, un universo particular.\r\n En consecuencia se podría afirmar que la narrativa urbana es aquella que trata sobre los temas y los\r\ncomportamientos que ha generado el desarrollo de lo urbano, y siempre a través de unos lenguajes\r\npeculiares. Esta definición no pretende ser exhaustiva ni excluyente, pero es útil para delimitar ese\r\nuniverso esquivo y manoseado de lo urbano.\r\n(Tomado de: TAMAYO S., Guido L. Prólogo al texto Cuentos urbanos.\r\nColección El Pozo y el Péndulo, Bogotá: Panamericana, 1999.) ', NULL),
(32, '12. LA VENTANILLA DEL BUS ', 'Comienza a oscurecer, ya están encendidas las vitrinas de la Carrera Trece, en los andenes se agolpa la\r\nmultitud; voy en un bus que lucha por abrirse paso en la congestión vehicular. Entre la ciudad y yo está\r\nel vidrio de la ventanilla que devuelve mi imagen, perdida en la masa de pasajeros que se mueven al\r\nritmo espasmódico del tránsito. Ahora vamos por una cuadra sin comercio, la penumbra de las fachadas\r\nle permite al pequeño mundo del interior reflejarse en todo su cansado esplendor: ya no hay paisaje\r\nurbano superpuesto al reflejo. Sólo estamos nosotros, la indiferente comunidad que comparte el viaje.\r\nEl bus acelera su marcha y la ciudad desaparece. Baudrillard dice que un simulacro es la suplantación\r\nde lo real por los signos de lo real. No hay lo real, tan sólo la ventanilla que nos refleja. Nosotros, los\r\npasajeros, suplantamos la realidad, somos el paisaje. ¿Somos los signos de lo real?. Un semáforo nos\r\ndetiene en una esquina. Otro bus se acerca lentamente hasta quedar paralelo al nuestro; ante mí pasan\r\notras ventanillas con otros pasajeros de otra comunidad igualmente apática.\r\nPasan dos señoras en el primer puesto. Serán amigas -pienso-, quizás compañeras de trabajo. Pero no\r\nhablan entre ellas. Sigue pasando la gente detrás de las otras ventanas, mezclando su imagen real con\r\nnuestro reflejo. Creo verme sentado en la cuarta ventanilla del bus que espera la señal verde junto a\r\nnosotros. Es mi reflejo, intuyo; pero no es reflejo: soy yo mismo sentado en el otro bus. Con temor y\r\nasombro, él y yo cruzamos una mirada cómplice, creo que nos sonreímos más allá del cansancio del día\r\nde trabajo. Los dos vehículos arrancan en medio de una nube de humo negro.\r\n(Texto tomado de: PÉRGOLIS, Juan Carlos; ORDUZ, Luis Fernando; MORENO, Danilo. Reflejos, fantasmas, desarraigos. Bogotá recorrida.\r\nBogotá: Arango Editores, Instituto Distrital de Cultura y Turismo, 1999.) ', NULL),
(33, '13. ¡OH BELLA INGRATA! ', '(Carta de Don Quijote a Dulcinea del Toboso (tomada del libro de Miguel de Cervantes Saavedra).\r\nSoberana y alta señora:\r\nEl herido de punta de ausencia y el llagado de las telas del corazón, dulcísima Dulcinea del Toboso, te\r\nenvía la salud que él no tiene. Si tu hermosura me desprecia, si tu valor no es en mi pro, si tus desdenes\r\nson en mi afincamiento, maguer que yo sea asaz de sufrido, mal podré sostenerme en esta cuita, que,\r\nademás de ser fuerte, es muy duradera. \r\nMi buen escudero Sancho te dará entera relación, ¡oh bella ingrata, amada enemiga mía!, del modo en\r\nque por tu causa quedo: si gustares de acorrerme, tuyo soy; y si no, haz lo que te viniere en gusto; que\r\ncon acabar mi vida habré satisfecho a tu crueldad y a mi deseo.\r\nTuyo hasta la muerte,\r\nEl Caballero de la Triste Figura. ', NULL),
(34, '14.', 'La Revolución Industrial se debió, entre otras causas, a la invención de la máquina de vapor y la\r\nconcentración del capital, que permitió adquirir máquinas para producir en masa. Esta revolución\r\nprodujo cambios en la población, se pasó de la explotación de la tierra a la producción de\r\nbienes, del telar familiar a la gran fábrica y de la manufactura a la producción tecnificada.', NULL),
(35, '15.', 'Entre los 16 estudiantes de un salón de clases se va a rifar una boleta para ingresar a un parque de diversiones. Cada estudiante debe escoger un número del 3 al 18. El sorteo se efectúa de la siguiente manera: se depositan 6 balotas en una urna, cada una numerada del 1 al 6; se extrae una balota, se mira el número y se vuelve a depositar en la urna. El experimento se repite dos veces más. La suma de los tres puntajes obtenidos determina el número ganador de la rifa. Si en la primera extracción del sorteo se obtuvo 2, es más probable que el estudiante que escogió el número 10 gane la rifa a que la gane el estudiante con el número 7, ', NULL),
(36, '16.', 'A partir de las cadenas de ARN mensajero se forman las proteínas. En este proceso, por cada tres nucleótidos consecutivos de ARN mensajero se codifica un aminoácido. A continuación se muestra una secuencia de ARN mensajero. \r\n\r\nLos nucleótidos AUG codifican únicamente para indicar el inicio de la formación de la proteína y los nucleótidos UAG codifican únicamente para indicar su terminación. Con base en esta información, ', NULL),
(37, '17.', 'El problema del tráfico de drogas ilícitas ha generado que gobernantes, académicos y miembros de la sociedad civil de países productores debatan sobre el asunto con el fin de encontrar soluciones. Algunos proponen que, para defender el bien común, se debe legalizar las drogas.', NULL),
(38, '18.', 'Algunas tendencias del liberalismo promueven cobrar más impuestos a la parte de la población que posee más recursos, y menos impuestos a aquellas personas que posean menos. ', NULL),
(39, '19.', 'En las principales ciudades del mundo moderno está produciéndose un paulatino abandono de las zonas residenciales del centro urbano, al tiempo que las zonas periféricas tienden a un mayor poblamiento. Estas migraciones las realizan personas o familias que tienen ingresos medios y altos. ', NULL),
(40, '20. INFOGRAFIA', 'Considere la siguiente descripción del contenido de la infografía:\r\n«La infografía muestra datos sobre la frecuencia de los accidentes de tránsito en el mundo, y ejemplos relacionados. Además, informa sobre la mortalidad por género, por ingresos, por número de vehículos, por tipo de vehículo y por ubicación regional.»', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estudiante`
--

CREATE TABLE `estudiante` (
  `Ident_num` varchar(15) NOT NULL,
  `Tipo_ident` varchar(50) NOT NULL,
  `Genero` varchar(20) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `Fecha_nac` date NOT NULL,
  `Dir_numero` varchar(100) NOT NULL,
  `Dir_barrio` varchar(100) NOT NULL,
  `Teléfono` varchar(100) NOT NULL,
  `codPrograma` varchar(6) NOT NULL,
  `codCiudad` varchar(5) NOT NULL,
  `idUsuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `estudiante`
--

INSERT INTO `estudiante` (`Ident_num`, `Tipo_ident`, `Genero`, `Nombre`, `Apellido`, `Fecha_nac`, `Dir_numero`, `Dir_barrio`, `Teléfono`, `codPrograma`, `codCiudad`, `idUsuario`) VALUES
('1005162949', 'Tarjeta de Identidad', 'Masculino', 'Oscar Eduardo', 'Vera Sanabría', '2003-08-17', 'calle 45#0-172', 'campo hermoso', '3165402620', '20410', '68001', 9),
('1005464259', 'Tarjeta de Identidad', 'Masculino', 'Sebastian Fernando', 'Veloza Cerón', '2002-02-19', 'cra11#5-40', 'Villabel', '321564897', '20410', '68001', 6),
('1098822716', 'Cédula de Ciudadania', 'Masculino', 'Paul ', 'Diaz', '1999-09-19', 'Portal Campestre', 'Girón', '3222270651', '20410', '68307', 8),
('34532270', 'Cédula de Ciudadania', 'Femenino', 'Maria Cecilia De Juan', 'Acosta Aragón', '1985-05-08', 'Cra11#7-45', 'Villaluz', '3169587895', '90364', '68276', 2),
('98789875', 'Cédula de Extranjeria', 'Masculino', 'Eliodoro Javier', 'Gomez Cimitá', '1998-02-28', 'Troncal 27#5-48 octava', 'Canelos', '3185784515', '105324', '68820', 7);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estudiantepregunta`
--

CREATE TABLE `estudiantepregunta` (
  `Id` int(11) NOT NULL,
  `Opc_estudiante` int(11) NOT NULL,
  `Ident_Estud` varchar(15) NOT NULL,
  `IdPregunta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `estudiantepregunta`
--

INSERT INTO `estudiantepregunta` (`Id`, `Opc_estudiante`, `Ident_Estud`, `IdPregunta`) VALUES
(1, 3, '34532270', 1),
(2, 2, '34532270', 2),
(3, 3, '34532270', 3),
(4, 2, '34532270', 4),
(5, 2, '34532270', 5),
(6, 0, '34532270', 6),
(7, 1, '34532270', 7),
(8, 0, '34532270', 8),
(9, 2, '34532270', 9),
(10, 2, '34532270', 10),
(11, 3, '34532270', 11),
(12, 1, '34532270', 12),
(13, 3, '34532270', 13),
(14, 1, '34532270', 14),
(15, 3, '34532270', 15),
(16, 3, '34532270', 16),
(17, 3, '34532270', 17),
(18, 3, '34532270', 18),
(19, 0, '34532270', 19),
(20, 1, '34532270', 20),
(21, 1, '1005464259', 1),
(22, 2, '1005464259', 2),
(23, 1, '1005464259', 3),
(24, 2, '1005464259', 4),
(25, 2, '1005464259', 5),
(26, 0, '1005464259', 6),
(27, 0, '1005464259', 7),
(28, 0, '1005464259', 8),
(29, 0, '1005464259', 9),
(30, 1, '1005464259', 10),
(31, 1, '1005464259', 11),
(32, 1, '1005464259', 12),
(33, 1, '1005464259', 13),
(34, 1, '1005464259', 14),
(35, 2, '1005464259', 15),
(36, 2, '1005464259', 16),
(37, 2, '1005464259', 17),
(38, 2, '1005464259', 18),
(39, 2, '1005464259', 19),
(40, 1, '1005464259', 20),
(41, 1, '98789875', 1),
(42, 3, '98789875', 2),
(43, 2, '98789875', 3),
(44, 2, '98789875', 4),
(45, 3, '98789875', 5),
(46, 0, '98789875', 6),
(47, 0, '98789875', 7),
(48, 3, '98789875', 8),
(49, 1, '98789875', 9),
(50, 2, '98789875', 10),
(51, 3, '98789875', 11),
(52, 3, '98789875', 12),
(53, 3, '98789875', 13),
(54, 0, '98789875', 14),
(55, 3, '98789875', 15),
(56, 1, '98789875', 16),
(57, 2, '98789875', 17),
(58, 2, '98789875', 18),
(59, 1, '98789875', 19),
(60, 1, '98789875', 20),
(61, 2, '98789875', 21),
(62, 1, '98789875', 22),
(63, 3, '98789875', 23),
(64, 3, '98789875', 24),
(65, 2, '98789875', 25),
(66, 1, '98789875', 26),
(67, 0, '98789875', 27),
(68, 3, '98789875', 28),
(69, 3, '98789875', 29),
(70, 2, '98789875', 30),
(71, 3, '98789875', 31),
(72, 0, '98789875', 32),
(73, 0, '98789875', 33),
(74, 2, '98789875', 34),
(75, 3, '98789875', 35),
(76, 2, '98789875', 36),
(77, 3, '98789875', 37),
(78, 3, '98789875', 38),
(79, 1, '98789875', 39),
(80, 2, '98789875', 40),
(81, 1, '1098822716', 21),
(82, 1, '1098822716', 22),
(83, 1, '1098822716', 23),
(84, 2, '1098822716', 24),
(85, 3, '1098822716', 25),
(86, 2, '1098822716', 26),
(87, 3, '1098822716', 27),
(88, 1, '1098822716', 28),
(89, 2, '1098822716', 29),
(90, 1, '1098822716', 30),
(91, 1, '1098822716', 31),
(92, 1, '1098822716', 32),
(93, 3, '1098822716', 33),
(94, 1, '1098822716', 34),
(95, 2, '1098822716', 35),
(96, 2, '1098822716', 36),
(97, 2, '1098822716', 37),
(98, 3, '1098822716', 38),
(99, 0, '1098822716', 39),
(100, 3, '1098822716', 40),
(101, 1, '1005162949', 21),
(102, 2, '1005162949', 22),
(103, 1, '1005162949', 23),
(104, 2, '1005162949', 24),
(105, 1, '1005162949', 25),
(106, 0, '1005162949', 26),
(107, 0, '1005162949', 27),
(108, 0, '1005162949', 28),
(109, 0, '1005162949', 29),
(110, 0, '1005162949', 30),
(111, 0, '1005162949', 31),
(112, 0, '1005162949', 32),
(113, 0, '1005162949', 33),
(114, 0, '1005162949', 34),
(115, 0, '1005162949', 35),
(116, 0, '1005162949', 36),
(117, 0, '1005162949', 37),
(118, 0, '1005162949', 38),
(119, 0, '1005162949', 39),
(120, 0, '1005162949', 40),
(121, 1, '1005464259', 21),
(122, 1, '1005464259', 22),
(123, 0, '1005464259', 23),
(124, 2, '1005464259', 24),
(125, 2, '1005464259', 25),
(126, 0, '1005464259', 26),
(127, 0, '1005464259', 27),
(128, 0, '1005464259', 28),
(129, 0, '1005464259', 29),
(130, 0, '1005464259', 30),
(131, 0, '1005464259', 31),
(132, 0, '1005464259', 32),
(133, 0, '1005464259', 33),
(134, 0, '1005464259', 34),
(135, 0, '1005464259', 35),
(136, 0, '1005464259', 36),
(137, 0, '1005464259', 37),
(138, 0, '1005464259', 38),
(139, 0, '1005464259', 39),
(140, 0, '1005464259', 40);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estudianteprueba`
--

CREATE TABLE `estudianteprueba` (
  `Id` int(11) NOT NULL,
  `Ident_num_estud` varchar(15) NOT NULL,
  `NumPrueba` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `estudianteprueba`
--

INSERT INTO `estudianteprueba` (`Id`, `Ident_num_estud`, `NumPrueba`) VALUES
(1, '34532270', 1),
(2, '1005464259', 1),
(3, '98789875', 1),
(4, '98789875', 2),
(5, '1098822716', 2),
(6, '1005162949', 2),
(7, '1005464259', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facultad`
--

CREATE TABLE `facultad` (
  `id` int(11) NOT NULL,
  `Nombre` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `facultad`
--

INSERT INTO `facultad` (`id`, `Nombre`) VALUES
(1, 'Ciencias, Administrativas Economicas y Contables'),
(2, 'Ciencias Sociales y Humanas'),
(3, 'Comunicacion, Artes y Diseño'),
(4, 'Ingenierias');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `opciones`
--

CREATE TABLE `opciones` (
  `Id` int(11) NOT NULL,
  `Descripcion` varchar(2000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `opciones`
--

INSERT INTO `opciones` (`Id`, `Descripcion`) VALUES
(1, 'los activistas quieren oponerse al desarrollo económico, mientras que los científicos quieren mejorar la vida de todos.'),
(2, 'los activistas quieren cuestionar la efectividad de la ciencia, mientras que los científicos quieren evadir el control a su trabajo.'),
(3, 'los científicos quieren utilizar a los animales como instrumentos de investigación, mientras que los activistas quieren que todos desarrollen sentimientos de apego hacia los animales.'),
(4, 'los científicos quieren priorizar la vida humana, mientras que los activistas quieren proteger lo que consideran un derecho de los animales a su propia vida.'),
(5, 'la incapacidad del Gobierno nacional para atender la emergencia. '),
(6, 'la deficiencia en la infraestructura nacional para la prevención de desastres. '),
(7, 'la inobservancia del principio de solidaridad por parte de los ciudadanos. '),
(8, 'la libertad de los ciudadanos para decidir el uso de sus recursos propios.'),
(9, '3. Organizar esquemas de transporte para que los estudiantes vayan a clases en escuelas no afectadas por las inundaciones. '),
(10, 'Ajustar el calendario para incluir los sábados como día escolar y que no haya clases en las épocas de inundación. '),
(11, 'Dar una parte de las clases a través de tutores a domicilio para reducir los días en que los niños tienen que asistir presencialmente al colegio. '),
(12, 'Trasladar a los niños a escuelas no inundadas dos veces por semana y reducir el número de horas de clases.'),
(13, 'El medio ambiente en la capital y la voluntad del gobierno departamental. '),
(14, 'La economía del municipio y las políticas medioambientales de la capital. '),
(15, 'La salubridad de la capital y la voluntad de los habitantes del municipio. '),
(16, 'Las políticas económicas de la alcaldía del municipio y la salubridad de la capital.'),
(17, 'las consecuencias económicas de la discriminación a un pueblo con grandes capitales.'),
(18, 'los efectos de la decisión del juez en las relaciones internacionales alemanas. '),
(19, '. las creencias religiosas y tradiciones que respaldan la práctica de la circuncisión.'),
(20, 'los derechos de los menores de edad y la responsabilidad de sus padres de respetarlos.'),
(21, 'promover sistemas de financiación adecuados y equitativos que canalicen los recursos necesarios para lograr una atención de mejor calidad y con mayor cobertura. '),
(22, 'prever el envejecimiento demográfico de la población, las estructuras familiares cambiantes, y el de los mercados de trabajo informales.'),
(23, '. respetar el derecho a los servicios de salud, el respeto a las diferencias culturales y a los principios de igualdad y de no discriminación. '),
(24, 'crear un sistema de información, con un enfoque de Derechos Humanos, que permita evaluar los avances en salud.'),
(25, 'se prolongue la inconformidad de quienes practican la medicina oficial. '),
(26, 'se inicien procesos de regulación oficiales sobre este tipo de prácticas. '),
(27, '. se derogue la ley de que la medicina científica es la única oficial. '),
(28, 'se extienda la brecha entre la medicina química y la medicina botánica.'),
(29, 'crear condiciones para reproducir en todo el mundo los rasgos característicos de las sociedades avanzadas. '),
(30, '. adoptar, en el primer mundo, el sueño americano de paz y abundancia, la educación y los valores culturales modernos. '),
(31, 'iniciar una nueva era en la comprensión y manejo de los asuntos de los países económicamente más avanzados. '),
(32, 'generar altos niveles de industrialización y urbanización, tecnificando la agricultura de los países desarrollados.'),
(33, 'elevar los niveles de industrialización y urbanización. '),
(34, '. tratar equitativamente a todas las naciones y a todos los pueblos del planeta.'),
(35, 'producir más fortaleciendo la alianza entre capital, ciencia y tecnología. '),
(36, 'mitigar las condiciones de pobreza, hambre y miseria en todas las áreas del globo.'),
(37, 'toma decisiones dentro de las normas de una comunidad. '),
(38, 'no les da más importancia a los sentimientos que al dinero.  '),
(39, 'gusta de los hombres que tienen dinero. '),
(40, 'la opinión de los demás es importante a la hora de tomar decisiones.  '),
(41, '680 litros de agua. '),
(42, '5.600 litros de agua.'),
(43, '300.000 litros de agua. '),
(44, '. 2.000.000 litros de agua.'),
(45, 'correcta, porque el número 30 indica el número de días que tiene un mes.'),
(46, '. incorrecta, porque debe tener en cuenta las 150 toneladas de papel y cartón reciclado por día.'),
(47, 'correcta, porque tiene en cuenta que día tras día hay 140 litros más de petróleo ahorrado. '),
(48, 'incorrecta, porque debe tener en cuenta las 25 toneladas de papel y cartón reciclado por día.'),
(49, 'el denominador de la fracción debe expresarse en potencias de diez.'),
(50, 'no se tiene en cuenta la equivalencia de unidades entre las magnitudes involucradas.'),
(51, 'para obtener el diámetro se debe determinar el producto entre ambas medidas relacionadas.  '),
(52, 'el resultado no se expresa en potencias de diez como los otros datos.'),
(53, 'Incrementará sus ganancias'),
(54, 'existe una posibilidad entre seis de que pierda.'),
(55, 'puede apostar a todas los tríos de dígitos posibles. '),
(56, 'existen cinco posibilidades entre seis de que pierda.'),
(57, 'si en el chance apuesta $100 a cada trío posible, gana $100.000'),
(58, 'en el chance para ganar $100.000 tiene que apostar mínimo $200.'),
(59, 'si en la minilotería apuesta $50.000 es seguro que gana $100.000 '),
(60, 'en la minilotería el número de posibles apuestas es menor que en el chance.'),
(61, 'cities.'),
(62, 'people.'),
(63, 'major.'),
(64, 'countries.'),
(65, 'give up.'),
(66, 'look for.'),
(67, 'take care.'),
(68, 'find out.'),
(69, 'people are forced to leave their native countries.'),
(70, 'major cities of the world have received many visitors.'),
(71, 'people have immigrated to other countries due to overpopulation'),
(72, 'living in a new place implies many changes for immigrants.'),
(73, 'die soon.'),
(74, 'study more.'),
(75, 'discover new thin gs.'),
(76, '. he was born.'),
(77, 'professors'),
(78, 'family.'),
(79, 'company.'),
(80, 'friends.'),
(81, 'A. correcta, pues, sin importar las variaciones en la tasa de cambio, la proporción en que'),
(82, 'B. incorrecta, pues debería conocerse el valor exacto de la inversión para poder calcular la'),
(83, 'C. correcta, pues el 3 % representa una proporción fija en cualquiera de las dos monedas,'),
(84, 'D. incorrecta, pues el 3 % representa un incremento, que será mayor en pesos colombianos,'),
(85, 'A. aumenta en un 50 %.'),
(86, 'B. se duplica'),
(87, 'C. no cambia.'),
(88, 'D. aumenta en 100 unidades. '),
(89, 'A. las 16 personas se encuentran actualmente en la piscina menos profunda. El director de la'),
(90, 'B. con el promedio es imposible determinar la cantidad de personas en las piscinas. Es'),
(91, 'C. incrementar el promedio a 1,80 m es insuficiente. El director de la escuela debe aceptar'),
(92, 'D. aunque el promedio de estatura de las 16 personas sea inferior a 1,80 m, no significa que'),
(93, 'A. R + S'),
(94, 'B. vRST'),
(95, 'C. (R + S - T)/2'),
(96, 'D v (RS)/T'),
(97, 'A. 9 y 3'),
(98, 'B. 9 y 7.'),
(99, 'C. 13 y 3'),
(100, 'D. 13 y 7.'),
(101, 'A. 10, que es la cantidad de racionales menores que 11.'),
(102, 'B. Una cantidad infinita, pues existen infinitos números enteros mayores que 11.'),
(103, 'C. 11, que es el número que equivale en este caso a j.'),
(104, 'D. Uno, pues el racional más cercano a k se halla con j = 10, es decir, con k + 0,1. '),
(105, 'A. 1960 to 1979'),
(106, 'B. 1960 to 1970.'),
(107, 'C. 1960 to 1985'),
(108, 'D. 1965 to 1989'),
(109, 'A. does not like cooking food for himself.'),
(110, 'B. almost always eats hamburgers.'),
(111, 'C. enjoys eating fast food sometimes.'),
(112, 'D. is tired of going to restaurants.'),
(113, 'A. 1 de los donantes fuera receptor universal'),
(114, 'B. 11 de los donantes por cada 1000 habitantes fuera del grupo A'),
(115, 'C. el 61% de los donantes fuera del grupo O'),
(116, 'D. el 1,8% de los no donantes, deciden donar y son aceptados como donantes'),
(117, 'A. escoger la propuesta 1 si x < 4 cm., la propuesta 2 si x > 4 cm. y cualquiera de las dos si x = 4'),
(118, 'B. escoger la propuesta 1 si x > 4 cm., en cualquier otro caso resulta más beneficiosa la propuesta'),
(119, 'C. escoger la propuesta 1 si x > 4 cm., la propuesta 2 si x < 4cm. y cualquiera de las dos si x = 4'),
(120, 'D. escoger la propuesta 1 si x < 4 cm., en cualquier otro caso resulta más beneficiosa la propuesta'),
(121, 'A. la relación entre narradores urbanos y rurales en la literatura contemporánea. '),
(122, 'B. la similitud entre literatura y urbanismo en la narrativa contemporánea. '),
(123, 'C. la diferencia entre urbanismo y ciudad en la literatura contemporánea. '),
(124, 'D. la relación entre ciudad y literatura en la narrativa contemporánea. '),
(125, 'A. un estudio comparativo entre la literatura del futuro y la actual permitiría percibir la'),
(126, 'B. la literatura del futuro será completamente diferente a la literatura actual, ya que estará'),
(127, 'C. en el futuro la literatura no se diferenciará de lo que es hoy en día, porque en ambos casos el'),
(128, 'D. comparar la literatura actual con la literatura del futuro será una labor infructuosa, puesto'),
(129, 'A. la imagen que Don Quijote tenía de Dulcinea. '),
(130, 'B. la clase social a la que pertenecía Dulcinea. '),
(131, 'C. el aspecto físico que caracterizaba a Dulcinea. '),
(132, 'D. el amor que sentía Don Quijote por Dulcinea. '),
(133, 'A. traslado del campo a la ciudad y el surgimiento del proletariado urbano.'),
(134, 'B. crecimiento de la población rural sobre la urbana.'),
(135, 'C. nacimiento de una élite propietaria de la tierra.'),
(136, 'D. desarrollo de un modelo económico para la protección del proletariado.'),
(137, 'A.   9 '),
(138, 'B. 14 '),
(139, 'C. 20 '),
(140, 'D. 40'),
(141, 'A. 8 '),
(142, 'B. 18 '),
(143, 'C. 6 '),
(144, 'D. 10'),
(145, 'A. Cada persona debe tener la libertad de decidir si consume o no drogas y, por tanto, su comercialización no debería estar bajo ningún control. '),
(146, 'B. Los países productores no tienen ninguna responsabilidad en el tráfico de drogas; la responsabilidad recae sobre los países consumidores. '),
(147, 'C. Quienes consumen drogas no deben ser tratados como delincuentes, sino como adictos que necesitan tratamientos médicos. '),
(148, 'D. En los países productores la prohibición ha generado problemas sociales más graves que aquellos que se querían evitar con esta medida.'),
(149, 'A. En el país A, la tasa promedio de impuestos es el 33% del salario de los habitantes. '),
(150, 'B. En el país B, el Gobierno autoriza aumentar el impuesto del IVA. '),
(151, 'C. En el país C, el Gobierno quita los subsidios para los servicios públicos. '),
(152, 'D. En el país D, el Gobierno aumenta los impuestos de patrimonio y renta. '),
(153, 'A. al creciente desarrollo de la industria en el centro de las ciudades.'),
(154, 'B. a la búsqueda de mejor calidad de vida en barrios tranquilos.'),
(155, 'C. a la escasa oferta de servicios en los barrios del centro de la ciudad.'),
(156, 'D. a la creciente oferta de vivienda barata en las afueras de la ciudad.'),
(157, 'A. pasa por alto información esencial contenida en la infografía. '),
(158, 'B. el orden de su contenido no corresponde con el de la infografía. '),
(159, 'C. menciona información que no está presente en la infografía. '),
(160, 'D. omite evidencias que sustentan la información de la infografía.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `persona`
--

CREATE TABLE `persona` (
  `Ident_num` varchar(15) NOT NULL,
  `Tipo_ident` varchar(30) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `Titulo` varchar(100) NOT NULL,
  `Estado` bit(1) NOT NULL,
  `idUsuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `persona`
--

INSERT INTO `persona` (`Ident_num`, `Tipo_ident`, `Nombre`, `Apellido`, `Titulo`, `Estado`, `idUsuario`) VALUES
('10533149 ', 'Cédula de Ciudadania', 'Jose Manuel', 'Beltrán Vidal', 'Ingeniero Civil', b'1', 3),
('60254110', 'Cédula de Ciudadania', 'Gustavo Alfonso', 'León Castillo', 'Contador Público', b'1', 4),
('63291350', 'Cédula de Ciudadania', 'Administrador', 'Simulacro Udi', 'Administrador', b'1', 1),
('88158292', 'Cédula de Ciudadania', 'Robert Arnulfo', 'Jaimes Portilla', 'Ingeniero Ambiental', b'1', 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pregunta`
--

CREATE TABLE `pregunta` (
  `Id` int(11) NOT NULL,
  `Descripcion` varchar(1000) NOT NULL,
  `Fotografia` varchar(300) DEFAULT NULL,
  `idCompetencia` int(11) NOT NULL,
  `Id_Enunciado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pregunta`
--

INSERT INTO `pregunta` (`Id`, `Descripcion`, `Fotografia`, `idCompetencia`, `Id_Enunciado`) VALUES
(1, '1. Las divergencias de intereses entre científicos y activistas radican en que', NULL, 1, 1),
(2, '2. Teniendo en cuenta lo planteado en la Constitución política colombiana, esta respuesta de la ciudadanía refleja', NULL, 1, 2),
(3, '3. ¿Cuál de las siguientes soluciones vulnera el derecho a la educación?', NULL, 1, 3),
(4, '10. En esta situación, ¿cuáles de los siguientes aspectos están en conflicto?', NULL, 1, 4),
(5, '15. En la descripción de esta situación, se le da mayor énfasis a', NULL, 1, 5),
(6, '19. Según el texto, para que la atención primaria en salud, por parte de la medicina oficial, pueda atender a más del 20 % de la población, sería necesario principalmente \r\n\r\n', NULL, 1, 6),
(7, '0. Esto implica que', NULL, 3, 7),
(8, '84. De acuerdo con Arturo Escobar, el propósito de la doctrina Truman era ', NULL, 3, 8),
(9, 'Para alcanzar los propósitos de la doctrina, Harry Truman proponía como estrategia', NULL, 3, 9),
(10, 'La afirmación de Luisa, “Si estoy con un man que me gusta porque sí, ¿por qué no voy a estar con otro por plata?”, implica que ella', NULL, 3, 10),
(11, 'Se realizó una campaña de reciclaje durante tres días en una unidad residencial, en la que se recogieron 2 toneladas diarias de papel y cartón; por tanto, se evitó la tala de 2 × 3 × 17 = 102 árboles adultos. Si esta campaña se efectuara durante 20 días en la misma unidad y se recolectara la misma cantidad se podrían ahorrar ', NULL, 2, 11),
(12, 'Una persona afirma: “Como al día se ahorran 140 litros de petróleo por cada tonelada de papel y cartón reciclado en la ciudad, durante un mes se ahorrarán exactamente 30 veces 140 litros de petróleo”. \r\nSu afirmación es \r\n', NULL, 2, 12),
(13, '2. El estudiante concluye que el diámetro es 106 millones de años luz. El anterior procedimiento es incorrecto, porque', NULL, 2, 13),
(14, '2. Federico desea apostar nuevamente utilizando únicamente el dinero que ganó. Si no puede apostar más de una vez a cada trío de dígitos, es correcto afirmar que si invierte los $100.000', NULL, 2, 14),
(15, '45. Si Federico decide apostar los $100.000 en el chance y le pagan $500 por cada $1 apostado pero para ganar debe acertar en su orden los tres últimos dígitos de una lotería, es correcto afirmar que', NULL, 2, 15),
(16, '16. The underlined word who is related to', NULL, 4, 16),
(17, '8. The underlined words seek out can be replaced by', NULL, 4, 17),
(18, '97. According to the text, ', NULL, 4, 18),
(19, '2. After his 21st birthday, he believedhe was going to', NULL, 4, 19),
(20, 'Hawking thought his dreams hadcome true thanks to his', NULL, 4, 20),
(21, 'La afirmación de su amigo es', NULL, 2, 21),
(22, 'su area,?', NULL, 2, 22),
(23, 'Un día, el director de la escuela escucha que el promedio de estatura de las 16 personas es 1,70 m\r\ne insiste en aumentar la cantidad de alumnos para que el promedio sea 1,80 m, afirmando que\r\nde esta manera se logrará igualar la cantidad de personas en las dos piscinas. Esta afirmación es\r\nerrónea, porque', NULL, 2, 23),
(24, 'La forma de hallarlo es resolviendo', NULL, 2, 24),
(25, 'Es correcto\r\nafirmar, entonces, que para los elementos del conjunto T su promedio y su desviación estándar\r\nson, respectivamente,', NULL, 2, 25),
(26, ' ¿Cuántos números racionales se pueden construir\r\ncercanos a k y menores que  (k + 1/11)?\r', NULL, 2, 26),
(27, 'James Salter played an important part\r\nin the making of movies from', NULL, 4, 27),
(28, 'It can be inferred from the text that Mark', NULL, 4, 28),
(29, ' Este déficit no se presentaría si por lo menos:\r', NULL, 2, 29),
(30, 'La decisión que debe tomarse\r\nes:', NULL, 2, 30),
(31, 'El texto anterior se ocupa fundamentalmente de: ', NULL, 3, 31),
(32, 'Si las ciudades y sociedades de todo el mundo están experimentando una profunda transformación\r\nhistórica y la literatura expresa dicha transformación a través de sus propios lenguajes, podría pensarse\r\nque: \r', NULL, 3, 32),
(33, 'En el saludo que da inicio a la carta se utiliza la expresión Soberana y alta señora. En estas palabras\r\nse refleja:', NULL, 3, 33),
(34, 'De acuerdo\r\ncon lo anterior, se puede afirmar que una de las consecuencias de esta revolución, respecto a la\r\npoblación, fue el', NULL, 1, 34),
(35, 'porque', NULL, 2, 35),
(36, '¿cuántos aminoácidos conformarán la proteína', NULL, 3, 36),
(37, ' ¿Cuál de los siguientes es el argumento más afin con la propuesta de legalización?\r\n', NULL, 1, 37),
(38, '¿Cuál de las siguientes situaciones está de acuerdo con lo anterior?\r\n', NULL, 1, 38),
(39, 'La principal causa de este fenómeno se atribuye ', NULL, 1, 39),
(40, 'Esta descripción es insatisfactoria porque\r\n ', NULL, 3, 40);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preguntaopciones`
--

CREATE TABLE `preguntaopciones` (
  `Id` int(11) NOT NULL,
  `Opc_correcta` bit(1) NOT NULL,
  `Id_Pregunta` int(11) NOT NULL,
  `Id_Opciones` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `preguntaopciones`
--

INSERT INTO `preguntaopciones` (`Id`, `Opc_correcta`, `Id_Pregunta`, `Id_Opciones`) VALUES
(1, b'0', 1, 1),
(2, b'0', 1, 2),
(3, b'0', 1, 3),
(4, b'1', 1, 4),
(5, b'0', 2, 5),
(6, b'0', 2, 6),
(7, b'1', 2, 7),
(8, b'0', 2, 8),
(9, b'0', 3, 9),
(10, b'0', 3, 10),
(11, b'0', 3, 11),
(12, b'1', 3, 12),
(13, b'0', 4, 13),
(14, b'0', 4, 14),
(15, b'1', 4, 15),
(16, b'0', 4, 16),
(17, b'0', 5, 17),
(18, b'0', 5, 18),
(19, b'1', 5, 19),
(20, b'0', 5, 20),
(21, b'1', 6, 21),
(22, b'0', 6, 22),
(23, b'0', 6, 23),
(24, b'0', 6, 24),
(25, b'0', 7, 25),
(26, b'1', 7, 26),
(27, b'0', 7, 27),
(28, b'0', 7, 28),
(29, b'1', 8, 29),
(30, b'0', 8, 30),
(31, b'0', 8, 31),
(32, b'0', 8, 32),
(33, b'0', 9, 33),
(34, b'0', 9, 34),
(35, b'1', 9, 35),
(36, b'0', 9, 36),
(37, b'0', 10, 37),
(38, b'0', 10, 38),
(39, b'1', 10, 39),
(40, b'0', 10, 40),
(41, b'0', 11, 41),
(42, b'1', 11, 42),
(43, b'0', 11, 43),
(44, b'0', 11, 44),
(45, b'0', 12, 45),
(46, b'1', 12, 46),
(47, b'0', 12, 47),
(48, b'0', 12, 48),
(49, b'0', 13, 49),
(50, b'0', 13, 50),
(51, b'0', 13, 51),
(52, b'1', 13, 52),
(53, b'0', 14, 53),
(54, b'1', 14, 54),
(55, b'0', 14, 55),
(56, b'0', 14, 56),
(57, b'0', 15, 57),
(58, b'0', 15, 58),
(59, b'0', 15, 59),
(60, b'1', 15, 60),
(61, b'0', 16, 61),
(62, b'0', 16, 62),
(63, b'0', 16, 63),
(64, b'1', 16, 64),
(65, b'0', 17, 65),
(66, b'0', 17, 66),
(67, b'0', 17, 67),
(68, b'1', 17, 68),
(69, b'0', 18, 69),
(70, b'0', 18, 70),
(71, b'0', 18, 71),
(72, b'1', 18, 72),
(73, b'1', 19, 73),
(74, b'0', 19, 74),
(75, b'0', 19, 75),
(76, b'0', 19, 76),
(77, b'0', 20, 77),
(78, b'1', 20, 78),
(79, b'0', 20, 79),
(80, b'0', 20, 80),
(81, b'0', 21, 81),
(82, b'0', 21, 82),
(83, b'1', 21, 83),
(84, b'0', 21, 84),
(85, b'0', 22, 85),
(86, b'1', 22, 86),
(87, b'0', 22, 87),
(88, b'0', 22, 88),
(89, b'0', 23, 89),
(90, b'0', 23, 90),
(91, b'0', 23, 91),
(92, b'1', 23, 92),
(93, b'0', 24, 93),
(94, b'0', 24, 94),
(95, b'0', 24, 95),
(96, b'1', 24, 96),
(97, b'0', 25, 97),
(98, b'0', 25, 98),
(99, b'1', 25, 99),
(100, b'0', 25, 100),
(101, b'0', 26, 101),
(102, b'1', 26, 102),
(103, b'0', 26, 103),
(104, b'0', 26, 104),
(105, b'1', 27, 105),
(106, b'0', 27, 106),
(107, b'0', 27, 107),
(108, b'0', 27, 108),
(109, b'0', 28, 109),
(110, b'0', 28, 110),
(111, b'0', 28, 111),
(112, b'1', 28, 112),
(113, b'0', 29, 113),
(114, b'0', 29, 114),
(115, b'0', 29, 115),
(116, b'1', 29, 116),
(117, b'0', 30, 117),
(118, b'0', 30, 118),
(119, b'1', 30, 119),
(120, b'0', 30, 120),
(121, b'0', 31, 121),
(122, b'0', 31, 122),
(123, b'0', 31, 123),
(124, b'1', 31, 124),
(125, b'1', 32, 125),
(126, b'0', 32, 126),
(127, b'0', 32, 127),
(128, b'0', 32, 128),
(129, b'1', 33, 129),
(130, b'0', 33, 130),
(131, b'0', 33, 131),
(132, b'0', 33, 132),
(133, b'0', 34, 133),
(134, b'0', 34, 134),
(135, b'1', 34, 135),
(136, b'0', 34, 136),
(137, b'0', 35, 137),
(138, b'0', 35, 138),
(139, b'0', 35, 139),
(140, b'1', 35, 140),
(141, b'0', 36, 141),
(142, b'0', 36, 142),
(143, b'1', 36, 143),
(144, b'0', 36, 144),
(145, b'0', 37, 145),
(146, b'0', 37, 146),
(147, b'0', 37, 147),
(148, b'1', 37, 148),
(149, b'0', 38, 149),
(150, b'0', 38, 150),
(151, b'0', 38, 151),
(152, b'1', 38, 152),
(153, b'0', 39, 153),
(154, b'1', 39, 154),
(155, b'0', 39, 155),
(156, b'0', 39, 156),
(157, b'0', 40, 157),
(158, b'0', 40, 158),
(159, b'1', 40, 159),
(160, b'0', 40, 160);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa`
--

CREATE TABLE `programa` (
  `Codigo` varchar(10) NOT NULL,
  `Nombre` varchar(30) NOT NULL,
  `codSede` varchar(5) NOT NULL,
  `idFacultad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `programa`
--

INSERT INTO `programa` (`Codigo`, `Nombre`, `codSede`, `idFacultad`) VALUES
('102300', 'Derecho', '1', 2),
('105324', 'Ingeniería Civil', '1', 4),
('106295', 'Publicidad y Marketing Digital', '1', 3),
('18982', 'Administración de Empresas', '1', 1),
('18984', 'Diseño Gráfico', '1', 3),
('20407', 'Ingeniería Electrónica', '1', 4),
('20410', 'Ingeniería de Sistemas', '1', 4),
('52964', 'Criminalística', '1', 2),
('53566', 'Ingeniería Industrial', '1', 4),
('90364', 'Psicología', '1', 2),
('90379', 'Diseño Industrial', '1', 3),
('90654', 'Comunicación Social', '1', 3),
('91102', 'Negocios Internacionales', '1', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prueba`
--

CREATE TABLE `prueba` (
  `NumPrueba` int(11) NOT NULL,
  `Fecha_creacion` date NOT NULL,
  `Titulo` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `prueba`
--

INSERT INTO `prueba` (`NumPrueba`, `Fecha_creacion`, `Titulo`) VALUES
(1, '2019-11-22', 'PREPARACION ICFES_1'),
(2, '2019-11-28', 'PRUEBA UDI SALA 17'),
(3, '2010-05-05', 'PRUEBA 30');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pruebapreguntas`
--

CREATE TABLE `pruebapreguntas` (
  `Id` int(11) NOT NULL,
  `num_prueba` int(11) NOT NULL,
  `IdPregunta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pruebapreguntas`
--

INSERT INTO `pruebapreguntas` (`Id`, `num_prueba`, `IdPregunta`) VALUES
(1, 1, 1),
(2, 1, 2),
(3, 1, 3),
(4, 1, 4),
(5, 1, 5),
(6, 1, 6),
(7, 1, 7),
(8, 1, 8),
(9, 1, 9),
(10, 1, 10),
(11, 1, 11),
(12, 1, 12),
(13, 1, 13),
(14, 1, 14),
(15, 1, 15),
(16, 1, 16),
(17, 1, 17),
(18, 1, 18),
(19, 1, 19),
(20, 1, 20),
(21, 2, 21),
(22, 2, 22),
(23, 2, 23),
(24, 2, 24),
(25, 2, 25),
(26, 2, 26),
(27, 2, 27),
(28, 2, 28),
(29, 2, 29),
(30, 2, 30),
(31, 2, 31),
(32, 2, 32),
(33, 2, 33),
(34, 2, 34),
(35, 2, 35),
(36, 2, 36),
(37, 2, 37),
(38, 2, 38),
(39, 2, 39),
(40, 2, 40);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sede`
--

CREATE TABLE `sede` (
  `Codigo` varchar(5) NOT NULL,
  `Nombre` varchar(25) NOT NULL,
  `Dir_numero` varchar(100) NOT NULL,
  `Dir_barrio` varchar(100) NOT NULL,
  `Cod_ciudad` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `sede`
--

INSERT INTO `sede` (`Codigo`, `Nombre`, `Dir_numero`, `Dir_barrio`, `Cod_ciudad`) VALUES
('1', 'Bucaramanga', 'Calle 9 No. 23-55', 'la Universidad', '68001');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `Id` int(11) NOT NULL,
  `Correo` varchar(200) NOT NULL,
  `Clave` varchar(200) NOT NULL,
  `Rol` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`Id`, `Correo`, `Clave`, `Rol`) VALUES
(1, 'adminsimulacroudi@udi.edu.co', 'uNawoWwoWxDFcW1002x01F321QS4kF1Q', 'Administrador'),
(2, 'maraa1@udi.edu.co', 'f0rTN4L3J0001f0rTN9c3DY0NnNL1TTxqN6bmWslm32', 'Estudiante'),
(3, 'jostb@udi.edu.co', 'cW221cV4mai5pc24pc24cW221lo2710xAm5', 'Docente'),
(4, 'gcas25@udi.edu.co', 'p01Xc32lPqF1Qx01cL7cV', 'Administrador'),
(5, 'rbt31@udi.edu.co', '1zD33DzcW221plL7pc24lo27mai5qLopU', 'Docente'),
(6, 'lmiguel@udi.edu.co', 'bmWspUpUlm324as235l4as2024Ulm32w8x', 'Estudiante'),
(7, 'helio45@udi.edu.co', 'w8xcow1in3coww8xcow1in3lm32', 'Estudiante'),
(8, 'pdiaz@udi.edu.co', 'bmWspUw8xcowcow024U024U1in3bmWs35l', 'Estudiante'),
(9, 'overa@udi.edu.co', 'bmWspUpUlm32bmWs35l024Uw8x4as2w8x', 'Estudiante');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `ciudad`
--
ALTER TABLE `ciudad`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `codDpto` (`codDpto`);

--
-- Indices de la tabla `competencias`
--
ALTER TABLE `competencias`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `departamento`
--
ALTER TABLE `departamento`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `enunciado`
--
ALTER TABLE `enunciado`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `estudiante`
--
ALTER TABLE `estudiante`
  ADD PRIMARY KEY (`Ident_num`),
  ADD KEY `idUsuario` (`idUsuario`),
  ADD KEY `codPrograma` (`codPrograma`),
  ADD KEY `codCiudad` (`codCiudad`);

--
-- Indices de la tabla `estudiantepregunta`
--
ALTER TABLE `estudiantepregunta`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Ident_Estud` (`Ident_Estud`),
  ADD KEY `IdPregunta` (`IdPregunta`);

--
-- Indices de la tabla `estudianteprueba`
--
ALTER TABLE `estudianteprueba`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `ident_num_estud` (`Ident_num_estud`),
  ADD KEY `NumPrueba` (`NumPrueba`);

--
-- Indices de la tabla `facultad`
--
ALTER TABLE `facultad`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `opciones`
--
ALTER TABLE `opciones`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `persona`
--
ALTER TABLE `persona`
  ADD PRIMARY KEY (`Ident_num`),
  ADD KEY `idUsuario` (`idUsuario`);

--
-- Indices de la tabla `pregunta`
--
ALTER TABLE `pregunta`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `idCompetencia` (`idCompetencia`),
  ADD KEY `id_enunciado` (`Id_Enunciado`);

--
-- Indices de la tabla `preguntaopciones`
--
ALTER TABLE `preguntaopciones`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `id_Pregunta` (`Id_Pregunta`),
  ADD KEY `id_Opciones` (`Id_Opciones`);

--
-- Indices de la tabla `programa`
--
ALTER TABLE `programa`
  ADD PRIMARY KEY (`Codigo`),
  ADD KEY `codSede` (`codSede`),
  ADD KEY `idFacultad` (`idFacultad`);

--
-- Indices de la tabla `prueba`
--
ALTER TABLE `prueba`
  ADD PRIMARY KEY (`NumPrueba`);

--
-- Indices de la tabla `pruebapreguntas`
--
ALTER TABLE `pruebapreguntas`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IdPrueba` (`num_prueba`),
  ADD KEY `IdPregunta` (`IdPregunta`);

--
-- Indices de la tabla `sede`
--
ALTER TABLE `sede`
  ADD PRIMARY KEY (`Codigo`),
  ADD KEY `cod_ciudad` (`Cod_ciudad`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Correo` (`Correo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `competencias`
--
ALTER TABLE `competencias`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `enunciado`
--
ALTER TABLE `enunciado`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT de la tabla `estudiantepregunta`
--
ALTER TABLE `estudiantepregunta`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=141;

--
-- AUTO_INCREMENT de la tabla `estudianteprueba`
--
ALTER TABLE `estudianteprueba`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `facultad`
--
ALTER TABLE `facultad`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `opciones`
--
ALTER TABLE `opciones`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=161;

--
-- AUTO_INCREMENT de la tabla `pregunta`
--
ALTER TABLE `pregunta`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT de la tabla `preguntaopciones`
--
ALTER TABLE `preguntaopciones`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=161;

--
-- AUTO_INCREMENT de la tabla `pruebapreguntas`
--
ALTER TABLE `pruebapreguntas`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `ciudad`
--
ALTER TABLE `ciudad`
  ADD CONSTRAINT `codDpto` FOREIGN KEY (`codDpto`) REFERENCES `departamento` (`codigo`);

--
-- Filtros para la tabla `estudiante`
--
ALTER TABLE `estudiante`
  ADD CONSTRAINT `estudiante_ibfk_1` FOREIGN KEY (`idUsuario`) REFERENCES `usuarios` (`Id`),
  ADD CONSTRAINT `estudiante_ibfk_2` FOREIGN KEY (`codPrograma`) REFERENCES `programa` (`Codigo`),
  ADD CONSTRAINT `estudiante_ibfk_3` FOREIGN KEY (`codCiudad`) REFERENCES `ciudad` (`codigo`);

--
-- Filtros para la tabla `estudiantepregunta`
--
ALTER TABLE `estudiantepregunta`
  ADD CONSTRAINT `estudiantepregunta_ibfk_1` FOREIGN KEY (`Ident_Estud`) REFERENCES `estudiante` (`Ident_num`),
  ADD CONSTRAINT `estudiantepregunta_ibfk_2` FOREIGN KEY (`IdPregunta`) REFERENCES `pregunta` (`Id`);

--
-- Filtros para la tabla `estudianteprueba`
--
ALTER TABLE `estudianteprueba`
  ADD CONSTRAINT `NumPrueba` FOREIGN KEY (`NumPrueba`) REFERENCES `prueba` (`NumPrueba`),
  ADD CONSTRAINT `ident_num_estud` FOREIGN KEY (`Ident_num_estud`) REFERENCES `estudiante` (`Ident_num`);

--
-- Filtros para la tabla `persona`
--
ALTER TABLE `persona`
  ADD CONSTRAINT `idUsuario` FOREIGN KEY (`idUsuario`) REFERENCES `usuarios` (`Id`);

--
-- Filtros para la tabla `pregunta`
--
ALTER TABLE `pregunta`
  ADD CONSTRAINT `idCompetencia` FOREIGN KEY (`idCompetencia`) REFERENCES `competencias` (`Id`),
  ADD CONSTRAINT `id_enunciado` FOREIGN KEY (`Id_Enunciado`) REFERENCES `enunciado` (`Id`);

--
-- Filtros para la tabla `preguntaopciones`
--
ALTER TABLE `preguntaopciones`
  ADD CONSTRAINT `id_Opciones` FOREIGN KEY (`Id_Opciones`) REFERENCES `opciones` (`Id`),
  ADD CONSTRAINT `id_Pregunta` FOREIGN KEY (`Id_Pregunta`) REFERENCES `pregunta` (`Id`);

--
-- Filtros para la tabla `programa`
--
ALTER TABLE `programa`
  ADD CONSTRAINT `codSede` FOREIGN KEY (`codSede`) REFERENCES `sede` (`Codigo`),
  ADD CONSTRAINT `idFacultad` FOREIGN KEY (`idFacultad`) REFERENCES `facultad` (`id`);

--
-- Filtros para la tabla `pruebapreguntas`
--
ALTER TABLE `pruebapreguntas`
  ADD CONSTRAINT `IdPregunta` FOREIGN KEY (`IdPregunta`) REFERENCES `pregunta` (`Id`),
  ADD CONSTRAINT `IdPrueba` FOREIGN KEY (`num_prueba`) REFERENCES `prueba` (`NumPrueba`);

--
-- Filtros para la tabla `sede`
--
ALTER TABLE `sede`
  ADD CONSTRAINT `cod_ciudad` FOREIGN KEY (`Cod_ciudad`) REFERENCES `ciudad` (`codigo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
