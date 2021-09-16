CREATE PROCEDURE [dbo].[Foods_AddFood]
	@upc int,
	@food_name varchar(50),
	@brand_name varchar(50),
	@serving_qty int,
	@serving_unit varchar(50),
	@serving_weight_grams int,
	@calories int,
	@total_fat int,
	@saturated_fat int,
	@cholesterol int,
	@sodium int,
	@total_carbohydrate int,
	@dietary_fiber int,
	@sugars int,
	@protien int,
	@potassium int,
	@tags nvarchar(50),
	@photo nvarchar(50)
AS
BEGIN
	IF NOT EXISTS (select * from [dbo].[Foods]
				   where [upc] = @upc)
		BEGIN
			INSERT INTO [dbo].[Foods] 
			([upc], [food_name], [brand_name], [serving_qty], [serving_unit], [serving_weight_grams], [calories], [total_fat], [saturated_fat], [cholesterol], [sodium], [total_carbohydrate], [dietary_fiber], [sugars], [protien], [potassium], [tags], [photo]) 
			VALUES (@upc, @food_name, @brand_name, @serving_qty, @serving_unit, @serving_weight_grams, @calories, @total_fat, @saturated_fat, @cholesterol, @sodium, @total_carbohydrate, @dietary_fiber, @sugars, @protien, @potassium, @tags, @photo)
		END
	ELSE
		BEGIN
			UPDATE [dbo].[Foods]
			SET [amount] = [amount] + 1
			WHERE [upc] = @upc
		END
END