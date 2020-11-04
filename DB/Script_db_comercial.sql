create database db_comercial;

go

/*CRIAÇÃO DAS TABELAS*/

use db_comercial;
go

CREATE TABLE sistema (
id INT identity PRIMARY KEY,
nome VARCHAR(50) NOT NULL unique,
localizacao varchar(100) not null,
NIF varchar(50),
email varchar(50),
banco varchar(50),
num_banco varchar(50),
iban varchar(50),
tel1 varchar(15),
tel2 varchar(15)
);

go
	
insert into sistema values ('Sistema','XXXXXXXX',
'006952280LA047','sistema@gmail.com','BAI','004224423423','IBAN-4909424342342','934092233','992334358');
go

CREATE TABLE cargos (
id INT identity PRIMARY KEY,
nome VARCHAR(50) NOT NULL unique,
salario numeric(14,2) not null default 0
);
go

insert into cargos values ('desenvolvedor',4000)

go
	
CREATE TABLE funcionarios (
id INT identity PRIMARY KEY,
bi varchar(50) unique not null,
nome VARCHAR(100) NOT NULL,
sexo varchar(1) check (sexo='M' or sexo='F') not null,
data_n date,
residencia varchar(100),
formacao varchar(100) default null,
email varchar(50),
banco varchar(50),
num_banco varchar(50) unique, 
iban varchar(50) unique,
aumento numeric (14,2) default 0,
imagem image default null, 
nome_usuario varchar(50),
senha varchar(20),
acesso varchar(10) check(acesso='admin' or acesso='normal' or acesso='gerente' or acesso=null) default null,
estado varchar(20) check(estado='desablitado' or estado=null) default null,
id_cargo int,
foreign key(id_cargo) references cargos(id)
);
go
	
create index funcionario_nome on funcionarios(nome);

--	alter table funcionarios add id_cargo int;
--	alter table funcionarios add foreign key(id_cargo) references cargos(id);

go

CREATE TABLE contactos (
id int identity primary key,
id_funcionario int,
numero VARCHAR(15),
foreign key(id_funcionario) references funcionarios (id) on delete cascade
);

go

CREATE TABLE escala (
id INT identity unique,
id_funcionario int,
dia varchar(20) check(dia='segunda feira' or dia='terça feira' or dia='quarta feira' or dia='quinta feira' or dia='sexta feira' or dia='sabado' or dia='domingo') not null,
turno varchar(10) check(turno='manhã' or turno='tarde' or turno='noite') not null,
hora_entrada time not null,
hora_saida time not null,
foreign key(id_funcionario) references funcionarios (id) on delete cascade,
primary key(id_funcionario,dia,turno,hora_entrada)
);

go
  
CREATE TABLE categorias (
id INT identity PRIMARY KEY,
nome VARCHAR(50) NOT NULL unique
);
	
go

CREATE TABLE produtos (
id INT identity unique,
codigo varchar(50) default null,
id_categoria int,
nome VARCHAR(50) NOT NULL unique,
imagem image,
estado varchar(15) check (estado='activado' or estado='desativado') default 'activado' not null,
preco numeric(14,2) default 0,
foreign key(id_categoria) references categorias(id),
primary key(id,codigo)
);

create index produtos_nome on produtos(nome);

go

CREATE TABLE stock (
id INT identity PRIMARY KEY,
id_produto int,
stock int default 0,
foreign key(id_produto) references produtos (id) on delete cascade
);
     
go
	   
CREATE TABLE produtos_entrada (
id INT identity PRIMARY KEY,
id_produto int,
volume int,
data_fabricacao date,
data_validade date,
custus numeric(14,2) default 0,
data_entrada date,
foreign key(id_produto) references produtos (id) on delete cascade
);
	
go
    
CREATE TABLE vendas (
id INT identity PRIMARY KEY,
id_produto int,
quantidade int default 0,
preco numeric(14,2) default 0,
data_venda datetime not null,
id_funcionario int,
venda varchar(15) check (venda='cancelada' or venda='feita') not null default 'feita',
foreign key(id_funcionario) references funcionarios (id),
foreign key(id_produto) references produtos (id)
);
	
go 
	
create table venda_pagamento(
id int identity primary key,
cliente VARCHAR(50),
total numeric(14,2) default 0,
valor_pago numeric(14,2) not null,
tipo_pagamento varchar(15) check(tipo_pagamento='multicaixa' or tipo_pagamento='dinheiro') default 'dinheiro',
);
	
