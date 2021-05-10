CREATE TABLE [dbo].[Product]
(
	[PRODUCT_ID]        INT           IDENTITY (1, 1)   NOT NULL,
    [SKU]               VARCHAR(50)                         NULL, 
    [TITLE]             VARCHAR(MAX)                        NULL, 
    [DESCRIPTION]       VARCHAR(MAX)                        NULL, 
    [PRICE]             DECIMAL(15, 2)                      NULL, 
    [COST]              DECIMAL(15, 2)                      NULL,
    PRIMARY KEY CLUSTERED ([PRODUCT_ID] ASC)
)
