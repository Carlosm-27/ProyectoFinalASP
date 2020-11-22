using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalASP.Models
{
    public class Usuario
    {


        public int id { get; set; }
        public string contraseña { get; set; }
        public string nombreUsuario { get; set; }

        public string nombre { get; set; }
        public string apellido { get; set; }
        public int telefono { get; set; }
        public string email { get; set; }
        public int id_rol { get; set; }


        /*public class UsuarioDbContext : DbContext { 
            
            public Dbset<Usuario> usuario { get; set; }
        
        }*/

    }
}