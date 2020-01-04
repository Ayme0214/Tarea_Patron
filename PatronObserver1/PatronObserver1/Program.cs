using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronObserver1.Clases;
using PatronObserver1.Interfaces;

namespace PatronObserver1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crea una vista de los precios de las zanahorias y se adjuntan los restaurantes que compran las zanahorias
            Zanahorias zanahorias = new Zanahorias(0.50);
            zanahorias.Attach(new Restaurante("KFC", 0.70));
            zanahorias.Attach(new Restaurante("Mc Donald's", 0.75));
            zanahorias.Attach(new Restaurante("Carl's Junior", 0.80));

            //Precios fluctuantes de las zanahorias para notificar a los restaurantes
            zanahorias.PrecioLibras = 0.76;
            zanahorias.PrecioLibras = 0.66;
            zanahorias.PrecioLibras = 0.86;
            zanahorias.PrecioLibras = 0.78;

            Console.ReadKey();
        }
    }
}