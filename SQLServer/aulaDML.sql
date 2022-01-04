use aulaDML

create table veiculos (
placa varchar(7) primary key,
marca varchar(20) not null,
modelo varchar(20) not null,
cor varchar(20) not null,
opcionais varchar(100),
ano int not null,
valorCompra float not null,
)

-- #1
insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra) values
('DAB0001','Jeep', 'Compacto', 'Azul', 'airbag', 2000, 60000)
-- #2
insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra) values
('DAB0002','Ford', 'Sport', 'Rosa', ' ', 2010, 80000)

-- #3
insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra) values
('DAB0003','Fiat', 'Sedan', 'Branco', 'radio', 2011, 100000)

-- #4
insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra) values
('AAA0001','Ferrari', 'Sport', 'Vermelho', 'cambio automatico', 2020, 250000)

-- #5
insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra) values
('BAA1001','Audi', 'Sedan', 'Vinho', 'conversivel', 2018, 175000)

-- #6
insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra) values
('CDE1021','Ford', 'Compacto', 'Laranja', ' ', 2015, 125000)

-- #7
insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra) values
('EAD2425','Nissan', 'Sport', 'Rosa', 'tv', 2014, 175000)

-- #8
insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra) values
('HUE0707','Fiat', 'Sport', 'Azul', 'led', 2014, 175500)

-- #9
insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra) values
('ZUE1124','Jeep', 'Compacto', 'Verde', ' ', 2019, 180500)

-- #10
insert into veiculos
(placa, marca, modelo, cor, opcionais, ano, valorCompra) values
('LOL0505','Ferrari', 'Sport', 'Branco', 'rodas verdes', 2012, 25000)

alter table veiculos
add valorVenda floatupdate veiculos set valorVenda = 1.4 * valorCompra;delete from veiculos
where placa = 'LOL0505'alter table veiculosadd cidadeRegistro varchar(30)update veiculos set cidadeRegistro = 'SP'
where modelo = 'Sport'update veiculos set cidadeRegistro = 'RJ'
where modelo = 'Sedan'update veiculos set cidadeRegistro = 'MG'
where modelo = 'Compacto'update veiculos set valorVenda = valorVenda - ( valorVenda * 0.1 )
where ano <= 2005
update veiculos set valorVenda = valorVenda - ( valorVenda * 0.05 )
where ano >= 2013update veiculos set valorVenda = valorVenda + ( valorVenda * 0.03 )
where marca = 'Ford'update veiculos set valorVenda = valorVenda - ( valorVenda * 0.05 )
where modelo = 'Tracker'alter table veiculos
drop column opcionaisupdate veiculos set valorVenda = valorVenda + ( valorVenda * 0.03 )
where marca = 'Ecosport' and ano <= 2007 update veiculos set valorVenda = valorVenda + ( valorVenda * 0.03 )
where marca = 'Jeep' and ano <= 2007 update veiculos set valorVenda = valorVenda - ( valorVenda * 0.05 )
where marca = 'Jeep' and ano >= 2019 and valorVenda <= 120000delete from veiculos
where marca = 'Ford'select * from veiculos