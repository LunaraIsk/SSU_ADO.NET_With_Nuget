SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetRequest
    @IdRequest int
AS
BEGIN
	SELECT S.IdRequest, 
	   S.DateOfCreation,
	   S.Id_Inventory,
	   S.Amount,
	   S.Comment
		FROM dbo.Request S where S.IdRequest = @IdRequest
END
GO

