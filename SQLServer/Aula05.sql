create database aula05

use aula05

create table personagens(
idPersonagem int primary key identity,
nomePersonagem varchar(20) not null)
idPersonagem int primary key identity,
nomeItem varchar(20) not null )
idPersonagem int,
idItem int)
on personagens.idPersonagem = correlacao.idItem

select * from personagens inner join correlacao
on personagens.idPersonagem = correlacao.idItem
where personagens.nomePersonagem = 'Arthas'