go
	
create table fatura_venda(
id int identity primary key,
id_venda int,
id_pagamento int,
id_sistema int
foreign key(id_venda) references vendas (id) on delete cascade,
foreign key(id_pagamento) references venda_pagamento (id) on delete cascade,
foreign key(id_sistema) references sistema (id)
);

go
create index vendas_cliente on venda_pagamento(cliente);

go

-- Criação de triggers
create trigger down_stock on vendas after insert as
begin
declare @id_venda1 int,@id_produto1 int,@quantidade1 int,@stock1 int;
	
set @id_venda1 = (select IDENT_CURRENT('vendas'));	
set @id_produto1 = (select id_produto from vendas where id=@id_venda1);
set @quantidade1 = (select quantidade from vendas where id=@id_venda1);
set @stock1 =(select stock from stock where id_produto=@id_produto1);
	
if(@stock1>=@quantidade1)
update stock set stock=stock-@quantidade1 where id_produto=@id_produto1;

end

go

create trigger set_entrada_stock on dbo.produtos_entrada after insert as
begin
declare @id_produto1 int, @stock1 int, @id1 int,@volume1 int;
set @id1=(select IDENT_CURRENT('produtos_entrada'));
set @volume1=(select volume from produtos_entrada where id=@id1);
set @id_produto1=(select id_produto from produtos_entrada where id=@id1);
set @stock1 =(select stock from stock where id_produto=@id_produto1);

if(@volume1>=1)
update stock set stock=(stock+@volume1) where id_produto=@id_produto1;
end


go


-- CRIAÇÃO DAS VIEWS

create view vw_produtos as
SELECT p.id, p.codigo, c.nome AS categoria, p.nome, p.preco, s.stock, p.estado, p.imagem
FROM  dbo.produtos AS p INNER JOIN  dbo.categorias AS c ON p.id_categoria = c.id INNER JOIN
            dbo.stock AS s ON s.id_produto = p.id
						 
go

create view vw_produtos_entrada as
select pe.id,p.id 'id_produto',p.nome,pe.volume,pe.data_fabricacao,pe.data_validade,pe.custus,pe.data_entrada from produtos_entrada pe 
inner join produtos p on pe.id_produto=p.id;

go

create view vw_vendas as
select vp.id,v.id 'id_venda',p.id 'id_produto', p.nome 'produto',v.quantidade,v.preco,
(v.quantidade*v.preco) 'total',v.data_venda 'data',v.venda,f.nome 'funcionario', f.id 'id_funcionario' from vendas v 
inner join produtos p on p.id=v.id_produto inner join funcionarios f on v.id_funcionario=f.id inner join fatura_venda fv on fv.id_venda=v.id inner join venda_pagamento vp on vp.id=fv.id_pagamento;

go

create view vw_fatura as
select p.id,p.cliente,pr.nome,v.quantidade,v.preco,(v.quantidade*v.preco) 'total_p',v.data_venda,v.id_funcionario 'operador',p.total 'TOTAL',p.valor_pago,p.tipo_pagamento, CURRENT_TIMESTAMP 'data_impressao',fr.nome 'sistema',fr.localizacao,fr.NIF,fr.tel1,fr.tel2
from fatura_venda f inner join vendas v on f.id_venda=v.id 
inner join venda_pagamento p on f.id_pagamento=p.id 
inner join produtos pr on v.id_produto=pr.id
inner join sistema fr on fr.id=f.id_sistema;

go

-- CRIAÇÃO DAS STORED PROCEDURES
create procedure sp_login (@user1 varchar(100), @senha1 varchar(40))as 
begin
select id,nome_usuario, senha, acesso from funcionarios where nome_usuario=@user1 and senha=@senha1 and estado is null or estado='';
end

go	

create procedure sp_sistema(@nome1 varchar(50),@localizacao1 varchar(50),@NIF1 varchar(50),@email1 varchar(50),
@banco1 varchar(50),@num_banco1 varchar(50),@Iban1 varchar(50),@tel1 varchar(15),@tel2 varchar(15)) as
begin
declare @id int;
select @id=MAX(id) from sistema;
update sistema set nome=@nome1, localizacao=@localizacao1,NIF=@NIF1,email=@email1,banco=@banco1,num_banco=@num_banco1,iban=@Iban1,tel1=@tel1,tel2=@tel2
where id=@id;
end

