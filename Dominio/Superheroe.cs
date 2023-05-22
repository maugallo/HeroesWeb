using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Superheroe
    {
        private int _id;
        private string _alias;
        private string _nombre;
        private string _apellido;
        private int _edad;
        private string _poder;
        private string _universo;
        private string _url;

        public Superheroe()
        {

        }
        public Superheroe(int id, string alias, string nombre, string apellido, int edad, string universo)
        {
            Id = id;
            Alias = alias;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Universo = universo;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        public string Poder
        {
            get { return _poder; }
            set { _poder = value; }
        }
        public string Universo
        {
            get { return _universo; }
            set { _universo = value; }
        }
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
    }
}
