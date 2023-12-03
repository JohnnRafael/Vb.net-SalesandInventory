DELIMITER $$

USE `salesandinventory`$$

DROP VIEW IF EXISTS `vw_inventory`$$

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_inventory` AS 
SELECT 
	`s`.`stockid` AS `stockid`,
	`i`.`itemcode` AS `itemcode`,`i`.`itemtype` AS `itemtype`,`i`.`Description` AS `description`,`i`.`UnitP` AS `UnitP`,`s`.`quantity` AS `quantity`,`i`.`UnitP` * `s`.`quantity` AS `Total` FROM (`stocks` `s` JOIN `items` `i` ON(`i`.`itemid` = `s`.`itemid`))$$

DELIMITER ;