USE [Proyecto_Final]
GO

SELECT [Id]
      ,[Nombre_Cat]
      ,[Precio_cat_Entrada]
      ,[contraseña_cat]
  FROM [dbo].[cat_evento]

GO

USE [Proyecto_Final]
GO


SELECT *
  FROM [dbo].[Entrada]


ALTER TABLE ENTRADA
ADD COSECUTIVO VARCHAR(100)
GO

USE [Proyecto_Final]
GO

SELECT [Id]
      ,[Nombre_evento]
      ,[Descripcion_evento]
      ,[fecha_Evento]
      ,[hora_evento]
      ,[espacios_evento]
  FROM [dbo].[Evento]



GO

drop TRIGGER TR_FILL_ENTRADAS;

go
CREATE TRIGGER TR_FILL_ENTRADAS
ON EVENTO
AFTER INSERT
AS
BEGIN
	DECLARE @contador INT
    SET @contador = 1

	DECLARE @IDEVENTO INT
	SET @IDEVENTO = (SELECT ID FROM inserted)

	WHILE @contador <= (SELECT ESPACIOS_EVENTO FROM inserted)
    BEGIN

        DECLARE @CONSECUTIVO INT
        SET @CONSECUTIVO = (SELECT ISNULL(MAX(ID),0) FROM ENTRADA) + 1
		PRINT(@CONSECUTIVO)

		DECLARE @Id VARCHAR(50)
		SET @Id = CAST(@IDEVENTO AS varchar);
		PRINT(@Id)



        INSERT INTO Entrada (COSECUTIVO) VALUES (@Id);



        SET @contador = @contador + 1
    END
END


DELETE FROM ENTRADA;