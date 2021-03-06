set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go



ALTER PROCEDURE [dbo].[InsProjeto]
  (
	@idProjeto int OUTPUT,
	@Requerente varchar(255), 
	@Nome varchar(50),
	@ValorProjeto float,
	@GastoAtual float,
	@DataDeInicio varchar(50),
	@DataDeFim varchar(50),
	@Descricao text
   )
AS
INSERT INTO Projetos
VALUES
(@Requerente, @Nome, @ValorProjeto,@GastoAtual,@DataDeInicio,@DataDeFim,@Descricao)

SET @idProjeto = @@IDENTITY

