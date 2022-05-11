USE [NGANHANG]
GO

/****** Object:  StoredProcedure [dbo].[SP_TAOACCOUNT]    Script Date: 22/09/2021 1:57:11 SA ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_TAOACCOUNT]
    @LGNAME VARCHAR(50),  @PASS VARCHAR(50),
    @USERNAME VARCHAR(50),  @ROLE VARCHAR(50)     
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS, 'NGANHANG'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
  BEGIN
     RAISERROR ('Tài khoản này đã có người sử dụng!', 16,1)
	 RETURN
  END 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RAISERROR ('Nhân viên này đã có login name!', 16,2)
       RETURN
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE = 'ADMIN'
  BEGIN
      EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
      EXEC sp_addsrvrolemember @LGNAME, 'DBCREATOR'
      EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
  END
  IF @ROLE = 'CHINHANH' OR @ROLE = 'NGANHANG'
  BEGIN
      EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
  END

GO