go

create procedure sp_categorias(@id1 int,@nome1 varchar(50)) as
begin 
if(@id1=0)
insert into categorias values(@nome1);
else
update categorias set nome = @nome1 where id=@id1;
end

go

create procedure sp_delete(@id1 int,@tabela varchar(30))
as 
begin
	if(@tabela='produtos')
	delete from produtos where id=@id1 and (select stock from stock where id_produto=@id1)=0;
	else if (@tabela='escala')
	delete from escala where id=@id1;
		else if (@tabela='cargos')
	delete from cargos where id=@id1;
		else if (@tabela='categorias')
	delete from categorias where id=@id1;
		else if (@tabela='funcionarios')
	delete from funcionarios where id=@id1;
end
go

create procedure sp_desativar_produto (@ops int, @id1 int) as
begin	

	if(@ops=0)
		update produtos set estado='desativado' where id=@id1;
	else
		update produtos set estado='activado' where id=@id1;
end

go

create procedure sp_produtos_entrada(@id1 int,@id_produto1 int,@volume1 int,@data_fabricacao1 varchar(20),
 @data_validade1 varchar(20),@custus1 decimal)
as 
begin
if(@id1=0 and @volume1>0)
insert into produtos_entrada values(@id_produto1,@volume1,@data_fabricacao1,@data_validade1,@custus1,GETDATE());

else if(@id1!=0)
	begin
	
	declare @oldVolume int, @stock1 int;
	
	set @oldVolume = (select volume from produtos_entrada where id=@id1);
	set @stock1 =(select stock from stock where id_produto=@id_produto1);
	
	if((@stock1-@oldVolume)>=0)
	begin
		update produtos_entrada set id_produto= @id_produto1, volume= @volume1, data_fabricacao= @data_fabricacao1 , data_validade=@data_validade1, custus = @custus1 where id= @id1;
		update stock set stock=stock-@oldVolume where id_produto=@id_produto1;
		if(@volume1>=@oldVolume)
		update stock set stock=(stock+@volume1) where id_produto=@id_produto1;
	end
	end
end

go 

create procedure sp_delete_entrada(@id1 int)
as 
begin
	declare @id_produto1 int,@volume1 int, @stock1 int, @dataEntrada date;
	set @dataEntrada = (select data_entrada from produtos_entrada where id=@id1);
	set @id_produto1= (select id_produto from produtos_entrada where id=@id1);
	set @volume1 =(select volume from produtos_entrada where id=@id1);
	set @stock1 =(select stock from stock where id_produto=@id_produto1);
	
	if(DATEDIFF(DAY,@dataEntrada,GETDATE())<15)
	begin
	if((@stock1-@volume1)>=0)
	begin
		update stock set stock=stock-@Volume1 where id_produto=@id_produto1;
	end
	end

	delete from produtos_entrada where id=@id1;

	end
	
go

-- ====================================PROCEDURE PARA ELIMINAR AS TABELAS==============================================================
-- create procedure sp_delete(@id1 int,@tabela varchar(30))
-- as 
-- begin
-- 	if(@tabela='produtos')
-- 	begin
-- 	delete from produtos where id=@id1 and (select stock from stock where id_produto=@id1)=0;
-- 	end
-- 	else if (@tabela='escala')
-- 	delete from escala where id=@id1;
-- 		else if (@tabela='cargos')
-- 	delete from cargos where id=@id1;
-- 		else if (@tabela='categorias')
-- 	delete from categorias where id=@id1;
-- 		else if (@tabela='funcionarios')
-- 	delete from funcionarios where id=@id1;
-- end

go
-- ====================================PROCEDURE PARA VENDER O PRODUTO==============================================================
create procedure sp_venda (@id_produto1 int,@quantidade1 int,@preco1 numeric(14,2),@id_funcionario1 int) as
begin
	declare @id_venda int,@maximo_venda int, @tot1 int;
	set @maximo_venda=(select MAX(id) from vendas) 
	set @tot1=(select COUNT(*) from vendas);
	
	insert into vendas values (@id_produto1,@quantidade1,@preco1,GETDATE(),@id_funcionario1,default);
	set @id_venda=(select MAX(id) from vendas);
	
	if((@id_venda>@maximo_venda or @tot1=0))
	insert into fatura_venda values (@id_venda,IDENT_CURRENT('venda_pagamento'),(select MAX(id) from sistema));
