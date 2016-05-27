-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 27 Mei 2016 pada 04.41
-- Versi Server: 10.1.10-MariaDB
-- PHP Version: 5.6.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `aplprofit`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `cabang`
--

CREATE TABLE `cabang` (
  `id` int(11) NOT NULL,
  `kode` varchar(20) DEFAULT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `alamat` varchar(50) DEFAULT NULL,
  `notelp` varchar(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `cabang`
--

INSERT INTO `cabang` (`id`, `kode`, `nama`, `alamat`, `notelp`) VALUES
(1, '101', 'CABANG BANDUNG', 'BANDUNG', '00'),
(2, '102', 'CABANG BOGOR', 'BOGOR', '11'),
(3, '103', 'CABANG BEKASI', 'BEKASI', '22'),
(4, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Struktur dari tabel `customer`
--

CREATE TABLE `customer` (
  `id` int(11) NOT NULL,
  `kode` varchar(10) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `alamat` varchar(100) DEFAULT NULL,
  `notlp` varchar(13) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `customer`
--

INSERT INTO `customer` (`id`, `kode`, `nama`, `alamat`, `notlp`) VALUES
(1, '101200001\r', 'Testing dummy', 'dummy', 'dummy'),
(2, '101200002', 'Rehan Test', 'Test', 'Test'),
(3, '102200001', 'Rehan', 'Cibinong', '08654564564');

-- --------------------------------------------------------

--
-- Struktur dari tabel `detailtransaksi`
--

CREATE TABLE `detailtransaksi` (
  `id` int(11) NOT NULL,
  `kodeTrans` varchar(21) NOT NULL,
  `Termin` varchar(20) NOT NULL,
  `Tanggalbayar` date NOT NULL,
  `Bayar` decimal(10,0) NOT NULL,
  `tahun` year(4) NOT NULL,
  `keterangan` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `detailtransaksi`
--

INSERT INTO `detailtransaksi` (`id`, `kodeTrans`, `Termin`, `Tanggalbayar`, `Bayar`, `tahun`, `keterangan`) VALUES
(5, '10120000125052016001', '1', '2016-05-25', '40000000', 2016, ''),
(6, '10120000125052016001', '2', '2016-09-25', '15808000', 2016, ''),
(7, '10120000125052016001', '3', '2016-12-25', '15808000', 2016, ''),
(8, '10120000125052016001', '4', '2017-03-25', '15808000', 2017, ''),
(9, '10120000225052016001', '1', '2016-05-25', '40000000', 2016, ''),
(10, '10120000225052016001', '2', '2016-08-25', '15808000', 2016, ''),
(11, '10120000225052016001', '3', '2016-12-25', '15808000', 2016, ''),
(12, '10120000225052016001', '4', '2017-02-25', '15808000', 2017, '');

-- --------------------------------------------------------

--
-- Struktur dari tabel `employee`
--

CREATE TABLE `employee` (
  `id` int(11) NOT NULL,
  `kode` varchar(7) NOT NULL,
  `nama` varchar(25) DEFAULT NULL,
  `email` varchar(30) DEFAULT NULL,
  `kodejabatan` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `employee`
--

INSERT INTO `employee` (`id`, `kode`, `nama`, `email`, `kodejabatan`) VALUES
(1, '1010001', 'Kacab Cabang Bandung', 'Test@gmail.com', 'KC'),
(2, '1010002', 'Supervisor Cabang Bandung', 'spv@gmail.com', 'SP'),
(3, '1010003', 'Marketing Eksekutif Bandu', 'me@gmail.com', 'ME');

-- --------------------------------------------------------

--
-- Struktur dari tabel `jabatan`
--

CREATE TABLE `jabatan` (
  `id` int(11) NOT NULL,
  `kode` varchar(2) NOT NULL,
  `Nama` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `jabatan`
--

INSERT INTO `jabatan` (`id`, `kode`, `Nama`) VALUES
(1, 'KC', 'Kepala Cabang'),
(2, 'SP', 'Supervisor'),
(3, 'ME', 'Marketing Eksekutif');

-- --------------------------------------------------------

--
-- Struktur dari tabel `traksaksi`
--

CREATE TABLE `traksaksi` (
  `kodetransaksi` varchar(20) NOT NULL,
  `jenistransaksi` varchar(15) NOT NULL,
  `Tahun` year(4) NOT NULL,
  `TanggalInput` date NOT NULL,
  `kodecabang` varchar(15) NOT NULL,
  `kodekacab` varchar(15) NOT NULL,
  `kodespv` varchar(17) NOT NULL,
  `kodeME` varchar(17) NOT NULL,
  `kodepelanggan` varchar(17) NOT NULL,
  `jumlahsiswa` double NOT NULL,
  `Prediksiharga` double NOT NULL,
  `Rata2exp` int(11) NOT NULL,
  `nominal` float NOT NULL,
  `rabat` float NOT NULL,
  `retur` float NOT NULL,
  `Hpp` float NOT NULL,
  `royalty` float NOT NULL,
  `komisi` float NOT NULL,
  `operasional` float NOT NULL,
  `danataktis` double NOT NULL,
  `pajak` float NOT NULL,
  `dpRabat` double NOT NULL,
  `returnH` float NOT NULL,
  `jumlahtermin` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `traksaksi`
--

INSERT INTO `traksaksi` (`kodetransaksi`, `jenistransaksi`, `Tahun`, `TanggalInput`, `kodecabang`, `kodekacab`, `kodespv`, `kodeME`, `kodepelanggan`, `jumlahsiswa`, `Prediksiharga`, `Rata2exp`, `nominal`, `rabat`, `retur`, `Hpp`, `royalty`, `komisi`, `operasional`, `danataktis`, `pajak`, `dpRabat`, `returnH`, `jumlahtermin`) VALUES
('10120000125052016001', 'BOS', 2016, '2016-05-25', '101', '1010001', '1010002', '1010003', '101200001', 1000, 48000, 2, 100000000, 48, 5, 20, 6, 5, 25, 1000000, 25, 40000000, 12, 4),
('10120000225052016001', 'BOS', 2016, '2016-05-25', '101', '1010001', '1010002', '1010003', '101200002', 1000, 48000, 2, 100000000, 48, 5, 20, 6, 5, 25, 1000000, 25, 40000000, 12, 4);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cabang`
--
ALTER TABLE `cabang`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `detailtransaksi`
--
ALTER TABLE `detailtransaksi`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `jabatan`
--
ALTER TABLE `jabatan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `traksaksi`
--
ALTER TABLE `traksaksi`
  ADD PRIMARY KEY (`kodetransaksi`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cabang`
--
ALTER TABLE `cabang`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `detailtransaksi`
--
ALTER TABLE `detailtransaksi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `jabatan`
--
ALTER TABLE `jabatan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
