CREATE TABLE [dbo].[Document] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [DocumentName] NVARCHAR (250)   NOT NULL,
    [CreateDate]   DATETIME         CONSTRAINT [DF_Document_CreateDate] DEFAULT (getdate()) NOT NULL,
    [LastModified] DATETIME         NULL,
    [IsDeleted]    BIT              CONSTRAINT [DF_Document_IsDeleted] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Document] PRIMARY KEY CLUSTERED ([Id] ASC)
);