end


go

/*
create procedure sp_fatura(@id1 int) as
begin
select p.id,p.cliente,pr.nome,v.quantidade,v.preco,(v.quantidade*v.preco) 'total_p',v.data_venda,fn.nome 'operador',fr.nome 'sistema',p.total 'TOTAL',p.valor_pago,p.tipo_pagamento, CURRENT_TIMESTAMP 'data_impressao'
from fatura_venda f inner join vendas v on f.id_venda=v.id 
inner join venda_pagamento p on f.id_pagamento=p.id 
inner join produtos pr on v.id_produto=pr.id
inner join sistema fr on fr.id=f.id_sistema
inner join funcionarios fn on fn.id=v.id_funcionario where p.id=@id1;
end

*/
go

-- ====================================PROCEDURE PARA EFECTUAR O PAGAMENTO DA VENDA==============================================================
create procedure sp_pagamento (@cliente1 varchar(50),@total1 numeric(14,2),@valorpago1 numeric(14,2),@tipo_pagamento1 varchar(20)) as
begin
		delete from venda_pagamento where id not in (select id_pagamento from fatura_venda);
		insert into venda_pagamento values (@cliente1,@total1,@valorpago1,@tipo_pagamento1);
end

go 

CREATE procedure [dbo].[sp_produtos] (@id1 int,@codigo1 varchar(50), @id_categoria1 int, @nome1 varchar(50), @imagem1 image,
@preco1 numeric(14,2)) as
begin 
declare @id_produto int, @maximo int, @tot int;
if(@id1=0)
 begin
	set @maximo = (select MAX(id) from produtos);
	set @tot =(select COUNT(*) from produtos);
	insert into produtos values (@codigo1,@id_categoria1, @nome1,@imagem1,'activado',@preco1);
	set @id_produto=(select MAX(id) from produtos);
	if(@id_produto>@maximo or @tot=0)
	begin
		insert into stock values (@id_produto,default);
	end
 end
else
 begin
 	update produtos set  codigo=@codigo1 ,id_categoria= @id_categoria1, nome=@nome1,
	imagem= @imagem1, preco=@preco1 where id=@id1;
 end 
end

go 

create procedure [dbo].[select_cargos](@campo varchar(50),@busca varchar(50)) as
begin
if(@campo='id')
select * from cargos where  id like @busca+'%';
 else if(@campo='cargo')
 select * from cargos where nome like @busca+'%' or nome like '%'+@busca;
 else if(@campo='tot')
 select COUNT(*) from cargos;
end

go

-- ====================================PROCEDURE PARA SELECIONAR AS VENDAS==============================================================

create procedure select_vendas_today(@id_funcionario1 int,@campo varchar(50),@busca varchar(50)) as
begin
if(@campo='id')
select * from vw_vendas where  id like @busca+'%' and (id_funcionario=@id_funcionario1 and MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE())) order by data desc;
 else if(@campo='produto')
 select * from vw_vendas where produto like @busca+'%' or produto like '%'+@busca and (id_funcionario=@id_funcionario1 and (DAY(data)=DAY(GETDATE()) and MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE()))) order by data desc;
 else if (@campo='venda')
 select * from vw_vendas where venda like @busca+'%' and (id_funcionario=@id_funcionario1 and (DAY(data)=DAY(GETDATE()) and MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE()))) order by data desc;
 else if (@campo='dia')
 select * from vw_vendas where  (DAY(data)) like  @busca+'%' and (id_funcionario=@id_funcionario1 and MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE())) order by data desc;
else if (@campo='mês')
 select * from vw_vendas where  (MONTH(data)) like  @busca+'%' or DATENAME(MONTH,data) like  @busca+'%' and (id_funcionario=@id_funcionario1 and YEAR(data)=YEAR(GETDATE())) order by data desc;  
 else if (@campo='data')
 select * from vw_vendas where  CONVERT(varchar,data,3) like '%'+ @busca+'%' or CONVERT(varchar,data,3) like '%'+ @busca or CONVERT(varchar,data,3) like @busca+'%' and (id_funcionario=@id_funcionario1) order by data desc;  
 else if(@campo='tot')
 select COUNT(*) from vw_vendas where  (id_funcionario=@id_funcionario1 and (DAY(data)=DAY(GETDATE()) and MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE())));
