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
    public Usuario objUsuario;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            objUsuario = new Usuario(int.Parse(Cache["idUsuario"].ToString()));
            if (!IsPostBack)
            {
                objUsuario.LoadObject();

                //Preenchendo os campos do formulário com os dados do objeto
                txtCelular.Text = objUsuario.Celular;
                txtEmail.Text = objUsuario.Email;
                txtLogin.Text = objUsuario.Login;
                txtNomeCompleto.Text = objUsuario.Nome;
                txtSenha.Text = objUsuario.Senha;
                txtSenha2.Text = objUsuario.Senha;
                if (objUsuario.Admin)
                    isAdmin.SelectedIndex = 0;
                else
                    isAdmin.SelectedIndex = 1;
                
                
            }
        }
        catch (Exception Ex)
        {
            Response.Redirect("userList.aspx");
        }


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("userList.aspx");
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            objUsuario.Celular = txtCelular.Text;
            objUsuario.Email = txtEmail.Text;
            objUsuario.Login = txtLogin.Text;
            objUsuario.Nome = txtNomeCompleto.Text;
            objUsuario.Senha = txtSenha2.Text;
            if (isAdmin.SelectedIndex == 0)
                objUsuario.Admin = true;
            else
                objUsuario.Admin = false;
            objUsuario.UltimoAcesso = System.DateTime.Now.ToString();
            objUsuario.Save();
            lblInfor.Text = "As informações do Usuário foram  alteradas com sucesso!";
            lblInfor.ForeColor = System.Drawing.Color.Green;
            //Response.Redirect("userList.aspx");
        }
        catch (System.Data.SqlClient.SqlException SqlEx)
        {
            lblInfor.Text = "Ocorreu um erro ao conectar com o Banco de Dados.\n";
        }
        catch (Exception Ex)
        {
            lblInfor.Text = Ex.Message;
        }
    }
}
