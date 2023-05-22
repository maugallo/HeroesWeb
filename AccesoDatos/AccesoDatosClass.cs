using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoDatosClass
    {
        private SqlConnection _conexion;
        private SqlDataReader _lector;
        private SqlCommand _comando;

        public AccesoDatosClass()
        {
            Conexion = new SqlConnection("Data Source=LAPTOP-NHMAE4TA; Initial Catalog=SuperheroeDB; Integrated Security=True");
            Comando = new SqlCommand();
        }

        public SqlConnection Conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
        }

        public SqlDataReader Lector
        {
            get { return _lector; }
            set { _lector = value; }
        }

        public SqlCommand Comando
        {
            get { return _comando; }
            set { _comando = value; }
        }

        public void SetearConsulta(string consulta)
        {
            //Primero indico al SqlCommand que la consulta que se hará será de tipo string:
            Comando.CommandType = System.Data.CommandType.Text;
            //Luego seteo la consulta que se ingresó por parámetro: 
            Comando.CommandText = consulta;
        }

        public void SetearProcedimiento(string sp)
        {
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.CommandText = sp;
        }

        public void EjecutarConsulta()
        {
            //Establezco la conexión entre el objeto SqlCommand (Comando) y la base de datos mediante el objeto SqlConnection:
            Comando.Connection = Conexion;
            //Una vez establecida, abro la conexión:
            try
            {
                Conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Algo salió mal al abrir la conexión.");
                Console.WriteLine(ex.Message);
            }
            //Y ejecuto la consulta hecha previamente en el método SetearConsulta(string consulta):
            Comando.ExecuteNonQuery();
        }

        public void CerrarConexion()
        {
            if (Lector != null)
                Lector.Close();
            if (Comando != null)
                Comando.Dispose();
            Conexion.Close();
        }
    }
}
