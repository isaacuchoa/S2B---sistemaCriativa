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
using System.Xml;
using System.Data.SqlClient;

public partial class main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (! IsPostBack) 
        {
            try
            {
                SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString());
                SqlCommand Comando = new SqlCommand("UPDATE  Usuarios SET Ultimo_Acesso = '" + System.DateTime.Now + "' WHERE (idUsuario= " + (int)Session["idUsuario"] + ")", Conn);
                Conn.Open();
                Comando.ExecuteNonQuery();
                Conn.Close();
            }
            catch { }
        }
    }
}
