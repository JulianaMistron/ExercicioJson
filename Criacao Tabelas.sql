use ExercicioJson

create table Empresa
(
id int identity(1,1) primary key,
cnpj varchar(18) not null,
razao_social varchar(100) not null,
);

create table Motorista
(
id int identity(1,1) primary key,
cpf varchar (14) not null,
nome_motorista varchar(100) not null,
vigencia_cadastro datetime not null,
cnpj_empresa varchar(18) not null
);
