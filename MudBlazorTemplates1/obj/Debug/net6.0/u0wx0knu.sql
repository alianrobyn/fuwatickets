IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Train] (
    [ID] int NOT NULL IDENTITY,
    [Z_K] nvarchar(max) NOT NULL,
    [Date] datetime2 NOT NULL,
    [V_P] nvarchar(max) NOT NULL,
    [VM] int NOT NULL,
    [Sum] int NOT NULL,
    CONSTRAINT [PK_Train] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [User] (
    [ID] int NOT NULL IDENTITY,
    [Email] nvarchar(max) NOT NULL,
    [Password] nvarchar(max) NOT NULL,
    [Password2] nvarchar(max) NOT NULL,
    [Surname] nvarchar(max) NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Phone] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [Ticket] (
    [Id] int NOT NULL IDENTITY,
    [Status] int NOT NULL,
    [UserId] int NOT NULL,
    [Surname] nvarchar(max) NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [TrainId] int NOT NULL,
    [Z_K] nvarchar(max) NOT NULL,
    [Date] datetime2 NOT NULL,
    [V_P] nvarchar(max) NOT NULL,
    [Type] int NOT NULL,
    [Service] int NULL,
    [Sum] int NOT NULL,
    [Action] nvarchar(max) NULL,
    CONSTRAINT [PK_Ticket] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Ticket_Train_TrainId] FOREIGN KEY ([TrainId]) REFERENCES [Train] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Ticket_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [User] ([ID]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Ticket_TrainId] ON [Ticket] ([TrainId]);
GO

CREATE INDEX [IX_Ticket_UserId] ON [Ticket] ([UserId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230325123751_InitialCreate', N'7.0.4');
GO

COMMIT;
GO

