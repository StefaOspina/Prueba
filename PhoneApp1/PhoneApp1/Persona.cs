using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp1
{
    public class Persona
    {
        private int _codigo;

        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
