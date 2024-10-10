-- Create the database
CREATE DATABASE EmployeeManagement;
GO

-- Use the newly created database
USE EmployeeManagement;
GO

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
    FOREIGN KEY (DepartmentId) REFERENCES Departments(Id) ON DELETE CASCADE
);

-- Employees Table
CREATE TABLE Employees (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(150) NOT NULL,
    DateOfBirth DATE,
    HireDate DATE NOT NULL,
    Phone NVARCHAR(20),
    PositionId INT NOT NULL,
    FOREIGN KEY (PositionId) REFERENCES Positions(Id) ON DELETE CASCADE
);

-- Insert sample data
-- Insert a new department
INSERT INTO Departments (DepartmentName, Description)
VALUES ('Recursos Humanos', 'Gestiona las relaciones con los empleados y el reclutamiento');

-- Insert a new position
INSERT INTO Positions (PositionName, BaseSalary, DepartmentId)
VALUES ('Especialista de RRHH', 5000.00, 1);

-- Insert a new employee
INSERT INTO Employees (FullName, DateOfBirth, HireDate, Phone, PositionId)
VALUES ('María García', '1985-07-15', '2023-09-01', '(555) 123-4567', 1);

-- Verify the data
SELECT * FROM Departments;
SELECT * FROM Positions;
SELECT * FROM Employees;