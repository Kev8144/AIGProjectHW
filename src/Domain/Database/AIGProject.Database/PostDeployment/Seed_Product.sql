SET NOCOUNT ON
	--Delete current values
DELETE FROM PRODUCT
    --Seed Product values      
INSERT INTO PRODUCT ( SKU, TITLE, DESCRIPTION, PRICE, COST) VALUES ('10-1-100','Great Book Part I','The first book in the series',9.99,4.27)
INSERT INTO PRODUCT ( SKU, TITLE, DESCRIPTION, PRICE, COST) VALUES ('10-1-101','Great Book Part II','The sequel',10.00,4.68)
INSERT INTO PRODUCT ( SKU, TITLE, DESCRIPTION, PRICE, COST) VALUES ('10-2-100','Yet Another Book','Another book here',9.95,4.35)
