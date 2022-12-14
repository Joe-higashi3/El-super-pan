USE [panesito]
GO
/****** Object:  StoredProcedure [dbo].[SP_UNIDAD]    Script Date: 14/11/2022 11:03:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UNIDAD]
@OP TINYINT,
@IDUNIDAD INT = 0, 
@DESCRIPCION VARCHAR(20) =null

AS
BEGIN
	IF @OP = 1
	BEGIN
		IF NOT EXISTS(SELECT * FROM UNIDAD WHERE un_id_unidad = @IDUNIDAD)
		BEGIN
			INSERT INTO UNIDAD(un_id_unidad, un_descripcion)
			VALUES(@IDUNIDAD, @DESCRIPCION)
		END
		ELSE
		BEGIN
			UPDATE UNIDAD SET un_descripcion =@DESCRIPCION 
			WHERE un_id_unidad = @IDUNIDAD
		END
	END
END
