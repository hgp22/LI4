CREATE TABLE [dbo].[Utilizadores]
(
  [Username] VARCHAR(50) NOT NULL PRIMARY KEY,
  [Email] VARCHAR(100) NOT NULL,
  [Password] VARCHAR(100) NOT NULL,
  [Nif] INT NOT NULL,
  [Nome] VARCHAR(100) NOT NULL,
  [DataNascimento] DATE NOT NULL,
  [IsAdmin] BIT NOT NULL,
  [MetodoPagamento] INT,
  [DetalhesEntrega] INT
);
