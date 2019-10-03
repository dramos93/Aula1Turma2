update Funcionarios set Ativo = 1

insert into Salarios (Funcionario,Valor) values (1,1500),(1,2500),(2,3000),(2,2800),(3,2300),(3,5500)

select Nome,(Select sum(Valor) from Salarios where Funcionario = Funcionarios.Id) as 'Salário' from  Funcionarios

/*Descobrindo o salário dos funcionários nos últimos 3 meses*/
select fun.Nome,
Sum(sal.Valor) as 'Total nos 3 Meses'
from Funcionarios fun
	inner join Salarios sal on fun.Id = sal.Funcionario group by fun.Nome

/*Descobrindo o salário dos funcionários nos últimos 3 meses e a quantidade de pagamentos*/
select fun.Nome,
Sum(sal.Valor) as 'Total nos 3 Meses',
count (sal.Valor) as 'Qtde Pagamentos'
from Funcionarios fun
	inner join Salarios sal on fun.Id = sal.Funcionario group by fun.Nome

/*Descobrindo o salário dos funcionários nos últimos 3 meses e a quantidade de pagamentos e a média dos pagamentos*/
select fun.Nome,
Sum(sal.Valor) as 'Total nos 3 Meses',
count (sal.Valor) as 'Qtde Pagamentos',
sum(sal.Valor)/count (sal.Valor) as 'Média Mensal'
from Funcionarios fun
	inner join Salarios sal on fun.Id = sal.Funcionario group by fun.Nome

/*Pego os Salários do 3 ao 8 Salarios da tabela*/
select * from Salarios where Id between 3 and 8

/*Paga os salário dentro de um período*/
select * from Funcionarios where DataCriacao between '12/12/2012' and getdate()

/*Tira a média nos últimos 3 meses de forma ascentende*/
select fun.Nome,
AVG(sal.valor) as 'Média Mensal',--Tira a média
count (sal.Valor) as 'Qtde Pagamentos', --conta a qauntidade de pagamentos
sum(sal.Valor)/count (sal.Valor) as 'Média Mensal',--Tira a média
SUM(sal.Valor) as 'Total'			--Soma valor Total no Período
from Funcionarios fun
	inner join Salarios sal on fun.Id = sal.Funcionario group by fun.Nome
	order by Sum(sal.Valor) asc--Ascendente ou 'desc' descendente

/*Funcionário Demitido, alterando data de saída, data de alteração e desativando ele do sistema*/
Update Funcionarios set DataSaida = GetDate(), DataAlteracao = GetDate(), Ativo = 0 where Nome like 'Mag%'
select * From Funcionarios where Nome like 'Mag%' --% no final pega a palavra quando começa do começo

select * From Funcionarios where Ativo = 1





