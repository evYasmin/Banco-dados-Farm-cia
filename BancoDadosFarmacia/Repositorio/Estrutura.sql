CREATE TABLE produto_higienicos (
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR (100) , 
preco DECIMAL (8,2) , 
categoria VARCHAR (30) 
);




DROP TABLE remedio;
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