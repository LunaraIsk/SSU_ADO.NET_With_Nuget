SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetAllRequests
AS
BEGIN
	SELECT S.IdRequest, 
	   S.DateOfCreation,
	   S.Id_Inventory,
	   S.Amount,
	   S.Comment
		FROM dbo.Request S
END
GO
