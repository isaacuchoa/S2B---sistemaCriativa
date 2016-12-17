using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for Solicitacao
/// </summary>
public class Solicitacao
{
    #region Atributos
    private int m_idSolicitacao;
    private int m_idUsuario;
    private int m_Progresso;
    private String m_NomeDoCriador;
    private String m_DataDaSolicitacao;
    private String m_DataDeEntrega;
    private String m_Titulo;
    private String m_Status;
    private String m_Prioridade;
    private String m_Categoria;
    private String m_Descricao;
    private bool persisted;
    #endregion

    #region Construtores
    public Solicitacao()
	{
        this.persisted = false;
    }
    public Solicitacao(int ID)
    {
        this.m_idSolicitacao = ID;
        this.persisted = true;
    }
    #endregion
}
