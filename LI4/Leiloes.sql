CREATE TABLE [dbo].[Leiloes]
(
  [Id] INT NOT NULL PRIMARY KEY,
  [Titulo] VARCHAR(50) NOT NULL,
  [Fotografias] VARCHAR(100) NOT NULL,
  [ValorInicial] INT NOT NULL,
  [AumentoMinimo] INT NOT NULL,
  [DataFinal] DATE NOT NULL,
  [Estado] INT NOT NULL,
  [VideoLink] VARCHAR(100),
  [Descricao] VARCHAR(500),
  [UsernameAdmin] VARCHAR(50) NOT NULL,
  [IdVeiculo] INT NOT NULL,
  [idLicitacaoAtual] INT,
  FOREIGN KEY ([UsernameAdmin]) REFERENCES [dbo].[Utilizadores]([Username]),
  FOREIGN KEY ([IdVeiculo]) REFERENCES [dbo].[Veiculos]([Id]),
  FOREIGN KEY ([idLicitacaoAtual]) REFERENCES [dbo].[Licitacoes]([Id])
);
