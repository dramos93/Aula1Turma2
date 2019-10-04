select gen.Nome as 'Gênero',ar.Nome as 'Artista',can.Nome as 'Música'from Cancoes can
inner join Artistas ar on ar.Id = Can.Artista
inner join Genero gen on gen.Id = ar.Genero

select gen.Nome as 'Gênero', art.Nome as 'Artista', can.Nome as 'Música' from Genero gen
inner join Artistas art on art.Genero = gen.Id
inner join Cancoes can on can.Artista = art.Id

select gen.Nome as 'Gênero',
		count(art.Nome) as 'Quantidade Artistas'
		from Genero gen 
		inner join Artistas art on gen.Id = art.Genero
		group by gen.Nome

select gen.Nome as 'Gênero',
		count(can.Nome) as 'Quantidade Canções'
		from Genero gen 
		inner join Artistas art on gen.Id = art.Genero
		inner join Cancoes can on can.Artista = art.Id
		group by gen.Nome