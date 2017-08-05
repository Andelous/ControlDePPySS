DROP DATABASE IF EXISTS PPSS;
CREATE DATABASE PPSS;

USE PPSS;

-- Catalogos
CREATE TABLE TipoSolicitud (
	tipo_solicitud_id INT PRIMARY KEY AUTO_INCREMENT,
	nombre VARCHAR(100) NOT NULL

	/*
		Este tipo es para saber si es PP o SS
	*/
);

CREATE TABLE TipoUsuario (
	tipo_usuario_id INT PRIMARY KEY AUTO_INCREMENT,
	nombre VARCHAR(100) NOT NULL

	/*
		Este tipo es para saber el tipo de usuario.
		Habrá estos tipos de usuario:
			- Administrador (Nosotros, desarrolladores)
			- Usuario general (Lic. Erika)
			- Observador (Coordinadores)
	*/
);

CREATE TABLE Licenciatura (
	licenciatura_id INT PRIMARY KEY AUTO_INCREMENT,
	nombre VARCHAR(100) NOT NULL

	/*
		Las ingenierías
		- Ing. Software
		- Ing. Electronica
		- Ing. Civil
		- Ing. Industrial
		- Ing. Ambiental
		- Arquitectura
	*/
);

CREATE TABLE Organizacion (
	organizacion_id INT PRIMARY KEY AUTO_INCREMENT,

	nombre VARCHAR(150) NOT NULL,
	direccion VARCHAR(150) NOT NULL

	/*
		Datos generales de las organizaciones
	*/
);

-- Catalogos con FK a otros catalogos
CREATE TABLE Usuario (
	identificador VARCHAR(50) PRIMARY KEY,
	contrasena VARCHAR(100) NOT NULL,

	-- FK :v
	tipo_usuario_id INT NOT NULL

	/*
		Catálogo de los usuarios registrados.
		Aquí, el FK hace referencia al tipo de usuario
	*/
);

CREATE TABLE Alumno (
	matricula VARCHAR(10) PRIMARY KEY,

	nombres VARCHAR(50) NOT NULL,
	apellido_paterno VARCHAR(20) NOT NULL,
	apellido_materno VARCHAR(20) NOT NULL,

	-- Este es FK...
	licenciatura_id INT NOT NULL

	/*
		Catálogo de alumnos registrados del sistema
		La FK hace referencia a la licenciatura que
		cursa
	*/
);

CREATE TABLE Solicitud (
	solicitud_id INT PRIMARY KEY AUTO_INCREMENT,

	jefe_inmediato VARCHAR(100) NOT NULL,
	numero_de_contacto VARCHAR(15) NOT NULL,

	area VARCHAR(50) NOT NULL,

	carta_de_presentacion BIT NOT NULL DEFAULT 0,
	carta_de_aceptacion BIT NOT NULL DEFAULT 0,
	
	-- FKs...
	matricula VARCHAR(10) NOT NULL,
	organizacion_id INT NOT NULL,
	tipo_solicitud_id INT NOT NULL

	/*
		La solicitud, y datos generales:
		- Jefe inmediato
		- Número de contacto
		- Área donde estará el alumno
		- Booleano si ya se ha entregado la carta de presentación de la universidad
		- "                                        " aceptación de la empresa


		Los FK hacen referencia al alumno que hizo la solicitud
		también a la organización, y al tipo de solicitud (PP / SS)
	*/
);

CREATE TABLE CartaAceptacion (
	carta_aceptacion_id INT PRIMARY KEY AUTO_INCREMENT,
	horas_a_liberar INT NOT NULL,

	-- Horario general

	fecha_inicio DATE NOT NULL,
	fecha_fin DATE NOT NULL,

	lunes BIT NOT NULL DEFAULT 0,
	martes BIT NOT NULL DEFAULT 0,
	miercoles BIT NOT NULL DEFAULT 0,
	jueves BIT NOT NULL DEFAULT 0,
	viernes BIT NOT NULL DEFAULT 0,
	sabado BIT NOT NULL DEFAULT 0,
	domingo BIT NOT NULL DEFAULT 0,

	hora_entrada VARCHAR(5) NOT NULL,
	hora_salida VARCHAR(5) NOT NULL,

	-- FKs...
	solicitud_id INT NOT NULL

	/*
		Este tipo es para saber si es PP o SS
	*/
);

