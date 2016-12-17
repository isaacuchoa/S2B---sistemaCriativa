using System;
using System.Data;
using System.Data.SqlClient;
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
/// Summary description for Projeto
/// </summary>
public class Projeto
{
    #region Construtores
    public Projeto()
	{
        this.persisted = false;
    }
    public Projeto(int ID)
    {
        this.m_idProjeto =  ID;
        this.persisted = true;
    }
    #endregion

    #region Atributos
    private int m_idProjeto;
    private String m_Requerente;
    private String m_Nome;
    private String m_DataDeInicio;
    private String m_DataDeFim;
    private String m_Descricao;
    private float m_ValorProjeto;
    private float m_GastoAtual;
    private bool persisted;
    #endregion

    #region Propriedades
    public int IdProjeto
    {
        get { return m_idProjeto; }
        set { m_idProjeto = value; }
    }
    public String Nome
    {
        get { return m_Nome; }
        set { m_Nome = value; }
    }
    public float ValorProjeto
    {
        get { return m_ValorProjeto; }
        set { m_ValorProjeto = value; }
    }
    public float GastoAtual
    {
        get { return m_GastoAtual; }
        set { m_GastoAtual = value; }
    }
    public String DataDeInicio
    {
        get { return m_DataDeInicio; }
        set { m_DataDeInicio = value; }
    }
    public String DataDeFim
    {
        get { return m_DataDeFim; }
        set { m_DataDeFim = value; }
    }
    public String Descricao
    {
        get { return m_Descricao; }
        set { m_Descricao = value; }
    }
    public String Requerente
    {
        get { return m_Requerente; }
        set { m_Requerente = value; }
    }
    #endregion

    #region Variaveis
    private SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString());
    #endregion

    #region Métodos
    public void Save()
    {
        if (persisted)
        {
            this.Update();
        }
        else
        {
            this.Insert();
        }
    }

    /// <summary>
    /// O método LoadObject preenche o objeto com os dados de acordo com uma chave de identificação.
    /// </summary>
    public void LoadObject()
    {
        SqlParameter[] Parametros = GetParameters(); //Pega o array de PARAMETROS
        SqlCommand Comando = new SqlCommand("SELECT * FROM Projetos WHERE (idProjeto = @IDPROJETO)", Conn);
        SqlDataReader dr;
        Comando.Parameters.Add("@IDPROJETO", SqlDbType.Int);
        Comando.Parameters["@IDPROJETO"].Value = this.m_idProjeto;
        try
        {
            Conn.Open();
            dr = Comando.ExecuteReader();
            dr.Read();
            this.m_Requerente   = dr["Requerente"].ToString();
            this.m_Nome         = dr["Nome"].ToString();
            this.m_ValorProjeto = float.Parse(dr["ValorProjeto"].ToString());
            this.m_GastoAtual   = float.Parse(dr["GastoAtual"].ToString());
            this.m_DataDeInicio = dr["DataDeInicio"].ToString();
            this.m_DataDeFim    = dr["DataDeFim"].ToString();
            this.m_Descricao    = dr["Descricao"].ToString();
        }
        catch (Exception Ex)
        {

        }
        finally
        {
            Conn.Close();
        }
    }
    private void SetParameters(SqlParameter[] parms)
    {
        /*Esse método atribui os valores dos membros a cada
         parâmetro.*/
        parms[0].Value = this.m_idProjeto;
        parms[1].Value = this.m_Requerente;
        parms[2].Value = this.m_Nome;
        parms[3].Value = this.m_ValorProjeto;
        parms[4].Value = this.m_GastoAtual;
        parms[5].Value = this.m_DataDeInicio;
        parms[6].Value = this.m_DataDeFim;
        parms[7].Value = this.m_Descricao;

    }
    private static SqlParameter[] GetParameters()
    { 
     /*Esse método cria um array com os parâmetros 
      * correspondentes aos campos da tabela. */
     SqlParameter[] Parametros = new SqlParameter[]{
         new SqlParameter("idProjeto", DbType.Int32),
         new SqlParameter("Requerente", DbType.String),
         new SqlParameter("Nome",DbType.String),
         new SqlParameter("ValorProjeto",DbType.Double),
         new SqlParameter("GastoAtual",DbType.Double),
         new SqlParameter("DataDeInicio",DbType.String),
         new SqlParameter("DataDeFim",DbType.String),
         new SqlParameter("Descricao", DbType.String),
    };

    return Parametros;

    }  
    private bool Insert()
    {
        SqlParameter[] Parametros = GetParameters(); //Pega o array de PARAMETROS
        SqlCommand Comando = new SqlCommand("InsProjeto",  Conn);
        
        try
        {
            Comando.CommandType = CommandType.StoredProcedure;
            SetParameters(Parametros); //Atribuindo os valores dos atributos da classe a cada parâmetro
            Comando.Parameters.AddRange(Parametros); //Finalmente, adicionando os parâmetros já com seus respectivos valores a Collection de Parâmetros do SqlCommand
            Conn.Open();
            Comando.ExecuteNonQuery();
            return true; //retorna true, se tudo ocorrer nos conformes ^^
        }
        catch (Exception Ex)
        {

        }
        finally 
        {
            
            Conn.Close();
        }
        return false;
    }
    public static bool Delete(int id)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString());
        SqlCommand Comando = new SqlCommand("DelProjeto", conn);
        Comando.CommandType = CommandType.StoredProcedure;

        try 
        {
            Comando.Parameters.Add("@IDPROJETO", SqlDbType.Int);
            Comando.Parameters["@IDPROJETO"].Value = id;
            conn.Open();
            Comando.ExecuteNonQuery();
            return true;
        }
        catch (Exception Ex)
        {}
        finally 
        {
            conn.Close();
        }

        return false;
    }
    private bool Update()
    {
        //this.LoadObject();
        SqlParameter[] Parametros = GetParameters();
        SqlCommand Comando = new SqlCommand("UpdProjeto", Conn);
        SetParameters(Parametros);

        try 
        {
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddRange(Parametros);
            Conn.Open();
            Comando.ExecuteNonQuery();
            return true; //retorna TRUE, se tudo ocorrer nos conformes ^^
        }
        catch  (Exception Ex)
        { }
        finally 
        {
            Conn.Close();
        }
        return false;
    }
    #endregion
}
