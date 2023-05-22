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
    public partial class DetalleHeroe : System.Web.UI.Page
    {
        public List<Superheroe> ListaHeroes { get; set; }
        public Superheroe Heroe { get; set; }
        public String UrlImagen { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioSuperheroe negocioSuperheroe = new NegocioSuperheroe();
            ListaHeroes = negocioSuperheroe.ListarSP();
            
            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                Heroe = ListaHeroes.Find(heroe => heroe.Id == id);
                ListaHeroes.Clear();
                ListaHeroes.Add(Heroe);
                gridHeroes.DataSource = ListaHeroes;
                gridHeroes.DataBind();
                UrlImagen = Heroe.Url;
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}