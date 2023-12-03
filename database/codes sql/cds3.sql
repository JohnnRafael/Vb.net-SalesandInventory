DELIMITER $$

USE `salesandinventory`$$

DROP VIEW IF EXISTS `vw_prod`$$

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_prod` AS 
SELECT
  `i`.`itemid`      AS `itemid`,
  `i`.`itemcode`    AS `itemcode`,
  `t`.`itemtype`      AS `itemtype`,
  `i`.`Description` AS `Description`,
  `i`.`UnitP`       AS `UnitP`
FROM (`items` `i`
   JOIN `itemtype` `t`
     ON (`t`.`typeid` = `i`.`typeid`))$$

DELIMITER ;