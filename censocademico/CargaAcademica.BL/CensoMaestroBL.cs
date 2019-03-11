using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaAcademica.BL
{
    public class CensoMaestroBL
    {
        Contexto _Contexto;
        public List<CensoDetalle> CensosDetalles { get; set; }

        public CensoMaestroBL()
        {
            _Contexto = new Contexto();
            CensosDetalles = new List<CensoDetalle>();
        }

        public List<CensoDetalle> ObtenerCensoDetalle()
        {
            CensosDetalles = _Contexto.CensosDetalles.Include("Alumnos").ToList();//para traer la tabla Alumnos

            return CensosDetalles;
        }
    }
}
