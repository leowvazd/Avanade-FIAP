create database conexao

use conexao

create table clientes(
	id int primary key identity(1,1),
	nome varchar(50) not null,
	email varchar(50) not null,
	endereco varchar(100) not null
)

/*stored procedure*/
create procedure inserirClientes
@nome varchar(50),
@email varchar(50),
@endereco varchar(50)
as
insert into clientes (nome, email, endereco)
values (@nome, @email, @endereco)

exec inserirClientes 'Alex Sander', 'alexs@email.co.br', 'rua X'
select * from clientes
----------------------------------------------------------------------------

create procedure alterarClientes
@id int,
@nome varchar(50),
@email varchar(50),
@endereco varchar(50)
as
update clientes set nome=@nome, email=@email, endereco=@endereco
where id=@id

exec alterarClientes 1, 'Alex Sander', 'alexs@email.co.br', 'rua B'
select * from clientes

----------------------------------------------------------------------------

create procedure excluirClientes
@id int
as
delete from clientes
where id=@id

exec excluirClientes 1
select * from clientes
----------------------------------------------------------------------------

create procedure clientePorCodigo
@id int
as
select id, nome, endereco, email from clientes
where id=@id

select * from clientes

