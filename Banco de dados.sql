create database projeto;
use projeto;

create table cargo(
codigoCargo int primary key auto_increment,
cargo varchar(100)
);

create table usuario(
codigo int primary key auto_increment,
nome varchar(60),
email varchar(100),
senha varchar(255),
cargo int,
ativo tinyint,
constraint fk_cargo foreign key (cargo) references cargo(codigoCargo)
);
select * from usuario;

create table produto(
codigoProduto int primary key auto_increment,
nome varchar(50),
descricao varchar (200),
valor decimal(5,2),
quantidade int,
foto varchar(100)
);

create table cliente(
codigoCliente int primary key auto_increment,
nome varchar(100),
endereco  varchar(200),
cep int,
cpf int,
senha varchar(255),
email varchar(100),
telefone varchar(20)
);

create table pedido(
codigoPedido int primary key auto_increment,
formaPagamento varchar(100),
dataEntrega datetime,
codigoCliente int,
dataPedido datetime,
constraint fk_usuario foreign key (codigoCliente) references cliente(codigoCliente)
);

create table itensProduto(
codigoProduto int,
codigoPedido int,
quantidadeDoProduto int,
constraint fk_pedido foreign key (codigoPedido) references pedido(codigoPedido),
constraint fk_produto foreign key (codigoProduto) references produto(codigoProduto)
);

insert into cargo(cargo) value("moderador");
insert into cargo(cargo) value("assistente");
insert into cargo(cargo) value("dono");