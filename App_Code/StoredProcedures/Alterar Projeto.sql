set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

ALTER PROCEDURE [dbo].[UpdProjeto]
	(
	@idProjeto int,
	@Requerente varchar(255),
	@Nome varchar(60),
	@ValorProjeto float,
	@GastoAtual float,
	@DataDeInicio varchar(50),
	@DataDeFim varchar(50),
	@Descricao text
	)
AS
	UPDATE Projetos SET
		Requerente = @Requerente,
		Nome = @Nome,
		ValorProjeto = @ValorProjeto,
		GastoAtual = @GastoAtual,
		DataDeInicio = @DataDeInicio, 
		DataDeFim = @DataDeFim, 
		Descricao = @Descricao
	WHERE idProjeto = @idProjeto

