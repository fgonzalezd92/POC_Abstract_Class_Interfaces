using POC.Concepts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Concepts.Classes
{
    public class Leon : Animal, ICaminar
    {
        public Leon()
        {
            Patas = 4;
            NombreCientifico = "Panthera leo";
        }
        public string Caminar() => $"Yo {GetType().Name} puedo caminar con mis {Patas} patas";

        public override string Comer()
        {
            return "Come carne.";
        }
        public override string DameNombreCientifico()
        {
            return this.GetNombreCientifico();
        }
    }
}
