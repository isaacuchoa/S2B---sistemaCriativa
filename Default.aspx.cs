using System;
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

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btLogin_Click(object sender, EventArgs e)
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString());
        SqlCommand Comando = new SqlCommand("SELECT * FROM Usuarios WHERE (Login = @LOGIN AND Senha = @SENHA)", Conn);
        SqlDataReader DR;
        Comando.Parameters.Add("@LOGIN", SqlDbType.VarChar);
        Comando.Parameters.Add("@SENHA", SqlDbType.VarChar);

        try
        {
            Conn.Open();
            Comando.Parameters["@LOGIN"].Value = txtLogin.Text;
            Comando.Parameters["@SENHA"].Value = txtSenha.Text;
            DR = Comando.ExecuteReader();
            DR.Read();
            Session["idUsuario"] =  DR["idUsuario"];
            Session["Login"] = DR["Login"];
            Session["Nome"] = DR["Nome"];
            Session["Email"] =  DR["Email"];
            Session["Senha"] =  DR["Senha"];
            Session["Celular"] =  DR["Celular"];
            Session["Admin"] =  DR["Admin"];
            Session["Ultimo_Acesso"] = DR["Ultimo_Acesso"];
            Session.Timeout = 30;
            Response.Redirect("main.aspx");

        }
        catch (System.InvalidOperationException) {
            lblFalhaDeLogin.Text = "Login e/ou Senha incorretos."; 
            }
        catch (Exception Ex)
        {
            lblFalhaDeLogin.Text = Ex.Message;
        }
        finally 
        {
            Conn.Close();
        }

        
    }
}
