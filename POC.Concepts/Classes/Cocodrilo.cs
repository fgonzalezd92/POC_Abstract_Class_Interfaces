using POC.Concepts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Concepts.Classes
{
    public class Cocodrilo : Animal, ICaminar, INadar
    {
        public Cocodrilo()
        {
            Patas = 4;
            NombreCientifico = "Crocodylus niloticus";
        }
        public string Caminar()
        {
            return $"Yo {GetType().Name} puedo caminar con mis {Patas} patas";
        }

        public override string Comer()
        {
            return "Come carne.";
        }

        public string Nadar()
        {
            return $"Yo {GetType().Name} puedo nadar usando mi cola.";
        }
        public override string DameNombreCientifico()
        {
            return this.GetNombreCientifico();
        }
    }
}
