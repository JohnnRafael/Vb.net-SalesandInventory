/*
SQLyog Ultimate v8.55 
MySQL - 5.5.5-10.4.24-MariaDB : Database - salesandinventory
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
  `contactno` varchar(12) NOT NULL,
  `emailadd` varchar(255) NOT NULL,
  `status` int(12) DEFAULT NULL,
  PRIMARY KEY (`CustID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4;

/*Data for the table `client` */

insert  into `client`(`CustID`,`Iddetails`,`lname`,`fname`,`mi`,`pmethod`,`Street`,`Brgy`,`city`,`contactno`,`emailadd`,`status`) values (1,20220614001,'TUBERO','KRAM','B.',2,'BANTUTIN ST.','BRGY SANTIMO','QUEZON CITY','9454576','KRAM@ROCKETMAIL.COM',1),(2,20220614002,'BENKONG','MARK','R. ',2,'BINGO ST. ','BRGY HEHA','QUEZON CITY','95457651','MARK@ROCKETMAIL.COM',1),(3,202206150003,'TUGANO','JOHN RAFAEL','R',2,'SAMUEL 3 ','BRGY PASONG TAMO','QUEZON CITY','945164572','JOHNNTUGANO@GMAIL.COM',1),(4,202206160004,'MARKIN','JAMSON','M',1,'MAKABILANG BUHAY ST.','BRGY STO ANYO','QUEZON CITY','976412488','NARKIN@GMAIL.COM',1),(5,202206160005,'CLEMENTE','EDWARD','M.',1,'MANIMAN STREET','BRGY KALIWAN','MARIKINA CITY','978463215','EDWARD@GMAIL.COM',1),(6,202206160006,'KELAN','DENMA','R',2,'MANDIJO ST','BRGY 122','CALOOCAN CITY','978746513','DEM@GMAIL.COM',1),(7,202206160007,'MAMANSAG','JAN MARC','M',2,'MALIGAYA ST','BRGY STO NINO','QUEZON CITY','98572312','JANMARC@GMAIL.COM',1),(8,202210060008,'TIAMO','RIAKIMU','R.',2,'BALANGAO ST.','BRGY SALO SALO','CALIBAO CITY','9587583','RIAKUMU@GMAIL.COM',1),(9,202210060009,'INAOM','DEMON','N',2,'3 NAMO','BRGY SAMO','KAMO CITY','8579312','JNANA@GMAIL.COM',1),(10,202210060010,'MARIK','RIAKIMU','M',2,'NEJO ST','BRGY MAJO','DEJO CITY','09958128312','NAKIMUR@GMAIL.COM',1),(11,202212020011,'MENDIOLA','JESSIE','M',2,'BBBB','BBB','BBB','984472611','JM@GMAIL.COM',1);

/*Table structure for table `clientpay` */

DROP TABLE IF EXISTS `clientpay`;

