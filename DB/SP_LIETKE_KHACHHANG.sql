USE [NGANHANG]
GO

/****** Object:  StoredProcedure [dbo].[SP_LIETKE_KHACHHANG]    Script Date: 11/11/2021 3:51:35 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_LIETKE_KHACHHANG]
@maCN nchar(10)
AS
	IF EXISTS(SELECT CMND FROM LINK1.NGANHANG.dbo.KHACHHANG WHERE MACN = @maCN)
	BEGIN
		SELECT CMND, HO, TEN, NGAYCAP, SODT, MACN 
		FROM LINK1.NGANHANG.dbo.KHACHHANG 
		ORDER BY TEN, HO
	END
	ELSE 
	BEGIN
		SELECT CMND, HO, TEN, NGAYCAP, SODT, MACN 
		FROM KHACHHANG 
		ORDER BY TEN, HO
	END

GO