CREATE TABLE Reporte (
	reporte_id INT PRIMARY KEY AUTO_INCREMENT,
	horas_liberadas INT NOT NULL,

	fecha_inicio DATE NOT NULL,
	fecha_fin DATE NOT NULL,

	firma_coordinador BIT NOT NULL DEFAULT 0,

	-- FKs...
	solicitud_id INT NOT NULL
);

CREATE TABLE Entregas (
	entrega_id INT PRIMARY KEY AUTO_INCREMENT,

	solicitud BIT NOT NULL DEFAULT 0,
	carta_aceptacion BIT NOT NULL DEFAULT 0,
	ficha_identificacion BIT NOT NULL DEFAULT 0,
	reportes BIT NOT NULL DEFAULT 0,
	reporte_final BIT NOT NULL DEFAULT 0,
	informe_final BIT NOT NULL DEFAULT 0,
	evaluacion_final BIT NOT NULL DEFAULT 0,
	carta_liberacion_elemento BIT NOT NULL DEFAULT 0,

	solicitud_comentario VARCHAR(200) NOT NULL DEFAULT '',
	carta_aceptacion_comentario VARCHAR(200) NOT NULL DEFAULT '',
	ficha_identificacion_comentario VARCHAR(200) NOT NULL DEFAULT '',
	reportes_comentario VARCHAR(200) NOT NULL DEFAULT '',
	reporte_final_comentario VARCHAR(200) NOT NULL DEFAULT '',
	informe_final_comentario VARCHAR(200) NOT NULL DEFAULT '',
	evaluacion_final_comentario VARCHAR(200) NOT NULL DEFAULT '',
	carta_liberacion_comentario VARCHAR(200) NOT NULL DEFAULT '',

	-- FKs...
	solicitud_id INT NOT NULL
);

-- Restricciones de BD

ALTER TABLE Usuario ADD FOREIGN KEY (tipo_usuario_id) REFERENCES TipoUsuario(tipo_usuario_id) ON DELETE CASCADE;
ALTER TABLE Alumno ADD FOREIGN KEY (licenciatura_id) REFERENCES Licenciatura(licenciatura_id) ON DELETE CASCADE;

ALTER TABLE Solicitud ADD FOREIGN KEY (matricula) REFERENCES Alumno(matricula) ON DELETE CASCADE;
ALTER TABLE Solicitud ADD FOREIGN KEY (organizacion_id) REFERENCES Organizacion(organizacion_id) ON DELETE CASCADE;
ALTER TABLE Solicitud ADD FOREIGN KEY (tipo_solicitud_id) REFERENCES TipoSolicitud(tipo_solicitud_id) ON DELETE CASCADE;

ALTER TABLE CartaAceptacion ADD FOREIGN KEY (solicitud_id) REFERENCES Solicitud(solicitud_id) ON DELETE CASCADE;
ALTER TABLE Reporte ADD FOREIGN KEY (solicitud_id) REFERENCES Solicitud(solicitud_id) ON DELETE CASCADE;
ALTER TABLE Entregas ADD FOREIGN KEY (solicitud_id) REFERENCES Solicitud(solicitud_id) ON DELETE CASCADE;

INSERT INTO TipoUsuario
	(nombre)
VALUES
	('Desarrollador'),
	('Administrador');
    
SELECT * FROM TipoUsuario;


INSERT INTO Usuario
	(identificador, contrasena, tipo_usuario_id)
VALUES
	('root', 'Mexico.2016', 1);
    
SELECT * FROM Usuario;