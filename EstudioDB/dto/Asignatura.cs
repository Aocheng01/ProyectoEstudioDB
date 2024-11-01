using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioDB.dto
{
    internal class Asignatura
    {
        public int asignaturaID { get; set; }
        public string nombreAsignaura { get; set; }


        public Asignatura(int asignaturaID,string nombreAsignaura)
        {
            this.asignaturaID = asignaturaID;
            this.nombreAsignaura = nombreAsignaura;
        }
    }

    


}
