CREATE PROCEDURE uspUpdatePassenger
     @intPassengerID			AS INTEGER 
    ,@strFirstName				AS VARCHAR(255)
    ,@strLastName				AS VARCHAR(255)
    ,@strAddress				AS VARCHAR(255)
    ,@strCity					AS VARCHAR(255)
    ,@intState					AS INTEGER 
    ,@strZip					AS VARCHAR(255)
    ,@strPhoneNumber			AS VARCHAR(255)    
    ,@strEmail					AS VARCHAR(255)
    ,@strPassengerLoginID		AS VARCHAR(255)
	,@strPassengerPassword		AS VARCHAR(255)
	,@dtmPassengerDateofBirth	DATETIME
	
AS
SET XACT_ABORT ON --terminate and rollback if any errors
BEGIN TRANSACTION
  
    Update  TPassengers 
			SET strFirstName =	@strFirstName, 
			    strLastName =	@strLastName,
				strAddress =	@strAddress, 
				strCity =		@strCity, 
				intStateID =	@intState,
				strZip =		@strZip,
				strPhoneNumber = @strPhoneNumber,
				strEmail =		@strEmail,
				strPassengerLoginID = @strPassengerLoginID,
				strPassengerPassword = @strPassengerPassword,
				dtmPassengerDateofBirth = @dtmPassengerDateofBirth
							   			
	WHERE  intPassengerID = @intPassengerID
COMMIT TRANSACTION