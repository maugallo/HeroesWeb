using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;

namespace Negocio
{
    public class NegocioSuperheroe
    {
        public List<Superheroe> Listar()
        {
            AccesoDatosClass accesoDatos = new AccesoDatosClass();
            List<Superheroe> listaHeroes = new List<Superheroe>();
            try
            {
                accesoDatos.SetearConsulta("SELECT * FROM Superheroe");
                accesoDatos.EjecutarConsulta();
                accesoDatos.Lector = accesoDatos.Comando.ExecuteReader();
                while (accesoDatos.Lector.Read())
                {
                    Superheroe heroeRegistro = new Superheroe((int)accesoDatos.Lector["id"], (string)accesoDatos.Lector["alias"], (string)accesoDatos.Lector["nombre"], (string)accesoDatos.Lector["apellido"], (int)accesoDatos.Lector["edad"], (string)accesoDatos.Lector["universo"]);
                    //El '!' invierte la condición: Si accesoDatos.Lector["url"] NO devuelve una exception DBNull, significa que se le puede asignar al objeto heroeRegistro.
                    if (!(accesoDatos.Lector["poder"] is DBNull))
                    {
                        heroeRegistro.Poder = (string)accesoDatos.Lector["poder"];
                    }
                    //El '!' invierte la condición: Si accesoDatos.Lector["url"] NO devuelve una exception DBNull, significa que se le puede asignar al objeto heroeRegistro.
                    if (!(accesoDatos.Lector["url"] is DBNull))
                    {
                        heroeRegistro.Url = (string)accesoDatos.Lector["url"];
                    }
                    listaHeroes.Add(heroeRegistro);
                }
                return listaHeroes;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error - Exception: " + ex.Message);
                Console.WriteLine("Tipo de Exception: " + ex.GetType().ToString());
            }
            finally
            {
                accesoDatos.CerrarConexion();
            }
            return listaHeroes;
        }
        
        //En lugar de listar los objetos como la forma anterior, vamos a hacerlo mediante un Stored Procedure.
        public List<Superheroe> ListarSP()
        {
            AccesoDatosClass accesoDatos = new AccesoDatosClass();
            List<Superheroe> listaHeroes = new List<Superheroe>();
            try
            {
                //Aplicando el seteo con Stored Procedure:
                accesoDatos.SetearProcedimiento("SPListar");
                accesoDatos.EjecutarConsulta();
                accesoDatos.Lector = accesoDatos.Comando.ExecuteReader();
                while (accesoDatos.Lector.Read())
                {
                    Superheroe heroeRegistro = new Superheroe((int)accesoDatos.Lector["id"], (string)accesoDatos.Lector["alias"], (string)accesoDatos.Lector["nombre"], (string)accesoDatos.Lector["apellido"], (int)accesoDatos.Lector["edad"], (string)accesoDatos.Lector["universo"]);
                    //El '!' invierte la condición: Si accesoDatos.Lector["url"] NO devuelve una exception DBNull, significa que se le puede asignar al objeto heroeRegistro.
                    if (!(accesoDatos.Lector["poder"] is DBNull))
                    {
                        heroeRegistro.Poder = (string)accesoDatos.Lector["poder"];
                    }
                    if (!(accesoDatos.Lector["url"] is DBNull))
                    {
                        heroeRegistro.Url = (string)accesoDatos.Lector["url"];
                    }
                    listaHeroes.Add(heroeRegistro);
                }
                return listaHeroes;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error - Exception: " + ex.Message);
                Console.WriteLine("Tipo de Exception: " + ex.GetType().ToString());
            }
            finally
            {
                accesoDatos.CerrarConexion();
            }
            return listaHeroes;
        }
    }
}
