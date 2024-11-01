using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioDB.dto
{
    internal class Usuario
    {
        public int usuarioID { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }

        public Usuario(int usuarioID, string nombreUsuario, string contraseña)
        {
            this.usuarioID = usuarioID;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
        }
    }
}