end
go

create procedure select_Allvendas(@campo varchar(50),@busca varchar(50)) as
begin
if(@campo='id')
select * from vw_vendas where  id like @busca+'%' and (MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE())) order by data desc;
 else if(@campo='produto')
 select * from vw_vendas where produto like @busca+'%' or produto like '%'+@busca and (MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE())) order by data desc;
 else if (@campo='venda')
 select * from vw_vendas where venda like @busca+'%' and (MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE())) order by data desc;
 else if (@campo='dia')
 select * from vw_vendas where  (DAY(data)) like  @busca+'%' and (MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE())) order by data desc;
else if (@campo='mês')
 select * from vw_vendas where  (MONTH(data)) like  @busca+'%' or DATENAME(MONTH,data) like  @busca+'%' order by data desc;  
 else if (@campo='data')
 select * from vw_vendas where  CONVERT(varchar,data,3) like '%'+ @busca+'%' or CONVERT(varchar,data,3) like '%'+ @busca or CONVERT(varchar,data,3) like @busca+'%' order by data desc;  
 else if(@campo='funcionários')
 select * from vw_vendas where funcionario like @busca+'%' or funcionario like '%'+@busca and (MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE())) order by data desc;
 else if(@campo='tot')
 select COUNT(*) from vw_vendas where (MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE()));
end

go

-- ====================================PROCEDURE PARA CANCELAR VENDA==============================================================

create procedure sp_cancelar_venda(@ops int,@id_pagamento1 int) as
begin
if (@ops=1)
update vw_vendas set venda='cancelada' where id=@id_pagamento1;
else if (@ops=0)
update vw_vendas set venda='feita' where id=@id_pagamento1;
end

go


go
-- ====================================PROCEDURE PARA ELIMINAR VENDA==============================================================

create procedure sp_delete_vendas (@id_pagamento int) as
begin
declare @cont int,@tot int, @id_venda1 int,@id_produto1 int,@quantidade1 int,@venda1 varchar(15), @stock1 int;
declare cr cursor for select id_venda,id_produto,quantidade,venda from vw_vendas where id=@id_pagamento;
 
	set @tot=(select COUNT(*) from vw_vendas where id=@id_pagamento);
	set @cont=0;

	open cr;
		while @cont < @tot
		begin
		set @cont=@cont+1;
		fetch next from cr into @id_venda1,@id_produto1,@quantidade1,@venda1;
		
		if @venda1='cancelada'
		begin
		 set @stock1=(select stock from stock where id_produto=@id_produto1);
			if (@stock1>@quantidade1)
			update stock set stock.stock=(stock.stock+@quantidade1) where id_produto=@id_produto1;
		 end
			delete from vendas where id=@id_venda1;
		end
	close cr;
	deallocate cr;
	delete from venda_pagamento where id=@id_pagamento;
end 

go 
-- ====================================PROCEDURE PARA CADASTRAR FUNCIONARIOS==============================================================
create procedure sp_funcionarios (@id1 int,@bi1 varchar(50),@nome1 varchar(100), @sexo1 varchar(1), @data1 date,@residencia1 varchar(100),@formacao1 varchar(100),@email1 varchar(50),@banco1 varchar(50),@num_banco1 varchar(50),
@iban1 varchar(50),@aumento1 numeric(14,2),@imagem1 image,@acesso1 varchar(10),@id_cargo1 int) as
begin 
	if(@id1=0)
	insert into funcionarios values (@bi1,@nome1, @sexo1, @data1,@residencia1,@formacao1,@email1,@banco1,@num_banco1,
@iban1,@aumento1,@imagem1,@nome1,'',@acesso1,NULL,@id_cargo1);
	else
	begin
		if(@acesso1='not' or @acesso1='')
		update funcionarios set bi=@bi1,nome=@nome1, sexo=@sexo1, data_n=@data1, residencia=@residencia1, formacao=@formacao1,email=@email1, banco=@banco1,
		num_banco=@num_banco1,iban=@iban1,aumento=@aumento1, imagem=@imagem1,nome_usuario=NULL,senha='', acesso=NULL, id_cargo=@id_cargo1 where id=@id1;
		else
		begin
		declare @user varchar(40);
		if ((select nome_usuario from funcionarios where id=@id1) is null)
		set @user=@nome1;
		else
		select @user=nome_usuario from funcionarios where id=@id1;
		
		
		update funcionarios set bi=@bi1,nome=@nome1,sexo=@sexo1, data_n=@data1, residencia=@residencia1, formacao=@formacao1,email=@email1, banco=@banco1,
		num_banco=@num_banco1,iban=@iban1,aumento=@aumento1,imagem=@imagem1,acesso=@acesso1,nome_usuario=@user,id_cargo=@id_cargo1 where id=@id1;
		end
	end
