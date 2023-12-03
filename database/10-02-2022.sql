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

/*Table structure for table `client` */

DROP TABLE IF EXISTS `client`;

CREATE TABLE `client` (
  `CustID` int(12) unsigned NOT NULL AUTO_INCREMENT,
  `Iddetails` bigint(15) NOT NULL,
  `lname` varchar(255) NOT NULL,
  `fname` varchar(255) NOT NULL,
  `mi` varchar(255) DEFAULT NULL,
  `Street` varchar(255) NOT NULL,
  `Brgy` varchar(255) NOT NULL,
  `city` varchar(255) NOT NULL,
  `contactno` int(12) NOT NULL,
  `emailadd` varchar(255) NOT NULL,
  `status` int(12) DEFAULT NULL,
  PRIMARY KEY (`CustID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

/*Data for the table `client` */

insert  into `client`(`CustID`,`Iddetails`,`lname`,`fname`,`mi`,`Street`,`Brgy`,`city`,`contactno`,`emailadd`,`status`) values (1,20220614001,'Tubero','Kram','B.','Bantutin St.','Brgy Santimo','Quezon City',9454576,'kram@rocketmail.com',1),(2,20220614002,'Benkong','Mark','R. ','Bingo St. ','Brgy Heha','Quezon City',95457651,'mark@rocketmail.com',1),(3,202206150003,'TUGANO','JOHN RAFAEL','R','SAMUEL 3 ','BRGY PASONG TAMO','QUEZON CITY',945164572,'JOHNNTUGANO@GMAIL.COM',1),(4,202206160004,'MARKIN','JAMSON','M','MAKABILANG BUHAY ST.','BRGY STO ANYO','QUEZON CITY',976412488,'NARKIN@GMAIL.COM',1),(5,202206160005,'CLEMENTE','EDWARD','M.','MANIMAN STREET','BRGY KALIWAN','MARIKINA CITY',978463215,'EDWARD@GMAIL.COM',1),(6,202206160006,'KELAN','DENMA','R','MANDIJO ST','BRGY 122','CALOOCAN CITY',978746513,'DEM@GMAIL.COM',1),(7,202206160007,'MAMANSAG','JAN MARC','M','MALIGAYA ST','BRGY STO NINO','QUEZON CITY',2147483647,'JANMARC@GMAIL.COM',1);

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
  `isActve` int(12) DEFAULT NULL,
  PRIMARY KEY (`empID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

/*Data for the table `employee` */

insert  into `employee`(`empID`,`fname`,`mname`,`lname`,`dob`,`uname`,`password`,`lvl_id`,`date_in`,`isActve`) values (1,'John','R.','Tugano','1999-12-08',NULL,NULL,0,NULL,NULL),(2,'Alphonse','D.','Elric','1999-04-19',NULL,NULL,1,NULL,NULL),(3,'Edward','M.','Clemente','2000-06-24',NULL,NULL,1,NULL,NULL),(4,'Trixie','C.','Calina','2000-02-14',NULL,NULL,1,NULL,NULL),(5,'Angela','C.','Arcilla','2000-04-15',NULL,NULL,0,NULL,NULL);

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
) ENGINE=InnoDB AUTO_INCREMENT=65 DEFAULT CHARSET=utf8mb4;

/*Data for the table `items` */

insert  into `items`(`itemid`,`itemcode`,`typeid`,`Description`,`price`,`UnitP`) values (1,'JPC-001',1,'W45 X D50 XH 75',3600.00,4500.00),(2,'MBC-3112',5,'H120 X D45 X W50',5500.00,7500.00),(3,'OFT-1600',6,'L160 X W80 X H75',21000.00,23000.00),(4,'OFT-1011',7,'L100 X W50 X H75',5000.00,6900.00),(5,'CST-D9602',9,'L100 X W54 X H74',8000.00,9500.00),(6,'OFT-8140',8,'L280 X W120 X H75',28000.00,35000.00),(7,'CFT-240',2,'L420 X W120 X H75',18000.00,24000.00),(8,'CST- D9614',9,'L120 X W52 X H74',9000.00,12000.00),(9,'DTR-360',13,'L70 X W70',5500.00,7500.00),(10,'YT-6319',10,'L100 X W76 X H56',7600.00,8500.00),(11,'FT-PR150',11,'L150 X W70 X H75',3500.00,5800.00),(12,'FT-PR120',11,'L120 X W60 X H75',3500.00,5500.00),(13,'FT-7306',12,'L120 X W40 X H75',4000.00,5000.00),(14,'DT-P112',13,'L120 X W40',7700.00,9700.00),(15,'JL-59',14,'W60 X L69',3600.00,4600.00),(16,'DT-A209',15,'W125 X L75',7500.00,9500.00),(17,'DT-A9107',16,'L150 X W90 X H75',10000.00,12000.00),(18,'CT-502',17,'L105 X W55 X H42',3000.00,5000.00),(19,'TV-258',18,'L112 X W43 X H136',4400.00,8800.00),(20,'C-BD2089',19,'LEATHERETTE',5000.00,9200.00),(21,'C-BD6016',19,'LEATHERETTE',7800.00,8800.00),(22,'C-BNH301',20,'MESH',8000.00,9100.00),(23,'C-NH168',20,'MESH',8000.00,9100.00),(24,'C-NL382',20,'MESH',4800.00,5700.00),(25,'C-604G',21,'CLERICAL',1850.00,3500.00),(26,'C-609',21,'CLERICAL',2000.00,4500.00),(27,'VC-NL315',22,'L47 X W48 X H94',3400.00,4800.00),(28,'VC-3028',22,'L43 X W45 X H82',2800.00,3900.00),(29,'VC-282',23,'L47 X W47 X H94',7500.00,8000.00),(30,'C-303',23,'L50 X W50 X H103',3350.00,4950.00),(31,'SFC-G102',24,'L90 X W45 X H183',14000.00,16500.00),(32,'SFC-KM13',25,'L90 X W40 X H185',12000.00,18000.00),(33,'SFC-052-4',26,'L44.5 X W62 X H133',11000.00,15000.00),(34,'BKS-908',27,'L120 X W30 X H180',6700.00,10400.00),(35,'MT-1224',28,'L120 X W60 X H76',5000.00,10000.00),(36,'WLS-067',29,'L120 X W46 X H183',7500.00,9500.00),(37,'SQ-1709(2.4M)',2,'L240 X W120 X H75',15000.00,18000.00),(38,'SQ-1709(3.2M)',2,'L320 X W120 X H75',18000.00,23000.00),(39,'CTBT46015',30,'L80 X W75',4500.00,6000.00),(40,'SQ 1707',31,'L240 X W120 X H75',25000.00,30000.00),(41,'CT 1802',32,'L60X W40 X H123',2500.00,3500.00),(42,'GC5STR',33,'L286 X W57 X H80',10000.00,14000.00),(43,'001C2JNSX',34,'L32 X W41 X H45',1550.00,3500.00),(44,'100CJNSX',34,'L56 X W57 X H86',2000.00,4000.00),(45,'803BKONSX',35,'L44 X W57 X H126',4500.00,6500.00),(46,'801-2FM',36,'L53 X W40 X H80',2000.00,4100.00),(47,'116FM',36,'L53 X W50 X H90',2500.00,4000.00),(48,'815HLPRX',37,'L60 X W56 X H128',9600.00,11800.00),(49,'YS-906',37,'L57 X W56 X H121',8000.00,9000.00),(50,'6202',38,'L120 X W38 X H80',6700.00,7700.00),(51,'WLS-H4',25,'L90 X W50 X H185',8000.00,15000.00),(52,'SH2',39,'L64 X W56 X H115-124',3200.00,6600.00),(53,'SH1-BW',39,'L64 X W58 X H115-124',3100.00,6300.00),(54,'SH2-B',39,'L64 X W56 X H42-51',3000.00,6100.00),(55,'BC-EIFFEL',19,'L72 X W59 X H133-141',15000.00,20000.00),(56,'BC-EIFFEL (B)',19,'L72 X W59 X H133-141',16000.00,19000.00),(57,'BC-GRAND',19,'L61.5 X W59.5-78.5 X H112-128',14800.00,15500.00),(58,'STC-A08',40,'',2550.00,4100.00),(59,'STC-818A',40,'',1600.00,3600.00),(60,'GS-02AD',41,'',2500.00,4500.00),(61,'PB-020',42,'',3500.00,7500.00),(62,'PB-004',42,'',3500.00,7500.00),(63,'HBC-2022',43,'W120 XD60 X H75',3500.00,7500.00),(64,'781-444',4,'',2500.00,3000.00);

/*Table structure for table `itemtype` */

DROP TABLE IF EXISTS `itemtype`;

CREATE TABLE `itemtype` (
  `typeid` int(12) NOT NULL AUTO_INCREMENT,
  `ItemType` varchar(255) NOT NULL,
  PRIMARY KEY (`typeid`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8mb4;

/*Data for the table `itemtype` */

insert  into `itemtype`(`typeid`,`ItemType`) values (1,'MOBILE PEDESTAL'),(2,'CONFERENCE TABLE'),(3,'STUDY TABLE'),(4,'HIGH BACK CHAIR'),(5,'MID BACK CHAIR'),(6,'EXECUTIVE TABLE'),(7,'OFFICE TABLE'),(8,'OFFICE TABLE WITH MOBILE DRAWER'),(9,'COMPUTER DESK WITH METAL FRAME'),(10,'COMPUTER STUDY TABLE'),(11,'FOLDING PLASTIC TABLE'),(12,'TRAINING TABLE'),(13,'COFFEE TABLE'),(14,'ALUMINUM TABLE & CHAIRS'),(15,'4 SEATING DINING TABLE'),(16,'6 SEATING DINING TABLE'),(17,'CENTER & SIDE TABLE'),(18,'TV STAND WITH MOUNT'),(19,'EXECUTIVE CHAIR'),(20,'MESH CHAIR'),(21,'CLERICAL CHAIR'),(22,'VISITOR\'S CHAIR'),(23,'LEATHERETTE VISITOR\'S CHAIR'),(24,'STEEL LOCKER'),(25,'STEEL CABINET'),(26,'FILING CABINET'),(27,'BOOK CASE'),(28,'METAL OFFICE TABLE'),(29,'OFFICE FIXTURES'),(30,'MINI CONFERENCE'),(31,'WORKSTATION'),(32,'COMPUTER TABLE'),(33,'GANG CHAIR'),(34,'OFFICE CHAIR'),(35,'OFFICE TELLER CHAIR'),(36,'STACKABLE CHAIR'),(37,'GAMING CHAIR'),(38,'HOME FURNITURE'),(39,'SUPREME'),(40,'CHROME PLATED STOOL'),(41,'STUDENT CHAIR'),(42,'PARK BENCH'),(43,'OFFICES TABLES');

/*Table structure for table `modeofp` */

DROP TABLE IF EXISTS `modeofp`;

CREATE TABLE `modeofp` (
  `mopid` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `mopname` varchar(255) NOT NULL,
  PRIMARY KEY (`mopid`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `modeofp` */

insert  into `modeofp`(`mopid`,`mopname`) values (1,'50% DownPayment'),(2,'Full Payment'),(3,'Full Payment After Receiving the Item');

/*Table structure for table `porder` */

DROP TABLE IF EXISTS `porder`;

CREATE TABLE `porder` (
  `porderid` int(12) NOT NULL AUTO_INCREMENT,
  `itemid` int(12) NOT NULL,
  `quantity` int(12) NOT NULL,
  `porder_bodyid` int(12) NOT NULL,
  PRIMARY KEY (`porderid`)
) ENGINE=InnoDB AUTO_INCREMENT=79 DEFAULT CHARSET=utf8mb4;

/*Data for the table `porder` */

insert  into `porder`(`porderid`,`itemid`,`quantity`,`porder_bodyid`) values (1,1,12,1),(2,1,12,2),(3,1,15,3),(4,1,12,4),(5,1,12,5),(6,1,2,6),(7,2,15,7),(8,2,12,8),(9,2,12,9),(10,1,3,9),(11,17,13,10),(12,59,17,11),(13,57,7,12),(14,57,11,13),(15,10,15,14),(16,45,8,15),(17,44,11,16),(18,55,7,17),(19,11,11,18),(20,45,4,19),(21,45,18,20),(22,40,2,21),(23,37,4,22),(24,61,25,23),(25,42,17,24),(26,41,11,25),(27,39,17,26),(28,38,19,27),(29,36,15,28),(30,35,19,29),(31,4,24,30),(32,5,16,31),(33,6,19,32),(34,7,24,33),(35,8,31,34),(36,9,22,35),(37,12,13,36),(38,13,16,37),(39,14,33,38),(40,14,9,39),(41,15,16,40),(42,19,26,41),(43,21,4,42),(44,22,12,43),(45,22,33,44),(46,23,22,45),(47,24,24,46),(48,1,42,47),(49,27,14,48),(50,28,12,49),(51,29,16,50),(52,31,16,51),(53,30,15,52),(54,26,23,53),(55,1,16,54),(56,48,7,55),(57,54,5,56),(58,53,13,57),(59,62,1,58),(60,49,17,59),(61,60,4,60),(62,1,16,61),(63,52,19,62),(64,58,11,63),(65,57,12,64),(66,56,15,64),(67,2,12,64),(68,55,20,64),(69,63,25,64),(70,57,12,65),(71,59,12,66),(72,38,12,66),(73,55,12,66),(75,59,2,67),(76,60,2,67),(77,41,3,67),(78,8,12,68);

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
) ENGINE=InnoDB AUTO_INCREMENT=69 DEFAULT CHARSET=utf8mb4;

/*Data for the table `porder_details` */

insert  into `porder_details`(`porder_bodyid`,`ponum`,`sup_id`,`numberofitem`,`expecdate`,`dateissue`,`createdby`,`statid`) values (1,'2022-0001','globe',1,'2022-05-28','2022-05-28',1,2),(2,'2022-0002','globe',1,'2022-05-28','2022-05-28',1,2),(3,'2022-0003','GLOBE',1,'2022-05-28','2022-05-28',1,2),(4,'2022-0004','GLOBE',1,'2022-06-21','2022-06-07',2,2),(5,'2022-0005','TM',1,'2022-06-07','2022-06-07',1,2),(6,'2022-0006','GLOBE',1,'2022-06-22','2022-06-07',2,2),(7,'2022-0007','TNT',1,'2022-06-15','2022-06-08',1,2),(8,'2022-0008','GLOBE',1,'2022-06-11','2022-06-11',1,2),(9,'2022-0009','GLOBE',2,'2022-06-14','2022-06-13',2,2),(10,'2022-0010','FURNITURE EXCHANGE',1,'2022-06-16','2022-06-16',1,2),(11,'2022-0011','INLAND FURNITURE',1,'2022-06-16','2022-06-16',2,2),(12,'2022-0012','INTACT FURNITURE',1,'2022-06-16','2022-06-16',1,2),(13,'2022-0013','ENTITY FURNITURE',1,'2022-06-16','2022-06-16',1,2),(14,'2022-0014','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',2,2),(15,'2022-0015','FURNITURE WEST',1,'2022-06-16','2022-06-16',1,2),(16,'2022-0016','GLOBE',1,'2022-06-16','2022-06-16',1,2),(17,'2022-0017','FURNITURE EXCHANGE',1,'2022-06-16','2022-06-16',1,2),(18,'2022-0018','FURNITURE EXCHANGE',1,'2022-06-16','2022-06-16',1,2),(19,'2022-0019','INTACT FURNITURE',1,'2022-06-19','2022-06-16',1,2),(20,'2022-0020','ENTITY FURNITURE',1,'2022-06-20','2022-06-16',2,2),(21,'2022-0021','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',3,2),(22,'2022-0022','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',5,2),(23,'2022-0023','PALMTREE FURNITURE',1,'2022-06-28','2022-06-16',4,2),(24,'2022-0024','VERTIX FURNITURE',1,'2022-06-20','2022-06-16',2,2),(25,'2022-0025','ENTITY FURNITURE',1,'2022-06-16','2022-06-16',3,2),(26,'2022-0026','INTACT FURNITURE',1,'2022-06-16','2022-06-16',6,2),(27,'2022-0027','FURNITURE EYES',1,'2022-06-16','2022-06-16',4,2),(28,'2022-0028','FURNITURE EYES',1,'2022-06-16','2022-06-16',5,2),(29,'2022-0029','FURNITURE EXCHANGE',1,'2022-06-16','2022-06-16',1,2),(30,'2022-0030','VERTIX FURNITURE',1,'2022-06-16','2022-06-16',1,2),(31,'2022-0031','INTACT FURNITURE',1,'2022-06-16','2022-06-16',2,2),(32,'2022-0032','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',1,2),(33,'2022-0033','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',1,2),(34,'2022-0034','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',1,2),(35,'2022-0035','FURNITURE SPOTS',1,'2022-06-20','2022-06-16',4,2),(36,'2022-0036','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',3,2),(37,'2022-0037','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',2,2),(38,'2022-0038','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',1,2),(39,'2022-0039','INLAND FURNITURE',1,'2022-06-16','2022-06-16',5,2),(40,'2022-0040','INLAND FURNITURE',1,'2022-06-16','2022-06-16',2,2),(41,'2022-0041','INLAND FURNITURE',1,'2022-06-16','2022-06-16',4,2),(42,'2022-0042','PALMTREE FURNITURE',1,'2022-06-16','2022-06-16',3,2),(43,'2022-0043','PALMTREE FURNITURE',1,'2022-06-16','2022-06-16',5,2),(44,'2022-0044','PALMTREE FURNITURE',1,'2022-06-16','2022-06-16',1,2),(45,'2022-0045','PALMTREE FURNITURE',1,'2022-06-16','2022-06-16',1,2),(46,'2022-0046','PALMTREE FURNITURE',1,'2022-06-16','2022-06-16',1,2),(47,'2022-0047','VERTIX FURNITURE',1,'2022-06-16','2022-06-16',3,2),(48,'2022-0048','VERTIX FURNITURE',1,'2022-06-16','2022-06-16',1,2),(49,'2022-0049','VERTIX FURNITURE',1,'2022-06-16','2022-06-16',2,2),(50,'2022-0050','VERTIX FURNITURE',1,'2022-06-16','2022-06-16',3,2),(51,'2022-0051','ENTITY FURNITURE',1,'2022-06-16','2022-06-16',5,2),(52,'2022-0052','INLAND FURNITURE',1,'2022-06-16','2022-06-16',3,2),(53,'2022-0053','INLAND FURNITURE',1,'2022-06-16','2022-06-16',5,2),(54,'2022-0054','FURNITURE SPOTS',1,'2022-06-16','2022-06-16',4,2),(55,'2022-0055','INTEGRATE FURNITURE',1,'2022-06-16','2022-06-16',3,2),(56,'2022-0056','INTACT FURNITURE',1,'2022-06-16','2022-06-16',4,2),(57,'2022-0057','VERTIX FURNITURE',1,'2022-06-16','2022-06-16',3,2),(58,'2022-0058','INTEGRATE FURNITURE',1,'2022-06-16','2022-06-16',4,2),(59,'2022-0059','INTEGRATE FURNITURE',1,'2022-06-16','2022-06-16',5,2),(60,'2022-0060','INTACT FURNITURE',1,'2022-06-16','2022-06-16',3,2),(61,'2022-0061','ENTITY FURNITURE',1,'2022-06-16','2022-06-16',5,2),(62,'2022-0062','ENTITY FURNITURE',1,'2022-06-16','2022-06-16',2,2),(63,'2022-0063','ENTITY FURNITURE',1,'2022-06-16','2022-06-16',1,2),(64,'2022-0064','FURNITURE SPOTS',5,'2022-06-17','2022-06-17',1,2),(65,'2022-0065','FURNITURE EXCHANGE',1,'2022-10-02','2022-10-02',1,2),(66,'2022-0066','FURNITURE SPOTS',3,'2022-10-02','2022-10-02',1,2),(67,'2022-0067','VERTIX FURNITURE',3,'2022-10-02','2022-10-02',4,2),(68,'2022-0068','TM',1,'2022-10-02','2022-10-02',1,1);

/*Table structure for table `received` */

DROP TABLE IF EXISTS `received`;

CREATE TABLE `received` (
  `drid` int(12) NOT NULL AUTO_INCREMENT,
  `sup_id` varchar(255) DEFAULT NULL,
  `date_received` date NOT NULL,
  `numberofitem` int(12) NOT NULL,
  `receiveby` int(12) NOT NULL,
  PRIMARY KEY (`drid`)
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=utf8mb4;

/*Data for the table `received` */

insert  into `received`(`drid`,`sup_id`,`date_received`,`numberofitem`,`receiveby`) values (1,NULL,'2022-05-31',1,2),(2,'globe','2022-05-31',1,2),(3,'globe','2022-05-31',1,2),(4,'         ','2022-06-08',1,2),(5,'globe','2022-06-10',1,2),(6,'globe','2022-06-23',1,2),(7,'globe','2022-06-22',1,2),(8,'         ','2022-06-09',1,2),(9,'         ','2022-06-15',2,2),(10,'         ','2022-06-16',1,2),(11,'         ','2022-06-16',1,2),(12,'         ','2022-06-16',1,1),(13,'         ','2022-06-16',1,1),(14,'         ','2022-06-16',1,1),(15,'         ','2022-06-16',1,1),(16,'         ','2022-06-16',1,1),(17,'         ','2022-06-16',1,1),(18,'         ','2022-06-16',1,1),(19,'         ','2022-06-19',1,2),(20,'         ','2022-06-16',1,1),(21,'         ','2022-06-16',1,1),(22,'         ','2022-06-16',1,1),(23,'         ','2022-06-16',1,1),(24,'         ','2022-06-16',1,1),(25,'         ','2022-06-16',1,1),(26,'         ','2022-06-16',1,1),(27,'         ','2022-06-16',1,1),(28,'         ','2022-06-16',1,1),(29,'         ','2022-06-16',1,1),(30,'         ','2022-06-16',1,3),(31,'         ','2022-06-16',1,4),(32,'         ','2022-06-16',1,2),(33,'         ','2022-06-16',1,5),(34,'         ','2022-06-16',1,4),(35,'         ','2022-06-16',1,5),(36,'         ','2022-06-16',1,2),(37,'         ','2022-06-16',1,4),(38,'         ','2022-06-16',1,2),(39,'         ','2022-06-16',1,1),(40,'         ','2022-06-16',1,1),(41,'         ','2022-06-16',1,1),(42,'         ','2022-06-16',1,3),(43,'         ','2022-06-16',1,2),(44,'         ','2022-06-16',1,2),(45,'         ','2022-06-16',1,3),(46,'         ','2022-06-16',1,4),(47,'         ','2022-06-16',1,3),(48,'         ','2022-06-16',1,5),(49,'         ','2022-06-16',1,2),(50,'         ','2022-06-16',1,3),(51,'         ','2022-06-16',1,1),(52,'         ','2022-06-16',1,3),(53,'         ','2022-06-16',1,2),(54,'         ','2022-06-16',1,3),(55,'         ','2022-06-16',1,4),(56,'         ','2022-06-16',1,5),(57,'         ','2022-06-16',1,1),(58,'         ','2022-06-16',1,4),(59,'         ','2022-06-16',1,2),(60,'         ','2022-06-16',1,2),(61,'         ','2022-06-16',1,2),(62,'         ','2022-06-16',1,4),(63,'         ','2022-06-16',1,5),(64,'ENTITY FURNITURE','2022-06-21',5,2),(65,'INTACT FURNITURE','2022-10-13',1,4),(66,'FURNITURE SPOTS','2022-10-02',3,1),(67,'2022-0058','2022-10-02',3,1);

/*Table structure for table `receiveddetails` */

DROP TABLE IF EXISTS `receiveddetails`;

CREATE TABLE `receiveddetails` (
  `ruID` int(12) NOT NULL AUTO_INCREMENT,
  `drID` int(12) NOT NULL,
  `itemid` int(12) NOT NULL,
  `quantity` int(12) NOT NULL,
  `dateDelivered` date NOT NULL,
  PRIMARY KEY (`ruID`)
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=utf8mb4;

/*Data for the table `receiveddetails` */

insert  into `receiveddetails`(`ruID`,`drID`,`itemid`,`quantity`,`dateDelivered`) values (1,14341,1,12,'2022-05-31'),(2,4141,1,12,'2022-05-31'),(3,21234,1,15,'2022-05-31'),(4,13121,1,12,'2022-06-08'),(5,1451231,1,12,'2022-06-10'),(6,1412313131,1,2,'2022-06-23'),(7,988712,2,15,'2022-06-22'),(8,6234,2,12,'2022-06-09'),(9,64352,2,12,'2022-06-15'),(10,64352,1,3,'2022-06-15'),(11,873113,17,13,'2022-06-16'),(12,798132,59,17,'2022-06-16'),(13,242626,57,7,'2022-06-16'),(14,546752,57,11,'2022-06-16'),(15,766245,10,15,'2022-06-16'),(16,589323,45,8,'2022-06-16'),(17,242513,44,11,'2022-06-16'),(18,352626,55,7,'2022-06-16'),(19,235233,45,4,'2022-06-16'),(20,325327,11,11,'2022-06-19'),(21,646353,45,18,'2022-06-16'),(22,22425,37,4,'2022-06-16'),(23,324215,40,2,'2022-06-16'),(24,353532,61,25,'2022-06-16'),(25,212145,42,17,'2022-06-16'),(26,214378,36,15,'2022-06-16'),(27,767695,39,17,'2022-06-16'),(28,8776,41,11,'2022-06-16'),(29,655856,38,19,'2022-06-16'),(30,434899,35,19,'2022-06-16'),(31,585485,4,24,'2022-06-16'),(32,464733,6,19,'2022-06-16'),(33,360808,19,26,'2022-06-16'),(34,111358,22,33,'2022-06-16'),(35,546860,22,12,'2022-06-16'),(36,975753,27,14,'2022-06-16'),(37,342363,23,22,'2022-06-16'),(38,124252,24,24,'2022-06-16'),(39,368965,21,4,'2022-06-16'),(40,121564,28,12,'2022-06-16'),(41,868654,15,16,'2022-06-16'),(42,325343,14,33,'2022-06-16'),(43,3447585,14,9,'2022-06-16'),(44,436223,12,13,'2022-06-16'),(45,358888,13,16,'2022-06-16'),(46,868532,8,31,'2022-06-16'),(47,353474,7,24,'2022-06-16'),(48,235231,5,16,'2022-06-16'),(49,973433,1,42,'2022-06-16'),(50,366576,29,16,'2022-06-16'),(51,336464,9,22,'2022-06-16'),(52,214125,48,7,'2022-06-16'),(53,251797,1,16,'2022-06-16'),(54,654645,54,5,'2022-06-16'),(55,974554,26,23,'2022-06-16'),(56,547545,30,15,'2022-06-16'),(57,965755,53,13,'2022-06-16'),(58,757754,60,4,'2022-06-16'),(59,753741,58,11,'2022-06-16'),(60,789642,1,16,'2022-06-16'),(61,787941,52,19,'2022-06-16'),(62,747774,62,1,'2022-06-16'),(63,741256,31,16,'2022-06-16'),(64,757145,49,17,'2022-06-16'),(65,156789,57,12,'2022-06-21'),(66,156789,56,15,'2022-06-21'),(67,156789,2,12,'2022-06-21'),(68,156789,55,20,'2022-06-21'),(69,156789,63,25,'2022-06-21'),(70,1313,57,12,'2022-10-13'),(71,13131,59,12,'2022-10-02'),(72,13131,38,12,'2022-10-02'),(73,13131,55,12,'2022-10-02'),(74,41231,41,3,'2022-10-02'),(75,41231,60,2,'2022-10-02'),(76,41231,59,2,'2022-10-02');

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
) ENGINE=InnoDB AUTO_INCREMENT=65 DEFAULT CHARSET=utf8mb4;

/*Data for the table `stocks` */

insert  into `stocks`(`stockid`,`itemid`,`quantity`) values (1,1,75),(2,2,28),(3,3,12),(4,4,24),(5,5,16),(6,6,19),(7,7,24),(8,8,31),(9,9,22),(10,10,12),(11,11,11),(12,12,13),(13,13,16),(14,14,42),(15,15,16),(16,16,1),(17,17,13),(18,18,0),(19,19,23),(20,20,0),(21,21,4),(22,22,45),(23,23,22),(24,24,24),(25,25,0),(26,26,23),(27,27,14),(28,28,12),(29,29,16),(30,30,15),(31,31,16),(32,32,1),(33,33,1),(34,34,1),(35,35,19),(36,36,15),(37,37,4),(38,38,31),(39,39,17),(40,40,4),(41,41,14),(42,42,17),(43,43,1),(44,44,11),(45,45,30),(46,46,1),(47,47,5),(48,48,7),(49,49,17),(50,50,1),(51,51,1),(52,52,19),(53,53,13),(54,54,5),(55,55,39),(56,56,15),(57,57,42),(58,58,11),(59,59,31),(60,60,8),(61,61,25),(62,62,1),(63,63,25),(64,64,0);

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
  PRIMARY KEY (`sup_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4;

/*Data for the table `supplier` */

insert  into `supplier`(`sup_id`,`sup_cname`,`sup_name`,`contact`,`emailadd`,`house`,`brgy`,`city`) values (1,'TM',NULL,'0915645987','TM@GMAIL.COM','GREENFIELDS','BRGY PASONG TAMO','QUEZON CITY'),(2,'GLOBE',NULL,'0945564897','GLOBE@GMAIL.COM','SACREDHEART','BRGY PASONG PUTIK PROPER','QUEZON CITY'),(3,'TNT',NULL,'094567981','TNT@GMAIL.COM','DEMINAY ST','BRGY SITO PULO','CALOOCAN CITY'),(4,'FURNITURE EYES',NULL,'09638885513','DDXEAP7@YANDEX.CFD','NATIONAL HIGHWAY','GUSA','CAGAYAN DE ORO CITY'),(5,'FURNITURE EXCHANGE',NULL,'8132449','SOFIAIBRAGIMOVA@GMAILNI.COM','CONDOMINIUM 10 TOWR 2','CITYLAND','MAKATI CITY'),(6,'INLAND FURNITURE',NULL,'6373570','WASEEMALI628@ONEMAHANET.COM','ORTIGAS CENTER','ADB AVENUE','PASIG CITY'),(7,'ENTITY FURNITURE',NULL,'8303073','S161268@BHARATASUPERFUR.COM','V.A. RUFINO STREETS','SALCEDO','MAKATI CITY'),(8,'INTACT FURNITURE',NULL,'8961230','ALIGIRSCH@GKQIL.COM','A P REYES GATE','CARMONA 1200','MAKATI CITY'),(9,'FURNITURE WEST',NULL,'723474','ALIGIRSCH@GKQIL.COM','J.R BORJA','DON A. VELEZ ','CAGAYAN DE ORO'),(10,'FURNITURE SPOTS',NULL,'8332876','ANTC2JANTR@SIPSTRORE.COM','PARK AVENUE','21143 UNIT','PASAY CITY'),(11,'VERTIX FURNITURE',NULL,'5111568','RANDYM26@KONGSHUON.COM','DEL PILAR','MAHARLIKA','NUEVA ECIJA'),(12,'INTEGRATE FURNITURE',NULL,'2932659','DOBROGROZAN@NBOBD.COM','DE LEON','92 GEN. T','VALENZUELA CITY'),(13,'PALMTREE FURNITURE',NULL,'4395434','COCKASIAN@OMTECHA.COM','2115 C.M.','RECTO AVENUE','MANILA CITY');

/*Table structure for table `tblemployee` */

DROP TABLE IF EXISTS `tblemployee`;

CREATE TABLE `tblemployee` (
  `empID` int(10) NOT NULL AUTO_INCREMENT,
  `firstName` varchar(100) NOT NULL,
  `middleName` varchar(100) NOT NULL,
  `lastName` varchar(100) NOT NULL,
  `dob` date NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(50) NOT NULL,
  `lvl_id` int(10) NOT NULL,
  `stat_id` int(10) NOT NULL,
  `ddatein` varchar(50) NOT NULL,
  `isActive` int(10) NOT NULL,
  PRIMARY KEY (`empID`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `tblemployee` */

insert  into `tblemployee`(`empID`,`firstName`,`middleName`,`lastName`,`dob`,`username`,`password`,`lvl_id`,`stat_id`,`ddatein`,`isActive`) values (1,'LESLIE','L.','LABOR','1999-12-12','LESLABOR','qLlUMbHxJms=',2,0,'2021-09-09',1),(2,'baby','l.','labor','1999-12-08','asd123','qLlUMbHxJms=',2,0,'2021-09-09',1),(3,'Jcj','m','gallemit','1999-09-09','jcM','asd123',2,0,'2021-09-09',1),(4,'asasd','s','asdas','1980-09-09','sdfsf','asd123',2,0,'2021-09-09',1),(5,'mac','','puerta','1999-09-09','mac','asd123',1,0,'2021-09-09',1);

/*Table structure for table `temp_transaction` */

DROP TABLE IF EXISTS `temp_transaction`;

CREATE TABLE `temp_transaction` (
  `transId` int(10) NOT NULL AUTO_INCREMENT,
  `transdetailsId` int(10) NOT NULL,
  `totalstockId` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `totalprice` double(10,2) NOT NULL,
  `ornum` varchar(50) NOT NULL,
  `empID` int(10) NOT NULL,
  `status` int(10) NOT NULL,
  PRIMARY KEY (`transId`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

/*Data for the table `temp_transaction` */

insert  into `temp_transaction`(`transId`,`transdetailsId`,`totalstockId`,`qty`,`totalprice`,`ornum`,`empID`,`status`) values (11,0,1,1,4500.00,'202206170006',0,0);

/*Table structure for table `transaction` */

DROP TABLE IF EXISTS `transaction`;

CREATE TABLE `transaction` (
  `transId` int(10) NOT NULL AUTO_INCREMENT,
  `transdetailsId` int(10) NOT NULL,
  `totalstockId` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `totalprice` double(10,2) NOT NULL,
  `ornum` varchar(50) NOT NULL,
  `empID` int(10) NOT NULL,
  `status` int(10) NOT NULL,
  PRIMARY KEY (`transId`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `transaction` */

/*Table structure for table `transaction_details` */

DROP TABLE IF EXISTS `transaction_details`;

CREATE TABLE `transaction_details` (
  `transdetailsId` int(10) NOT NULL AUTO_INCREMENT,
  `amountTendered` double(10,2) NOT NULL,
  `Discount` double(10,2) NOT NULL,
  `delfee` double(10,2) NOT NULL,
  `totaDueAmount` double(10,2) NOT NULL,
  `amountChange` double(10,2) NOT NULL,
  `tDate` varchar(50) NOT NULL,
  `transNo` varchar(50) NOT NULL,
  `cashierId` int(10) NOT NULL,
  `isPaid` int(10) DEFAULT NULL,
  PRIMARY KEY (`transdetailsId`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `transaction_details` */

insert  into `transaction_details`(`transdetailsId`,`amountTendered`,`Discount`,`delfee`,`totaDueAmount`,`amountChange`,`tDate`,`transNo`,`cashierId`,`isPaid`) values (1,50305.00,-2.00,1000.00,49.00,0.00,'20220616','202206160001',0,1),(2,5000.00,0.00,500.00,4.00,135.00,'20220616','202206160002',0,1),(3,5000.00,-135.00,500.00,4.00,135.00,'20220616','202206160003',0,1),(4,5000.00,-135.00,500.00,4.00,135.00,'20220617','202206170004',0,1),(5,184000.00,-9.00,0.00,174.00,500.00,'20220617','202206170005',0,1);

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
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

/*Data for the table `void` */

insert  into `void`(`VoidID`,`transheadId`,`itemid`,`qty`,`totalprice`,`date_void`,`date_time`,`empID`) values (1,1,1,1,'4500.00','2022-06-15','2022-06-15 12:52:27',1),(2,0,1,1,'4500.00','2022-06-15','2022-06-15 17:54:34',1),(3,0,19,1,'8800.00','2022-06-16','2022-06-16 21:16:18',1),(4,0,19,1,'8800.00','2022-06-16','2022-06-16 21:16:30',1),(5,0,19,1,'8800.00','2022-06-16','2022-06-16 21:16:38',1),(6,0,19,1,'8800.00','2022-06-16','2022-06-16 21:16:48',1),(7,1,1,2,'9000.00','2022-06-17','2022-06-17 12:27:31',1),(8,1,1,2,'9000.00','2022-06-17','2022-06-17 12:27:40',1);

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
 `status` int(10) 
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

/*View structure for view vwclient */

/*!50001 DROP TABLE IF EXISTS `vwclient` */;
/*!50001 DROP VIEW IF EXISTS `vwclient` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwclient` AS select `c`.`CustID` AS `custID`,`c`.`Iddetails` AS `Iddetails`,concat(`c`.`lname`,', ',`c`.`fname`) AS `clientname`,concat(`c`.`Brgy`,' ',`c`.`city`) AS `address`,`c`.`contactno` AS `contactno`,`c`.`emailadd` AS `emailadd`,`cs`.`status` AS `status` from (`client` `c` join `clientstatus` `cs` on(`cs`.`clienstatusID` = `c`.`status`)) */;

/*View structure for view vwtransaction */

/*!50001 DROP TABLE IF EXISTS `vwtransaction` */;
/*!50001 DROP VIEW IF EXISTS `vwtransaction` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwtransaction` AS select `s`.`stockid` AS `stockid`,`i`.`itemid` AS `itemid`,`i`.`itemcode` AS `itemcode`,`t`.`ItemType` AS `itemtype`,`i`.`UnitP` AS `UnitP`,`tt`.`qty` AS `qty`,`tt`.`totalprice` AS `totalprice`,`tt`.`transId` AS `transId`,`tt`.`ornum` AS `ornum`,`tt`.`status` AS `status` from (((`stocks` `s` join `temp_transaction` `tt` on(`tt`.`totalstockId` = `s`.`stockid`)) join `items` `i` on(`i`.`itemid` = `s`.`itemid`)) join `itemtype` `t` on(`t`.`typeid` = `i`.`typeid`)) */;

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

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
