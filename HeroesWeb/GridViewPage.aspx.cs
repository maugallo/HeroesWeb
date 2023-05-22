using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace HeroesWeb
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			NegocioSuperheroe negocioSuperheroe = new NegocioSuperheroe();
			GridHeroes.DataSource = negocioSuperheroe.ListarSP();
			GridHeroes.DataBind();
		}
	}
}