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
