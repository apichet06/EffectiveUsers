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

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240205090145_AddDatabase'
)
BEGIN
    CREATE TABLE [Divisions] (
        [Id] int NOT NULL IDENTITY,
        [DV_ID] nvarchar(10) NOT NULL,
        [DVName] nvarchar(100) NOT NULL,
        CONSTRAINT [PK_Divisions] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240205090145_AddDatabase'
)
BEGIN
    CREATE TABLE [Positions] (
        [Id] int NOT NULL IDENTITY,
        [P_ID] nvarchar(10) NOT NULL,
        [P_Name] nvarchar(100) NOT NULL,
        CONSTRAINT [PK_Positions] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240205090145_AddDatabase'
)
BEGIN
    CREATE TABLE [Users] (
        [Id] int NOT NULL IDENTITY,
        [U_ID] nvarchar(10) NOT NULL,
        [Email] nvarchar(100) NULL,
        [UserLogin] nvarchar(40) NOT NULL,
        [Password] nvarchar(20) NOT NULL,
        [Username] nvarchar(50) NOT NULL,
        [Status] nvarchar(1) NOT NULL,
        [DV_ID] nvarchar(10) NOT NULL,
        [P_ID] nvarchar(10) NOT NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240205090145_AddDatabase'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240205090145_AddDatabase', N'8.0.1');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240205090251_AddBaseStatus'
)
BEGIN
    CREATE TABLE [status] (
        [Id] int NOT NULL IDENTITY,
        [ST_ID] nvarchar(10) NOT NULL,
        [StatusName] nvarchar(150) NOT NULL,
        CONSTRAINT [PK_status] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240205090251_AddBaseStatus'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240205090251_AddBaseStatus', N'8.0.1');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240206023021_updateUsers'
)
BEGIN
    ALTER TABLE [Users] ADD [EffectiveDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240206023021_updateUsers'
)
BEGIN
    ALTER TABLE [Users] ADD [EffectiveUpdateDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240206023021_updateUsers'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240206023021_updateUsers', N'8.0.1');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240206023219_updateUsersRequired'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240206023219_updateUsersRequired', N'8.0.1');
END;
GO

COMMIT;
GO

