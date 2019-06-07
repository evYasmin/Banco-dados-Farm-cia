CREATE TABLE produto_higienicos (
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR (100) , 
preco DECIMAL (8,2) , 
categoria VARCHAR (30) 
);



DROP TABLE remedios;
CREATE TABLE remedios (
id INT PRIMARY KEY IDENTITY(1,1) , 
nome VARCHAR (100) , 
categoria VARCHAR(25) , 
e_generico BIT , 
contra_indicacoes VARCHAR(100) , 
bula VARCHAR (40) , 
faixa VARCHAR(30) , 
precisa_receita BIT , 
e_solido BIT 
);

SELECT id,nome,categoria,e_generico,contra_indicacoes,bula,faixa,precisa_receita,e_solido FROM remedios;




CREATE TABLE comestiveis (
id INT PRIMARY KEY IDENTITY(1,1) ,
nome VARCHAR(100) , 
valor DECIMAL(6,2) , 
data_vencimento VARCHAR(30) , 
quantidade INT , 
marca VARCHAR(56) 
);