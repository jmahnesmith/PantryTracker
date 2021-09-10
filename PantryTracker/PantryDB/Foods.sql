CREATE TABLE [dbo].[Foods]
(
   upc                      INTEGER NOT NULL PRIMARY KEY,
   food_name                 VARCHAR(7) NOT NULL
  ,brand_name                VARCHAR(10) NOT NULL
  ,serving_qty               NUMERIC(3,1) NOT NULL
  ,serving_unit              VARCHAR(30) NOT NULL
  ,serving_weight_grams      VARCHAR(30)
  ,[calories]               INTEGER  NULL
  ,[total_fat]              INTEGER  NULL
  ,[saturated_fat]          INTEGER  NULL
  ,[cholesterol]            INTEGER  NULL
  ,[sodium]                 INTEGER  NULL
  ,[total_carbohydrate]     INTEGER  NULL
  ,[dietary_fiber]          INTEGER  NULL
  ,[sugars]                 INTEGER  NULL
  ,[protein]                INTEGER  NULL
  ,[potassium]              VARCHAR(30)
  ,tags                      VARCHAR(30)
  ,
    [photo] VARCHAR(50) NULL
  
  
)