end

go 

create procedure sp_User (@id1 int,@nome_usuario1 varchar(50),@senha1 varchar(20)) as
begin 
		update funcionarios set nome_usuario=@nome_usuario1,senha=@senha1 where id=@id1;
end

go

create procedure sp_cargos (@id1 int,@nome1 varchar(50),@salario1 numeric(14,2)) as
begin 
	if(@id1=0)
	insert into cargos values (@nome1,@salario1);
	else
		update cargos set nome=@nome1, salario=@salario1 where id=@id1;
end

go

create procedure sp_contacto (@id1 int,@tel1 varchar(15),@tel2 varchar(15)) as
begin
		
	if @id1=0
	begin 
	declare @id_funcionario1 int;
	select @id_funcionario1=IDENT_CURRENT('funcionarios');
	insert into contactos values (@id_funcionario1,@tel1),(@id_funcionario1,@tel2); 
	end	
	else
	begin
	
	declare @id_new1 int, @id_new2 int;
	select @id_new1=Min(id) from contactos where id_funcionario=@id1;
	select @id_new2=MAX(id) from contactos where id_funcionario=@id1;
	
	update contactos set numero=@tel1 where id=@id_new1;
	update contactos set numero=@tel2 where id=@id_new2;
	end
end

go

create procedure select_funcionarios(@campo varchar(50),@busca varchar(50)) as
begin

if(@campo='id')
select  f.*, c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo where  f.id like @busca+'%' order by f.nome;

else if(@campo='bi')
select  f.*, c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo where  f.bi like @busca+'%' order by f.nome;

else if(@campo='sexo')
select  f.*, c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo where  f.sexo like @busca+'%' order by f.nome;

 else if(@campo='nome')
 select  f.*,c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo where f.nome like @busca+'%' or f.nome like '%'+@busca or f.nome like '%'+@busca+'%' order by f.nome;
 
 else if(@campo='residencia')
 select  f.*, c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo where f.residencia like @busca+'%' or f.residencia like '%'+@busca order by f.nome;

 else if(@campo='formacao')
 select  f.*, c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo where f.formacao like @busca+'%' or f.formacao like '%'+@busca order by f.nome;

  else if(@campo='email')
 select  f.*, c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo where f.email like @busca+'%' order by f.nome;

  else if(@campo='banco')
 select  f.*, c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo where f.banco like @busca+'%' order by f.nome;

  else if(@campo='numero do banco')
 select  f.*, c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo where f.num_banco like @busca+'%' order by f.nome;

  else if(@campo='iban')
 select  f.*, c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo where f.iban like @busca+'%' order by f.nome;

  else if(@campo='aumento')
 select  f.*, c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo where f.aumento like @busca+'%' order by f.nome;

  else if(@campo='acesso')
 select  f.*, c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo where f.acesso like @busca+'%' order by f.nome;

  else if(@campo='estado')
 select  f.*, c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo where f.estado like @busca+'%' order by f.nome;

  else if(@campo='cargo')
 select  f.*, c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo where c.nome like @busca+'%' or c.nome like '%'+@busca order by f.nome;
 else if(@campo='salario')
 select  f.*, c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo where c.salario like @busca+'%' order by f.nome;
else if(@campo='data de nascimento')
 select  f.*, c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo where CONVERT(varchar,f.data_n,3) like '%'+ @busca+'%' or CONVERT(varchar,f.data_n,3) like '%'+ @busca or CONVERT(varchar,f.data_n,3) like @busca+'%' order by f.nome;
 
 else if(@campo='tot')
 select COUNT(*) from funcionarios;
end


go

create procedure select_contacto (@id_funcionario1 int) as
select numero from contactos where id_funcionario=@id_funcionario1;

go

