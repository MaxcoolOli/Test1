CREATE TABLE [dbo].[Student] (
    [ID]         CHAR (10)      NOT NULL,
    [Name]       NVARCHAR (10)  NULL,
    [BirthDate]  DATE           NOT NULL,
    [Phone]      CHAR (10)      NULL,
    [Email]      VARCHAR (100)  NULL,
    [Gender]     CHAR (1)       NULL,
    [Address]    NVARCHAR (100) NULL,
    [School]     NVARCHAR (10)  NULL,
    [Department] NVARCHAR (10)  NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([ID] ASC)
);

