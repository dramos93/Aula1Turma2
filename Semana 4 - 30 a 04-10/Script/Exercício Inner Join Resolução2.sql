--Trazer somente as marcas que Felipe cadastrou
select * from Marcas mar
inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Felipe'
--Trazer somente as marcas que Giomar cadastrou
select * from Marcas mar
inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Gi%'
--Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor
select usu.Usuario,COunt(mar.UsuInc) from Marcas mar
inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Felipe%'
group by usu.Usuario
order by usu.Usuario desc
--Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
select usu.Usuario,COunt(mar.UsuInc) from Marcas mar
inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Giomar%'
group by usu.Usuario
order by usu.Usuario desc
--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 
select usu.Usuario, count(mar.Nome) as 'Total'from Marcas mar
inner join Usuarios usu on usu.Id=mar.UsuInc
group by usu.Usuario
--Trazer somente os carros que Felipe cadastrou
select car.Modelo from Carros car
inner join Usuarios usu on usu.Id = car.UsuInc
where usu.Usuario like 'Fe%'
--Trazer somente os carros que Giomar cadastrou
select car.Modelo from Carros car
inner join Usuarios usu on usu.Id = car.UsuInc
where usu.Usuario like 'Gi%'
--Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
select usu.Usuario, count(car.Modelo) as 'Quantidade' from Carros car
inner join Usuarios usu on usu.Id = car.UsuInc
where usu.Usuario like 'Felipe%'
group by usu.Usuario
order by count(car.Modelo) desc
--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
select usu.Usuario, count(car.Modelo) as 'Quantidade' from Carros car
inner join Usuarios usu on usu.Id = car.UsuInc
where usu.Usuario like 'Gi%'
group by usu.Usuario
order by count(car.Modelo) asc
--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 
select usu.Usuario,count(car.Modelo) as 'Qtde' from Carros car
inner join Marcas mar on mar.Id = car.Marca
inner join Usuarios usu on usu.Id = mar.UsuInc
group by usu.Usuario
--Trazer somente os carros das marcas que Felipe cadastrou
select usu.Usuario, car.Modelo from Carros car
inner join Marcas mar on mar.Id = car.Marca
inner join Usuarios usu on usu.id = mar.UsuInc
where usu.Usuario  like 'Felipe%'
--Trazer somente os carros das marcas que Giomar cadastrou
select usu.Usuario, car.Modelo from Carros car
inner join Marcas mar on mar.Id = car.Marca
inner join Usuarios usu on usu.id = mar.UsuInc
where usu.Usuario  like 'Gi%'
--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
select usu.Usuario, count(car.Modelo) as 'Total' from Carros car
inner join Marcas mar on mar.Id = car.Marca
inner join Usuarios usu on usu.id = mar.UsuInc
where usu.Usuario  like 'Fe%'
group by usu.Usuario
order by count(car.Modelo) desc
--Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
select usu.Usuario, count(car.Modelo) as 'Total' from Carros car
inner join Marcas mar on mar.Id = car.Marca
inner join Usuarios usu on usu.id = mar.UsuInc
where usu.Usuario  like 'Gi%'
group by usu.Usuario
order by count(car.Modelo) asc
--Trazer o valor total de vendas 2019 isolado
select sum(ven.Valor*ven.Quantidade) as 'Vendas em 2019' from Vendas ven
where year(ven.DatInc) = 2019
--Trazer a quantidade total de vendas 2019 isolado
select sum(ven.Quantidade) as 'Quantidade de Vendas' from Vendas ven
where YEAR(ven.DatInc) = 2019
--Trazer o valor total de vendas em cada ano e ordernar do maior para o menor
select distinct year(ven.DatInc) as 'Ano', sum(ven.Quantidade*ven.Valor)  as 'Soma de Valores'	 from Vendas ven
group by  year(ven.DatInc)
order by sum(ven.Quantidade*ven.Valor) desc
--Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor
select year(ven.DatInc) as 'Ano', count(ven.Quantidade)  as 'Soma de Vendas'	 from Vendas ven
group by  year(ven.DatInc)
order by sum(ven.Quantidade) desc
/*Trazer o mês de cada ano que retornou a maior quantidade de vendas
		- Tradução "Retornar agrupado por mês e ordernar do maior para menor"
*/
select  year(ven1.DatInc) as 'Ano',  
(select top 1 MONTH(ven.DatInc)   from Vendas ven WHERE YEAR(ven.DatInc) = YEAR(ven1.DatInc) group by MONTH(ven.DatInc)ORDER BY SUM(ven.Quantidade) DESC) as'Mês'
from Vendas ven1
group by year(ven1.DatInc)

