using POC.Concepts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Concepts.Classes
{
    public class Tiburon : Animal, INadar
    {
        public Tiburon()
        {
            NombreCientifico = "Carcharodon carcharias";
        }

        public override string Comer()
        {
            return "Come pescado";
        }

        public override string DameNombreCientifico()
        {
            return this.GetNombreCientifico();
        }

        public string Nadar()
        {
            return $"Yo {GetType().Name} nado con mis aletas.";
        }
    }

    public static class AnimalExtension
    {
        public static string GetNombreCientifico(this Animal animal)
        {
            return $"Mi nombre cientifico es: {animal.NombreCientifico}";
        }
    }
}

