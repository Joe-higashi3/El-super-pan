USE [panesito]
GO
/****** Object:  StoredProcedure [dbo].[SP_TIPO_MOV]    Script Date: 14/11/2022 11:02:48 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_TIPO_MOV]
@OP TINYINT,
@IDTM INT = 0, 
@TIPO_MOV VARCHAR(40) =null

AS
BEGIN
	IF @OP = 1
	BEGIN
		IF NOT EXISTS(SELECT * FROM TIPO_MOV WHERE tm_id = @IDTM)
		BEGIN
			INSERT INTO TIPO_MOV(tm_id, tm_tipo)
			VALUES(@IDTM, @TIPO_MOV)
		END
		ELSE
		BEGIN
			UPDATE TIPO_MOV SET tm_tipo =@TIPO_MOV
			WHERE tm_id = @IDTM
		END
	END
END
