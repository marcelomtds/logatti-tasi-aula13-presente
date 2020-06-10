CREATE TABLE tipo (
	id INT IDENTITY (1, 1) NOT NULL,
	descricao VARCHAR (100) NOT NULL,
	CONSTRAINT pk_tipo PRIMARY KEY (id)
);

CREATE TABLE marca (
	id INT IDENTITY (1, 1) NOT NULL,
	descricao VARCHAR (100) NOT NULL,
	CONSTRAINT pk_marca PRIMARY KEY (id)
);

CREATE TABLE finalidade (
	id INT IDENTITY (1, 1) NOT NULL,
	descricao VARCHAR (100) NOT NULL,
	origem VARCHAR (100) NOT NULL,
	CONSTRAINT pk_finalidade PRIMARY KEY (id)
);

CREATE TABLE fornecedor (
	id INT IDENTITY (1, 1) NOT NULL,
	nome VARCHAR (100) NOT NULL,
	telefone VARCHAR (15) NOT NULL,
	cidade VARCHAR (50) NOT NULL,
	estado VARCHAR (50) NOT NULL,
	logradouro VARCHAR (100) NOT NULL,
	numero VARCHAR (10) NOT NULL,
	cnpj VARCHAR (15) NOT NULL,
	email VARCHAR (50) NOT NULL,
	conta_corrente VARCHAR (10) NOT NULL,
	agencia VARCHAR (10) NOT NULL,
	banco VARCHAR (50) NOT NULL,
	CONSTRAINT pk_fornecedor PRIMARY KEY (id)
);

CREATE TABLE presente (
	id INT IDENTITY (1, 1) NOT NULL,
	descricao VARCHAR (100) NOT NULL,
	id_tipo INT NOT NULL,
	id_marca INT NOT NULL,
	id_finalidade INT NOT NULL,
	cor VARCHAR (30) NOT NULL,
	tamanho DECIMAL (8, 2) NOT NULL,
	preco DECIMAL (8, 2) NOT NULL,
	id_fornecedor INT NOT NULL,
	CONSTRAINT pk_presente PRIMARY KEY (id)
);