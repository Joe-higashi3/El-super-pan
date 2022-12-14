USE [panesito]
GO
/****** Object:  StoredProcedure [dbo].[SP_EMPLEADO]    Script Date: 14/11/2022 11:01:43 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EMPLEADO]
@OP TINYINT,
@IDEMPLEADO INT = 0, 
@USUARIO VARCHAR(30) =null, 
@CONTRASEÑA varbinary(max)=null, 
@APELLIDO_P VARCHAR(30)=null,
@APELLIDO_M VARCHAR(30)=null,
@TELEFONO VARCHAR(10)=NULL,
@CALLE VARCHAR(60) =null, 
@INTERIOR INT=null, 
@EXTERIOR INT=null,
@COLONIA VARCHAR(30)=NULL,
@MUNICIPIO INT=NULL,
@ROL INT=NULL,
@STATUS CHAR(1) =null
AS
BEGIN
	IF @OP = 1
	BEGIN
		IF NOT EXISTS(SELECT * FROM EMPLEADO WHERE em_id_empleado = @IDEMPLEADO)
		BEGIN
			INSERT INTO EMPLEADO(em_usuario,em_contraseña,em_apellido_paterno,em_apellido_materno,em_telefono,em_calle,
			em_num_interior,em_num_exterior,em_colonia,em_id_municipio,em_r_id,em_status)
			VALUES(@USUARIO,ENCRYPTBYPASSPHRASE(@CONTRASEÑA,CAST(@CONTRASEÑA AS varbinary(max))),@APELLIDO_P,@APELLIDO_M,@TELEFONO,@CALLE,@INTERIOR,@EXTERIOR,@COLONIA,@MUNICIPIO,@ROL,@STATUS)
		END
		ELSE
		BEGIN
			UPDATE EMPLEADO SET  em_usuario=@USUARIO, em_contraseña=@CONTRASEÑA, em_apellido_paterno=@APELLIDO_P, 
			em_apellido_materno=@APELLIDO_M, em_telefono=@TELEFONO,em_calle=@CALLE, em_num_interior=@INTERIOR,em_num_exterior=@EXTERIOR,
			em_colonia=@COLONIA, em_id_municipio=@MUNICIPIO, em_r_id=@ROL,em_status=@STATUS 
			WHERE em_id_empleado = @IDEMPLEADO
		END
	END
	IF @OP = 2
	BEGIN
		UPDATE EMPLEADO SET em_status = @STATUS WHERE em_id_empleado = @IDEMPLEADO
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
