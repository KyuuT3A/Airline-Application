CREATE PROCEDURE uspDeleteAttendant
     @intAttendantID				AS INTEGER             
AS
SET XACT_ABORT ON --terminate and rollback if any errors
BEGIN TRANSACTION  
    Delete  FROM TAttendants 
	WHERE  intAttendantID = @intAttendantID
COMMIT TRANSACTION
GO