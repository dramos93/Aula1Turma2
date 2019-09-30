insert into Usuarios
(Nome, Login, Senha)
values
('Adagoberto', 'Urineidson','66tapanasoreia')
GO
Select * from Usuarios
update Usuarios set Ativo = 0 where Id in (11,9,8,7)