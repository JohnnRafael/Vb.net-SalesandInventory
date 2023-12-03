/*
SQLyog Ultimate v8.55 
MySQL - 5.5.5-10.4.22-MariaDB : Database - salesandinventory
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`salesandinventory` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `salesandinventory`;

/*Table structure for table `bank` */

DROP TABLE IF EXISTS `bank`;

CREATE TABLE `bank` (
  `bankID` int(10) NOT NULL AUTO_INCREMENT,
  `bankName` varchar(255) NOT NULL,
  PRIMARY KEY (`bankID`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Data for the table `bank` */

insert  into `bank`(`bankID`,`bankName`) values (1,'Metrobank'),(2,'LandBank'),(3,'BDO'),(4,'BPI'),(5,'Unibank'),(6,'BSP');

/*Table structure for table `cheque` */

DROP TABLE IF EXISTS `cheque`;

CREATE TABLE `cheque` (
  `cheqID` int(10) NOT NULL AUTO_INCREMENT,
  `cheqNo` bigint(20) NOT NULL,
  `amount` decimal(12,2) NOT NULL,
  `bankID` int(10) NOT NULL,
  PRIMARY KEY (`cheqID`)
) ENGINE=MyISAM AUTO_INCREMENT=38 DEFAULT CHARSET=latin1;

/*Data for the table `cheque` */

insert  into `cheque`(`cheqID`,`cheqNo`,`amount`,`bankID`) values (1,555555,'8.00',1),(2,44444,'7.00',1),(3,41231312,'8.00',1),(4,412313,'7.00',1),(5,65345345,'8.00',1),(6,54123,'8.00',1),(7,15123123,'5.00',1),(8,15123123,'5.00',1),(9,4234234,'14.00',1),(10,4234234,'14.00',1),(11,412384,'9.00',1),(12,44123123,'9.00',1),(13,31534,'9.00',1),(14,4534123,'9.00',1),(15,41231,'9370.00',1),(16,41231,'9370.00',1),(17,555555,'7044.00',1),(18,44444,'23300.00',1),(19,44444,'22000.00',1),(20,44444,'23300.00',1),(21,555534,'6500.00',1),(22,555534,'6500.00',1),(23,5531,'5500.00',1),(24,4444,'5500.00',1),(25,4444,'5500.00',1),(26,4444,'5500.00',1),(27,4443343,'20000.00',1),(28,5123123,'20000.00',1),(29,53535353,'20000.00',1),(30,535353,'5000.00',1),(31,535353,'5500.00',1),(32,535353,'5500.00',1),(33,45123,'5500.00',1),(34,5123123,'7500.00',1),(35,5123123,'7500.00',1),(36,535353,'7500.00',1),(37,43434343,'7500.00',1);

/*Table structure for table `client` */

DROP TABLE IF EXISTS `client`;

CREATE TABLE `client` (
  `CustID` int(12) unsigned NOT NULL AUTO_INCREMENT,
  `Iddetails` bigint(15) NOT NULL,
  `lname` varchar(255) NOT NULL,
  `fname` varchar(255) NOT NULL,
  `mi` varchar(255) DEFAULT NULL,
  `pmethod` int(12) NOT NULL,
  `Street` varchar(255) NOT NULL,
  `Brgy` varchar(255) NOT NULL,
  `city` varchar(255) NOT NULL,
  `contactno` int(12) NOT NULL,
  `emailadd` varchar(255) NOT NULL,
  `status` int(12) DEFAULT NULL,
  PRIMARY KEY (`CustID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4;

/*Data for the table `client` */

insert  into `client`(`CustID`,`Iddetails`,`lname`,`fname`,`mi`,`pmethod`,`Street`,`Brgy`,`city`,`contactno`,`emailadd`,`status`) values (1,20220614001,'TUBERO','KRAM','B.',2,'BANTUTIN ST.','BRGY SANTIMO','QUEZON CITY',9454576,'KRAM@ROCKETMAIL.COM',1),(2,20220614002,'BENKONG','MARK','R. ',2,'BINGO ST. ','BRGY HEHA','QUEZON CITY',95457651,'MARK@ROCKETMAIL.COM',1),(3,202206150003,'TUGANO','JOHN RAFAEL','R',2,'SAMUEL 3 ','BRGY PASONG TAMO','QUEZON CITY',945164572,'JOHNNTUGANO@GMAIL.COM',1),(4,202206160004,'MARKIN','JAMSON','M',1,'MAKABILANG BUHAY ST.','BRGY STO ANYO','QUEZON CITY',976412488,'NARKIN@GMAIL.COM',1),(5,202206160005,'CLEMENTE','EDWARD','M.',1,'MANIMAN STREET','BRGY KALIWAN','MARIKINA CITY',978463215,'EDWARD@GMAIL.COM',1),(6,202206160006,'KELAN','DENMA','R',1,'MANDIJO ST','BRGY 122','CALOOCAN CITY',978746513,'DEM@GMAIL.COM',1),(7,202206160007,'MAMANSAG','JAN MARC','M',1,'MALIGAYA ST','BRGY STO NINO','QUEZON CITY',888888888,'JANMARC@GMAIL.COM',1),(8,202210060008,'TIAMO','RIAKIMU','R.',2,'BALANGAO ST.','BRGY SALO SALO','CALIBAO CITY',2147483647,'RIAKUMU@GMAIL.COM',1),(9,202210060009,'INAOM','DEMON','N',1,'3 NAMO','BRGY SAMO','KAMO CITY',2147483647,'JNANA@GMAIL.COM',1),(10,202210060010,'MARIK','RIAKIMU','M',2,'NEJO ST','BRGY MAJO','DEJO CITY',99999999,'NAKIMUR@GMAIL.COM',1);

/*Table structure for table `clientpay` */

DROP TABLE IF EXISTS `clientpay`;

CREATE TABLE `clientpay` (
  `pmethodid` int(12) NOT NULL AUTO_INCREMENT,
  `pmethod` varchar(255) NOT NULL,
  PRIMARY KEY (`pmethodid`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `clientpay` */

insert  into `clientpay`(`pmethodid`,`pmethod`) values (1,'50% Down Payment'),(2,'Fully Paid'),(3,'3 Months Before Pay');

/*Table structure for table `clientstatus` */

DROP TABLE IF EXISTS `clientstatus`;

CREATE TABLE `clientstatus` (
  `clienstatusID` int(12) NOT NULL AUTO_INCREMENT,
  `status` varchar(255) NOT NULL,
  PRIMARY KEY (`clienstatusID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `clientstatus` */

insert  into `clientstatus`(`clienstatusID`,`status`) values (1,'ACTIVE'),(2,'NOT ACTIVE');

/*Table structure for table `custtransaction_details` */

DROP TABLE IF EXISTS `custtransaction_details`;

CREATE TABLE `custtransaction_details` (
  `custtransdetailsId` int(10) NOT NULL AUTO_INCREMENT,
  `Discount` double(10,2) NOT NULL,
  `amountTendered` double(10,2) NOT NULL,
  `totaDueAmount` double(10,2) NOT NULL,
  `amountChange` double(10,2) NOT NULL,
  `tDate` varchar(50) NOT NULL,
  `transNo` varchar(50) NOT NULL,
  `cashierId` int(10) NOT NULL,
  `isPaid` int(10) DEFAULT NULL,
  PRIMARY KEY (`custtransdetailsId`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `custtransaction_details` */

/*Table structure for table `employee` */

DROP TABLE IF EXISTS `employee`;

CREATE TABLE `employee` (
  `empID` int(12) NOT NULL AUTO_INCREMENT,
  `fname` varchar(255) NOT NULL,
  `mname` varchar(255) DEFAULT NULL,
  `lname` varchar(255) NOT NULL,
  `dob` date NOT NULL,
  `uname` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `lvl_id` int(12) NOT NULL,
  `date_in` date DEFAULT NULL,
  `isActive` int(12) DEFAULT NULL,
  PRIMARY KEY (`empID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `employee` */

insert  into `employee`(`empID`,`fname`,`mname`,`lname`,`dob`,`uname`,`password`,`lvl_id`,`date_in`,`isActive`) values (1,'JOHN RAFAEL','R','TUGANO','1999-12-08','JOHN','+3Z9MZvzxBM=',3,'2022-11-25',1),(2,'JONEL','','MACASA','1999-02-16','JONEL','o3q15R1RkqE=',2,'2022-11-25',1);

/*Table structure for table `items` */

DROP TABLE IF EXISTS `items`;

CREATE TABLE `items` (
  `itemid` int(12) NOT NULL AUTO_INCREMENT,
  `itemcode` varchar(255) NOT NULL,
  `typeid` int(12) NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `price` double(9,2) NOT NULL,
  `UnitP` double(9,2) NOT NULL,
  PRIMARY KEY (`itemid`),
  UNIQUE KEY `itemid` (`itemid`)
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=utf8mb4;

/*Data for the table `items` */

insert  into `items`(`itemid`,`itemcode`,`typeid`,`Description`,`price`,`UnitP`) values (1,'JPC-001',1,'W45 X D50 XH 75',3600.00,4500.00),(2,'MBC-3112',5,'H120 X D45 X W50',5500.00,7500.00),(3,'OFT-16000',6,'L160 X W80 X H75',21000.00,23000.00),(4,'OFT-10111',7,'L100 X W50 X H75',5000.00,6900.00),(5,'CST-D96022',9,'L100 X W54 X H74',8000.00,9500.00),(6,'OFT-8140',8,'L280 X W120 X H75',28000.00,35000.00),(7,'CFT-24000',2,'L420 X W120 X H75',18000.00,24000.00),(8,'CST- D96144',9,'L120 X W52 X H74',9000.00,12000.00),(9,'DTR-3600',13,'L70 X W70',5500.00,7500.00),(10,'YT-6319',10,'L100 X W76 X H56',7600.00,8500.00),(11,'FT-PR150',11,'L150 X W70 X H75',3500.00,5800.00),(12,'FT-PR1200',11,'L120 X W60 X H75',3500.00,5500.00),(13,'FT-7306',12,'L120 X W40 X H75',4000.00,5000.00),(14,'DT-P112',13,'L120 X W40',7700.00,9700.00),(15,'JL-59',14,'W60 X L69',3600.00,4600.00),(16,'DT-A209',15,'W125 X L75',7500.00,9500.00),(17,'DT-A9107',16,'L150 X W90 X H75',10000.00,12000.00),(18,'CT-502',17,'L105 X W55 X H42',3000.00,5000.00),(19,'TV-258',18,'L112 X W43 X H136',4400.00,8800.00),(20,'C-BD2089',19,'LEATHERETTE',5000.00,9200.00),(21,'C-BD6016',19,'LEATHERETTE',7800.00,8800.00),(22,'C-BNH301',20,'MESH',8000.00,9100.00),(23,'C-NH168',20,'MESH',8000.00,9100.00),(24,'C-NL382',20,'MESH',4800.00,5700.00),(25,'C-604G',21,'CLERICAL',1850.00,3500.00),(26,'C-609',21,'CLERICAL',2000.00,4500.00),(27,'VC-NL315',22,'L47 X W48 X H94',3400.00,4800.00),(28,'VC-3028',22,'L43 X W45 X H82',2800.00,3900.00),(29,'VC-282',23,'L47 X W47 X H94',7500.00,8000.00),(30,'C-303',23,'L50 X W50 X H103',3350.00,4950.00),(31,'SFC-G102',24,'L90 X W45 X H183',14000.00,16500.00),(32,'SFC-KM13',25,'L90 X W40 X H185',12000.00,18000.00),(33,'SFC-052-4',26,'L44.5 X W62 X H133',11000.00,15000.00),(34,'BKS-908',27,'L120 X W30 X H180',6700.00,10400.00),(35,'MT-1224',28,'L120 X W60 X H76',5000.00,10000.00),(36,'WLS-067',29,'L120 X W46 X H183',7500.00,9500.00),(37,'SQ-1709(2.4M)',2,'L240 X W120 X H75',15000.00,18000.00),(38,'SQ-1709(3.2M)',2,'L320 X W120 X H75',18000.00,23000.00),(39,'CTBT46015',30,'L80 X W75',4500.00,6000.00),(40,'SQ 1707',31,'L240 X W120 X H75',25000.00,30000.00),(41,'CT 1802',32,'L60X W40 X H123',2500.00,3500.00),(42,'GC5STR',33,'L286 X W57 X H80',10000.00,14000.00),(43,'001C2JNSX',34,'L32 X W41 X H45',1550.00,3500.00),(44,'100CJNSX',34,'L56 X W57 X H86',2000.00,4000.00),(45,'803BKONSX',35,'L44 X W57 X H126',4500.00,6500.00),(46,'801-2FM',36,'L53 X W40 X H80',2000.00,4100.00),(47,'116FM',36,'L53 X W50 X H90',2500.00,4000.00),(48,'815HLPRX',37,'L60 X W56 X H128',9600.00,11800.00),(49,'YS-906',37,'L57 X W56 X H121',8000.00,9000.00),(50,'6202',38,'L120 X W38 X H80',6700.00,7700.00),(51,'WLS-H4',25,'L90 X W50 X H185',8000.00,15000.00),(52,'SH2',39,'L64 X W56 X H115-124',3200.00,6600.00),(53,'SH1-BW',39,'L64 X W58 X H115-124',3100.00,6300.00),(54,'SH2-B',39,'L64 X W56 X H42-51',3000.00,6100.00),(55,'BC-EIFFEL',19,'L72 X W59 X H133-141',15000.00,20000.00),(56,'BC-EIFFEL (B)',19,'L72 X W59 X H133-141',16000.00,19000.00),(57,'BC-GRAND',19,'L61.5 X W59.5-78.5 X H112-128',14800.00,15500.00),(58,'STC-A08',40,'',2550.00,4100.00),(59,'STC-818A',40,'',1600.00,3600.00),(60,'GS-02AD',41,'',2500.00,4500.00),(61,'PB-020',42,'',3500.00,7500.00),(62,'PB-004',42,'',3500.00,7500.00),(63,'HBC-2022',43,'W120 XD60 X H75',3500.00,7500.00),(64,'781-444',4,'',2500.00,3000.00),(65,'XXX-012',2,'W120 X D60 X H75',5500.00,8500.00),(66,'SAMPLE-123',3,'SAMPLE123',5500.00,6500.00),(67,'SAMMM',3,'12323',2200.00,3500.00),(68,'AAA',1,'AAA',1111.00,1111.00),(69,'PARTITION-SIDEPANEL',48,'H120 X W60',3500.00,4500.00),(70,'PARTITION-FRONTPANEL',48,'H120 X W100',4500.00,5500.00),(71,'PARTITION-TABLE',48,'W100 X D60',2500.00,3500.00);

/*Table structure for table `itemtype` */

DROP TABLE IF EXISTS `itemtype`;

CREATE TABLE `itemtype` (
  `typeid` int(12) NOT NULL AUTO_INCREMENT,
  `ItemType` varchar(255) NOT NULL,
  PRIMARY KEY (`typeid`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8mb4;

/*Data for the table `itemtype` */

insert  into `itemtype`(`typeid`,`ItemType`) values (1,'MOBILE PEDESTAL'),(2,'CONFERENCE TABLE'),(3,'STUDY TABLE'),(4,'HIGH BACK CHAIR'),(5,'MID BACK CHAIR'),(6,'EXECUTIVE TABLE'),(7,'OFFICE TABLE'),(8,'OFFICE TABLE WITH MOBILE DRAWER'),(9,'COMPUTER DESK WITH METAL FRAME'),(10,'COMPUTER STUDY TABLE'),(11,'FOLDING PLASTIC TABLE'),(12,'TRAINING TABLE'),(13,'COFFEE TABLE'),(14,'ALUMINUM TABLE & CHAIRS'),(15,'4 SEATING DINING TABLE'),(16,'6 SEATING DINING TABLE'),(17,'CENTER & SIDE TABLE'),(18,'TV STAND WITH MOUNT'),(19,'EXECUTIVE CHAIR'),(20,'MESH CHAIR'),(21,'CLERICAL CHAIR'),(22,'VISITOR\'S CHAIR'),(23,'LEATHERETTE VISITOR\'S CHAIR'),(24,'STEEL LOCKER'),(25,'STEEL CABINET'),(26,'FILING CABINET'),(27,'BOOK CASE'),(28,'METAL OFFICE TABLE'),(29,'OFFICE FIXTURES'),(30,'MINI CONFERENCE'),(31,'WORKSTATION'),(32,'COMPUTER TABLE'),(33,'GANG CHAIR'),(34,'OFFICE CHAIR'),(35,'OFFICE TELLER CHAIR'),(36,'STACKABLE CHAIR'),(37,'GAMING CHAIR'),(38,'HOME FURNITURE'),(39,'SUPREME'),(40,'CHROME PLATED STOOL'),(41,'STUDENT CHAIR'),(42,'PARK BENCH'),(43,'OFFICES TABLES'),(44,'CHROME PLATED STOOLS'),(45,'OFFICE TABLEE'),(46,'CONFERENCE TABLEE'),(47,'STEEL LOCKERR'),(48,'PARTITION');

/*Table structure for table `modeofp` */

DROP TABLE IF EXISTS `modeofp`;

CREATE TABLE `modeofp` (
  `mopid` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `mopname` varchar(255) NOT NULL,
  PRIMARY KEY (`mopid`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `modeofp` */

insert  into `modeofp`(`mopid`,`mopname`) values (1,'50% DownPayment'),(2,'Full Payment'),(3,'Full Payment After Receiving the Item');

/*Table structure for table `payment` */

DROP TABLE IF EXISTS `payment`;

CREATE TABLE `payment` (
  `paymentid` int(12) NOT NULL AUTO_INCREMENT,
  `paymenttype` varchar(255) NOT NULL,
  `paymentdetails` varchar(255) NOT NULL,
  `Amount` double(10,2) NOT NULL,
  `transno` varchar(155) NOT NULL,
  `clientid` varchar(255) NOT NULL,
  `status` int(12) NOT NULL,
  PRIMARY KEY (`paymentid`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

/*Data for the table `payment` */

insert  into `payment`(`paymentid`,`paymenttype`,`paymentdetails`,`Amount`,`transno`,`clientid`,`status`) values (1,'1','',7625.00,'202211220001','202210060010',1),(2,'1','',875.00,'202211220002','202210060010',1),(3,'2','0985812354',30000.00,'202211220002','202210060010',1),(4,'3','097561235',1000.00,'202211220002','202210060010',1),(5,'1','',500.00,'202211220003','202210060010',1),(6,'2','55555',500.00,'202211220003','202210060010',1),(7,'3','44444',500.00,'202211220003','202210060010',1),(8,'4','312355123',5000.00,'202211220003','202210060010',1),(9,'1','',6125.00,'202211220003','202210060010',1);

/*Table structure for table `payment_copy` */

DROP TABLE IF EXISTS `payment_copy`;

CREATE TABLE `payment_copy` (
  `paymentid` int(12) NOT NULL AUTO_INCREMENT,
  `paymenttype` varchar(255) NOT NULL,
  `paymentdetails` varchar(255) NOT NULL,
  `Amount` double(10,2) NOT NULL,
  `transno` varchar(155) NOT NULL,
  `clientid` varchar(255) NOT NULL,
  `status` int(12) NOT NULL,
  PRIMARY KEY (`paymentid`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

/*Data for the table `payment_copy` */

insert  into `payment_copy`(`paymentid`,`paymenttype`,`paymentdetails`,`Amount`,`transno`,`clientid`,`status`) values (1,'1','',500.00,'202211220001','202206160005',1),(2,'2','09595959',500.00,'202211220001','202206160005',1),(3,'1','',50000.00,'202211220001','202206160005',1),(4,'1','',1000.00,'202211220002','202206160004',0);

/*Table structure for table `paymenttype` */

DROP TABLE IF EXISTS `paymenttype`;

CREATE TABLE `paymenttype` (
  `paymentid` int(10) NOT NULL AUTO_INCREMENT,
  `paymentname` varchar(155) NOT NULL,
  PRIMARY KEY (`paymentid`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

/*Data for the table `paymenttype` */

insert  into `paymenttype`(`paymentid`,`paymentname`) values (1,'Cash'),(2,'Gcash'),(3,'Paymaya'),(4,'Cheque');

/*Table structure for table `payy` */

DROP TABLE IF EXISTS `payy`;

CREATE TABLE `payy` (
  `payID` int(10) NOT NULL AUTO_INCREMENT,
  `mobilenum` int(11) NOT NULL,
  `amount` double(10,2) NOT NULL,
  `onlineID` int(12) NOT NULL,
  PRIMARY KEY (`payID`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4;

/*Data for the table `payy` */

insert  into `payy`(`payID`,`mobilenum`,`amount`,`onlineID`) values (1,2147483647,8.00,2),(2,2147483647,5.00,1),(3,2147483647,8.00,1),(4,512354123,8.00,1),(5,2147483647,3870.00,1),(6,2147483647,9000.00,1),(7,2147483647,9525.00,1),(8,412313123,6500.00,1),(9,1235324,5500.00,1),(10,4123134,5500.00,1),(11,5123123,6500.00,1),(12,55555,7500.00,1),(13,535353,7500.00,1);

/*Table structure for table `po_temp` */

DROP TABLE IF EXISTS `po_temp`;

CREATE TABLE `po_temp` (
  `poiddetailstemp` int(12) NOT NULL AUTO_INCREMENT,
  `suppid` int(12) NOT NULL,
  `sup_cname` varchar(255) NOT NULL,
  `itemid` int(12) NOT NULL,
  `itemcode` varchar(255) NOT NULL,
  `itemtype` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  `price` double(10,2) NOT NULL,
  `qty` int(12) NOT NULL,
  `status` int(12) NOT NULL DEFAULT 1,
  `ordernum` varchar(12) NOT NULL,
  PRIMARY KEY (`poiddetailstemp`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

/*Data for the table `po_temp` */

/*Table structure for table `porder` */

DROP TABLE IF EXISTS `porder`;

CREATE TABLE `porder` (
  `porderid` int(12) NOT NULL AUTO_INCREMENT,
  `itemid` int(12) NOT NULL,
  `quantity` int(12) NOT NULL,
  `porder_bodyid` int(12) NOT NULL,
  PRIMARY KEY (`porderid`)
) ENGINE=InnoDB AUTO_INCREMENT=121 DEFAULT CHARSET=utf8mb4;

/*Data for the table `porder` */

insert  into `porder`(`porderid`,`itemid`,`quantity`,`porder_bodyid`) values (1,1,12,1),(2,1,12,2),(3,1,15,3),(4,1,12,4),(5,1,12,5),(6,1,2,6),(7,2,15,7),(8,2,12,8),(9,2,12,9),(10,1,3,9),(11,17,13,10),(12,59,17,11),(13,57,7,12),(14,57,11,13),(15,10,15,14),(16,45,8,15),(17,44,11,16),(18,55,7,17),(19,11,11,18),(20,45,4,19),(21,45,18,20),(22,40,2,21),(23,37,4,22),(24,61,25,23),(25,42,17,24),(26,41,11,25),(27,39,17,26),(28,38,19,27),(29,36,15,28),(30,35,19,29),(31,4,24,30),(32,5,16,31),(33,6,19,32),(34,7,24,33),(35,8,31,34),(36,9,22,35),(37,12,13,36),(38,13,16,37),(39,14,33,38),(40,14,9,39),(41,15,16,40),(42,19,26,41),(43,21,4,42),(44,22,12,43),(45,22,33,44),(46,23,22,45),(47,24,24,46),(48,1,42,47),(49,27,14,48),(50,28,12,49),(51,29,16,50),(52,31,16,51),(53,30,15,52),(54,26,23,53),(55,1,16,54),(56,48,7,55),(57,54,5,56),(58,53,13,57),(59,62,1,58),(60,49,17,59),(61,60,4,60),(62,1,16,61),(63,52,19,62),(64,58,11,63),(65,57,12,64),(66,56,15,64),(67,2,12,64),(68,55,20,64),(69,63,25,64),(70,57,12,65),(71,59,12,66),(72,38,12,66),(73,55,12,66),(75,59,2,67),(76,60,2,67),(77,41,3,67),(78,8,12,68),(79,62,2,69),(80,57,1,69),(81,58,2,69),(82,55,1,69),(83,29,2,69),(84,6,2,69),(85,57,2,70),(86,63,2,70),(87,62,2,71),(88,19,2,72),(89,64,2,72),(90,64,2,73),(91,67,2,74),(92,63,2,75),(93,60,2,76),(94,65,2,76),(95,12,1,77),(96,60,2,78),(97,1,2,79),(98,1,2,80),(99,1,2,81),(100,16,5,82),(101,10,2,82),(102,2,4,82),(103,8,4,82),(104,14,5,82),(105,16,2,83),(106,2,2,84),(107,2,2,85),(108,10,2,85),(109,16,7,86),(110,16,7,87),(111,14,2,87),(112,16,2,88),(113,18,4,88),(114,9,5,89),(115,18,5,90),(116,4,4,90),(117,30,5,91),(118,10,5,92),(119,9,2,92),(120,3,5,93);

/*Table structure for table `porder_details` */

DROP TABLE IF EXISTS `porder_details`;

CREATE TABLE `porder_details` (
  `porder_bodyid` int(10) NOT NULL AUTO_INCREMENT,
  `ponum` varchar(150) NOT NULL,
  `sup_id` varchar(255) NOT NULL,
  `numberofitem` int(12) NOT NULL,
  `expecdate` date NOT NULL,
  `dateissue` date NOT NULL,
  `createdby` int(12) NOT NULL,
  `statid` int(12) NOT NULL,
  PRIMARY KEY (`porder_bodyid`)
) ENGINE=InnoDB AUTO_INCREMENT=94 DEFAULT CHARSET=utf8mb4;

/*Data for the table `porder_details` */

insert  into `porder_details`(`porder_bodyid`,`ponum`,`sup_id`,`numberofitem`,`expecdate`,`dateissue`,`createdby`,`statid`) values (1,'2022-0001','globe',1,'2022-05-28','2022-05-28',1,2),(2,'2022-0002','globe',1,'2022-05-28','2022-05-28',1,2),(3,'2022-0003','GLOBE',1,'2022-05-28','2022-05-28',1,2),(4,'2022-0004','GLOBE',1,'2022-06-21','2022-06-07',2,2),(5,'2022-0005','TM',1,'2022-06-07','2022-06-07',1,2),(6,'2022-0006','GLOBE',1,'2022-06-22','2022-06-07',2,2),(7,'2022-0007','TNT',1,'2022-06-15','2022-06-08',1,2),(8,'2022-0008','GLOBE',1,'2022-06-11','2022-06-11',1,2),(9,'2022-0009','GLOBE',2,'2022-06-14','2022-06-13',2,2),(10,'2022-0010','FURNITURE EXCHANGE',1,'2022-06-16','2022-06-16',1,2),(11,'2022-0011','INLAND FURNITURE',1,'2022-06-16','2022-06-16',2,2),(12,'2022-0012','INTACT FURNITURE',1,'2022-06-16','2022-06-16',1,2),(13,'2022-0013','ENTITY FURNITURE',1,'2022-06-16','2022-06-16',1,2),(14,'2022-0014','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',2,2),(15,'2022-0015','FURNITURE WEST',1,'2022-06-16','2022-06-16',1,2),(16,'2022-0016','GLOBE',1,'2022-06-16','2022-06-16',1,2),(17,'2022-0017','FURNITURE EXCHANGE',1,'2022-06-16','2022-06-16',1,2),(18,'2022-0018','FURNITURE EXCHANGE',1,'2022-06-16','2022-06-16',1,2),(19,'2022-0019','INTACT FURNITURE',1,'2022-06-19','2022-06-16',1,2),(20,'2022-0020','ENTITY FURNITURE',1,'2022-06-20','2022-06-16',2,2),(21,'2022-0021','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',3,2),(22,'2022-0022','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',5,2),(23,'2022-0023','PALMTREE FURNITURE',1,'2022-06-28','2022-06-16',4,2),(24,'2022-0024','VERTIX FURNITURE',1,'2022-06-20','2022-06-16',2,2),(25,'2022-0025','ENTITY FURNITURE',1,'2022-06-16','2022-06-16',3,2),(26,'2022-0026','INTACT FURNITURE',1,'2022-06-16','2022-06-16',6,2),(27,'2022-0027','FURNITURE EYES',1,'2022-06-16','2022-06-16',4,2),(28,'2022-0028','FURNITURE EYES',1,'2022-06-16','2022-06-16',5,2),(29,'2022-0029','FURNITURE EXCHANGE',1,'2022-06-16','2022-06-16',1,2),(30,'2022-0030','VERTIX FURNITURE',1,'2022-06-16','2022-06-16',1,2),(31,'2022-0031','INTACT FURNITURE',1,'2022-06-16','2022-06-16',2,2),(32,'2022-0032','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',1,2),(33,'2022-0033','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',1,2),(34,'2022-0034','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',1,2),(35,'2022-0035','FURNITURE SPOTS',1,'2022-06-20','2022-06-16',4,2),(36,'2022-0036','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',3,2),(37,'2022-0037','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',2,2),(38,'2022-0038','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',1,2),(39,'2022-0039','INLAND FURNITURE',1,'2022-06-16','2022-06-16',5,2),(40,'2022-0040','INLAND FURNITURE',1,'2022-06-16','2022-06-16',2,2),(41,'2022-0041','INLAND FURNITURE',1,'2022-06-16','2022-06-16',4,2),(42,'2022-0042','PALMTREE FURNITURE',1,'2022-06-16','2022-06-16',3,2),(43,'2022-0043','PALMTREE FURNITURE',1,'2022-06-16','2022-06-16',5,2),(44,'2022-0044','PALMTREE FURNITURE',1,'2022-06-16','2022-06-16',1,2),(45,'2022-0045','PALMTREE FURNITURE',1,'2022-06-16','2022-06-16',1,2),(46,'2022-0046','PALMTREE FURNITURE',1,'2022-06-16','2022-06-16',1,2),(47,'2022-0047','VERTIX FURNITURE',1,'2022-06-16','2022-06-16',3,2),(48,'2022-0048','VERTIX FURNITURE',1,'2022-06-16','2022-06-16',1,2),(49,'2022-0049','VERTIX FURNITURE',1,'2022-06-16','2022-06-16',2,2),(50,'2022-0050','VERTIX FURNITURE',1,'2022-06-16','2022-06-16',3,2),(51,'2022-0051','ENTITY FURNITURE',1,'2022-06-16','2022-06-16',5,2),(52,'2022-0052','INLAND FURNITURE',1,'2022-06-16','2022-06-16',3,2),(53,'2022-0053','INLAND FURNITURE',1,'2022-06-16','2022-06-16',5,2),(54,'2022-0054','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',4,2),(55,'2022-0055','INTEGRATE FURNITURE',1,'2022-06-16','2022-06-16',3,2),(56,'2022-0056','INTACT FURNITURE',1,'2022-06-16','2022-06-16',4,2),(57,'2022-0057','VERTIX FURNITURE',1,'2022-06-16','2022-06-16',3,2),(58,'2022-0058','INTEGRATE FURNITURE',1,'2022-06-16','2022-06-16',4,2),(59,'2022-0059','INTEGRATE FURNITURE',1,'2022-06-16','2022-06-16',5,2),(60,'2022-0060','INTACT FURNITURE',1,'2022-06-16','2022-06-16',3,2),(61,'2022-0061','ENTITY FURNITURE',1,'2022-06-16','2022-06-16',5,2),(62,'2022-0062','ENTITY FURNITURE',1,'2022-06-16','2022-06-16',2,2),(63,'2022-0063','ENTITY FURNITURE',1,'2022-06-16','2022-06-16',1,2),(64,'2022-0064','FURNITURE SPOTS',5,'2022-06-17','2022-06-17',1,2),(65,'2022-0065','FURNITURE EXCHANGE',1,'2022-10-02','2022-10-02',1,2),(66,'2022-0066','FURNITURE SPOTS',3,'2022-10-02','2022-10-02',1,2),(67,'2022-0067','VERTIX FURNITURE',3,'2022-10-02','2022-10-02',4,2),(68,'2022-0068','TM',1,'2022-10-02','2022-10-02',1,2),(69,'2022-0069','INLAND FURNITURE',6,'2022-10-25','2022-10-18',3,1),(70,'2022-0070','TNT',2,'2022-11-02','2022-10-27',1,1),(71,'2022-0071','FURNITURE EYES',1,'2022-10-31','2022-10-31',1,2),(72,'2022-0072','INTACT FURNITURE',2,'2022-11-07','2022-11-07',4,1),(73,'2022-0073','FURNITURE EYES',1,'2022-11-09','2022-11-09',0,1),(74,'2022-0074','TM',1,'2022-11-09','2022-11-09',0,1),(75,'2022-0075','INTACT FURNITURE',1,'2022-11-29','2022-11-09',0,1),(76,'2022-0076','FURNITURE EXCHANGE',2,'2022-11-10','2022-11-10',0,1),(77,'2022-0077','GLOBE',1,'2022-11-29','2022-11-12',0,1),(78,'2022-0078','NEW ORLEANS',1,'2022-11-29','2022-11-12',0,2),(79,'2022-0079','NEW ORLEANS',1,'2022-11-28','2022-11-12',0,2),(80,'2022-0080','NEW ORLEANS',1,'2022-11-12','2022-11-12',0,2),(81,'2022-0081','GLOBE',1,'2022-11-21','2022-11-15',0,2),(82,'2022-0082','TM',5,'2022-11-22','2022-11-22',0,1),(83,'2022-0083','TM',1,'2022-11-22','2022-11-22',0,1),(84,'2022-0084','TM',1,'2022-11-22','2022-11-22',0,1),(85,'2022-0085','TM',2,'2022-11-22','2022-11-22',0,1),(86,'2022-0086','TM',1,'2022-11-23','2022-11-22',0,1),(87,'2022-0087','TM',2,'2022-11-22','2022-11-22',0,1),(88,'2022-0088','TM',2,'2022-11-22','2022-11-22',0,1),(89,'2022-0089','GLOBE',1,'2022-11-22','2022-11-22',0,2),(90,'2022-0090','TM',2,'2022-11-30','2022-11-22',0,2),(91,'2022-0091','NEW ORLEANS',1,'2022-11-29','2022-11-24',0,1),(92,'2022-0092','GLOBE',2,'2022-12-01','2022-12-01',0,1),(93,'2022-0093','TM',1,'2022-12-01','2022-12-01',0,1);

/*Table structure for table `position` */

DROP TABLE IF EXISTS `position`;

CREATE TABLE `position` (
  `lvl_id` int(10) NOT NULL AUTO_INCREMENT,
  `level` varchar(150) NOT NULL,
  PRIMARY KEY (`lvl_id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `position` */

insert  into `position`(`lvl_id`,`level`) values (1,'Manager'),(2,'Cashier'),(3,'Administrator');

/*Table structure for table `received` */

DROP TABLE IF EXISTS `received`;

CREATE TABLE `received` (
  `drid` int(12) NOT NULL AUTO_INCREMENT,
  `sup_id` varchar(255) DEFAULT NULL,
  `date_received` date NOT NULL,
  `numberofitem` int(12) NOT NULL,
  `receiveby` int(12) NOT NULL,
  PRIMARY KEY (`drid`)
) ENGINE=InnoDB AUTO_INCREMENT=76 DEFAULT CHARSET=utf8mb4;

/*Data for the table `received` */

insert  into `received`(`drid`,`sup_id`,`date_received`,`numberofitem`,`receiveby`) values (1,NULL,'2022-05-31',1,2),(2,'globe','2022-05-31',1,2),(3,'globe','2022-05-31',1,2),(4,'         ','2022-06-08',1,2),(5,'globe','2022-06-10',1,2),(6,'globe','2022-06-23',1,2),(7,'globe','2022-06-22',1,2),(8,'         ','2022-06-09',1,2),(9,'         ','2022-06-15',2,2),(10,'         ','2022-06-16',1,2),(11,'         ','2022-06-16',1,2),(12,'         ','2022-06-16',1,1),(13,'         ','2022-06-16',1,1),(14,'         ','2022-06-16',1,1),(15,'         ','2022-06-16',1,1),(16,'         ','2022-06-16',1,1),(17,'         ','2022-06-16',1,1),(18,'         ','2022-06-16',1,1),(19,'         ','2022-06-19',1,2),(20,'         ','2022-06-16',1,1),(21,'         ','2022-06-16',1,1),(22,'         ','2022-06-16',1,1),(23,'         ','2022-06-16',1,1),(24,'         ','2022-06-16',1,1),(25,'         ','2022-06-16',1,1),(26,'         ','2022-06-16',1,1),(27,'         ','2022-06-16',1,1),(28,'         ','2022-06-16',1,1),(29,'         ','2022-06-16',1,1),(30,'         ','2022-06-16',1,3),(31,'         ','2022-06-16',1,4),(32,'         ','2022-06-16',1,2),(33,'         ','2022-06-16',1,5),(34,'         ','2022-06-16',1,4),(35,'         ','2022-06-16',1,5),(36,'         ','2022-06-16',1,2),(37,'         ','2022-06-16',1,4),(38,'         ','2022-06-16',1,2),(39,'         ','2022-06-16',1,1),(40,'         ','2022-06-16',1,1),(41,'         ','2022-06-16',1,1),(42,'         ','2022-06-16',1,3),(43,'         ','2022-06-16',1,2),(44,'         ','2022-06-16',1,2),(45,'         ','2022-06-16',1,3),(46,'         ','2022-06-16',1,4),(47,'         ','2022-06-16',1,3),(48,'         ','2022-06-16',1,5),(49,'         ','2022-06-16',1,2),(50,'         ','2022-06-16',1,3),(51,'         ','2022-06-16',1,1),(52,'         ','2022-06-16',1,3),(53,'         ','2022-06-16',1,2),(54,'         ','2022-06-16',1,3),(55,'         ','2022-06-16',1,4),(56,'         ','2022-06-16',1,5),(57,'         ','2022-06-16',1,1),(58,'         ','2022-06-16',1,4),(59,'         ','2022-06-16',1,2),(60,'         ','2022-06-16',1,2),(61,'         ','2022-06-16',1,2),(62,'         ','2022-06-16',1,4),(63,'         ','2022-06-16',1,5),(64,'ENTITY FURNITURE','2022-06-21',5,2),(65,'INTACT FURNITURE','2022-10-13',1,4),(66,'FURNITURE SPOTS','2022-10-02',3,1),(67,'2022-0058','2022-10-02',3,1),(68,'2022-0008','2022-10-07',1,2),(69,'         ','2022-10-31',1,1),(70,'2022-0059','2022-11-12',1,3),(71,'         ','2022-11-29',1,2),(72,'         ','2022-11-12',1,1),(73,'         ','2022-11-15',1,3),(74,'         ','2022-11-23',1,3),(75,'         ','2022-11-23',2,3);

/*Table structure for table `receiveddetails` */

DROP TABLE IF EXISTS `receiveddetails`;

CREATE TABLE `receiveddetails` (
  `ruID` int(12) NOT NULL AUTO_INCREMENT,
  `drID` int(12) NOT NULL,
  `itemid` int(12) NOT NULL,
  `quantity` int(12) NOT NULL,
  `dateDelivered` date NOT NULL,
  PRIMARY KEY (`ruID`)
) ENGINE=InnoDB AUTO_INCREMENT=86 DEFAULT CHARSET=utf8mb4;

/*Data for the table `receiveddetails` */

insert  into `receiveddetails`(`ruID`,`drID`,`itemid`,`quantity`,`dateDelivered`) values (1,14341,1,12,'2022-05-31'),(2,4141,1,12,'2022-05-31'),(3,21234,1,15,'2022-05-31'),(4,13121,1,12,'2022-06-08'),(5,1451231,1,12,'2022-06-10'),(6,1412313131,1,2,'2022-06-23'),(7,988712,2,15,'2022-06-22'),(8,6234,2,12,'2022-06-09'),(9,64352,2,12,'2022-06-15'),(10,64352,1,3,'2022-06-15'),(11,873113,17,13,'2022-06-16'),(12,798132,59,17,'2022-06-16'),(13,242626,57,7,'2022-06-16'),(14,546752,57,11,'2022-06-16'),(15,766245,10,15,'2022-06-16'),(16,589323,45,8,'2022-06-16'),(17,242513,44,11,'2022-06-16'),(18,352626,55,7,'2022-06-16'),(19,235233,45,4,'2022-06-16'),(20,325327,11,11,'2022-06-19'),(21,646353,45,18,'2022-06-16'),(22,22425,37,4,'2022-06-16'),(23,324215,40,2,'2022-06-16'),(24,353532,61,25,'2022-06-16'),(25,212145,42,17,'2022-06-16'),(26,214378,36,15,'2022-06-16'),(27,767695,39,17,'2022-06-16'),(28,8776,41,11,'2022-06-16'),(29,655856,38,19,'2022-06-16'),(30,434899,35,19,'2022-06-16'),(31,585485,4,24,'2022-06-16'),(32,464733,6,19,'2022-06-16'),(33,360808,19,26,'2022-06-16'),(34,111358,22,33,'2022-06-16'),(35,546860,22,12,'2022-06-16'),(36,975753,27,14,'2022-06-16'),(37,342363,23,22,'2022-06-16'),(38,124252,24,24,'2022-06-16'),(39,368965,21,4,'2022-06-16'),(40,121564,28,12,'2022-06-16'),(41,868654,15,16,'2022-06-16'),(42,325343,14,33,'2022-06-16'),(43,3447585,14,9,'2022-06-16'),(44,436223,12,13,'2022-06-16'),(45,358888,13,16,'2022-06-16'),(46,868532,8,31,'2022-06-16'),(47,353474,7,24,'2022-06-16'),(48,235231,5,16,'2022-06-16'),(49,973433,1,42,'2022-06-16'),(50,366576,29,16,'2022-06-16'),(51,336464,9,22,'2022-06-16'),(52,214125,48,7,'2022-06-16'),(53,251797,1,16,'2022-06-16'),(54,654645,54,5,'2022-06-16'),(55,974554,26,23,'2022-06-16'),(56,547545,30,15,'2022-06-16'),(57,965755,53,13,'2022-06-16'),(58,757754,60,4,'2022-06-16'),(59,753741,58,11,'2022-06-16'),(60,789642,1,16,'2022-06-16'),(61,787941,52,19,'2022-06-16'),(62,747774,62,1,'2022-06-16'),(63,741256,31,16,'2022-06-16'),(64,757145,49,17,'2022-06-16'),(65,156789,57,12,'2022-06-21'),(66,156789,56,15,'2022-06-21'),(67,156789,2,12,'2022-06-21'),(68,156789,55,20,'2022-06-21'),(69,156789,63,25,'2022-06-21'),(70,1313,57,12,'2022-10-13'),(71,13131,59,12,'2022-10-02'),(72,13131,38,12,'2022-10-02'),(73,13131,55,12,'2022-10-02'),(74,41231,41,3,'2022-10-02'),(75,41231,60,2,'2022-10-02'),(76,41231,59,2,'2022-10-02'),(77,415445645,8,12000,'2022-10-07'),(78,412313,62,7500,'2022-10-31'),(79,41,60,4500,'2022-11-12'),(80,3,1,4500,'2022-11-29'),(81,44,1,2,'2022-11-12'),(82,55555,1,2,'2022-11-15'),(83,6666,9,5,'2022-11-23'),(84,1,18,5,'2022-11-23'),(85,1,4,4,'2022-11-23');

/*Table structure for table `setting` */

DROP TABLE IF EXISTS `setting`;

CREATE TABLE `setting` (
  `transactionnumber` bigint(100) unsigned NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`transactionnumber`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `setting` */

/*Table structure for table `status` */

DROP TABLE IF EXISTS `status`;

CREATE TABLE `status` (
  `statid` int(12) NOT NULL AUTO_INCREMENT,
  `status` varchar(255) NOT NULL,
  PRIMARY KEY (`statid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `status` */

insert  into `status`(`statid`,`status`) values (1,'Pending'),(2,'Delivered');

/*Table structure for table `stocks` */

DROP TABLE IF EXISTS `stocks`;

CREATE TABLE `stocks` (
  `stockid` int(12) NOT NULL AUTO_INCREMENT,
  `itemid` int(12) NOT NULL,
  `quantity` int(12) NOT NULL,
  PRIMARY KEY (`stockid`)
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=utf8mb4;

/*Data for the table `stocks` */

insert  into `stocks`(`stockid`,`itemid`,`quantity`) values (1,1,5),(2,2,24),(3,3,6),(4,4,18),(5,5,5),(6,6,2),(7,7,7),(8,8,0),(9,9,2),(10,10,0),(11,11,0),(12,12,0),(13,13,0),(14,14,30),(15,15,8),(16,16,0),(17,17,6),(18,18,5),(19,19,14),(20,20,0),(21,21,0),(22,22,45),(23,23,18),(24,24,23),(25,25,0),(26,26,23),(27,27,13),(28,28,12),(29,29,16),(30,30,15),(31,31,16),(32,32,1),(33,33,0),(34,34,1),(35,35,19),(36,36,14),(37,37,4),(38,38,31),(39,39,17),(40,40,4),(41,41,14),(42,42,17),(43,43,0),(44,44,11),(45,45,29),(46,46,0),(47,47,5),(48,48,7),(49,49,17),(50,50,1),(51,51,1),(52,52,19),(53,53,13),(54,54,5),(55,55,39),(56,56,15),(57,57,42),(58,58,11),(59,59,31),(60,60,3),(61,61,25),(62,62,2),(63,63,25),(64,64,0),(65,65,0),(66,65,0),(67,67,0),(68,68,0),(69,69,0),(70,70,0),(71,71,0);

/*Table structure for table `sup_item` */

DROP TABLE IF EXISTS `sup_item`;

CREATE TABLE `sup_item` (
  `supitemid` int(12) NOT NULL AUTO_INCREMENT,
  `suppid` int(12) NOT NULL,
  `itemid` int(12) NOT NULL,
  `itemcode` varchar(255) NOT NULL,
  `itemtype` varchar(255) NOT NULL,
  `description` varchar(255) DEFAULT NULL,
  `price` double(10,2) NOT NULL,
  PRIMARY KEY (`supitemid`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4;

/*Data for the table `sup_item` */

insert  into `sup_item`(`supitemid`,`suppid`,`itemid`,`itemcode`,`itemtype`,`description`,`price`) values (1,12,11,'FT-PR150','FOLDING PLASTIC TABLE','L150 X W70 X H75',3500.00),(2,12,12,'FT-PR1200','FOLDING PLASTIC TABLE','L120 X W60 X H75',3500.00),(3,12,7,'CFT-24000','CONFERENCE TABLE','L420 X W120 X H75',18000.00),(4,12,21,'C-BD6016','EXECUTIVE CHAIR','LEATHERETTE',7800.00),(5,12,28,'VC-3028','VISITOR\'S CHAIR','L43 X W45 X H82',2800.00),(6,12,17,'DT-A9107','6 SEATING DINING TABLE','L150 X W90 X H75',10000.00),(7,1,8,'CST- D96144','COMPUTER DESK WITH METAL FRAME','L120 X W52 X H74',9000.00),(8,1,18,'CT-502','CENTER & SIDE TABLE','L105 X W55 X H42',3000.00),(9,1,10,'YT-6319','COMPUTER STUDY TABLE','L100 X W76 X H56',7600.00),(10,1,2,'MBC-3112','MID BACK CHAIR','H120 X D45 X W50',5500.00),(11,1,16,'DT-A209','4 SEATING DINING TABLE','W125 X L75',7500.00),(12,1,14,'DT-P112','COFFEE TABLE','L120 X W40',7700.00),(13,14,30,'C-303','LEATHERETTE VISITOR\'S CHAIR','L50 X W50 X H103',3350.00),(14,2,9,'DTR-3600','COFFEE TABLE','L70 X W70',5500.00),(15,8,20,'C-BD2089','EXECUTIVE CHAIR','LEATHERETTE',5000.00),(16,8,5,'CST-D96022','COMPUTER DESK WITH METAL FRAME','L100 X W54 X H74',8000.00),(17,3,5,'CST-D96022','COMPUTER DESK WITH METAL FRAME','L100 X W54 X H74',8000.00),(18,3,8,'CST- D96144','COMPUTER DESK WITH METAL FRAME','L120 X W52 X H74',9000.00),(19,7,3,'OFT-16000','EXECUTIVE TABLE','L160 X W80 X H75',21000.00),(20,1,3,'OFT-16000','EXECUTIVE TABLE','L160 X W80 X H75',21000.00),(21,1,4,'OFT-10111','OFFICE TABLE','L100 X W50 X H75',5000.00),(22,5,13,'FT-7306','TRAINING TABLE','L120 X W40 X H75',4000.00),(23,2,10,'YT-6319','COMPUTER STUDY TABLE','L100 X W76 X H56',7600.00),(24,3,12,'FT-PR1200','FOLDING PLASTIC TABLE','L120 X W60 X H75',3500.00),(25,1,22,'C-BNH301','MESH CHAIR','MESH',8000.00),(26,1,59,'STC-818A','CHROME PLATED STOOL','',1600.00),(27,1,6,'OFT-8140','OFFICE TABLE WITH MOBILE DRAWER','L280 X W120 X H75',28000.00),(28,1,7,'CFT-24000','CONFERENCE TABLE','L420 X W120 X H75',18000.00),(29,3,1,'JPC-001','MOBILE PEDESTAL','W45 X D50 XH 75',3600.00),(30,3,9,'DTR-3600','COFFEE TABLE','L70 X W70',5500.00),(31,14,7,'CFT-24000','CONFERENCE TABLE','L420 X W120 X H75',18000.00),(32,14,1,'JPC-001','MOBILE PEDESTAL','W45 X D50 XH 75',3600.00),(33,15,69,'PARTITION-SIDEPANEL','PARTITION','H120 X W60',3500.00),(34,15,70,'PARTITION-FRONTPANEL','PARTITION','H120 X W100',4500.00),(35,15,71,'PARTITION-TABLE','PARTITION','W100 X D60',2500.00);

/*Table structure for table `supplier` */

DROP TABLE IF EXISTS `supplier`;

CREATE TABLE `supplier` (
  `sup_id` int(12) NOT NULL AUTO_INCREMENT,
  `sup_cname` varchar(255) NOT NULL,
  `sup_name` varchar(255) DEFAULT NULL,
  `contact` varchar(255) NOT NULL,
  `emailadd` varchar(255) NOT NULL,
  `house` varchar(255) NOT NULL,
  `brgy` varchar(255) NOT NULL,
  `city` varchar(255) NOT NULL,
  `status` int(12) NOT NULL DEFAULT 1,
  PRIMARY KEY (`sup_id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4;

/*Data for the table `supplier` */

insert  into `supplier`(`sup_id`,`sup_cname`,`sup_name`,`contact`,`emailadd`,`house`,`brgy`,`city`,`status`) values (1,'TM',NULL,'0915645987','TM@GMAIL.COM','GREENFIELDS','BRGY PASONG TAMO','QUEZON CITY',1),(2,'GLOBE',NULL,'0945564897','GLOBE@GMAIL.COM','SACREDHEART','BRGY PASONG PUTIK PROPER','QUEZON CITY',1),(3,'TNT',NULL,'094567981','TNT@GMAIL.COM','DEMINAY ST','BRGY SITO PULO','CALOOCAN CITY',1),(4,'FURNITURE EYES',NULL,'09638885513','DDXEAP7@YANDEX.CFD','NATIONAL HIGHWAY','GUSA','CAGAYAN DE ORO CITY',1),(5,'FURNITURE EXCHANGE',NULL,'8132449','SOFIAIBRAGIMOVA@GMAILNI.COM','CONDOMINIUM 10 TOWR 2','CITYLAND','MAKATI CITY',1),(6,'INLAND FURNITURE',NULL,'6373570','WASEEMALI628@ONEMAHANET.COM','ORTIGAS CENTER','ADB AVENUE','PASIG CITY',1),(7,'ENTITY FURNITURE',NULL,'8303073','S161268@BHARATASUPERFUR.COM','V.A. RUFINO STREETS','SALCEDO','MAKATI CITY',1),(8,'INTACT FURNITURE',NULL,'8961230','DAETR@GKQIL.COM','A P REYES GATE','CARMONA 1200','MAKATI CITY',1),(9,'FURNITURE WEST',NULL,'723474','ALIGIRSCH@GKQIL.COM','J.R BORJA','DON A. VELEZ ','CAGAYAN DE ORO',1),(10,'FURNITURE SPOTS',NULL,'8332876','ANTC2JANTR@SIPSTRORE.COM','PARK AVENUE','21143 UNIT','PASAY CITY',1),(11,'VERTIX FURNITURE',NULL,'5111568','RANDYM26@KONGSHUON.COM','DEL PILAR','MAHARLIKA','NUEVA ECIJA',1),(12,'INTEGRATE FURNITURE',NULL,'2932659','DOBROGROZAN@NBOBD.COM','DE LEON','92 GEN. T','VALENZUELA CITY',1),(13,'PALMTREE FURNITURE',NULL,'0956783123','SSS@OMTECHA.COM','2115 C.M.','RECTO AVENUE','MANILA CITY',1),(14,'NEW ORLEANS',NULL,'812394','NW@GMAIL.COM','CAMACHILE ST.','BRGY SITIO MANU','QUEZON CITY',1),(15,'PRINTEX FURNITURES',NULL,'768657','PFURNITURES@YAHOO.COM','PICOLO ST.','BRGY SAN JUAN','MALABON CITY',1);

/*Table structure for table `tblinout` */

DROP TABLE IF EXISTS `tblinout`;

CREATE TABLE `tblinout` (
  `attendID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `position` varchar(50) NOT NULL,
  `activity` varchar(150) NOT NULL,
  `date` varchar(50) NOT NULL,
  PRIMARY KEY (`attendID`)
) ENGINE=MyISAM AUTO_INCREMENT=155 DEFAULT CHARSET=latin1;

/*Data for the table `tblinout` */

insert  into `tblinout`(`attendID`,`username`,`position`,`activity`,`date`) values (1,'Admin','Admin','Successfully logged in','2022-11-24 11:00:03 PM'),(2,'Admin','Admin','Successfully logged in','2022-11-24 11:01:36 PM'),(3,'Admin','Admin','Successfully logged in','2022-11-24 11:19:14 PM'),(4,'Admin','Admin','Successfully logged in','2022-11-24 11:23:43 PM'),(5,'KKK KK KKK','Administrator','Successfully logged in','2022-11-24 11:24:19'),(6,'Admin','Admin','Successfully logged in','2022-11-24 11:24:57 PM'),(7,'Admin','Admin','Successfully logged in','2022-11-24 11:26:18 PM'),(8,'Admin','Admin','Successfully logged in','2022-11-24 11:27:41 PM'),(9,'Admin','Admin','Successfully logged out','2022-11-24 11:28:06 PM'),(10,'Admin','Admin','Successfully logged in','2022-11-24 11:28:34 PM'),(11,'Admin','Admin','Successfully logged out','2022-11-24 11:29:50 PM'),(12,'MARIANNE BELLE V EMPAS','Cashier','Successfully logged in','2022-11-24 11:30:07'),(13,'MARIANNE BELLE V EMPAS','Cashier','Successfully logged in','2022-11-24 11:34:59'),(14,'MARIANNE BELLE V EMPAS','Cashier','Successfully logged in','2022-11-24 11:38:33'),(15,'MARIANNE BELLE V EMPAS','Cashier','Successfully logged in','2022-11-24 11:39:26'),(16,'Admin','Admin','Successfully logged in','2022-11-24 11:39:40 PM'),(17,'MARIANNE BELLE V EMPAS','Cashier','Successfully logged in','2022-11-24 11:39:59'),(18,'Admin','Admin','Successfully logged in','2022-11-24 11:40:06 PM'),(19,'MARIANNE BELLE V EMPAS','Cashier','Successfully logged in','2022-11-24 11:41:07'),(20,'Admin','Admin','Successfully logged in','2022-11-24 11:41:14 PM'),(21,'Admin','Admin','Successfully logged in','2022-11-24 11:48:58 PM'),(22,'Admin','Admin','Successfully logged in','2022-11-24 11:53:02 PM'),(23,'Admin','Admin','Successfully logged in','2022-11-24 11:59:49 PM'),(24,'Admin','Admin','Successfully logged in','2022-11-25 12:00:22 AM'),(25,'Admin','Admin','Successfully logged in','2022-11-25 12:03:34 AM'),(26,'Admin','Admin','Successfully logged in','2022-11-25 12:06:13 AM'),(27,'JOHN RAFAEL R TUGANO','Administrator','Successfully logged in','2022-11-25 12:07:54'),(28,'Admin','Admin','Successfully logged in','2022-11-25 12:11:08 AM'),(29,'Admin','Admin','Successfully logged in','2022-11-25 12:11:43 AM'),(30,'Admin','Admin','Successfully logged in','2022-11-25 12:12:52 AM'),(31,'Admin','Admin','Successfully logged in','2022-11-25 12:14:17 AM'),(32,'Admin','Admin','Successfully logged in','2022-11-25 12:18:16 AM'),(33,'Admin','Admin','Successfully logged in','2022-11-25 12:19:16 AM'),(34,'Admin','Admin','Successfully logged in','2022-11-25 12:19:55 AM'),(35,'Admin','Admin','Successfully logged in','2022-11-25 12:21:37 AM'),(36,'Admin','Admin','Successfully logged in','2022-12-01 03:40:58 AM'),(37,'Admin','Admin','Successfully logged in','2022-12-01 03:42:16 AM'),(38,'Admin','Admin','Successfully logged in','2022-12-01 03:48:54 AM'),(39,'Admin','Admin','Successfully logged in','2022-12-01 03:50:03 AM'),(40,'Admin','Admin','Successfully logged in','2022-12-01 03:50:39 AM'),(41,'Admin','Admin','Successfully logged in','2022-12-01 04:00:39 AM'),(42,'Admin','Admin','Successfully logged in','2022-12-01 04:02:30 AM'),(43,'Admin','Admin','Successfully logged in','2022-12-01 04:04:24 AM'),(44,'Admin','Admin','Successfully logged in','2022-12-01 04:06:06 AM'),(45,'Admin','Admin','Successfully logged in','2022-12-01 04:06:48 AM'),(46,'Admin','Admin','Successfully logged in','2022-12-01 04:07:33 AM'),(47,'Admin','Admin','Successfully logged in','2022-12-01 04:09:30 AM'),(48,'Admin','Admin','Successfully logged in','2022-12-01 04:10:09 AM'),(49,'Admin','Admin','Successfully logged in','2022-12-01 04:14:27 AM'),(50,'Admin','Admin','Successfully logged in','2022-12-01 04:16:04 AM'),(51,'Admin','Admin','Successfully logged in','2022-12-01 04:16:42 AM'),(52,'Admin','Admin','Successfully logged in','2022-12-01 04:17:59 AM'),(53,'Admin','Admin','Successfully logged out','2022-12-01 04:18:14 AM'),(54,'JONEL  MACASA','Cashier','Successfully logged in','2022-12-01 04:18:20'),(55,'Admin','Admin','Successfully logged in','2022-12-01 04:18:32 AM'),(56,'Admin','Admin','Successfully logged out','2022-12-01 04:18:53 AM'),(57,'Admin','Admin','Successfully logged in','2022-12-01 04:19:04 AM'),(58,'Admin','Admin','Successfully logged in','2022-12-01 04:20:13 AM'),(59,'Admin','Admin','Successfully logged in','2022-12-01 04:29:07 AM'),(60,'Admin','Admin','Successfully logged in','2022-12-01 04:29:43 AM'),(61,'Admin','Admin','Successfully logged in','2022-12-01 04:30:12 AM'),(62,'Admin','Admin','Successfully logged in','2022-12-01 04:30:37 AM'),(63,'Admin','Admin','Successfully logged in','2022-12-01 04:31:15 AM'),(64,'Admin','Admin','Successfully logged in','2022-12-01 04:32:04 AM'),(65,'Admin','Admin','Successfully logged in','2022-12-01 04:34:02 AM'),(66,'Admin','Admin','Successfully logged in','2022-12-01 04:37:38 AM'),(67,'Admin','Admin','Successfully logged in','2022-12-01 04:38:48 AM'),(68,'Admin','Admin','Successfully logged in','2022-12-01 04:39:57 AM'),(69,'Admin','Admin','Successfully logged in','2022-12-01 04:40:43 AM'),(70,'Admin','Admin','Successfully logged in','2022-12-01 04:42:21 AM'),(71,'Admin','Admin','Successfully logged in','2022-12-01 04:45:45 AM'),(72,'Admin','Admin','Successfully logged in','2022-12-01 04:47:40 AM'),(73,'Admin','Admin','Successfully logged in','2022-12-01 04:48:36 AM'),(74,'Admin','Admin','Successfully logged in','2022-12-01 04:49:23 AM'),(75,'Admin','Admin','Successfully logged in','2022-12-01 04:52:20 AM'),(76,'Admin','Admin','Successfully logged in','2022-12-01 04:54:13 AM'),(77,'Admin','Admin','Successfully logged in','2022-12-01 04:55:18 AM'),(78,'Admin','Admin','Successfully logged in','2022-12-01 04:55:45 AM'),(79,'Admin','Admin','Successfully logged in','2022-12-01 05:01:14 AM'),(80,'Admin','Admin','Successfully logged in','2022-12-01 05:03:42 AM'),(81,'Admin','Admin','Successfully logged in','2022-12-01 05:04:08 AM'),(82,'Admin','Admin','Successfully logged in','2022-12-01 05:04:41 AM'),(83,'Admin','Admin','Successfully logged in','2022-12-01 05:05:47 AM'),(84,'Admin','Admin','Successfully logged in','2022-12-01 05:07:21 AM'),(85,'Admin','Admin','Successfully logged in','2022-12-01 05:08:01 AM'),(86,'Admin','Admin','Successfully logged in','2022-12-01 05:08:38 AM'),(87,'Admin','Admin','Successfully logged in','2022-12-01 05:08:59 AM'),(88,'Admin','Admin','Successfully logged in','2022-12-01 05:10:33 AM'),(89,'Admin','Admin','Successfully logged in','2022-12-01 05:10:55 AM'),(90,'Admin','Admin','Successfully logged in','2022-12-01 05:11:32 AM'),(91,'Admin','Admin','Successfully logged in','2022-12-01 05:12:34 AM'),(92,'Admin','Admin','Successfully logged in','2022-12-01 05:14:04 AM'),(93,'Admin','Admin','Successfully logged in','2022-12-01 05:16:04 AM'),(94,'Admin','Admin','Successfully logged in','2022-12-01 05:16:51 AM'),(95,'Admin','Admin','Successfully logged in','2022-12-01 05:18:07 AM'),(96,'Admin','Admin','Successfully logged in','2022-12-01 05:19:09 AM'),(97,'Admin','Admin','Successfully logged in','2022-12-01 05:19:26 AM'),(98,'Admin','Admin','Successfully logged in','2022-12-01 05:20:33 AM'),(99,'Admin','Admin','Successfully logged in','2022-12-01 05:20:53 AM'),(100,'Admin','Admin','Successfully logged in','2022-12-01 05:21:17 AM'),(101,'Admin','Admin','Successfully logged in','2022-12-01 05:31:11 AM'),(102,'Admin','Admin','Successfully logged in','2022-12-01 05:31:37 AM'),(103,'Admin','Admin','Successfully logged in','2022-12-01 05:32:33 AM'),(104,'Admin','Admin','Successfully logged in','2022-12-01 05:34:58 AM'),(105,'Admin','Admin','Successfully logged in','2022-12-01 05:35:23 AM'),(106,'Admin','Admin','Successfully logged in','2022-12-01 05:36:50 AM'),(107,'Admin','Admin','Successfully logged in','2022-12-01 05:37:28 AM'),(108,'Admin','Admin','Successfully logged in','2022-12-01 05:38:38 AM'),(109,'Admin','Admin','Successfully logged in','2022-12-01 05:39:00 AM'),(110,'Admin','Admin','Successfully logged in','2022-12-01 05:39:55 AM'),(111,'Admin','Admin','Successfully logged in','2022-12-01 05:40:44 AM'),(112,'Admin','Admin','Successfully logged in','2022-12-01 05:42:26 AM'),(113,'Admin','Admin','Successfully logged in','2022-12-01 05:47:01 AM'),(114,'Admin','Admin','Successfully logged in','2022-12-01 05:47:33 AM'),(115,'Admin','Admin','Successfully logged in','2022-12-01 05:49:02 AM'),(116,'Admin','Admin','Successfully logged in','2022-12-01 05:49:32 AM'),(117,'Admin','Admin','Successfully logged in','2022-12-01 05:50:36 AM'),(118,'Admin','Admin','Successfully logged in','2022-12-01 05:50:54 AM'),(119,'Admin','Admin','Successfully logged in','2022-12-01 05:55:53 AM'),(120,'Admin','Admin','Successfully logged in','2022-12-01 05:56:40 AM'),(121,'Admin','Admin','Successfully logged in','2022-12-01 05:57:48 AM'),(122,'Admin','Admin','Successfully logged in','2022-12-01 05:58:42 AM'),(123,'Admin','Admin','Successfully logged in','2022-12-01 05:59:18 AM'),(124,'Admin','Admin','Successfully logged in','2022-12-01 06:04:54 AM'),(125,'Admin','Admin','Successfully logged in','2022-12-01 06:07:50 AM'),(126,'Admin','Admin','Successfully logged in','2022-12-01 06:08:16 AM'),(127,'Admin','Admin','Successfully logged in','2022-12-01 06:08:53 AM'),(128,'Admin','Admin','Successfully logged in','2022-12-01 06:09:48 AM'),(129,'Admin','Admin','Successfully logged in','2022-12-01 06:11:00 AM'),(130,'Admin','Admin','Successfully logged in','2022-12-01 06:11:38 AM'),(131,'Admin','Admin','Successfully logged in','2022-12-01 06:14:18 AM'),(132,'Admin','Admin','Successfully logged in','2022-12-01 06:16:05 AM'),(133,'Admin','Admin','Successfully logged in','2022-12-01 06:17:38 AM'),(134,'Admin','Admin','Successfully logged in','2022-12-01 06:19:10 AM'),(135,'Admin','Admin','Successfully logged in','2022-12-01 06:19:43 AM'),(136,'Admin','Admin','Successfully logged in','2022-12-01 06:20:46 AM'),(137,'Admin','Admin','Successfully logged in','2022-12-01 06:21:17 AM'),(138,'Admin','Admin','Successfully logged in','2022-12-01 06:21:35 AM'),(139,'Admin','Admin','Successfully logged in','2022-12-01 06:23:16 AM'),(140,'Admin','Admin','Successfully logged in','2022-12-01 06:26:35 AM'),(141,'Admin','Admin','Successfully logged in','2022-12-01 06:26:56 AM'),(142,'Admin','Admin','Successfully logged in','2022-12-01 06:27:51 AM'),(143,'Admin','Admin','Successfully logged in','2022-12-01 06:28:17 AM'),(144,'Admin','Admin','Successfully logged in','2022-12-01 06:32:07 AM'),(145,'Admin','Admin','Successfully logged in','2022-12-01 06:33:02 AM'),(146,'Admin','Admin','Successfully logged in','2022-12-01 06:33:30 AM'),(147,'Admin','Admin','Successfully logged in','2022-12-01 06:33:50 AM'),(148,'Admin','Admin','Successfully logged in','2022-12-01 06:39:07 AM'),(149,'Admin','Admin','Successfully logged in','2022-12-01 06:39:39 AM'),(150,'Admin','Admin','Successfully logged in','2022-12-01 06:40:00 AM'),(151,'Admin','Admin','Successfully logged in','2022-12-01 06:41:54 AM'),(152,'Admin','Admin','Successfully logged in','2022-12-01 06:42:14 AM'),(153,'Admin','Admin','Successfully logged in','2022-12-01 06:42:57 AM'),(154,'Admin','Admin','Successfully logged in','2022-12-01 06:44:52 AM');

/*Table structure for table `temp_transaction` */

DROP TABLE IF EXISTS `temp_transaction`;

CREATE TABLE `temp_transaction` (
  `transId` int(10) NOT NULL AUTO_INCREMENT,
  `transdetailsId` int(10) NOT NULL,
  `totalstockId` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `totalprice` double(10,2) NOT NULL,
  `ornum` varchar(50) NOT NULL,
  `clientid` varchar(50) NOT NULL,
  `clientname` varchar(255) NOT NULL,
  `pmethod` varchar(255) NOT NULL,
  `status` int(10) NOT NULL,
  PRIMARY KEY (`transId`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `temp_transaction` */

/*Table structure for table `transaction` */

DROP TABLE IF EXISTS `transaction`;

CREATE TABLE `transaction` (
  `transId` int(10) NOT NULL AUTO_INCREMENT,
  `transdetailsId` int(10) NOT NULL,
  `totalstockId` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `totalprice` double(10,2) NOT NULL,
  `ornum` varchar(50) NOT NULL,
  `clientID` bigint(15) NOT NULL,
  `numberofitems` int(12) NOT NULL,
  `empID` int(10) NOT NULL,
  PRIMARY KEY (`transId`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `transaction` */

insert  into `transaction`(`transId`,`transdetailsId`,`totalstockId`,`qty`,`totalprice`,`ornum`,`clientID`,`numberofitems`,`empID`) values (1,1,46,1,4100.00,'202211220001',202210060010,1,0),(2,1,9,1,7500.00,'202211220001',202210060010,1,0),(3,2,3,1,23000.00,'202211220002',202210060010,2,0),(4,2,5,1,9500.00,'202211220002',202210060010,2,0),(5,0,9,1,7500.00,'202211220003',202210060010,1,0);

/*Table structure for table `transaction2` */

DROP TABLE IF EXISTS `transaction2`;

CREATE TABLE `transaction2` (
  `transId` int(10) NOT NULL AUTO_INCREMENT,
  `transdetailsId` int(10) NOT NULL,
  `totalstockId` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `totalprice` double(10,2) NOT NULL,
  `currentBal` double(10,2) NOT NULL,
  `ornum` varchar(50) NOT NULL,
  `clientID` bigint(15) NOT NULL,
  `empID` int(10) NOT NULL,
  PRIMARY KEY (`transId`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `transaction2` */

/*Table structure for table `transaction_details` */

DROP TABLE IF EXISTS `transaction_details`;

CREATE TABLE `transaction_details` (
  `transdetailsId` int(10) NOT NULL AUTO_INCREMENT,
  `amountTendered` double(10,2) NOT NULL,
  `Discount` int(10) NOT NULL,
  `delfee` double(10,2) NOT NULL,
  `totaDueAmount` double(10,2) NOT NULL,
  `amountChange` double(10,2) NOT NULL,
  `tDate` varchar(50) NOT NULL,
  `transNo` varchar(50) NOT NULL,
  `clientid` bigint(15) NOT NULL,
  `numberofitems` int(10) NOT NULL,
  `noi` int(12) NOT NULL,
  PRIMARY KEY (`transdetailsId`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `transaction_details` */

insert  into `transaction_details`(`transdetailsId`,`amountTendered`,`Discount`,`delfee`,`totaDueAmount`,`amountChange`,`tDate`,`transNo`,`clientid`,`numberofitems`,`noi`) values (1,7625.00,5,500.00,7625.00,0.00,'11-22-2022','202211220001',202210060010,0,1),(2,31875.00,5,500.00,31375.00,500.00,'11-22-2022','202211220002',202210060010,0,2),(3,12625.00,5,5000.00,12125.00,500.00,'11-22-2022','202211220003',202210060010,0,1);

/*Table structure for table `transaction_details2` */

DROP TABLE IF EXISTS `transaction_details2`;

CREATE TABLE `transaction_details2` (
  `transdetailsId` int(10) NOT NULL AUTO_INCREMENT,
  `amountTendered` double(10,2) NOT NULL,
  `Discount` int(10) NOT NULL,
  `delfee` double(10,2) NOT NULL,
  `totaDueAmount` double(10,2) NOT NULL,
  `currentBal` double(10,2) NOT NULL,
  `tDate` varchar(50) NOT NULL,
  `transNo` varchar(50) NOT NULL,
  `clientid` bigint(15) NOT NULL,
  `numberofitems` int(12) NOT NULL,
  `isPaid` int(12) NOT NULL,
  `finalpayment` double(10,2) NOT NULL,
  PRIMARY KEY (`transdetailsId`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `transaction_details2` */

insert  into `transaction_details2`(`transdetailsId`,`amountTendered`,`Discount`,`delfee`,`totaDueAmount`,`currentBal`,`tDate`,`transNo`,`clientid`,`numberofitems`,`isPaid`,`finalpayment`) values (1,51000.00,5,500.00,62320.00,11820.00,'11-22-2022','202211220001',202206160005,4,0,0.00);

/*Table structure for table `void` */

DROP TABLE IF EXISTS `void`;

CREATE TABLE `void` (
  `VoidID` bigint(20) NOT NULL AUTO_INCREMENT,
  `transheadId` int(10) NOT NULL,
  `itemid` bigint(20) NOT NULL,
  `qty` bigint(20) NOT NULL,
  `totalprice` decimal(10,2) NOT NULL,
  `date_void` date NOT NULL,
  `date_time` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `empID` int(11) NOT NULL,
  PRIMARY KEY (`VoidID`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `void` */

insert  into `void`(`VoidID`,`transheadId`,`itemid`,`qty`,`totalprice`,`date_void`,`date_time`,`empID`) values (1,3,7,4,'96000.00','2022-11-15','2022-11-15 20:23:14',1),(2,3,7,5,'120000.00','2022-11-15','2022-11-15 20:23:26',1),(3,3,12,5,'27500.00','2022-11-15','2022-11-15 20:24:57',1),(4,3,12,5,'27500.00','2022-11-15','2022-11-15 20:25:07',1),(5,3,12,5,'27500.00','2022-11-15','2022-11-15 20:25:12',1);

/*Table structure for table `vwclient` */

DROP TABLE IF EXISTS `vwclient`;

/*!50001 DROP VIEW IF EXISTS `vwclient` */;
/*!50001 DROP TABLE IF EXISTS `vwclient` */;

/*!50001 CREATE TABLE  `vwclient`(
 `custID` int(12) unsigned ,
 `Iddetails` bigint(15) ,
 `clientname` varchar(512) ,
 `address` varchar(511) ,
 `contactno` int(12) ,
 `emailadd` varchar(255) ,
 `status` varchar(255) 
)*/;

/*Table structure for table `vwclients` */

DROP TABLE IF EXISTS `vwclients`;

/*!50001 DROP VIEW IF EXISTS `vwclients` */;
/*!50001 DROP TABLE IF EXISTS `vwclients` */;

/*!50001 CREATE TABLE  `vwclients`(
 `custID` int(12) unsigned ,
 `iddetails` bigint(15) ,
 `ClientName` text ,
 `pmethod` varchar(255) ,
 `address` text ,
 `contactno` int(12) ,
 `emailadd` varchar(255) ,
 `status` varchar(255) 
)*/;

/*Table structure for table `vwtransaction` */

DROP TABLE IF EXISTS `vwtransaction`;

/*!50001 DROP VIEW IF EXISTS `vwtransaction` */;
/*!50001 DROP TABLE IF EXISTS `vwtransaction` */;

/*!50001 CREATE TABLE  `vwtransaction`(
 `stockid` int(12) ,
 `itemid` int(12) ,
 `itemcode` varchar(255) ,
 `itemtype` varchar(255) ,
 `UnitP` double(9,2) ,
 `qty` int(11) ,
 `totalprice` double(10,2) ,
 `transId` int(10) ,
 `ornum` varchar(50) ,
 `clientid` varchar(50) ,
 `status` int(10) 
)*/;

/*Table structure for table `vwusers` */

DROP TABLE IF EXISTS `vwusers`;

/*!50001 DROP VIEW IF EXISTS `vwusers` */;
/*!50001 DROP TABLE IF EXISTS `vwusers` */;

/*!50001 CREATE TABLE  `vwusers`(
 `empID` int(12) ,
 `fullname` text ,
 `dob` date ,
 `uname` varchar(255) ,
 `password` varchar(255) ,
 `level` varchar(150) ,
 `date_in` date ,
 `isActive` int(12) 
)*/;

/*Table structure for table `vwvoid` */

DROP TABLE IF EXISTS `vwvoid`;

/*!50001 DROP VIEW IF EXISTS `vwvoid` */;
/*!50001 DROP TABLE IF EXISTS `vwvoid` */;

/*!50001 CREATE TABLE  `vwvoid`(
 `VoidID` bigint(20) ,
 `transheadId` int(10) ,
 `itemid` int(12) ,
 `itemcode` varchar(255) ,
 `itemtype` varchar(255) ,
 `Description` varchar(255) ,
 `UnitP` double(9,2) ,
 `qty` bigint(20) ,
 `totalprice` decimal(10,2) ,
 `date_void` date ,
 `date_time` timestamp 
)*/;

/*Table structure for table `vw_inv` */

DROP TABLE IF EXISTS `vw_inv`;

/*!50001 DROP VIEW IF EXISTS `vw_inv` */;
/*!50001 DROP TABLE IF EXISTS `vw_inv` */;

/*!50001 CREATE TABLE  `vw_inv`(
 `stockid` int(12) ,
 `itemcode` varchar(255) ,
 `itemtype` varchar(255) ,
 `Description` varchar(255) ,
 `Price` double(9,2) ,
 `UnitP` double(9,2) ,
 `quantity` int(12) 
)*/;

/*Table structure for table `vw_item` */

DROP TABLE IF EXISTS `vw_item`;

/*!50001 DROP VIEW IF EXISTS `vw_item` */;
/*!50001 DROP TABLE IF EXISTS `vw_item` */;

/*!50001 CREATE TABLE  `vw_item`(
 `stockid` int(12) ,
 `itemid` int(12) ,
 `itemcode` varchar(255) ,
 `itemtype` varchar(255) ,
 `Price` double(9,2) ,
 `UnitP` double(9,2) ,
 `quantity` int(12) 
)*/;

/*Table structure for table `vw_payment` */

DROP TABLE IF EXISTS `vw_payment`;

/*!50001 DROP VIEW IF EXISTS `vw_payment` */;
/*!50001 DROP TABLE IF EXISTS `vw_payment` */;

/*!50001 CREATE TABLE  `vw_payment`(
 `paymentid` int(12) ,
 `paymentname` varchar(155) ,
 `paymentdetails` varchar(255) ,
 `Amount` double(10,2) ,
 `transno` varchar(155) ,
 `clientid` varchar(255) ,
 `status` int(12) 
)*/;

/*Table structure for table `vw_payment2` */

DROP TABLE IF EXISTS `vw_payment2`;

/*!50001 DROP VIEW IF EXISTS `vw_payment2` */;
/*!50001 DROP TABLE IF EXISTS `vw_payment2` */;

/*!50001 CREATE TABLE  `vw_payment2`(
 `paymentid` int(12) ,
 `paymentname` varchar(155) ,
 `paymentdetails` varchar(255) ,
 `Amount` double(10,2) ,
 `transno` varchar(155) ,
 `clientid` varchar(255) ,
 `status` int(12) 
)*/;

/*Table structure for table `vw_payment50report` */

DROP TABLE IF EXISTS `vw_payment50report`;

/*!50001 DROP VIEW IF EXISTS `vw_payment50report` */;
/*!50001 DROP TABLE IF EXISTS `vw_payment50report` */;

/*!50001 CREATE TABLE  `vw_payment50report`(
 `transno` varchar(50) ,
 `clientid` bigint(15) ,
 `clientname` varchar(512) ,
 `numberofitems` int(12) ,
 `discount` int(10) ,
 `delfee` double(10,2) ,
 `totadueamount` double(10,2) ,
 `amountTendered` double(10,2) ,
 `currentBal` double(10,2) ,
 `tDate` varchar(50) 
)*/;

/*Table structure for table `vw_paymentfpreport` */

DROP TABLE IF EXISTS `vw_paymentfpreport`;

/*!50001 DROP VIEW IF EXISTS `vw_paymentfpreport` */;
/*!50001 DROP TABLE IF EXISTS `vw_paymentfpreport` */;

/*!50001 CREATE TABLE  `vw_paymentfpreport`(
 `transno` varchar(50) ,
 `clientid` bigint(15) ,
 `clientname` varchar(512) ,
 `noi` int(12) ,
 `discount` int(10) ,
 `delfee` double(10,2) ,
 `totadueamount` double(10,2) ,
 `amountTendered` double(10,2) ,
 `amountchange` double(10,2) ,
 `tDate` varchar(50) 
)*/;

/*Table structure for table `vw_paymentprint50` */

DROP TABLE IF EXISTS `vw_paymentprint50`;

/*!50001 DROP VIEW IF EXISTS `vw_paymentprint50` */;
/*!50001 DROP TABLE IF EXISTS `vw_paymentprint50` */;

/*!50001 CREATE TABLE  `vw_paymentprint50`(
 `transno` varchar(50) ,
 `clientid` bigint(15) ,
 `clientname` varchar(512) ,
 `paymenttype` varchar(255) ,
 `paymentname` varchar(155) ,
 `discount` int(10) ,
 `delfee` double(10,2) ,
 `totadueamount` double(10,2) ,
 `paymentdetails` varchar(255) ,
 `amount` double(10,2) ,
 `numberofitems` int(12) ,
 `currentBal` double(10,2) ,
 `tDate` varchar(50) 
)*/;

/*Table structure for table `vw_paymentprintfp` */

DROP TABLE IF EXISTS `vw_paymentprintfp`;

/*!50001 DROP VIEW IF EXISTS `vw_paymentprintfp` */;
/*!50001 DROP TABLE IF EXISTS `vw_paymentprintfp` */;

/*!50001 CREATE TABLE  `vw_paymentprintfp`(
 `transno` varchar(50) ,
 `clientid` bigint(15) ,
 `clientname` varchar(512) ,
 `paymenttype` varchar(255) ,
 `paymentname` varchar(155) ,
 `discount` int(10) ,
 `delfee` double(10,2) ,
 `totadueamount` double(10,2) ,
 `paymentdetails` varchar(255) ,
 `amount` double(10,2) ,
 `noi` int(12) ,
 `amountchange` double(10,2) ,
 `tDate` varchar(50) 
)*/;

/*Table structure for table `vw_po` */

DROP TABLE IF EXISTS `vw_po`;

/*!50001 DROP VIEW IF EXISTS `vw_po` */;
/*!50001 DROP TABLE IF EXISTS `vw_po` */;

/*!50001 CREATE TABLE  `vw_po`(
 `porderid` int(12) ,
 `porder_bodyid` int(10) ,
 `itemid` int(12) ,
 `itemcode` varchar(255) ,
 `itemtype` varchar(255) ,
 `Description` varchar(255) ,
 `Price` double(9,2) ,
 `UnitP` double(9,2) ,
 `quantity` int(12) ,
 `Total` double(19,2) ,
 `ponum` varchar(150) ,
 `sup_id` varchar(255) ,
 `sup_cname` varchar(255) ,
 `expecdate` date 
)*/;

/*Table structure for table `vw_polist` */

DROP TABLE IF EXISTS `vw_polist`;

/*!50001 DROP VIEW IF EXISTS `vw_polist` */;
/*!50001 DROP TABLE IF EXISTS `vw_polist` */;

/*!50001 CREATE TABLE  `vw_polist`(
 `porder_bodyid` int(10) ,
 `ponum` varchar(150) ,
 `numberofitem` int(12) ,
 `expecdate` date ,
 `sup_id` varchar(255) ,
 `sup_cname` varchar(255) ,
 `statid` int(12) ,
 `status` varchar(255) 
)*/;

/*Table structure for table `vw_polistt` */

DROP TABLE IF EXISTS `vw_polistt`;

/*!50001 DROP VIEW IF EXISTS `vw_polistt` */;
/*!50001 DROP TABLE IF EXISTS `vw_polistt` */;

/*!50001 CREATE TABLE  `vw_polistt`(
 `porder_bodyid` int(10) ,
 `ponum` varchar(150) ,
 `numberofitem` int(12) ,
 `expecdate` date ,
 `sup_id` varchar(255) ,
 `sup_cname` varchar(255) ,
 `statid` int(12) ,
 `status` varchar(255) 
)*/;

/*Table structure for table `vw_prod` */

DROP TABLE IF EXISTS `vw_prod`;

/*!50001 DROP VIEW IF EXISTS `vw_prod` */;
/*!50001 DROP TABLE IF EXISTS `vw_prod` */;

/*!50001 CREATE TABLE  `vw_prod`(
 `itemid` int(12) ,
 `itemcode` varchar(255) ,
 `itemtype` varchar(255) ,
 `Description` varchar(255) ,
 `Price` double(9,2) ,
 `UnitP` double(9,2) 
)*/;

/*Table structure for table `vw_selectitem` */

DROP TABLE IF EXISTS `vw_selectitem`;

/*!50001 DROP VIEW IF EXISTS `vw_selectitem` */;
/*!50001 DROP TABLE IF EXISTS `vw_selectitem` */;

/*!50001 CREATE TABLE  `vw_selectitem`(
 `stockid` int(12) ,
 `itemid` int(12) ,
 `itemcode` varchar(255) ,
 `itemtype` varchar(255) ,
 `UnitP` double(9,2) ,
 `quantity` int(12) 
)*/;

/*Table structure for table `vw_supplier` */

DROP TABLE IF EXISTS `vw_supplier`;

/*!50001 DROP VIEW IF EXISTS `vw_supplier` */;
/*!50001 DROP TABLE IF EXISTS `vw_supplier` */;

/*!50001 CREATE TABLE  `vw_supplier`(
 `sup_id` int(12) ,
 `sup_cname` varchar(255) ,
 `contact` varchar(255) ,
 `emailadd` varchar(255) ,
 `address` text ,
 `status` varchar(255) 
)*/;

/*Table structure for table `vw_sup_item` */

DROP TABLE IF EXISTS `vw_sup_item`;

/*!50001 DROP VIEW IF EXISTS `vw_sup_item` */;
/*!50001 DROP TABLE IF EXISTS `vw_sup_item` */;

/*!50001 CREATE TABLE  `vw_sup_item`(
 `suppid` int(12) ,
 `sup_cname` varchar(255) ,
 `contact` varchar(255) ,
 `emailadd` varchar(255) ,
 `itemid` int(12) ,
 `itemcode` varchar(255) ,
 `itemtype` varchar(255) ,
 `description` varchar(255) ,
 `price` double(10,2) 
)*/;

/*Table structure for table `vw_sup_item2` */

DROP TABLE IF EXISTS `vw_sup_item2`;

/*!50001 DROP VIEW IF EXISTS `vw_sup_item2` */;
/*!50001 DROP TABLE IF EXISTS `vw_sup_item2` */;

/*!50001 CREATE TABLE  `vw_sup_item2`(
 `suppid` int(12) ,
 `sup_cname` varchar(255) ,
 `itemid` int(12) ,
 `itemcode` varchar(255) ,
 `itemtype` varchar(255) ,
 `description` varchar(255) ,
 `price` double(10,2) 
)*/;

/*Table structure for table `vw_updatepayment50` */

DROP TABLE IF EXISTS `vw_updatepayment50`;

/*!50001 DROP VIEW IF EXISTS `vw_updatepayment50` */;
/*!50001 DROP TABLE IF EXISTS `vw_updatepayment50` */;

/*!50001 CREATE TABLE  `vw_updatepayment50`(
 `transno` varchar(50) ,
 `clientid` bigint(15) ,
 `clientname` varchar(512) ,
 `numberofitems` int(12) ,
 `discount` int(10) ,
 `delfee` double(10,2) ,
 `totadueamount` double(10,2) ,
 `amountTendered` double(10,2) ,
 `currentBal` double(10,2) ,
 `tDate` varchar(50) ,
 `finalpayment` double(10,2) 
)*/;

/*View structure for view vwclient */

/*!50001 DROP TABLE IF EXISTS `vwclient` */;
/*!50001 DROP VIEW IF EXISTS `vwclient` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwclient` AS select `c`.`CustID` AS `custID`,`c`.`Iddetails` AS `Iddetails`,concat(`c`.`lname`,', ',`c`.`fname`) AS `clientname`,concat(`c`.`Brgy`,' ',`c`.`city`) AS `address`,`c`.`contactno` AS `contactno`,`c`.`emailadd` AS `emailadd`,`cs`.`status` AS `status` from (`client` `c` join `clientstatus` `cs` on(`cs`.`clienstatusID` = `c`.`status`)) */;

/*View structure for view vwclients */

/*!50001 DROP TABLE IF EXISTS `vwclients` */;
/*!50001 DROP VIEW IF EXISTS `vwclients` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwclients` AS select `c`.`CustID` AS `custID`,`c`.`Iddetails` AS `iddetails`,concat(`c`.`lname`,', ',`c`.`fname`,' ',`c`.`mi`) AS `ClientName`,`cp`.`pmethod` AS `pmethod`,concat(`c`.`Street`,' ',`c`.`Brgy`,' ',`c`.`city`) AS `address`,`c`.`contactno` AS `contactno`,`c`.`emailadd` AS `emailadd`,`cs`.`status` AS `status` from ((`client` `c` join `clientpay` `cp` on(`c`.`pmethod` = `cp`.`pmethodid`)) join `clientstatus` `cs` on(`c`.`status` = `cs`.`clienstatusID`)) */;

/*View structure for view vwtransaction */

/*!50001 DROP TABLE IF EXISTS `vwtransaction` */;
/*!50001 DROP VIEW IF EXISTS `vwtransaction` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwtransaction` AS select `s`.`stockid` AS `stockid`,`i`.`itemid` AS `itemid`,`i`.`itemcode` AS `itemcode`,`t`.`ItemType` AS `itemtype`,`i`.`UnitP` AS `UnitP`,`tt`.`qty` AS `qty`,`tt`.`totalprice` AS `totalprice`,`tt`.`transId` AS `transId`,`tt`.`ornum` AS `ornum`,`tt`.`clientid` AS `clientid`,`tt`.`status` AS `status` from (((`stocks` `s` join `temp_transaction` `tt` on(`tt`.`totalstockId` = `s`.`stockid`)) join `items` `i` on(`i`.`itemid` = `s`.`itemid`)) join `itemtype` `t` on(`t`.`typeid` = `i`.`typeid`)) */;

/*View structure for view vwusers */

/*!50001 DROP TABLE IF EXISTS `vwusers` */;
/*!50001 DROP VIEW IF EXISTS `vwusers` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwusers` AS select `e`.`empID` AS `empID`,concat(`e`.`fname`,' ',`e`.`mname`,' ',`e`.`lname`) AS `fullname`,`e`.`dob` AS `dob`,`e`.`uname` AS `uname`,`e`.`password` AS `password`,`p`.`level` AS `level`,`e`.`date_in` AS `date_in`,`e`.`isActive` AS `isActive` from (`employee` `e` join `position` `p` on(`e`.`lvl_id` = `p`.`lvl_id`)) */;

/*View structure for view vwvoid */

/*!50001 DROP TABLE IF EXISTS `vwvoid` */;
/*!50001 DROP VIEW IF EXISTS `vwvoid` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwvoid` AS select `v`.`VoidID` AS `VoidID`,`v`.`transheadId` AS `transheadId`,`vw_prod`.`itemid` AS `itemid`,`vw_prod`.`itemcode` AS `itemcode`,`vw_prod`.`itemtype` AS `itemtype`,`vw_prod`.`Description` AS `Description`,`vw_prod`.`UnitP` AS `UnitP`,`v`.`qty` AS `qty`,`v`.`totalprice` AS `totalprice`,`v`.`date_void` AS `date_void`,`v`.`date_time` AS `date_time` from (`vw_prod` join `void` `v` on(`v`.`itemid` = `vw_prod`.`itemid`)) */;

/*View structure for view vw_inv */

/*!50001 DROP TABLE IF EXISTS `vw_inv` */;
/*!50001 DROP VIEW IF EXISTS `vw_inv` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_inv` AS select `s`.`stockid` AS `stockid`,`p`.`itemcode` AS `itemcode`,`p`.`itemtype` AS `itemtype`,`p`.`Description` AS `Description`,`p`.`Price` AS `Price`,`p`.`UnitP` AS `UnitP`,`s`.`quantity` AS `quantity` from (`vw_prod` `p` join `stocks` `s` on(`s`.`itemid` = `p`.`itemid`)) */;

/*View structure for view vw_item */

/*!50001 DROP TABLE IF EXISTS `vw_item` */;
/*!50001 DROP VIEW IF EXISTS `vw_item` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_item` AS select `s`.`stockid` AS `stockid`,`i`.`itemid` AS `itemid`,`i`.`itemcode` AS `itemcode`,`t`.`ItemType` AS `itemtype`,`i`.`price` AS `Price`,`i`.`UnitP` AS `UnitP`,`s`.`quantity` AS `quantity` from ((`stocks` `s` join `items` `i` on(`s`.`itemid` = `i`.`itemid`)) join `itemtype` `t` on(`i`.`typeid` = `t`.`typeid`)) */;

/*View structure for view vw_payment */

/*!50001 DROP TABLE IF EXISTS `vw_payment` */;
/*!50001 DROP VIEW IF EXISTS `vw_payment` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_payment` AS select `p`.`paymentid` AS `paymentid`,`pt`.`paymentname` AS `paymentname`,`p`.`paymentdetails` AS `paymentdetails`,`p`.`Amount` AS `Amount`,`p`.`transno` AS `transno`,`p`.`clientid` AS `clientid`,`p`.`status` AS `status` from (`payment` `p` join `paymenttype` `pt` on(`p`.`paymenttype` = `pt`.`paymentid`)) */;

/*View structure for view vw_payment2 */

/*!50001 DROP TABLE IF EXISTS `vw_payment2` */;
/*!50001 DROP VIEW IF EXISTS `vw_payment2` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_payment2` AS select `pc`.`paymentid` AS `paymentid`,`pt`.`paymentname` AS `paymentname`,`pc`.`paymentdetails` AS `paymentdetails`,`pc`.`Amount` AS `Amount`,`pc`.`transno` AS `transno`,`pc`.`clientid` AS `clientid`,`pc`.`status` AS `status` from (`payment_copy` `pc` join `paymenttype` `pt` on(`pc`.`paymenttype` = `pt`.`paymentid`)) */;

/*View structure for view vw_payment50report */

/*!50001 DROP TABLE IF EXISTS `vw_payment50report` */;
/*!50001 DROP VIEW IF EXISTS `vw_payment50report` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_payment50report` AS select `td2`.`transNo` AS `transno`,`td2`.`clientid` AS `clientid`,concat(`c`.`lname`,', ',`c`.`fname`) AS `clientname`,`td2`.`numberofitems` AS `numberofitems`,`td2`.`Discount` AS `discount`,`td2`.`delfee` AS `delfee`,`td2`.`totaDueAmount` AS `totadueamount`,`td2`.`amountTendered` AS `amountTendered`,`td2`.`currentBal` AS `currentBal`,`td2`.`tDate` AS `tDate` from (`transaction_details2` `td2` join `client` `c` on(`c`.`Iddetails` = `td2`.`clientid`)) */;

/*View structure for view vw_paymentfpreport */

/*!50001 DROP TABLE IF EXISTS `vw_paymentfpreport` */;
/*!50001 DROP VIEW IF EXISTS `vw_paymentfpreport` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_paymentfpreport` AS select `td`.`transNo` AS `transno`,`td`.`clientid` AS `clientid`,concat(`c`.`lname`,', ',`c`.`fname`) AS `clientname`,`td`.`noi` AS `noi`,`td`.`Discount` AS `discount`,`td`.`delfee` AS `delfee`,`td`.`totaDueAmount` AS `totadueamount`,`td`.`amountTendered` AS `amountTendered`,`td`.`amountChange` AS `amountchange`,`td`.`tDate` AS `tDate` from (`transaction_details` `td` join `client` `c` on(`c`.`Iddetails` = `td`.`clientid`)) */;

/*View structure for view vw_paymentprint50 */

/*!50001 DROP TABLE IF EXISTS `vw_paymentprint50` */;
/*!50001 DROP VIEW IF EXISTS `vw_paymentprint50` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_paymentprint50` AS select `td2`.`transNo` AS `transno`,`td2`.`clientid` AS `clientid`,concat(`c`.`lname`,', ',`c`.`fname`) AS `clientname`,`pc`.`paymenttype` AS `paymenttype`,`pt`.`paymentname` AS `paymentname`,`td2`.`Discount` AS `discount`,`td2`.`delfee` AS `delfee`,`td2`.`totaDueAmount` AS `totadueamount`,`pc`.`paymentdetails` AS `paymentdetails`,`pc`.`Amount` AS `amount`,`td2`.`numberofitems` AS `numberofitems`,`td2`.`currentBal` AS `currentBal`,`td2`.`tDate` AS `tDate` from (((`transaction_details2` `td2` join `payment_copy` `pc` on(`pc`.`transno` = `td2`.`transNo`)) join `paymenttype` `pt` on(`pt`.`paymentid` = `pc`.`paymenttype`)) join `client` `c` on(`c`.`Iddetails` = `td2`.`clientid`)) */;

/*View structure for view vw_paymentprintfp */

/*!50001 DROP TABLE IF EXISTS `vw_paymentprintfp` */;
/*!50001 DROP VIEW IF EXISTS `vw_paymentprintfp` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_paymentprintfp` AS select `td`.`transNo` AS `transno`,`td`.`clientid` AS `clientid`,concat(`c`.`lname`,', ',`c`.`fname`) AS `clientname`,`p`.`paymenttype` AS `paymenttype`,`pt`.`paymentname` AS `paymentname`,`td`.`Discount` AS `discount`,`td`.`delfee` AS `delfee`,`td`.`totaDueAmount` AS `totadueamount`,`p`.`paymentdetails` AS `paymentdetails`,`p`.`Amount` AS `amount`,`td`.`noi` AS `noi`,`td`.`amountChange` AS `amountchange`,`td`.`tDate` AS `tDate` from (((`transaction_details` `td` join `payment` `p` on(`p`.`transno` = `td`.`transNo`)) join `paymenttype` `pt` on(`pt`.`paymentid` = `p`.`paymenttype`)) join `client` `c` on(`c`.`Iddetails` = `td`.`clientid`)) */;

/*View structure for view vw_po */

/*!50001 DROP TABLE IF EXISTS `vw_po` */;
/*!50001 DROP VIEW IF EXISTS `vw_po` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_po` AS select `po`.`porderid` AS `porderid`,`pd`.`porder_bodyid` AS `porder_bodyid`,`pr`.`itemid` AS `itemid`,`pr`.`itemcode` AS `itemcode`,`pr`.`itemtype` AS `itemtype`,`pr`.`Description` AS `Description`,`pr`.`Price` AS `Price`,`pr`.`UnitP` AS `UnitP`,`po`.`quantity` AS `quantity`,`po`.`quantity` * `pr`.`UnitP` AS `Total`,`pd`.`ponum` AS `ponum`,`pd`.`sup_id` AS `sup_id`,`s`.`sup_cname` AS `sup_cname`,`pd`.`expecdate` AS `expecdate` from (((`porder` `po` join `vw_prod` `pr` on(`pr`.`itemid` = `po`.`itemid`)) join `porder_details` `pd` on(`pd`.`porder_bodyid` = `po`.`porder_bodyid`)) join `supplier` `s` on(`s`.`sup_cname` = `pd`.`sup_id`)) */;

/*View structure for view vw_polist */

/*!50001 DROP TABLE IF EXISTS `vw_polist` */;
/*!50001 DROP VIEW IF EXISTS `vw_polist` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_polist` AS select `pd`.`porder_bodyid` AS `porder_bodyid`,`pd`.`ponum` AS `ponum`,`pd`.`numberofitem` AS `numberofitem`,`pd`.`expecdate` AS `expecdate`,`pd`.`sup_id` AS `sup_id`,`s`.`sup_cname` AS `sup_cname`,`pd`.`statid` AS `statid`,`st`.`status` AS `status` from ((`porder_details` `pd` join `supplier` `s` on(`s`.`sup_id` = `pd`.`sup_id`)) join `status` `st` on(`st`.`statid` = `pd`.`statid`)) */;

/*View structure for view vw_polistt */

/*!50001 DROP TABLE IF EXISTS `vw_polistt` */;
/*!50001 DROP VIEW IF EXISTS `vw_polistt` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_polistt` AS select `pd`.`porder_bodyid` AS `porder_bodyid`,`pd`.`ponum` AS `ponum`,`pd`.`numberofitem` AS `numberofitem`,`pd`.`expecdate` AS `expecdate`,`pd`.`sup_id` AS `sup_id`,`s`.`sup_cname` AS `sup_cname`,`pd`.`statid` AS `statid`,`st`.`status` AS `status` from ((`porder_details` `pd` join `supplier` `s` on(`s`.`sup_cname` = `pd`.`sup_id`)) join `status` `st` on(`st`.`statid` = `pd`.`statid`)) */;

/*View structure for view vw_prod */

/*!50001 DROP TABLE IF EXISTS `vw_prod` */;
/*!50001 DROP VIEW IF EXISTS `vw_prod` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_prod` AS select `i`.`itemid` AS `itemid`,`i`.`itemcode` AS `itemcode`,`t`.`ItemType` AS `itemtype`,`i`.`Description` AS `Description`,`i`.`price` AS `Price`,`i`.`UnitP` AS `UnitP` from (`items` `i` join `itemtype` `t` on(`t`.`typeid` = `i`.`typeid`)) */;

/*View structure for view vw_selectitem */

/*!50001 DROP TABLE IF EXISTS `vw_selectitem` */;
/*!50001 DROP VIEW IF EXISTS `vw_selectitem` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_selectitem` AS select `s`.`stockid` AS `stockid`,`i`.`itemid` AS `itemid`,`i`.`itemcode` AS `itemcode`,`t`.`ItemType` AS `itemtype`,`i`.`UnitP` AS `UnitP`,`s`.`quantity` AS `quantity` from ((`stocks` `s` join `items` `i` on(`s`.`itemid` = `i`.`itemid`)) join `itemtype` `t` on(`i`.`typeid` = `t`.`typeid`)) */;

/*View structure for view vw_supplier */

/*!50001 DROP TABLE IF EXISTS `vw_supplier` */;
/*!50001 DROP VIEW IF EXISTS `vw_supplier` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_supplier` AS select `s`.`sup_id` AS `sup_id`,`s`.`sup_cname` AS `sup_cname`,`s`.`contact` AS `contact`,`s`.`emailadd` AS `emailadd`,concat(`s`.`house`,', ',`s`.`brgy`,' ',`s`.`city`) AS `address`,`c`.`status` AS `status` from (`supplier` `s` join `clientstatus` `c` on(`s`.`status` = `c`.`clienstatusID`)) */;

/*View structure for view vw_sup_item */

/*!50001 DROP TABLE IF EXISTS `vw_sup_item` */;
/*!50001 DROP VIEW IF EXISTS `vw_sup_item` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_sup_item` AS select `si`.`suppid` AS `suppid`,`s`.`sup_cname` AS `sup_cname`,`s`.`contact` AS `contact`,`s`.`emailadd` AS `emailadd`,`si`.`itemid` AS `itemid`,`si`.`itemcode` AS `itemcode`,`si`.`itemtype` AS `itemtype`,`si`.`description` AS `description`,`si`.`price` AS `price` from (`sup_item` `si` join `supplier` `s` on(`si`.`suppid` = `s`.`sup_id`)) */;

/*View structure for view vw_sup_item2 */

/*!50001 DROP TABLE IF EXISTS `vw_sup_item2` */;
/*!50001 DROP VIEW IF EXISTS `vw_sup_item2` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_sup_item2` AS select `si`.`suppid` AS `suppid`,`s`.`sup_cname` AS `sup_cname`,`si`.`itemid` AS `itemid`,`si`.`itemcode` AS `itemcode`,`si`.`itemtype` AS `itemtype`,`si`.`description` AS `description`,`si`.`price` AS `price` from (`sup_item` `si` join `supplier` `s` on(`si`.`suppid` = `s`.`sup_id`)) */;

/*View structure for view vw_updatepayment50 */

/*!50001 DROP TABLE IF EXISTS `vw_updatepayment50` */;
/*!50001 DROP VIEW IF EXISTS `vw_updatepayment50` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_updatepayment50` AS select `td2`.`transNo` AS `transno`,`td2`.`clientid` AS `clientid`,concat(`c`.`lname`,', ',`c`.`fname`) AS `clientname`,`td2`.`numberofitems` AS `numberofitems`,`td2`.`Discount` AS `discount`,`td2`.`delfee` AS `delfee`,`td2`.`totaDueAmount` AS `totadueamount`,`td2`.`amountTendered` AS `amountTendered`,`td2`.`currentBal` AS `currentBal`,`td2`.`tDate` AS `tDate`,`td2`.`finalpayment` AS `finalpayment` from (`transaction_details2` `td2` join `client` `c` on(`c`.`Iddetails` = `td2`.`clientid`)) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
