CREATE VIEW vw_paymentprintfp AS 
SELECT 
	td.transno,
	td.clientid,
	p.paymenttype,
	pt.paymentname,
	td.discount,
	td.delfee,
	td.totadueamount,
	p.paymentdetails,
	p.amount,
	td.noi,
	td.amountchange,
	td.tDate
	
FROM transaction_details td
	JOIN payment p
		ON p.transno = td.transNo
	JOIN paymenttype pt
		ON pt.paymentid = p.paymenttype
		
CREATE VIEW vw_paymentprint50 AS 
SELECT 
	td2.transno,
	td2.clientid,
	pc.paymenttype,
	pt.paymentname,
	td2.discount,
	td2.delfee,
	td2.totadueamount,
	pc.paymentdetails,
	pc.amount,
	td2.numberofitems,
	td2.currentBal,
	td2.tDate
	
FROM transaction_details2 td2
	JOIN payment_copy pc
		ON pc.transno = td2.transNo
	JOIN paymenttype pt
		ON pt.paymentid = pc.paymenttype