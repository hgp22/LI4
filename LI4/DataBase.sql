CREATE TABLE [dbo].[Marcas]
(
  [Id] INT NOT NULL PRIMARY KEY,
  [Nome] VARCHAR(50) NOT NULL
);
CREATE TABLE [dbo].[Modelos]
(
  [Id] INT NOT NULL PRIMARY KEY,
  [Nome] VARCHAR(50) NOT NULL,
  [IdMarca] INT NOT NULL,
  FOREIGN KEY ([IdMarca]) REFERENCES [dbo].[Marcas]([Id])
);
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
CREATE TABLE [dbo].[Veiculos]
(
  [Id] INT NOT NULL PRIMARY KEY,
  [Ano] INT NOT NULL,
  [Quilometragem] INT NOT NULL,
  [CorExeterior] VARCHAR(20) NOT NULL,
  [NumPortas] INT NOT NULL,
  [Cilindrada] INT NOT NULL,
  [Potencia] INT NOT NULL,
  [Lugares] INT NOT NULL,
  [TipoMotor] INT NOT NULL,
  [Tipo] INT NOT NULL,
  [IdMarca] INT NOT NULL,
  [IdModelo] INT NOT NULL,
  FOREIGN KEY ([IdMarca]) REFERENCES [dbo].[Marcas]([Id]),
  FOREIGN KEY ([IdModelo]) REFERENCES [dbo].[Modelos]([Id])
);
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
