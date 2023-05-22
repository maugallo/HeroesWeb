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
    public partial class Tarjetas : System.Web.UI.Page
    {
        //Inicializo una property:
        public List<Superheroe> ListaHeroes {get; set;}
        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioSuperheroe negocioSuperheroe = new NegocioSuperheroe();
            ListaHeroes = negocioSuperheroe.ListarSP();
            /*
             Principal diferencia entre el Foreach y el Repeater, es:
             - El repeater proporciona un código un poco más claro y legible.
             - Ambos tienen una sintáxis distinta.
             - El foreach, por un lado, solo puede enviar valores (mediante url o sessions) hacia otras
               páginas, mientras que el Repeater puede enviar valores hacia la propia página mediante el
               uso de, por ejemplo, botones (haciendo click en ellos).
             */
        }
    }
}