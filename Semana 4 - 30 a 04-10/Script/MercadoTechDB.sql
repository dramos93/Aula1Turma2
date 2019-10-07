--2 - Criar uma base de dados chamada MercadoTechDB
create database MercadoTechDB
Go
Use MercadoTechDB
Go
/*2.1 - A base deve conter as seguintes tabelas e seus campos	
		2.1.1 - Funcionario
			2.1.1.1 - Id,Nome e informações de controle*/
Create Table Funcionario
(
	[idFun]			int identity(1,1),
	[NomeFun]		nVarChar(30) Not Null Unique,
	[DatInc]		DateTime		default GetDate(),
	[DatAlt]		DateTime		Default GetDate(),
	[Ativo]			int				default 1
)
Go
/*		2.1.1 - Produtos
		2.1.1.1 - Id,Nome,Valor e informações de controle*/
		Create Table Produtos
(
	[IdPro]			int				identity(1,1),
	[NomePro]		nVarChar(50)	Not Null,
	[Valor]			Money			Default 0,
	[DatInc]		DateTime		default GetDate(),
	[DatAlt]		DateTime		Default GetDate(),
	[Ativo]			int				default 1
)
Go
/*	2.1.2 - Pedidos
	2.1.2.1 - Id,FuncionarioId,ProdutoId,Quantidade, e informações*/
Create	Table Pedidos
(
	[IdPed]			int				identity(1,1),
	[FuncionarioId]	int				Not Null,
	[ProdutoId]		int				Not Null,
	[Quantidade]	int				Default 1,
	[DatInc]		DateTime		default GetDate(),
	[DatAlt]		DateTime		Default GetDate(),
	[Ativo]			int				default 1
)
GO
--2.2  - Agora devemos inseir 2 funcionarios diferentes
Insert Into Funcionario(NomeFun) Values ('Daniel')
Insert Into Funcionario(NomeFun) Values ('Abigail')
--2.3  - Agora devemos cadastrar 5 produtos ambev com seus respectivos valores
Insert Into Produtos(NomePro,Valor) Values ('Original 600 mL',7.99)
Insert Into Produtos(NomePro,Valor) Values ('Guaraná 2L',6.50)
Insert Into Produtos(NomePro,Valor) Values ('Corona 355 mL',8.79)
Insert Into Produtos(NomePro,Valor) Values ('Fusion',4.99)
Insert Into Produtos(NomePro,Valor) Values ('budweiser',1.89)
/*	2.4  - Vamos realizar a felicidade dos funcionarios e realizar 3 pedidos, sendo 2 para o primeiro funcionario e 1 para o segundo
	lembrando que cada pedido deve contem no minimo 2 itens e maximo de 5*/
Insert Into Pedidos(FuncionarioId,ProdutoId,Quantidade) Values(1,4,6)
Insert Into Pedidos(FuncionarioId,ProdutoId,Quantidade) Values(1,5,24)
Insert Into Pedidos(FuncionarioId,ProdutoId,Quantidade) Values(2,2,2)
--2.5  - Vamos Listar em uma seleção de nossos funcionarios por ordem alfabetica
Select * From Funcionario Order by Funcionario.NomeFun asc
--2.6  - Vamos listar em uma seleção de nossos produtos do mais caro para o mais barato
Select * From Produtos Order By Produtos.Valor Desc
--2.7  - Vamos listar em uma seleção de nossos pedidos por funcionario trazendo o nome do funcionario
Select  Fun.NomeFun,Count(Ped.IdPed) as 'Total de Pedidos' From Pedidos Ped
inner join Funcionario Fun on Fun.idFun = Ped.FuncionarioId
Group by Fun.NomeFun
--2.8  - Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando sua respectiva quantidade de itens
Select Fun.NomeFun, Count(Ped.IdPed) as 'Pedidos', Sum(Ped.Quantidade) as 'Total de Itens' From Pedidos Ped
inner Join Funcionario Fun on Fun.idFun = Ped.FuncionarioId
group by Fun.NomeFun 
--2.9  - Vamos listar em uma seleção de nossos pedidos agrupando por 
--funcionario os pedidos e somando seu valor total lembrando que o valor total e a a "quantidade * valor"
Select Fun.NomeFun, Sum(ped.Quantidade) as 'Qtde', Sum(Ped.Quantidade*Pro.Valor) as 'Valor'From Pedidos ped
Inner Join Funcionario Fun on Fun.idFun = Ped.FuncionarioId
inner join Produtos pro on Pro.IdPro = Ped.ProdutoId
Group by Fun.NomeFun
--2.10 - Vamos retornar em uma seleção nosso produto mais pedido dentro de nossa base de dados
Select Top 1 * From Produtos Pro
Inner Join Pedidos Ped on Ped.ProdutoId = Pro.IdPro
Order By ped.Quantidade desc
--2.11 - Vamos retornar em uma seleção o produto que gerou a maior receita dentro de nossa base de dados 
Select Pro.NomePro, Pro.Valor, Ped.Quantidade, Ped.Quantidade*Pro.Valor as 'Valor Total' From Produtos Pro
Inner Join Pedidos Ped on Ped.ProdutoId = Pro.IdPro
Order By Ped.Quantidade*Pro.Valor Desc
--2.12 - Vamos retornar em uma seleção para o primeiro funcionario os produtos que ele não comprou de nosso mercado
Select * From  Produtos Pro
inner join Pedidos Ped on Pro.IdPro = Ped.ProdutoId
Inner Join Funcionario Fun on Fun.idFun = Ped.FuncionarioId
Where Fun.idFun = 1  

Select * From Produtos
Select * From Funcionario
Select * From Pedidos
