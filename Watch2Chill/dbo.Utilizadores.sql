CREATE TABLE [dbo].[Utilizadores] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Nome]           NVARCHAR (MAX) NOT NULL,
    [Email]          NVARCHAR (150) NOT NULL,
    [Morada]         NVARCHAR (MAX) NOT NULL,
    [CodPostal]      NVARCHAR (MAX) NOT NULL,
    [Sexo]           NVARCHAR (MAX) NULL,
    [DataNascimento] DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_Utilizadores] PRIMARY KEY CLUSTERED ([Id] ASC)
);

