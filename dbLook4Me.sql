DROP DATABASE if EXISTS dbLook4Me;
CREATE DATABASE if NOT exists dbLook4Me;
USE dbLook4Me;


create table if not exists tbSobrenome(
IDsobrenome int auto_increment primary key,
Nome varchar(100), 
Pais1 varchar(50), 
Pais2 varchar(50), 
Pais3 varchar(50), 
Arvore varchar(100)
);

create table if not exists tbPais(
IDpais int auto_increment primary key,
Nome varchar(100), 
Continente varchar(50)
);

 Delimiter $$
 create procedure InsertSobrenome (pNome
 varchar(100), pPais1 varchar(50), pPais2 varchar(50), pPais3 varchar(50), pArvore varchar(100))
 begin
 insert into tbSobrenome (Nome, Pais1, Pais2, Pais3, Arvore)
 values (pNome, pPais1, pPais2, pPais3, pArvore);
 end;$$
 

 call InsertSobrenome('Jard', 'França', 'Estados Unidos', 'Alemanha', '357 Pessoas com o sobrenome Jard na Árvore Familiar compartilhada.');
 call InsertSobrenome('Sousa', 'Brasil', 'Portugal', 'Estados Unidos', '458,473 Pessoas com o sobrenome Sousa na Árvore Familiar compartilhada.');
 call InsertSobrenome('Soares', 'Brasil', 'Portugal', 'Estados Unidos', '146,826 Pessoas com o sobrenome Soares na Árvore Familiar compartilhada.');
 call InsertSobrenome('Da Silva', 'Brasil', 'Portugal', 'Uruguai', '386,899 Pessoas com o sobrenome da Silva na Árvore Familiar compartilhada.');
 call InsertSobrenome('Souza', 'Brasil', 'Portugal', 'Estados Unidos', '458,473 Pessoas com o sobrenome Souza na Árvore Familiar compartilhada.');
 call InsertSobrenome('Ribeiro', 'Brasil', 'Portugal', 'Uruguai', '204,533 Pessoas com o sobrenome Ribeiro na Árvore Familiar compartilhada.');
 call InsertSobrenome('Miranda', 'México', 'Brasil', 'Chile', '354,077 Pessoas com o sobrenome Miranda na Árvore Familiar compartilhada.');
 call InsertSobrenome('Pereira', 'Brasil', 'Portugal', 'Argentina', '548,930 Pessoas com o sobrenome Pereira na Árvore Familiar compartilhada.');
 call InsertSobrenome('Pessoa', 'Brasil', 'Portugal', 'Argentina', '15,010 Pessoas com o sobrenome Pessoa na Árvore Familiar compartilhada.');
 call InsertSobrenome('Ferreira', 'Brasil', 'Portugal', 'Argentina', '470,233 Pessoas com o sobrenome Ferreira na Árvore Familiar compartilhada.');
 call InsertSobrenome('Freire', 'Brasil', 'Portugal', 'Espanha', '36,863 Pessoas com o sobrenome Freire na Árvore Familiar compartilhada.');
 call InsertSobrenome('Lima', 'Brasil', 'Portugal', 'México', '313,669 Pessoas com o sobrenome Lima na Árvore Familiar compartilhada.');
 call InsertSobrenome('Boaventura', 'Brasil', 'Portugal', 'Cabo Verde', '2,062 Pessoas com o sobrenome Boaventura na Árvore Familiar compartilhada.');
 call InsertSobrenome('Galvao', 'Brasil', 'Portugal', 'Cabo Verde', '4,570 Pessoas com o sobrenome Galvao na Árvore Familiar compartilhada.');
 call InsertSobrenome('Barreto', 'Brasil', 'México', 'Porto Rico', '65,623 Pessoas com o sobrenome Barreto na Árvore Familiar compartilhada.');
 call InsertSobrenome('Basilio', 'México', 'Brasil', 'Filipinas', '6,775 Pessoas com o sobrenome Basilio na Árvore Familiar compartilhada.');
 call InsertSobrenome('Jesus', 'Brasil', 'México', 'Portugal', '849,030 Pessoas com o sobrenome Jesus na Árvore Familiar compartilhada.');
 call InsertSobrenome('Gomes', 'Brasil', 'México', 'Portugal', '713,714 Pessoas com o sobrenome Gomes na Árvore Familiar compartilhada.');
 call InsertSobrenome('Almeida', 'Brasil', 'Portugal', 'México', '219,371 Pessoas com o sobrenome Almeida na Árvore Familiar compartilhada.');
 call InsertSobrenome('Bastos', 'Brasil', 'Portugal', 'Costa Rica', '28,586 Pessoas com o sobrenome Pessoa na Árvore Familiar compartilhada.');
 call InsertSobrenome('Sanches', 'México', 'Peru', 'Espanha', '738,133 Pessoas com o sobrenome Sanches na Árvore Familiar compartilhada.');
 call InsertSobrenome('Resina', 'Espanha', 'Argentina', 'México', '331 Pessoas com o sobrenome Resina na Árvore Familiar compartilhada.');
 call InsertSobrenome('Oliveira', 'Brasil', 'Portugal', 'Uruguai', '597,179 Pessoas com o sobrenome Oliveira na Árvore Familiar compartilhada.');
 call InsertSobrenome('Porto', 'Brasil', 'Itália', 'Espanha', '20,361 Pessoas com o sobrenome Porto na Árvore Familiar compartilhada.');
 
 
  select * from tbSobrenome;
