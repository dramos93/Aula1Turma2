
/*1 - Criar uma base de dados chamada FloriculturaDB
	1.1 - A base deve conter as seguintes tabelas e seus campos
		1.1.1 - Flores
			1.1.1.1 - Id,Nome,Quantidade
	1.2 - Devemos inserir ao menos 5 flores dentro de nossa tabelas*/
create database FloriculturaDB
go
Use FloriculturaDB 
Go
Create Table Flores
(
	[Id]			int				identity(1,1) ,
	[Nome]			nVarChar(30)	not null		unique,
	[Quantidade]	int				default 0
)
insert into Flores (Nome,Quantidade)values('Rosa',10)
insert into Flores (Nome,Quantidade)values('Bromélia',67)
insert into Flores (Nome,Quantidade)values('Cravo',35)
insert into Flores (Nome,Quantidade)values('Mosquitinho',357)
insert into Flores (Nome,Quantidade)values('Tulipa',27)
GO
--1.3 - Devemos ter uma seleção ordenada das flores, da que contem a maior quantidade para a menor
Select * from Flores order by Quantidade desc
GO
--1.3 - Devemos retornar uma seleção com a quantidade total de flores que temos em nossa tabela
Select Distinct Sum(Flores.Quantidade) as 'Total de Flores' from Flores 
Go

