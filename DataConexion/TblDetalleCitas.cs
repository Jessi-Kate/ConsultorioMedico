using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConexion
{
    public class TblDetalleCitas
    {
        public int IDCita { get; set; }
        public string NombrePaciente { get; set; }
        public string NombreMedico { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Motivo { get; set; }


    }
}
