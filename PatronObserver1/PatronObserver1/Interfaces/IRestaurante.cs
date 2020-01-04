using System;
using System.Collections.Generic;
using System.Text;
using PatronObserver1.Clases;


namespace PatronObserver1.Interfaces
{
    /*Este será nuesttro Observador,
     * como los restaurantes desean observar los precios de las verduras,
     * el Observador será de tipo interfaz, la cual debe definir
     * un método el cual permita actualizar sus implementadores
     */
     
    interface IRestaurante
    {
        void Update(Verduras verduras);
    }
}
