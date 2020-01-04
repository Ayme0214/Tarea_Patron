using System;
using System.Collections.Generic;
using System.Text;
using PatronObserver1.Interfaces;
using PatronObserver1.Clases;

namespace PatronObserver1.Clases
{
    /*Clase abstracta de participante (Sujeto)
     *se implementan métodos para adjuntar o separar observadores
     *y realizar el seguimiento del precio actual de las verduras
     */

    abstract class Verduras
    {
        private double PrecioLibra;
        List<IRestaurante> restaurantes = new List<IRestaurante>();

        public Verduras (double precioLibras)
        {
            PrecioLibras = precioLibras;
        }
        public void Attach (IRestaurante restaurante)
        {
            restaurantes.Add(restaurante);
        }
        public void Detach (IRestaurante restaurante)
        {
            restaurantes.Remove(restaurante);
        }
        public void Notificar()
        {
            foreach (IRestaurante restaurante in restaurantes)
            {
                restaurante.Update(this);
            }
            Console.WriteLine("");
        }
        public double PrecioLibras
        {
            get { return PrecioLibra; }
            set
            {
                if (PrecioLibra != value)
                {
                    PrecioLibra = value;
                    Notificar(); //  Notificación automática sobre cambios de precios a nuestros observadores 
                }
            }
        }
    }
}
