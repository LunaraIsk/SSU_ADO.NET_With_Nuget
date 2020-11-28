CREATE DATABASE ApplicationSystem

ALTER DATABASE ApplicationSystem
COLLATE Cyrillic_General_100_CI_AI
GO

USE ApplicationSystem

CREATE TABLE Inventory
(
    IdInventory int NOT NULL IDENTITY(1,1) CONSTRAINT PK_Inventory PRIMARY KEY,
    Name nvarchar(20) NOT NULL
)
GO


CREATE TABLE Request
(
    IdRequest int NOT NULL IDENTITY(1,1) CONSTRAINT PK_Request PRIMARY KEY,
    DateOfCreation Date NOT NULL,
	Id_Inventory int NOT NULL,
	Amount int NOT NULL,
	Comment nvarchar(300) NOT NULL
)
GO 


ALTER TABLE Request
ADD
CONSTRAINT FK_Inventory_Request
FOREIGN KEY (Id_Inventory) REFERENCES Inventory (IdInventory)


INSERT INTO Inventory
VALUES
('Стул'),
('Стол'),
('Калькулятор'),
('Ведро'),
('Веник');
GO

INSERT INTO Request
VALUES
('2020-05-12', 1, 2, 'Изящные стулья с мягкими элементами');
GO

