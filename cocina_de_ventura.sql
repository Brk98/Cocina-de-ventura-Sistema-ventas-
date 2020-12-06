-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 06, 2020 at 11:04 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cocina_de_ventura`
--

-- --------------------------------------------------------

--
-- Table structure for table `cant_ordenes`
--

CREATE TABLE `cant_ordenes` (
  `id_ordenes_cant` int(10) NOT NULL,
  `Gordita de Comal c/Queso` int(20) NOT NULL,
  `Gordita de Comal sin Ques` int(20) NOT NULL,
  `Gordita Dorada c/Queso` int(20) NOT NULL,
  `Gordita Dorada sin Queso` int(20) NOT NULL,
  `Quesadilla de Comal` int(20) NOT NULL,
  `Quesadilla Dorada` int(20) NOT NULL,
  `Sope Sencillo` int(11) NOT NULL,
  `Sope con Guisado` int(11) NOT NULL,
  `Tacos` int(11) NOT NULL,
  `Plato Chico` int(11) NOT NULL,
  `Plato Grande` int(11) NOT NULL,
  `Refrescos` int(11) NOT NULL,
  `Refrescos Desechables` int(11) NOT NULL,
  `Coca-Cola Desechable` int(11) NOT NULL,
  `Bebidas Calientes` int(11) NOT NULL,
  `Nescafe` int(11) NOT NULL,
  `Bolillo con Guisado` int(11) NOT NULL,
  `Chile Relleno` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cant_ordenes`
--

INSERT INTO `cant_ordenes` (`id_ordenes_cant`, `Gordita de Comal c/Queso`, `Gordita de Comal sin Ques`, `Gordita Dorada c/Queso`, `Gordita Dorada sin Queso`, `Quesadilla de Comal`, `Quesadilla Dorada`, `Sope Sencillo`, `Sope con Guisado`, `Tacos`, `Plato Chico`, `Plato Grande`, `Refrescos`, `Refrescos Desechables`, `Coca-Cola Desechable`, `Bebidas Calientes`, `Nescafe`, `Bolillo con Guisado`, `Chile Relleno`) VALUES
(1, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 2, 3, 0, 2, 0, 2, 0, 1),
(2, 0, 0, 0, 0, 0, 0, 0, 17, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(3, 4, 0, 2, 0, 0, 0, 0, 0, 5, 0, 0, 2, 0, 0, 2, 2, 0, 0),
(4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3);

-- --------------------------------------------------------

--
-- Table structure for table `ordenes`
--

CREATE TABLE `ordenes` (
  `ID_Orden` int(3) NOT NULL,
  `Fecha_Orden` date NOT NULL,
  `total` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ordenes`
--

INSERT INTO `ordenes` (`ID_Orden`, `Fecha_Orden`, `total`) VALUES
(1, '2020-12-04', 63),
(2, '2020-12-04', 119),
(3, '2020-12-05', 119),
(4, '2020-12-06', 21);

-- --------------------------------------------------------

--
-- Table structure for table `productos`
--

CREATE TABLE `productos` (
  `ID_Producto` int(11) NOT NULL,
  `Nombre_Producto` varchar(25) NOT NULL,
  `Precio_Producto` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `productos`
--

INSERT INTO `productos` (`ID_Producto`, `Nombre_Producto`, `Precio_Producto`) VALUES
(1, 'Gordita de Comal c/Queso', 16),
(2, 'Gordita de Comal sin Ques', 7),
(3, 'Gordita Dorada c/Queso', 7),
(4, 'Gordita Dorada sin Queso', 7),
(5, 'Quesadilla de Comal', 7),
(6, 'Quesadilla Dorada', 7),
(7, 'Sope Sencillo', 7),
(8, 'Sope con Guisado', 7),
(9, 'Tacos', 7),
(10, 'Plato Chico', 7),
(11, 'Plato Grande', 7),
(12, 'Refrescos', 7),
(13, 'Refrescos Desechables', 7),
(14, 'Coca-Cola Desechable', 7),
(15, 'Bebidas Calientes', 7),
(16, 'Nescafe', 7),
(17, 'Bolillo con Guisado', 7),
(18, 'Chile Relleno', 7);

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

CREATE TABLE `usuarios` (
  `id_usuario` int(10) NOT NULL,
  `usuario` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `tipo` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `usuarios`
--

INSERT INTO `usuarios` (`id_usuario`, `usuario`, `password`, `tipo`) VALUES
(1, 'brayan', '123', 'Gerente'),
(2, 'Administrador', 'root', 'Gerente'),
(3, 'Fulanito', '123456', 'Cajero'),
(4, 'bra', '123', 'Cajero');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cant_ordenes`
--
ALTER TABLE `cant_ordenes`
  ADD PRIMARY KEY (`id_ordenes_cant`);

--
-- Indexes for table `ordenes`
--
ALTER TABLE `ordenes`
  ADD PRIMARY KEY (`ID_Orden`);

--
-- Indexes for table `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`ID_Producto`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cant_ordenes`
--
ALTER TABLE `cant_ordenes`
  MODIFY `id_ordenes_cant` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `ordenes`
--
ALTER TABLE `ordenes`
  MODIFY `ID_Orden` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id_usuario` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
