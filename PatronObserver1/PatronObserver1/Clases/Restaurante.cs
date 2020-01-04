using System;
using System.Collections.Generic;
using System.Text;
using PatronObserver1.Interfaces;

namespace PatronObserver1.Clases
{
    /*Esta será la clase ConcreteObserver 
     * la cual representa los restaurantes específicos.
     *Se implementa el Update() de la interfaz Restaurante
     */
    class Restaurante: IRestaurante
    {
        private string Nombre;
        private double UmbralCompras;
        
        public Restaurante(string nombre, double umbralCompras)
        {
            Nombre = nombre;
            UmbralCompras = umbralCompras;
        }
        public void Update (Verduras verduras)
        {
            Console.WriteLine ("Noticado {0} de {1}'s" + " cambio de precio a {2:C} por libra." , Nombre, verduras.GetType().Name, verduras.PrecioLibras);
            if (verduras.PrecioLibras < UmbralCompras)
            {
                Console.WriteLine(Nombre + " quiere comprar " + verduras.GetType().Name + " ! ");
            }
        }
    }
}
