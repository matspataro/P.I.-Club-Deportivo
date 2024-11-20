-- Script para inicializar la base de datos `club_deportivo_pi`

-- Crear la base de datos si no existe
CREATE DATABASE IF NOT EXISTS club_deportivo_pi;
USE club_deportivo_pi;

-- Configuraciones globales para asegurar compatibilidad y consistencia
/*!50503 SET NAMES utf8mb4 */;
SET FOREIGN_KEY_CHECKS = 0;
SET UNIQUE_CHECKS = 0;

-- Crear tabla `persona`
DROP TABLE IF EXISTS `persona`;
CREATE TABLE `persona` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `documento` varchar(20) NOT NULL,
  `contacto` varchar(50) DEFAULT NULL,
  `aptoFisico` tinyint(1) NOT NULL COMMENT '0: No, 1: Sí',
  `tipoCliente` enum('Socio','No Socio') NOT NULL DEFAULT 'No Socio',
  `fechaVencimiento` date DEFAULT NULL,
  `pago` tinyint(1) DEFAULT '0' COMMENT '0: No pagado, 1: Pagado',
  PRIMARY KEY (`id`),
  UNIQUE KEY `documento` (`documento`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Insertar datos de prueba en la tabla `persona`
INSERT INTO `persona` (`id`, `nombre`, `apellido`, `direccion`, `documento`, `contacto`, `aptoFisico`, `tipoCliente`, `fechaVencimiento`, `pago`) VALUES
(1, 'Carmen', 'Grilletta', 'Peru 1234', '23234234', '1112345678', 0, 'No Socio', '2024-11-20', 0),
(2, 'Juan', 'Salomon', 'Av 90 1234', '123', '12345678', 1, 'Socio', '2024-11-18', 1),
(3, 'Clara', 'Lopez', 'Urquiza 345', '11111111', '333444', 1, 'Socio', '2024-11-18', 0);

-- Crear tabla `pago`
DROP TABLE IF EXISTS `pago`;
CREATE TABLE `pago` (
  `id` int NOT NULL AUTO_INCREMENT,
  `fecha` datetime NOT NULL,
  `tipoPago` varchar(50) NOT NULL,
  `monto` decimal(10,2) NOT NULL,
  `personaId` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `personaId` (`personaId`),
  CONSTRAINT `pago_ibfk_1` FOREIGN KEY (`personaId`) REFERENCES `persona` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Insertar datos de prueba en la tabla `pago`
INSERT INTO `pago` (`id`, `fecha`, `tipoPago`, `monto`, `personaId`) VALUES
(3, '2024-11-19 02:45:30', 'Efectivo', 300.00, 2),
(4, '2024-11-19 02:51:58', 'Efectivo', 33.00, 2),
(5, '2024-11-19 03:04:20', 'TC - 6 cuotas', 400.00, 2),
(6, '2024-11-19 03:06:21', 'TC - 1 cuota', 4.00, 2);

-- Crear tabla `usuarios`
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(20) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Insertar datos de prueba en la tabla `usuarios`
INSERT INTO `usuarios` (`id`, `username`, `password`) VALUES
(1, 'sole', '1234'),
(2, 'usuario2', 'password2'),
(3, 'matias', '123456'),
(4, 'admin', 'admin');

-- Restaurar configuraciones globales
SET FOREIGN_KEY_CHECKS = 1;
SET UNIQUE_CHECKS = 1;