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

public partial class testes_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        #region Carrega Projetos

            DataSet DsMeuProjetos = new DataSet();
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString());
            SqlDataAdapter DaMeusProjetos = new SqlDataAdapter("SELECT * FROM Projetos", Conn);

            try
            {
                Conn.Open();
                DaMeusProjetos.Fill(DsMeuProjetos, "MeusProjetos");
                GridView1.DataSource = DsMeuProjetos.Tables["MeusProjetos"];
                DataBind();
                for (int i = 1; i <= 999999999; i++)
                {
                    i++;
                }

            }
            catch
            {
                Conn.Close();
            }
 
        #endregion
    }
}
