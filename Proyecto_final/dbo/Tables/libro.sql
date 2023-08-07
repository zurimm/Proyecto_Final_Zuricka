CREATE TABLE [dbo].[libro] (
    [idLibro] VARCHAR (30)   NOT NULL,
    [titulo]  VARCHAR (50)   NOT NULL,
    [autor]   VARCHAR (50)   NOT NULL,
    [precio]  NUMERIC (8, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([idLibro] ASC)
);

