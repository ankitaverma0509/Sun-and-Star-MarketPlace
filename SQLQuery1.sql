CREATE TABLE [dbo].[TblRegister] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50)   NOT NULL,
    [Role]        VARCHAR (50)   NOT NULL,
    [UserId]      VARCHAR (250)  NOT NULL,
    [Password]    NVARCHAR (MAX) NOT NULL,
    [CompanyName] VARCHAR (250)  NOT NULL,
    [SecurityAns] VARCHAR (50)   NOT NULL,
    [Contact]     NVARCHAR (10)  NOT NULL,
    [Address]     VARCHAR (500)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([UserId] ASC)
);