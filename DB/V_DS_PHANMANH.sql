USE [NGANHANG]
GO

/****** Object:  View [dbo].[V_DS_PHANMANH]    Script Date: 16/09/2021 11:55:56 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_DS_PHANMANH]
AS
SELECT  TENCN=PUBS.description, TENSERVER= subscriber_server
   FROM dbo.sysmergepublications PUBS,  dbo.sysmergesubscriptions SUBS
   WHERE PUBS.pubid= SUBS.PUBID  AND PUBS.publisher <> SUBS.subscriber_server

GO

