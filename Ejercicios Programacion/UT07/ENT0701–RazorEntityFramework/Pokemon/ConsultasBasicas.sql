select * from Generaciones;
select * from Eventos;
select * from Tipos;

select * from Movimientos;

create database [pokemon_sergio];
drop database pokemon_sergio;


select * from Pokemon;

SELECT pokemon.Nombre, generacion.Nombre AS Generacion, tipo1.Nombre AS Tipo1, tipo2.Nombre AS Tipo2, pokemon.Imagen
FROM Pokemon AS pokemon
JOIN Generaciones AS generacion ON pokemon.GeneracionId = generacion.Id
JOIN Tipos AS tipo1 ON pokemon.Tipo1Id = tipo1.Id
LEFT JOIN Tipos AS tipo2 ON pokemon.Tipo2Id = tipo2.Id
WHERE generacion.Nombre = "cuarta generación" AND tipo2.Nombre = Hielo OR tipo1.Nombre = Hielo
