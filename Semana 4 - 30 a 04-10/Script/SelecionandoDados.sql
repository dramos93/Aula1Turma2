select
car.Nome,
mar.Nome as 'Marca',
usu.Nome as 'UsuarioCriacao',
usua.Nome as 'UsuarioCriacao'
from Automovel car inner join  mar  on car.MarcaCodigo     = mar.codigo
                inner join Usuarios usu on car.UsuarioCriacao = usu.Id
				inner join Usuarios usua on car.UsuarioAlterecao = usua.Id