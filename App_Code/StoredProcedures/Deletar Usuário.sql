set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go


ALTER PROCEDURE [dbo].[DelUsuario]

(
 @idUsuario int
)

AS

DELETE FROM Usuarios
WHERE idUsuario = @idUsuario
