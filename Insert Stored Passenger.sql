CREATE PROCEDURE uspAddPassenger(
     @intPassengerID			AS INTEGER OUTPUT
    ,@strFirstName				AS VARCHAR(255)
    ,@strLastName				AS VARCHAR(255)
    ,@strAddress				AS VARCHAR(255)
    ,@strCity					AS VARCHAR(255)
    ,@intState					AS INTEGER 
    ,@strZip					AS VARCHAR(255)
    ,@strPhoneNumber			AS VARCHAR(255)    
    ,@strEmail					AS VARCHAR(255)
)       
AS
SET XACT_ABORT ON --terminate and rollback if any errors
BEGIN TRANSACTION
    SELECT @intPassengerID = ISNULL(MAX(intPassengerID), 0) + 1 
	FROM TPassengers WITH (TABLOCKX);

    -- default to 1 if table is empty
    SELECT @intPassengerID = COALESCE(@intPassengerID, 1)
    INSERT INTO TPassengers (intPassengerID, strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail)
    VALUES (@intPassengerID, @strFirstName, @strLastName, @strAddress, @strCity, @intState, @strZip, @strPhoneNumber, @strEmail)

COMMIT TRANSACTION
GO