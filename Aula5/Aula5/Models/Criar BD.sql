use[AVA]

DROP TABLE aluno;

--	CRIAR TABELA
CREATE TABLE aluno(
	id		int primary key not null identity(1,1),
	nome	varchar(100),
	ra		varchar(15),
	cpf		varchar(15),
	idade	int
);

SELECT * FROM aluno;

-- USUARIO

CREATE TABLE usuario(
	id		int not null primary key identity(1,1),
	nome	varchar(100),
	senha	varchar(20)
);

insert into usuario(nome, senha) values ('daniel', '123');

select * from usuario;
