CREATE TABLE [dbo].[Foods]
(
	[upc] INT NOT NULL PRIMARY KEY, 
    [food_name] VARCHAR(50) NULL, 
    [brand_name] VARCHAR(50) NULL, 
    [serving_qty] INT NULL, 
    [serving_unit] VARCHAR(50) NULL, 
    [serving_weight_grams] INT NULL, 
    [calories] INT NULL, 
    [total_fat] INT NULL, 
    [saturated_fat] INT NULL, 
    [cholesterol] INT NULL, 
    [sodium] INT NULL, 
    [total_carbohydrate] INT NULL, 
    [dietary_fiber] INT NULL, 
    [sugars] INT NULL, 
    [protien] INT NULL, 
    [potassium] INT NULL, 
    [tags] NVARCHAR(50) NULL, 
    [photo] NVARCHAR(50) NULL 
)
