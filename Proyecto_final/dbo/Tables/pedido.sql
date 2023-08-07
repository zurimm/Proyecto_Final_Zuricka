CREATE TABLE [dbo].[pedido] (
    [idLibro]     VARCHAR (30)   NOT NULL,
    [idCliente]   VARCHAR (15)   NOT NULL,
    [fecha]       DATETIME       NOT NULL,
    [cantidad]    SMALLINT       DEFAULT ((1)) NOT NULL,
    [precioTotal] NUMERIC (8, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([idLibro] ASC),
    FOREIGN KEY ([idCliente]) REFERENCES [dbo].[cliente] ([idCliente]),
    FOREIGN KEY ([idLibro]) REFERENCES [dbo].[libro] ([idLibro])
);

