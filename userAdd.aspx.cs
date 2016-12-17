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

public partial class projList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("userList.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool eAdmin;
        if (isAdmin.SelectedValue == "True")
            eAdmin = true;
        else
            eAdmin = false;

        Usuario objUsuario = new Usuario();
        objUsuario.Admin = eAdmin;
        objUsuario.Celular = txtCelular.Text;
        objUsuario.Email = txtEmail.Text;
        objUsuario.Login = txtLogin.Text;
        objUsuario.Nome = txtNomeCompleto.Text;
        objUsuario.Senha = txtSenha2.Text;
        objUsuario.UltimoAcesso = "";
        objUsuario.Save();

    }
}
