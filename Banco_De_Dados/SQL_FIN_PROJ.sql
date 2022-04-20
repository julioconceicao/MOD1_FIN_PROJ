--Comentários:
--Acrescentar o restantes dos valores da tabela Jogador @João

CREATE DATABASE db_projeto_final_mod1
USE db_projeto_final_mod1

CREATE TABLE Jogador(
	Id INT PRIMARY KEY NOT NULL,
	nome VARCHAR(50) NOT NULL,
	posicao VARCHAR(50) NOT NULL,
	numero INT NOT NULL,
	habilidade1 VARCHAR(50) NULL,
	habilidade2 VARCHAR(50) NULL,
	habilidade3 VARCHAR(50) NULL,
	altura real NOT NULL,
	peso int NOT NULL,
	cidade VARCHAR(50) NOT NULL,
)
INSERT INTO Jogador
VALUES
(1,'Tim Maia','Goleiro',1,'Forte','Bom passe','',2.05,95,'Rio de Janeiro'),
(2,'Carl Johnson','Goleiro',2,'Rápido','Forte','Cabeceio',1.90,92,'Los Santos'),
(3,'Nathan Drake','Goleiro',3,'Rápido','Cobrança','',1.87,85,'Los Santos'),
(4,'João victor','Zagueiro',4,'Rápido','Bom domínio','',1.66,64,'Sorocaba'),
(5,'Livinho','Zagueiro',5,'Bom domínio','Bom passe','Forte',1.60,76,'São Paulo'),
(6,'Casimiro Miguel','Zagueiro',6,'Cobrança','Bom chute','Forte',1.88,87,'São Paulo'),
(7,'Poze do Rodo','Zagueiro',7,'Forte','Rapido','Bom passe',1.82,80,'Rio de Janeiro'),
(8,'Anitta','Laterais',8,'Bom passe','Bom dominio','',1.63,72,'Rio de Janeiro'),
(9,'Zeca Pagodinha','Laterais',9,'Forte','Bom passe','Cabeceio',2.03,93,'Irajá'),
(10,'Gaules','Laterais',10,'Cabeceio','','Rapido',1.83,74,'São Paulo')


SELECT * FROM Jogador