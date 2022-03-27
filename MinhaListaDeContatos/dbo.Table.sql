CREATE TABLE "Contato" (
	"IdContato"	INT NOT NULL UNIQUE,
	"Nome"	NVARCHAR(100) NOT NULL,
	"Telefone"	NVARCHAR(14),
	"Email"	NVARCHAR(100),
	"IdEndereco"	INT,
	PRIMARY KEY("IdContato"),
	FOREIGN KEY("IdEndereco") REFERENCES "Endereco"("IdEndereco")
);

GO

CREATE TABLE "Endereco" (
	"IdEndereco"	INTEGER NOT NULL UNIQUE,
	"CEP"	INTEGER,
	"Logradouro"	NVARCHAR(100),
	"Numero"	NVARCHAR(100),
	"Bairro"	NVARCHAR(100),
	"Cidade"	NVARCHAR(100),
	"Estado"	NVARCHAR(100),
	"Pais"	NVARCHAR(100) DEFAULT 'Brasil',
	PRIMARY KEY("IdEndereco")
);
go