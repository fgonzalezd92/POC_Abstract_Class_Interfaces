using POC.Concepts.Classes;
using System;
using System.Collections.Generic;

namespace POC.Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            var aguila = new Aguila();
            var antilope = new Antilope();
            var coco = new Cocodrilo();
            var leon = new Leon();
            var tibu = new Tiburon();
            List<Animal> Animales = new()
            {
                aguila,
                antilope,
                coco,
                leon,
                tibu
            };

            Console.WriteLine(aguila.Caminar());
            Console.WriteLine(aguila.Volar());
            Console.WriteLine(antilope.Caminar());
            Console.WriteLine(coco.Caminar());
            Console.WriteLine(coco.Nadar());
            Console.WriteLine(leon.Caminar());
            Console.WriteLine(tibu.Nadar());



            foreach (var item in Animales)
            {
                Console.WriteLine(item.DameNombreCientifico());
                Console.WriteLine(item.Comer());
            }
           
        }
    }
}
