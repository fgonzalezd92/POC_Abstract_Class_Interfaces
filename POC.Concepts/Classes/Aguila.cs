using POC.Concepts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Concepts.Classes
{
    public class Aguila : Animal, ICaminar, IVolar
    {
        public Aguila()
        {
            Patas = 2;
            NombreCientifico = "Aquila chrysaetos";
        }
        public override string DameNombreCientifico()
        {
            return this.GetNombreCientifico();
        }
        public string Caminar()
        {
            return $"Yo {GetType().Name} puedo caminar con mis {Patas} patas aunque casí no camino.";
        }

        public override string Comer() => "Come carne";

        public string Volar()
        {
            return $"Yo {GetType().Name} puedo volar con mis alas.";
        }
    }
}
