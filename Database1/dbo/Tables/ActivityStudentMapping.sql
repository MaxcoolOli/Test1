CREATE TABLE [dbo].[ActivityStudentMapping] (
    [ID]         CHAR (10) NOT NULL,
    [ActivityID] INT       NOT NULL,
    CONSTRAINT [PK_ActivityStudentMapping] PRIMARY KEY CLUSTERED ([ID] ASC, [ActivityID] ASC)
);

