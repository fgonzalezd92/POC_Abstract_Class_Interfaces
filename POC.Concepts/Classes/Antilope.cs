using POC.Concepts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Concepts.Classes
{
    public class Antilope : Animal, ICaminar
    {
        public Antilope()
        {
            Patas = 4;
            NombreCientifico = "Antilope cervicapra";
        }
        public string Caminar() => $"Yo {GetType().Name} puedo caminar con mis {Patas} patas";

        public override string Comer()
        {
            return "Come hierba.";
        }
        public override string DameNombreCientifico()
        {
            return this.GetNombreCientifico();
        }
    }
}
