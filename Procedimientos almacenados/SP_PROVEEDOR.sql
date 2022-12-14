USE [panesito]
GO
/****** Object:  StoredProcedure [dbo].[SP_PROVEEDOR]    Script Date: 14/11/2022 11:02:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PROVEEDOR]
@OP TINYINT,
@IDPROVEEDOR INT = 0, 
@NOMBRE VARCHAR(50) =null, 
@APELLIDO_P VARCHAR(100)=null, 
@APELLIDO_M VARCHAR(50)=null,
@REGIMEN INT=null,
@RFC VARCHAR(13)=NULL,
@RAZON_SOCIAL VARCHAR(200) =null,
@TELEFONO VARCHAR(15)=NULL,
@CALLE VARCHAR(50)=NULL,
@NUM_INT VARCHAR (10)=null, 
@NUM_EXT VARCHAR(10)=null,
@COLONIA VARCHAR(50)=NULL,
@MUNICIPIO INT=NULL,
@STATUS CHAR(1) =null
AS
BEGIN
	IF @OP = 1
	BEGIN
		IF NOT EXISTS(SELECT * FROM PROVEEDOR WHERE pdr_id = @IDPROVEEDOR)
		BEGIN
			INSERT INTO PROVEEDOR(pdr_id,pdr_nombre, pdr_apellido_pat,pdr_apellido_mat,pdr_regimen,pdr_RFC,  pdr_rason_social,pdr_telefono,pdr_calle ,
			pdr_num_interior,pdr_num_exterior,pdr_colonia,pdr_id_municipio,pdr_status)
			VALUES(@IDPROVEEDOR,@NOMBRE, @APELLIDO_P, @APELLIDO_M,@REGIMEN,@RFC,@RAZON_SOCIAL,@TELEFONO,@CALLE,@NUM_INT, 
			@NUM_EXT,@COLONIA,@MUNICIPIO,@STATUS)
		END
		ELSE
		BEGIN
			UPDATE PROVEEDOR SET  pdr_nombre = @NOMBRE, pdr_apellido_pat = @APELLIDO_P,pdr_apellido_mat = @APELLIDO_M,pdr_regimen = @REGIMEN,
			pdr_RFC = @RFC, pdr_rason_social = @RAZON_SOCIAL,pdr_telefono = @TELEFONO,pdr_calle = @CALLE,pdr_num_interior = @NUM_INT,
			pdr_num_exterior = @NUM_EXT,pdr_colonia = @COLONIA,pdr_id_municipio = @MUNICIPIO,pdr_status = @STATUS
			WHERE pdr_id = @IDPROVEEDOR
		END
	END
	IF @OP = 2
	BEGIN
		UPDATE PROVEEDOR SET pdr_status = @STATUS WHERE pdr_id = @IDPROVEEDOR
	END
	/*IF @OP = 3?????????
	BEGIN
		SELECT IDESTUDIANTE,NOMBRE,DBO.FN_ESTUDIANTE([STATUS]) AS EXISTENCIA FROM ESTUDIANTES
	END*/
END

select * from EMPLEADO
--dbcc CHECKIDENT(Empleado, reseed,0)

/*SELECT em_id_empleado, em_usuario, em_contraseña, em_apellido_paterno, em_apellido_materno, em_telefono, em_calle, em_num_interior, em_num_exterior, em_colonia, em_id_municipio, em_r_id, em_status
FROM     EMPLEADO*/

/*SELECT E.em_id_empleado, E.em_usuario, E.em_contraseña, E.em_apellido_paterno, E.em_apellido_materno, E.em_telefono, E.em_calle, E.em_num_interior, E.em_num_exterior, E.em_colonia, E.em_id_municipio, M.mu_descripcion, E.em_r_id, R.r_tipo, E.em_status
FROM EMPLEADO as E
INNER JOIN MUNICIPIO AS M ON E.em_id_municipio = M.mu_id_municipio
INNER JOIN ROL AS R ON E.em_r_id = R.r_id*/
