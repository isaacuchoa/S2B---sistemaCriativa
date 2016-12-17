using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class projList : System.Web.UI.Page
{
    public void projDelete(Object Sender, RepeaterCommandEventArgs e)
    {
        int id = int.Parse(e.CommandArgument.ToString());
        switch (e.CommandName)
        {
            case "Deletar":
                {
                    Projeto.Delete(id);
                    Response.Redirect("projList.aspx"); 
                    break;
                }
            case "Editar":
                {
                    Cache.Insert("idProjeto", e.CommandArgument.ToString());
                    //Response.Redirect("projEdit.aspx");
                    Server.Transfer("projEdit.aspx");
                    break;
                }
        }
    
    }

    internal DataSet DsMeuProjetos = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        #region Carrega Projetos
        if (!IsPostBack)
        {
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString());
            SqlDataAdapter DaMeusProjetos = new SqlDataAdapter("SELECT * FROM Projetos", Conn);

            try
            {
                Conn.Open();
                DaMeusProjetos.Fill(DsMeuProjetos, "MeusProjetos");
                Repeater1.DataSource = DsMeuProjetos.Tables["MeusProjetos"];

                DataBind();

            }
            catch
            {
                Conn.Close();
            }
        } //Fim do IF 
        #endregion

    }
}
