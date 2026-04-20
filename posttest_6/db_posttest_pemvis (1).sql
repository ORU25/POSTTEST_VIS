-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 20, 2026 at 12:26 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_posttest_pemvis`
--

-- --------------------------------------------------------

--
-- Table structure for table `karyawan`
--

CREATE TABLE `karyawan` (
  `nik` varchar(255) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `hp` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `karyawan`
--

INSERT INTO `karyawan` (`nik`, `nama`, `email`, `hp`) VALUES
('IT24001', 'Budi', 'budi@gmail.com', '081212121221'),
('IT24002', 'tono', 'tono@gmail.com', '081212121221');

-- --------------------------------------------------------

--
-- Table structure for table `tanggungan`
--

CREATE TABLE `tanggungan` (
  `id_tanggungan` int(11) NOT NULL,
  `nik_karyawan` varchar(255) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `hubungan` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tanggungan`
--

INSERT INTO `tanggungan` (`id_tanggungan`, `nik_karyawan`, `nama`, `hubungan`, `status`) VALUES
(6, 'IT24001', 'siti', 'istri', 'Meninggal Dunia'),
(8, 'IT24002', 'Neneng', 'Istri', 'Bekerja'),
(9, 'IT24002', 'dedi', 'anak', 'TIdak Bekerja');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `karyawan`
--
ALTER TABLE `karyawan`
  ADD UNIQUE KEY `nik` (`nik`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indexes for table `tanggungan`
--
ALTER TABLE `tanggungan`
  ADD PRIMARY KEY (`id_tanggungan`),
  ADD KEY `karyawan_tanggungan` (`nik_karyawan`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tanggungan`
--
ALTER TABLE `tanggungan`
  MODIFY `id_tanggungan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tanggungan`
--
ALTER TABLE `tanggungan`
  ADD CONSTRAINT `karyawan_tanggungan` FOREIGN KEY (`nik_karyawan`) REFERENCES `karyawan` (`nik`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
