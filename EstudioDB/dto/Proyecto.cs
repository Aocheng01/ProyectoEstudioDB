using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioDB.dto
{
    internal class Proyecto
    {
        public int ProyectoId { get; set; }
        public string NombreProyecto { get; set; }


        public Proyecto(int proyectoID,string nombreProyecto)
        {
            this.ProyectoId = proyectoID;
            this.NombreProyecto = nombreProyecto;
        }
    }

    


}