SELECT YEAR(ven1.DatInc) as 'Ano',
(SELECT TOP 1 MONTH(ven.DatInc) FROM Vendas ven WHERE YEAR(ven.DatInc) = YEAR(ven1.DatInc)  GROUP BY MONTH(ven.DatInc)  ORDER BY SUM(ven.Quantidade) DESC) as 'Mês',
(select  top 1  count(ven2.Quantidade) from vendas ven2 where YEAR(ven2.DatInc) = YEAR(ven1.DatInc) GROUP BY ven2.Quantidade ORDER BY SUM(ven2.Quantidade)desc)
FROM Vendas ven1
GROUP BY YEAR(ven1.DatInc)
/*Trazer o mês de cada ano que retornou o maior valor de vendas
		- Tradução "Retornar agrupado por mês e ordernar do maior para menor"*/
SELECT YEAR(ven1.DatInc) as 'Ano',MONTH(ven1.DatInc) as'Mês',
(SELECT TOP 1 MONTH(ven.DatInc)FROM Vendas ven WHERE YEAR(ven.DatInc) = YEAR(ven1.DatInc)
GROUP BY MONTH(ven.DatInc)
ORDER BY SUM(ven.Valor) DESC)
FROM Vendas ven1
GROUP BY YEAR(ven1.DatInc),MONTH(ven1.DatInc)

/*Trazer o valor total de vendas que Felipe realizou*/
select distinct sum(Ven.Valor), usu.Usuario from vendas ven
inner join Usuarios usu on usu.id = ven.UsuInc
where usu.Usuario like 'Fe%'
group by usu.Usuario
--Trazer o valor total de vendas que Giomar realizou
select distinct sum(Ven.Valor), usu.Usuario from vendas ven
inner join Usuarios usu on usu.id = ven.UsuInc
where usu.Usuario like 'Gi%'
group by usu.Usuario
--Trazer a quantidade total de vendas que Felipe realizou
select distinct count(Ven.Valor), usu.Usuario from vendas ven
inner join Usuarios usu on usu.id = ven.UsuInc
where usu.Usuario like 'Fe%'
group by usu.Usuario
--Trazer a quantidade de vendas que Giomar realizou
select distinct count(Ven.Valor), usu.Usuario from vendas ven
inner join Usuarios usu on usu.id = ven.UsuInc
where usu.Usuario like 'Gi%'
group by usu.Usuario
--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select distinct count(Ven.Valor), usu.Usuario from vendas ven
inner join Usuarios usu on usu.id = ven.UsuInc
group by usu.Usuario
order by count(Ven.Valor) desc
--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select distinct sum(Ven.Valor), usu.Usuario from vendas ven
inner join Usuarios usu on usu.id = ven.UsuInc
group by usu.Usuario
order by sum(Ven.Valor) desc
--Trazer  as marcas mais vendida de todos os anos
		-- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"
select year(ven.DatInc) as 'Ano',mar.Nome, sum(ven.Valor) as 'Valor' from Vendas ven
inner join Carros car on car.Id = ven.Carro
inner join Marcas mar on mar.Id = car.Marca
group by mar.Nome,year(ven.DatInc)
order by Sum(ven.Valor) desc
--Trazer o valor total da marca mais vendida de todos os anos
select   mar.nome, sum(ven.Valor) as 'Valor', sum(ven.Quantidade) as 'Qtde' from Vendas ven
inner join Carros car on car.Id = ven.Carro
inner join Marcas mar on mar.Id = car.Marca
group by mar.nome
order by sum(ven.Quantidade) desc
--Trazer a quantidade do carro mais vendido de todos os anos
select top 1  car.Modelo, ven.Valor as 'valor',sum(ven.Quantidade) as 'Qtde' from Vendas ven
inner join Carros car on car.Id = ven.Carro
group by car.Modelo,ven.Valor 
order by sum(ven.Quantidade) desc
--Trazer o valor do carro mais vendido de todos os anos
select top 1  car.Modelo, ven.Valor as 'valor', sum(ven.Quantidade) as 'Qtde' from Vendas ven
inner join Carros car on car.Id = ven.Carro
group by ven.Valor,car.Modelo
order by sum(ven.Quantidade) desc


