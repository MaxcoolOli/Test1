CREATE TABLE [dbo].[Member] (
    [ID]           INT             IDENTITY (1, 1) NOT NULL,
    [Email]        VARCHAR (50)    NOT NULL,
    [Name]         NVARCHAR (10)   NULL,
    [Phone]        CHAR (10)       NULL,
    [Password]     CHAR (30)       NOT NULL,
    [CreateTime]   DATE            NULL,
    [EngName]      VARCHAR (20)    NULL,
    [BirthDate]    DATE            NULL,
    [Gender]       CHAR (1)        NULL,
    [Address]      NVARCHAR (100)  NULL,
    [Img]          VARBINARY (MAX) NULL,
    [Subscription] CHAR (1)        NULL,
    CONSTRAINT [PK_Member_1] PRIMARY KEY CLUSTERED ([ID] ASC)
);

