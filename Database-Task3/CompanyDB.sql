CREATE DATABASE CompanyDB; 
GO 
USE CompanyDB;
GO

--part1
--Craete Employee table

CREATE TABLE Employee
(
    Ssn CHAR(9) PRIMARY KEY,

    Fname VARCHAR(30) NOT NULL,
    Minit CHAR(30),
    Lname VARCHAR(30) NOT NULL,

    Bdate DATE NOT NULL,

    Address VARCHAR(100),

    Sex CHAR(1)
        CHECK (Sex IN ('M','F')),

    Salary DECIMAL(10,2)
        NOT NULL
        CHECK (Salary > 0),

    Super_ssn CHAR(9),

    Dno INT NOT NULL
);
GO

-- craete department table
CREATE TABLE Department
(
    Dnumber INT PRIMARY KEY,
    Dname VARCHAR(50) NOT NULL UNIQUE,
    Mgr_ssn CHAR(9) NULL,
    Mgr_start_date DATE NOT NULL
);
GO

--department location 
CREATE TABLE Dept_Locations
(
    Dnumber INT NOT NULL,
    Dlocation VARCHAR(50) NOT NULL,

    PRIMARY KEY (Dnumber, Dlocation),

    FOREIGN KEY (Dnumber)
        REFERENCES Department(Dnumber)
);
GO

--craete project table
CREATE TABLE Project
(
    Pnumber INT PRIMARY KEY,

    Pname VARCHAR(50) NOT NULL UNIQUE,

    Plocation VARCHAR(50),

    Dnum INT NOT NULL,

    FOREIGN KEY (Dnum)
        REFERENCES Department(Dnumber)
);
GO

--create works on table
CREATE TABLE Works_On
(
    Essn CHAR(9) NOT NULL,
    Pno INT NOT NULL,

    Hours DECIMAL(4,1)
        DEFAULT 0
        CHECK (Hours >= 0),

    PRIMARY KEY(Essn,Pno),

    FOREIGN KEY(Essn)
        REFERENCES Employee(Ssn),

    FOREIGN KEY(Pno)
        REFERENCES Project(Pnumber)
);
GO

--craete dependent table 
CREATE TABLE Dependent
(
    Essn CHAR(9) NOT NULL,

    Dependent_name VARCHAR(40) NOT NULL,

    Sex CHAR(1)
        CHECK (Sex IN ('M','F')),

    Bdate DATE,

    Relationship VARCHAR(25),

    PRIMARY KEY(Essn, Dependent_name),

    FOREIGN KEY(Essn)
        REFERENCES Employee(Ssn)
);
GO


--part2
--add the remaining foreign keys
ALTER TABLE Employee
ADD CONSTRAINT FK_Employee_Department
FOREIGN KEY(Dno)
REFERENCES Department(Dnumber);
GO

ALTER TABLE Employee
ADD CONSTRAINT FK_Employee_Supervisor
FOREIGN KEY(Super_ssn)
REFERENCES Employee(Ssn);
GO

ALTER TABLE Department
ADD CONSTRAINT FK_Department_Manager
FOREIGN KEY(Mgr_ssn)
REFERENCES Employee(Ssn);
GO

--part3
--NSERT statements
--1
INSERT INTO Department (Dnumber, Dname, Mgr_ssn, Mgr_start_date)
VALUES
(1, 'Research', NULL, '2020-11-01'),
(2, 'Administration', NULL, '2022-04-01'),
(3, 'IT', NULL, '2023-12-05');

--2
INSERT INTO Employee (Ssn, Fname, Minit, Lname, Bdate, Address, Sex, Salary, Super_ssn, Dno)
VALUES
('111111111','Ali','Ahmed','Almahroqi','2000-04-10','Muscat','M',1000,NULL,1),
('222222222','Sara','Basim','Alshamsi','1999-08-15','Muscat','F',2000,'111111111',1),
('333333333','Ahmed','Camal','Alhadi','1998-01-05','Sohar','M',900,'111111111',2),
('444444444','Abdullah','ali','Alwahibi','1995-10-20','Nizwa','F',1500,'333333333',2),
('555555555','mosaa','Ibrahim','Alsawafi','1992-12-12','Salalah','M',850,'111111111',3);

--3
INSERT INTO Project (Pnumber, Pname, Plocation, Dnum)
VALUES
(1,'Payroll','Muscat',2),
(2,'Website','Muscat',3),
(3,'AI System','Salalah',1);

--4
INSERT INTO Works_On (Essn, Pno, Hours)
VALUES
('111111111',3,20),
('222222222',3,25),
('333333333',1,30),
('444444444',1,25),
('555555555',2,40);

--5
INSERT INTO Dependent (Essn, Dependent_name, Sex, Bdate, Relationship)
VALUES
('111111111','Mona','F','2012-05-01','Daughter'),
('222222222','Omar','M','2015-03-12','Son'),
('333333333','Aya','F','2018-09-21','Daughter');

--UPDATE Statements
--1
UPDATE Employee
SET Salary = Salary + 200
WHERE Ssn = '222222222';

--2
UPDATE Project
SET Plocation = 'Nizwa'
WHERE Pnumber = 2;

--3
UPDATE Employee
SET Dno = 3
WHERE Ssn = '444444444';

--4
UPDATE Works_On
SET Hours = 42
WHERE Essn = '222222222'
  AND Pno = 3;

--5
UPDATE Dependent
SET Relationship = 'Child'
WHERE Essn = '111111111'
  AND Dependent_name = 'Mona';


--DELETE Statements
--1
DELETE FROM Works_On
WHERE Essn = '444444444';

DELETE FROM Dependent
WHERE Essn = '333333333'
  AND Dependent_name = 'Aisha';

--2
DELETE FROM Employee
WHERE Ssn = '444444444';
