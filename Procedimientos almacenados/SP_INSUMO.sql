USE [panesito]
GO
/****** Object:  StoredProcedure [dbo].[SP_INSUMO]    Script Date: 14/11/2022 11:01:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSUMO]
@OP TINYINT,
@IDINSUMO INT = 0, 
@NOMBRE VARCHAR(50) =null,
@COSTO FLOAT = null,
@UNIDAD INT = null,
@STATUS CHAR(1) =null
AS
BEGIN
	IF @OP = 1
	BEGIN
		IF NOT EXISTS(SELECT * FROM INSUMO WHERE in_id_insumo = @IDINSUMO)
		BEGIN
			INSERT INTO INSUMO(in_id_insumo, in_nombre, in_costo, in_id_unidad, in_status)
			VALUES(@IDINSUMO, @NOMBRE, @COSTO, @UNIDAD, @STATUS)
		END
		ELSE
		BEGIN
			UPDATE INSUMO SET in_nombre =@NOMBRE,in_costo =@COSTO, in_id_unidad = @UNIDAD,  in_status =@STATUS 
			WHERE in_id_insumo = @IDINSUMO
		END
	END
	IF @OP = 2
	BEGIN
		UPDATE INSUMO SET in_status = @STATUS WHERE in_id_insumo = @IDINSUMO
	END
END