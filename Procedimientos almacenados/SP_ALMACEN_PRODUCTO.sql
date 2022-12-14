USE [panesito]
GO
/****** Object:  StoredProcedure [dbo].[SP_ALMACEN_PRODUCTO]    Script Date: 14/11/2022 11:00:14 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ALMACEN_PRODUCTO]
@OP tinyint,
@IDALMACEN int = 0,
@NOMBRE varchar (50) = null

AS
BEGIN
	IF @OP = 1
	BEGIN
		if not exists(select *from ALMACEN_PRODUCTO where ap_id = @IDALMACEN)
		BEGIN
			Insert into ALMACEN_PRODUCTO(ap_id, ap_nombre) 
			values (@IDALMACEN, @NOMBRE)
		END
		ELSE
		BEGIN
			update ALMACEN_PRODUCTO set ap_nombre = @NOMBRE where ap_id = @IDALMACEN
		END
	END
END
