create database aula05

use aula05

create table personagens(
id int primary key identity (1,1),
nomePersonagem varchar(20) not null )

create table itens (
id int primary key identity (1,1),
nomeItem varchar(20) not null )

-- #1
insert into personagens values 
('Arthas')

-- #2
insert into personagens values 
('Folker')

-- #3
insert into personagens values 
('Lukas')

-- #4
insert into personagens values 
('Synk')

-- #5
insert into personagens values 
('Jayus')

---------------------------------

-- #1
insert into itens values 
('Foice')

-- #2
insert into itens values 
('Adaga')

-- #3
insert into itens values 
('Espada')

-- #4
insert into itens values 
('Arco')

-- #5
insert into itens values 
('Escudo')

-------------------------------


select * from personagens
select * from itens


create table personagem_item (
id int primary key identity,
idPersonagem int,
idItem int,

constraint fk_personagemItem_Personagens foreign key (idPersonagem)
references personagens(id),

constraint fk_personagemItem_Itens foreign key (idItem)
references itens(id) )

-- #1
insert into personagem_item(idPersonagem, idItem)
values (1,1)

-- #2
insert into personagem_item(idPersonagem, idItem)
values (2,2)

-- #3
insert into personagem_item(idPersonagem, idItem)
values (4,3)

-- #4
insert into personagem_item(idPersonagem, idItem)
values (2,1)

-- #5
insert into personagem_item(idPersonagem, idItem)
values (2,1)

-- #6
insert into personagem_item(idPersonagem, idItem)
values (2,5)

select * from personagem_item

----------------------------------------------------------
-- #1
select personagens.nomePersonagem, itens.nomeItem  
from personagem_item inner join personagens on 
personagem_item.idPersonagem = personagens.id
inner join itens on personagem_item.idItem = itens.id
group by personagens.nomePersonagem, itens.nomeItem

-- #2
select personagens.nomePersonagem, itens.nomeItem  
from personagem_item inner join personagens on 
personagem_item.idPersonagem = personagens.id
inner join itens on personagem_item.idItem = itens.id
group by personagens.nomePersonagem, itens.nomeItem

--#3
select personagens.nomePersonagem, itens.nomeItem  
from personagem_item inner join personagens on 
personagem_item.idPersonagem = personagens.id
inner join itens on personagem_item.idItem = itens.id
group by personagens.nomePersonagem, itens.nomeItem
