CREATE TABLE produto_higienicos (
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR (100) , 
preco DECIMAL (8,2) , 
categoria VARCHAR (30) 
);

SELECT id,nome,preco,categoria FROM produto_higienicos;