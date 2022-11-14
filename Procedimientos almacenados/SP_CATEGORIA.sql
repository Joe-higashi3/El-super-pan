USE [panesito]
GO
/****** Object:  StoredProcedure [dbo].[SP_CATEGORIA]    Script Date: 14/11/2022 11:01:09 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[SP_CATEGORIA]
(
@OP TINYINT,
@IDCATEGORIA INT = 0,
@DESCRIPCION varchar(50)=null
)
AS
BEGIN
	IF @OP = 1
	BEGIN
		IF NOT EXISTS(SELECT * FROM CATEGORIA WHERE ca_id = @IDCATEGORIA)
		BEGIN
			INSERT INTO CATEGORIA(ca_descripcion)
			VALUES(@DESCRIPCION)
		END
		ELSE
		BEGIN
			UPDATE CATEGORIA SET ca_descripcion=@DESCRIPCION
			WHERE ca_id = @IDCATEGORIA
		END
	END

END