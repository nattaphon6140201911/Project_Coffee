-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Apr 23, 2020 at 02:47 PM
-- Server version: 8.0.17
-- PHP Version: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `coffee_project`
--

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `CustomerID` int(11) NOT NULL,
  `CustomerName` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Gender` enum('M','F') CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `CustomerType` enum('Member','VIP','Other') CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `CustomerTelNo` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`CustomerID`, `CustomerName`, `Gender`, `CustomerType`, `CustomerTelNo`) VALUES
(101, 'Top', 'F', 'Member', '0123456789'),
(102, 'You', 'M', 'VIP', '0223456789'),
(103, 'Jop', 'M', 'Other', '0113456789'),
(872, 'rew', 'M', 'VIP', '2644847845');

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `ProductID` int(11) NOT NULL,
  `ProductName` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Price` float NOT NULL,
  `ProductDetail` text CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`ProductID`, `ProductName`, `Price`, `ProductDetail`) VALUES
(11, 'Espresso', 50, 'เป็นการใช้เมล็ดกาแฟบด เข้าเครื่องชงกาแฟที่จะใช้แรงอัดไอน้ำให้ผ่านเมล็ดกาแฟส่งกลิ่นหอมๆ และเข้มข้น'),
(22, 'Americano', 50, 'คล้ายๆ กับเอสเพรสโซ่ แต่จะอ่อนกว่าเล็กน้อย'),
(33, 'Cappuccino', 50, 'กาแฟคาปูชิโน่จะเป็นการนำเอากาแฟเอสเพรสโซ่ มาผสมกับนม');

-- --------------------------------------------------------

--
-- Table structure for table `sale00`
--

CREATE TABLE `sale00` (
  `SaleDetailID` int(11) NOT NULL,
  `ProductName` varchar(100) NOT NULL,
  `Price` float NOT NULL,
  `Amount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `SaleID` int(11) NOT NULL,
  `SaleDateTime` datetime NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `StaffID` int(11) NOT NULL,
  `GrandTotal` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`SaleID`, `SaleDateTime`, `CustomerID`, `StaffID`, `GrandTotal`) VALUES
(1717, '2020-04-23 09:18:19', 101, 1, 200),
(1919, '2020-04-01 08:48:32', 101, 1, 350),
(2842, '2020-04-18 08:48:32', 102, 1, 350),
(3072, '2020-04-23 08:48:32', 103, 1, 400),
(3198, '2020-04-20 08:48:32', 101, 1, 200),
(4535, '2020-04-23 09:43:52', 101, 1, 250),
(5336, '2020-04-23 09:42:13', 101, 1, 300),
(5913, '2020-04-23 09:13:57', 101, 1, 100),
(6632, '2020-04-23 09:38:28', 101, 1, 300),
(7022, '2020-04-10 08:48:32', 103, 1, 50),
(7254, '2020-04-01 08:48:32', 102, 1, 300);

-- --------------------------------------------------------

--
-- Table structure for table `sale_details`
--

CREATE TABLE `sale_details` (
  `SaleDetailID` int(11) NOT NULL,
  `SaleID` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `Price` float NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Amount` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `sale_details`
--

INSERT INTO `sale_details` (`SaleDetailID`, `SaleID`, `ProductID`, `Price`, `Quantity`, `Amount`) VALUES
(10412, 1717, 22, 50, 2, 100),
(11073, 2842, 33, 50, 1, 50),
(14501, 2842, 22, 50, 3, 150),
(16968, 5913, 11, 50, 2, 100),
(17999, 7254, 22, 50, 2, 100),
(23368, 6632, 33, 50, 2, 100),
(24871, 3072, 33, 50, 4, 200),
(27681, 6632, 11, 50, 2, 100),
(27699, 4535, 22, 50, 2, 100),
(27842, 1919, 11, 50, 3, 150),
(28863, 1717, 11, 50, 2, 100),
(40474, 3072, 22, 50, 2, 100),
(41855, 7254, 33, 50, 2, 100),
(53999, 4535, 11, 50, 2, 100),
(63501, 3198, 33, 50, 2, 100),
(64096, 6632, 22, 50, 2, 100),
(64151, 7022, 11, 50, 1, 50),
(66335, 5336, 22, 50, 2, 100),
(68488, 5336, 11, 50, 2, 100),
(69096, 3198, 11, 50, 2, 100),
(75466, 5336, 33, 50, 2, 100),
(77113, 1919, 22, 50, 2, 100),
(83254, 4535, 33, 50, 1, 50),
(90659, 2842, 11, 50, 3, 150),
(94093, 1919, 33, 50, 2, 100),
(96026, 7254, 11, 50, 2, 100),
(97493, 3072, 11, 50, 2, 100);

-- --------------------------------------------------------

--
-- Table structure for table `staffs`
--

CREATE TABLE `staffs` (
  `StaffID` int(11) NOT NULL,
  `StaffCode` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `StaffName` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Gender` enum('M','F') CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `StaffPassword` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `StaffLevel` enum('Staff','Manager','Admin') CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `staffs`
--

INSERT INTO `staffs` (`StaffID`, `StaffCode`, `StaffName`, `Gender`, `StaffPassword`, `StaffLevel`) VALUES
(1, '123', 'c1', 'F', '001', 'Staff'),
(2, '456', 'coffee2', 'F', '002', 'Manager'),
(3, '789', 'coffee3', 'M', '003', 'Admin'),
(2129, '234', 'rew', 'M', '004', 'Staff'),
(5210, '675', 'toot', 'M', '123456', 'Staff');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ProductID`);

--
-- Indexes for table `sale00`
--
ALTER TABLE `sale00`
  ADD PRIMARY KEY (`SaleDetailID`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`SaleID`);

--
-- Indexes for table `sale_details`
--
ALTER TABLE `sale_details`
  ADD PRIMARY KEY (`SaleDetailID`);

--
-- Indexes for table `staffs`
--
ALTER TABLE `staffs`
  ADD PRIMARY KEY (`StaffID`),
  ADD UNIQUE KEY `StaffCode` (`StaffCode`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `CustomerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=893;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `sale00`
--
ALTER TABLE `sale00`
  MODIFY `SaleDetailID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=97494;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `SaleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9946;

--
-- AUTO_INCREMENT for table `sale_details`
--
ALTER TABLE `sale_details`
  MODIFY `SaleDetailID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=97494;

--
-- AUTO_INCREMENT for table `staffs`
--
ALTER TABLE `staffs`
  MODIFY `StaffID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5211;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
