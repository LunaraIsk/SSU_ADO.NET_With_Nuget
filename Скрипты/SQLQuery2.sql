SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE AddRequest
	@DateOfCreation Date,
	@Id_Inventory int,
	@Amount int,
	@Comment nvarchar(300)
AS
BEGIN
	    INSERT INTO Request(DateOfCreation, Id_Inventory, Amount, Comment)
		VALUES(@DateOfCreation, @Id_Inventory, @Amount, @Comment)

		SELECT @@IDENTITY;
END
GO
