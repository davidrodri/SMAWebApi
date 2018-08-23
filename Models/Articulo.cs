using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMAWebApi.Models
{
    public class Articulo
    {
        public string ArticuloID { get; set; }
        public string NombreArticulo { get; set; }
        public string CodigoBarra { get; set; }
        //public double PrecioCosto { get; set; }
        //public double PrecioVenta { get; set; }
    }
}