CREATE TABLE `clientpay` (
  `pmethodid` int(12) NOT NULL AUTO_INCREMENT,
  `pmethod` varchar(255) NOT NULL,
  PRIMARY KEY (`pmethodid`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `clientpay` */

insert  into `clientpay`(`pmethodid`,`pmethod`) values (1,'50% Down Payment'),(2,'Fully Paid');

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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

/*Data for the table `employee` */

insert  into `employee`(`empID`,`fname`,`mname`,`lname`,`dob`,`uname`,`password`,`lvl_id`,`date_in`,`isActive`) values (1,'JOHN RAFAEL','R','TUGANO','1999-12-08','JOHN','+3Z9MZvzxBM=',3,'2022-11-25',1),(2,'JONEL','','MACASA','1999-02-16','JONEL','o3q15R1RkqE=',2,'2022-12-02',0),(3,'DARREN','D','GIMENEZ','2000-02-28','DARREN','+3Z9MZvzxBM=',1,'2022-12-08',1),(4,'KERBY','','MONTEJO','2000-04-17','KERBY','+3Z9MZvzxBM=',1,'2022-12-08',1),(5,'KEN','','DELPUERTO','2000-06-13','KEN','vyvI4on5w0aYrRUrObmaUg==',1,'2022-12-08',1);

/*Table structure for table `items` */

DROP TABLE IF EXISTS `items`;

CREATE TABLE `items` (
  `itemid` int(12) NOT NULL AUTO_INCREMENT,
  `itemcode` varchar(255) NOT NULL,
  `typeid` int(12) NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `price` double(9,2) NOT NULL,
  `UnitP` double(9,2) NOT NULL,
  `suppid` int(12) NOT NULL,
  PRIMARY KEY (`itemid`),
  UNIQUE KEY `itemid` (`itemid`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4;

/*Data for the table `items` */

insert  into `items`(`itemid`,`itemcode`,`typeid`,`Description`,`price`,`UnitP`,`suppid`) values (1,'JPC-001',1,'H75 X W95',3500.00,4500.00,1),(2,'OFC-001',7,'H75 X W100 X D60',2500.00,7500.00,1),(3,'SHW-W',49,'W64 X D56 X H115-124',2500.00,6700.00,1),(4,'SH1-BW',49,'W64 X D58 X H115-124',3200.00,6200.00,1),(5,'SH2-B',49,'W64 X D56 X H115-124',3200.00,6100.00,1),(6,'SH3-B',49,'W63 X D59 X H115-124',4500.00,7800.00,1),(7,'SH4-B',49,'ADJUSTABLE LUMBAR SUPPORT AND ARMREST',5800.00,7800.00,1),(8,'SH5-BL',49,'HEAVY DUTY BLACK FRAME WITH BLUE MESH BACK-REST',3500.00,6500.00,1),(9,'BC-EIFFEL',19,'W72 X D59 X H133-141',15000.00,20000.00,1),(10,'BC-EIFFEL (B)',19,'W72 X D59 X H133-141',14000.00,19000.00,1),(11,'CM1',50,'',2800.00,3800.00,2),(12,'CM2',50,'',2800.00,3800.00,2),(13,'CM3',50,'',2700.00,3800.00,2),(14,'CMMB1',50,'',2500.00,4000.00,2),(15,'EMHR2',51,'',3200.00,4800.00,2),(16,'ELHB1',51,'',2000.00,4000.00,2),(17,'EMHR3',51,'',3500.00,6500.00,2),(18,'ELHR3-A',51,'',3500.00,7500.00,2),(19,'VMS1',52,'',1900.00,3900.00,2),(20,'VMS2',52,'',2700.00,3700.00,2),(21,'EOT-GT1607',53,'L160 X W80 X H76',15000.00,25000.00,3),(22,'A16EOT',53,'L160 X W80 X H76',18000.00,24200.00,3),(23,'EOT-GT0944',53,'',17000.00,24500.00,3),(24,'LPMA27',54,'L160 X W80 X H76',18000.00,21000.00,3),(25,'LPMA26',54,'L160 X W80 X H76',15000.00,18000.00,3),(26,'PH24-01',55,'L180 X W80 X H76',20000.00,25000.00,3),(27,'SQ-1716',56,'L180 X W80 X H76',25000.00,28000.00,3),(28,'LT 1.4',57,'L120 X W60 X H75',7000.00,9000.00,3),(29,'STYTBL',58,'L100 X W60 X H75',4500.00,8500.00,3),(30,'CT 8812',3,'L100 X W48 X H120',2800.00,4800.00,3);

/*Table structure for table `itemtype` */

DROP TABLE IF EXISTS `itemtype`;

CREATE TABLE `itemtype` (
  `typeid` int(12) NOT NULL AUTO_INCREMENT,
  `ItemType` varchar(255) NOT NULL,
  PRIMARY KEY (`typeid`)
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=utf8mb4;

/*Data for the table `itemtype` */

insert  into `itemtype`(`typeid`,`ItemType`) values (1,'MOBILE PEDESTAL'),(2,'CONFERENCE TABLE'),(3,'STUDY TABLE'),(4,'HIGH BACK CHAIR'),(5,'MID BACK CHAIR'),(6,'EXECUTIVE TABLE'),(7,'OFFICE TABLE'),(8,'OFFICE TABLE WITH MOBILE DRAWER'),(9,'COMPUTER DESK WITH METAL FRAME'),(10,'COMPUTER STUDY TABLE'),(11,'FOLDING PLASTIC TABLE'),(12,'TRAINING TABLE'),(13,'COFFEE TABLE'),(14,'ALUMINUM TABLE & CHAIRS'),(15,'4 SEATING DINING TABLE'),(16,'6 SEATING DINING TABLE'),(17,'CENTER & SIDE TABLE'),(18,'TV STAND WITH MOUNT'),(19,'EXECUTIVE CHAIR'),(20,'MESH CHAIR'),(21,'CLERICAL CHAIR'),(22,'VISITOR\'S CHAIR'),(23,'LEATHERETTE VISITOR\'S CHAIR'),(24,'STEEL LOCKER'),(25,'STEEL CABINET'),(26,'FILING CABINET'),(27,'BOOK CASE'),(28,'METAL OFFICE TABLE'),(29,'OFFICE FIXTURES'),(30,'MINI CONFERENCE'),(31,'WORKSTATION'),(32,'COMPUTER TABLE'),(33,'GANG CHAIR'),(34,'OFFICE CHAIR'),(35,'OFFICE TELLER CHAIR'),(36,'STACKABLE CHAIR'),(37,'GAMING CHAIR'),(38,'HOME FURNITURE'),(39,'SUPREME'),(40,'CHROME PLATED STOOL'),(41,'STUDENT CHAIR'),(42,'PARK BENCH'),(43,'OFFICES TABLES'),(44,'CHROME PLATED STOOLS'),(45,'OFFICE TABLEE'),(46,'CONFERENCE TABLEE'),(47,'STEEL LOCKERR'),(48,'PARTITION'),(49,'EXECUTIVE MESH CHAIR'),(50,'MID-BACK MESH CHAIR'),(51,'HIGH-BACK MESH CHAIR'),(52,'VISITOR MESH CHAIR'),(53,'EXECUTIVE GLASS TOP TABLE'),(54,'EXECUTIVE L TYPE TABLE'),(55,'MELAMINE EXECUTIVE TABLE'),(56,'WOODEN EXECUTIVE TABLE'),(57,'SEMI EXECUTIVE TABLE'),(58,'FREE STANDING TABLE');

/*Table structure for table `payment` */

DROP TABLE IF EXISTS `payment`;

CREATE TABLE `payment` (
  `paymentid` int(12) NOT NULL AUTO_INCREMENT,
  `paymenttype` varchar(255) NOT NULL,
  `paymentdetails` varchar(255) DEFAULT NULL,
  `Amount` double(10,2) NOT NULL,
  `transno` varchar(155) NOT NULL,
  `referenceno` varchar(155) DEFAULT NULL,
  `clientid` varchar(255) NOT NULL,
  `status` int(12) NOT NULL,
  PRIMARY KEY (`paymentid`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4;

/*Data for the table `payment` */

insert  into `payment`(`paymentid`,`paymenttype`,`paymentdetails`,`Amount`,`transno`,`referenceno`,`clientid`,`status`) values (1,'2','09100765122',23875.00,'202212070001','748120239','202212020011',1),(2,'1','',9650.00,'202212070002','','202212020011',1),(3,'1','',12850.00,'202212070003','','202212020011',1),(4,'1','',7125.00,'202212070004','','202212020011',1),(5,'2','09100765122',31000.00,'202212070005','4781238742313','202212020011',1),(6,'2','09100765122',17100.00,'202212070006','314123','202206150003',1),(7,'2','09100765122',9625.00,'202212070007','58172387642','20220614002',1),(8,'1','',9625.00,'202212070008','','202212020011',1),(9,'1','',6775.00,'202212070009','','202212020011',1),(10,'2','09100765122',9625.00,'202212080010','23124123','202212020011',1),(11,'1','',2500.00,'202212090011','','202206160006',1),(12,'2','09100765122',7125.00,'202212090011','857237612359348','202206160006',1);

/*Table structure for table `payment_copy` */

DROP TABLE IF EXISTS `payment_copy`;

CREATE TABLE `payment_copy` (
  `paymentid` int(12) NOT NULL AUTO_INCREMENT,
  `paymenttype` varchar(255) NOT NULL,
  `paymentdetails` varchar(255) DEFAULT NULL,
  `Amount` double(10,2) NOT NULL,
  `transno` varchar(155) NOT NULL,
  `referenceno` varchar(255) DEFAULT NULL,
  `clientid` varchar(255) NOT NULL,
  `status` int(12) NOT NULL,
  PRIMARY KEY (`paymentid`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

/*Data for the table `payment_copy` */

insert  into `payment_copy`(`paymentid`,`paymenttype`,`paymentdetails`,`Amount`,`transno`,`referenceno`,`clientid`,`status`) values (1,'1','',3500.00,'202212070001','','202206160004',1),(2,'1','',3500.00,'202212080002','','202210060010',1),(3,'1','',3500.00,'202212080003','','202210060010',1),(4,'1','',4500.00,'202212080004','','202210060010',1),(5,'1','',4500.00,'202212080005','','202210060010',1);

/*Table structure for table `paymenttype` */

DROP TABLE IF EXISTS `paymenttype`;

CREATE TABLE `paymenttype` (
  `paymentid` int(10) NOT NULL AUTO_INCREMENT,
  `paymentname` varchar(155) NOT NULL,
  PRIMARY KEY (`paymentid`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

/*Data for the table `paymenttype` */

insert  into `paymenttype`(`paymentid`,`paymentname`) values (1,'Cash'),(2,'Gcash'),(3,'Paymaya'),(4,'Cheque');

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
) ENGINE=InnoDB AUTO_INCREMENT=62 DEFAULT CHARSET=utf8mb4;

/*Data for the table `po_temp` */

/*Table structure for table `porder` */

DROP TABLE IF EXISTS `porder`;

CREATE TABLE `porder` (
  `porderid` int(12) NOT NULL AUTO_INCREMENT,
  `itemid` int(12) NOT NULL,
  `quantity` int(12) NOT NULL,
  `porder_bodyid` int(12) NOT NULL,
  PRIMARY KEY (`porderid`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4;

/*Data for the table `porder` */

insert  into `porder`(`porderid`,`itemid`,`quantity`,`porder_bodyid`) values (1,2,5,1),(2,1,5,1),(3,1,1,2),(4,2,1,3),(5,2,1,4),(6,2,1,5),(7,1,5,6),(8,3,5,7),(9,10,5,8),(10,1,5,9);

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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

/*Data for the table `porder_details` */

insert  into `porder_details`(`porder_bodyid`,`ponum`,`sup_id`,`numberofitem`,`expecdate`,`dateissue`,`createdby`,`statid`) values (1,'2022-0001','1',2,'2022-12-07','2022-12-07',1,2),(2,'2022-0002','1',1,'2022-12-07','2022-12-07',1,2),(3,'2022-0003','1',1,'2022-12-07','2022-12-07',1,2),(4,'2022-0004','1',1,'2022-12-07','2022-12-07',1,2),(5,'2022-0005','1',1,'2022-12-07','2022-12-07',1,2),(6,'2022-0006','1',1,'2022-12-09','2022-12-09',1,2),(7,'2022-0007','1',1,'2022-12-09','2022-12-09',2,2),(8,'2022-0008','1',1,'2022-12-09','2022-12-09',2,2),(9,'2022-0009','1',1,'2022-12-10','2022-12-10',1,2);

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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

/*Data for the table `received` */

insert  into `received`(`drid`,`sup_id`,`date_received`,`numberofitem`,`receiveby`) values (1,'1','2022-12-14',2,1),(2,'1','2022-11-30',1,2),(3,'1','2022-11-27',1,2),(4,'1','2022-12-07',1,2),(5,'1','2022-12-01',1,2),(6,'1','2022-12-05',1,1),(7,'1','2022-12-07',1,2),(8,'1','2022-12-09',1,1),(9,'1','2022-12-11',1,1);

/*Table structure for table `receiveddetails` */

DROP TABLE IF EXISTS `receiveddetails`;

CREATE TABLE `receiveddetails` (
  `ruID` int(12) NOT NULL AUTO_INCREMENT,
  `drID` varchar(255) NOT NULL,
  `itemid` int(12) NOT NULL,
  `quantity` int(12) NOT NULL,
  `dateDelivered` date NOT NULL,
  `sup_id` int(12) NOT NULL,
  `ponum` varchar(150) NOT NULL,
  PRIMARY KEY (`ruID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4;

/*Data for the table `receiveddetails` */

insert  into `receiveddetails`(`ruID`,`drID`,`itemid`,`quantity`,`dateDelivered`,`sup_id`,`ponum`) values (1,'4123',2,5,'2022-12-14',1,'2022-0001'),(2,'4123',1,5,'2022-12-14',1,'2022-0001'),(3,'444',1,1,'2022-11-30',1,'2022-0002'),(4,'41234',2,1,'2022-11-27',1,'2022-0003'),(5,'434343',2,1,'2022-12-07',1,'2022-0004'),(6,'2212',2,0,'2022-12-01',1,'2022-0005'),(7,'534545',1,5,'2022-12-05',1,'2022-0006'),(8,'534554646',3,2,'2022-12-07',1,'2022-0007'),(9,'2147483647',10,0,'2022-12-09',1,'2022-0008'),(10,'5123523',1,0,'2022-12-11',1,'2022-0009');

/*Table structure for table `receivedfromsupp` */

DROP TABLE IF EXISTS `receivedfromsupp`;

CREATE TABLE `receivedfromsupp` (
  `recsup` int(12) NOT NULL AUTO_INCREMENT,
  `drID` int(12) NOT NULL,
  `sup_id` int(12) NOT NULL,
  `itemid` int(12) NOT NULL,
  `receivedby` int(12) NOT NULL,
  `qty` int(12) NOT NULL,
  PRIMARY KEY (`recsup`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

/*Data for the table `receivedfromsupp` */

insert  into `receivedfromsupp`(`recsup`,`drID`,`sup_id`,`itemid`,`receivedby`,`qty`) values (1,2147483647,1,10,1,2),(2,2147483647,1,10,1,2),(3,2147483647,1,10,1,2),(4,5123523,1,1,1,3),(5,5123523,1,1,1,2),(6,2212,1,2,1,1),(7,2147483647,1,10,1,3),(8,2147483647,1,10,1,3);

/*Table structure for table `returnfromclient` */

DROP TABLE IF EXISTS `returnfromclient`;

CREATE TABLE `returnfromclient` (
  `returnid` int(12) NOT NULL AUTO_INCREMENT,
  `clientid` varchar(255) NOT NULL,
  `ornum` varchar(255) NOT NULL,
  `itemid` int(12) NOT NULL,
  `reason` varchar(255) NOT NULL,
  `other` varchar(255) NOT NULL,
  `qty` int(12) NOT NULL,
  `datereturn` date NOT NULL,
  `status` int(12) NOT NULL,
  PRIMARY KEY (`returnid`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `returnfromclient` */

insert  into `returnfromclient`(`returnid`,`clientid`,`ornum`,`itemid`,`reason`,`other`,`qty`,`datereturn`,`status`) values (1,'202212020011','202212070008',2,'Defective','',1,'2022-12-07',1),(2,'202206160006','202212090011',2,'Defective','',1,'2022-12-10',1),(3,'202206150003','202212070006',1,'Defective','',4,'2022-12-10',2);

/*Table structure for table `returns` */

DROP TABLE IF EXISTS `returns`;

CREATE TABLE `returns` (
  `returnid` int(12) NOT NULL AUTO_INCREMENT,
  `drID` int(12) NOT NULL,
  `sup_id` int(12) NOT NULL,
  `itemid` int(12) NOT NULL,
  `returnby` int(12) NOT NULL,
  `reason` varchar(255) NOT NULL,
  `other` varchar(255) NOT NULL,
  `qty` int(12) NOT NULL,
  `datereturn` date NOT NULL,
  `status` int(12) NOT NULL,
  PRIMARY KEY (`returnid`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

/*Data for the table `returns` */

insert  into `returns`(`returnid`,`drID`,`sup_id`,`itemid`,`returnby`,`reason`,`other`,`qty`,`datereturn`,`status`) values (1,2212,1,2,1,'Defective','',1,'2022-12-07',2),(2,534554646,1,3,1,'Defective','',3,'2022-12-09',2),(3,2147483647,1,10,1,'Defective','',2,'2022-12-10',2),(4,5123523,1,1,1,'Defective','',3,'2022-12-10',2),(5,5123523,1,1,2,'Defective','',2,'2022-12-10',2),(6,2147483647,1,10,2,'Defective','',3,'2022-12-10',2);

/*Table structure for table `returntoclient` */

DROP TABLE IF EXISTS `returntoclient`;

CREATE TABLE `returntoclient` (
  `recsup` int(12) NOT NULL AUTO_INCREMENT,
  `transno` varchar(12) NOT NULL,
  `itemid` int(12) NOT NULL,
  `qty` int(12) NOT NULL,
  PRIMARY KEY (`recsup`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `returntoclient` */

insert  into `returntoclient`(`recsup`,`transno`,`itemid`,`qty`) values (1,'202212070006',1,4);

/*Table structure for table `sales` */

DROP TABLE IF EXISTS `sales`;

CREATE TABLE `sales` (
  `salesid` int(12) NOT NULL AUTO_INCREMENT,
  `itemid` int(12) NOT NULL,
  `quantity` int(12) NOT NULL,
  PRIMARY KEY (`salesid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `sales` */

insert  into `sales`(`salesid`,`itemid`,`quantity`) values (1,2,7),(2,1,3);

/*Table structure for table `sales2` */

DROP TABLE IF EXISTS `sales2`;

CREATE TABLE `sales2` (
  `salesid` int(12) NOT NULL AUTO_INCREMENT,
  `itemid` int(12) NOT NULL,
  `quantity` int(12) NOT NULL,
  `transno2` varchar(255) NOT NULL,
  `tDate` date NOT NULL,
  `typepay` int(12) NOT NULL,
  PRIMARY KEY (`salesid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `sales2` */

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
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4;

/*Data for the table `stocks` */

insert  into `stocks`(`stockid`,`itemid`,`quantity`) values (1,1,13),(2,2,5),(3,3,2),(4,4,0),(5,5,0),(6,6,0),(7,7,0),(8,8,0),(9,9,0),(10,10,12),(11,11,0),(12,12,0),(13,13,0),(14,14,0),(15,15,0),(16,16,0),(17,17,0),(18,18,0),(19,19,0),(20,20,0),(21,21,0),(22,22,0),(23,23,0),(24,24,0),(25,25,0),(26,26,0),(27,27,0),(28,28,0),(29,29,0),(30,30,0);

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `sup_item` */

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
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4;

/*Data for the table `supplier` */

insert  into `supplier`(`sup_id`,`sup_cname`,`sup_name`,`contact`,`emailadd`,`house`,`brgy`,`city`,`status`) values (1,'TM',NULL,'0915645987','TM@GMAIL.COM','GREENFIELDS','BRGY PASONG TAMO','QUEZON CITY',1),(2,'GLOBE',NULL,'0945564897','GLOBE@GMAIL.COM','SACREDHEART','BRGY PASONG PUTIK PROPER','QUEZON CITY',1),(3,'TNT',NULL,'094567981','TNT@GMAIL.COM','DEMINAY ST','BRGY SITO PULO','CALOOCAN CITY',1),(4,'FURNITURE EYES',NULL,'09638885513','DDXEAP7@YANDEX.CFD','NATIONAL HIGHWAY','GUSA','CAGAYAN DE ORO CITY',1),(5,'FURNITURE EXCHANGE',NULL,'8132449','SOFIAIBRAGIMOVA@GMAILNI.COM','CONDOMINIUM 10 TOWR 2','CITYLAND','MAKATI CITY',1),(6,'INLAND FURNITURE',NULL,'6373570','WASEEMALI628@ONEMAHANET.COM','ORTIGAS CENTER','ADB AVENUE','PASIG CITY',1),(7,'ENTITY FURNITURE',NULL,'8303073','S161268@BHARATASUPERFUR.COM','V.A. RUFINO STREETS','SALCEDO','MAKATI CITY',1),(8,'INTACT FURNITURE',NULL,'8961230','DAETR@GKQIL.COM','A P REYES GATE','CARMONA 1200','MAKATI CITY',1),(9,'FURNITURE WEST',NULL,'723474','ALIGIRSCH@GKQIL.COM','J.R BORJA','DON A. VELEZ ','CAGAYAN DE ORO',1),(10,'FURNITURE SPOTS',NULL,'8332876','ANTC2JANTR@SIPSTRORE.COM','PARK AVENUE','21143 UNIT','PASAY CITY',1),(11,'VERTIX FURNITURE',NULL,'5111568','RANDYM26@KONGSHUON.COM','DEL PILAR','MAHARLIKA','NUEVA ECIJA',1),(12,'INTEGRATE FURNITURE',NULL,'2932659','DOBROGROZAN@NBOBD.COM','DE LEON','92 GEN. T','VALENZUELA CITY',1),(13,'PALMTREE FURNITURE',NULL,'0956783123','SSS@OMTECHA.COM','2115 C.M.','RECTO AVENUE','MANILA CITY',1),(14,'NEW ORLEANS',NULL,'812394','NW@GMAIL.COM','CAMACHILE ST.','BRGY SITIO MANU','QUEZON CITY',1),(15,'PRINTEX FURNITURES',NULL,'09581283723','PFURNITURES@YAHOO.COM','PICOLO ST.','BRGY SAN JUAN','MALABON CITY',1),(16,'NEW WAVE',NULL,'0985742124','NEWWAVE@CMAIL.COM','MAHARLIKA ST.','BRGY STO NINO','CALOOCAN CITY',1);

/*Table structure for table `tblinout` */

DROP TABLE IF EXISTS `tblinout`;

CREATE TABLE `tblinout` (
  `attendID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `position` varchar(50) NOT NULL,
  `activity` varchar(150) NOT NULL,
  `date` varchar(50) NOT NULL,
  PRIMARY KEY (`attendID`)
) ENGINE=MyISAM AUTO_INCREMENT=229 DEFAULT CHARSET=latin1;

/*Data for the table `tblinout` */

insert  into `tblinout`(`attendID`,`username`,`position`,`activity`,`date`) values (1,'Admin','Admin','Successfully logged in','2022-12-07 03:38:24 PM'),(2,'Admin','Admin','Successfully logged in','2022-12-07 03:42:28 PM'),(3,'Admin','Admin','Successfully logged in','2022-12-07 03:43:18 PM'),(4,'Admin','Admin','Successfully logged in','2022-12-07 03:44:19 PM'),(5,'Admin','Admin','Successfully logged in','2022-12-07 03:46:10 PM'),(6,'Admin','Admin','Successfully logged out','2022-12-07 03:47:22 PM'),(7,'Admin','Admin','Successfully logged in','2022-12-07 03:54:26 PM'),(8,'Admin','Admin','Successfully logged in','2022-12-07 03:54:52 PM'),(9,'Admin','Admin','Successfully logged in','2022-12-07 03:55:31 PM'),(10,'Admin','Admin','Successfully logged in','2022-12-07 03:56:09 PM'),(11,'Admin','Admin','Successfully logged in','2022-12-07 03:57:51 PM'),(12,'Admin','Admin','Successfully logged in','2022-12-07 03:58:06 PM'),(13,'Admin','Admin','Successfully logged in','2022-12-07 04:00:35 PM'),(14,'Admin','Admin','Successfully logged in','2022-12-07 04:28:44 PM'),(15,'Admin','Admin','Successfully logged in','2022-12-07 04:31:45 PM'),(16,'Admin','Admin','Successfully logged in','2022-12-07 05:07:24 PM'),(17,'Admin','Admin','Successfully logged in','2022-12-07 05:13:05 PM'),(18,'Admin','Admin','Successfully logged in','2022-12-07 06:22:24 PM'),(19,'Admin','Admin','Successfully logged in','2022-12-07 06:35:33 PM'),(20,'Admin','Admin','Successfully logged out','2022-12-07 06:37:07 PM'),(21,'Admin','Admin','Successfully logged in','2022-12-07 06:58:14 PM'),(22,'Admin','Admin','Successfully logged in','2022-12-07 06:58:34 PM'),(23,'Admin','Admin','Successfully logged in','2022-12-07 06:59:10 PM'),(24,'Admin','Admin','Successfully logged in','2022-12-07 07:04:33 PM'),(25,'Admin','Admin','Successfully logged in','2022-12-07 07:06:36 PM'),(26,'Admin','Admin','Successfully logged in','2022-12-07 07:11:22 PM'),(27,'Admin','Admin','Successfully logged in','2022-12-07 07:12:43 PM'),(28,'Admin','Admin','Successfully logged in','2022-12-07 07:13:21 PM'),(29,'Admin','Admin','Successfully logged in','2022-12-07 07:13:52 PM'),(30,'Admin','Admin','Successfully logged in','2022-12-07 07:14:15 PM'),(31,'Admin','Admin','Successfully logged in','2022-12-07 07:14:38 PM'),(32,'Admin','Admin','Successfully logged in','2022-12-07 07:15:17 PM'),(33,'Admin','Admin','Successfully logged in','2022-12-07 07:34:14 PM'),(34,'Admin','Admin','Successfully logged in','2022-12-07 07:35:07 PM'),(35,'Admin','Admin','Successfully logged in','2022-12-07 07:36:14 PM'),(36,'Admin','Admin','Successfully logged in','2022-12-07 07:36:51 PM'),(37,'Admin','Admin','Successfully logged in','2022-12-07 07:37:41 PM'),(38,'Admin','Admin','Successfully logged in','2022-12-07 07:38:34 PM'),(39,'Admin','Admin','Successfully logged in','2022-12-07 07:38:58 PM'),(40,'Admin','Admin','Successfully logged in','2022-12-07 07:39:59 PM'),(41,'Admin','Admin','Successfully logged in','2022-12-07 07:40:36 PM'),(42,'Admin','Admin','Successfully logged in','2022-12-07 07:41:04 PM'),(43,'Admin','Admin','Successfully logged in','2022-12-07 07:41:56 PM'),(44,'Admin','Admin','Successfully logged in','2022-12-07 07:42:28 PM'),(45,'Admin','Admin','Successfully logged in','2022-12-07 08:06:47 PM'),(46,'Admin','Admin','Successfully logged in','2022-12-07 08:07:29 PM'),(47,'Admin','Admin','Successfully logged in','2022-12-07 08:09:24 PM'),(48,'Admin','Admin','Successfully logged in','2022-12-07 08:19:51 PM'),(49,'Admin','Admin','Successfully logged in','2022-12-07 08:22:02 PM'),(50,'Admin','Admin','Successfully logged in','2022-12-07 08:23:30 PM'),(51,'Admin','Admin','Successfully logged in','2022-12-07 08:25:18 PM'),(52,'Admin','Admin','Successfully logged in','2022-12-07 08:25:57 PM'),(53,'Admin','Admin','Successfully logged in','2022-12-07 08:27:41 PM'),(54,'Admin','Admin','Successfully logged in','2022-12-07 08:32:09 PM'),(55,'Admin','Admin','Successfully logged out','2022-12-07 08:35:09 PM'),(56,'Admin','Admin','Successfully logged in','2022-12-07 08:39:54 PM'),(57,'Admin','Admin','Successfully logged in','2022-12-07 08:41:59 PM'),(58,'Admin','Admin','Successfully logged in','2022-12-07 08:42:33 PM'),(59,'Admin','Admin','Successfully logged in','2022-12-07 08:52:04 PM'),(60,'Admin','Admin','Successfully logged in','2022-12-07 08:54:06 PM'),(61,'Admin','Admin','Successfully logged in','2022-12-07 08:56:30 PM'),(62,'Admin','Admin','Successfully logged in','2022-12-07 08:58:04 PM'),(63,'Admin','Admin','Successfully logged in','2022-12-08 09:13:15 AM'),(64,'Admin','Admin','Successfully logged in','2022-12-08 09:15:27 AM'),(65,'Admin','Admin','Successfully logged in','2022-12-08 09:16:01 AM'),(66,'Admin','Admin','Successfully logged in','2022-12-08 09:16:27 AM'),(67,'Admin','Admin','Successfully logged in','2022-12-08 09:17:38 AM'),(68,'Admin','Admin','Successfully logged in','2022-12-08 09:18:17 AM'),(69,'Admin','Admin','Successfully logged in','2022-12-08 09:18:38 AM'),(70,'Admin','Admin','Successfully logged in','2022-12-08 09:19:08 AM'),(71,'Admin','Admin','Successfully logged in','2022-12-08 09:21:14 AM'),(72,'Admin','Admin','Successfully logged in','2022-12-08 09:21:37 AM'),(73,'Admin','Admin','Successfully logged in','2022-12-08 09:22:11 AM'),(74,'Admin','Admin','Successfully logged in','2022-12-08 09:22:33 AM'),(75,'Admin','Admin','Successfully logged in','2022-12-08 09:24:17 AM'),(76,'Admin','Admin','Successfully logged in','2022-12-08 09:27:46 AM'),(77,'Admin','Admin','Successfully logged in','2022-12-08 09:29:01 AM'),(78,'Admin','Admin','Successfully logged in','2022-12-08 09:33:41 AM'),(79,'Admin','Admin','Successfully logged in','2022-12-08 09:33:56 AM'),(80,'Admin','Admin','Successfully logged in','2022-12-08 09:35:17 AM'),(81,'Admin','Admin','Successfully logged in','2022-12-08 09:37:37 AM'),(82,'Admin','Admin','Successfully logged in','2022-12-08 09:38:56 AM'),(83,'Admin','Admin','Successfully logged in','2022-12-08 09:39:27 AM'),(84,'Admin','Admin','Successfully logged in','2022-12-08 09:40:42 AM'),(85,'Admin','Admin','Successfully logged in','2022-12-08 09:41:13 AM'),(86,'Admin','Admin','Successfully logged in','2022-12-08 09:42:03 AM'),(87,'Admin','Admin','Successfully logged in','2022-12-08 09:42:39 AM'),(88,'Admin','Admin','Successfully logged in','2022-12-08 09:43:35 AM'),(89,'Admin','Admin','Successfully logged in','2022-12-08 09:43:49 AM'),(90,'Admin','Admin','Successfully logged in','2022-12-08 09:44:49 AM'),(91,'Admin','Admin','Successfully logged in','2022-12-08 09:45:49 AM'),(92,'Admin','Admin','Successfully logged in','2022-12-08 09:46:18 AM'),(93,'Admin','Admin','Successfully logged in','2022-12-08 09:47:30 AM'),(94,'Admin','Admin','Successfully logged in','2022-12-08 09:47:59 AM'),(95,'Admin','Admin','Successfully logged in','2022-12-08 09:48:18 AM'),(96,'Admin','Admin','Successfully logged in','2022-12-08 09:48:44 AM'),(97,'Admin','Admin','Successfully logged in','2022-12-08 09:49:07 AM'),(98,'Admin','Admin','Successfully logged in','2022-12-08 09:49:38 AM'),(99,'Admin','Admin','Successfully logged in','2022-12-08 09:49:57 AM'),(100,'Admin','Admin','Successfully logged in','2022-12-08 09:55:09 AM'),(101,'Admin','Admin','Successfully logged in','2022-12-08 09:56:23 AM'),(102,'Admin','Admin','Successfully logged in','2022-12-08 09:57:27 AM'),(103,'Admin','Admin','Successfully logged in','2022-12-08 10:00:29 AM'),(104,'Admin','Admin','Successfully logged in','2022-12-08 10:01:35 AM'),(105,'Admin','Admin','Successfully logged in','2022-12-08 10:21:32 AM'),(106,'Admin','Admin','Successfully logged in','2022-12-08 10:22:35 AM'),(107,'Admin','Admin','Successfully logged in','2022-12-08 10:30:56 AM'),(108,'Admin','Admin','Successfully logged in','2022-12-08 10:33:20 AM'),(109,'Admin','Admin','Successfully logged in','2022-12-08 10:40:55 AM'),(110,'Admin','Admin','Successfully logged in','2022-12-08 10:41:51 AM'),(111,'Admin','Admin','Successfully logged in','2022-12-08 10:42:43 AM'),(112,'Admin','Admin','Successfully logged in','2022-12-08 10:46:36 AM'),(113,'Admin','Admin','Successfully logged in','2022-12-08 10:52:11 AM'),(114,'Admin','Admin','Successfully logged in','2022-12-08 11:17:17 AM'),(115,'Admin','Admin','Successfully logged in','2022-12-08 11:18:35 AM'),(116,'Admin','Admin','Successfully logged in','2022-12-08 11:21:16 AM'),(117,'Admin','Admin','Successfully logged in','2022-12-08 11:21:56 AM'),(118,'DARREN D GIMENEZ','Manager','Successfully logged in','2022-12-08 11:22:42'),(119,'Admin','Admin','Successfully logged in','2022-12-08 11:24:11 AM'),(120,'Admin','Admin','Successfully logged in','2022-12-08 11:25:44 AM'),(121,'Admin','Admin','Successfully logged in','2022-12-08 11:31:50 AM'),(122,'Admin','Admin','Successfully logged out','2022-12-08 11:33:00 AM'),(123,'Admin','Admin','Successfully logged in','2022-12-09 07:47:24 AM'),(124,'Admin','Admin','Successfully logged in','2022-12-09 08:30:14 AM'),(125,'Admin','Admin','Successfully logged in','2022-12-09 08:31:30 AM'),(126,'Admin','Admin','Successfully logged in','2022-12-09 08:33:16 AM'),(127,'Admin','Admin','Successfully logged in','2022-12-09 08:34:29 AM'),(128,'Admin','Admin','Successfully logged in','2022-12-09 08:36:00 AM'),(129,'Admin','Admin','Successfully logged in','2022-12-09 08:37:41 AM'),(130,'Admin','Admin','Successfully logged in','2022-12-09 08:38:17 AM'),(131,'Admin','Admin','Successfully logged in','2022-12-09 08:39:46 AM'),(132,'Admin','Admin','Successfully logged in','2022-12-09 08:40:46 AM'),(133,'Admin','Admin','Successfully logged in','2022-12-09 08:41:38 AM'),(134,'Admin','Admin','Successfully logged in','2022-12-09 08:43:04 AM'),(135,'Admin','Admin','Successfully logged in','2022-12-09 08:46:22 AM'),(136,'Admin','Admin','Successfully logged in','2022-12-09 10:35:10 PM'),(137,'Admin','Admin','Successfully logged in','2022-12-09 10:35:49 PM'),(138,'Admin','Admin','Successfully logged in','2022-12-09 10:36:25 PM'),(139,'Admin','Admin','Successfully logged in','2022-12-09 10:37:25 PM'),(140,'Admin','Admin','Successfully logged in','2022-12-09 10:38:52 PM'),(141,'Admin','Admin','Successfully logged in','2022-12-09 10:39:29 PM'),(142,'Admin','Admin','Successfully logged in','2022-12-09 10:40:45 PM'),(143,'Admin','Admin','Successfully logged in','2022-12-09 10:42:17 PM'),(144,'Admin','Admin','Successfully logged in','2022-12-09 10:43:08 PM'),(145,'Admin','Admin','Successfully logged in','2022-12-09 10:44:06 PM'),(146,'Admin','Admin','Successfully logged in','2022-12-09 10:45:05 PM'),(147,'Admin','Admin','Successfully logged in','2022-12-09 10:46:24 PM'),(148,'Admin','Admin','Successfully logged in','2022-12-09 10:47:11 PM'),(149,'Admin','Admin','Successfully logged in','2022-12-09 10:47:57 PM'),(150,'Admin','Admin','Successfully logged in','2022-12-09 10:48:06 PM'),(151,'Admin','Admin','Successfully logged in','2022-12-09 10:49:32 PM'),(152,'Admin','Admin','Successfully logged in','2022-12-09 10:50:01 PM'),(153,'Admin','Admin','Successfully logged in','2022-12-09 10:54:54 PM'),(154,'Admin','Admin','Successfully logged in','2022-12-09 10:55:41 PM'),(155,'Admin','Admin','Successfully logged in','2022-12-09 10:56:07 PM'),(156,'Admin','Admin','Successfully logged in','2022-12-09 11:04:29 PM'),(157,'Admin','Admin','Successfully logged in','2022-12-09 11:05:12 PM'),(158,'Admin','Admin','Successfully logged in','2022-12-09 11:06:57 PM'),(159,'Admin','Admin','Successfully logged in','2022-12-09 11:07:54 PM'),(160,'Admin','Admin','Successfully logged in','2022-12-09 11:11:17 PM'),(161,'Admin','Admin','Successfully logged in','2022-12-09 11:17:55 PM'),(162,'Admin','Admin','Successfully logged in','2022-12-09 11:18:24 PM'),(163,'Admin','Admin','Successfully logged in','2022-12-09 11:24:11 PM'),(164,'Admin','Admin','Successfully logged in','2022-12-09 11:33:36 PM'),(165,'Admin','Admin','Successfully logged in','2022-12-09 11:34:19 PM'),(166,'Admin','Admin','Successfully logged in','2022-12-09 11:42:36 PM'),(167,'Admin','Admin','Successfully logged in','2022-12-09 11:43:50 PM'),(168,'Admin','Admin','Successfully logged in','2022-12-10 12:06:23 AM'),(169,'Admin','Admin','Successfully logged in','2022-12-10 12:07:00 AM'),(170,'Admin','Admin','Successfully logged in','2022-12-10 12:07:51 AM'),(171,'Admin','Admin','Successfully logged in','2022-12-10 12:08:33 AM'),(172,'Admin','Admin','Successfully logged in','2022-12-10 12:10:05 AM'),(173,'Admin','Admin','Successfully logged in','2022-12-10 12:11:53 AM'),(174,'Admin','Admin','Successfully logged in','2022-12-10 12:12:25 AM'),(175,'Admin','Admin','Successfully logged in','2022-12-10 12:12:50 AM'),(176,'Admin','Admin','Successfully logged in','2022-12-10 12:13:24 AM'),(177,'Admin','Admin','Successfully logged in','2022-12-10 12:13:54 AM'),(178,'Admin','Admin','Successfully logged in','2022-12-10 12:15:10 AM'),(179,'Admin','Admin','Successfully logged in','2022-12-10 12:15:42 AM'),(180,'Admin','Admin','Successfully logged in','2022-12-10 12:17:33 AM'),(181,'Admin','Admin','Successfully logged in','2022-12-10 12:18:06 AM'),(182,'Admin','Admin','Successfully logged in','2022-12-10 12:23:07 AM'),(183,'Admin','Admin','Successfully logged in','2022-12-10 12:38:50 AM'),(184,'Admin','Admin','Successfully logged in','2022-12-10 12:40:22 AM'),(185,'Admin','Admin','Successfully logged in','2022-12-10 12:41:00 AM'),(186,'Admin','Admin','Successfully logged in','2022-12-10 12:42:59 AM'),(187,'Admin','Admin','Successfully logged in','2022-12-10 12:43:31 AM'),(188,'Admin','Admin','Successfully logged in','2022-12-10 12:44:18 AM'),(189,'Admin','Admin','Successfully logged in','2022-12-10 12:54:48 AM'),(190,'Admin','Admin','Successfully logged in','2022-12-10 12:58:37 AM'),(191,'Admin','Admin','Successfully logged in','2022-12-10 12:59:27 AM'),(192,'Admin','Admin','Successfully logged in','2022-12-10 01:01:35 AM'),(193,'Admin','Admin','Successfully logged in','2022-12-10 01:02:43 AM'),(194,'Admin','Admin','Successfully logged in','2022-12-10 01:06:51 AM'),(195,'Admin','Admin','Successfully logged in','2022-12-10 01:07:34 AM'),(196,'Admin','Admin','Successfully logged in','2022-12-10 01:08:27 AM'),(197,'Admin','Admin','Successfully logged in','2022-12-10 01:09:06 AM'),(198,'Admin','Admin','Successfully logged in','2022-12-10 01:09:37 AM'),(199,'Admin','Admin','Successfully logged in','2022-12-10 01:10:01 AM'),(200,'Admin','Admin','Successfully logged in','2022-12-10 01:14:18 AM'),(201,'Admin','Admin','Successfully logged in','2022-12-10 01:14:51 AM'),(202,'Admin','Admin','Successfully logged in','2022-12-10 01:15:19 AM'),(203,'Admin','Admin','Successfully logged in','2022-12-10 01:23:26 AM'),(204,'Admin','Admin','Successfully logged in','2022-12-10 01:29:34 AM'),(205,'Admin','Admin','Successfully logged in','2022-12-10 01:33:46 AM'),(206,'Admin','Admin','Successfully logged in','2022-12-10 01:35:05 AM'),(207,'Admin','Admin','Successfully logged in','2022-12-10 01:36:57 AM'),(208,'Admin','Admin','Successfully logged in','2022-12-10 01:53:08 AM'),(209,'Admin','Admin','Successfully logged in','2022-12-10 01:54:10 AM'),(210,'Admin','Admin','Successfully logged in','2022-12-10 01:55:20 AM'),(211,'Admin','Admin','Successfully logged in','2022-12-10 01:55:59 AM'),(212,'Admin','Admin','Successfully logged in','2022-12-10 01:56:48 AM'),(213,'Admin','Admin','Successfully logged in','2022-12-10 01:58:06 AM'),(214,'Admin','Admin','Successfully logged in','2022-12-10 02:07:59 AM'),(215,'Admin','Admin','Successfully logged in','2022-12-10 02:10:48 AM'),(216,'Admin','Admin','Successfully logged in','2022-12-10 02:14:10 AM'),(217,'Admin','Admin','Successfully logged in','2022-12-10 02:16:12 AM'),(218,'Admin','Admin','Successfully logged in','2022-12-10 02:16:42 AM'),(219,'Admin','Admin','Successfully logged in','2022-12-10 02:24:08 AM'),(220,'Admin','Admin','Successfully logged in','2022-12-10 02:26:40 AM'),(221,'Admin','Admin','Successfully logged in','2022-12-10 02:27:44 AM'),(222,'Admin','Admin','Successfully logged in','2022-12-10 02:28:54 AM'),(223,'Admin','Admin','Successfully logged in','2022-12-10 02:31:14 AM'),(224,'Admin','Admin','Successfully logged in','2022-12-10 02:33:34 AM'),(225,'Admin','Admin','Successfully logged in','2022-12-10 02:35:44 AM'),(226,'Admin','Admin','Successfully logged in','2022-12-10 02:36:15 AM'),(227,'Admin','Admin','Successfully logged in','2022-12-10 02:38:22 AM'),(228,'Admin','Admin','Successfully logged in','2022-12-10 02:40:53 AM');

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
  `status` int(10) NOT NULL,
  PRIMARY KEY (`transId`)
) ENGINE=MyISAM AUTO_INCREMENT=73 DEFAULT CHARSET=latin1;

/*Data for the table `temp_transaction` */

/*Table structure for table `totalsales` */

DROP TABLE IF EXISTS `totalsales`;

CREATE TABLE `totalsales` (
  `salesid` int(12) NOT NULL AUTO_INCREMENT,
  `itemid` int(12) NOT NULL,
  `quantity` int(12) NOT NULL,
  `transno` varchar(255) NOT NULL,
  `tDate` date NOT NULL,
  `typepay` int(12) NOT NULL,
  PRIMARY KEY (`salesid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `totalsales` */

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
  `tDate` date NOT NULL,
  `empID` int(10) NOT NULL,
  PRIMARY KEY (`transId`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

/*Data for the table `transaction` */

insert  into `transaction`(`transId`,`transdetailsId`,`totalstockId`,`qty`,`totalprice`,`ornum`,`clientID`,`numberofitems`,`tDate`,`empID`) values (1,0,2,3,22500.00,'202212070001',202212020011,1,'2022-12-07',0),(2,2,2,1,7500.00,'202212070002',202212020011,1,'2022-12-07',0),(3,3,1,3,13500.00,'202212070003',202212020011,1,'2022-12-07',0),(4,4,2,1,7500.00,'202212070004',202212020011,1,'2022-12-07',0),(5,5,2,4,30000.00,'202212070005',202212020011,1,'2022-12-07',0),(6,6,1,0,18000.00,'202212070006',202206150003,1,'2022-12-07',0),(7,7,2,1,7500.00,'202212070007',20220614002,1,'2022-12-07',0),(8,8,2,0,7500.00,'202212070008',202212020011,1,'2022-12-07',0),(9,9,1,0,4500.00,'202212070009',202212020011,1,'2022-12-07',0),(10,10,2,1,7500.00,'202212080010',202212020011,1,'2022-12-08',0),(11,11,2,0,7500.00,'202212090011',202206160006,1,'2022-12-09',0);

/*Table structure for table `transaction2` */

DROP TABLE IF EXISTS `transaction2`;

CREATE TABLE `transaction2` (
  `transId` int(10) NOT NULL AUTO_INCREMENT,
  `transdetailsId` int(10) NOT NULL,
  `totalstockId` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `totalprice` double(10,2) NOT NULL,
  `ornum` varchar(50) NOT NULL,
  `clientID` bigint(15) NOT NULL,
  `numberofitems` int(12) NOT NULL,
  `tDate` date NOT NULL,
  `empID` int(10) NOT NULL,
  PRIMARY KEY (`transId`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `transaction2` */

insert  into `transaction2`(`transId`,`transdetailsId`,`totalstockId`,`qty`,`totalprice`,`ornum`,`clientID`,`numberofitems`,`tDate`,`empID`) values (1,5,2,1,7500.00,'202212080005',202210060010,1,'2022-12-08',0);

/*Table structure for table `transaction_details` */

DROP TABLE IF EXISTS `transaction_details`;

CREATE TABLE `transaction_details` (
  `transdetailsId` int(10) NOT NULL AUTO_INCREMENT,
  `amountTendered` double(10,2) NOT NULL,
  `Discount` int(10) NOT NULL,
  `delfee` double(10,2) NOT NULL,
  `totaDueAmount` double(10,2) NOT NULL,
  `amountChange` double(10,2) NOT NULL,
  `tDate` date NOT NULL,
  `transNo` varchar(50) NOT NULL,
  `clientid` bigint(15) NOT NULL,
  `numberofitems` int(10) NOT NULL,
  `noi` int(12) NOT NULL,
  PRIMARY KEY (`transdetailsId`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

/*Data for the table `transaction_details` */

insert  into `transaction_details`(`transdetailsId`,`amountTendered`,`Discount`,`delfee`,`totaDueAmount`,`amountChange`,`tDate`,`transNo`,`clientid`,`numberofitems`,`noi`) values (1,23875.00,5,2500.00,23875.00,0.00,'2022-07-12','202212070001',202212020011,0,1),(2,9650.00,5,2500.00,9625.00,25.00,'2022-07-12','202212070002',202212020011,0,1),(3,12850.00,5,0.00,12825.00,25.00,'2022-07-12','202212070003',202212020011,0,1),(4,7125.00,5,0.00,7125.00,0.00,'2022-07-12','202212070004',202212020011,0,1),(5,31000.00,5,2500.00,31000.00,0.00,'2022-07-12','202212070005',202212020011,0,1),(6,17100.00,5,0.00,17100.00,0.00,'2022-07-12','202212070006',202206150003,0,1),(7,9625.00,5,2500.00,9625.00,0.00,'2022-07-12','202212070007',20220614002,0,1),(8,9625.00,5,2500.00,9625.00,0.00,'2022-07-12','202212070008',202212020011,0,1),(9,6775.00,5,2500.00,6775.00,0.00,'2022-07-12','202212070009',202212020011,0,1),(10,9625.00,5,2500.00,9625.00,0.00,'2022-08-12','202212080010',202212020011,0,1),(11,9625.00,5,2500.00,9625.00,0.00,'2022-09-12','202212090011',202206160006,0,1);

/*Table structure for table `transaction_details2` */

DROP TABLE IF EXISTS `transaction_details2`;

CREATE TABLE `transaction_details2` (
  `transdetailsId` int(10) NOT NULL AUTO_INCREMENT,
  `amountTendered` double(10,2) NOT NULL,
  `Discount` int(10) NOT NULL,
  `delfee` double(10,2) NOT NULL,
  `totaDueAmount` double(10,2) NOT NULL,
  `currentBal` double(10,2) NOT NULL,
  `tDate` date NOT NULL,
  `transNo` varchar(50) NOT NULL,
  `clientid` bigint(15) NOT NULL,
  `numberofitems` int(12) NOT NULL,
  `finalpayment` double(10,2) NOT NULL,
  `change` double(10,2) NOT NULL,
  `changes` double(10,2) NOT NULL,
  `isPaid` int(12) NOT NULL,
  PRIMARY KEY (`transdetailsId`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `transaction_details2` */

insert  into `transaction_details2`(`transdetailsId`,`amountTendered`,`Discount`,`delfee`,`totaDueAmount`,`currentBal`,`tDate`,`transNo`,`clientid`,`numberofitems`,`finalpayment`,`change`,`changes`,`isPaid`) values (1,3500.00,5,2500.00,4275.00,3275.00,'2022-07-12','202212070001',202206160004,1,3275.00,0.00,0.00,1),(2,3500.00,5,2500.00,7125.00,6125.00,'2022-08-12','202212080002',202210060010,1,0.00,0.00,0.00,0),(3,3500.00,5,2500.00,6775.00,3275.00,'2022-08-12','202212080003',202210060010,1,0.00,0.00,0.00,0),(4,4500.00,5,2500.00,9625.00,5125.00,'2022-08-12','202212080004',202210060010,1,0.00,0.00,0.00,0),(5,4500.00,5,2500.00,9625.00,5125.00,'2022-08-12','202212080005',202210060010,1,0.00,0.00,0.00,0);

/*Table structure for table `updatepayment` */

DROP TABLE IF EXISTS `updatepayment`;

CREATE TABLE `updatepayment` (
  `paymentid` int(12) NOT NULL AUTO_INCREMENT,
  `paymenttype` varchar(255) NOT NULL,
  `paymentdetails` varchar(255) NOT NULL,
  `Amount` double(10,2) NOT NULL,
  `transno` varchar(155) NOT NULL,
  `referenceno` varchar(255) NOT NULL,
  `clientid` varchar(255) NOT NULL,
  `status` int(12) NOT NULL,
  PRIMARY KEY (`paymentid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `updatepayment` */

insert  into `updatepayment`(`paymentid`,`paymenttype`,`paymentdetails`,`Amount`,`transno`,`referenceno`,`clientid`,`status`) values (1,'2','09100765122',3275.00,'202212070001','4321234','202206160004',1);

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
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `void` */

/*Table structure for table `vwclient` */

DROP TABLE IF EXISTS `vwclient`;

/*!50001 DROP VIEW IF EXISTS `vwclient` */;
/*!50001 DROP TABLE IF EXISTS `vwclient` */;

/*!50001 CREATE TABLE  `vwclient`(
 `custID` int(12) unsigned ,
 `Iddetails` bigint(15) ,
 `clientname` varchar(512) ,
 `address` varchar(511) ,
 `contactno` varchar(12) ,
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
 `contactno` varchar(12) ,
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

/*Table structure for table `vw_emps` */

DROP TABLE IF EXISTS `vw_emps`;

/*!50001 DROP VIEW IF EXISTS `vw_emps` */;
/*!50001 DROP TABLE IF EXISTS `vw_emps` */;

/*!50001 CREATE TABLE  `vw_emps`(
 `empid` int(12) ,
 `fname` varchar(255) ,
 `mname` varchar(255) ,
 `lname` varchar(255) ,
 `dob` date ,
 `uname` varchar(255) ,
 `password` varchar(255) ,
 `lvl_id` int(12) ,
 `level` varchar(150) ,
 `date_in` date ,
 `isActive` int(12) 
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

/*Table structure for table `vw_inv2` */

DROP TABLE IF EXISTS `vw_inv2`;

/*!50001 DROP VIEW IF EXISTS `vw_inv2` */;
/*!50001 DROP TABLE IF EXISTS `vw_inv2` */;

/*!50001 CREATE TABLE  `vw_inv2`(
 `stockid` int(12) ,
 `itemcode` varchar(255) ,
 `itemtype` varchar(255) ,
 `Description` varchar(255) ,
 `UnitP` double(9,2) ,
 `quantity` int(12) ,
 `total` double(19,2) 
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

/*Table structure for table `vw_items` */

DROP TABLE IF EXISTS `vw_items`;

/*!50001 DROP VIEW IF EXISTS `vw_items` */;
/*!50001 DROP TABLE IF EXISTS `vw_items` */;

/*!50001 CREATE TABLE  `vw_items`(
 `itemid` int(12) ,
 `itemcode` varchar(255) ,
 `itemtype` varchar(255) ,
 `Description` varchar(255) ,
 `price` double(9,2) ,
 `UnitP` double(9,2) ,
 `suppid` int(12) 
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
 `referenceno` varchar(155) ,
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
 `referenceno` varchar(255) ,
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
 `tDate` date ,
 `finalpayment` double(10,2) ,
 `changes` double(10,2) ,
 `isPaid` int(12) 
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
 `tDate` date 
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
 `tDate` date 
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
 `tDate` date 
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

/*Table structure for table `vw_polistwdel` */

DROP TABLE IF EXISTS `vw_polistwdel`;

/*!50001 DROP VIEW IF EXISTS `vw_polistwdel` */;
/*!50001 DROP TABLE IF EXISTS `vw_polistwdel` */;

/*!50001 CREATE TABLE  `vw_polistwdel`(
 `ruID` int(12) ,
 `drID` varchar(255) ,
 `ponum` varchar(150) ,
 `itemid` int(12) ,
 `itemcode` varchar(255) ,
 `itemtype` varchar(255) ,
 `description` varchar(255) ,
 `price` double(9,2) ,
 `quantity` int(12) ,
 `sup_id` int(12) ,
 `sup_cname` varchar(255) ,
 `dateissue` date ,
 `expecdate` date ,
 `dateDelivered` date 
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

/*Table structure for table `vw_return` */

DROP TABLE IF EXISTS `vw_return`;

/*!50001 DROP VIEW IF EXISTS `vw_return` */;
/*!50001 DROP TABLE IF EXISTS `vw_return` */;

/*!50001 CREATE TABLE  `vw_return`(
 `returnid` int(12) ,
 `drID` int(12) ,
 `sup_id` int(12) ,
 `sup_cname` varchar(255) ,
 `itemid` int(12) ,
 `itemcode` varchar(255) ,
 `itemtype` varchar(255) ,
 `price` double(9,2) ,
 `qty` int(12) ,
 `fullname` text ,
 `reason` varchar(255) ,
 `other` varchar(255) ,
 `datereturn` date ,
 `statid` int(12) ,
 `status` varchar(255) 
)*/;

/*Table structure for table `vw_returnfromclient1` */

DROP TABLE IF EXISTS `vw_returnfromclient1`;

/*!50001 DROP VIEW IF EXISTS `vw_returnfromclient1` */;
/*!50001 DROP TABLE IF EXISTS `vw_returnfromclient1` */;

/*!50001 CREATE TABLE  `vw_returnfromclient1`(
 `returnid` int(12) ,
 `clientname` varchar(512) ,
 `ornum` varchar(255) ,
 `itemid` int(12) ,
 `itemcode` varchar(255) ,
 `itemtype` varchar(255) ,
 `unitp` double(9,2) ,
 `qty` int(12) ,
 `reason` varchar(255) ,
 `other` varchar(255) ,
 `datereturn` date ,
 `statusid` int(12) ,
 `status` varchar(255) 
)*/;

/*Table structure for table `vw_sales` */

DROP TABLE IF EXISTS `vw_sales`;

/*!50001 DROP VIEW IF EXISTS `vw_sales` */;
/*!50001 DROP TABLE IF EXISTS `vw_sales` */;

/*!50001 CREATE TABLE  `vw_sales`(
 `itemid` int(12) ,
 `quantity` bigint(13) 
)*/;

/*Table structure for table `vw_salestrans` */

DROP TABLE IF EXISTS `vw_salestrans`;

/*!50001 DROP VIEW IF EXISTS `vw_salestrans` */;
/*!50001 DROP TABLE IF EXISTS `vw_salestrans` */;

/*!50001 CREATE TABLE  `vw_salestrans`(
 `transId` int(10) ,
 `totalstockid` int(11) ,
 `itemcode` varchar(255) ,
 `itemtype` varchar(255) ,
 `description` varchar(255) ,
 `Unitp` double(9,2) ,
 `qty` int(11) ,
 `totalprice` double(10,2) ,
 `ornum` varchar(50) ,
 `tDate` date ,
 `clientID` bigint(15) ,
 `clientname` varchar(512) 
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
 `price` double(9,2) ,
 `UnitP` double(9,2) 
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
 `tDate` date ,
 `finalpayment` double(10,2) ,
 `changes` double(10,2) ,
 `isPaid` int(12) 
)*/;

/*Table structure for table `vw_updatepaymenttttt` */

DROP TABLE IF EXISTS `vw_updatepaymenttttt`;

/*!50001 DROP VIEW IF EXISTS `vw_updatepaymenttttt` */;
/*!50001 DROP TABLE IF EXISTS `vw_updatepaymenttttt` */;

/*!50001 CREATE TABLE  `vw_updatepaymenttttt`(
 `paymentid` int(12) ,
 `paymentname` varchar(155) ,
 `paymentdetails` varchar(255) ,
 `Amount` double(10,2) ,
 `transno` varchar(155) ,
 `clientid` varchar(255) ,
 `status` int(12) 
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

/*View structure for view vw_emps */

/*!50001 DROP TABLE IF EXISTS `vw_emps` */;
/*!50001 DROP VIEW IF EXISTS `vw_emps` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_emps` AS select `e`.`empID` AS `empid`,`e`.`fname` AS `fname`,`e`.`mname` AS `mname`,`e`.`lname` AS `lname`,`e`.`dob` AS `dob`,`e`.`uname` AS `uname`,`e`.`password` AS `password`,`e`.`lvl_id` AS `lvl_id`,`p`.`level` AS `level`,`e`.`date_in` AS `date_in`,`e`.`isActive` AS `isActive` from (`employee` `e` join `position` `p` on(`p`.`lvl_id` = `e`.`lvl_id`)) */;

/*View structure for view vw_inv */

/*!50001 DROP TABLE IF EXISTS `vw_inv` */;
/*!50001 DROP VIEW IF EXISTS `vw_inv` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_inv` AS select `s`.`stockid` AS `stockid`,`p`.`itemcode` AS `itemcode`,`p`.`itemtype` AS `itemtype`,`p`.`Description` AS `Description`,`p`.`Price` AS `Price`,`p`.`UnitP` AS `UnitP`,`s`.`quantity` AS `quantity` from (`vw_prod` `p` join `stocks` `s` on(`s`.`itemid` = `p`.`itemid`)) */;

/*View structure for view vw_inv2 */

/*!50001 DROP TABLE IF EXISTS `vw_inv2` */;
/*!50001 DROP VIEW IF EXISTS `vw_inv2` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_inv2` AS select `s`.`stockid` AS `stockid`,`p`.`itemcode` AS `itemcode`,`p`.`itemtype` AS `itemtype`,`p`.`Description` AS `Description`,`p`.`UnitP` AS `UnitP`,`s`.`quantity` AS `quantity`,`s`.`quantity` * `p`.`UnitP` AS `total` from (`vw_prod` `p` join `stocks` `s` on(`s`.`itemid` = `p`.`itemid`)) */;

/*View structure for view vw_item */

/*!50001 DROP TABLE IF EXISTS `vw_item` */;
/*!50001 DROP VIEW IF EXISTS `vw_item` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_item` AS select `s`.`stockid` AS `stockid`,`i`.`itemid` AS `itemid`,`i`.`itemcode` AS `itemcode`,`t`.`ItemType` AS `itemtype`,`i`.`price` AS `Price`,`i`.`UnitP` AS `UnitP`,`s`.`quantity` AS `quantity` from ((`stocks` `s` join `items` `i` on(`s`.`itemid` = `i`.`itemid`)) join `itemtype` `t` on(`i`.`typeid` = `t`.`typeid`)) */;

/*View structure for view vw_items */

/*!50001 DROP TABLE IF EXISTS `vw_items` */;
/*!50001 DROP VIEW IF EXISTS `vw_items` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_items` AS select `i`.`itemid` AS `itemid`,`i`.`itemcode` AS `itemcode`,`t`.`ItemType` AS `itemtype`,`i`.`Description` AS `Description`,`i`.`price` AS `price`,`i`.`UnitP` AS `UnitP`,`i`.`suppid` AS `suppid` from (`items` `i` join `itemtype` `t` on(`t`.`typeid` = `i`.`typeid`)) */;

/*View structure for view vw_payment */

/*!50001 DROP TABLE IF EXISTS `vw_payment` */;
/*!50001 DROP VIEW IF EXISTS `vw_payment` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_payment` AS select `p`.`paymentid` AS `paymentid`,`pt`.`paymentname` AS `paymentname`,`p`.`paymentdetails` AS `paymentdetails`,`p`.`Amount` AS `Amount`,`p`.`transno` AS `transno`,`p`.`referenceno` AS `referenceno`,`p`.`clientid` AS `clientid`,`p`.`status` AS `status` from (`payment` `p` join `paymenttype` `pt` on(`p`.`paymenttype` = `pt`.`paymentid`)) */;

/*View structure for view vw_payment2 */

/*!50001 DROP TABLE IF EXISTS `vw_payment2` */;
/*!50001 DROP VIEW IF EXISTS `vw_payment2` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_payment2` AS select `pc`.`paymentid` AS `paymentid`,`pt`.`paymentname` AS `paymentname`,`pc`.`paymentdetails` AS `paymentdetails`,`pc`.`Amount` AS `Amount`,`pc`.`transno` AS `transno`,`pc`.`referenceno` AS `referenceno`,`pc`.`clientid` AS `clientid`,`pc`.`status` AS `status` from (`payment_copy` `pc` join `paymenttype` `pt` on(`pc`.`paymenttype` = `pt`.`paymentid`)) */;

/*View structure for view vw_payment50report */

/*!50001 DROP TABLE IF EXISTS `vw_payment50report` */;
/*!50001 DROP VIEW IF EXISTS `vw_payment50report` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_payment50report` AS select `td2`.`transNo` AS `transno`,`td2`.`clientid` AS `clientid`,concat(`c`.`lname`,', ',`c`.`fname`) AS `clientname`,`td2`.`numberofitems` AS `numberofitems`,`td2`.`Discount` AS `discount`,`td2`.`delfee` AS `delfee`,`td2`.`totaDueAmount` AS `totadueamount`,`td2`.`amountTendered` AS `amountTendered`,`td2`.`currentBal` AS `currentBal`,`td2`.`tDate` AS `tDate`,`td2`.`finalpayment` AS `finalpayment`,`td2`.`changes` AS `changes`,`td2`.`isPaid` AS `isPaid` from (`transaction_details2` `td2` join `client` `c` on(`c`.`Iddetails` = `td2`.`clientid`)) */;

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

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_po` AS select `po`.`porderid` AS `porderid`,`pd`.`porder_bodyid` AS `porder_bodyid`,`pr`.`itemid` AS `itemid`,`pr`.`itemcode` AS `itemcode`,`pr`.`itemtype` AS `itemtype`,`pr`.`Description` AS `Description`,`pr`.`Price` AS `Price`,`pr`.`UnitP` AS `UnitP`,`po`.`quantity` AS `quantity`,`po`.`quantity` * `pr`.`UnitP` AS `Total`,`pd`.`ponum` AS `ponum`,`pd`.`sup_id` AS `sup_id`,`s`.`sup_cname` AS `sup_cname`,`pd`.`expecdate` AS `expecdate` from (((`porder` `po` join `vw_prod` `pr` on(`pr`.`itemid` = `po`.`itemid`)) join `porder_details` `pd` on(`pd`.`porder_bodyid` = `po`.`porder_bodyid`)) join `supplier` `s` on(`s`.`sup_id` = `pd`.`sup_id`)) */;

/*View structure for view vw_polist */

/*!50001 DROP TABLE IF EXISTS `vw_polist` */;
/*!50001 DROP VIEW IF EXISTS `vw_polist` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_polist` AS select `pd`.`porder_bodyid` AS `porder_bodyid`,`pd`.`ponum` AS `ponum`,`pd`.`numberofitem` AS `numberofitem`,`pd`.`expecdate` AS `expecdate`,`pd`.`sup_id` AS `sup_id`,`s`.`sup_cname` AS `sup_cname`,`pd`.`statid` AS `statid`,`st`.`status` AS `status` from ((`porder_details` `pd` join `supplier` `s` on(`s`.`sup_id` = `pd`.`sup_id`)) join `status` `st` on(`st`.`statid` = `pd`.`statid`)) */;

/*View structure for view vw_polistt */

/*!50001 DROP TABLE IF EXISTS `vw_polistt` */;
/*!50001 DROP VIEW IF EXISTS `vw_polistt` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_polistt` AS select `pd`.`porder_bodyid` AS `porder_bodyid`,`pd`.`ponum` AS `ponum`,`pd`.`numberofitem` AS `numberofitem`,`pd`.`expecdate` AS `expecdate`,`pd`.`sup_id` AS `sup_id`,`s`.`sup_cname` AS `sup_cname`,`pd`.`statid` AS `statid`,`st`.`status` AS `status` from ((`porder_details` `pd` join `supplier` `s` on(`s`.`sup_id` = `pd`.`sup_id`)) join `status` `st` on(`st`.`statid` = `pd`.`statid`)) */;

/*View structure for view vw_polistwdel */

/*!50001 DROP TABLE IF EXISTS `vw_polistwdel` */;
/*!50001 DROP VIEW IF EXISTS `vw_polistwdel` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_polistwdel` AS select `rd`.`ruID` AS `ruID`,`rd`.`drID` AS `drID`,`rd`.`ponum` AS `ponum`,`rd`.`itemid` AS `itemid`,`vwpr`.`itemcode` AS `itemcode`,`vwpr`.`itemtype` AS `itemtype`,`vwpr`.`Description` AS `description`,`vwpr`.`Price` AS `price`,`rd`.`quantity` AS `quantity`,`rd`.`sup_id` AS `sup_id`,`s`.`sup_cname` AS `sup_cname`,`pd`.`dateissue` AS `dateissue`,`pd`.`expecdate` AS `expecdate`,`rd`.`dateDelivered` AS `dateDelivered` from (((`receiveddetails` `rd` join `vw_prod` `vwpr` on(`rd`.`itemid` = `vwpr`.`itemid`)) join `porder_details` `pd` on(`rd`.`ponum` = `pd`.`ponum`)) join `supplier` `s` on(`rd`.`sup_id` = `s`.`sup_id`)) */;

/*View structure for view vw_prod */

/*!50001 DROP TABLE IF EXISTS `vw_prod` */;
/*!50001 DROP VIEW IF EXISTS `vw_prod` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_prod` AS select `i`.`itemid` AS `itemid`,`i`.`itemcode` AS `itemcode`,`t`.`ItemType` AS `itemtype`,`i`.`Description` AS `Description`,`i`.`price` AS `Price`,`i`.`UnitP` AS `UnitP` from (`items` `i` join `itemtype` `t` on(`t`.`typeid` = `i`.`typeid`)) */;

/*View structure for view vw_return */

/*!50001 DROP TABLE IF EXISTS `vw_return` */;
/*!50001 DROP VIEW IF EXISTS `vw_return` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_return` AS select `r`.`returnid` AS `returnid`,`r`.`drID` AS `drID`,`r`.`sup_id` AS `sup_id`,`s`.`sup_cname` AS `sup_cname`,`r`.`itemid` AS `itemid`,`p`.`itemcode` AS `itemcode`,`p`.`itemtype` AS `itemtype`,`p`.`Price` AS `price`,`r`.`qty` AS `qty`,`u`.`fullname` AS `fullname`,`r`.`reason` AS `reason`,`r`.`other` AS `other`,`r`.`datereturn` AS `datereturn`,`r`.`status` AS `statid`,`st`.`status` AS `status` from ((((`returns` `r` join `supplier` `s` on(`r`.`sup_id` = `s`.`sup_id`)) join `vw_prod` `p` on(`r`.`itemid` = `p`.`itemid`)) join `vwusers` `u` on(`r`.`returnby` = `u`.`empID`)) join `status` `st` on(`r`.`status` = `st`.`statid`)) */;

/*View structure for view vw_returnfromclient1 */

/*!50001 DROP TABLE IF EXISTS `vw_returnfromclient1` */;
/*!50001 DROP VIEW IF EXISTS `vw_returnfromclient1` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_returnfromclient1` AS select `rf`.`returnid` AS `returnid`,`c`.`clientname` AS `clientname`,`rf`.`ornum` AS `ornum`,`rf`.`itemid` AS `itemid`,`p`.`itemcode` AS `itemcode`,`p`.`itemtype` AS `itemtype`,`p`.`UnitP` AS `unitp`,`rf`.`qty` AS `qty`,`rf`.`reason` AS `reason`,`rf`.`other` AS `other`,`rf`.`datereturn` AS `datereturn`,`rf`.`status` AS `statusid`,`s`.`status` AS `status` from (((`returnfromclient` `rf` join `vw_prod` `p` on(`p`.`itemid` = `rf`.`itemid`)) join `vwclient` `c` on(`c`.`Iddetails` = `rf`.`clientid`)) join `status` `s` on(`rf`.`status` = `s`.`statid`)) */;

/*View structure for view vw_sales */

/*!50001 DROP TABLE IF EXISTS `vw_sales` */;
/*!50001 DROP VIEW IF EXISTS `vw_sales` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_sales` AS select `s`.`itemid` AS `itemid`,`s`.`quantity` + `s2`.`quantity` AS `quantity` from (`sales` `s` join `sales` `s2` on(`s`.`itemid` = `s2`.`itemid`)) */;

/*View structure for view vw_salestrans */

/*!50001 DROP TABLE IF EXISTS `vw_salestrans` */;
/*!50001 DROP VIEW IF EXISTS `vw_salestrans` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_salestrans` AS select `t`.`transId` AS `transId`,`t`.`totalstockId` AS `totalstockid`,`p`.`itemcode` AS `itemcode`,`p`.`itemtype` AS `itemtype`,`p`.`Description` AS `description`,`p`.`UnitP` AS `Unitp`,`t`.`qty` AS `qty`,`t`.`totalprice` AS `totalprice`,`t`.`ornum` AS `ornum`,`t`.`tDate` AS `tDate`,`t`.`clientID` AS `clientID`,`c`.`clientname` AS `clientname` from ((`transaction` `t` join `vw_prod` `p` on(`p`.`itemid` = `t`.`totalstockId`)) join `vwclient` `c` on(`c`.`Iddetails` = `t`.`clientID`)) */;

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

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_sup_item2` AS select `vi`.`suppid` AS `suppid`,`s`.`sup_cname` AS `sup_cname`,`vi`.`itemid` AS `itemid`,`vi`.`itemcode` AS `itemcode`,`vi`.`itemtype` AS `itemtype`,`vi`.`Description` AS `description`,`vi`.`price` AS `price`,`vi`.`UnitP` AS `UnitP` from (`vw_items` `vi` join `supplier` `s` on(`vi`.`suppid` = `s`.`sup_id`)) */;

/*View structure for view vw_updatepayment50 */

/*!50001 DROP TABLE IF EXISTS `vw_updatepayment50` */;
/*!50001 DROP VIEW IF EXISTS `vw_updatepayment50` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_updatepayment50` AS select `td2`.`transNo` AS `transno`,`td2`.`clientid` AS `clientid`,concat(`c`.`lname`,', ',`c`.`fname`) AS `clientname`,`td2`.`numberofitems` AS `numberofitems`,`td2`.`Discount` AS `discount`,`td2`.`delfee` AS `delfee`,`td2`.`totaDueAmount` AS `totadueamount`,`td2`.`amountTendered` AS `amountTendered`,`td2`.`currentBal` AS `currentBal`,`td2`.`tDate` AS `tDate`,`td2`.`finalpayment` AS `finalpayment`,`td2`.`changes` AS `changes`,`td2`.`isPaid` AS `isPaid` from (`transaction_details2` `td2` join `client` `c` on(`c`.`Iddetails` = `td2`.`clientid`)) */;

/*View structure for view vw_updatepaymenttttt */

/*!50001 DROP TABLE IF EXISTS `vw_updatepaymenttttt` */;
/*!50001 DROP VIEW IF EXISTS `vw_updatepaymenttttt` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_updatepaymenttttt` AS select `pc`.`paymentid` AS `paymentid`,`pt`.`paymentname` AS `paymentname`,`pc`.`paymentdetails` AS `paymentdetails`,`pc`.`Amount` AS `Amount`,`pc`.`transno` AS `transno`,`pc`.`clientid` AS `clientid`,`pc`.`status` AS `status` from (`updatepayment` `pc` join `paymenttype` `pt` on(`pc`.`paymenttype` = `pt`.`paymentid`)) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
