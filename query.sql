-- CREATE DATABASE EmployeeManagement;
use EmployeeManagement;

/*
-- Departments Table
CREATE TABLE Departments (
    Id INT PRIMARY KEY IDENTITY(1,1),
    DepartmentName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255)
);
-- Positions Table
CREATE TABLE Positions (
    Id INT PRIMARY KEY IDENTITY(1,1),
    PositionName NVARCHAR(100) NOT NULL,
    BaseSalary DECIMAL(10, 2) NOT NULL,
    DepartmentId INT NOT NULL,
    FOREIGN KEY (DepartmentId) REFERENCES Departments(Id)
);

-- Employees Table
CREATE TABLE Employees (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(150) NOT NULL,
    DateOfBirth DATE,
    HireDate DATE NOT NULL,
    Phone NVARCHAR(20),
    PositionId INT NOT NULL,
    FOREIGN KEY (PositionId) REFERENCES Positions(Id)
);

-- Insertar un nuevo departamento
INSERT INTO Departments (DepartmentName, Description)
VALUES ('Recursos Humanos', 'Gestiona las relaciones con los empleados y el reclutamiento');
SELECT * FROM Departments;

-- Insertar un nuevo puesto
INSERT INTO Positions (PositionName, BaseSalary, DepartmentId)
VALUES ('Especialista de RRHH', 5000.00, 1);
SELECT * FROM Positions;

-- Insertar un nuevo empleado
INSERT INTO Employees (FullName, DateOfBirth, HireDate, Phone, PositionId)
VALUES ('María García', '1985-07-15', '2023-09-01', '(555) 123-4567', 1);
SELECT * FROM Employees;

-- Insertar un nuevo empleado
INSERT INTO Employees (FullName, DateOfBirth, HireDate, Phone, PositionId)
VALUES ('María García', '1985-07-15', '2023-09-01', '(555) 123-4567', 1);

SELECT * FROM Employees;
*/

-- First, we need to drop the existing foreign key constraints
ALTER TABLE Positions
DROP CONSTRAINT IF EXISTS FK_Positions_Departments;

ALTER TABLE Employees
DROP CONSTRAINT IF EXISTS FK_Employees_Positions;

-- Now, we can add the new foreign key constraints with cascading delete
ALTER TABLE Positions
ADD CONSTRAINT FK_Positions_Departments
FOREIGN KEY (DepartmentId) REFERENCES Departments(Id) ON DELETE CASCADE;

ALTER TABLE Employees
ADD CONSTRAINT FK_Employees_Positions
FOREIGN KEY (PositionId) REFERENCES Positions(Id) ON DELETE CASCADE;