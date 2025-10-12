use [Clinic Management System]

create table Patients(
PatientID int Primary Key,
Name nvarchar(100) not null,
Phone nvarchar(20) not null ,
Email nvarchar(50) ,
Address nvarchar(300),
MedicalNotes nvarchar(300)
)


create table Services
(
ServiceID int Primary Key,
ServiceName nvarchar(100) not null,
Price smallmoney not null
)

CREATE TABLE Appointments
(
    AppointmentID INT PRIMARY KEY NOT NULL,
    PatientID INT,
    ServiceID INT,
    AppointmentDate DATETIME,
    Status TINYINT, -- 1: „ƒﬂœ° 2: „·€Ì° 3: ﬁÌœ «·«‰ Ÿ«—

    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
    FOREIGN KEY (ServiceID) REFERENCES Services(ServiceID)
);





