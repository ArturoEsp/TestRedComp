/* Script WebAPI */
/* Author: Arturo Espinoza Herrera */


CREATE DATABASE DB_ESCUELA;

USE DB_ESCUELA;

CREATE TABLE Aula(
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	numero CHAR(4) NOT NULL,
	edificio CHAR(3) NOT NULL
);

CREATE TABLE Alumno(
	id INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	apellido VARCHAR(50) NOT NULL,
	cedula	CHAR(15) NOT NULL UNIQUE,
	aula_id INT NOT NULL,
	FOREIGN KEY (aula_id) REFERENCES Aula(id)
); 


CREATE TABLE Profesor(
	id INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	apellido VARCHAR(50) NOT NULL,
	identificacion VARCHAR(15) NOT NULL UNIQUE,
	aula_id INT NOT NULL,
	FOREIGN KEY (aula_id) REFERENCES Aula(id)
);

CREATE TABLE Promedio(
	alumno_id INT NOT NULL,
	promedio DECIMAL(2,2),
	FOREIGN KEY (alumno_id) REFERENCES Alumno(id),
);

CREATE TABLE Materia(
	id INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	nombre VARCHAR(50) NOT NULL UNIQUE,
	profesor_id INT NOT NULL,
	FOREIGN KEY (profesor_id) REFERENCES Profesor(id)
);

CREATE TABLE Calificacion(
	alumno_id INT NOT NULL,
	materia_id INT NOT NULL,
	calificacion DECIMAL(2,2),
	FOREIGN KEY (alumno_id) REFERENCES Alumno(id),
	FOREIGN KEY (materia_id) REFERENCES Materia(id),
);

/* Data Insert */

INSERT INTO Aula(numero, edificio) VALUES('201', 'A'),('302','A'),('405','F');

INSERT INTO Alumno(nombre, apellido, cedula, aula_id) VALUES('Camila','González','201874856', 1),
('Emilio','Díaz','201898245', 2), ('Daniel','Rodríguez','201896384',1), ('Fernanda','Martínez','201719745',1),
('Javier','Gómez','201896873', 3), ('María','Romero','201836289',3), ('Ximena','Sosa','201874891', 2);


INSERT INTO Profesor(nombre, apellido, identificacion, aula_id) VALUES ('Adriana','Vera','MWM987513', 3),
('Gabriel','Miranda','YTJ321545', 1),('Luisa','Sandoval','WM332154', 2);


INSERT INTO Materia(nombre, profesor_id) VALUES('Fundamentos de programación', 1), ('Arquitectura de software', 2),('Bases de datos', 3);
