USE [panesito]
GO
/****** Object:  StoredProcedure [dbo].[SP_ROL]    Script Date: 14/11/2022 11:02:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ROL]
@OP TINYINT,
@IDROL INT = 0, 
@TIPO VARCHAR(50) =null
AS
BEGIN
	IF @OP = 1
	BEGIN
		IF NOT EXISTS(SELECT * FROM ROL WHERE r_id = @IDROL)
		BEGIN
			INSERT INTO ROL(r_tipo)
			VALUES(@TIPO)
		END
		ELSE
		BEGIN
			UPDATE ROL SET  r_tipo = @TIPO
			WHERE r_id = @IDROL
		END
	END
END