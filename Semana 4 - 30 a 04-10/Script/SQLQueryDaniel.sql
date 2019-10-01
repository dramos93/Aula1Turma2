CREATE DATABASE BaseSistemaLocacao --Criamos nossa base de dados
GO
USE BaseSistemaLocacao --Indicamos que estamos usando ele logo abaixo
GO
--1 - Deve,ps criar um Script de exportação da nossa base de dados esse script deve conter todas nossas tabelas
--2 Devemos popular a tabelas ao final do nosso com nosso usuario admin
--3 Devemos popupar nossa tabela de marcas com nossas marcas já cadastradas

CREATE TABLE [dbo].[Usuarios] (
    [Id]               INT         IDENTITY (1, 1) NOT NULL,
    [Nome]             NCHAR (100) NOT NULL,
    [Login]            NCHAR (50)  NULL,
    [Senha]            NCHAR (50)  NULL,
    [Ativo]            BIT         DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
CREATE TABLE [dbo].[Marcas] 
(
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Nome]   NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Codigo] ASC)
);
GO
CREATE TABLE [dbo].[Carros] (
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [Modelo ]          NCHAR (50) NOT NULL,
    [MarcaCodigo]      INT        DEFAULT (NULL) NULL,
    [Placa]            NCHAR (7)  NULL,
    [Ano]              INT        NULL,
    [Ativo]            BIT        DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
CREATE TABLE [dbo].[Locacoes] (
    [Id]               INT      IDENTITY (1, 1) NOT NULL,
    [UsuarioId]        INT      NOT NULL,
    [Carrold]          INT      NULL,
    [Valor]            MONEY    NULL,
    [DataInicial]      DATETIME DEFAULT (getdate()) NULL,
    [DataDevolucao]    DATETIME DEFAULT (dateadd(day, (5), getdate())) NULL,
    [Ativo]            BIT      DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT      DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT      DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
Insert into Usuarios (Nome,Login,Senha,UsuarioCriacao) values ('Tu Mesmo','admin','admin')
GO
Insert into Marcas(Codigo,Nome) values (1,'VOLKSWAGEN'),(2,'Chevrolet')
-- Inserir um usuário padrão com Admin Admin
-- INserir os dados da tabela Marcas ou seja, os insert
