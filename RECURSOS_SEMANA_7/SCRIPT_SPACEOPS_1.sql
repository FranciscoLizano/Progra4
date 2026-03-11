USE master
GO

CREATE DATABASE SPACEOPS_PROGRAIV
GO


USE SPACEOPS_PROGRAIV
GO

CREATE TABLE [dbo].[Usuarios](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Correo] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Especialidad] [nvarchar](150) NOT NULL,
	[Estado] [char](1) NOT NULL,
	[Password] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Auditoria](
	[Id_Auditoria] [int] IDENTITY(1,1) NOT NULL,
	[Id_Usuario] [int] NOT NULL,
	[Accion] [char](1) NOT NULL,
	[Descripción] [nvarchar](500) NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Auditoria] PRIMARY KEY CLUSTERED 
(
	[Id_Auditoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Auditoria]  WITH CHECK ADD  CONSTRAINT [FK_Auditoria_Usuarios] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuarios] ([Id_Usuario])
GO

ALTER TABLE [dbo].[Auditoria] CHECK CONSTRAINT [FK_Auditoria_Usuarios]
GO

CREATE TABLE [dbo].[Estados_Tareas](
	[Id_Estado] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Estados_Tareas] PRIMARY KEY CLUSTERED 
(
	[Id_Estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Prioridades_Tareas](
	[Id_Prioridad] [int] IDENTITY(1,1) NOT NULL,
	[Prioridad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Prioridades_Tareas] PRIMARY KEY CLUSTERED 
(
	[Id_Prioridad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Actividades_Tareas](
	[Id_Actividad] [int] IDENTITY(1,1) NOT NULL,
	[Actividad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Actividades_Tareas] PRIMARY KEY CLUSTERED 
(
	[Id_Actividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



CREATE TABLE [dbo].[Tareas](
	[Id_Tarea] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](500) NOT NULL,
	[Fecha_Registro] [datetime] NOT NULL,
	[Fecha_Inicio] [date] NOT NULL,
	[Fecha_Finalizacion] [date] NOT NULL,
	[Id_Usuario] [int] NOT NULL,
	[Id_Estado] [int] NOT NULL,
	[Id_Prioridad] [int] NOT NULL,
	[Id_Actividad] [int] NOT NULL,
	
CONSTRAINT [PK_Tareas] PRIMARY KEY CLUSTERED 
(
	[Id_Tarea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Tareas]  WITH CHECK ADD  CONSTRAINT [FK_Tareas_Usuarios] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuarios] ([Id_Usuario])
GO

ALTER TABLE [dbo].[Tareas] CHECK CONSTRAINT [FK_Tareas_Usuarios]
GO


ALTER TABLE [dbo].[Tareas]  WITH CHECK ADD  CONSTRAINT [FK_Tareas_Estados_Tareas] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[Estados_Tareas] ([Id_Estado])
GO

ALTER TABLE [dbo].[Tareas] CHECK CONSTRAINT [FK_Tareas_Estados_Tareas]
GO


ALTER TABLE [dbo].[Tareas]  WITH CHECK ADD  CONSTRAINT [FK_Tareas_Prioridades_Tareas] FOREIGN KEY([Id_Prioridad])
REFERENCES [dbo].[Prioridades_Tareas] ([Id_Prioridad])
GO

ALTER TABLE [dbo].[Tareas] CHECK CONSTRAINT [FK_Tareas_Prioridades_Tareas]
GO

ALTER TABLE [dbo].[Tareas]  WITH CHECK ADD  CONSTRAINT [FK_Tareas_Actividades_Tareas] FOREIGN KEY([Id_Actividad])
REFERENCES [dbo].[Actividades_Tareas] ([Id_Actividad])
GO

ALTER TABLE [dbo].[Tareas] CHECK CONSTRAINT [FK_Tareas_Actividades_Tareas]
GO




----PROCEDIMIENTOS CRUD INICIO SESION Y USUARIOS
CREATE PROCEDURE [dbo].[USP_InicioSesion_Usuarios]
(
@Correo varchar(50),
@Password varchar(25)
)
AS BEGIN 
DECLARE @IdUsuario int
DECLARE @Estado char(1)
BEGIN TRY

	IF EXISTS(SELECT Id_Usuario FROM Usuarios WHERE Correo=@Correo and Password=@Password) 
	BEGIN
		SELECT @IdUsuario=Id_Usuario, @Estado=Estado FROM Usuarios WHERE Correo=@Correo and Password=@Password

		IF @Estado='A'
		BEGIN
			SELECT @IdUsuario

			-----------------------PARA EL CONTROL DE AUDITORIA DEL SISTEMA-------------------------------------------
			DECLARE @DSC VARCHAR(MAX)
			DECLARE @USRNOM VARCHAR(300)
			DECLARE @ACC CHAR(1)

			SELECT @USRNOM = Nombre FROM Usuarios Where Id_Usuario=@IdUsuario
			SET @DSC = 'Inicio de Sesión del Usuario: ' + CONVERT(VARCHAR,@USRNOM)
			SET @ACC = 'I'

			INSERT INTO Auditoria
			(
			Id_Usuario, Accion, Descripción, Fecha
			)
			SELECT
			@IdUsuario, @ACC, RTRIM(LTRIM(@DSC)) , GETDATE()
			-----------------------PARA EL CONTROL DE AUDITORIA DEL SISTEMA-------------------------------------------

		END
		ELSE
		BEGIN
			SELECT -1
		END
	END
	ELSE
	BEGIN
		SELECT 0
	END
END TRY 
BEGIN CATCH
	SELECT 0
END CATCH
END
GO

CREATE PROCEDURE [dbo].[USP_CierraSesion_Usuarios]
(
@IdUsuario INT
)
AS BEGIN 
DECLARE @Estado char(1)
BEGIN TRY

	IF EXISTS(SELECT Id_Usuario FROM Usuarios WHERE Id_Usuario=@IdUsuario) 
	BEGIN
			SELECT @IdUsuario

			-----------------------PARA EL CONTROL DE AUDITORIA DEL SISTEMA-------------------------------------------
			DECLARE @DSC VARCHAR(MAX)
			DECLARE @USRNOM VARCHAR(300)
			DECLARE @ACC CHAR(1)

			SELECT @USRNOM = Nombre FROM Usuarios Where Id_Usuario=@IdUsuario
			SET @DSC = 'Cierra de Sesión del Usuario: ' + CONVERT(VARCHAR,@USRNOM)
			SET @ACC = 'I'

			INSERT INTO Auditoria
			(
			Id_Usuario, Accion, Descripción, Fecha
			)
			SELECT
			@IdUsuario, @ACC, RTRIM(LTRIM(@DSC)) , GETDATE()
			-----------------------PARA EL CONTROL DE AUDITORIA DEL SISTEMA-------------------------------------------
	END
	ELSE
	BEGIN
		SELECT 0
	END
END TRY 
BEGIN CATCH
	SELECT 0
END CATCH
END
GO

CREATE PROCEDURE [dbo].[USP_Informacion_Usuarios]
(
@IdUsuario INT
)
AS BEGIN 

SELECT [Id_Usuario]
      ,[Nombre]
	  ,[Especialidad]
	  ,[Correo]
	  ,CASE LTRIM(RTRIM([Estado])) WHEN 'A' THEN 'Activo' ELSE 'Inactivo' END [Estado]
	  ,[Password]
  FROM [dbo].[Usuarios]
  WHERE [Id_Usuario]=@IdUsuario
END
GO

CREATE PROCEDURE [dbo].[USP_Insertar_Usuarios]
(
@Nombre varchar(100),
@Especialidad varchar(150),
@Correo varchar(50),
@Estado varchar(10),
@Password varchar(25)
)
AS BEGIN 
BEGIN TRY
	IF NOT EXISTS(SELECT Id_Usuario FROM Usuarios WHERE Correo=@Correo)
	BEGIN 
		INSERT INTO  [dbo].[Usuarios]
		(
			   [Nombre]
			  ,[Especialidad]
			  ,[Estado]
			  ,[Correo]
			  ,[Password]
		)
		VALUES
		(
			@Nombre,
			@Especialidad,
			'A',
			@Correo,
			@Password
		)
		SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		SELECT -1
	END
	
END TRY
BEGIN CATCH
		SELECT 0
END CATCH
END
GO


----PROCEDIMIENTOS CRUD AUDITORIA
CREATE PROCEDURE [dbo].[USP_Filtrar_Auditoria]
(
@Usuario int,
@Accion nvarchar(10),
@Desde DATETIME,
@Hasta DATETIME
)
AS BEGIN 
SET DATEFORMAT DMY
SELECT 
	   [Fecha] as [Fecha / Hora]
      ,CASE LTRIM(RTRIM([Accion])) WHEN 'A' THEN 'Actualizar' WHEN 'E' THEN 'Eliminar' WHEN 'I' THEN 'Insertar' ELSE 'N/A' END [Accion]
      ,[Descripción]
      
  FROM [dbo].[Auditoria]
  WHERE Id_Usuario=@Usuario 
		AND 
			(
				CAST(Fecha as DATE)>=CAST(@Desde AS DATE) 
					AND 
				CAST(Fecha as DATE)<=CAST(@Hasta AS DATE) 
			 )
		AND Accion = CASE LTRIM(RTRIM(@Accion)) WHEN 'T' THEN Accion ELSE @Accion END
END
GO

----PROCEDIMIENTOS CRUD ESTADOS DE TAREAS
CREATE PROCEDURE [dbo].[USP_Listar_Estados_Tareas]
AS BEGIN
SELECT [Id_Estado]
      ,[Estado]
  FROM [dbo].[Estados_Tareas]
END
GO

----PROCEDIMIENTOS CRUD PRIORIDADES DE TAREAS
CREATE PROCEDURE [dbo].[USP_Listar_Prioridades_Tareas]
AS BEGIN
SELECT [Id_Prioridad]
      ,[Prioridad]
  FROM [dbo].[Prioridades_Tareas]
END
GO

----PROCEDIMIENTOS CRUD ACTIVIDADES DE TAREAS
CREATE PROCEDURE [dbo].[USP_Listar_Actividades_Tareas]
AS BEGIN
SELECT [Id_Actividad]
      ,[Actividad]
  FROM [dbo].[Actividades_Tareas]
END
GO


----PROCEDIMIENTOS CRUD TAREAS

CREATE PROCEDURE [dbo].[USP_Listar_Tareas]
(
@IdUsuario int,
@Titulo VARCHAR(50),
@Estado int
)
AS BEGIN 
  SELECT TASK.[Id_Tarea] AS [Id_Tarea]
      ,TASK.[Titulo] AS [Titulo]
      ,CAST(TASK.[Fecha_Inicio] AS date) AS [Fecha_Inicio]
	  ,CAST(TASK.[Fecha_Finalizacion] AS date) AS [Fecha_Finalizacion]
	  ,PRI.[Prioridad] AS [Prioridad]
	  ,ACT.[Actividad] AS [Actividad]
	  ,EST.[Estado] AS [Estado]
  FROM [dbo].[Tareas] TASK
  INNER JOIN Prioridades_Tareas PRI ON PRI.Id_Prioridad = TASK.Id_Prioridad
  INNER JOIN Estados_Tareas EST ON EST.Id_Estado = TASK.Id_Estado
  INNER JOIN Actividades_Tareas ACT ON ACT.Id_Actividad = TASK.Id_Actividad
  WHERE LTRIM(RTRIM(TASK.[Titulo])) LIKE '%' + LTRIM(RTRIM(@Titulo)) +'%'
		AND TASK.[Id_Usuario]=@IdUsuario 
		AND TASK.[Id_Estado] = CASE WHEN @Estado = 0 THEN TASK.[Id_Estado] ELSE @Estado END
END
GO

CREATE PROCEDURE [dbo].[USP_Informacion_Tareas]
(
@IdTarea INT
)
AS BEGIN 
  SELECT TASK.[Id_Tarea] AS [Id_Tarea]
      ,TASK.[Titulo] AS [Titulo]
	  ,TASK.[Descripcion] AS [Descripcion]
      ,CAST(TASK.[Fecha_Inicio] AS date) AS [Fecha_Inicio]
	  ,CAST(TASK.[Fecha_Finalizacion] AS date) AS [Fecha_Finalizacion]
	  ,TASK.[Id_Prioridad] AS [Prioridad]
	  ,TASK.[Id_Actividad] AS [Actividad]
	  ,TASK.[Id_Estado] AS [Estado]
  FROM [dbo].[Tareas] TASK
  WHERE TASK.[Id_Tarea]=@IdTarea 
END
GO

CREATE PROCEDURE [dbo].[USP_Insertar_Tareas]
(
@Titulo varchar(50),
@Descripcion varchar(50),
@Fecha_Inicio datetime,
@Fecha_Finalizacion datetime,
@IdUsuario int,
@IdEstado int,
@IdPrioridad int,
@IdActividad int
)
AS BEGIN 
BEGIN TRY
	IF NOT EXISTS(SELECT Id_Tarea FROM Tareas WHERE Titulo=@Titulo AND Id_Usuario=@IdUsuario)
	BEGIN
		INSERT INTO  [dbo].[Tareas]
		( 
			[Titulo], 
			[Descripcion], 
			[Fecha_Registro], 
			[Fecha_Inicio], 
			[Fecha_Finalizacion], 
			[Id_Usuario], 
			[Id_Estado], 
			[Id_Prioridad], 
			[Id_Actividad]
		)
		VALUES
		(
			@Titulo,
			@Descripcion,
			GETDATE(),
			CAST(@Fecha_Inicio AS date),
			CAST(@Fecha_Finalizacion AS date),
			@IdUsuario,
			@IdEstado,
			@IdPrioridad,
			@IdActividad
		)

		SELECT @@IDENTITY

		-----------------------PARA EL CONTROL DE AUDITORIA DEL SISTEMA-------------------------------------------
		DECLARE @DSC VARCHAR(MAX)
		DECLARE @ACC CHAR(1)
		SET @DSC = 'Inserta la información de la Tarea ' + RTRIM(LTRIM(@Titulo)) + ' | Descripción: ' + RTRIM(LTRIM(@Descripcion)) + '. Id Registro: ' + CONVERT(VARCHAR,@@IDENTITY)
		SET @ACC = 'I'

		INSERT INTO Auditoria
		(
		Id_Usuario, Accion, Descripción, Fecha
		)
		SELECT
		@IdUsuario, @ACC, RTRIM(LTRIM(@DSC)) , GETDATE()
		-----------------------PARA EL CONTROL DE AUDITORIA DEL SISTEMA-------------------------------------------
	END
	ELSE
	BEGIN
		SELECT -1
	END
END TRY
BEGIN CATCH
	SELECT 0
END CATCH
END
GO

CREATE PROCEDURE [dbo].[USP_Modificar_Tareas]
(
@IdTarea int,
@Titulo varchar(50),
@Descripcion varchar(50),
@Fecha_Inicio datetime,
@Fecha_Finalizacion datetime,
@IdUsuario int,
@IdEstado int,
@IdPrioridad int,
@IdActividad int
)
AS BEGIN 
BEGIN TRY
SET DATEFORMAT DMY
	IF NOT EXISTS(SELECT Id_Tarea FROM Tareas WHERE Titulo=@Titulo AND Id_Usuario=@IdUsuario AND Id_Tarea NOT IN (@IdTarea))
	BEGIN
		UPDATE [dbo].[Tareas]
		SET
			   [Titulo]=@Titulo
			  ,[Descripcion]=@Descripcion
			  ,[Fecha_Inicio]=CAST(@Fecha_Inicio AS DATE)
			  ,[Fecha_Finalizacion]=CAST(@Fecha_Finalizacion AS DATE)
			  ,[Id_Estado]=@IdEstado
			  ,[Id_Actividad]=@IdActividad
			  ,[Id_Prioridad]=@IdPrioridad
		WHERE Id_Tarea=@IdTarea

		SELECT @IdTarea
		-----------------------PARA EL CONTROL DE AUDITORIA DEL SISTEMA-------------------------------------------
		DECLARE @DSC VARCHAR(MAX)
		DECLARE @ACC CHAR(1)
		SET @DSC = 'Actualiza la información de la Tarea ' + RTRIM(LTRIM(@Titulo)) + ' | Descripción: ' + RTRIM(LTRIM(@Descripcion)) + '. Id Registro: ' + CONVERT(VARCHAR,@IdTarea)
		SET @ACC = 'A'

		INSERT INTO Auditoria
		(
		Id_Usuario, Accion, Descripción, Fecha
		)
		SELECT
		@IdUsuario, @ACC, RTRIM(LTRIM(@DSC)) , GETDATE()
		-----------------------PARA EL CONTROL DE AUDITORIA DEL SISTEMA-------------------------------------------
	END
	ELSE
	BEGIN
		SELECT -1
	END
END TRY
BEGIN CATCH
	SELECT 0
END CATCH


END
GO

CREATE PROCEDURE [dbo].[USP_Eliminar_Tareas]
(
@IdTarea int,
@IdUsuario int
)
AS BEGIN 
BEGIN TRY
	IF EXISTS(SELECT Id_Tarea FROM Tareas WHERE Id_Tarea=@IdTarea)
	BEGIN
		-----------------------PARA EL CONTROL DE AUDITORIA DEL SISTEMA-------------------------------------------
		DECLARE @DSC VARCHAR(MAX)
		DECLARE @NOMBRE VARCHAR(200)
		DECLARE @ACC CHAR(1)

		SELECT @NOMBRE=RTRIM(LTRIM(Titulo))  FROM Tareas WHERE Id_Tarea=@IdTarea

		SET @DSC = 'Elimina la información de la tarea ' + RTRIM(LTRIM(@NOMBRE)) + '. Id Registro: ' + CONVERT(VARCHAR,@IdTarea)
		SET @ACC = 'E'

		INSERT INTO Auditoria
		(
		Id_Usuario, Accion, Descripción, Fecha
		)
		SELECT
		@IdUsuario, @ACC, RTRIM(LTRIM(@DSC)) , GETDATE()
		-----------------------PARA EL CONTROL DE AUDITORIA DEL SISTEMA-------------------------------------------

		DELETE FROM Tareas WHERE Id_Tarea=@IdTarea	
		SELECT @IdTarea
	END
	ELSE
	BEGIN
		SELECT -1
	END
END TRY
BEGIN CATCH
	SELECT 0
END CATCH


END
GO


----PROCEDIMIENTOS CRUD PANEL DE CONTROL
CREATE PROCEDURE [dbo].[USP_Resumen_Estado_Tareas]
(
@Id_Usuario int
)
AS BEGIN
	
	DECLARE @Tareas INT
	DECLARE @Pendientes INT
	DECLARE @Proceso INT
	DECLARE @Finalizadas INT

	SET @Tareas= (SELECT ISNULL(COUNT(Id_Tarea),0) FROM Tareas WHERE Id_Usuario=@Id_Usuario)
	SET @Pendientes= (SELECT ISNULL(COUNT(TASK.Id_Tarea),0) FROM Tareas TASK INNER JOIN Estados_Tareas EST ON EST.Id_Estado=TASK.Id_Estado WHERE EST.Estado='Pendiente' AND TASK.Id_Usuario=@Id_Usuario)
	SET @Proceso= (SELECT ISNULL(COUNT(TASK.Id_Tarea),0) FROM Tareas TASK INNER JOIN Estados_Tareas EST ON EST.Id_Estado=TASK.Id_Estado WHERE EST.Estado='En Proceso' AND TASK.Id_Usuario=@Id_Usuario)
	SET @Finalizadas= (SELECT ISNULL(COUNT(TASK.Id_Tarea),0) FROM Tareas TASK INNER JOIN Estados_Tareas EST ON EST.Id_Estado=TASK.Id_Estado WHERE EST.Estado='Finalizada' AND TASK.Id_Usuario=@Id_Usuario)

	SELECT @Tareas AS Tareas, @Pendientes AS Pendientes, @Proceso AS EnProceso, @Finalizadas AS Finalizadas

END
GO

CREATE PROCEDURE [dbo].[USP_Listar_Cantidad_TareasXEstado]
(
@Id_Usuario int
)
AS BEGIN
		SELECT  EST.Estado, COUNT(TASK.Id_Tarea) AS Total
		FROM Estados_Tareas EST
		LEFT JOIN Tareas TASK ON EST.Id_Estado=TASK.Id_Estado AND TASK.Id_Usuario = @Id_Usuario -- Filtra dentro del JOIN para no excluir prioridades sin tareas
		GROUP BY EST.Estado
		ORDER BY EST.Estado
END
GO

CREATE PROCEDURE [dbo].[USP_Listar_Cantidad_TareasXPrioridad]
(
@Id_Usuario int
)
AS BEGIN
		SELECT PRI.Prioridad, 
       COUNT(TASK.Id_Tarea) AS Total
		FROM Prioridades_Tareas PRI
		LEFT JOIN Tareas TASK  ON PRI.Id_Prioridad = TASK.Id_Prioridad AND TASK.Id_Usuario = @Id_Usuario -- Filtra dentro del JOIN para no excluir prioridades sin tareas
		GROUP BY PRI.Prioridad
		ORDER BY PRI.Prioridad;
END
GO

