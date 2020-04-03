/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------

The idea behind this script is to put default values which application demands in order to work
*/

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Margheritta' AND ItemPrice = 20 AND ItemType = 'Pizza')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Margheritta', 20, 'Pizza');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Vegetariana' AND ItemPrice =  22 AND ItemType = 'Pizza')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Vegetariana', 22, 'Pizza');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Tosca' AND ItemPrice = 25 AND ItemType = 'Pizza')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Tosca', 25, 'Pizza');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Venecia' AND ItemPrice = 25 AND ItemType = 'Pizza')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Venecia', 25, 'Pizza');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Podwójny Ser' AND ItemPrice = 2 AND ItemType = 'PizzaAdd')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Podwójny Ser', 2, 'PizzaAdd');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Salami' AND ItemPrice = 2 AND ItemType = 'PizzaAdd')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Salami', 2, 'PizzaAdd');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Szynka' AND ItemPrice = 2 AND ItemType = 'PizzaAdd')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Szynka', 2, 'PizzaAdd');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Pieczarki' AND ItemPrice = 2 AND ItemType = 'PizzaAdd')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Pieczarki', 2, 'PizzaAdd');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Schabowy z ryżem' AND ItemPrice = 30 AND ItemType = 'MainDish')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Schabowy z ryżem', 30, 'MainDish');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Schabowy z frytkami' AND ItemPrice = 30 AND ItemType = 'MainDish')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Schabowy z frytkami', 30, 'MainDish');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Schabowy z ziemniakami' AND ItemPrice = 30 AND ItemType = 'MainDish')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Schabowy z ziemniakami', 30, 'MainDish');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Ryba z frytkami' AND ItemPrice = 28 AND ItemType = 'MainDish')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Ryba z frytkami', 28, 'MainDish');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Placek po węgiersku' AND ItemPrice = 28 AND ItemType = 'MainDish')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Placek po węgiersku', 28, 'MainDish');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Bar sałatkowy' AND ItemPrice = 5 AND ItemType = 'MDAdd')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Bar sałatkowy', 5, 'MDAdd');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Zestaw sosów' AND ItemPrice = 6 AND ItemType = 'MDAdd')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Zestaw sosów', 6, 'MDAdd');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Pomidorowa' AND ItemPrice = 12 AND ItemType = 'Soup')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Pomidorowa', 12, 'Soup');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Rosół' AND ItemPrice = 10 AND ItemType = 'Soup')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Rosół', 10, 'Soup');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Kawa' AND ItemPrice = 5 AND ItemType = 'Drink')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Kawa', 5, 'Drink');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Herbata' AND ItemPrice = 5 AND ItemType = 'Drink')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Herbata', 5, 'Drink');
END

IF NOT EXISTS(SELECT * FROM dbo.Menu WHERE ItemName = 'Cola' AND ItemPrice = 5 AND ItemType = 'Drink')
BEGIN
    INSERT INTO dbo.Menu(ItemName, ItemPrice, ItemType)
    VALUES ('Cola', 5, 'Drink');
END
