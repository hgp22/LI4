CREATE TABLE [dbo].[Licitacoes]
(
  [Id] INT NOT NULL PRIMARY KEY,
  [Data] TIMESTAMP NOT NULL,
  [Valor] INT NOT NULL,
  [UsernameUtilizador] VARCHAR(50) NOT NULL,
  [IdVeiculo] INT NOT NULL,
  FOREIGN KEY ([UsernameUtilizador]) REFERENCES [dbo].[Utilizadores]([Username]),
  FOREIGN KEY ([IdVeiculo]) REFERENCES [dbo].[Veiculos]([Id])
);
