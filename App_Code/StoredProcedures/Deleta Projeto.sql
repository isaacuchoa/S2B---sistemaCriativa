CREATE PROCEDURE dbo.DelProjeto

(
 @idProjeto int
)

AS

DELETE FROM Projetos
WHERE idProjeto = @idProjeto