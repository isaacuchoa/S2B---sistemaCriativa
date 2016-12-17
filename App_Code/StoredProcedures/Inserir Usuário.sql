USE [s2b]
go

CREATE PROCEDURE [dbo].[InsUsuario]
  (
	@idUsuario int OUTPUT,
	@Login varchar(20), 
	@Senha varchar(20),
	@Nome varchar(60),
	@Email varchar(60),
	@Celular varchar(15),
	@Admin bit,
	@Ultimo_Acesso varchar(30)
   )
AS
INSERT INTO Usuarios
VALUES
(@Login,@Senha,@Nome,@Email,@Celular,@Admin,@Ultimo_Acesso )

SET @idUsuario = @@IDENTITY


