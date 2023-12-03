CREATE VIEW vw_vendor AS 
SELECT 
	v.vendorID,
	v.vendor,
	CONCAT(Street, ', ', Brgy,' ',City)AS address,
	CONCAT(LNAME, ',', Fname,' ',Mi)AS contactperson,
	v.contactNo,
	v.email
FROM vendor b
	JOIN vendor
		ON v.vendorID = v.vendorID;
		

CREATE VIEW vw_prod AS 
SELECT 
	i.itemid,
	i.itemcode,
	t.itemtype,
	i.Description,
	i.UnitP
FROM items i
	JOIN itemtype t
		ON t.typeid = i.typeid;
		

CREATE VIEW vw_items AS 
SELECT 
	s.stockid,
	i.itemid,
	i.itemcode,
	t.Itemtype,
	i.Description,
	i.UnitP,
	s.quantity
FROM stocks s
	JOIN items i
		ON s.itemid = i.itemid
	JOIN itemtype t
		ON i.typeid = t.typeid
		
CREATE VIEW vwtransaction AS
SELECT
	s.stockid,
	i.itemid,
	t.itemtype,
	i.UnitP,
	tr.qty,
	tr.totalprice,
	tr.transId,
	tr.ornum
FROM stocks s
	JOIN transactions tr
		ON tr.stockid = s.stockid
	JOIN items i
		ON i.itemid = s.itemid
	JOIN itemtype t
		ON t.typeid = i.typeid
	