using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace HeroesWeb
{
    public partial class RepeaterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioSuperheroe negocioSuperheroe = new NegocioSuperheroe();
            repeaterHeroes.DataSource = negocioSuperheroe.ListarSP();
            repeaterHeroes.DataBind();
        }
    }
}