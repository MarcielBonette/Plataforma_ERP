CREATE TABLE [dbo].[Table]
(
	[Id] NTEXT NOT NULL PRIMARY KEY, 
    [Nome] NVARCHAR(50) NOT NULL, 
    [RG] NVARCHAR(9) NULL, 
    [CPF] NVARCHAR(10) NULL, 
    [DateOfBirth] NVARCHAR(8) NULL, 
    [Telephone] NCHAR(10) NULL, 
    [Adress] NVARCHAR(100) NULL, 
    [Password] NVARCHAR(50) NULL
)
