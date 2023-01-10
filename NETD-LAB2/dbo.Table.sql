CREATE TABLE [dbo].[lend]
(
	[name] NVARCHAR(MAX) NULL , 
    [empID] INT NOT NULL, 
    [desc] NVARCHAR(MAX) NULL, 
    [phone] NVARCHAR(MAX) NULL, 
    PRIMARY KEY ([empID])
)
