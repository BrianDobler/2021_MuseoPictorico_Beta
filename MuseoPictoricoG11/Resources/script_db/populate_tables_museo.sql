USE [MuseoPictorico]
GO

INSERT INTO [dbo].[Sede]
           ([CantMaximaVisitantes]
           ,[Domicilio]
           ,[Horario]
           ,[Nombre])
     VALUES
           (100,'Hipolito Yrigoyen 511','8:00','Museo Superior de Bellas Artes'),
		   (50,'Av siempre viva 500','8:00','Museo Superior de Bellas Artes 2'),
		   (20,'Av siempre viva 120','8:00','Museo Superior de Bellas Artes 3'),
		   (10,'Av siempre viva 5300','8:00','Museo Superior de Bellas Artes 4'),
		   (60,'Av siempre viva 520','8:00','Museo Superior de Bellas Artes 5'),
		   (200,'Av siempre viva 5020','8:00','Museo Superior de Bellas Artes 6'),
		   (150,'Av siempre viva 5011','8:00','Museo Superior de Bellas Artes 7'),
		   (150,'Av siempre viva 5011','8:00','Museo Superior de Bellas Artes 8')
GO

INSERT INTO [dbo].[Empleado]
           ([IdSede]
           ,[Apellido]
           ,[CodigoValidacion]
           ,[Cuit]
           ,[Dni]
           ,[Domicilio]
           ,[FechaIngreso]
           ,[FechaNacimiento]
           ,[Mail]
           ,[NombreEmpleado]
           ,[Sexo]
           ,[Telefono])
     VALUES
           (1,'Perez',10,20303211237,30321123,'Avenida1 100','2010-01-01','1985-05-05','a@a.com','Juan',1,3515555555),
		   (2,'Selem',10,20303211237,30321123,'Avenida4 100','2010-01-01','1960-05-05','a@ac.com','Judith',2,3515555553)
		   (3,'Diaz',10,20303211237,30321123,'Avenida2 100','2010-01-01','1965-05-05','a@ab.com','Mariel',2,3515555554)
GO

INSERT INTO [dbo].[Usuario]
           ([IdEmpleado]
           ,[Caducidad]
           ,[Contraseña]
           ,[NombreUsuario])
     VALUES
           (2,'2025-05-01','admin','admin'),
		   (3,'2025-05-01','diaz','diaz')
GO


