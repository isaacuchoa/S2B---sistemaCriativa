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
        Response.Redirect("projList.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Projeto newProj = new Projeto();
        newProj.DataDeFim = txtDataTermino.Text;
        newProj.DataDeInicio = txtDataInicio.Text;
        newProj.Descricao = txtDescricaoProjeto.Text;
        newProj.GastoAtual = 0;
        newProj.Nome = txtNome.Text;
        newProj.ValorProjeto = float.Parse(txtValorProjeto.Text);
        newProj.Requerente = txtRequerente.Text;
        newProj.Save();
    }
}
