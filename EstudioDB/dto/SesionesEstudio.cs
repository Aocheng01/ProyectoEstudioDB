using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioDB.dto
{
    internal class SesionesEstudio
    {
        public int sesionID { get; set; }
        public int asignaturaID { get; set; }
        public int usuarioID { get; set; }
        public int duracion { get; set; }
        public DateTime fecha { get; set; }

        public SesionesEstudio(int sesionID, int asignaturaID, int usuarioID, int duracion, DateTime fecha)
        {
            this.sesionID = sesionID;
            this.asignaturaID = asignaturaID;
            this.usuarioID = usuarioID;
            this.duracion = duracion;
            this.fecha = fecha;
        }
    }


    
}
