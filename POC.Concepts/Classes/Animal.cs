using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Concepts.Classes
{
    public abstract class Animal
    {
        public Animal()
        {
            Patas = 0;
            NombreCientifico = string.Empty;
        }
        protected int Patas {get; set;}
        public string NombreCientifico {get; set; }
        public abstract string Comer();
        public abstract string DameNombreCientifico();
    }
}
