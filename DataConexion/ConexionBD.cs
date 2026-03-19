using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConexion
{
    //Herencia de la clase DataConnection del paquete Linq2db
    public class ConexionBD : DataConnection
    {
        //Constructor 
        public ConexionBD() : base("ConexionSQL") { }

        //Creamos la interfaz 
        ITable<TblDetalleCitas> Citas { get; set; }
        ITable<TblDetalleMedico> Medicos { get; set; }
        ITable<TblDetallesPaciente> Pacientes { get; set; }

    }
}
