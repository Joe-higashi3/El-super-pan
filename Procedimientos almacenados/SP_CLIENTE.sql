USE [panesito]
GO
/****** Object:  StoredProcedure [dbo].[SP_CLIENTE]    Script Date: 14/11/2022 11:01:30 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CLIENTE]
@OP TINYINT,
@IDCLIENTE INT = 0, 
@NOMBRE VARCHAR(50) =null, 
@APELLIDO_P VARCHAR(20)=null, 
@APELLIDO_M VARCHAR(20)=null,
@TELEFONO VARCHAR(15)=NULL,
@CALLE VARCHAR(50) =null, 
@NUM_INT VARCHAR(10)=null, 
@NUM_EXT VARCHAR(10)=null,
@COLONIA VARCHAR(50),
@MUNICIPIO INT = 0,
@TIPO INT = 0,
@STATUS CHAR(1) =null
AS
BEGIN
	IF @OP = 1
	BEGIN
		IF NOT EXISTS(SELECT * FROM CLIENTE WHERE cl_id_cliente = @IDCLIENTE)
		BEGIN
			INSERT INTO CLIENTE(cl_id_cliente,cl_nombre,cl_apellido_pat,cl_apellido_mat,cl_telefono,cl_calle,cl_num_interior,cl_num_exterior,cl_colonia,cl_id_municipio,cl_id_tipocl,cl_status)
			VALUES(@IDCLIENTE,@NOMBRE,@APELLIDO_M,@APELLIDO_P,@TELEFONO,@CALLE,@NUM_INT,@NUM_EXT,@COLONIA,11,@TIPO,@STATUS)
		END
		ELSE
		BEGIN
			UPDATE CLIENTE SET cl_nombre =@NOMBRE, cl_apellido_pat=@APELLIDO_P, cl_apellido_mat = @APELLIDO_M,cl_telefono=@TELEFONO,cl_calle=@CALLE,
			cl_num_interior=@NUM_INT,cl_num_exterior=@NUM_EXT,cl_colonia=@COLONIA,cl_id_tipocl=@TIPO, cl_status=@STATUS 
			WHERE cl_id_cliente = @IDCLIENTE
		END
	END
	IF @OP = 2
	BEGIN
		UPDATE CLIENTE SET cl_status = @STATUS WHERE cl_id_cliente = @IDCLIENTE
	END
	/*IF @OP = 3?????????
	BEGIN
		SELECT IDESTUDIANTE,NOMBRE,DBO.FN_ESTUDIANTE([STATUS]) AS EXISTENCIA FROM ESTUDIANTES
	END*/
END