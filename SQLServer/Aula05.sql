create database aula05

use aula05

create table personagens(
idPersonagem int primary key identity,
nomePersonagem varchar(20) not null)create table itens (
idPersonagem int primary key identity,
nomeItem varchar(20) not null )create table correlacao (
idPersonagem int,
idItem int)-- #1insert into personagens values ('Arthas')-- #2insert into personagens values ('Folker')-- #3insert into personagens values ('Lukas')-- #4insert into personagens values ('Synk')-- #5insert into personagens values ('Jayus')----------------------------------- #1insert into itens values ('Foice')-- #2insert into itens values ('Adaga')-- #3insert into itens values ('Espada')-- #4insert into itens values ('Arco')-- #5insert into itens values ('Escudo')--------------------------------- #1insert into correlacao values (1,1)-- #2insert into correlacao values (1,2)-- #3insert into correlacao values (2,3)-- #4insert into correlacao values (3,3)-- #5insert into correlacao values (5,4)select * from personagensselect * from itensselect * from correlacaoselect * from personagens inner join correlacao
on personagens.idPersonagem = correlacao.idItem

select * from personagens inner join correlacao
on personagens.idPersonagem = correlacao.idItem
where personagens.nomePersonagem = 'Arthas'


