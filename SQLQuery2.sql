drop table "Contato"
CREATE TABLE "Contato" (
	"IdContato"	INT NOT NULL UNIQUE IDENTITY,
	"Nome"	NVARCHAR(100) NOT NULL,
	"Telefone"	NVARCHAR(20),
	"Email"	NVARCHAR(100),
	PRIMARY KEY("IdContato"),
);

GO
drop table "Endereco"
CREATE TABLE "Endereco" (
	"IdEndereco"	INTEGER NOT NULL UNIQUE IDENTITY,
	"IdContato" INTEGER NOT NULL,
	"CEP"	NVARCHAR(8),
	"Logradouro"	NVARCHAR(100),
	"Numero"	NVARCHAR(100),
	"Bairro"	NVARCHAR(100),
	"Cidade"	NVARCHAR(100),
	"Estado"	NVARCHAR(100),
	"Pais"	NVARCHAR(100) DEFAULT 'Brasil',
	PRIMARY KEY("IdEndereco"),
	FOREIGN kEY ("IdContato") REFERENCES "Contato"
);
go


INSERT INTO [Contato]([Nome],[Email],[Telefone]) VALUES ('aaa','sddsd','1194182548')
INSERT INTO [Endereco]([CEP],[Logradouro],[Numero],[Cidade],[Bairro],[Estado],[IdContato]) VALUES ('09300000', 'rua asdasdrfsad', '123','sfgs', 'dghyc', 'BL', @@IDENTITY)


select * from [Contato] 

SELECT *
FROM Contato
INNER JOIN Endereco
ON [Contato].[IdContato] = [Endereco].[IdContato]
go

DELETE FROM [Endereco] WHERE [Endereco].[IdContato] = 16;
DELETE FROM [Contato] WHERE [Contato].[IdContato] = 16;



SELECT *
FROM Contato
INNER JOIN Endereco
ON [Contato].[IdContato] = [Endereco].[IdContato]