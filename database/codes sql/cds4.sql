DELIMITER $$

USE `salesandinventory`$$

DROP VIEW IF EXISTS `vw_inv`$$

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_inv` AS 
SELECT
  `s`.`stockid`     AS `stockid`,
  `p`.`itemcode`    AS `itemcode`,
  `p`.`itemtype`    AS `itemtype`,
  `p`.`Description` AS `Description`,
  `p`.`UnitP`       AS `UnitP`
  s.quanity AS quantity
  s.quanity * p.UnitP AS Total
FROM (`vw_prod` `p`
   JOIN `stocks` `s`
     ON (`s`.`itemid` = `p`.`itemid`))$$

DELIMITER ;