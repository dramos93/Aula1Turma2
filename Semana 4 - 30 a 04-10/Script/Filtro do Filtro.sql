SELECT * from Clientes;
select * from Pedidos;

select cli.* from Clientes cli inner join Pedidos ped on cli.Id = ped.CLIENTEID 
where ped.NUMERO in ('s003','s004','s006')

Select * from pedidos ped where ped.CLIENTEID in (select cli.Id from Clientes cli inner join Pedidos ped on cli.id = ped.CLIENTEID where ped.NUMERO in ('s003','s004','s006'))
order by ped.VALOR desc