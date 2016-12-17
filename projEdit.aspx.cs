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
    public Projeto objProj;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            objProj = new Projeto(int.Parse(Cache["idProjeto"].ToString()));
            if (!IsPostBack)
            {
                objProj.LoadObject();

                //Preenchendo os campos do formulário com os dados do objeto
                txtRequerente.Text = objProj.Requerente;
                txtNome.Text = objProj.Nome;
                txtValorProjeto.Text = objProj.ValorProjeto.ToString();
                txtCustoAtual.Text = objProj.GastoAtual.ToString();
                txtDataInicio.Text = objProj.DataDeInicio;
                txtDataTermino.Text = objProj.DataDeFim;
                txtDescricaoProjeto.Text = objProj.Descricao;
            }
        }
        catch (Exception Ex)
        {
            Response.Redirect("projList.aspx");
        }


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("projList.aspx");
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        objProj.Requerente      = txtRequerente.Text ;
        objProj.Nome            = txtNome.Text ;
        objProj.ValorProjeto    = float.Parse(txtValorProjeto.Text);
        objProj.GastoAtual      = float.Parse(txtCustoAtual.Text);
        objProj.DataDeInicio    = txtDataInicio.Text ;
        objProj.DataDeFim       = txtDataTermino.Text ;
        objProj.Descricao       = txtDescricaoProjeto.Text;
        objProj.Save();
        Response.Redirect("projList.aspx");
    }
}
