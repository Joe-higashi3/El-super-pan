USE [panesito]
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTO]    Script Date: 14/11/2022 11:02:11 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_PRODUCTO]
(
@OP TINYINT,
@IDPRODUCTO INT = 0,
@NOMBRE varchar(20),
@DESCRIPCION VARCHAR(30),
@CATEGORIA INT = 0,
@PRECIO FLOAT,
@IDUNIDAD INT=0,
@STATUS CHAR(1)= NULL
)
AS
BEGIN
	IF @OP = 1
	BEGIN
		IF NOT EXISTS(SELECT * FROM PRODUCTO WHERE pr_id_producto = @IDPRODUCTO)
		BEGIN
			INSERT INTO PRODUCTO(pr_nombre,pr_descripcion,pr_id_categoria,pr_precio, pr_id_unidad, pr_status)
			VALUES(@NOMBRE,@DESCRIPCION,@CATEGORIA,@PRECIO, @IDUNIDAD, @STATUS)
		END
		ELSE
		BEGIN
			UPDATE PRODUCTO SET pr_nombre =@NOMBRE, pr_descripcion=@DESCRIPCION, pr_id_categoria = @CATEGORIA,
			pr_precio=@PRECIO, pr_id_unidad = @IDUNIDAD, pr_status = @STATUS 
			WHERE pr_id_producto = @IDPRODUCTO
		END
	END

END