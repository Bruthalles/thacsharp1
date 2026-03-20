
--exemplo de criação
create table Enderecos(
	Id int primary key identity(1,1) not null,
	IdCliente int null,
	Rua varchar(255) null,
	Bairro varchar(255) null,
	Cidade varchar(255) null,
	Estado char(2) null,
	
	constraint FK_Enderecos_Clientes foreign key(IdCliente)
	references Clientes(Id)
)

--busca tudo que começa com th
select * from Clientes
where Nome like 'th%'
order by Nome, Sobrenome


--tipos de insert:
--escolhendo a ordem das colunas
insert into Clientes (Nome,Sobrenome,Email,AceitaComunicados,DataCadastro ) 
values ('thalles','brumatti','gmailkr@bruthalles',2,GETDATE())

--ou na ordem padrão
insert into Clientes values('roberto','carlos','email@email',2,GETDATE())

--exemplo de update
update Clientes 
set Sobrenome = 'Choté Brumatti',
    Nome = 'Thalles Roberto'
where Nome = 'thalles' 

--algumas operações internas
select count(*) quantidadeProdutos from Produtos 

select sum(Preco) PrecoTotal from Produtos

select max(Preco) ProdutoMaisCaro from Produtos

select min(Preco) ProdutoMaisBarato from Produtos

select
	Nome + ', Cor: ' + Cor NomeProdutoCompleto,
	upper(Nome),
	lower(cor),
	format(DataCadastro, 'dd/MM/yyyy HH:mm')
from Produtos

select * from Produtos

--exemplo de alteração
alter table Produtos 
add DataCadastro DATETIME2

alter table Produtos 
drop column DataCadastro 

--atualizando valor da tabela data cadastro

update Produtos 
set DataCadastro = GETDATE()

--exemplo de delete
delete Clientes 
where Nome = 'thalles'

SELECT 
	Tamanho,
	count(*) Quantidade
from Produtos 
where Tamanho != ''
group by Tamanho 
order by Quantidade desc

select * from Enderecos

insert into Enderecos values (4,'Rua teste','Bairro b','campo grande','RJ')
insert into Enderecos values (2,'rua da coroba','mato grosso','besteirol','BR')
insert into Enderecos values (5,'rua da batata','mato alto','hoje','SP')

select * from Clientes c
inner join Enderecos e on c.Id = e.IdCliente
where c.Id = 4





