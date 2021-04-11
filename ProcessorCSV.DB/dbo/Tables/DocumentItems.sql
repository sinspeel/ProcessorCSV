CREATE TABLE [dbo].[DocumentItems] (
    [Id]                UNIQUEIDENTIFIER CONSTRAINT [DF_DocumentItems_Id] DEFAULT (newid()) ROWGUIDCOL NOT NULL,
    [DocumentID]        UNIQUEIDENTIFIER NOT NULL,
    [StudentNumber]     NVARCHAR (250)   NOT NULL,
    [FirstName]         NVARCHAR (250)   NOT NULL,
    [Surname]           NVARCHAR (250)   NOT NULL,
    [CourseCode]        NVARCHAR (250)   NOT NULL,
    [CourseDescription] NVARCHAR (250)   NOT NULL,
    [Grade]             NVARCHAR (250)   NOT NULL,
    CONSTRAINT [PK_DocumentItems] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_DocumentItems_Document] FOREIGN KEY ([DocumentID]) REFERENCES [dbo].[Document] ([Id])
);