create procedure sp_desablitar_funcionario (@ops int, @id1 int) as
begin	

	if(@ops=0)
		update funcionarios set estado='desablitado' where id=@id1;
	else
		update funcionarios set estado=null where id=@id1;
end

go

create procedure sp_escalas (@id1 int,@dia1 varchar(20),@turno1 varchar(20),@hora_entrada1 time,@hora_saida1 time) as
begin 
	insert into escala values (@id1,@dia1,@turno1,@hora_entrada1,@hora_saida1);
end

go 

create procedure sp_delete_escala(@id_funcionario1 int) as
delete from escala where id_funcionario=@id_funcionario1;

go

create procedure select_escalas(@campo varchar(50),@busca varchar(50)) as
begin

if(@campo='id')
select e.dia,e.turno,e.hora_entrada,e.hora_saida,f.nome from escala e inner join funcionarios f on f.id=e.id_funcionario
where f.id like @busca+'%' order by e.dia,e.turno;

if(@campo='funcionário')
select e.dia,e.turno,e.hora_entrada,e.hora_saida,f.nome from escala e inner join funcionarios f on f.id=e.id_funcionario
where f.nome like @busca+'%' or f.nome like '%'+@busca or f.nome like '%'+@busca+'%' order by e.dia,e.turno;

else if(@campo='dia')
select e.dia,e.turno,e.hora_entrada,e.hora_saida,f.nome from escala e inner join funcionarios f on f.id=e.id_funcionario
where e.dia like @busca+'%' order by e.dia,e.turno;

else if(@campo='turno')
select e.dia,e.turno,e.hora_entrada,e.hora_saida,f.nome from escala e inner join funcionarios f on f.id=e.id_funcionario
where e.turno like @busca+'%' order by e.dia,e.turno;

 else if(@campo='tot')
 select COUNT(*) from escala;
end

go

ALTER procedure [dbo].[select_vendas_today](@id_funcionario1 int,@campo varchar(50),@busca varchar(50)) as
begin
if(@campo='id')
select * from vw_vendas where  id like @busca+'%' and (MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE())) order by data desc;
 else if(@campo='produto')
 select * from vw_vendas where produto like @busca+'%' or produto like '%'+@busca and (id_funcionario=@id_funcionario1 and (DAY(data)=DAY(GETDATE()) and MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE()))) order by data desc;
 else if (@campo='venda')
 select * from vw_vendas where venda like @busca+'%' and (id_funcionario=@id_funcionario1 and (DAY(data)=DAY(GETDATE()) and MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE()))) order by data desc;
 else if (@campo='dia')
 select * from vw_vendas where id_funcionario=@id_funcionario1  and (DAY(data)) like  @busca+'%' and (MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE())) order by data desc;
else if (@campo='mês')
 select * from vw_vendas where id_funcionario=@id_funcionario1 and MONTH(data) like '%'+@busca+'%' or DATENAME(MONTH,data) like '%'+@busca+'%' and YEAR(data)=YEAR(GETDATE()) order by data desc;  
 else if (@campo='data')
 select * from vw_vendas where  id_funcionario=@id_funcionario1 and (CONVERT(varchar,data,3) like '%'+ @busca+'%') order by data desc;   
 else if(@campo='tot')
 select COUNT(*) from vw_vendas where  (id_funcionario=@id_funcionario1 and (DAY(data)=DAY(GETDATE()) and MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE())));
end

go 


ALTER procedure [dbo].[sp_delete_vendas] (@id_pagamento int) as
begin
declare @cont int,@tot int, @id_venda1 int,@id_produto1 int,@quantidade1 int,@venda1 varchar(15), @stock1 int;
declare cr cursor for select id_venda,id_produto,quantidade,venda from vw_vendas where id=@id_pagamento;
 
	set @tot=(select COUNT(*) from vw_vendas where id=@id_pagamento);
	set @cont=0;

	open cr;
		while @cont < @tot
		begin
		set @cont=@cont+1;
		fetch next from cr into @id_venda1,@id_produto1,@quantidade1,@venda1;
		
		if @venda1='cancelada'
		begin
		 set @stock1=(select stock from stock where id_produto=@id_produto1);
			update stock set stock.stock=(stock.stock+@quantidade1) where id_produto=@id_produto1;
		 end
			delete from vendas where id=@id_venda1;
		end
	close cr;
	deallocate cr;
	delete from venda_pagamento where id=@id_pagamento;
end

go

