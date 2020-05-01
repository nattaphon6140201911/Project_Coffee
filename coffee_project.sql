-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: May 01, 2020 at 05:13 PM
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
(453, 'google', 'M', 'VIP', '5448948155'),
(461, 'yuyi', 'F', 'Other', '8549684421'),
(663, 'yoy', 'F', 'Other', '0123535378'),
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
(33, 'Cappuccino', 40, 'กาแฟคาปูชิโน่จะเป็นการนำเอากาแฟเอสเพรสโซ่ มาผสมกับนม'),
(44, '', 0, '');

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
(1093, '2020-04-23 10:36:19', 101, 1, 200),
(1717, '2020-04-23 09:18:19', 101, 1, 200),
(1919, '2020-04-01 08:48:32', 101, 1, 350),
(2328, '2020-05-01 10:34:53', 461, 1, 190),
(2842, '2020-04-18 08:48:32', 102, 1, 350),
(2935, '2020-05-02 12:02:26', 102, 1, 100),
(3072, '2020-04-23 08:48:32', 103, 1, 400),
(3198, '2020-04-20 08:48:32', 101, 1, 200),
(3348, '2020-04-30 10:45:11', 531, 1, 240),
(4128, '2020-04-30 08:57:45', 102, 1, 300),
(4535, '2020-04-23 09:43:52', 101, 1, 250),
(4869, '2020-04-30 09:51:52', 101, 1, 100),
(5336, '2020-04-23 09:42:13', 101, 1, 300),
(5502, '2020-04-25 12:33:53', 102, 1, 200),
(5836, '2020-05-01 11:47:59', 102, 1, 100),
(5913, '2020-04-23 09:13:57', 101, 1, 100),
(6339, '2020-05-01 10:37:09', 102, 1, 130),
(6377, '2020-05-01 11:49:20', 103, 1, 200),
(6632, '2020-04-23 09:38:28', 101, 1, 300),
(6798, '2020-05-01 11:18:45', 102, 1, 200),
(6834, '2020-04-25 01:16:44', 102, 1, 200),
(7022, '2020-04-10 08:48:32', 103, 1, 50),
(7254, '2020-04-01 08:48:32', 102, 1, 300),
(7622, '2020-05-01 11:45:25', 103, 1, 100),
(7742, '2020-04-24 03:37:44', 102, 3, 100),
(7935, '2020-04-23 10:21:17', 101, 1, 100),
(8134, '2020-04-23 10:30:35', 101, 1, 100),
(8311, '2020-04-24 03:35:13', 103, 1, 100),
(9405, '2020-04-25 01:14:10', 103, 1, 100);

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
(18332, 5836, 22, 50, 2, 100),
(20892, 6377, 11, 50, 2, 100),
(21371, 4128, 33, 50, 2, 100),
(21396, 8311, 11, 50, 2, 100),
(22156, 5502, 11, 50, 2, 100),
(23368, 6632, 33, 50, 2, 100),
(24871, 3072, 33, 50, 4, 200),
(27681, 6632, 11, 50, 2, 100),
(27699, 4535, 22, 50, 2, 100),
(27842, 1919, 11, 50, 3, 150),
(28863, 1717, 11, 50, 2, 100),
(34884, 2328, 11, 50, 2, 100),
(38420, 2328, 33, 40, 1, 40),
(39304, 1093, 22, 50, 2, 100),
(40474, 3072, 22, 50, 2, 100),
(41732, 2935, 11, 50, 2, 100),
(41855, 7254, 33, 50, 2, 100),
(45120, 4128, 11, 50, 2, 100),
(48037, 1093, 11, 50, 2, 100),
(50905, 3348, 33, 45, 2, 90),
(52018, 6834, 11, 50, 2, 100),
(52381, 4128, 22, 50, 2, 100),
(52931, 4869, 11, 50, 2, 100),
(53999, 4535, 11, 50, 2, 100),
(58571, 5502, 22, 50, 2, 100),
(60979, 6339, 33, 40, 2, 80),
(61828, 6377, 22, 50, 2, 100),
(63501, 3198, 33, 50, 2, 100),
(64037, 9405, 11, 50, 2, 100),
(64096, 6632, 22, 50, 2, 100),
(64151, 7022, 11, 50, 1, 50),
(66335, 5336, 22, 50, 2, 100),
(68488, 5336, 11, 50, 2, 100),
(69096, 3198, 11, 50, 2, 100),
(70025, 3348, 22, 50, 1, 50),
(72475, 3348, 11, 50, 2, 100),
(75466, 5336, 33, 50, 2, 100),
(76846, 7742, 11, 50, 2, 100),
(77113, 1919, 22, 50, 2, 100),
(83254, 4535, 33, 50, 1, 50),
(85767, 6798, 11, 50, 2, 100),
(86750, 8134, 11, 50, 2, 100),
(90659, 2842, 11, 50, 3, 150),
(91212, 6339, 22, 50, 1, 50),
(93577, 2328, 22, 50, 1, 50),
(93610, 7622, 11, 50, 2, 100),
(94093, 1919, 33, 50, 2, 100),
(95586, 6798, 22, 50, 2, 100),
(96026, 7254, 11, 50, 2, 100),
(97493, 3072, 11, 50, 2, 100),
(97854, 6834, 33, 50, 2, 100);

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
(1314, '861', 'popy', 'M', '011', 'Manager'),
(2319, '586', 'man', 'F', '099', 'Manager'),
(4273, '407', 'retsdf', 'F', '777', 'Staff'),
(4518, '779', 'wert', 'M', '0088', 'Staff'),
(7381, '347', 'giut', 'M', '333', 'Manager');

-- --------------------------------------------------------

--
-- Table structure for table `staffs1`
--

CREATE TABLE `staffs1` (
  `StaffID.` int(11) NOT NULL,
  `StaffCode` int(20) NOT NULL,
  `StaffName` varchar(100) NOT NULL,
  `Gender` enum('M','F') NOT NULL,
  `StaffLevel` enum('Staff','Manager','Admin') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `staffs1`
--

INSERT INTO `staffs1` (`StaffID.`, `StaffCode`, `StaffName`, `Gender`, `StaffLevel`) VALUES
(1, 123, 'c1', 'F', 'Staff'),
(2, 456, 'coffee2', 'F', 'Manager'),
(3, 789, 'coffee3', 'M', 'Admin'),
(1314, 861, 'popy', 'M', 'Manager'),
(2319, 586, 'man', 'F', 'Manager'),
(4273, 407, 'retsdf', 'F', 'Staff'),
(4518, 779, 'wert', 'M', 'Staff'),
(7381, 347, 'giut', 'M', 'Manager');

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
-- Indexes for table `staffs1`
--
ALTER TABLE `staffs1`
  ADD PRIMARY KEY (`StaffID.`);

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
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `sale00`
--
ALTER TABLE `sale00`
  MODIFY `SaleDetailID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=97855;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `SaleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9946;

--
-- AUTO_INCREMENT for table `sale_details`
--
ALTER TABLE `sale_details`
  MODIFY `SaleDetailID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=97855;

--
-- AUTO_INCREMENT for table `staffs`
--
ALTER TABLE `staffs`
  MODIFY `StaffID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8367;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
