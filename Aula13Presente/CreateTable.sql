﻿CREATE TABLE presente (
	id INT IDENTITY (1, 1) NOT NULL,
	descricao VARCHAR (100) NOT NULL,
	tipo VARCHAR (100) NOT NULL,
	marca VARCHAR (100) NOT NULL,
	finalidade VARCHAR (100) NOT NULL,
	cor VARCHAR (30) NOT NULL,
	tamanho VARCHAR (30) NOT NULL,
	preco DECIMAL (8, 2) NOT NULL,
	nome_fornecedor VARCHAR (100) NOT NULL,
	CONSTRAINT pk_presente PRIMARY KEY (id)
);