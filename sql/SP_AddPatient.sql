CREATE PROCEDURE SP_AddPatient
@PatientID INT OUTPUT,
@FirstName NVARCHAR(100),
@LastName NVARCHAR(100),
@Phone NVARCHAR(50),
@Email NVARCHAR(250),
@Address NVARCHAR(250),
@MedicalNotes NVARCHAR(100)

AS
BEGIN
INSERT INTO Patients(FirstName, LastName , Phone,  Email, Address, MedicalNotes) values
(@FirstName, @LastName,@Phone,@Email, @Address, @MedicalNotes)
END
SET @PatientID = SCOPE_IDENTITY()

select * from Patients






select * from Patients