CREATE TABLE [dbo].[Foods]
(
   nix_item_id               VARCHAR(24) NOT NULL PRIMARY KEY
  ,food_name                 VARCHAR(7) NOT NULL
  ,brand_name                VARCHAR(10) NOT NULL
  ,serving_qty               NUMERIC(3,1) NOT NULL
  ,serving_unit              VARCHAR(2) NOT NULL
  ,serving_weight_grams      VARCHAR(30)
  ,nf_calories               INTEGER  NOT NULL
  ,nf_total_fat              INTEGER  NOT NULL
  ,nf_saturated_fat          INTEGER  NOT NULL
  ,nf_cholesterol            INTEGER  NOT NULL
  ,nf_sodium                 INTEGER  NOT NULL
  ,nf_total_carbohydrate     INTEGER  NOT NULL
  ,nf_dietary_fiber          INTEGER  NOT NULL
  ,nf_sugars                 INTEGER  NOT NULL
  ,nf_protein                INTEGER  NOT NULL
  ,nf_potassium              VARCHAR(30)
  ,nf_p                      VARCHAR(30)
  ,nix_brand_name            VARCHAR(10) NOT NULL
  ,nix_brand_id              VARCHAR(24) NOT NULL
  ,nix_item_name             VARCHAR(7) NOT NULL
  ,source                    INTEGER  NOT NULL
  ,ndb_no                    VARCHAR(30)
  ,tags                      VARCHAR(30)
  ,alt_measures              VARCHAR(30)
  ,photothumb                VARCHAR(62) NOT NULL
  ,photohighres              VARCHAR(30)
)
