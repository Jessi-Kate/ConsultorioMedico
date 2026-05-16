using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConexion
{
    public class TblDetalleCitas
    {
        [PrimaryKey]
        public string IDCita { get; set; }
        public string NombrePaciente { get; set; }
        public string NombreMedico { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Motivo { get; set; }


    }
}
