USE SPACEOPS_PROGRAIV
GO

DECLARE @SU_CORREO VARCHAR(100) = 'francisco.lizano@uamcr.net'
DECLARE @SU_NOMBRE VARCHAR(100) = 'Francisco A Lizano Guzmán'


IF (
	@SU_CORREO='' OR @SU_NOMBRE=''
   )
BEGIN 
	SELECT 'ERROR!!!! DEFINA SUS DATOS PERSONALES' AS ERROR_DATOS_NO_VALIDOS
END
ELSE
BEGIN
	-----------------------INSERTA REGISTROS BASICOS DE USUARIOS
	INSERT INTO Usuarios
	(
	Correo, Nombre, Especialidad, Estado, Password
	)
	SELECT 
	@SU_CORREO,@SU_NOMBRE,'desarrollo_web','A','123'

	INSERT INTO Usuarios
	(
	Correo, Nombre, Especialidad, Estado, Password
	)
	SELECT 
	'kevin.montes@uamcr.net','Kevin Montes Varela','desarrollo_web','A','123'

	INSERT INTO Usuarios
	(
	Correo, Nombre, Especialidad, Estado, Password
	)
	SELECT 
	'kenneth.montes@uamcr.net','Kenneth Montes Varela','desarrollo_web','I','123'


	-----------------------INSERTA REGISTROS BASICOS DE ESTADOS DE TAREAS
	INSERT INTO Estados_Tareas
	(
	Estado
	)
	SELECT
	'Pendiente'

	INSERT INTO Estados_Tareas
	(
	Estado
	)
	SELECT
	'En Proceso'

	INSERT INTO Estados_Tareas
	(
	Estado
	)
	SELECT
	'Finalizada'


	-----------------------INSERTA REGISTROS BASICOS DE PRIORIDADES DE TAREAS
	INSERT INTO Prioridades_Tareas
	(
	Prioridad
	)
	SELECT 
	'Urgente'

	INSERT INTO Prioridades_Tareas
	(
	Prioridad
	)
	SELECT 
	'Alta'

	INSERT INTO Prioridades_Tareas
	(
	Prioridad
	)
	SELECT 
	'Normal'

	INSERT INTO Prioridades_Tareas
	(
	Prioridad
	)
	SELECT 
	'Baja'


	-----------------------INSERTA REGISTROS BASICOS DE ACTIVIDADES DE TAREAS
	INSERT INTO Actividades_Tareas
	(
	Actividad
	)
	SELECT 
	'Requerimientos'

	INSERT INTO Actividades_Tareas
	(
	Actividad
	)
	SELECT 
	'Diseño'

	INSERT INTO Actividades_Tareas
	(
	Actividad
	)
	SELECT 
	'Desarrollo'

	INSERT INTO Actividades_Tareas
	(
	Actividad
	)
	SELECT 
	'Implementación'

	INSERT INTO Actividades_Tareas
	(
	Actividad
	)
	SELECT 
	'Pruebas'

	INSERT INTO Actividades_Tareas
	(
	Actividad
	)
	SELECT 
	'Documentación'

	DECLARE @FECHA DATETIME = GETDATE()
	DECLARE @FECHA_FIN DATETIME = GETDATE() + 15
	
	--EXEC USP_Insertar_Tareas @Titulo, @Descripcion, @Fecha_Inicio, @Fecha_Finalizacion, @IdUsuario, @IdEstado, @IdPrioridad, @IdActividad
	EXEC USP_Insertar_Tareas 'Diseño de Prototipos', 'Diseño de prototipos del sistema de gestión de tareas', @FECHA, @FECHA_FIN, 1, 1, 1, 1
	EXEC USP_Insertar_Tareas 'Desarrollo de Prototipos', 'Desarrollo de prototipos del sistema de gestión de tareas',  @FECHA, @FECHA_FIN, 1, 1, 1, 1
	EXEC USP_Insertar_Tareas 'Pruebas de Prototipos', 'Ejecución de Pruebas de prototipos del sistema de gestión de tareas',  @FECHA, @FECHA_FIN, 1, 1, 1, 1

	EXEC USP_Insertar_Tareas 'Diseño de Prototipos SpaceOps', 'Diseño de prototipos del sistema de gestión de tareas SpaceOps', @FECHA, @FECHA_FIN, 2, 1, 1, 1
	EXEC USP_Insertar_Tareas 'Desarrollo de Prototipos SpaceOps', 'Desarrollo de prototipos del sistema de gestión de tareas SpaceOps',  @FECHA, @FECHA_FIN, 2, 1, 1, 1
	EXEC USP_Insertar_Tareas 'Pruebas de Prototipos SpaceOps', 'Ejecución de Pruebas de prototipos del sistema de gestión de tareas SpaceOps',  @FECHA, @FECHA_FIN, 2, 1, 1, 1

END
GO



SELECT * FROM Usuarios
SELECT * FROM Estados_Tareas
SELECT * FROM Prioridades_Tareas
SELECT * FROM Actividades_Tareas
SELECT * FROM Tareas
SELECT * FROM Auditoria