--(frmAttendantForm.vb page uspGetAttendants)1
CREATE PROCEDURE uspGetAttendantInfoByName(
    @FirstName VARCHAR(255),
    @LastName VARCHAR(255)
)
AS
BEGIN
    SELECT intAttendantID, strFirstName, strLastName
    FROM TAttendants
    WHERE strFirstName = @FirstName AND strLastName = @LastName;
END


--(frmStatistics.vb page uspCalculateTotalMilesFlownByPilot)2
CREATE PROCEDURE uspCalculateTotalMilesFlownByPilot
AS
BEGIN
    SELECT TP.strFirstName + ' ' + TP.strLastName AS PilotName,
           ISNULL(SUM(TF.intMilesFlown), 0) AS TotalMilesFlown
    FROM TPilots AS TP
    JOIN TPilotFlights AS TPF ON TP.intPilotID = TPF.intPilotID
    JOIN TFlights AS TF ON TF.intFlightID = TPF.intFlightID
    GROUP BY TP.strFirstName, TP.strLastName;
END;

--(frmUpdatePilotProfile Page uspGetPilotRoles)3
CREATE PROCEDURE uspGetPilotRoles
AS
BEGIN
    SELECT intPilotRoleID, strPilotRole
    FROM TPilotRoles;
END

--(frmAddCustomer.vb page uspSelectStates)4
CREATE PROCEDURE uspSelectStates    
AS
BEGIN
    SELECT TS.intStateID, TS.strState 
    FROM TStates As TS	 
END;

--(frmUpdatePilotProfile page uspGetPilotInfoByPilotID)5
CREATE PROCEDURE uspGetPilotInfoByPilotID
    @Pilot_ID INT
AS
BEGIN
    SELECT strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination, dtmDateofLicense, intPilotRoleID
    FROM TPilots
    WHERE intPilotID = @Pilot_ID;
END

--(frmAttendantsFutureFlights.vb page usp_GetUpcomingFlightsForAttendant)6
 CREATE PROCEDURE usp_GetUpcomingFlightsForAttendant
    @Attendant_ID As INTEGER
AS
BEGIN
    SELECT strFlightNumber, dtmFlightDate, dtmTimeofDeparture, dtmTimeOfLanding, intMilesFlown
    FROM TFlights
    WHERE dtmFlightDate > GETDATE()
    AND intFlightID IN (
        SELECT intFlightID
        FROM TAttendantFlights
        WHERE intAttendantID = @Attendant_ID
    );
END

--(frmStatistic page uspCalculateAverageMilesFlown)7
CREATE PROCEDURE uspCalculateAverageMilesFlown
AS
BEGIN
    SELECT AVG(TF.intMilesFlown) AS AverageMilesFlown
    FROM TFlights AS TF
    JOIN TFlightPassengers AS TFP ON TF.intFlightID = TFP.intFlightID;
END

--(frmStatitic page uspCalculateTotalMilesFlownByAttendant)8
CREATE PROCEDURE uspCalculateTotalMilesFlownByAttendant
AS
BEGIN
    SELECT TA.strFirstName + ' ' + TA.strLastName AS AttendantName,
           ISNULL(SUM(TF.intMilesFlown), 0) AS TotalMilesFlown
    FROM TAttendants AS TA
    JOIN TAttendantFlights AS TAF ON TA.intAttendantID = TAF.intAttendantID
    JOIN TFlights AS TF ON TF.intFlightID = TAF.intFlightID
    GROUP BY TA.strFirstName, TA.strLastName;
END

--(frmShowFutureFlights.vb page uspGetFutureFlightsForCustomer)9
CREATE PROCEDURE usp_GetFutureFlightsForCustomer
    @Customer_ID As INTEGER
AS
BEGIN
    SELECT TF.strFlightNumber,
           TF.dtmFlightDate,
           TF.dtmTimeofDeparture,
           TF.dtmTimeOfLanding,
           TF.intMilesFlown
    FROM TFlights AS TF
    INNER JOIN TFlightPassengers AS TFP ON TF.intFlightID = TFP.intFlightID
    WHERE TF.dtmFlightDate > GETDATE()
    AND TFP.intPassengerID = @Customer_ID;
END







