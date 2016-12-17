using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class userList : System.Web.UI.Page
{
    public void FuncoesDeUsuario(Object Sender, RepeaterCommandEventArgs e)
    {
        int id = int.Parse(e.CommandArgument.ToString());
        switch (e.CommandName)
        {
            case "Deletar":
                {
                    Usuario.Delete(id);
                    Response.Redirect("userList.aspx");
                    //Projeto.Delete(id);
                    break;
                }
            case "Editar":
                {
                    Cache.Insert("idUsuario", e.CommandArgument.ToString());
                    //Response.Redirect("projEdit.aspx");
                    Server.Transfer("userEdit.aspx");
                    break;
                }
        }

    }

    protected DataSet DsMeuProjetos = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        #region Carrega Usuários
        if (!IsPostBack)
        {
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString());
            SqlDataAdapter DaMeusProjetos = new SqlDataAdapter("SELECT * FROM Usuarios", Conn);

            try
            {
                Conn.Open();
                DaMeusProjetos.Fill(DsMeuProjetos);
                Repeater1.DataSource = DsMeuProjetos.Tables[0];
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
