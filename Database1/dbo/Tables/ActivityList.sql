CREATE TABLE [dbo].[ActivityList] (
    [ActivityID] INT           IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (15) NOT NULL,
    [StartDate]  DATE          NULL,
    [EndDate]    DATE          NULL,
    [Cost]       INT           NULL,
    [Place]      NVARCHAR (15) NULL,
    CONSTRAINT [PK_ActivityList] PRIMARY KEY CLUSTERED ([ActivityID] ASC)
);

