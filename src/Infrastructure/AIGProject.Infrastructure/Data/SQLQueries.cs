using System;
using System.Collections.Generic;
using System.Text;

namespace AIGProject.Infrastructure.Data
{
    /// <summary>
    /// CRUD operation queries
    /// </summary>
    public static class SqlQueries
    {
        // Product queries
        public static string ProductAdd => @"INSERT INTO PRODUCT (	
                     SKU
                    ,DESCRIPTION
                    ,PRICE
                    ,COST                    
                    ) VALUES (
                     @Sku
                    ,@Price
                    ,@Cost
                    );
                        SELECT CAST(SCOPE_IDENTITY() as int);";
        public static string ProductFind => @"SELECT PRODUCT_ID  as ProductId
                      , SKU                 as Sku
                      , DESCRIPTION         as Description
                      , PRICE               as Price
                      , COST                as Cost
                            FROM PRODUCT
                           WHERE PRODUCT_ID = @ProductId";
        public static string ProductGetAll => @"SELECT PRODUCT_ID  as ProductId
                      , SKU                 as Sku
                      , DESCRIPTION         as Description
                      , PRICE               as Price
                      , COST                as Cost
                        FROM PRODUCT";
        public static string ProductDelete => @"DELETE FROM PRODUCT WHERE PRODUCT_ID = @Id";
        public static string ProductUpdate => @"UPDATE Product SET 
                                    SKU                 =   @Sku
                                  , DESCRIPTION         =   @Description
                                  , PRICE               =   @Price
                                  , COST                =   @Cost
                                    WHERE  PRODUCT_ID   =   @ProductId";
    }
}
