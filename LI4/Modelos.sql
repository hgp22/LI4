CREATE TABLE [dbo].[Modelos]
(
  [Id] INT NOT NULL PRIMARY KEY,
  [Nome] VARCHAR NOT NULL,
  [IdMarca] INT NOT NULL,
  FOREIGN KEY ([IdMarca]) REFERENCES [dbo].[Marcas]([Id])
);
