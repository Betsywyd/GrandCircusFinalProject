--use whatisfordinnerdb;
--select * from Accounts;
create table SavedRecipe(
Id int primary key identity(1,1),
RecipeId int not null,
Title varchar(255),
Ingredients varchar(max),
IngredientAmount varchar(max),
[Image] varchar(max) not null,
 ReadyInMinutes int,
 Servings int,
 AnalizedInstructions varchar(max)
);
DROP TABLE SavedRecipe;