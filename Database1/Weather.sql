﻿CREATE TABLE [dbo].[Weather]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [JsonData] VARCHAR(MAX) NULL, 
    [CreateTime] DATETIME NULL
)
