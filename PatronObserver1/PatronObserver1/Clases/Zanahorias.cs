using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObserver1.Clases
{
    /*Esta clase será el ConcreteSubject
     * la cual representará el precio de un vegetan específico
     * en este caso la zanahoria
     */
     
    class Zanahorias: Verduras
    {
        public Zanahorias(double precio): base(precio)
        {
        }
    }
}
