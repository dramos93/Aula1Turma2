
/*Realizar um update das informações que contem usuario de criação 0 para o Id do usuario Felipe*/
update marcas set UsuInc = 1 where UsuInc = 0

/*Trazer somente as marcas que Felipe cadastrou*/
select  mar.NOme from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id where usu.Usuario like 'Felipe%'
/*Trazer somente as marcas que Giomar cadastrou*/
select  mar.Nome from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id where usu.Usuario like 'Giomar%'

/*Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor "colocar o order by desc   no final do select só isso "*/
select Usuarios.Usuario, count(Marcas.UsuInc) as 'Total' 
from Marcas inner join Usuarios on marcas.UsuInc = Usuarios.Id 
where Usuarios.Usuario like 'Fel%'
group by Usuarios.Usuario order by Usuarios.Usuario desc

/*Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior*/
select Usuarios.Usuario, count(Marcas.UsuInc) as 'Total' 
from Marcas inner join Usuarios on marcas.UsuInc = Usuarios.Id 
where Usuarios.Usuario like 'Gi%'
group by Usuarios.Usuario order by Usuarios.Usuario asc

/*Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram */
select Usuarios.Usuario, count(Marcas.UsuInc) as 'Total' 
from Marcas inner join Usuarios on marcas.UsuInc = Usuarios.Id 
group by Usuarios.Usuario order by Usuarios.Usuario desc

--Trazer somente os carros que Felipe cadastrou
select Usuarios.Usuario, Carros.Modelo as 'Modelo' 
from Carros inner join Usuarios on Carros.UsuInc = Usuarios.Id 
where Usuarios.usuario like 'Fel%'
order by Usuarios.Usuario asc

--Trazer somente os carros que Giomar cadastrou
select Usuarios.Usuario, Carros.Modelo as 'Modelo' 
from Carros inner join Usuarios on Carros.UsuInc = Usuarios.Id 
where Usuarios.usuario like 'GI%'
order by Usuarios.Usuario asc

/*Trazer somente a quantidade de carros que Felipe cadastrou maior para menor*/
select Usuarios.Usuario, sum(Carros.Modelo) as 'Modelo' 
from Carros inner join Usuarios on Carros.UsuInc = Usuarios.Id 
where Usuarios.usuario like 'GI%'
order by Usuarios.Usuario asc


--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior


select count(*), MAX(MAR.id) AS MAXID from marcas MAR
group by MAR.UsuInc


UPDATE MARCAS SET ATIVO = 0 WHERE ID < 5