create database SistemaRH
GO
use SistemaRH
GO
create table [dbo].[Salarios]
(
	[Id]				INT  PRIMARY KEY IDENTITY(1,1),
	[Funcionario]		INT					NOT NULL,
	[Valor]				MONEY			DEFAULT 0 NOT NULL UNIQUE,
    [Ativo]				BIT				DEFAULT ((1)) NULL,
    [UsuarioCriacao]	INT				DEFAULT ((0)) NULL,
    [UsuarioAlteracao]	INT				DEFAULT ((0)) NULL,
    [DataCriacao]		DATETIME		DEFAULT (getdate()) NULL,
    [DataAlteracao]		DATETIME		DEFAULT (getdate()) NULL,
)
GO
create table [dbo].[Funcionarios]
(
	[Id]				INT  PRIMARY KEY IDENTITY(1,1),
	[Nome]				NVARCHAR(30)	NOT NULL,
    [DataInicio]		DATETIME		DEFAULT (getdate()) NULL,
    [DataSaida]			DATETIME		NULL,
    [Ativo]				BIT				DEFAULT ((1)) NULL,
    [UsuarioCriacao]	INT				DEFAULT ((0)) NULL,
    [UsuarioAlteracao]	INT				DEFAULT ((0)) NULL,
    [DataCriacao]		DATETIME		DEFAULT (getdate()) NULL,
    [DataAlteracao]		DATETIME		DEFAULT (getdate()) NULL,
)
GO
INSERT INTO Funcionarios(Nome,DataInicio) VALUES ('Daniel Silva Ramos','06/02/2018')
INSERT INTO Funcionarios(Nome,DataInicio) VALUES ('Suzana Paulista','12/02/2018')
INSERT INTO Funcionarios(Nome,DataInicio) VALUES ('Magda Ramos','04/07/2018')
