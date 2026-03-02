using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataConexion
{
    public class InsercionDatos
    {
        //Operaciones CRUD
        //crearemos una funcion para insercion de registros
        public void InsercionContacto(TblDetallesPaciente paciente)
        {
            //consulta a la BD
            string query = $"INSERT INTO TblDetallesPaciente(nombre,aPterno,aMaterno,edad,sexo,telefono,direccion,correo) "
                + $"VALUES('{paciente.Nombre}','{paciente.ApellidoPaterno}','{paciente.ApellidoMaterno}','{paciente.Edad}','{paciente.Sexo}','{paciente.Telefono}','{paciente.Direccion}','{paciente.Correo}')";

            //ejecutariamos la consulta del query SQL
            MessageBox.Show("El registro se ingreso de manera correcta a la base de datos.");
        }

        public void InsercionMedico(TblDetalleMedico medico)
        {
            //consulta a la BD
            string query = $"INSERT INTO TblDetalleMedico(Id,nombre,aPterno,aMaterno,edad,sexo,telefono,correo,especialidad,horario) "
                + $"VALUES('{medico.IDMedico}','{medico.Nombre}','{medico.ApellidoPaterno}','{medico.ApellidoMaterno}','{medico.Edad}','{medico.Sexo}','{medico.Telefono}','{medico.Correo}','{medico.Especialidad}','{medico.Horario}')";
            //ejecutariamos la consulta del query SQL
            MessageBox.Show("El registro se ingreso de manera correcta a la base de datos.");
        }

        public void InsercionCitas(TblDetalleCitas cita)
        {
            //consulta a la BD
            string query = $"INSERT INTO TblDetalleCitas(IdCita,nombrePaciente,nombreMedico,fecha,hora,motivo) "
                + $"VALUES('{cita.IDCita}','{cita.NombrePaciente}','{cita.NombreMedico}','{cita.Fecha}','{cita.Hora}','{cita.Motivo}')";
        }
    }
}
