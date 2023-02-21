
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/04/2023 16:22:59
-- Generated from EDMX file: G:\C-Dac\7_.NET\Projects\Demo\Demo\17_Entity_Framework\PuneDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [puneDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EmpEmpDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Emps] DROP CONSTRAINT [FK_EmpEmpDetails];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EmpDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmpDetails];
GO
IF OBJECT_ID(N'[dbo].[Emps]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Emps];
GO
IF OBJECT_ID(N'[dbo].[Tables]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tables];
GO
IF OBJECT_ID(N'[dbo].[Tests]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tests];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Tables'
CREATE TABLE [dbo].[Tables] (
    [Id] int  NOT NULL,
    [Name] nchar(10)  NOT NULL,
    [Role] nvarchar(50)  NULL
);
GO

-- Creating table 'Tests'
CREATE TABLE [dbo].[Tests] (
    [No] int  NOT NULL,
    [Name] varchar(50)  NULL,
    [Address] varchar(50)  NULL
);
GO

-- Creating table 'Emps'
CREATE TABLE [dbo].[Emps] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [EmpDetail_DetailId] int  NOT NULL
);
GO

-- Creating table 'EmpDetails'
CREATE TABLE [dbo].[EmpDetails] (
    [DetailId] int IDENTITY(1,1) NOT NULL,
    [EmpNo] nvarchar(max)  NOT NULL,
    [PhoneNo] nvarchar(max)  NOT NULL,
    [FullAddress] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Tables'
ALTER TABLE [dbo].[Tables]
ADD CONSTRAINT [PK_Tables]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [No] in table 'Tests'
ALTER TABLE [dbo].[Tests]
ADD CONSTRAINT [PK_Tests]
    PRIMARY KEY CLUSTERED ([No] ASC);
GO

-- Creating primary key on [Id] in table 'Emps'
ALTER TABLE [dbo].[Emps]
ADD CONSTRAINT [PK_Emps]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [DetailId] in table 'EmpDetails'
ALTER TABLE [dbo].[EmpDetails]
ADD CONSTRAINT [PK_EmpDetails]
    PRIMARY KEY CLUSTERED ([DetailId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EmpDetail_DetailId] in table 'Emps'
ALTER TABLE [dbo].[Emps]
ADD CONSTRAINT [FK_EmpEmpDetails]
    FOREIGN KEY ([EmpDetail_DetailId])
    REFERENCES [dbo].[EmpDetails]
        ([DetailId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpEmpDetails'
CREATE INDEX [IX_FK_EmpEmpDetails]
ON [dbo].[Emps]
    ([EmpDetail_DetailId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------