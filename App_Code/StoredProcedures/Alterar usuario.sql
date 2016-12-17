GO

CREATE PROCEDURE [dbo].[UpdUsuario]
	(
	@idUsuario int,
	@Login varchar(20),
	@Senha varchar(20),
	@Nome varchar(60),
	@Email varchar(60),
	@Celular varchar(15),
	@Admin bit,
	@Ultimo_Acesso varchar(30)
	)
AS
	UPDATE Usuarios SET
		Login = @Login,
		Senha = @Senha,
		Nome = @Nome,
		Email = @Email,
		Celular = @Celular, 
		Admin = @Admin, 
		Ultimo_Acesso = @Ultimo_Acesso
	WHERE idUsuario = @idUsuario


