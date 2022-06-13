-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 13, 2022 at 11:42 PM
-- Server version: 10.1.40-MariaDB
-- PHP Version: 7.3.5

--
-- ApacheFriends XAMPP Version 7.3.5
--
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `addressbook`
--

-- --------------------------------------------------------

--
-- Table structure for table `addressbook`
--

CREATE TABLE `addressbook` (
  `domain_id` int(9) UNSIGNED NOT NULL DEFAULT '0',
  `id` int(9) UNSIGNED NOT NULL,
  `firstname` varchar(255) NOT NULL,
  `middlename` varchar(255) NOT NULL,
  `lastname` varchar(255) NOT NULL,
  `nickname` varchar(255) NOT NULL,
  `company` varchar(255) NOT NULL,
  `title` varchar(255) NOT NULL,
  `address` text NOT NULL,
  `addr_long` text,
  `addr_lat` text,
  `addr_status` text,
  `home` text NOT NULL,
  `mobile` text NOT NULL,
  `work` text NOT NULL,
  `fax` text NOT NULL,
  `email` text NOT NULL,
  `email2` text NOT NULL,
  `email3` text NOT NULL,
  `im` text NOT NULL,
  `im2` text NOT NULL,
  `im3` text NOT NULL,
  `homepage` text NOT NULL,
  `bday` tinyint(2) NOT NULL,
  `bmonth` varchar(50) NOT NULL,
  `byear` varchar(4) NOT NULL,
  `aday` tinyint(2) NOT NULL,
  `amonth` varchar(50) NOT NULL,
  `ayear` varchar(4) NOT NULL,
  `address2` text NOT NULL,
  `phone2` text NOT NULL,
  `notes` text NOT NULL,
  `photo` mediumtext,
  `x_vcard` mediumtext,
  `x_activesync` mediumtext,
  `created` datetime DEFAULT NULL,
  `modified` datetime DEFAULT NULL,
  `deprecated` datetime NOT NULL,
  `password` varchar(256) DEFAULT NULL,
  `login` date DEFAULT NULL,
  `role` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `addressbook`
--

INSERT INTO `addressbook` (`domain_id`, `id`, `firstname`, `middlename`, `lastname`, `nickname`, `company`, `title`, `address`, `addr_long`, `addr_lat`, `addr_status`, `home`, `mobile`, `work`, `fax`, `email`, `email2`, `email3`, `im`, `im2`, `im3`, `homepage`, `bday`, `bmonth`, `byear`, `aday`, `amonth`, `ayear`, `address2`, `phone2`, `notes`, `photo`, `x_vcard`, `x_activesync`, `created`, `modified`, `deprecated`, `password`, `login`, `role`) VALUES
(0, 52, 'fname9', 'MiddleOtchestvo9', 'lname9', '', '', '', '', NULL, NULL, NULL, '', '', '', '', '', '', '', '', '', '', '', 0, '-', '', 0, '-', '', '', '', '', '', NULL, NULL, '2020-11-06 16:42:08', '2020-11-06 16:42:08', '0000-00-00 00:00:00', NULL, NULL, NULL),
(0, 53, 'First_modifBytest', 'Otchestvo_modif', 'Last_modifBytest', '', '', '', '', NULL, NULL, NULL, '', '', '', '', '', '', '', '', '', '', '', 0, '-', '', 0, '-', '', '', '', '', '', NULL, NULL, '2020-11-06 16:43:44', '2020-11-06 16:59:50', '0000-00-00 00:00:00', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `address_in_groups`
--

CREATE TABLE `address_in_groups` (
  `domain_id` int(9) UNSIGNED NOT NULL DEFAULT '0',
  `id` int(9) UNSIGNED NOT NULL DEFAULT '0',
  `group_id` int(9) UNSIGNED NOT NULL DEFAULT '0',
  `created` datetime DEFAULT NULL,
  `modified` datetime DEFAULT NULL,
  `deprecated` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `group_list`
--

CREATE TABLE `group_list` (
  `domain_id` int(9) UNSIGNED NOT NULL DEFAULT '0',
  `group_id` int(9) UNSIGNED NOT NULL,
  `group_parent_id` int(9) DEFAULT NULL,
  `created` datetime DEFAULT NULL,
  `modified` datetime DEFAULT NULL,
  `deprecated` datetime NOT NULL,
  `group_name` varchar(255) NOT NULL DEFAULT '',
  `group_header` mediumtext NOT NULL,
  `group_footer` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `group_list`
--

INSERT INTO `group_list` (`domain_id`, `group_id`, `group_parent_id`, `created`, `modified`, `deprecated`, `group_name`, `group_header`, `group_footer`) VALUES
(0, 40, NULL, NULL, NULL, '0000-00-00 00:00:00', 'mmm', 'hhh', 'fff');

-- --------------------------------------------------------

--
-- Table structure for table `month_lookup`
--

CREATE TABLE `month_lookup` (
  `bmonth` varchar(50) NOT NULL DEFAULT '',
  `bmonth_short` char(3) NOT NULL DEFAULT '',
  `bmonth_num` int(2) UNSIGNED NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `month_lookup`
--

INSERT INTO `month_lookup` (`bmonth`, `bmonth_short`, `bmonth_num`) VALUES
('', '', 0),
('January', 'Jan', 1),
('February', 'Feb', 2),
('March', 'Mar', 3),
('April', 'Apr', 4),
('May', 'May', 5),
('June', 'Jun', 6),
('July', 'Jul', 7),
('August', 'Aug', 8),
('September', 'Sep', 9),
('October', 'Oct', 10),
('November', 'Nov', 11),
('December', 'Dec', 12);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `domain_id` int(9) UNSIGNED NOT NULL DEFAULT '0',
  `username` char(128) NOT NULL,
  `md5_pass` char(128) NOT NULL,
  `password_hint` varchar(255) NOT NULL DEFAULT '',
  `sso_facebook_uid` varchar(255) DEFAULT NULL,
  `sso_google_uid` varchar(255) DEFAULT NULL,
  `sso_live_uid` varchar(255) DEFAULT NULL,
  `sso_yahoo_uid` varchar(255) DEFAULT NULL,
  `lastname` varchar(50) NOT NULL DEFAULT '',
  `firstname` varchar(50) NOT NULL DEFAULT '',
  `email` varchar(100) NOT NULL DEFAULT '',
  `phone` varchar(50) NOT NULL DEFAULT '',
  `address1` varchar(100) NOT NULL DEFAULT '',
  `address2` varchar(100) NOT NULL DEFAULT '',
  `city` varchar(80) NOT NULL DEFAULT '',
  `state` varchar(20) NOT NULL DEFAULT '',
  `zip` varchar(20) NOT NULL DEFAULT '',
  `country` varchar(50) NOT NULL DEFAULT '',
  `master_code` char(128) NOT NULL,
  `confirmation_code` char(128) DEFAULT NULL,
  `pass_reset_code` char(128) DEFAULT NULL,
  `status` char(128) NOT NULL DEFAULT 'NEW' COMMENT 'New, Ready, Blocked',
  `trials` int(11) NOT NULL DEFAULT '0',
  `created` datetime DEFAULT NULL,
  `modified` datetime DEFAULT NULL,
  `deprecated` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `addressbook`
--
ALTER TABLE `addressbook`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `address_in_groups`
--
ALTER TABLE `address_in_groups`
  ADD PRIMARY KEY (`group_id`,`id`);

--
-- Indexes for table `group_list`
--
ALTER TABLE `group_list`
  ADD PRIMARY KEY (`group_id`);

--
-- Indexes for table `month_lookup`
--
ALTER TABLE `month_lookup`
  ADD PRIMARY KEY (`bmonth_num`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `addressbook`
--
ALTER TABLE `addressbook`
  MODIFY `id` int(9) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

--
-- AUTO_INCREMENT for table `group_list`
--
ALTER TABLE `group_list`
  MODIFY `group_id` int(9) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
